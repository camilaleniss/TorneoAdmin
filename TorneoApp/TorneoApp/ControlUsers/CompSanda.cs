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
    public partial class CompSanda : UserControl
    {

        public MainWindow Main { get; set; }
        public int IndexCategoria { get; set; }
        public CompSanda()
        {
            InitializeComponent();
        }

        private void CompSanda_Load(object sender, EventArgs e)
        {

        }

        public void InitCategories(List<string> categories)
        {
            foreach (string category in categories)
                comboCategory.Items.Add(category);
        }

        public void MostrarCombates(List<string> combates)
        {
            listCombates.Clear();
            foreach(string combate in combates)
            {
                listCombates.Items.Add(combate);
            }
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexCategoria = comboCategory.SelectedIndex;
            Main.MostrarRondas(IndexCategoria);
        }
    }
}
