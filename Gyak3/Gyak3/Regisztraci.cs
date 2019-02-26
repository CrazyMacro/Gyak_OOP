using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak3
{
    public partial class Regisztraci : Form
    {
        public Regisztraci()
        {
            InitializeComponent();
        }

        List<Felhasznalo> felhasznalok = new List<Felhasznalo>();

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            Felhasznalo f = new Felhasznalo();
            f.Name = textBoxUserName.Text;
            f.Pwd = textBoxPwdRepeat.Text;
            f.BirthDate = dateTimeBirthDate.Value;
            f.Height = Convert.ToInt32(numHeight.Value);
            f.IsMale = checkBoxMale.Checked;
            felhasznalok.Add(f);
        }



        private void textBoxPwdRepeat_Validating(object sender, CancelEventArgs e)
        {
            if (!textBoxPwd.Text.Equals(textBoxPwdRepeat.Text))
            {
                errorPwdMismatch.SetError(textBoxPwdRepeat, "Passwords do not match");
            }
        }
    }
}
