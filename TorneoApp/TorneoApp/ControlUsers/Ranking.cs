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

        public void InitializeRanking(List<String> lista, bool IsFormas)
        {
            if (IsFormas)
            {
                foreach (String s in lista)
                    listFormas.Items.Add(s);
            }
            else
            {
                foreach (String s in lista)
                    listSanda.Items.Add(s);
            }
        }

        private void ListFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFormas.SelectedIndices.Count > 0)
            {
                this.escuela = listFormas.SelectedItems[0].Text;
                this.IsFormas = true;
                Main.InicializarRankingCompetidores(escuela, IsFormas);
            }
        }

        private void ListSanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSanda.SelectedIndices.Count > 0)
            {
                this.escuela = listSanda.SelectedItems[0].Text;
                this.IsFormas = true;
                Main.InicializarRankingCompetidores(escuela, IsFormas);
            }
        }
    }
}
