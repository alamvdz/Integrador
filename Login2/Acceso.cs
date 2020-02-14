using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }






        private void Acceso_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

    
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0'; ;
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
            textBox2.Focus();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }







}
