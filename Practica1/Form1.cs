using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class frmMiPrimeraApp : Form
    {
        public frmMiPrimeraApp()
        {
            InitializeComponent();
        }
        //Comentare las finalidades de los eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            //Mostrar un mensaje apenas inicie la app
            MessageBox.Show("Bienvenido a C#");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Mostrar un mensaje al cerrar la app
            MessageBox.Show("Gracias por utilizar mi app...");
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //Mostrar un mensaje
            //MessageBox.Show("Se disparó el evento clic" + ", atención");
            //Al dispararse el evento, se cambia el color del formulario a azul
            //this.BackColor = Color.Blue;
            //Cambio el color si el TextBox esta vacio y hago clic en el boton prueba
            if (txtBxTest.Text == "")
                txtBxTest.BackColor = Color.Red;
            //Si tiene un valor, no tendra el color rojo
            else
                txtBxTest.BackColor = System.Drawing.SystemColors.Control;

        }

        private void MiPrimeraApp_Click(object sender, EventArgs e)
        {
            //Manejo el evento para mostrar que clic se presionó
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el click izquierdo" + ", atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el click derecho" + ", atención");
            else if (click.Button == MouseButtons.Middle)
            MessageBox.Show("Presionó el click del medio" + ", atención");
        }

        private void lblPrueba_MouseMove(object sender, MouseEventArgs e)
        {
            //Cambio el color de la propiedad "BackColor"
            lblPrueba.BackColor = Color.Red;
            //Cambio el estilo del cursor al estar en la etiqueta
            lblPrueba.Cursor = Cursors.Hand;
        }

        private void lblPrueba_MouseLeave(object sender, EventArgs e)
        {
            //Al dispararse este evento, se vuelve al color original
            lblPrueba.BackColor = System.Drawing.SystemColors.Control;
            //Cambio el estilo del cursor al dejar la etiqueta
            lblPrueba.Cursor = Cursors.Arrow;
        }

        private void txtBxTest_MouseLeave(object sender, EventArgs e)
        {
            //Muestra la cantidad de cararcteres que tiene una vez que el mouse se va
            MessageBox.Show("Tiene " + txtBxTest.Text.Length + " caracteres");
        }

        private void txtBxTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Manejo el evento para que ingrese solo numeros
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
