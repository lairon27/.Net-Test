using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("DateAdded", "Date Added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new add(this);
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.BeginEdit(true);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row  in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
                dataGridView1.Refresh();
            }
        }
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Visible = false;
                for (var j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            dataGridView1.Rows[i].Visible = true;
                            break;
                        }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int i = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow r = dataGridView1.Rows[i];

                var f = new info();
                f.label2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                f.label4.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                f.label6.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                
                f.ShowDialog(this);
            }
        }
    }
}