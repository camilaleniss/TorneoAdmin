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
            Controlador.ShowView(MainWindow.INIT);
        }

        private void ButCatSanda_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.CATSANDA);
        }

        private void ButImportar_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.VERIFICAR);
        }

        private void ButCategorias_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.CATEGORIAS);
        }

        private void ButCatFormas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.CATFORMAS);
        }

        private void ButCompetidores_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.COMPETIDORES);

        }

        private void ButListaCompetidores_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.LISTCOMPETIDORES);
        }

        private void ButEscuelas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.ESCUELAS);
        }

        private void ButListaEscuelas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.LISTESCUELAS);
        }

        private void ButRankingEscuelas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.RANKING);
        }

        private void ButCompetencia_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.COMPETENCIA);
        }

        private void ButSanda_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.COMPSANDA);

        }

        private void ButFormas_Click(object sender, EventArgs e)
        {
            Controlador.ShowView(MainWindow.COMPFORMAS);
        }
    }
}
