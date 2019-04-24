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
    public partial class BetegFelvetelForm : Form
    {
        List<Beteg> betegek;

        public BetegFelvetelForm(List<Beteg> betegek)
        {
            InitializeComponent();
            this.betegek = betegek;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int tmpTajSzam = Convert.ToInt32(numericUpDown1.Value);
            if (tmpTajSzam > 100000000 && tmpTajSzam < 999999999)
            {
                if (comboBox1.SelectedItem == null)
                {
                    Beteg tmpBeteg = new Beteg();
                    tmpBeteg.TajSzam = tmpTajSzam;
                    tmpBeteg.Sorszam = r.Next()%1000;
                    betegek.Add(tmpBeteg);
                }
                else
                {
                    IdopntosBeteg idopntosBeteg = new IdopntosBeteg();
                    idopntosBeteg.Idopont = comboBox1.SelectedItem.ToString();
                    idopntosBeteg.TajSzam = tmpTajSzam;
                    idopntosBeteg.Sorszam = r.Next() % 1000;
                    betegek.Add(idopntosBeteg);
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;            }
        }
    }
}
