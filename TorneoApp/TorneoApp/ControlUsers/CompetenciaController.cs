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
    public partial class CompetenciaController : UserControl
    {
        public MainWindow Main { get; set; }
        public CompetenciaController()
        {
            InitializeComponent();
            labNombreTorneo.Text = Torneo.NOMBRE_TORNEO;
        }

        private void ButSanda_Click(object sender, EventArgs e)
        {
            Main.ShowView(MainWindow.COMPSANDA);
        }

        private void ButFormas_Click(object sender, EventArgs e)
        {
            Main.ShowView(MainWindow.COMPFORMAS);
        }
    }
}
