using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Projesi
{
    public partial class AccountForm : Form
    {
        
        private AccountDal _accountDal = new AccountDal();
        public AccountForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            gbx.BackColor = Color.FromArgb(160, Color.White);
            lblInfoOutput.BackColor = Color.White;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            string temp = Form1.sendtext1;
            String accountInfo = _accountDal.GetAccountInfo(temp);
            lblInfoOutput.Text = accountInfo;
            lblInfoName.Text = "Name: " + "\n" + "Category: " + "\n" + "Account Number: " + "\n" + "Balance: ";

        }

        private void rtbxAccountInfo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle _gradientRectangle = new Rectangle(0, 0, 816, 489);
            Brush _brush = new LinearGradientBrush(_gradientRectangle, Color.FromArgb(150, Color.MidnightBlue), Color.FromArgb(150, Color.DodgerBlue), 45F);

            graphics.FillRectangle(_brush, _gradientRectangle);
        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }
    }
}
