using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxTotal


/** =========================================================
 Kristi Mathis

 Windows 10

 Microsoft Visual Studio 2017 Community Edition
 CIS 169
 Chapter 03 Programming Assignment

 Program Description: This program will take a meal cost
 and calcuate a tip amount, tax amount, and grand total.


 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/

{
    public partial class TipTaxTotal : Form
    {
        public TipTaxTotal()

        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal TIP_PERCENT = .15m;        //15% tip
                const decimal SALES_TAX_PERCENT = .07m; //7% Sales Tax
                decimal mealCost;                      //To hold the meal cost
                decimal tipAmount;                     //To hold the tip amount
                decimal taxAmount;                     //To hold the tax amount
                decimal grandTotal;                    //To hold the grand total

                //Get the amount of the meal from the text box and 
                //assign it to the mealCost variable
                mealCost = decimal.Parse(mealTextBox.Text);

                //Calculate the tip amount based on meal and 15% tip
                tipAmount = mealCost * TIP_PERCENT;

                //Calculate the tax amount based on 7% sales tax
                taxAmount = mealCost * SALES_TAX_PERCENT;

                //Calculate the total for all 3
                grandTotal = mealCost + tipAmount + taxAmount;

                //Display the tip amount in the tip label
                displayTipLabel.Text = tipAmount.ToString("c");

                //Display the tax amount in the tax label
                displayTaxLabel.Text = taxAmount.ToString("c");

                //display the grand total in the total label
                displayTotalLabel.Text = grandTotal.ToString("c");

            }
            catch (Exception ex)
            {
                //Display the default error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
