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
    public partial class Ranking : UserControl
    {
        public MainWindow Main { get; set; }

        public bool IsFormas { get; set; }

        public String escuela { get; set; }
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        public void InitializeRanking(List<Escuela> lista, bool IsFormas)
        {
            if (IsFormas)
            {
                listFormas.Clear();
                foreach (Escuela s in lista)
                    listFormas.Items.Add(s.Name);
            }
            else
            {
                listSanda.Clear();
                foreach (Escuela s in lista)
                    listSanda.Items.Add(s.Name);
            }
        }

        public void InitializeCompetidores(List<String> lista)
        {
            listCompetidores.Clear();
            foreach (string s in lista)
                listCompetidores.Items.Add(s);
        }

        private void ListFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFormas.SelectedIndices.Count > 0)
            {
                this.escuela = listFormas.SelectedItems[0].Text;
                this.IsFormas = true;
                labNomEscuela.Text = escuela;
                Main.InicializarEscuela(escuela, IsFormas);
            }
        }

        private void ListSanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSanda.SelectedIndices.Count > 0)
            {
                this.escuela = listSanda.SelectedItems[0].Text;
                this.IsFormas = false;
                labNomEscuela.Text = escuela;
                Main.InicializarEscuela(escuela, IsFormas);
            }
        }

        private void LabNumOro_Click(object sender, EventArgs e)
        {

        }

        public void SetMedallas(int oro, int plata, int bronce, int totales)
        {
            labNumOro.Text = "" + oro;
            labNumPlata.Text = "" + plata;
            labNumBronce.Text = "" + bronce;
            labTotal.Text = "" + totales;
        }

        private void ButOro_Click(object sender, EventArgs e)
        {
            Main.GetCompetidoresRanking(escuela, IsFormas, Torneo.ORO);
        }

        private void ButPlata_Click(object sender, EventArgs e)
        {
            Main.GetCompetidoresRanking(escuela, IsFormas, Torneo.PLATA);
        }

        private void ButBronce_Click(object sender, EventArgs e)
        {
            Main.GetCompetidoresRanking(escuela, IsFormas, Torneo.BRONCE);
        }
    }
}
