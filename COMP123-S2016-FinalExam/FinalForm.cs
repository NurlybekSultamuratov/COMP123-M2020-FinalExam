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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            //FILL THE BLANK TEXTBOXES IN FINAL FORM
            LastNameFill.Text = Program.character.LastName;
            FirstNameFill.Text = Program.character.FirstName;
            RaceFill.Text= Program.character.Race;
            StrengthFill.Text = Program.character.Strength;
            DexterityFill.Text = Program.character.Dexterity;
            ConstitutionFill.Text = Program.character.Constitution;
            IntelligenceFill.Text = Program.character.Intelligence;
            WisdomFill.Text = Program.character.Wisdom;
            CharismaFill.Text = Program.character.Charisma;
        }
    }
}
