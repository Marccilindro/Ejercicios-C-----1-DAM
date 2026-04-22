using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFMiniCalculadora
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            // No incluimos ningún código antes de la llamada a InitializeComponent().
            // Se debe ejecutar todo lo generado en el diseñador de la clase FrmPrincipal
            InitializeComponent();
            // Cambio el título del formulario
            this.Text = "MiniCalculadora Básica"; // (se puede realizar también en diseño)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Vaciamos las cajas de texto (se puede realizar también en diseño)
            // y damos el foco a la caja de texto del Operador1
            txtOper1.Text = "";
            txtOper2.Text = "";
            txtResultado.Text = "";
            txtOper1.Focus();
            // Desactivamos la caja de texto de resultados (para que no sea editable)
            txtResultado.Enabled = false;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            txtResultado.Text = op.Suma();           
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            txtResultado.Text = op.Resta();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            txtResultado.Text = op.Multiplicacion();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            txtResultado.Text = op.Division();
            if(string.IsNullOrEmpty(txtResultado.Text))
            {
                // Uso de MessageBox con sus 4 parámetros posibles (Se trabajará en la AP13)
                MessageBox.Show("Operacion no realizable","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtResultado.Text = "";
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Finaliza la aplicación (cerramos formulario y liberamos recursos)
            this.Close();
            this.Dispose();
            
            // También es posible con:
            // Application.Exit();  Cierra todos los formularios abiertos y sale de la aplicación
        }

        private void txtOper1_Enter(object sender, EventArgs e)
        {
            txtOper1.BackColor = Color.Aqua;            
        }

        private void txtOper1_Leave(object sender, EventArgs e)
        {
            txtOper1.BackColor = Color.White;            
        }

        private void txtOper2_Enter(object sender, EventArgs e)
        {
            txtOper2.BackColor = Color.Aqua;            
        }

        private void txtOper2_Leave(object sender, EventArgs e)
        {
            txtOper2.BackColor = Color.White;          
        }
    }
}
