using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Staj_Projesi
{
    public partial class Form1 : Form
    {
        private string output;
      
        public List<Customer> _customers = new List<Customer>();
        public CustomerDal _customerDal = new CustomerDal();

        public static string sendtext1 = "";
        public static string sendtext2 = "";
        
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            gbx.BackColor = Color.FromArgb(160, Color.White);
            lblTitle.BackColor = Color.FromArgb(160, Color.White);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            sendtext1 = tbxIdNumber.Text;
            sendtext2 = tbxLastName.Text;


            ContainCheck();
        }


        private void ContainCheck()
        {
            string tmp = _customerDal.CustomerContain(tbxIdNumber.Text, output);
            if (tmp != null)
            {
                Form1.ActiveForm.Visible = false;
                Form2 form2 = new Form2();
                form2.Show();

            }
            else
            {
                Form1.ActiveForm.Visible = true;
                MessageBox.Show("Customer that has this id was not found in the system.", "Information Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle _gradientRectangle = new Rectangle(0, 0, 816, 489);
            Brush _brush = new LinearGradientBrush(_gradientRectangle, Color.FromArgb(150, Color.MidnightBlue), Color.FromArgb(150, Color.DodgerBlue), 45F);

            graphics.FillRectangle(_brush, _gradientRectangle);
        }

        
    }
}

