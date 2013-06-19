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
    public partial class searchprofile : Form
    {
        public searchprofile()
        {
            InitializeComponent();
        }

        private void search1_Click(object sender, EventArgs e)
        {
            string firstname = firstname_search.Text;
            string lastname = lastname_search.Text;
        }
    }
}
