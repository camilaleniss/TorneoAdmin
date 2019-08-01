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
    public partial class ControlButtons : UserControl
    {

        public MainWindow Main { get; set; }
        public ControlButtons()
        {
            InitializeComponent();
        }

        private void ControlButtons_Load(object sender, EventArgs e)
        {

        }

        private void ButSaveChanges_Click(object sender, EventArgs e)
        {
            Main.SaveTorneo();
        }

        private void ButIniciar_Click(object sender, EventArgs e)
        {
            Main.IniciarTorneo();
            this.butIniciar.Enabled = false;
        }
    }
}
