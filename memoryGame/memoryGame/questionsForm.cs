using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class QuestionsForm : Form
    {
        public QuestionsForm()
        {
            InitializeComponent();
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            question3Lbl.Visible = false;
            question3Lbl.Visible = false;
            question3Lbl2.Visible = false;
            question3Option1.Visible = false;
            question3Option2.Visible = false;
            question3Option3.Visible = false; 
            question3Option4.Visible = false;
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

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            dogPic.Visible = false;
            iToldYouSoPic.Visible = false;

            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            congratsLbl.Visible = false;
            startNextLevel.Visible = false;
            startOtherLevel.Visible = false;
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionsForm questionsForm = new QuestionsForm();
            questionsForm.Close();                                 //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                  // Open the previous one.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");
            grayHairPic.Visible = false;
            question1Label.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            questionLbl.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            question3Lbl.Visible = true;
            question3Lbl2.Visible = true;
            question3Option1.Visible = true;
            question3Option2.Visible = true;
            question3Option3.Visible = true;
            question3Option4.Visible = true;

            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question3Lbl.Visible = false;
            question3Lbl2.Visible = false;
            question3Option1.Visible = false;
            question3Option2.Visible = false;
            question3Option3.Visible = false;
            question3Option4.Visible = false;

            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

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
            dogPic.Visible = true;
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
            question4Option1.Visible = true;
            question4Option2.Visible = true;
            question4Option3.Visible = true;
            question4Option4.Visible = true;
            question4Button1.Visible = false;
            question4Button2.Visible = false;
            question4Button3.Visible = false;
            question4Button4.Visible = false;
            dogPic.Visible = false;

            question5Lbl.Visible = true;
            question5Lbl2.Visible = true;
            iToldYouSoPic.Visible = true;

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
            MessageBox.Show("Wrong answer", "Try again");
        }

        private void question5Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "That's Correct!");

            question5Lbl.Visible = false;
            question5Lbl2.Visible = false;
            iToldYouSoPic.Visible = false;

            question5Button1.Visible = false;
            question5Button2.Visible = false;
            question5Button3.Visible = false;
            question5Button4.Visible = false;
            question4Option1.Visible = false;
            question4Option2.Visible = false;
            question4Option3.Visible = false;
            question4Option4.Visible = false;

            congratsLbl.Visible = true;
            startNextLevel.Visible = true;
            startOtherLevel.Visible = true;
        }

        private void startNextLevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionsForm questionsForm = new QuestionsForm();
            questionsForm.Close();                                 //Close this form.
            DifficultForm difficultForm = new DifficultForm();
            difficultForm.Show();                                  // Open the next one.
        }
    }
}
