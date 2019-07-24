using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneoApp.Model;

namespace TorneoApp.ControlUsers
{
    public partial class CompetidoresController : UserControl
    {
        public MainWindow Main { get; set; }

        public CompetidoresController()
        {
            InitializeComponent();
            labNombreTorneo.Text = Torneo.NOMBRE_TORNEO;
        }

        private void ButListado_Click(object sender, EventArgs e)
        {
            Main.ShowView(MainWindow.LISTCOMPETIDORES);
        }

        private void ButVerificar_Click(object sender, EventArgs e)
        {
            Main.ShowView(MainWindow.VERIFICAR);
        }
    }
}
