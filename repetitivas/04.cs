﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.repetitivas
{
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);

            int m = int.Parse(txt2.Text);
            // Mostrar los m múltiplos de n
            Console.WriteLine($"Los primeros {m} múltiplos de {n} son:");
            for (int i = 1; i <= m; i++)
            {
                txt3.Text= ($"{n} x {i} = {n * i}");
            }
        }
    }
}