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
    public partial class EscuelasView : UserControl
    {
        public MainWindow Main { get; set; }
        public int IndexEscuela { get; set; }
        public EscuelasView()
        {
            InitializeComponent();
        }

        public void InitializeEscuelas(List<String> escuelas)
        {
            foreach (String e in escuelas)
                listEscuelas.Items.Add(e);           
        }

        private void ListCompetidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void InitializeCompetidores(List<Competidor> competidores, string nombre, int puntossanda, int puntosformas)
        {
            foreach (Competidor c in competidores)
                listCompetidores.Items.Add(c.ToString());

            labNomEscuela.Text = nombre;
            labPuntosSanda.Text = puntossanda+"";
            labPuntosFormas.Text = puntosformas+"";
        }

        private void EscuelasView_Load(object sender, EventArgs e)
        {

        }

        private void ListEscuelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEscuelas.SelectedIndices.Count > 0)
            {
                int index = listEscuelas.SelectedIndices[0];
                IndexEscuela = index;
                this.Main.GetCompetidoresEscuela(index);
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
