﻿using System;
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
	public partial class SelectHeistMenu : Form
	{
		public SelectHeistMenu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainMenu mainmenu = new MainMenu();
			mainmenu.ShowDialog();
			this.Close();
		}

		private void SelectBankButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			BankHeistGamePlay bankheist = new BankHeistGamePlay();
			bankheist.ShowDialog();
			this.Close();
		}
	}
}
