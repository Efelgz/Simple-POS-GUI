using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

 #region FORMU AÇILIŞ

namespace Project1
{

    public partial class Form1 : Form
    {
        string pin = string.Empty;
        public Form1()
        {
            InitializeComponent();
            TextBoxPin.Focus();
        }

        private void timerClock_Tick_1(object sender, EventArgs e)
        {
            timerClock.Start();
            
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblClock.Text = DateTime.Now.ToLongTimeString();
           
        }
        #endregion

        #region Numarator işlemleri
        private void Numpad_Click(object sender, EventArgs e)
        {
            SimpleButton b = sender as SimpleButton;
            string number = b.Text;
            if (pin.Length < 6){
                pin = pin + number;
                TextBoxPin.Text = pin;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text = string.Empty;
            pin = string.Empty;
            TextBoxPin.Focus();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (pin == "1234")
            {
                MessageBox.Show("PIN doğru!");
                Form2 newForm = new Form2();
                newForm.Show();
                this.Hide();
            }
            else MessageBox.Show("PIN yanlış!");
            pin = string.Empty;
            TextBoxPin.Text = string.Empty;
            TextBoxPin.Focus();
        }

        #endregion
        
    }
}
