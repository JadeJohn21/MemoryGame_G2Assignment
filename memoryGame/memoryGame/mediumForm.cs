using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class MediumForm : Form
    {
        private int countDown;
        public MediumForm()
        {
            InitializeComponent();
            overweightPic.Visible = false;
            englishLabel.Visible = false;
            afrikaansLabel.Visible = false;
            overweightLabel.Visible = false;
            oorgewigLabel.Visible = false;

            grayHairPic.Visible = false;
            grayHairLabel.Visible = false;
            grysHareLabel.Visible = false;

            iToldYouSoPic.Visible = false;
            iToldYouSoLabel.Visible = false;
            ekHetJouGesêLabel.Visible = false;

            youAreBannedPic.Visible = false;
            youAreBannedLabel.Visible = false;
            jyIsVerbanLabel.Visible = false;
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MediumForm mediumForm = new MediumForm();
            mediumForm.Close();                                 //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                  // Open the previous one.
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            countDown = 60;
            countDownTimer.Start();

            label3.Visible = false;
            startBtn.Visible = false;
            overweightPic.Visible = true;
            englishLabel.Visible = true;
            afrikaansLabel.Visible = true;
            overweightLabel.Visible = true;
            oorgewigLabel.Visible = true;
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            CountDownControl1.Text = countDown--.ToString();
            if (countDown == 0)
            {
                countDownTimer.Stop();
                this.Hide();
                MediumForm mediumForm = new MediumForm();
                mediumForm.Close();                                     //Close this form.
                QuestionsForm questionsForm  = new QuestionsForm();
                questionsForm.Show();                                  // Open a new one.
            }

            if (countDown == 45) 
            {
                overweightPic.Visible = false;
                overweightLabel.Visible = false;
                oorgewigLabel.Visible = false;

                grayHairPic.Visible = true;
                grayHairLabel.Visible = true;
                grysHareLabel.Visible = true;
            }

            if (countDown == 30)
            {
                grayHairPic.Visible = false;
                grayHairLabel.Visible = false;
                grysHareLabel.Visible = false;

                iToldYouSoPic.Visible = true;
                iToldYouSoLabel.Visible = true;
                ekHetJouGesêLabel.Visible = true;
            }

            if (countDown == 15)
            {
                iToldYouSoPic.Visible = false;
                iToldYouSoLabel.Visible = false;
                ekHetJouGesêLabel.Visible = false;

                youAreBannedPic.Visible = true;
                youAreBannedLabel.Visible = true;
                jyIsVerbanLabel.Visible = true;
            }
        }
    }
}
