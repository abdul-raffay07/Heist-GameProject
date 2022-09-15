namespace Heist
{
	partial class HelpMenu
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
			this.Help = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
			this.SuspendLayout();
			// 
			// Help
			// 
			this.Help.Image = global::Heist.Properties.Resources.Help;
			this.Help.Location = new System.Drawing.Point(12, 12);
			this.Help.Name = "Help";
			this.Help.Size = new System.Drawing.Size(224, 89);
			this.Help.TabIndex = 0;
			this.Help.TabStop = false;
			this.Help.Click += new System.EventHandler(this.Help_Click);
			// 
			// button1
			// 
			this.button1.AllowDrop = true;
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(668, 385);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HelpMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Help);
			this.Name = "HelpMenu";
			this.Text = "HelpMenu";
			((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Help;
		private System.Windows.Forms.Button button1;
	}
}