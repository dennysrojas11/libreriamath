namespace WinAppMath
{
    partial class Form1
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.groupBoxRespuesta = new System.Windows.Forms.GroupBox();
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelOperaciones = new System.Windows.Forms.Label();
            this.comboBoxOperaciones = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNota = new System.Windows.Forms.Label();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.groupBoxRespuesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(123, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(500, 38);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Operaciones de la librería Math";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(57, 117);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(121, 32);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Número";
            // 
            // groupBoxRespuesta
            // 
            this.groupBoxRespuesta.Controls.Add(this.labelRespuesta);
            this.groupBoxRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRespuesta.Location = new System.Drawing.Point(513, 106);
            this.groupBoxRespuesta.Name = "groupBoxRespuesta";
            this.groupBoxRespuesta.Size = new System.Drawing.Size(240, 176);
            this.groupBoxRespuesta.TabIndex = 2;
            this.groupBoxRespuesta.TabStop = false;
            this.groupBoxRespuesta.Text = "Resultado";
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta.Location = new System.Drawing.Point(76, 79);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(71, 32);
            this.labelRespuesta.TabIndex = 3;
            this.labelRespuesta.Text = "0,00";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(251, 115);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(225, 34);
            this.textBoxNumero.TabIndex = 3;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // labelOperaciones
            // 
            this.labelOperaciones.AutoSize = true;
            this.labelOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperaciones.Location = new System.Drawing.Point(57, 227);
            this.labelOperaciones.Name = "labelOperaciones";
            this.labelOperaciones.Size = new System.Drawing.Size(188, 32);
            this.labelOperaciones.TabIndex = 4;
            this.labelOperaciones.Text = "Operaciones";
            // 
            // comboBoxOperaciones
            // 
            this.comboBoxOperaciones.FormattingEnabled = true;
            this.comboBoxOperaciones.Items.AddRange(new object[] {
            "Valor absoluto",
            "Ángulo del coseno",
            "Ángulo del seno",
            "Ángulo de la tangente",
            "Multiplicar",
            "Valor integral",
            "Coseno",
            "Coseno hiperbólico",
            "DivRem",
            "Exponencial",
            "Piso",
            "IEEERemainder",
            "Logaritmo Natural",
            "Logaritmo en base 10",
            "Máximo",
            "Mínimo",
            "Potencia",
            "Redondear",
            "Signo",
            "Seno",
            "Seno hiperbólico",
            "Raiz",
            "Tangente",
            "Tangente hiperbólica",
            "Truncar"});
            this.comboBoxOperaciones.Location = new System.Drawing.Point(251, 235);
            this.comboBoxOperaciones.Name = "comboBoxOperaciones";
            this.comboBoxOperaciones.Size = new System.Drawing.Size(225, 24);
            this.comboBoxOperaciones.TabIndex = 5;
            this.comboBoxOperaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperaciones_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppMath.Properties.Resources.math;
            this.pictureBox1.Location = new System.Drawing.Point(63, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota.Location = new System.Drawing.Point(60, 290);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(38, 17);
            this.labelNota.TabIndex = 4;
            this.labelNota.Text = "label";
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero2.Location = new System.Drawing.Point(251, 166);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(225, 34);
            this.textBoxNumero2.TabIndex = 8;
            this.textBoxNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero2_KeyPress);
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero2.Location = new System.Drawing.Point(57, 168);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(146, 32);
            this.labelNumero2.TabIndex = 7;
            this.labelNumero2.Text = "Número 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxOperaciones);
            this.Controls.Add(this.labelOperaciones);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.groupBoxRespuesta);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRespuesta.ResumeLayout(false);
            this.groupBoxRespuesta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.GroupBox groupBoxRespuesta;
        private System.Windows.Forms.Label labelRespuesta;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelOperaciones;
        private System.Windows.Forms.ComboBox comboBoxOperaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Label labelNumero2;
    }
}

