﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneoApp.Model;

namespace TorneoApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            Application.Run(new MainWindow());
        }
    }
}
