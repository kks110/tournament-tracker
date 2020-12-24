using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
        }

        private bool validateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
                MessageBox.Show("Place number needs to be an Int");
            }

            if (placeNumber < 1)
            {
                output = false;
                MessageBox.Show("Place number needs to be greater than 1");
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Please enter a place name");
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);
            
            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
                MessageBox.Show("Prize amount and prize percentage must be ints");
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
                MessageBox.Show("Please enter a prize amount or percentage");
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
                MessageBox.Show("Please enter a percentage between 0 and 100");
            }

            return output;
        }
    }
}