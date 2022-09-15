namespace Heist
{
	partial class LoadUp
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.NameInput = new System.Windows.Forms.TextBox();
			this.AvaterNameInput = new System.Windows.Forms.Label();
			this.LoadGame = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Heist.Properties.Resources.Title;
			this.pictureBox1.Location = new System.Drawing.Point(262, 46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 108);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// NameInput
			// 
			this.NameInput.Location = new System.Drawing.Point(333, 204);
			this.NameInput.Name = "NameInput";
			this.NameInput.Size = new System.Drawing.Size(156, 20);
			this.NameInput.TabIndex = 1;
			this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
			// 
			// AvaterNameInput
			// 
			this.AvaterNameInput.AutoSize = true;
			this.AvaterNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AvaterNameInput.ForeColor = System.Drawing.Color.Red;
			this.AvaterNameInput.Location = new System.Drawing.Point(152, 199);
			this.AvaterNameInput.Name = "AvaterNameInput";
			this.AvaterNameInput.Size = new System.Drawing.Size(164, 24);
			this.AvaterNameInput.TabIndex = 2;
			this.AvaterNameInput.Text = "Type Username:";
			// 
			// LoadGame
			// 
			this.LoadGame.BackColor = System.Drawing.Color.Black;
			this.LoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadGame.ForeColor = System.Drawing.Color.Red;
			this.LoadGame.Location = new System.Drawing.Point(355, 273);
			this.LoadGame.Name = "LoadGame";
			this.LoadGame.Size = new System.Drawing.Size(154, 42);
			this.LoadGame.TabIndex = 3;
			this.LoadGame.Text = "Load Game";
			this.LoadGame.UseVisualStyleBackColor = false;
			this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
			// 
			// LoadUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LoadGame);
			this.Controls.Add(this.AvaterNameInput);
			this.Controls.Add(this.NameInput);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "LoadUp";
			this.Text = "LoadUp";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox NameInput;
		private System.Windows.Forms.Label AvaterNameInput;
		private System.Windows.Forms.Button LoadGame;
	}
}