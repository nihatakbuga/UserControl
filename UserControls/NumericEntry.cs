using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class NumericEntry : UserControl
    {
        private decimal m_MaxValue =1000;
        private decimal m_MinValue = 0;
        private bool m_Required = false;
        public delegate void NumberControl();
        public event NumberControl ValueChanged;
        public NumericEntry()
        {
            InitializeComponent();
        }
        public string Caption 
        {
            get { return lblCaption.Text;}
            set {lblCaption.Text=value;}
        }
        public int CaptionLength 
        {
            get { return lblCaption.Width;}
            set
            {
                lblCaption.Width = value;
                txtValue.Location = new System.Drawing.Point(lblCaption.Width, 0);
                txtValue.Width = this.Width-lblCaption.Width;
            }
        }
        public bool ReadOnly 
        {
            get {return txtValue.ReadOnly;}
            set {txtValue.ReadOnly=value;}
        } 
        public bool Enable 
        {
            get { return txtValue.Enabled; }
            set { txtValue.Enabled = value; }
        }
        public decimal MaxValue
        {
            get { return m_MaxValue;}
            set { m_MaxValue = value;}
        }
        public decimal MinValue 
        {
            get {return m_MinValue;}
            set {m_MinValue=value;} 
        }
        public bool Required
        {
            get { return m_Required;}
            set
            {
                m_Required = value;
                if(m_Required==true)
                {
                    lblCaption.Font = new Font(lblCaption.Font.FontFamily, lblCaption.Font.Size, FontStyle.Bold);
                }
                else
                    lblCaption.Font = new Font(lblCaption.Font.FontFamily, lblCaption.Font.Size, FontStyle.Regular);
            } 
        }
        public int Precesion { get; set; }
        public bool AllowNegative { get; set; }
        public decimal Value 
        {
            get {return Convert.ToDecimal(txtValue.Text); }
            set 
            {
                txtValue.Text=value.ToString();
                //Delegate ValueChanged 
                if (ValueChanged != null)
                    ValueChanged();
            }
        }
        
        /*METHODS*/
        //User control is cleared.
        public void Clear()
        {
            Value = 0;
        }
        //The user controls the control value.
        public bool ValidateControl()
        {
            if(Value<MinValue)
            {
                MessageBox.Show("Girmiş olduğunuz değer minimum değerden küçüktür: " + MinValue.ToString());
                return false;
            }
            else if(Value>MaxValue)
            {
                MessageBox.Show("Girmiş olduğunuz değer maksimum değerden küçüktür: " + MaxValue.ToString());
                return false;
            }
            return true;
        }
        //Returns the nearest integer value.
        public  int GetIntegerValue()
        {
            return Convert.ToInt32(Value);
        }
        //Returns the equivalent of the entered value in the system of 2.
        public string GetBinaryValue()
        {
            return Convert.ToString(GetIntegerValue(),2);
        }
       
        
        /*EVENTS*/
        //KeyPress Event
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar;
            //0 9 =48 - 57
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            //Allow Negative
            else if (AllowNegative == true && e.KeyChar.ToString() == "-" && txtValue.Text=="")
                e.Handled = false;
            //Precision
            else if (Precesion > 0 && e.KeyChar.ToString() == "." && txtValue.Text.Contains(".")==false)
                e.Handled = false;
            else
                e.Handled = true;

        }
        //Leave Event
        private void txtValue_Leave(object sender, EventArgs e)
        {
            decimal resultNumber = 0;
            if (Decimal.TryParse(txtValue.Text, out resultNumber))
                Value = Math.Round(resultNumber, Precesion);
            else
               Value=0;
               txtValue.BackColor = System.Drawing.Color.White;
        }
        //Enter Event
        private void txtValue_Enter(object sender, EventArgs e)
        {
            txtValue.BackColor = System.Drawing.Color.LightSkyBlue;
        }

       
      
    }
}
