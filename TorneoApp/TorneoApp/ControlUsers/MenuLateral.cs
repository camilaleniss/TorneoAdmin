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

        public void UpdateLocation(string categoria, string subcategoria)
        {
            InitBlancos();
            var yellow = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            if (!categoria.Equals(""))
            {
                Pintar(categoria, yellow);
                if (!subcategoria.Equals(""))
                    Pintar(subcategoria, yellow);
            }
        }

        public void InitBlancos()
        {
            buttonTitle.ForeColor = Color.White;
            butCategorias.ForeColor = Color.White;
            butCatSanda.ForeColor = Color.White;
            butCatFormas.ForeColor = Color.White;
            butCompetidores.ForeColor = Color.White;
            butListaCompetidores.ForeColor = Color.White;
            butImportar.ForeColor = Color.White;
            butEscuelas.ForeColor = Color.White;
            butListaEscuelas.ForeColor = Color.White;
            butRankingEscuelas.ForeColor = Color.White;
            butCompetencia.ForeColor = Color.White;
            butSanda.ForeColor = Color.White;
            butFormas.ForeColor = Color.White;
        }

        public void Pintar(string Lugar, System.Drawing.Color Pintura)
        {
            switch (Lugar)
            {
                case (MainWindow.CATEGORIAS):
                    butCategorias.ForeColor = Pintura;
                    break;
                case (MainWindow.CATFORMAS):
                    butCatFormas.ForeColor = Pintura;
                    break;
                case (MainWindow.CATSANDA):
                    butCatSanda.ForeColor = Pintura;
                    break;
                case (MainWindow.COMPETIDORES):
                    butCompetidores.ForeColor = Pintura;
                    break;
                case (MainWindow.LISTCOMPETIDORES):
                    butListaCompetidores.ForeColor = Pintura;
                    break;
                case (MainWindow.VERIFICAR):
                    butImportar.ForeColor = Pintura;
                    break;
                case (MainWindow.ESCUELAS):
                    butEscuelas.ForeColor = Pintura;
                    break;
                case (MainWindow.LISTESCUELAS):
                    butListaEscuelas.ForeColor = Pintura;
                    break;
                case (MainWindow.RANKING):
                    butRankingEscuelas.ForeColor = Pintura;
                    break;
                case (MainWindow.COMPETENCIA):
                    butCompetencia.ForeColor = Pintura;
                    break;
                case (MainWindow.COMPFORMAS):
                    butFormas.ForeColor = Pintura;
                    break;
                case (MainWindow.COMPSANDA):
                    butSanda.ForeColor = Pintura;
                    break;
            }
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

        public void ReviewState(bool Iniciado)
        {
            if (!Iniciado)
            {
                butCompetencia.Enabled = false;
                butSanda.Enabled = false;
                butFormas.Enabled = false;
            }
            else
            {
                butCompetencia.Enabled = true;
                butSanda.Enabled = true;
                butFormas.Enabled = true;
            }
        }
    }
}
