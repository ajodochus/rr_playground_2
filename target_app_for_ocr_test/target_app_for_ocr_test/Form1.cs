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
namespace target_app_for_ocr_test
{
    public partial class Form1 : Form
    {
        navi_control navigationcontrol;
        public Form1()
        {
            InitializeComponent();
            initialize_navi_controls();


            var lines = File.ReadAllLines(".\\data.csv");
            var list = new List<Contact>();
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 2)
                {
                    var contact = new Contact() { Name = values[0], Phone = values[1] };
                    list.Add(contact);
                }
            }
            mydg.DataSource = list;
        }

        private void initialize_navi_controls()
        {
            List<UserControl> usercontrols = new List<UserControl>()
            { new usercontrols.uc1(), new usercontrols.uc2() };

            navigationcontrol = new navi_control(usercontrols, panel1);
            navigationcontrol.Display(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mydg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navigationcontrol.Display(0);
        }

        private void panel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navigationcontrol.Display(1);
        }
    }
}
