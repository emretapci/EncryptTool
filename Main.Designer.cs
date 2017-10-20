namespace Encrypt
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.logoPicture = new System.Windows.Forms.PictureBox();
			this.passwordPanel = new System.Windows.Forms.Panel();
			this.demoHintLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.passwordTextbox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.separatorPanel = new System.Windows.Forms.Panel();
			this.encDecPanel = new System.Windows.Forms.Panel();
			this.processingAnimation = new System.Windows.Forms.PictureBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dragDropHereLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
			this.passwordPanel.SuspendLayout();
			this.encDecPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.processingAnimation)).BeginInit();
			this.panel10.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoPicture
			// 
			this.logoPicture.Dock = System.Windows.Forms.DockStyle.Top;
			this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
			this.logoPicture.Location = new System.Drawing.Point(0, 0);
			this.logoPicture.Name = "logoPicture";
			this.logoPicture.Size = new System.Drawing.Size(464, 149);
			this.logoPicture.TabIndex = 0;
			this.logoPicture.TabStop = false;
			// 
			// passwordPanel
			// 
			this.passwordPanel.Controls.Add(this.demoHintLabel);
			this.passwordPanel.Controls.Add(this.okButton);
			this.passwordPanel.Controls.Add(this.passwordTextbox);
			this.passwordPanel.Controls.Add(this.passwordLabel);
			this.passwordPanel.Controls.Add(this.separatorPanel);
			this.passwordPanel.Controls.Add(this.logoPicture);
			this.passwordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.passwordPanel.Location = new System.Drawing.Point(0, 0);
			this.passwordPanel.Name = "passwordPanel";
			this.passwordPanel.Size = new System.Drawing.Size(464, 174);
			this.passwordPanel.TabIndex = 1;
			// 
			// demoHintLabel
			// 
			this.demoHintLabel.AutoSize = true;
			this.demoHintLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.demoHintLabel.ForeColor = System.Drawing.Color.Red;
			this.demoHintLabel.Location = new System.Drawing.Point(264, 9);
			this.demoHintLabel.Name = "demoHintLabel";
			this.demoHintLabel.Size = new System.Drawing.Size(189, 22);
			this.demoHintLabel.TabIndex = 3;
			this.demoHintLabel.Text = "demo password: 123";
			// 
			// okButton
			// 
			this.okButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.okButton.Location = new System.Drawing.Point(339, 150);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(113, 23);
			this.okButton.TabIndex = 2;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// passwordTextbox
			// 
			this.passwordTextbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.passwordTextbox.Location = new System.Drawing.Point(108, 151);
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.PasswordChar = '*';
			this.passwordTextbox.Size = new System.Drawing.Size(218, 22);
			this.passwordTextbox.TabIndex = 1;
			this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextbox_KeyDown);
			// 
			// passwordLabel
			// 
			this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.passwordLabel.Location = new System.Drawing.Point(0, 150);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(102, 24);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "Password";
			this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// separatorPanel
			// 
			this.separatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.separatorPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.separatorPanel.Location = new System.Drawing.Point(0, 149);
			this.separatorPanel.Name = "separatorPanel";
			this.separatorPanel.Size = new System.Drawing.Size(464, 1);
			this.separatorPanel.TabIndex = 1;
			// 
			// encDecPanel
			// 
			this.encDecPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
			this.encDecPanel.Controls.Add(this.processingAnimation);
			this.encDecPanel.Controls.Add(this.panel9);
			this.encDecPanel.Controls.Add(this.panel10);
			this.encDecPanel.Controls.Add(this.panel6);
			this.encDecPanel.Controls.Add(this.panel7);
			this.encDecPanel.Controls.Add(this.panel3);
			this.encDecPanel.Controls.Add(this.panel4);
			this.encDecPanel.Controls.Add(this.panel2);
			this.encDecPanel.Controls.Add(this.panel1);
			this.encDecPanel.Controls.Add(this.dragDropHereLabel);
			this.encDecPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.encDecPanel.Location = new System.Drawing.Point(0, 0);
			this.encDecPanel.Name = "encDecPanel";
			this.encDecPanel.Size = new System.Drawing.Size(464, 174);
			this.encDecPanel.TabIndex = 3;
			this.encDecPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.encDecPanel_DragDrop);
			this.encDecPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.encDecPanel_DragEnter);
			// 
			// processingAnimation
			// 
			this.processingAnimation.Image = global::Encrypt.Properties.Resources.anim;
			this.processingAnimation.Location = new System.Drawing.Point(154, 7);
			this.processingAnimation.Name = "processingAnimation";
			this.processingAnimation.Size = new System.Drawing.Size(156, 158);
			this.processingAnimation.TabIndex = 10;
			this.processingAnimation.TabStop = false;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Yellow;
			this.panel9.Location = new System.Drawing.Point(445, 4);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(15, 4);
			this.panel9.TabIndex = 9;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Yellow;
			this.panel10.Controls.Add(this.panel11);
			this.panel10.Location = new System.Drawing.Point(456, 4);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(4, 15);
			this.panel10.TabIndex = 8;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Yellow;
			this.panel11.Location = new System.Drawing.Point(0, 11);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(15, 4);
			this.panel11.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Yellow;
			this.panel6.Location = new System.Drawing.Point(445, 165);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(15, 4);
			this.panel6.TabIndex = 7;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Yellow;
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Location = new System.Drawing.Point(456, 154);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(4, 15);
			this.panel7.TabIndex = 6;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Yellow;
			this.panel8.Location = new System.Drawing.Point(0, 11);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(15, 4);
			this.panel8.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Yellow;
			this.panel3.Location = new System.Drawing.Point(4, 165);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(15, 4);
			this.panel3.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Yellow;
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(4, 154);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(4, 15);
			this.panel4.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Yellow;
			this.panel5.Location = new System.Drawing.Point(0, 11);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(15, 4);
			this.panel5.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Yellow;
			this.panel2.Location = new System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(15, 4);
			this.panel2.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Yellow;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(4, 15);
			this.panel1.TabIndex = 2;
			// 
			// dragDropHereLabel
			// 
			this.dragDropHereLabel.AutoSize = true;
			this.dragDropHereLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dragDropHereLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.dragDropHereLabel.Location = new System.Drawing.Point(24, 59);
			this.dragDropHereLabel.Name = "dragDropHereLabel";
			this.dragDropHereLabel.Size = new System.Drawing.Size(298, 24);
			this.dragDropHereLabel.TabIndex = 0;
			this.dragDropHereLabel.Text = "drop here to encrypt or decrypt";
			this.dragDropHereLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 174);
			this.Controls.Add(this.passwordPanel);
			this.Controls.Add(this.encDecPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Encrypt/Decrypt";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
			this.passwordPanel.ResumeLayout(false);
			this.passwordPanel.PerformLayout();
			this.encDecPanel.ResumeLayout(false);
			this.encDecPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.processingAnimation)).EndInit();
			this.panel10.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPicture;
		private System.Windows.Forms.Panel passwordPanel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox passwordTextbox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Panel separatorPanel;
		private System.Windows.Forms.Panel encDecPanel;
		private System.Windows.Forms.Label dragDropHereLabel;
		private System.Windows.Forms.Label demoHintLabel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.PictureBox processingAnimation;
	}
}

