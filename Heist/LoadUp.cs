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
	public partial class LoadUp : Form
	{
		public static string PassName;
		public LoadUp()
		{
			InitializeComponent();
		}

		private void LoadGame_Click(object sender, EventArgs e)
		{
			PassName = NameInput.Text;
			MainMenu mainmenu = new MainMenu();
			mainmenu.Show();
			
		}

		private void NameInput_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
