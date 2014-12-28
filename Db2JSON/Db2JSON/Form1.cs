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

namespace Db2JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_MG_WEB_2003DataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this._MG_WEB_2003DataSet.Товары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = this._MG_WEB_2003DataSet.CreateDataReader();
            int cnt = dt.VisibleFieldCount;
            
            textBox1.AppendText("[");
            while (dt.Read())
            {
                textBox1.AppendText("{");
                for (int i = 0; i < cnt; i++)
                {
                    textBox1.AppendText("\"" + dt.GetName(i) + "\":\"" + dt.GetValue(i).ToString() + "\"");
                    if (i == cnt - 1)
                    {
                        textBox1.AppendText("},\n");
                    }
                    else
                    {
                        textBox1.AppendText(",");
                    }
                }
            }
            textBox1.AppendText("]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // create a writer and open the file
                TextWriter tw = new StreamWriter(folderBrowserDialog1.SelectedPath + "result.json");
                // write a line of text to the file
                tw.WriteLine(textBox1.Text);
                // close the stream
                tw.Close();
                MessageBox.Show("Saved to " + folderBrowserDialog1.SelectedPath + "\\result.json", "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
