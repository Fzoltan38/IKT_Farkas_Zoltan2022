using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialGenaratorGUI
{
    public partial class Form1 : Form
    {
        Queries q = new Queries();
        public Form1()
        {
            InitializeComponent();
            q.dbRead(listBox1);

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            q.dbCreate(textBox1,textBox2);
            q.dbRead(listBox1);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            q.dbDelete(listBox1, textBox3);
            q.dbRead(listBox1);
        }
    }
}
