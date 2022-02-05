namespace Practica1
{
    partial class frmMiPrimeraApp
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.txtBxPrueba = new System.Windows.Forms.TextBox();
            this.txtBxTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.Location = new System.Drawing.Point(326, 79);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrueba.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPrueba.Location = new System.Drawing.Point(225, 81);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(57, 19);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Prueba";
            this.lblPrueba.MouseLeave += new System.EventHandler(this.lblPrueba_MouseLeave);
            this.lblPrueba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPrueba_MouseMove);
            // 
            // txtBxPrueba
            // 
            this.txtBxPrueba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxPrueba.Location = new System.Drawing.Point(301, 157);
            this.txtBxPrueba.MaxLength = 40000;
            this.txtBxPrueba.Name = "txtBxPrueba";
            this.txtBxPrueba.Size = new System.Drawing.Size(100, 20);
            this.txtBxPrueba.TabIndex = 2;
            // 
            // txtBxTest
            // 
            this.txtBxTest.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBxTest.Location = new System.Drawing.Point(301, 196);
            this.txtBxTest.Multiline = true;
            this.txtBxTest.Name = "txtBxTest";
            this.txtBxTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxTest.Size = new System.Drawing.Size(100, 20);
            this.txtBxTest.TabIndex = 3;
            this.txtBxTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxTest_KeyPress);
            this.txtBxTest.MouseLeave += new System.EventHandler(this.txtBxTest_MouseLeave);
            // 
            // frmMiPrimeraApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxTest);
            this.Controls.Add(this.txtBxPrueba);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.btnPrueba);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMiPrimeraApp";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPrimeraApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MiPrimeraApp_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.TextBox txtBxPrueba;
        private System.Windows.Forms.TextBox txtBxTest;
    }
}

