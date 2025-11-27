using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Project1
{ 
    #region FORM BAŞLATMA
    public partial class Form2 : Form
    {
       
        string pin = string.Empty;
        string addition = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }
        #endregion
        #region ÇIKIŞ BUTONU
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion 
        #region TARİH - SAAT 
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion
        #region İÇECEK KATEGORİZASYON
        private void btnsogukahve_Click(object sender, EventArgs e)
        {
            if(groupboxsogukahve.Visible == true)
            {
                groupboxsogukahve.Visible = false;
            }
            else
            {
                groupboxsogukahve.Visible = true;
            }
        }
        #endregion
        #region NUMERATOR İŞLEMLERİ
        private void Numpad_Click(object sender, EventArgs e)
        {
            SimpleButton b = sender as SimpleButton;
            string number = b.Text;
                pin = pin + number;
                textBoxNumarator.Text = pin;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            textBoxNumarator.Text = string.Empty;
            pin = string.Empty;
            textBoxNumarator.Focus();
        }

        private void btnSilTekli_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pin))
            {
                pin = pin.Substring(0, pin.Length - 1);
            }
            textBoxNumarator.Text = pin;
        }
        #endregion
        #region EXTRA ADİSYON TEXT
        private void addition_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string text = b.Text;
            addition = text;
            additionTextBox.Text = addition;
        }
        #endregion
    }
}
