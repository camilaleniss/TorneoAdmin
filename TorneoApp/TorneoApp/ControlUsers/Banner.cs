using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoApp.ControlUsers
{
    public partial class Banner : UserControl
    {
        public Banner()
        {
            InitializeComponent();
            
        }

        public void ModifyLocation(string[] location)
        {          
            labInicio.Text = location[0];

            if (location[1] != null)
            {
                labArrow1.Visible = true;
                labCategoria.Visible = true;
                labCategoria.Text = location[1];
            }
            else
            {
                labArrow1.Visible = false;
                labCategoria.Visible = false;
            }

            if (location[2] != null)
            {
                labArrow2.Visible = true;
                labSubCat.Visible = true;
                labSubCat.Text = location[1];
            }
            else
            {
                labArrow2.Visible = false;
                labSubCat.Visible = false;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Banner_Load(object sender, EventArgs e)
        {

        }

        private void ButLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
