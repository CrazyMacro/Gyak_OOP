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
        List<Beteg> betegek = new List<Beteg>();

        public Form1()
        {
            InitializeComponent();
        }

        private void újBetegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BetegFelvetelForm betegFelvetelForm = new BetegFelvetelForm(betegek);
            if(betegFelvetelForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (Beteg b in betegek)
                {
                    //if (b.GetType() == typeof(IdopntosBeteg))
                    //{
                    //    IdopntosBeteg idB = (IdopntosBeteg)b;
                    //    listBox1.Items.Add(idB.Sorszam + idB.TajSzam + idB.Idopont);
                    //}
                    listBox1.Items.Add(b.ToString());
                }
            }
        }

        private void kezelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selected = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(listBox1.SelectedItem);
            Beteg betegToDelete = null;
            String[] split = selected.Split('\t');
            int sorszam = Convert.ToInt32(split[0]);
            foreach (Beteg b in betegek)
            {
                if(sorszam == b.Sorszam)
                {
                    betegToDelete = b;
                    break;
                }
            }
            betegek.Remove(betegToDelete);
        }
    }
}
