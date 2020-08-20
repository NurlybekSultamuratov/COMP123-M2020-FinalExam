using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.abilityGeneratorForm.Show();
            this.Hide();
        }

        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //CREATE GENERATENAMES METHOD TO RANDOMLY PICK NAMES FROM LISTBOX AND 
        //DISPLAY IT IN THE TEXTBOX
        private void GenerateNames()
        {
            Random random = new Random();
            int p;
            int q;
            q = FirstNameListBox.Items.Count;
            p = random.Next(q);
            FirstNameTextBox.Text = FirstNameListBox.Items[p].ToString();
            q = LastNameListBox.Items.Count;
            p = random.Next(q);
            LastNameTextBox.Text = LastNameListBox.Items[p].ToString();
        }


        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //CALL METHOD GENERATE NAMES
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //CALL METHOD GENERATE NAMES
            GenerateNames();
            //SET FIRSTNAME FROM TEXTBOX IN GENERATENAMEFORMS TO THE CHARACTER CLASS FIRSTNAME
            Program.character.FirstName = FirstNameTextBox.Text;
            //SET LASTNAME FROM TEXTBOX IN GENERATENAMEFORMS TO THE CHARACTER CLASS LASTNAME
            Program.character.LastName = LastNameTextBox.Text;

        }

        private void GenerateNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
