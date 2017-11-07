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
			this.logoPanel = new System.Windows.Forms.Panel();
			this.demoLabel2 = new System.Windows.Forms.Label();
			this.demoLabel1 = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.passwordTextbox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.animationPicture = new System.Windows.Forms.PictureBox();
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
			this.passwordPanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
			this.logoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.animationPicture)).BeginInit();
			this.encDecPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.processingAnimation)).BeginInit();
			this.panel10.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.passwordPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoPicture
			// 
			resources.ApplyResources(this.logoPicture, "logoPicture");
			this.logoPicture.Image = global::Encrypt.Properties.Resources.logo;
			this.logoPicture.Name = "logoPicture";
			this.logoPicture.TabStop = false;
			// 
			// logoPanel
			// 
			this.logoPanel.Controls.Add(this.demoLabel2);
			this.logoPanel.Controls.Add(this.demoLabel1);
			this.logoPanel.Controls.Add(this.logoPicture);
			resources.ApplyResources(this.logoPanel, "logoPanel");
			this.logoPanel.Name = "logoPanel";
			// 
			// demoLabel2
			// 
			resources.ApplyResources(this.demoLabel2, "demoLabel2");
			this.demoLabel2.ForeColor = System.Drawing.Color.Red;
			this.demoLabel2.Name = "demoLabel2";
			// 
			// demoLabel1
			// 
			resources.ApplyResources(this.demoLabel1, "demoLabel1");
			this.demoLabel1.ForeColor = System.Drawing.Color.Red;
			this.demoLabel1.Name = "demoLabel1";
			// 
			// okButton
			// 
			resources.ApplyResources(this.okButton, "okButton");
			this.okButton.Name = "okButton";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// passwordTextbox
			// 
			resources.ApplyResources(this.passwordTextbox, "passwordTextbox");
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextbox_KeyDown);
			// 
			// passwordLabel
			// 
			resources.ApplyResources(this.passwordLabel, "passwordLabel");
			this.passwordLabel.Name = "passwordLabel";
			// 
			// animationPicture
			// 
			resources.ApplyResources(this.animationPicture, "animationPicture");
			this.animationPicture.Image = global::Encrypt.Properties.Resources.anim2;
			this.animationPicture.Name = "animationPicture";
			this.animationPicture.TabStop = false;
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
			resources.ApplyResources(this.encDecPanel, "encDecPanel");
			this.encDecPanel.Name = "encDecPanel";
			this.encDecPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.encDecPanel_DragDrop);
			this.encDecPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.encDecPanel_DragEnter);
			// 
			// processingAnimation
			// 
			this.processingAnimation.Image = global::Encrypt.Properties.Resources.anim;
			resources.ApplyResources(this.processingAnimation, "processingAnimation");
			this.processingAnimation.Name = "processingAnimation";
			this.processingAnimation.TabStop = false;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel9, "panel9");
			this.panel9.Name = "panel9";
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Yellow;
			this.panel10.Controls.Add(this.panel11);
			resources.ApplyResources(this.panel10, "panel10");
			this.panel10.Name = "panel10";
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel11, "panel11");
			this.panel11.Name = "panel11";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel6, "panel6");
			this.panel6.Name = "panel6";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Yellow;
			this.panel7.Controls.Add(this.panel8);
			resources.ApplyResources(this.panel7, "panel7");
			this.panel7.Name = "panel7";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel8, "panel8");
			this.panel8.Name = "panel8";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Yellow;
			this.panel4.Controls.Add(this.panel5);
			resources.ApplyResources(this.panel4, "panel4");
			this.panel4.Name = "panel4";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel5, "panel5");
			this.panel5.Name = "panel5";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Yellow;
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// dragDropHereLabel
			// 
			resources.ApplyResources(this.dragDropHereLabel, "dragDropHereLabel");
			this.dragDropHereLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.dragDropHereLabel.Name = "dragDropHereLabel";
			// 
			// passwordPanel
			// 
			this.passwordPanel.Controls.Add(this.passwordLabel);
			this.passwordPanel.Controls.Add(this.passwordTextbox);
			this.passwordPanel.Controls.Add(this.okButton);
			resources.ApplyResources(this.passwordPanel, "passwordPanel");
			this.passwordPanel.Name = "passwordPanel";
			// 
			// Main
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.encDecPanel);
			this.Controls.Add(this.passwordPanel);
			this.Controls.Add(this.animationPicture);
			this.Controls.Add(this.logoPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
			this.logoPanel.ResumeLayout(false);
			this.logoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.animationPicture)).EndInit();
			this.encDecPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.processingAnimation)).EndInit();
			this.panel10.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.passwordPanel.ResumeLayout(false);
			this.passwordPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPicture;
		private System.Windows.Forms.Panel logoPanel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox passwordTextbox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Panel encDecPanel;
		private System.Windows.Forms.Label dragDropHereLabel;
		private System.Windows.Forms.Label demoLabel1;
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
        private System.Windows.Forms.Label demoLabel2;
        private System.Windows.Forms.PictureBox animationPicture;
		private System.Windows.Forms.Panel passwordPanel;
	}
}

