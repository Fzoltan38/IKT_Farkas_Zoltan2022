using System;
using System.Windows.Forms;

namespace serialGenaratorGUI
{
    public partial class Form1 : Form
    {
        Queries q = new Queries();
        Printing p = new Printing();
        public Form1()
        {
            InitializeComponent();
            q.dbRead(listBox1);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            /*q.dbCreate(textBox1,textBox2);
            q.dbRead(listBox1);*/

            q.dbUpdate(textBox1,textBox2);
            q.dbRead(listBox1);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = 
            MessageBox.Show("Biztosan törlöd?", "Elem törlése", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                q.dbDelete(listBox1);
                q.dbRead(listBox1);
            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            q.textPaste(listBox1, textBox1, textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            q.dbCreate();
            q.dbRead(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.doPdf(listBox1);
        }
    }
}
