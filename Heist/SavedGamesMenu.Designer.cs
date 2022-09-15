namespace Heist
{
	partial class SavedGamesMenu
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
			this.SavedGames = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SavedGames)).BeginInit();
			this.SuspendLayout();
			// 
			// SavedGames
			// 
			this.SavedGames.Image = global::Heist.Properties.Resources.SavedGames;
			this.SavedGames.Location = new System.Drawing.Point(12, 12);
			this.SavedGames.Name = "SavedGames";
			this.SavedGames.Size = new System.Drawing.Size(570, 95);
			this.SavedGames.TabIndex = 0;
			this.SavedGames.TabStop = false;
			this.SavedGames.Click += new System.EventHandler(this.SavedGames_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(671, 386);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SavedGamesMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.SavedGames);
			this.Name = "SavedGamesMenu";
			this.Text = "SavedGamesMenu";
			((System.ComponentModel.ISupportInitialize)(this.SavedGames)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox SavedGames;
		private System.Windows.Forms.Button button1;
	}
}