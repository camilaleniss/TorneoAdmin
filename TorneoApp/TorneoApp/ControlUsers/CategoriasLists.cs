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
    public partial class CategoriasLists : UserControl
    {

        public MainWindow Window { private get; set; }
        public bool IsFormas { get; set; }
        public int IndexCat { get; set; }
        public int IndexComp { get; set; }

        public CategoriasLists()
        {
            InitializeComponent();
            
        }

       

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CategoriasLists_Load(object sender, EventArgs e)
        {

        }

        private void ControlButtons1_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        public ListView getListCategorias()
        {
            return listCategorias;
        }

        private void ListCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCategorias.SelectedIndices.Count > 0)
            {
                int index = listCategorias.SelectedIndices[0];
                IndexCat = index;
                this.Window.SelectCategory(index, IsFormas);
            }
        }

        public void LoadCompetidores(List<Competidor> competidores)
        {
            listCompetidores.Clear();
            foreach (Competidor c in competidores)
            {
                listCompetidores.Items.Add(c.ToString());
            }
        }

        private void ListCompetidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCompetidores.SelectedIndices.Count > 0)
            {
                int index = listCompetidores.SelectedIndices[0];
                IndexComp = index;               
                this.Window.SelectCompetidor(IndexCat, IsFormas, index);
            }
        }

        public void LoadData(Competidor comp)
        {
            labNombre.Text = comp.Name;
            labEdad.Text = comp.Edad + " años";
            labPeso.Text = comp.Peso + "kg";
            labEscuela.Text = comp.Escuela.Name;
        }
    }
}
