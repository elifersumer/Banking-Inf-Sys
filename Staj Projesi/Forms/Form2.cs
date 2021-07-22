using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Projesi
{
    public partial class Form2 : Form
    {
        private CustomerDal _customerDal = new CustomerDal();
        public string _customerId = Form1.sendtext1;
        private string output;
        private string _personalTitle;

        public Form2()
        {
            InitializeComponent();

            OpacityBackground();

            string personalTitle = PersonalTitle();
            string lastName = LastNameTitle();

            lblWelcome.Text = "Welcome " + personalTitle + lastName + ",";
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBanker_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = false;
            BankerForm bankerForm = new BankerForm();
            bankerForm.Show();
        }


        private void btnAccount_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = false;
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = false;
            CreditCardForm creditCardForm = new CreditCardForm();
            creditCardForm.Show();
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle _gradientRectangle = new Rectangle(0, 0, 816, 489);
            Brush _brush = new LinearGradientBrush(_gradientRectangle, Color.FromArgb(150, Color.MidnightBlue),
                Color.FromArgb(150, Color.DodgerBlue), 45F);

            graphics.FillRectangle(_brush, _gradientRectangle);
        }

        private string PersonalTitle()
        {
            string gender = _customerDal.GetGender(_customerId, output);
            if (gender == "M")
            {
                _personalTitle = "Mr. ";
            }
            else
            {
                _personalTitle = "Mrs. ";
            }

            return _personalTitle;
        }

        private string LastNameTitle()
        {
            string lastName = _customerDal.GetLastName(_customerId, output);
            if (lastName == Form1.sendtext2)
            {
                return lastName;
            }

            return null;
        }
        private void OpacityBackground()
        {
            this.Paint += new PaintEventHandler(set_background);
            btnAccount.FillColor = Color.FromArgb(160, Color.White);
            btnBanker.FillColor = Color.FromArgb(160, Color.White);
            btnCreditCard.FillColor = Color.FromArgb(160, Color.White);
            btnBanker.HoverState.FillColor = Color.FromArgb(200, Color.White);
            btnAccount.HoverState.FillColor = Color.FromArgb(200, Color.White);
            btnCreditCard.HoverState.FillColor = Color.FromArgb(200, Color.White);
            lblWelcome.BackColor = Color.FromArgb(160, Color.White);
            lblChoose.BackColor = Color.FromArgb(160, Color.White);

        }



    }
}
