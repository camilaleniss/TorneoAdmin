using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneoApp.ControlUsers;
using TorneoApp.Model;

namespace TorneoApp.Gui
{
    public partial class CambiarCategoria : Form
    {
        public CategoriasLists categorias { get; set; }

        public int index;
        public CambiarCategoria()
        {
            InitializeComponent();
        }

        public void InitializeCategorias(List<string> categorias)
        {
            foreach(string cat in categorias)
            {
                listCategorias.Items.Add(cat);
            }
            
        }

        private void ButSaveChanges_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCategorias.SelectedIndices.Count > 0)
            {
                index = listCategorias.SelectedIndices[0];
                categorias.MoverA(index);
            }
        }

        private void ButIniciar_Click(object sender, EventArgs e)
        {
            categorias.MoverA(index);
            this.Dispose();
        }
    }
}
