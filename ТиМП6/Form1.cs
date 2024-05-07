using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТиМП6
{
    public partial class Form1 : Form
    {
        Client_with_NClocks C1 = new Client_with_NClocks();
        Client_with_EClocks C2 = new Client_with_EClocks();


        static Electronic_Clocks EC1 = new Electronic_Clocks();
        Normal_Clocks NC1 = new Adapter_to_NClocks(EC1);

        static Normal_Clocks NC2 = new Normal_Clocks();
        Electronic_Clocks EC2 = new Adapter_to_EClocks(NC2);



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int First = Int32.Parse(textBox1.Text);
            int Second = Int32.Parse(textBox2.Text);

            if (checkBox2.Checked)
            {
                if (checkBox1.Checked)
                    richTextBox1.Text += C1.Watch_Time(NC1, First, Second, true);
                else
                    richTextBox1.Text += C1.Watch_Time(NC1, First, Second, false);
            }
            else
            {
                richTextBox1.Text += C2.Watch_Time(EC2, First, Second);
            }
        }
    }
}
