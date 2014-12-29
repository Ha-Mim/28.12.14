using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefrigeratorUI : Form
    {
        public RefrigeratorUI()
        {
            InitializeComponent();
        }
        Refrigerator aRefrigerator;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator = new Refrigerator(Convert.ToDouble(maxWeightTextBox.Text));
            
            MessageBox.Show("Information has been added.");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
           
                    double noOfItem = Convert.ToDouble(noOfItemsTextBox.Text);
                    double itemWeight = Convert.ToDouble(weightTextBox.Text);
                try
                {
                    aRefrigerator.AddItems(noOfItem,itemWeight);
                    currentWeightTextBox.Text = aRefrigerator.CurrentWeight.ToString();
                    remainingWeightTextBox.Text = aRefrigerator.RemainingWeight.ToString();
                    
                }
                catch (Exception exceptionObj)
                {
                    MessageBox.Show("Refrigarator is Overloaded.");
                }
            
        }
    }
}
