using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmLooser : Form
    {
        public FrmLooser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLooser_Load(object sender, EventArgs e)
        {

        }

        private void picTick_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmList frmList = new FrmList();
            frmList.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Close();
        }
    }
}
