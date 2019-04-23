using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaktarNyilvantartas
{
    public partial class RaktarNyilvantartasForm : Form
    {
        List<Aru> aruk = new List<Aru>();
        List<AruTetel> beerkAruk = new List<AruTetel>();

        public RaktarNyilvantartasForm()
        {
            InitializeComponent();
            StreamReader file = new StreamReader(@"..\..\..\aruk.txt");
            while (!file.EndOfStream)
            {
                Aru tmpAru;
                String tmpLine = file.ReadLine();
                String[] tmpLineSplit = tmpLine.Split('\t');
                tmpAru = new Aru(tmpLineSplit[0],tmpLineSplit[1],Convert.ToInt32(tmpLineSplit[2]));
                lbAruk.Items.Add(tmpAru.ToString() + " Ft");
                aruk.Add(tmpAru);
            }
            file.Close();
        }

        private void ujAruMenuItem_Click(object sender, EventArgs e)
        {
            UjAruForm frm = new UjAruForm(aruk);
            if(frm.ShowDialog()==DialogResult.OK)
            {
                //               lbAruk.Items.Clear();
                //               foreach (Aru a in aruk)
                //               {
                //                    lbAruk.Items.Add(a.Nev + "\t" + a.Azon + "\t" + a.Ar + " Ft");
                //                }
                Aru a = aruk[aruk.Count - 1];
                lbAruk.Items.Add(a.ToString() + " Ft");
            }
        }

        private void RaktarNyilvantartasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter file = new StreamWriter(@"..\..\..\aruk.txt");
            foreach (Aru a in aruk)
            {
                file.WriteLine(a);
            }

            file.Close();
        }

        private void beérkezesMenuItem_Click(object sender, EventArgs e)
        {
            BeerkezesForm beerkezesForm = new BeerkezesForm(aruk, beerkAruk);
            beerkezesForm.Show();
        }
    }
}
