using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class NumericEntry : System.Windows.Forms.Form
    {
        public NumericEntry()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            decimal value1 = numericEntry1.Value;
            MessageBox.Show("Girilen Değer: " + value1);
            int value2 = numericEntry1.GetIntegerValue();
            MessageBox.Show("Integer Değer: " + value2);
            string value3 = numericEntry1.GetBinaryValue();
            MessageBox.Show("Binary Değer: " + value3);
            string value4 = numericEntry1.Caption;
            MessageBox.Show("Capiton Değer: " + value4);
            numericEntry1.Clear();
            
        }

    }
}
