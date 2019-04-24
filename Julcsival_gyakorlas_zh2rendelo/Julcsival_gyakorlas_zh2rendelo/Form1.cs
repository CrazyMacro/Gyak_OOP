using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Julcsival_gyakorlas_zh2rendelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void újBetegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BetegFelvetelForm betegFelvetelForm = new BetegFelvetelForm();
            betegFelvetelForm.Show();
        }
    }
}
