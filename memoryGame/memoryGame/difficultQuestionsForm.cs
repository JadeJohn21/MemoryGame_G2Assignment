using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class DifficultQuestionsForm : Form
    {
        public DifficultQuestionsForm()
        {
            InitializeComponent();
            
            question2Lbl.Visible = false;
            question2Lbl2.Visible = false;
            question2Option1.Visible = false;
            question2Option2.Visible = false;
            question2Option3.Visible = false;
            question2Option4.Visible = false;
            question2Button1.Visible = false;
            question2Button2.Visible = false;
            question2Button3.Visible = false;
            question2Button4.Visible = false;
            question3Pic.Visible = false;
            question3Lbl.Visible = false;
            question3Lbl2.Visible = false;
            question3Button1.Visible = false;
            question3Button2.Visible = false;
            question3Button3.Visible = false;
            question3Button4.Visible = false;
            question4Lbl.Visible = false;
            question4Lbl2.Visible = false;
            question4Option1.Visible = false;
            question4Option2.Visible = false;
            question4Option3.Visible = false;
            question4Option4.Visible = false;
            question4Button1.Visible = false;
            question4Button2.Visible = false;
            question4Button3.Visible = false;
            question4Button4.Visible = false;
            question5Lbl.Visible = false;
            question5Lbl2.Visible = false;
            question5Button1.Visible = false;
            question5Button2.Visible = false;
            question5Button3.Visible = false;
            question5Button4.Visible = false;
            question6Lbl.Visible = false;
            question6Lbl2.Visible = false;
            question6Pic1.Visible = false;
            question6Pic2.Visible = false;
            question6Pic3.Visible = false;
            question6Pic4.Visible = false;
            question6Option1.Visible = false;
            question6Option2.Visible = false;
            question6Option3.Visible = false;
            question6Option4.Visible = false;
            question7Pic.Visible = false;
            question7Lbl.Visible = false;
            question7Lbl2.Visible = false;
            question7Option1.Visible = false;
            question7Option2.Visible = false;
            question7Option3.Visible = false;
            question7Option4.Visible = false;
            question7Button1.Visible = false;
            question7Button2.Visible = false;
            question7Button3.Visible = false;
            question7Button4.Visible = false;
            question8Pic.Visible = false;
            question8Lbl.Visible = false;
            question8Lbl2.Visible = false;
            question8Option1.Visible = false;
            question8Option2.Visible = false;
            question8Option3.Visible = false;
            question8Option4.Visible = false;
            question8Button1.Visible = false;
            question8Button2.Visible = false;
            question8Button3.Visible = false;
            question8Button4.Visible = false;
            goodNewsPic.Visible = false;
            question3Pic.Visible = false;
            question9Label.Visible = false;
            question9Label2.Visible = false;
            question9Option1.Visible = false;
            question9Option2.Visible = false;
            question9Option3.Visible = false;
            question9Option4.Visible = false;
            question9Button1.Visible = false;
            question9Button2.Visible = false;
            question9Button3.Visible = false;
            question9Button4.Visible = false;
            question10Label1.Visible = false;
            question10Label2.Visible = false;
            question10Option1.Visible = false;
            question10Option2.Visible = false;
            question10Option3.Visible = false;
            question10Option4.Visible = false;
            question10Button1.Visible = false;
            question10Button2.Visible = false;
            question10Button3.Visible = false;
            question10Button4.Visible = false;

            congratsLbl.Visible = false;
            returnButton.Visible = false;
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            DifficultQuestionsForm difficultQuestionsForm = new DifficultQuestionsForm();
            difficultQuestionsForm.Close();                     //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                  // Open the previous one.
        }

        private void question1Answer1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question1Answer2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question1Lbl.Visible = false;
            question1Lbl2.Visible = false;
            question1Option1.Visible = false;
            question1Option2.Visible = false;
            question1Option3.Visible = false;
            question1Option4.Visible = false;
            question1Answer1.Visible = false;
            question1Answer2.Visible = false;
            question1Answer3.Visible = false;
            question1Answer4.Visible = false;

            goodNewsPic.Visible = true;
            question2Lbl.Visible = true;
            question2Lbl2.Visible = true;
            question2Option1.Visible = true;
            question2Option2.Visible = true;
            question2Option3.Visible = true;
            question2Option4.Visible = true;
            question2Button1.Visible = true;
            question2Button2.Visible = true;
            question2Button3.Visible = true;
            question2Button4.Visible = true;
        }

        private void question1Answer3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question1Answer4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            goodNewsPic.Visible = false;
            question2Lbl.Visible = false;
            question2Lbl2.Visible = false;
            //question2Option1.Visible = false;
            //question2Option2.Visible = false;
            //question2Option3.Visible = false;
            //question2Option4.Visible = false;
            question2Button1.Visible = false;
            question2Button2.Visible = false;
            question2Button3.Visible = false;
            question2Button4.Visible = false;

            question3Pic.Visible = true;
            question3Lbl.Visible = true;
            question3Lbl2.Visible = true;
            question3Button1.Visible = true;
            question3Button2.Visible = true;
            question3Button3.Visible = true;
            question3Button4.Visible = true;
        }

        private void question2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question2Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question3Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question3Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question3Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question3Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question3Pic.Visible = false;
            question2Option1.Visible = false;
            question2Option2.Visible = false;
            question2Option3.Visible = false;
            question2Option4.Visible = false;
            question3Lbl.Visible = false;
            question3Lbl2.Visible = false;
            question3Button1.Visible = false;
            question3Button2.Visible = false;
            question3Button3.Visible = false;
            question3Button4.Visible = false;

            question4Lbl.Visible = true;
            question4Lbl2.Visible = true;
            question4Option1.Visible = true;
            question4Option2.Visible = true;
            question4Option3.Visible = true;
            question4Option4.Visible = true;
            question4Button1.Visible = true;
            question4Button2.Visible = true;
            question4Button3.Visible = true;
            question4Button4.Visible = true;
        }

        private void question4Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question4Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question4Lbl.Visible = false;
            question4Lbl2.Visible = false;
            question4Button1.Visible = false;
            question4Button2.Visible = false;
            question4Button3.Visible = false;
            question4Button4.Visible = false;

            question5Lbl.Visible = true;
            question5Lbl2.Visible = true;
            question5Button1.Visible = true;
            question5Button2.Visible = true;
            question5Button3.Visible = true;
            question5Button4.Visible = true;
        }

        private void question4Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question4Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question5Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question5Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question5Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question5Lbl.Visible = false;
            question5Lbl2.Visible = false;
            question4Option1.Visible = false;
            question4Option2.Visible = false;
            question4Option3.Visible = false;
            question4Option4.Visible = false;
            question5Button1.Visible = false;
            question5Button2.Visible = false;
            question5Button3.Visible = false;
            question5Button4.Visible = false;

            question6Lbl.Visible = true;
            question6Lbl2.Visible = true;
            question6Pic1.Visible = true;
            question6Pic2.Visible = true;
            question6Pic3.Visible = true;
            question6Pic4.Visible = true;
            question6Option1.Visible = true;
            question6Option2.Visible = true;
            question6Option3.Visible = true;
            question6Option4.Visible = true;
        }

        private void question5Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question6Pic1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question6Pic3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question6Lbl.Visible = false;
            question6Lbl2.Visible = false;
            question6Pic1.Visible = false;
            question6Pic2.Visible = false;
            question6Pic3.Visible = false;
            question6Pic4.Visible = false;
            question6Option1.Visible = false;
            question6Option2.Visible = false;
            question6Option3.Visible = false;
            question6Option4.Visible = false;

            question7Pic.Visible = true;
            question7Lbl.Visible = true;
            question7Lbl2.Visible = true; 
            question7Option1.Visible = true; 
            question7Option2.Visible = true;
            question7Option3.Visible = true;
            question7Option4.Visible = true;
            question7Button1.Visible = true;
            question7Button2.Visible = true;
            question7Button3.Visible = true;
            question7Button4.Visible = true;
        }

        private void question6Pic2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question6Pic4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question7Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question7Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question7Pic.Visible = false;
            question7Lbl.Visible = false;
            question7Lbl2.Visible = false;
            question7Option1.Visible = false;
            question7Option2.Visible = false;
            question7Option3.Visible = false;
            question7Option4.Visible = false;
            question7Button1.Visible = false;
            question7Button2.Visible = false;
            question7Button3.Visible = false;
            question7Button4.Visible = false;

            question8Pic.Visible = true;
            question8Lbl.Visible = true;
            question8Lbl2.Visible = true;
            question8Option1.Visible = true;
            question8Option2.Visible = true;
            question8Option3.Visible = true;
            question8Option4.Visible = true;
            question8Button1.Visible = true;
            question8Button2.Visible = true;
            question8Button3.Visible = true;
            question8Button4.Visible = true;
        }

        private void question7Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question7Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question8Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question8Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question8Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question8Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question8Pic.Visible = false;
            question8Lbl.Visible = false;
            question8Lbl2.Visible = false;
            question8Option1.Visible = false;
            question8Option2.Visible = false;
            question8Option3.Visible = false;
            question8Option4.Visible = false;
            question8Button1.Visible = false;
            question8Button2.Visible = false;
            question8Button3.Visible = false;
            question8Button4.Visible = false;

            question9Label.Visible = true;
            question9Label2.Visible = true;
            question9Option1.Visible = true;
            question9Option2.Visible = true;
            question9Option3.Visible = true;
            question9Option4.Visible = true;
            question9Button1.Visible = true;
            question9Button2.Visible = true;
            question9Button3.Visible = true;
            question9Button4.Visible = true;
        }

        private void question5Button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question5Button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question5Lbl.Visible = false;
            question5Lbl2.Visible = false;
            question4Option1.Visible = false;
            question4Option2.Visible = false;
            question4Option3.Visible = false;
            question4Option4.Visible = false;
            question5Button1.Visible = false;
            question5Button2.Visible = false;
            question5Button3.Visible = false;
            question5Button4.Visible = false;

            question6Lbl.Visible = true;
            question6Lbl2.Visible = true;
            question6Pic1.Visible = true;
            question6Pic2.Visible = true;
            question6Pic3.Visible = true;
            question6Pic4.Visible = true;
            question6Option1.Visible = true;
            question6Option2.Visible = true;
            question6Option3.Visible = true;
            question6Option4.Visible = true;
        }

        private void question5Button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question5Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question9Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");
            question9Label.Visible = false;
            question9Label2.Visible = false;
            question9Option1.Visible = false;
            question9Option2.Visible = false;
            question9Option3.Visible = false;
            question9Option4.Visible = false;
            question9Button1.Visible = false;
            question9Button2.Visible = false;
            question9Button3.Visible = false;
            question9Button4.Visible = false;

            question10Label1.Visible = true;
            question10Label2.Visible = true;
            question10Option1.Visible = true;
            question10Option2.Visible = true;
            question10Option3.Visible = true;
            question10Option4.Visible = true;
            question10Button1.Visible = true;
            question10Button2.Visible = true;
            question10Button3.Visible = true;
            question10Button4.Visible = true;
        }

        private void question9Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question9Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question9Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question10Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question10Label1.Visible = false;
            question10Label2.Visible = false;
            question10Option1.Visible = false;
            question10Option2.Visible = false;
            question10Option3.Visible = false;
            question10Option4.Visible = false;
            question10Button1.Visible = false;
            question10Button2.Visible = false;
            question10Button3.Visible = false;
            question10Button4.Visible = false;

            congratsLbl.Visible = true;
            returnButton.Visible = true;
        }

        private void question10Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question10Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question10Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DifficultQuestionsForm difficultQuestionsForm = new DifficultQuestionsForm();
            difficultQuestionsForm.Close();                                 //Close this form.
            HomePage homepage = new HomePage();
            homepage.Show();                                  // Open the next one.
        }
    }
}
