using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneoApp.Model;

namespace TorneoApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visible = false; 
            main.Show();
            main.NuevoTorneo();
        }

        private void ButLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void ButLast_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visible = false;
            main.Show();
            main.RecuperarTorneo();
        }
    }
}
