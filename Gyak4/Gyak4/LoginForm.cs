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

namespace Gyak4
{
    public partial class LoginForm : Form
    {
        List<Hallgato> hallgatok = new List<Hallgato>();

        public LoginForm()
        {
            InitializeComponent();
            StreamReader file = new StreamReader(@"..\..\Students.txt");
            while (!file.EndOfStream)
            {
                String tmpNeptun = file.ReadLine();
                String tmpPassword = file.ReadLine();
                hallgatok.Add(new Hallgato(tmpNeptun, tmpPassword));
            }
            file.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Hallgato dataGiven = new Hallgato(textBoxNeptun.Text,textBoxPassword.Text);
            for (int i = 0; i < hallgatok.Count; i++)
            {
                if (hallgatok[i].Neptun1 == dataGiven.Neptun1 && hallgatok[i].Password1 == dataGiven.Password1)
                {
                    this.DialogResult = DialogResult.OK;
                    break;
                }
            }
            }
        }
    }

