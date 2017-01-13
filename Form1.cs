//Nathan Stopinski
//CIS199-01
//Due Feb 16
//Program 1
//Purpose of Program1 is to explore the use of variables and simple arithmetic using a paint job estimate format

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Prog1 : Form
    {
        public Prog1()
        {
            InitializeComponent();
          
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            const double SQFTGALLON = 325;                                    //To hold constant variable for amount of sq footage per can of paint.       
            const double LABORGALLON = 8;                                     //To hold constant variable for amount of labor hours is needed per gallon of paint.           
            const double LABORHOUR = 10.50;                                   //To hold constant variable for pay rate per hour of labor.

            double sqFtNeeded;                                                //To hold total square footage needed for paint job.
            double gallonsNeeded;                                             //To hold total gallons of paint needed for paint job.
            double paintNeeded;                                               //To hold total gallons of paint needed rounded to next whole number for accuracy.
            double laborNeeded;                                               //To hold total hours of labor needed to do pain job.
            double paintCost;                                                 //To hold the cost for the number of gallons of paint needed
            double totalLabor;                                                //To hold the cost of labor for the paint job
            double totalCost;                                                 //To hold the total cost for the paint job.
            byte coatsInput = byte.Parse(coatsNeededTextBox.Text);            //To hold number of coats input box into variable
            double sqFtInput = double.Parse(sqFtTextBox.Text);                //To hold number of sqft input box into variable
            double costPaintInput = double.Parse(paintPriceTextBox.Text);     //To hold cost per gallon of paint input into variable.
                   
            sqFtNeeded = sqFtInput * coatsInput; 
            totalSqFtOutput.Text = sqFtNeeded.ToString("n1");

            gallonsNeeded = sqFtNeeded / SQFTGALLON;
            paintNeeded = Math.Ceiling(gallonsNeeded);
            paintGallonsOutput.Text = paintNeeded.ToString("n0");

            laborNeeded = gallonsNeeded * LABORGALLON;
            laborOutput.Text = laborNeeded.ToString("n1");
            
            paintCost = costPaintInput * paintNeeded;
            paintCostOutput.Text = paintCost.ToString("C");
                    
            totalLabor = LABORHOUR * laborNeeded;
            laborCostOutput.Text = totalLabor.ToString("C");
            
            totalCost = totalLabor + paintCost;  
            totalCostOutput.Text = totalCost.ToString("C");
                        
        }

        private void Prog1_Load(object sender, EventArgs e)
        {

        }             

    }
}
