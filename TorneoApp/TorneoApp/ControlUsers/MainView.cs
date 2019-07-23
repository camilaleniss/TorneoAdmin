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
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void LabCategorias_Click(object sender, EventArgs e)
        {

        }

        private void LabNumCategorias_Click(object sender, EventArgs e)
        {

        }

        private void ControlButtons1_Load(object sender, EventArgs e)
        {

        }

        public void SetNumberLabs(int categorias, int catsanda, int catformas, int competidores, int escuelas, int formas)
        {
            this.labNumCat.Text = ""+categorias;
            this.labSanda.Text = ""+catsanda;
            this.labFormas.Text = "" + catformas;
            this.labNumComp.Text = "" + competidores;
            this.labNumEscuelas.Text = "" + escuelas;
            this.labNumFormas.Text = "" + formas;
        }

        public void InitializeListEscuelas(List<Escuela> escuelas)
        {
            foreach (Escuela e in escuelas)
            {
                listEscuelas.Items.Add(e.Name);
            }
        }

        public void InitializeListFormas(List<Forma> formas)
        {
            foreach(Forma f in formas)
            {
                listFormas.Items.Add(f.Nombre);
            }
        }
    }
}
