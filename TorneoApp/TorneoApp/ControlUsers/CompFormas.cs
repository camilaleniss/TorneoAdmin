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

        public string NameCompetidor { get; set; }

        public CompFormas()
        {
            InitializeComponent();
        }

        public void InitializePodium(string[] podium)
        {
            this.txtFirst.Text = podium[0];
            this.txtSecond.Text = podium[1];
            this.txtThird.Text = podium[2];
        }

        public void InitCategories(List<String> categorias)
        {

            foreach (String cat in categorias)
                comboCategory.Items.Add(cat);
        }

        public void InitializeRestantes(List<String> restantes)
        {
            listRestantes.Clear();
            foreach (String r in restantes)
                listRestantes.Items.Add(r);
        }

        public void InitializeCalificadas(List<String> calificadas)
        {
            listHechas.Clear();
            foreach (String c in calificadas)
                listHechas.Items.Add(c);
        }

        public void InitializePresentacion (double[] jueces, double calificacion)
        {
            txtJuez1.Text =  Math.Round(jueces[0], 1) +"";
            txtJuez2.Text = Math.Round(jueces[1], 1) + "";
            txtJuez3.Text = Math.Round(jueces[2], 1) + "";
            txtResult.Text = Math.Round(calificacion, 1) + "";
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

        private void ListRestantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRestantes.SelectedIndices.Count > 0)
            {
                NameCompetidor = listRestantes.SelectedItems[0].Text;
                ShowInfo();
            }
        }

        public void SetTextResult(double result)
        {
            txtResult.Text = Math.Round(result, 1) + "";
        }

        private void ListHechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHechas.SelectedIndices.Count > 0)
            {
                NameCompetidor = listHechas.SelectedItems[0].Text;
                ShowInfo();
            }
        }

        public void ShowInfo()
        {
            labNomCompetidor.Text = NameCompetidor;
            Main.ShowPresentacion(NameCompetidor);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                double[] jueces = new double[Torneo.NUM_JUECES];

                jueces[0] = Double.Parse(txtJuez1.Text);
                jueces[1] = Double.Parse(txtJuez2.Text);
                jueces[2] = Double.Parse(txtJuez3.Text);

                double Calificacion = Main.SendCalificacionFormas(jueces);

                txtResult.Text = Math.Round(Calificacion, 1) + "";

                Main.InitializePresentaciones(IndexCategoria);
            }catch(Exception exp)
            {
                txtJuez1.Text = "";
                txtJuez2.Text = "";
                txtJuez3.Text = "";
                MessageBox.Show("Datos no validos");
            }
        }
    }
}
