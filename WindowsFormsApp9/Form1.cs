using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Regex p = new Regex(@"([A-Z]:\\)[a-zA-Z]{1,}");
            listBox1.Items.Clear();
            if (p.IsMatch(textBox2.Text) && textBox1.Text[0] == '.')
            {
                var astFile = Directory.GetFiles(textBox2.Text, "*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(textBox1.Text)).ToList();
                listBox1.Items.Add("Всего файлов: "+astFile.Count);
                foreach(string file in astFile)
                {
                    listBox1.Items.Add(file);
                }
            }
            else
            {
                textBox2.Focus();
            }
        }
    }
}
