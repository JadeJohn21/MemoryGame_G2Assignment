using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class DifficultForm : Form
    {
        private int countDown;
        public DifficultForm()
        {
            InitializeComponent();

            goodNewsPic.Visible = false;
            englishLabel.Visible = false;
            afrikaansLabel.Visible = false;
            goodNewsLbl.Visible = false;
            goeieNussLbl.Visible = false;
            carPic.Visible = false;
            canIUseYouCarLbl.Visible = false;
            kanEkJouKarGebruik.Visible = false;
            dustPic.Visible = false;
            shelfWithDustLbl.Visible = false;
            dieRakLbl.Visible = false;
            visitPic.Visible = false;
            tomorrowVisitLbl.Visible = false;
            tomorrowVisitLbl2.Visible = false;
            ekGaanMoreKomKuierLbl.Visible = false;
            niceFoodLbl.Visible = false;
            niceFoodPic.Visible = false;
            lekkerKosLbl.Visible = false;
            loudNeighboursPic.Visible = false;
            loudNeighboursLbl.Visible = false;
            raasBureLbl.Visible = false;
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            DifficultForm difficultForm = new DifficultForm();
            difficultForm.Close();                                 //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                  // Open the previous one.
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            countDown = 60;
            countDownTimer.Start();

            label3.Visible = false;
            startBtn.Visible = false;

            goodNewsPic.Visible = true;
            englishLabel.Visible = true;
            afrikaansLabel.Visible = true;
            goodNewsLbl.Visible = true;
            goeieNussLbl.Visible = true;

        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            CountDownControl1.Text = countDown--.ToString();
            if (countDown == 0)
            {
                countDownTimer.Stop();
                this.Hide();
                DifficultForm difficultForm = new DifficultForm();
                difficultForm.Close();                                     //Close this form.
                DifficultQuestionsForm difficultQuestionsForm = new DifficultQuestionsForm();
                difficultQuestionsForm.Show();                             // Open a new one.
            }

            if (countDown == 50)
            {
                goodNewsPic.Visible = false;
                goodNewsLbl.Visible = false;
                goeieNussLbl.Visible = false;

                carPic.Visible = true;
                canIUseYouCarLbl.Visible = true;
                kanEkJouKarGebruik.Visible = true;
            }

            if (countDown == 40)
            {
                carPic.Visible = false;
                canIUseYouCarLbl.Visible = false;
                kanEkJouKarGebruik.Visible = false;

                dustPic.Visible = true;
                shelfWithDustLbl.Visible = true;
                dieRakLbl.Visible = true;
            }

            if (countDown == 30)
            {
                dustPic.Visible = false;
                shelfWithDustLbl.Visible = false;
                dieRakLbl.Visible = false;

                visitPic.Visible = true;
                tomorrowVisitLbl.Visible = true;
                tomorrowVisitLbl2.Visible = true;
                ekGaanMoreKomKuierLbl.Visible = true;

            }

            if (countDown == 20)
            {
                visitPic.Visible = false;
                tomorrowVisitLbl.Visible = false;
                tomorrowVisitLbl2.Visible = false;
                ekGaanMoreKomKuierLbl.Visible = false;

                niceFoodLbl.Visible = true;
                niceFoodPic.Visible = true;
                lekkerKosLbl.Visible = true;
            }

            if (countDown == 10)
            {
                niceFoodLbl.Visible = false;
                niceFoodPic.Visible = false;
                lekkerKosLbl.Visible = false;

                loudNeighboursPic.Visible = true;
                loudNeighboursLbl.Visible = true;
                raasBureLbl.Visible = true;
            }
        }
    }
}
