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

        public int IndexCombate { get; set; }

        public int IndexRonda { get; set; }
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

        public void MostrarRondas(Round r)
        {
            juez1Azul.Text = r.Puntajes[0, 0].ToString();
            juez2Azul.Text = r.Puntajes[0, 1].ToString();
            juez3Azul.Text = r.Puntajes[0, 2].ToString();
            juez1Rojo.Text = r.Puntajes[1, 0].ToString();
            juez2Rojo.Text = r.Puntajes[1, 1].ToString();
            juez3Rojo.Text = r.Puntajes[1, 2].ToString();

        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexCategoria = comboCategory.SelectedIndex;
            Main.MostrarCombates(IndexCategoria);
        }

        private void ListCombates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCombates.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listCombates.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                string text = listCombates.Items[intselectedindex].Text;
                IndexCombate = intselectedindex;
                nombreDelCombate.Text = text;
                VaciarRondas();
            }
        }

        private void ComboBoxRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexRonda = comboBoxRound.SelectedIndex;
            Main.MostrarPuntajeRonda(IndexCategoria, IndexCombate, comboBoxRound.SelectedIndex);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int[,] puntajes = new int[2, 3];
            puntajes[0, 0] = int.Parse(juez1Azul.Text);
            puntajes[0, 1] = int.Parse(juez2Azul.Text);
            puntajes[0, 2] = int.Parse(juez3Azul.Text);
            puntajes[1, 0] = int.Parse(juez1Rojo.Text);
            puntajes[1, 1] = int.Parse(juez2Rojo.Text);
            puntajes[1, 2] = int.Parse(juez3Rojo.Text);
            Main.ModificarPuntajeRonda(IndexCategoria, IndexCombate, IndexRonda, puntajes);
        }

        public void GanadorRonda(string ganador)
        {
            textBoxGanador.Text = ganador;
        }

        public void VaciarRondas()
        {
            juez1Azul.Text = "";
            juez2Azul.Text = "";
            juez3Azul.Text = "";
            juez1Rojo.Text = "";
            juez2Rojo.Text = "";
            juez3Rojo.Text = "";
            textBoxGanador.Text = "";
        }
    }

}
