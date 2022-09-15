namespace Heist
{
	partial class SelectHeistMenu
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
			this.SelectBankButton = new System.Windows.Forms.Button();
			this.SelectMuseumButton = new System.Windows.Forms.Button();
			this.SelecyJewelleryButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// SelectBankButton
			// 
			this.SelectBankButton.BackColor = System.Drawing.Color.Black;
			this.SelectBankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectBankButton.ForeColor = System.Drawing.Color.Red;
			this.SelectBankButton.Location = new System.Drawing.Point(23, 131);
			this.SelectBankButton.Name = "SelectBankButton";
			this.SelectBankButton.Size = new System.Drawing.Size(183, 52);
			this.SelectBankButton.TabIndex = 1;
			this.SelectBankButton.Text = "Bank";
			this.SelectBankButton.UseVisualStyleBackColor = false;
			this.SelectBankButton.Click += new System.EventHandler(this.SelectBankButton_Click);
			// 
			// SelectMuseumButton
			// 
			this.SelectMuseumButton.BackColor = System.Drawing.Color.Black;
			this.SelectMuseumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectMuseumButton.ForeColor = System.Drawing.Color.Red;
			this.SelectMuseumButton.Location = new System.Drawing.Point(23, 217);
			this.SelectMuseumButton.Name = "SelectMuseumButton";
			this.SelectMuseumButton.Size = new System.Drawing.Size(183, 52);
			this.SelectMuseumButton.TabIndex = 2;
			this.SelectMuseumButton.Text = "Museum";
			this.SelectMuseumButton.UseVisualStyleBackColor = false;
			// 
			// SelecyJewelleryButton
			// 
			this.SelecyJewelleryButton.BackColor = System.Drawing.Color.Black;
			this.SelecyJewelleryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelecyJewelleryButton.ForeColor = System.Drawing.Color.Red;
			this.SelecyJewelleryButton.Location = new System.Drawing.Point(23, 305);
			this.SelecyJewelleryButton.Name = "SelecyJewelleryButton";
			this.SelecyJewelleryButton.Size = new System.Drawing.Size(183, 52);
			this.SelecyJewelleryButton.TabIndex = 3;
			this.SelecyJewelleryButton.Text = "Jewellery";
			this.SelecyJewelleryButton.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Heist.Properties.Resources.SelectHeist;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(536, 88);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(672, 380);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 46);
			this.button1.TabIndex = 4;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SelectHeistMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.SelecyJewelleryButton);
			this.Controls.Add(this.SelectMuseumButton);
			this.Controls.Add(this.SelectBankButton);
			this.Controls.Add(this.pictureBox1);
			this.Name = "SelectHeistMenu";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button SelectBankButton;
		private System.Windows.Forms.Button SelectMuseumButton;
		private System.Windows.Forms.Button SelecyJewelleryButton;
		private System.Windows.Forms.Button button1;
	}
}