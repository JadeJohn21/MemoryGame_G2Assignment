using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class easyPlay : Form
    {
        public easyPlay()
        {
            InitializeComponent();
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            easyPlay easyPlayForm = new easyPlay();
            easyPlayForm.Close();                                 //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                    //Open a new one.
        }

        private void henloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. It is not a word.");
        }

        private void halloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct. Example: 'Hallo, hoe gaan dit?', which translates to 'Hello, how are you doing?'");
        }

        private void heloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. It is not a word.");
        }

        private void hulleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Means 'them' in English.");
        }

        private void huisButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct. Example: 'Ek wil huis toe gann.', which translates to 'I want to go home.'");
        }

        private void hiusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Is not a word.");
        }

        private void hulleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Means 'them' in English.");
        }

        private void plekButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Means 'place' in English.");
        }

        private void rakkeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Means 'shelves' in English.");
        }

        private void kombieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Is not a proper word in Afrikaans.");
        }

        private void kombuisButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct. Example: 'Die brood is in die kombuis.', which translates to 'The bread is in the kitchen.'");
        }

        private void kamerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Means 'room' in English.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Means 'animal' in English.");
        }

        private void honButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Is not a word.");
        }

        private void hondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct. Example: 'Dit is my hond.', which translates to 'This is my dog.'");
        }

        private void hoorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Means 'hear' in English.");
        }

        private void kapitainButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Is not a word.");
        }

        private void kaptienButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Is not a word.");
        }

        private void capteinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong. Is not a word.");
        }

        private void kapteinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct. Example: 'Hy is die kaptein van die span.', which translates to 'He is the captain of the team.'");
        }
    }
    
}
