using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester CallerForm;
        public CreatePrizeForm(IPrizeRequester Caller)
        {
            InitializeComponent();
            CallerForm = Caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidatForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    priceAmountValue.Text,
                    PricePercentage.Text);

                GlobalConfig.Connection.CreatePrizes(model);

                CallerForm.PrizeComplete(model);

                this.Close();
                //placeNameValue.Text = "";
                //placeNumberValue.Text = "";
                //priceAmountValue.Text = "0";
                //PricePercentage.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information, check it and try agian.");
            }

        }

        private bool ValidatForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool PlaceNumberValidate = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!PlaceNumberValidate || placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool PrizeAmountValid = decimal.TryParse(priceAmountValue.Text, out prizeAmount);
            bool prizePercentValid = double.TryParse(PricePercentage.Text, out prizePercentage);

            if (!PrizeAmountValid || !prizePercentValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
