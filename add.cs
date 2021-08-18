using System;
using System.Windows.Forms;

namespace testing
{
    public partial class add : Form
    {
        private Form1 form1;
        public add(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var row = new object[] {textBox1.Text, textBox2.Text, dateTimePicker1.Text};
            
            form1.dataGridView1.Rows.Add(row);
            form1.dataGridView1.Rows[0].Selected = false;

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}