namespace EX1_geaphique
{
    public partial class windows_1 : Form
    {
        const double TauxChange_CH = 1.05;
        const double TauxChange_JP = 0.0061;
        const double TauxChange_GB = 1.17;
        const double TauxChange_US = 0.92;
        string contry;
       
        



        public windows_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PicDevise.Image = Properties.Resources.flag_GB;
            contry = "GB";
        }

        private void PicDevise_Click(object sender, EventArgs e)
        {
            

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double Montant = double.Parse(txtMontant.Text);
            double Resultat = 0;
            switch (contry)
            {
                case "CH":
                    Resultat =  Montant * TauxChange_CH;

                    break;
                case "JP":
                    Resultat = Montant * TauxChange_JP;

                    break;
                case "GB":
                    Resultat = Montant * TauxChange_GB;

                    break;
                case "US":
                    Resultat = Montant * TauxChange_US;
                    break;

            }
            txtResultat.Text = Resultat.ToString();


        }

        private void rbnSFR_CheckedChanged(object sender, EventArgs e)
        {
            PicDevise.Image = Properties.Resources.flag_CH;
            contry = "CH";
        }

        private void rbnUSD_CheckedChanged(object sender, EventArgs e)
        {
            PicDevise.Image = Properties.Resources.flag_US;
            contry = "US";
        }

        private void rbnYEN_CheckedChanged(object sender, EventArgs e)
        {
            PicDevise.Image = Properties.Resources.flag_japon;
            contry = "JP";
        }
    }
}