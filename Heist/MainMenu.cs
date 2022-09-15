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
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{
			
		}
		private void StartGameButton_Click(object sender, EventArgs e)
		{
			//opens the SelectHeist Menu when the Start Game button is clicked.
			this.Hide();
			SelectHeistMenu selectheistmenu = new SelectHeistMenu();
			selectheistmenu.ShowDialog();
			this.Close();
		}

		private void HelpButton_Click(object sender, EventArgs e)
		{
			//opens the Help Menu when Help button is clicked.
			this.Hide();
			HelpMenu helpmenu = new HelpMenu();
			helpmenu.ShowDialog();
			this.Close();
		}

		private void SavedGamesButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			SavedGamesMenu savedgamesmenu = new SavedGamesMenu();
			savedgamesmenu.ShowDialog();
			this.Close();
		
		}


		private void NameMenu_Click_1(object sender, EventArgs e)
		{

		}

		private void NameMenu_TextChanged(object sender, EventArgs e)
		{
			NameMenu.Text = LoadUp.PassName;
		}
	}
}
