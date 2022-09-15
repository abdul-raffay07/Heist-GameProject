using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heist
{
	public partial class BankHeistGamePlay : Form
	{

		bool goLeft, goRight, goUp, goDown, gameOver;
		string facing = "right";
		int speed = 12;
		int playerhealth = 100;
		int ammo = 10;
		int oppSpeed = 5;
		Random ranNumber = new Random();

			List<PictureBox> opplist = new List<PictureBox>();

		private Rectangle buttonOrignalRectangle;
		private Rectangle orignalFormSize;

		public BankHeistGamePlay()
		{
			InitializeComponent();
			restartGame();
		}

		private void BankHeistGamePlay_Load(object sender, EventArgs e)
		{
			orignalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
			buttonOrignalRectangle = new Rectangle(Avater.Location.X, Avater.Location.Y, Avater.Width, Avater.Height);
		}

		private void Avater_Click(object sender, EventArgs e)
		{

		}



		private void BankHeistGamePlay_Resize(object sender, EventArgs e)
		{


		}

		private void HealthBar_Click(object sender, EventArgs e)
		{

		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}
		private void pictureBox8_Click(object sender, EventArgs e)
		{
		}
		private void txtAmmo_TextChanged(object sender, EventArgs e)
		{
		}

		private void moveTimeEvent(object sender, EventArgs e)
		{
			if (playerhealth > 1)
			{
				HealthBar.Value = playerhealth;
			}
			else
			{
				
				gameOver = true;
				Avater.Image = Properties.Resources.restartgame;
				Avater.Size = new Size(700, 400);
				Avater.SizeMode = PictureBoxSizeMode.Zoom;
				movetime.Stop();

			}
			txtAmmo.Text = "Ammo" + ammo;

			if (goLeft == true && Avater.Left > 0)
			{
				Avater.Left -= speed;
			}
			if (goRight == true && Avater.Left + Avater.Width < this.ClientSize.Width)
			{
				Avater.Left += speed;
			}
			if (goUp == true && Avater.Top > 45)
			{
				Avater.Top -= speed;
			}
			if (goDown == true && Avater.Top < this.ClientSize.Height)
			{
				Avater.Top += speed;
			}

			foreach(Control x in this.Controls)
            {
				if (x is PictureBox && (string)x.Tag == "ammo")
                {
					if (Avater.Bounds.IntersectsWith(x.Bounds))
                    {
						this.Controls.Remove(x);
						((PictureBox)x).Dispose();
						ammo += 5;
                    }
                }

				if(x is PictureBox && (string)x.Tag == "Life")
                {
					if(Avater.Bounds.IntersectsWith(x.Bounds))
                    {
						this.Controls.Remove(x);
						((PictureBox)x).Dispose();
						playerhealth += 20;
                    }
                }

				if (x is PictureBox && (string)x.Tag == "Opps")
                {

					if(Avater.Bounds.IntersectsWith(x.Bounds))
                    {
						playerhealth -= 1;
                    }
					if(x.Left > Avater.Left)
                    {
						x.Left -= oppSpeed;
						
						((PictureBox)x).Image = Properties.Resources.oleft;
						
                    }
					if (x.Left < Avater.Left)
					{
						x.Left += oppSpeed;

						((PictureBox)x).Image = Properties.Resources.oright;

					}
					if (x.Top < Avater.Top)
					{
						x.Top += oppSpeed;
					}
					if (x.Top > Avater.Top)
					{
						x.Top -= oppSpeed;
					}

				}
				foreach (Control j in this.Controls)
                {
					if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "Opps")
                    {
						if(x.Bounds.IntersectsWith(j.Bounds))
                        {
							this.Controls.Remove(j);
							((PictureBox)j).Dispose();
							this.Controls.Remove(x);
							((PictureBox)x).Dispose();
							opplist.Remove(((PictureBox)x));
							MakeOpps();
                        }
                    }
                }
            }
		}

		private void KeyisDown(object sender, KeyEventArgs e)
		{

			if(gameOver == true)
            {
				return;
            }

			if (e.KeyCode == Keys.Left)
			{
				goLeft = true;
				facing = "left";
				Avater.Image = Properties.Resources.left1;
			}
			if (e.KeyCode == Keys.Right)
			{
				goRight = true;
				facing = "right";
				Avater.Image = Properties.Resources.right1;
			}
			if (e.KeyCode == Keys.Up)
			{
				goUp = true;
			}
			if (e.KeyCode == Keys.Down)
			{
				goDown = true;
			}

		}

		private void KeyisUp(object sender, KeyEventArgs e)
		{
		if (e.KeyCode == Keys.Left)
			{
				goLeft = false;
			}
			if (e.KeyCode == Keys.Right)
			{
				goRight = false;
			}
			if (e.KeyCode == Keys.Up)
			{
				goUp = false;
			}
			if (e.KeyCode == Keys.Down)
			{
				goDown = false;
			}

			if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
			{
				ammo--;
				shootBullet(facing);
				if (ammo < 1)
                {
					DropAmmo();
                }
			}

			if(e.KeyCode == Keys.Enter && gameOver == true)
            {
				restartGame();
            }
		}
		private void MakeOpps()
		{
			PictureBox Opps = new PictureBox();
			Opps.Tag = "Opps";
			Opps.Image = Properties.Resources.oright;
			Opps.Left = ranNumber.Next(0, 900);
			Opps.Top = ranNumber.Next(0, 800);
			Opps.SizeMode = PictureBoxSizeMode.AutoSize;
			opplist.Add(Opps);
			this.Controls.Add(Opps);
			Avater.BringToFront();

		}

		private void DropAmmo()
        {
			PictureBox ammo = new PictureBox();
			ammo.Image = Properties.Resources.ammo1;
			ammo.Size =new Size(100, 100);
			ammo.Left = ranNumber.Next(10, this.ClientSize.Width - ammo.Width);
			ammo.Top = ranNumber.Next(60, this.ClientSize.Height - ammo.Height);
			ammo.Tag = "ammo";
			this.Controls.Add(ammo);

			ammo.BringToFront();
			Avater.BringToFront();

        }
		private void AddHealth()
        {
			PictureBox playerhealth = new PictureBox();
			playerhealth.Image = Properties.Resources.Main;
			playerhealth.Size = new Size(100, 100);
			playerhealth.Left = ranNumber.Next(10, this.ClientSize.Width - playerhealth.Width);
			playerhealth.Top = ranNumber.Next(60, this.ClientSize.Height - playerhealth.Height);
			playerhealth.Tag = "Life";
			this.Controls.Add(playerhealth);

			playerhealth.BringToFront();
			Avater.BringToFront();
        }

		private void texttorestart()
        {
			PictureBox ingamemenu = new PictureBox();
			ingamemenu.Image = Properties.Resources.restartgame;
			ingamemenu.Size = new Size(100, 100);
			ingamemenu.BringToFront();
        }
			
		private void shootBullet(string direction)
		{
			Bullet shootbullet = new Bullet();
			shootbullet.direction = direction;
			shootbullet.bulletLeft = Avater.Left + (Avater.Width / 2);
			shootbullet.bulletTop = Avater.Top + (Avater.Width / 2);
			shootbullet.makeBullet(this); 
		}

		public void restartGame()
        {
			Avater.Image = Properties.Resources.right1;

			foreach(PictureBox i in opplist)
            {
				this.Controls.Remove(i);
            }

			opplist.Clear();
			for (int i = 0; i < 2; i++)
            {
				MakeOpps();
            }
			goUp = false;
			goDown = false;
			goLeft = false;
			goRight = false;
			gameOver = false;

			playerhealth = 100;
			ammo = 10;

			movetime.Start();
        }
	}
}
