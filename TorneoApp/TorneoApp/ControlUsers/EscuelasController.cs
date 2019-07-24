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
    public partial class EscuelasController : UserControl
    {
        public EscuelasController()
        {
            InitializeComponent();
            labNombreTorneo.Text = Torneo.NOMBRE_TORNEO;
        }
    }
}
