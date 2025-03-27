using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Naptár
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] beolvas = File.ReadAllLines("naptar.txt", Encoding.UTF8);
            if (beolvas.Length > 0)
            {
                foreach (var item in beolvas)
                {
                    string[] sor = item.Split(';');
                    sor[0] = program.Text;
                }
            }
        }
        public List<string> esemenyek = new List<string>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            datum.Text = monthCalendar.SelectionRange.Start.ToString().Split(' ')[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void mentes_Click(object sender, EventArgs e)
        {
            if (datum.Text.Length > 0)
            {
                string file = "naptar.txt";
                using (FileStream fs = File.Create(file)) { }
                /*
                foreach (var item in beolvas)
                {
                    string sor = $"{datum.Text}; {cim.Text}; {idopont.Text}; {leiras.Text}";
                    File.AppendAllText(file, sor + Environment.NewLine);
                }
                */
            }
        }
    }
}
