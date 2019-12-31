using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.iListTitles = new List<string>();
            Globals.iListPrices = new List<double>();            
        }

        
        private void btnFinish_Click(object sender, EventArgs e)
        {
            int i;
            
            Listing[] listings = new Listing[Globals.iListTitles.Count()];

            for (i = 0; i < listings.Count(); i++)
            {
                listings[i] = new Listing(Globals.iListTitles[i], Globals.iListPrices[i]);
            }

        }

        private void btnSaveNext_Click(object sender, EventArgs e)
        {
            Globals.iListTitles.Add(txtTitle.Text);
            Globals.iListPrices.Add(Convert.ToDouble(txtPrice.Text));
            btnSaveNext.Enabled = false;
            txtTitle.Clear();
            txtPrice.Clear();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnSaveNext.Enabled = true;
        }
    }
}
