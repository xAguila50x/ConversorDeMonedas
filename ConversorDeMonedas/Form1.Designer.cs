namespace ConversorDeMonedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMoneda = new Label();
            lblMonto = new Label();
            cmbMonedas = new ComboBox();
            txtMonto = new TextBox();
            lblConverciones = new Label();
            lblPesoMex = new Label();
            lblCADdolar = new Label();
            lblEuro = new Label();
            label1 = new Label();
            txtMXN = new TextBox();
            txtDolar = new TextBox();
            txtEUR = new TextBox();
            txtYen = new TextBox();
            btnCalcular = new Button();
            lblDolarUSD = new Label();
            txtDolarUSD = new TextBox();
            SuspendLayout();
            // 
            // lblMoneda
            // 
            lblMoneda.AutoSize = true;
            lblMoneda.Location = new Point(15, 14);
            lblMoneda.Name = "lblMoneda";
            lblMoneda.Size = new Size(51, 15);
            lblMoneda.TabIndex = 0;
            lblMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(203, 14);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto";
            // 
            // cmbMonedas
            // 
            cmbMonedas.FormattingEnabled = true;
            cmbMonedas.Location = new Point(12, 32);
            cmbMonedas.Name = "cmbMonedas";
            cmbMonedas.Size = new Size(180, 23);
            cmbMonedas.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(203, 32);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(128, 23);
            txtMonto.TabIndex = 3;
            // 
            // lblConverciones
            // 
            lblConverciones.AutoSize = true;
            lblConverciones.Location = new Point(15, 106);
            lblConverciones.Name = "lblConverciones";
            lblConverciones.Size = new Size(79, 15);
            lblConverciones.TabIndex = 4;
            lblConverciones.Text = "Converciones";
            // 
            // lblPesoMex
            // 
            lblPesoMex.AutoSize = true;
            lblPesoMex.Location = new Point(15, 131);
            lblPesoMex.Name = "lblPesoMex";
            lblPesoMex.Size = new Size(70, 15);
            lblPesoMex.TabIndex = 5;
            lblPesoMex.Text = "MXN - Peso";
            // 
            // lblCADdolar
            // 
            lblCADdolar.AutoSize = true;
            lblCADdolar.Location = new Point(15, 163);
            lblCADdolar.Name = "lblCADdolar";
            lblCADdolar.Size = new Size(70, 15);
            lblCADdolar.TabIndex = 6;
            lblCADdolar.Text = "CAD - Dólar";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(15, 197);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(63, 15);
            lblEuro.TabIndex = 7;
            lblEuro.Text = "EUR - Euro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 227);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "JPY - Yen japonés";
            // 
            // txtMXN
            // 
            txtMXN.Location = new Point(203, 123);
            txtMXN.Name = "txtMXN";
            txtMXN.Size = new Size(128, 23);
            txtMXN.TabIndex = 9;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(203, 155);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(128, 23);
            txtDolar.TabIndex = 10;
            // 
            // txtEUR
            // 
            txtEUR.Location = new Point(203, 189);
            txtEUR.Name = "txtEUR";
            txtEUR.Size = new Size(128, 23);
            txtEUR.TabIndex = 11;
            // 
            // txtYen
            // 
            txtYen.Location = new Point(203, 219);
            txtYen.Name = "txtYen";
            txtYen.Size = new Size(128, 23);
            txtYen.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(203, 76);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 23);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblDolarUSD
            // 
            lblDolarUSD.AutoSize = true;
            lblDolarUSD.Location = new Point(15, 259);
            lblDolarUSD.Name = "lblDolarUSD";
            lblDolarUSD.Size = new Size(65, 15);
            lblDolarUSD.TabIndex = 14;
            lblDolarUSD.Text = "USD -Dolar";
            // 
            // txtDolarUSD
            // 
            txtDolarUSD.Location = new Point(203, 251);
            txtDolarUSD.Name = "txtDolarUSD";
            txtDolarUSD.Size = new Size(128, 23);
            txtDolarUSD.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 321);
            Controls.Add(txtDolarUSD);
            Controls.Add(lblDolarUSD);
            Controls.Add(btnCalcular);
            Controls.Add(txtYen);
            Controls.Add(txtEUR);
            Controls.Add(txtDolar);
            Controls.Add(txtMXN);
            Controls.Add(label1);
            Controls.Add(lblEuro);
            Controls.Add(lblCADdolar);
            Controls.Add(lblPesoMex);
            Controls.Add(lblConverciones);
            Controls.Add(txtMonto);
            Controls.Add(cmbMonedas);
            Controls.Add(lblMonto);
            Controls.Add(lblMoneda);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMoneda;
        private Label lblMonto;
        private ComboBox cmbMonedas;
        private TextBox txtMonto;
        private Label lblConverciones;
        private Label lblPesoMex;
        private Label lblCADdolar;
        private Label lblEuro;
        private Label label1;
        private TextBox txtMXN;
        private TextBox txtDolar;
        private TextBox txtEUR;
        private TextBox txtYen;
        private Button btnCalcular;
        private Label lblDolarUSD;
        private TextBox txtDolarUSD;
    }
}