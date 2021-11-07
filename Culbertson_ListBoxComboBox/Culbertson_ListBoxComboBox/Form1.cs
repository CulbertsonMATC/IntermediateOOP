using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culbertson_ListBoxComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.KeyUp += new KeyEventHandler(comboBox1_MyEnter);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = "";
            foreach (String item in listBox1.SelectedItems)
            {
                selected += item + " ";
            }
            MessageBox.Show(selected);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void comboBox1_MyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
        }
    }
}
