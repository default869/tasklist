using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddItem(ListViewItem item)
        {
            listView.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
                listView.Items.Remove(listView.SelectedItems[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                Form2 newForm = new Form2(this);
                newForm.Show();
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
