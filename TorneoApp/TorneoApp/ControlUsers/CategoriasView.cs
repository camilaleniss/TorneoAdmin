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
    public partial class CategoriasView : UserControl
    {
        public MainWindow Main { get; set; } 

        public CategoriasView()
        {
            InitializeComponent();
            labNombreTorneo.Text = Torneo.NOMBRE_TORNEO;
        }

        public void InitializeLabs (int numcat, int numopened, int numfinished, bool IsFormas)
        {
            if (IsFormas)
            {
                labNumExistsFormas.Text = ""+numcat;
                labNumOpenedFormas.Text = ""+numopened;
                labNumFinishedFormas.Text = ""+numfinished;
            }
            else
            {
                labNumExistsSanda.Text = "" + numcat;
                labNumOpenedSanda.Text = "" + numopened;
                labNumFinishedSanda.Text = "" + numfinished;
            }
        }

        public void InitializeListCategorias (List<String> categorias)
        {
            foreach (String cat in categorias)
                listCategorias.Items.Add(cat);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ControlButtons1_Load(object sender, EventArgs e)
        {

        }

        private void ButVerSanda_Click(object sender, EventArgs e)
        {
            Main.ShowView("CatSanda");        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Main.ShowView("CatFormas");
        }
    }
}
