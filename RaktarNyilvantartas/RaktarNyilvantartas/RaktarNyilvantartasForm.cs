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
    public partial class RaktarNyilvantartasForm : Form
    {
        List<Aru> aruk = new List<Aru>();
        public RaktarNyilvantartasForm()
        {
            InitializeComponent();
        }

        private void ujAruMenuItem_Click(object sender, EventArgs e)
        {
            UjAruForm frm = new UjAruForm(aruk);
            if(frm.ShowDialog()==DialogResult.OK)
            {
                lbAruk.Items.Clear();
                foreach (Aru a in aruk)
                {
                    lbAruk.Items.Add(a.Nev + "\t" + a.Azon + "\t" + a.Ar + " Ft");
                }
                
            }
        }
    }
}
