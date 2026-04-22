
namespace Pong
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pctBola = new System.Windows.Forms.PictureBox();
            this.tmrMover = new System.Windows.Forms.Timer(this.components);
            this.tckVelocidad = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pctBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(670, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(670, 364);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(670, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pctBola
            // 
            this.pctBola.Image = global::Pong.Properties.Resources.bola;
            this.pctBola.Location = new System.Drawing.Point(361, 190);
            this.pctBola.Name = "pctBola";
            this.pctBola.Size = new System.Drawing.Size(51, 49);
            this.pctBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBola.TabIndex = 3;
            this.pctBola.TabStop = false;
            // 
            // tmrMover
            // 
            this.tmrMover.Interval = 20;
            this.tmrMover.Tick += new System.EventHandler(this.tmrMover_Tick);
            // 
            // tckVelocidad
            // 
            this.tckVelocidad.LargeChange = 1;
            this.tckVelocidad.Location = new System.Drawing.Point(670, 274);
            this.tckVelocidad.Minimum = 1;
            this.tckVelocidad.Name = "tckVelocidad";
            this.tckVelocidad.Size = new System.Drawing.Size(109, 45);
            this.tckVelocidad.TabIndex = 4;
            this.tckVelocidad.TabStop = false;
            this.tckVelocidad.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckVelocidad.Value = 5;
            this.tckVelocidad.Scroll += new System.EventHandler(this.tckVelocidad_Scroll);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctBola);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tckVelocidad);
            this.MinimumSize = new System.Drawing.Size(408, 245);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVelocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pctBola;
        private System.Windows.Forms.Timer tmrMover;
        private System.Windows.Forms.TrackBar tckVelocidad;
    }
}

