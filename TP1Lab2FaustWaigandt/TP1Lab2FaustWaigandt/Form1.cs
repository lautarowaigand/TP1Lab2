﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1Lab2FaustWaigandt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            int[] coord = new int[2];
            coord[0] = Convert.ToInt32(NudX.Value);
            coord[1] = Convert.ToInt32(NudY.Value);
            int quesos = Convert.ToInt32(NudQuesos.Value);
            int ratones =Convert.ToInt32(NudRatones.Value); 
            FormIsla i = new FormIsla(coord,quesos,ratones);
            i.Show();
        }
    }
}
