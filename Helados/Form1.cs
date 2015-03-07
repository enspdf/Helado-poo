using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Helados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtTotal.Enabled = false;
            cbTipos_helados.Items.Add("Vainilla");
            cbTipos_helados.Items.Add("Chocolate");
            cbTipos_helados.Items.Add("Caramelo");
            cbTipos_helados.Items.Add("Mora");
            cbTipos_helados.Items.Add("Melocoton");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo puedes ingresar numeros");
                txtCantidad.Clear();
            }
            if (char.IsDigit(e.KeyChar))
            {
                Helado hel = new Helado();
                hel.TipoHelado = cbTipos_helados.Text;
                int costo = hel.Valor;
                int can = hel.Cantidad;
                can = Int32.Parse(txtCantidad.Text);
                int total = costo * can;
                txtTotal.Text = total.ToString();
            }*/
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Helado hel = new Helado();
            hel.TipoHelado = cbTipos_helados.Text;
            int costo = hel.Valor;
            int can = hel.Cantidad = int.Parse(txtCantidad.Text);
            int total = costo * can;
            txtTotal.Text = total.ToString();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("helado.txt");
            escribir.Write("Helado: " + cbTipos_helados.Text);
            escribir.Write(System.Environment.NewLine + "Cantidad: " + txtCantidad.Text);
            escribir.Write(System.Environment.NewLine + "Total a pagar: " + txtTotal.Text);
            escribir.Close();

            Process notepad = Process.Start("notepad.exe", "helado.txt");
            //this.Close();
        }
    }
}
