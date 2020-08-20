using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
           
           
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //SHOW THE FROM AFTER THE TIMER IS OFF
            Program.generateNameForm.Show();
            //HIDE THIS FORM
            this.Hide();
            //DISABLE TRIGERRING NEW FORMS
            SplashFormTimer.Enabled = false;

        }
    }
}
