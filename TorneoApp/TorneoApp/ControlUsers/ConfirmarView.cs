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

        public void InitializeCompetidores(List<Competidor> competidores)
        {
            listCompetidores.Clear();
            foreach (Competidor c in competidores)
                listCompetidores.Items.Add(c.Name);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ImportarView_Load(object sender, EventArgs e)
        {

        }

        private void ListCompetidores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButConfirmar_Click(object sender, EventArgs e)
        {
            var indices = listCompetidores.SelectedIndices;
            List<int> indexpresentes = new List<int>();
            foreach (var i in indices)
            {
                indexpresentes.Add(int.Parse(i.ToString()));
            }
            Main.ConfirmarCompetidores(indexpresentes);

        }
    }
}
