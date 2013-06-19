using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Owiki
{
    public partial class newprofile : Form
    {
        public newprofile()
        {
            InitializeComponent();
        }

        private void firstname_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_add_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_add_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\owiki\\" + firstname_add.Text + " " + Lastname_add.Text + "1")) ;
            {
                File.Delete("C:\\owiki\\" + firstname_add.Text + " " + Lastname_add.Text + "1");

                using (StreamWriter writer = new StreamWriter("C:\\owiki\\" + firstname_add.Text + " " + Lastname_add.Text + "1", true))
                {
                    writer.WriteLine(firstname_add.Text);
                    writer.WriteLine(Lastname_add.Text);
                    writer.WriteLine(Nationality_add.Text);
                    writer.WriteLine(passportnumber_add.Text);
                    writer.WriteLine(dateofbirth_add.Text);
                    writer.WriteLine(placeofbirth_add.Text);
                }

                using (StreamWriter writer = new StreamWriter("C:\\owiki\\" + firstname_add.Text + " " + Lastname_add.Text + "criminality"))
                {
                    writer.Write(criminality_add.Text);
                }

                using (StreamWriter writer = new StreamWriter("C:\\owiki\\" + firstname_add.Text + " " + Lastname_add.Text + "notes"))
                {
                    writer.Write(notes_add.Text);
                }
            } 

            if (File.Exists("C:\\owiki\\" + passportnumber_add.Text)) ;
            {
                File.Delete("C:\\owiki\\" + passportnumber_add.Text);

                using (StreamWriter writer = new StreamWriter("C:\\owiki\\" + passportnumber_add.Text, true))
                {
                    writer.WriteLine(firstname_add.Text);
                    writer.WriteLine(Lastname_add.Text);
                    writer.WriteLine(Nationality_add.Text);
                    writer.WriteLine(passportnumber_add.Text);
                    writer.WriteLine(dateofbirth_add.Text);
                    writer.WriteLine(placeofbirth_add.Text);
                }

                using (StreamWriter writer = new StreamWriter("C:\\owiki\\" + passportnumber_add.Text + "criminality"))
                {
                    writer.Write(criminality_add.Text);
                }

                using (StreamWriter writer = new StreamWriter("C:\\owiki\\" + passportnumber_add.Text + "notes"))
                {
                    writer.Write(notes_add.Text);
                }
            } 
        }
    }
}
