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
    public partial class CreditCardForm : Form
    {
        private CreditCardDal _creditCardDal = new CreditCardDal();
        public CreditCardForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            gbx.BackColor = Color.FromArgb(160, Color.White);
        }

        private void lblAccountInfo_Click(object sender, EventArgs e)
        {

        }

        private void CreditCardForm_Load(object sender, EventArgs e)
        {
            string temp = Form1.sendtext1;
            String cardInfo = _creditCardDal.GetCreditCardInfo(temp);
            lblInfoOutput.Text = cardInfo;
            lblInfoName.Text = "Name: " + "\n" + "Card Number: " + "\n" + "Limit: " + "\n" + "Expired Date: ";
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle _gradientRectangle = new Rectangle(0, 0, 816, 489);
            Brush _brush = new LinearGradientBrush(_gradientRectangle, Color.FromArgb(150, Color.MidnightBlue), Color.FromArgb(150, Color.DodgerBlue), 45F);

            graphics.FillRectangle(_brush, _gradientRectangle);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CreditCardForm.ActiveForm.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CreditCardForm.ActiveForm.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void CreditCardForm_DockChanged(object sender, EventArgs e)
        {

        }
    }
}
