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
    public partial class CompFormas : UserControl
    {
        public MainWindow Main { get; set; }

        public int IndexCategoria { get; set; }

        public CompFormas()
        {
            InitializeComponent();
        }

        public void InitializePodium(string[] podium)
        {
            this.textFirst.Text = podium[0];
            this.textSecond.Text = podium[1];
            this.textThird.Text = podium[2];
        }

        public void InitCategories(List<String> categorias)
        {
            foreach (String cat in categorias)
                comboCategory.Items.Add(cat);
        }

        public void InitializeRestantes(List<String> restantes)
        {
            foreach (String r in restantes)
                listRestantes.Items.Add(r);
        }

        public void InitializeCalificadas(List<String> calificadas)
        {
            foreach (String c in calificadas)
                listHechas.Items.Add(c);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           IndexCategoria = comboCategory.SelectedIndex;
           Main.InitializePresentaciones(IndexCategoria);
        }

        private void CompFormas_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
