using Encrypt.Properties;
using System;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Encrypt
{
	public partial class Main : Form
	{
		private bool processing;
		private long processedSizeTotal;
		private long totalSize;
		//private bool ctrlPressed, altPressed;
		//private int hotkeyIndex;
		private string password;
		private UserActivityMonitor.GlobalEventProvider globalEventProvider;
		private SHA256 hasher = SHA256.Create();

		public Main()
		{
			InitializeComponent();
			this.globalEventProvider = new Encrypt.UserActivityMonitor.GlobalEventProvider();
			//this.globalEventProvider.KeyUp += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyUp);
			//this.globalEventProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyDown);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			AllowDrop = true;
			encDecPanel.AllowDrop = true;
			processing = false;
			EncDec.Processed += EncDec_Processed;
			//WindowState = FormWindowState.Minimized;
			//ShowInTaskbar = false;

			SetUiEncDec(false);

			if (Resources.DemoVersion == "true")
			{
				passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
			}

			password = string.Empty;

			dragDropHereLabel.Location = new Point((encDecPanel.Size.Width - dragDropHereLabel.Size.Width) / 2,
				(encDecPanel.Size.Height - dragDropHereLabel.Size.Height) / 2);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			var hash = Convert.ToBase64String(hasher.ComputeHash(Encoding.Unicode.GetBytes(passwordTextbox.Text)));
			hash = Convert.ToBase64String(hasher.ComputeHash(Encoding.Unicode.GetBytes(hash)));

			if (hash == Resources.PasswordHash)
			{
				SetUiEncDec(true);
			}
			else
			{
				Vibrate(okButton);
				passwordTextbox.Text = "";
				passwordTextbox.Focus();
			}
		}

		private void SetUiEncDec(bool encDecPanelVisible)
		{
			if (encDecPanelVisible)
			{
				logoPanel.Visible =
				animationPicture.Visible =
				passwordPanel.Visible = false;
				encDecPanel.Visible = true;

				panel1.Location = new Point(4, 4);
				panel2.Location = new Point(4, 4);
				panel9.Location = new Point(encDecPanel.Width - 19, 4);
				panel10.Location = new Point(encDecPanel.Width - 8, 4);
				panel4.Location = new Point(4, encDecPanel.Height - 22);
				panel3.Location = new Point(4, encDecPanel.Height - 11);
				panel6.Location = new Point(encDecPanel.Width - 19, encDecPanel.Height - 11);
				panel7.Location = new Point(encDecPanel.Width - 8, encDecPanel.Height - 22);
				dragDropHereLabel.Location = new Point((encDecPanel.Size.Width - dragDropHereLabel.Size.Width) / 2,
					(encDecPanel.Size.Height - dragDropHereLabel.Size.Height) / 2);
			}
			else
			{
				logoPanel.Visible = true;
				passwordPanel.Visible =
				demoLabel1.Visible =
				demoLabel2.Visible =
					(Resources.DemoVersion == "true");
				animationPicture.Visible = true;
				encDecPanel.Visible = false;
			}

			Height = Math.Max((logoPanel.Visible ? logoPanel.Height : 0) +
				(animationPicture.Visible ? animationPicture.Height : 0) +
				(passwordPanel.Visible ? passwordPanel.Height : 0),
				encDecPanel.Height) +
				26;

			SetProcessing(false);
		}

		private void Vibrate(Control control)
		{
			control.Location = new Point(control.Location.X - 3, control.Location.Y);
			for (int i = 0; i < 5; i++)
			{
				control.Location = new Point(control.Location.X + 6, control.Location.Y);
				Thread.Sleep(30);
				control.Location = new Point(control.Location.X - 6, control.Location.Y);
				Thread.Sleep(30);
			}
			control.Location = new Point(control.Location.X + 3, control.Location.Y);
		}

		private void encDecPanel_DragDrop(object sender, DragEventArgs e)
		{
			if (processing)
			{
				return;
			}

			ThreadPool.QueueUserWorkItem((obj) =>
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
				totalSize = GetTotalSize(files);
				processedSizeTotal = 0;

				if (Resources.DemoVersion == "true")
				{
					if (totalSize > 10000000)
					{
						MessageBox.Show("Cannot process files or folders larger than 10 mb in demo mode.");
						return;
					}
				}

				SetProcessing(true);

				foreach (string inputFile in files)
				{
					bool encrypt = !inputFile.EndsWith(".enc");
					string outputFile = inputFile;
					if (encrypt)
					{
						outputFile += ".enc";
					}
					else
					{
						outputFile = outputFile.Substring(0, outputFile.Length - 4);
					}

					var key = Convert.ToBase64String(hasher.ComputeHash(Encoding.Unicode.GetBytes(passwordTextbox.Text)));
					Encrypt(inputFile, outputFile, key, encrypt);
				}

				Thread.Sleep(700);
				SetProcessing(false);
			});
		}

		private long GetTotalSize(string[] files)
		{
			return files.Sum(file =>
			{
				var attr = File.GetAttributes(file);
				bool directory = ((attr & FileAttributes.Directory) == FileAttributes.Directory);
				if (directory)
				{
					return GetTotalSize(GetFilesAndDirs(file));
				}
				else
				{
					return new FileInfo(file).Length;
				}
			});
		}

		private string[] GetFilesAndDirs(string path)
		{
			return Directory.GetFiles(path).Union(Directory.GetDirectories(path)).ToArray();
		}

		private void encDecPanel_DragEnter(object sender, DragEventArgs e)
		{
			if (!processing && e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
				return;
			}

			e.Effect = DragDropEffects.None;
		}

		private void Encrypt(string inputFile, string outputFile, string key, bool encrypt)
		{
			var attr = File.GetAttributes(inputFile);
			bool directory = ((attr & FileAttributes.Directory) == FileAttributes.Directory);
			if (directory)
			{
				EncryptDirectory(inputFile, outputFile, key, encrypt);
				try
				{
					Directory.Delete(inputFile, true);
				}
				catch
				{
				}
			}
			else
			{
				EncryptFile((CipherAlgorithm)Enum.Parse(typeof(CipherAlgorithm), Resources.CipherAlgorithm), inputFile, outputFile, key, encrypt);
				try
				{
					File.Delete(inputFile);
				}
				catch
				{
				}
			}
		}

		private void EncryptDirectory(string inputFile, string outputFile, string key, bool encrypt)
		{
			Directory.CreateDirectory(outputFile);

			foreach (string file in GetFilesAndDirs(inputFile).Select(file2 => Path.GetFileName(file2)))
			{
				Encrypt(inputFile + "\\" + file, outputFile + "\\" + file, key, encrypt);
			}
		}

		private void EncryptFile(CipherAlgorithm ca, string inputFile, string outputFile, string key, bool encrypt)
		{
			EncDec.EncryptOrDecrypt(ca, inputFile, outputFile, key, encrypt);
		}

		private void EncDec_Processed(int processedSize)
		{
			processedSizeTotal += processedSize;

			/*processedProgressBar.Invoke(new Action(() =>
			{
				processedProgressBar.Value = (int)((double)processedSizeTotal / totalSize * 600);
			}));*/
		}

		private void SetProcessing(bool processing)
		{
			this.processing = processing;

			encDecPanel.Invoke(new Action(() =>
			{
				if (processing)
				{
					dragDropHereLabel.Visible = false;
					//processedProgressBar.Visible = true;
					processingAnimation.Visible = true;
				}
				else
				{
					dragDropHereLabel.Visible = true;
					//processedProgressBar.Visible = false;
					processingAnimation.Visible = false;
				}
			}));
		}

		private void passwordTextbox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				okButton_Click(sender, e);
			}
		}

		private void passwordTextbox_TextChanged(object sender, EventArgs e)
		{
			var hash = Convert.ToBase64String(hasher.ComputeHash(Encoding.Unicode.GetBytes(passwordTextbox.Text)));
			hash = Convert.ToBase64String(hasher.ComputeHash(Encoding.Unicode.GetBytes(hash)));
			if (hash == Resources.PasswordHash)
			{
				SetUiEncDec(true);
			}
		}

		/*private void globalEventProvider_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey)
			{
				ctrlPressed = true;
			}

			if(altPressed = altPressed || e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu)
			{
				altPressed = true;
			}

			if (ctrlPressed && altPressed)
			{
				if(e.KeyCode == (Keys)Resources.HotkeySequence[hotkeyIndex])
				{
					hotkeyIndex++;
				}
			}

			if(hotkeyIndex == Resources.HotkeySequence.Length)
			{
				hotkeyIndex = 0;
				WindowState = FormWindowState.Normal;
				ShowInTaskbar = true;
				e.Handled = true;
			}
		}*/

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageBox.Show("Per una maggiore sicurezza si consiglia di rimuovere la chiave usb dopo la chiusura del programma",
				"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//WindowState = FormWindowState.Minimized;
			//ShowInTaskbar = false;
			EncDec.Cancel();
			//e.Cancel = true;
		}

		/*private void globalEventProvider_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey)
			{
				ctrlPressed = false;
				hotkeyIndex = 0;
			}

			if (e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu)
			{
				altPressed = false;
				hotkeyIndex = 0;
			}
		}*/

		private void Main_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)27)
			{
				password = string.Empty;
				return;
			}

			password += e.KeyChar;

			passwordTextbox.Text = password;
			passwordTextbox_TextChanged(passwordTextbox, null);
		}
	}
}
