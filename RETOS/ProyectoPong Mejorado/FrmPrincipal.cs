using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class FrmPrincipal : Form
    {
        int velocidad; // Velocidad de la pelota
        int direccion; // Dirección de la pelota
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private int CalculaDireccion()
        {
            Random num = new Random();
            return num.Next(1, 5); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrMover.Enabled = true;           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrMover.Enabled = false;
        }

        private void tmrMover_Tick(object sender, EventArgs e)
        {
            try
            {
                switch(direccion)
                {
                    case 1: // Abajo-Derecha
                        pctBola.Left += velocidad;
                        pctBola.Top += velocidad;
                        if (pctBola.Top + pctBola.Height*2 >= this.Height )
                            direccion = 2;
                        if (pctBola.Left + pctBola.Size.Width >= this.Width)
                            direccion = 3;
                        break;

                    case 2: // Arriba-Derecha
                        pctBola.Left += velocidad;
                        pctBola.Top -= velocidad;
                        if (pctBola.Top <=0) direccion = 1;
                        if (pctBola.Left + pctBola.Size.Width >= this.Width)
                            direccion = 4;
                        break;

                    case 3: // Abajo-Izquierda
                        pctBola.Left -= velocidad;
                        pctBola.Top += velocidad;
                        if (pctBola.Top + pctBola.Size.Height*2 >= this.Height) direccion = 4;
                        if (pctBola.Left <= 0) direccion = 1;
                        break;

                    case 4: // Arriba-Izquierda
                        pctBola.Left -= velocidad;
                        pctBola.Top -= velocidad;
                        if (pctBola.Top <=0) direccion = 3;
                        if (pctBola.Left <= 0) direccion = 2;
                        break;
                }

            }
            catch
            {
                MessageBox.Show("Error de dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            velocidad = tckVelocidad.Value;
            direccion = CalculaDireccion();
        }

        private void tckVelocidad_Scroll(object sender, EventArgs e)
        {
            velocidad = tckVelocidad.Value;
        }
    }
}
