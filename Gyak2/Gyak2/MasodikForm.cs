using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak2
{
    public partial class MasodikForm : Form
    {
        public MasodikForm()
        {
            InitializeComponent();
        }

        private void MasodikForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length != 0) {
                if (!listBoxNames.Items.Contains(textBoxName.Text)) {
                    listBoxNames.Items.Add(textBoxName.Text);
                    textBoxName.Clear();
                    textBoxName.Focus();
                }
                else
                {
                    labelItemExists.Visible = true;
                    ;
                    System.Threading.Thread.Sleep(1000);
                    ;
                    labelItemExists.Visible = false;
                    textBoxName.Clear();
                    textBoxName.Focus();
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxNames.Items.Remove(listBoxNames.SelectedItem);
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
