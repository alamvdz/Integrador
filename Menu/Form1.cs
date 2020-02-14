using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            customizeDezing();

        }

        private void customizeDezing()
        {
            
            panelSubClientes.Visible = false;
            panelSubLavadora.Visible = false;
            panelSubProduc.Visible = false;
            panelSubCitas.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubClientes.Visible == true)
                panelSubClientes.Visible = false;


            if (panelSubLavadora.Visible == true)
                panelSubLavadora.Visible = false;


            if (panelSubProduc.Visible == true)
                panelSubProduc.Visible = false;

            if (panelSubCitas.Visible == true)
                panelSubCitas.Visible = false;
         
           


        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }

            else
                submenu.Visible = false;




        }
        //////Clientes////////
        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubClientes);



        }

        private void button2_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }
        /////Lavadoras/////
        private void btnLavadoras_Click(object sender, EventArgs e)
        {

            showSubMenu(panelSubLavadora);


        }

        private void button7_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {




            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {




            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {




            hideSubMenu();
        }

        /////Productos////
        
            
        private void btnProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduc);


        }

        private void button11_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {




            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        //Citas//
        private void button13_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubCitas);


        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new Citas());


            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
