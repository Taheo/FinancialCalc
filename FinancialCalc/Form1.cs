using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalc
{
    public partial class Form1 : Form
    {
        List<string> foodlist = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            var cost = Convert.ToString(input.Text);
            switch ((string)category.SelectedItem)
            {
                case "Food":
                    food.AppendText(cost);
                  
                    food.AppendText(Environment.NewLine);
                    break;
                case "Party":
                    party.AppendText(cost);
                    party.AppendText(Environment.NewLine);
                    break;
                case "Transport":
                    transport.AppendText(cost);
                    transport.AppendText(Environment.NewLine);
                    break;
                case "Books":
                    books.AppendText(cost);
                    books.AppendText(Environment.NewLine);
                    break;
                case "Others":
                    others.AppendText(cost);
                    others.AppendText(Environment.NewLine);
                    break;
            }
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {



        }
    }
}
