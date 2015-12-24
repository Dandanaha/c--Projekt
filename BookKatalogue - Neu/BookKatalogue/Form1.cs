using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Hash;

namespace BookKatalogue
{
    public partial class Form1 : Form
    {

        public string numero = "dfdfdgfggf//55";

        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (User.Text.Length < 3 || Pass.Text.Length < 3) //  user oder passwort keiner als 3 
            {

                MessageBox.Show("Benutzer Name ist falsch", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                // Sagt zu Kurz
                
            }
            else
            {
                if (Directory.Exists($"data/users/{User.Text}")) // neue username machen
                {

                    MessageBox.Show("Benutzer Name ist gut");
                    Form3 bo = new Form3();
                    bo.Show();
                }
                else
                {
                    Directory.CreateDirectory($"data/users/{User.Text}");
                    StreamReader sr = new StreamReader($"data/users/{User.Text}/data.ls");// sehen ob das Password stimmt
                    string user = sr.ReadLine();
                    string Passhash = sr.ReadLine();
                    sr.Close();

                    string thisPass = SHA1.Hashing(SHA1.Hashing(Pass.Text+numero));
                    if ( user == User.Text && Passhash == thisPass)
                    {

                        MessageBox.Show($"Willkommen{User}!");

                    }
                    else
                    {
                        MessageBox.Show("Benutzer Name ist falsch","",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }

            this.Hide();
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form2 rg = new Form2();

            rg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
