namespace ConversorDeMonedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            añadirComplementos();
            btnCalcular.Click += btnCalcular_Click;
        }

        private void añadirComplementos() // Añade las etiquetas del ComboBox
        {
            cmbMonedas.Items.Add("USD - Dólar estadounidense");
            cmbMonedas.Items.Add("MXN - Peso mexicano");
            cmbMonedas.Items.Add("CAD - Dólar canadiense");
            cmbMonedas.Items.Add("EUR - Euro");
            cmbMonedas.Items.Add("JPY - Yen japonés");
        }

        private void btnCalcular_Click(object sender, EventArgs e) // Evento al presionar el botón calcular
        {
            if (cmbMonedas.SelectedItem == null || string.IsNullOrEmpty(txtMonto.Text))
            {
                MessageBox.Show("Por favor, selecciona una moneda e introduce un monto.");
                return;
            }

            string monedaSeleccionada = cmbMonedas.SelectedItem.ToString();

            // Separa la abreviatura de la moneda para realizar las conversiones
            string[] parts = monedaSeleccionada.Split('-');
            string abreviaturaMoneda = parts[0].Trim(); // Obtiene la abreviatura de la moneda
            double monto = Convert.ToDouble(txtMonto.Text);

            // Realizar conversiones según la moneda seleccionada
            switch (abreviaturaMoneda)
            {
                case "MXN":
                    double montoMXN = monto;
                    double montoUSD_MXN = monto * 0.050; // Tasa de conversión de Peso Mexicano a Dólar estadounidense
                    double montoCAD_MXN = monto * 0.060; // Tasa de conversión de Peso Mexicano a Dólar Canadiense
                    double montoEUR_MXN = monto * 0.040; // Tasa de conversión de Peso Mexicano a Euro
                    double montoYEN_MXN = monto * 5.32; // Tasa de conversión de Peso Mexicano a Yen japonés

                    txtMXN.Text = "$ " + montoMXN.ToString();
                    txtDolarUSD.Text = "$ " + montoUSD_MXN.ToString();
                    txtDolar.Text = "$ " + montoCAD_MXN.ToString();
                    txtEUR.Text = "€ " + montoEUR_MXN.ToString();
                    txtYen.Text = "¥ " + montoYEN_MXN.ToString();
                    break;

                case "USD":
                    double montoUSD = monto;
                    double montoMXN_USD = monto * 21.23;
                    double montoCAD_USD = monto * 1.28;
                    double montoEUR_USD = monto * 0.89;
                    double montoYEN_USD = monto * 113.05;

                    txtDolar.Text = "$ " + montoCAD_USD.ToString();
                    txtDolarUSD.Text = "$ " + montoUSD.ToString();
                    txtEUR.Text = "€ " + montoEUR_USD.ToString();
                    txtMXN.Text = "$ " + montoMXN_USD.ToString();
                    txtYen.Text = "¥ " + montoYEN_USD.ToString();
                    break;

                case "CAD":
                    double montoCAD = monto;
                    double montoMXN_CAD = monto * 16.55;
                    double montoUSD_CAD = monto * 0.78;
                    double montoEUR_CAD = monto * 0.69;
                    double montoYEN_CAD = monto * 88.12;

                    txtDolar.Text = "$ " + montoCAD.ToString();
                    txtDolarUSD.Text = "$ " + montoUSD_CAD.ToString();
                    txtEUR.Text = "€ " + montoEUR_CAD.ToString();
                    txtMXN.Text = "$ " + montoMXN_CAD.ToString();
                    txtYen.Text = "¥ " + montoYEN_CAD.ToString();
                    break;

                case "EUR":
                    double montoEUR = monto;
                    double montoMXN_EUR = monto * 23.96;
                    double montoCAD_EUR = monto * 1.45;
                    double montoUSD_EUR = monto * 1.13;
                    double montoYEN_EUR = monto * 127.56;

                    txtDolar.Text = "$ " + montoCAD_EUR.ToString();
                    txtDolarUSD.Text = "$ " + montoUSD_EUR.ToString();
                    txtEUR.Text = "€ " + montoEUR.ToString();
                    txtMXN.Text = "$ " + montoMXN_EUR.ToString();
                    txtYen.Text = "¥ " + montoYEN_EUR.ToString();
                    break;

                case "JPY":
                    double montoJPY = monto;
                    double montoMXN_JPY = monto * 0.1878;
                    double montoUSD_JPY = monto * 0.0088;
                    double montoCAD_JPY = monto * 0.0113;
                    double montoEUR_JPY = monto * 0.0078;

                    txtDolar.Text = "$ " + montoCAD_JPY.ToString();
                    txtDolarUSD.Text = "$ " + montoUSD_JPY.ToString();
                    txtEUR.Text = "€ " + montoEUR_JPY.ToString();
                    txtMXN.Text = "$ " + montoMXN_JPY.ToString();
                    txtYen.Text = "¥ " + montoJPY.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
