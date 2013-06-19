using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Owiki
{
    public partial class Owiki : Form
    {
        public Owiki()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newprofile_Click(object sender, EventArgs e)
        {
            new newprofile().Show();
        }

        private void editprofile_Click(object sender, EventArgs e)
        {
            new searchprofile().Show();
        }
    }
}
