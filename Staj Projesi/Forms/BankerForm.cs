using System;
using System.CodeDom.Compiler;
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
    public partial class BankerForm : Form
    {
        private BankerDal _bankerDal = new BankerDal();
        public BankerForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            gbx.BackColor = Color.FromArgb(160, Color.White);
        }

        private void BankerForm_Load(object sender, EventArgs e)
        {
            string temp = Form1.sendtext1;
            String bankerInfo = _bankerDal.GetBankerInfo(temp);
            lblInfoOutput.Text = bankerInfo;
            lblInfoName.Text = "Banker Id: " + "\n" + "Banker Name: " + "\n" + "City: " + "\n" + "Email: ";
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle _gradientRectangle = new Rectangle(0, 0, 816, 489);
            Brush _brush = new LinearGradientBrush(_gradientRectangle, Color.FromArgb(150, Color.MidnightBlue), Color.FromArgb(150, Color.DodgerBlue), 45F);

            graphics.FillRectangle(_brush, _gradientRectangle);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BankerForm.ActiveForm.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            BankerForm.ActiveForm.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BankerForm_Enter(object sender, EventArgs e)
        {

        }
    }
}
