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
    public partial class FrmMain : Form
    {
        public FrmMain(String welcome)
        {
            setWelcome(welcome);
            InitializeComponent();
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void linkM1_LinkClicked(object sender, EventArgs e)
        {

        }
        private String welcome;

        public void setWelcome(String welcome)
        {
            this.welcome = welcome;
        }
        public String getWelcome()
        {
            return welcome;
        }

        private void lblwel_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblwel.Text = "Welcome Dear " + welcome;

        }
        //private void MaximizeWindow()
        //{
        //    var rectangle = Screen.FromControl(this).Bounds;
        //    this.FormBorderStyle = FormBorderStyle.None;
        //    Size = new Size(rectangle.Width, rectangle.Height);
        //    Location = new Point(0, 0);
        //    Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
        //    this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
        //}

        //private void ResizableWindow()
        //{
        //    this.ControlBox = false;
        //    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        //}

        private void picM3_Click(object sender, EventArgs e)
        {

        }

        private void picM1_Click(object sender, EventArgs e)
        {

        }

        private void linkM1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmLooser frmLooser = new FrmLooser();
            frmLooser.ShowDialog();
            this.Close();
        }

        private void linkM2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmBihamechiz frmBihamechiz = new FrmBihamechiz();
            frmBihamechiz.ShowDialog();
            this.Close();
        }

        private void linkM3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkM4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkM5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkM6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin2 frmLogin2 = new FrmLogin2();
            frmLogin2.ShowDialog();
            this.Close();
        }

        private void lblRgistr_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.ShowDialog();
            this.Close();
        }
    }
}
