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
    public partial class Targyfelvetel : Form
    {

        List<Subject> subjectsAvailable = new List<Subject>();
        List<Subject> subjectsTaken = new List<Subject>();

        public Targyfelvetel()
        {
            InitializeComponent();
            ProcessTextData();
            foreach (Subject tmpSubject in subjectsAvailable)
            {
                listBoxSubjectsAvailable.Items.Add(tmpSubject.Neptun + " " + tmpSubject.Name);
            }
        }

        void ProcessTextData()
        {
            StreamReader fileReader = new StreamReader(@"..\..\Subjects.txt");
            while (!fileReader.EndOfStream)
            {
                Subject tmpSubject = new Subject();
                tmpSubject.Neptun = fileReader.ReadLine();
                tmpSubject.Name = fileReader.ReadLine();
                tmpSubject.Credit = Convert.ToInt32(fileReader.ReadLine());
                subjectsAvailable.Add(tmpSubject);
            }
            fileReader.Close();
        }

        private void buttonTakeSubject_Click(object sender, EventArgs e)
        {
            listBoxSubjectsTaken.Items.Add(listBoxSubjectsAvailable.SelectedItem);
            subjectsTaken.Add(subjectsAvailable[listBoxSubjectsAvailable.SelectedIndex]);

        }
    }
}
