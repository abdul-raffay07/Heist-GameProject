namespace Heist
{
	partial class MainMenu
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
			this.StartGameButton = new System.Windows.Forms.Button();
			this.WeaponsButton = new System.Windows.Forms.Button();
			this.HelpButton = new System.Windows.Forms.Button();
			this.SavedGamesButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MainMenuName = new System.Windows.Forms.Label();
			this.NameMenu = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// StartGameButton
			// 
			this.StartGameButton.BackColor = System.Drawing.Color.Black;
			this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartGameButton.ForeColor = System.Drawing.Color.Red;
			this.StartGameButton.Location = new System.Drawing.Point(30, 132);
			this.StartGameButton.Name = "StartGameButton";
			this.StartGameButton.Size = new System.Drawing.Size(171, 59);
			this.StartGameButton.TabIndex = 1;
			this.StartGameButton.Text = " Start Game";
			this.StartGameButton.UseVisualStyleBackColor = false;
			this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
			// 
			// WeaponsButton
			// 
			this.WeaponsButton.BackColor = System.Drawing.Color.Black;
			this.WeaponsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeaponsButton.ForeColor = System.Drawing.Color.Red;
			this.WeaponsButton.Location = new System.Drawing.Point(30, 213);
			this.WeaponsButton.Name = "WeaponsButton";
			this.WeaponsButton.Size = new System.Drawing.Size(171, 59);
			this.WeaponsButton.TabIndex = 2;
			this.WeaponsButton.Text = "Weapons";
			this.WeaponsButton.UseVisualStyleBackColor = false;
			// 
			// HelpButton
			// 
			this.HelpButton.BackColor = System.Drawing.Color.Black;
			this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton.ForeColor = System.Drawing.Color.Red;
			this.HelpButton.Location = new System.Drawing.Point(30, 295);
			this.HelpButton.Name = "HelpButton";
			this.HelpButton.Size = new System.Drawing.Size(171, 59);
			this.HelpButton.TabIndex = 3;
			this.HelpButton.Text = "Help";
			this.HelpButton.UseVisualStyleBackColor = false;
			this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
			// 
			// SavedGamesButton
			// 
			this.SavedGamesButton.BackColor = System.Drawing.Color.Black;
			this.SavedGamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SavedGamesButton.ForeColor = System.Drawing.Color.Red;
			this.SavedGamesButton.Location = new System.Drawing.Point(30, 379);
			this.SavedGamesButton.Name = "SavedGamesButton";
			this.SavedGamesButton.Size = new System.Drawing.Size(171, 59);
			this.SavedGamesButton.TabIndex = 4;
			this.SavedGamesButton.Text = "Saved Games";
			this.SavedGamesButton.UseVisualStyleBackColor = false;
			this.SavedGamesButton.Click += new System.EventHandler(this.SavedGamesButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = global::Heist.Properties.Resources.Title;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(180, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(323, 114);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MainMenuName
			// 
			this.MainMenuName.AutoSize = true;
			this.MainMenuName.ForeColor = System.Drawing.Color.Red;
			this.MainMenuName.Location = new System.Drawing.Point(558, 12);
			this.MainMenuName.Name = "MainMenuName";
			this.MainMenuName.Size = new System.Drawing.Size(0, 13);
			this.MainMenuName.TabIndex = 5;
			// 
			// NameMenu
			// 
			this.NameMenu.BackColor = System.Drawing.Color.Black;
			this.NameMenu.ForeColor = System.Drawing.Color.Red;
			this.NameMenu.Location = new System.Drawing.Point(562, 13);
			this.NameMenu.Name = "NameMenu";
			this.NameMenu.Size = new System.Drawing.Size(100, 20);
			this.NameMenu.TabIndex = 6;
			this.NameMenu.TextChanged += new System.EventHandler(this.NameMenu_TextChanged);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.NameMenu);
			this.Controls.Add(this.MainMenuName);
			this.Controls.Add(this.SavedGamesButton);
			this.Controls.Add(this.HelpButton);
			this.Controls.Add(this.WeaponsButton);
			this.Controls.Add(this.StartGameButton);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainMenu";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button StartGameButton;
		private System.Windows.Forms.Button WeaponsButton;
		private System.Windows.Forms.Button HelpButton;
		private System.Windows.Forms.Button SavedGamesButton;
		private System.Windows.Forms.Label MainMenuName;
		private System.Windows.Forms.TextBox NameMenu;
	}
}

