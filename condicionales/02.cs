namespace appFP_NET.condicionales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void _02_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            const double precioUnitario = 20.0;
            double descuento = 0;
            int caramelos = 0;

            int unidades = int.Parse(txtcantidad.Text);

            // Calcular el importe de la compra
            double importeCompra = unidades * precioUnitario;

            // Determinar el porcentaje de descuento según el importe de la compra
            if (importeCompra > 700)
            {
                descuento = 0.16;
            }
            else if (importeCompra >= 501)
            {
                descuento = 0.14;
            }
            else
            {
                descuento = 0.12;
            }

            // Calcular el descuento y el total a pagar
            double montoDescuento = importeCompra * descuento;
            double totalAPagar = importeCompra - montoDescuento;

            // Determinar la cantidad de caramelos según las unidades adquiridas
            if (unidades >= 1 && unidades <= 50)
            {
                caramelos = 5;
            }
            else if (unidades >= 51 && unidades <= 100)
            {
                caramelos = 10;
            }
            else if (unidades > 100)
            {
                caramelos = 15;
            }

            // Mostrar los resultados
            txtimporte.Text = importeCompra.ToString();
            txtdescuento.Text = montoDescuento.ToString();
            txttotal.Text = totalAPagar.ToString();
            txtcaramelos.Text = caramelos.ToString();
            
        }
        }
    }
=======
            int cantidad = int.Parse(txtcantidad.Text);

            double i1 = 27 * cantidad;
            double i2 = 25 * cantidad;
            double i3 = 23 * cantidad;

            double d1 = ((i3 / 100) * 15);
            double d2 = ((i1 / 100) * 5);
            Double d3 = ((i2 / 100) * 5);

            double t1 = i1 - d2;
            double t2 = i2 - d3;
            double t3 = i3 - d1;

            if (cantidad > 0 && cantidad < 26)
            {
                txtimporte.Text = i1.ToString();
                txtdescuento.Text = d2.ToString();
                txttotal.Text = t1.ToString();
            }
            else if (cantidad > 25 && cantidad < 51)
            {
                txtimporte.Text = i2.ToString();
                txtdescuento.Text = d3.ToString();
                txttotal.Text = t2.ToString();
            }
            else if (cantidad > 50)
            {
                txtimporte.Text = i3.ToString();
                txtdescuento.Text = d1.ToString();
                txttotal.Text = t3.ToString();
            }
        }
    }
}
>>>>>>> e3cd870ea5616d31439b1aea86efcd06540783c7
