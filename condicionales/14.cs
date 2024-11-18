<<<<<<< HEAD
﻿namespace appFP_NET.condicionales
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.condicionales
>>>>>>> e3cd870ea5616d31439b1aea86efcd06540783c7
{
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numeroTarjeta = int.Parse(txtn.Text);

            double montoCompra = double.Parse(txtm.Text);

            double descuento;

            // Verificar si el número de la tarjeta es par y no menor de 100
            if (numeroTarjeta % 2 == 0 && numeroTarjeta >= 100)
            {
                descuento = 0.15; // Descuento del 15%
            }
            else
            {
                descuento = 0.05; // Descuento del 5%
            }

            // Calcular el monto de descuento
            double montoDescuento = montoCompra * descuento;
            double montoFinal = montoCompra - montoDescuento;

            // Mostrar los resultados
<<<<<<< HEAD
            lblnt.Text = ($"Número de la Tarjeta: {numeroTarjeta}");
            lblmc.Text = ($"Monto de la Compra: ${montoCompra:F2}");
            lbld.Text = ($"Descuento Aplicado: ${montoDescuento:F2}");
            lblt.Text = ($"Monto a Pagar después del Descuento: ${montoFinal:F2}");
=======
            lblnt.Text =("\nNúmero de la Tarjeta: " + numeroTarjeta);
            lblmc.Text = ("Monto de la Compra: $" + montoCompra);
            lbld.Text = ("Descuento Aplicado: $" + montoDescuento);
            lblt.Text = ("Monto a Pagar después del Descuento: $" + montoFinal);
>>>>>>> e3cd870ea5616d31439b1aea86efcd06540783c7
        }
    }
    }