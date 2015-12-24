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
    public partial class Form2 : Form

    {

        public string numero = "dfdfdgfggf//55";
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   // Clear
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)  // Exit
        {
            User.Text = "";
            Pass.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) // Register
        {
            if (User.Text.Length < 3 || Pass.Text.Length < 3) //  user oder passwort keiner als 3 
            {

                MessageBox.Show("Benutzer oder Paßwort zu kurz");  // Sagt zu Kurz
            }
            else
            {
                if (Directory.Exists($"data/users/{User.Text}")) // neue username machen
                {

                    MessageBox.Show("Benutzer Name existiert bereit");
                }
                else {

                    StreamWriter SW = new StreamWriter($"data/users/{User.Text}data.ls");
                    SW.WriteLine(User.Text);
                    SW.WriteLine(SHA1.Hashing(SHA1.Hashing(Pass.Text + numero)));
                    SW.Close();
                    MessageBox.Show ($"Benutzer wurde erstellt" );


                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
