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
    public partial class MenuLateral : UserControl
    {
        public MainWindow Controlador { get; set; }

        public MenuLateral()
        {
            InitializeComponent();
        }

        private void ButtonTitle_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Init");
        }

        private void ButCatSanda_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("CatSanda");
        }

        private void ButImportar_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Importar");
        }

        private void ButCategorias_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Categorias");
        }

        private void ButCatFormas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("CatFormas");
        }

        private void ButCompetidores_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Competidores");

        }

        private void ButListaCompetidores_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Competidores");
        }

        private void ButEscuelas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Escuelas");
        }

        private void ButListaEscuelas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Escuelas");
        }

        private void ButRankingEscuelas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("Ranking");
        }

        private void ButCompetencia_Click(object sender, EventArgs e)
        {

        }

        private void ButSanda_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("CompSanda");

        }

        private void ButFormas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView("CompFormas");
        }
    }
}
