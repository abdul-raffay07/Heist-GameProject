namespace Heist
{
	partial class BankHeistGamePlay
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
			this.components = new System.ComponentModel.Container();
			this.movetime = new System.Windows.Forms.Timer(this.components);
			this.HealthBar = new System.Windows.Forms.ProgressBar();
			this.txtAmmo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Avater = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Avater)).BeginInit();
			this.SuspendLayout();
			// 
			// movetime
			// 
			this.movetime.Enabled = true;
			this.movetime.Interval = 20;
			this.movetime.Tick += new System.EventHandler(this.moveTimeEvent);
			// 
			// HealthBar
			// 
			this.HealthBar.Location = new System.Drawing.Point(362, 12);
			this.HealthBar.Name = "HealthBar";
			this.HealthBar.Size = new System.Drawing.Size(132, 26);
			this.HealthBar.TabIndex = 12;
			this.HealthBar.Value = 100;
			this.HealthBar.Click += new System.EventHandler(this.HealthBar_Click);
			// 
			// txtAmmo
			// 
			this.txtAmmo.AutoSize = true;
			this.txtAmmo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.txtAmmo.Location = new System.Drawing.Point(23, 12);
			this.txtAmmo.Name = "txtAmmo";
			this.txtAmmo.Size = new System.Drawing.Size(48, 13);
			this.txtAmmo.TabIndex = 13;
			this.txtAmmo.Text = "Ammo: 0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(315, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Health:";
			// 
			// Avater
			// 
			this.Avater.AccessibleDescription = "b";
			this.Avater.BackColor = System.Drawing.Color.Transparent;
			this.Avater.Image = global::Heist.Properties.Resources.right1;
			this.Avater.Location = new System.Drawing.Point(12, 330);
			this.Avater.Name = "Avater";
			this.Avater.Size = new System.Drawing.Size(92, 87);
			this.Avater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Avater.TabIndex = 0;
			this.Avater.TabStop = false;
			this.Avater.Click += new System.EventHandler(this.Avater_Click);
			// 
			// BankHeistGamePlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(799, 453);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAmmo);
			this.Controls.Add(this.Avater);
			this.Controls.Add(this.HealthBar);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "BankHeistGamePlay";
			this.Text = "BankHeistGamePlay";
			this.Load += new System.EventHandler(this.BankHeistGamePlay_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
			this.Resize += new System.EventHandler(this.BankHeistGamePlay_Resize);
			((System.ComponentModel.ISupportInitialize)(this.Avater)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Avater;
		private System.Windows.Forms.Timer movetime;
		private System.Windows.Forms.ProgressBar HealthBar;
		private System.Windows.Forms.Label txtAmmo;
		private System.Windows.Forms.Label label1;
	}
}