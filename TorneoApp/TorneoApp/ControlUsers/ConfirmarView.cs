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
    public partial class ConfirmarView : UserControl
    {

        public MainWindow Main { get; set; }
        public ConfirmarView()
        {
            InitializeComponent();
            labNombreTorneo.Text = Torneo.NOMBRE_TORNEO;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ImportarView_Load(object sender, EventArgs e)
        {

        }
    }
}
