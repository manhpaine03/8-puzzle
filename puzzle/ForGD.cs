using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class ForGD : Form
	{
		public ForGD()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			// Tạo instance form 2
			frmPuzzleGame frmPuzzleGame = new frmPuzzleGame();

			frmPuzzleGame.Show();
		}

		private void btnLuat_Click(object sender, EventArgs e)
		{
			FormLuat frmLuat = new FormLuat();
			frmLuat.Show();
		}

		private void btnOUT_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
