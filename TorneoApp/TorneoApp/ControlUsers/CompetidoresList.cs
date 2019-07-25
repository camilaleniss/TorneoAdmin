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
    public partial class CompetidoresList : UserControl
    {
        public int Index { get; set; }

        public MainWindow Main { get; set; }
        public CompetidoresList()
        {
            InitializeComponent();
            Index = 0;
        }

        public void InitializeListCompetidores(List<String> competidores)
        {
            foreach (String c in competidores)
                listCompetidores.Items.Add(c);
        }

        public void InitializeInfoCompetidor(string nombre, string genero, string edad, string peso, string nivel,
            string sanda, string formas, string cintanegra, string telefono, string escuela, string eps, 
            string acudiente, string telacudiente, List<Forma> listformas)
        {
            txtNombre.Text = nombre;
            comboGenero.Text = genero;
            txtEdad.Text = edad;
            txtPeso.Text = peso;
            comboNivel.Text = nivel;
            comboSanda.Text = sanda;
            comboFormas.Text = formas;
            comboCinta.Text = cintanegra;
            txtTelefono.Text = telefono;
            txtEscuela.Text = escuela;
            txtEPS.Text = eps;
            txtAcudiente.Text = acudiente;
            txtTelAcudiente.Text = telacudiente;

            listFormas.Clear();
            if (listformas != null)
            {
                foreach (Forma f in listformas)
                    this.listFormas.Items.Add(f.Nombre);
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CompetidoresView_Load(object sender, EventArgs e)
        {

        }

        private void ListCompetidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCompetidores.SelectedIndices.Count > 0)
            {
                Index = listCompetidores.SelectedIndices[0];
                this.Main.GetInfoCompetidor(Index);
            }
        }
    }
}
