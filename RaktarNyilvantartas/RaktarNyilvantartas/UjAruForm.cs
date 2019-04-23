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
    public partial class UjAruForm : Form
    {
        List<Aru> aruk;
        public UjAruForm(List<Aru> aruk)
        {
            InitializeComponent();
            this.aruk = aruk;
        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            if (tbNev.Text != "" && tbAzon.Text != "" && nuAr.Value != -1)
            {
                //Első megoldás, default konstruktorral
                //Aru aru = new Aru();
                //aru.Nev = tbNev.Text;
                //aru.Azon = tbAzon.Text;
                //aru.Ar = Convert.ToInt32(nuAr.Value);

                ////Második megoldás paraméterezett konstruktorral
                ////Aru aru = new Aru(tbNev.Text, tbAzon.Text, Convert.ToInt32(nuAr.Value));
                ////aruk.Add(aru);

                //////Harmadik megoldás nevesített objektum nélkül
                aruk.Add(new Aru(tbNev.Text, tbAzon.Text, Convert.ToInt32(nuAr.Value)));


                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
