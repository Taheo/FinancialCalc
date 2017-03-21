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
        List<string> partylist = new List<string>();
        List<string> transportlist = new List<string>();
        List<string> bookslist = new List<string>();
        List<string> otherslist = new List<string>();

        
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
                    foodlist.Add(cost);
                    break;
                case "Party":
                    party.AppendText(cost);
                    party.AppendText(Environment.NewLine);
                    partylist.Add(cost);
                    break;
                case "Transport":
                    transport.AppendText(cost);
                    transport.AppendText(Environment.NewLine);
                    transportlist.Add(cost);
                    break;
                case "Books":
                    books.AppendText(cost);
                    books.AppendText(Environment.NewLine);
                    bookslist.Add(cost);
                    break;
                case "Others":
                    others.AppendText(cost);
                    others.AppendText(Environment.NewLine);
                    otherslist.Add(cost);
                    break;
            }
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            sumlabel.Text =
                (
                 foodlist.ConvertAll(item => double.Parse(item)).Sum() +
                 partylist.ConvertAll(item => double.Parse(item)).Sum() +
                 transportlist.ConvertAll(item => double.Parse(item)).Sum() +
                 bookslist.ConvertAll(item => double.Parse(item)).Sum() +
                 otherslist.ConvertAll(item => double.Parse(item)).Sum()
                 ).ToString();
        }

        private void foodlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
