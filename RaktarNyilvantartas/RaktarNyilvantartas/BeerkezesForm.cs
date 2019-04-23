using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaktarNyilvantartas
{
    public partial class BeerkezesForm : Form
    {
        List<Aru> aruk;
        List<AruTetel> beerkAruk;

        public BeerkezesForm(List<Aru> aruk, List<AruTetel> beerkAruk)
        {
            InitializeComponent();
            this.aruk = aruk;
            this.beerkAruk = beerkAruk;
            foreach (Aru a in aruk)
            {
                listBoxAruLista.Items.Add(a);
            }
        }

        private void buttonBeerk_Click(object sender, EventArgs e)
        {
            AruTetel tetel = new AruTetel();
            tetel.Aru = aruk[listBoxAruLista.SelectedIndex];
            tetel.Db = Convert.ToInt32(numericUpDownDb.Value);
            tetel.Kod = DateTime.Now.ToShortTimeString();
            beerkAruk.Add(tetel);
            listBoxBeerk.Items.Add(tetel);
            
        }
    }
}
