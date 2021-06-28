using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class GameLevels : Form
    {
        private HomePage homePage;
        private GameLevels gameLevels;
        private EasyForm easyForm;
        private MediumForm mediumForm;
        public GameLevels()
        {
            InitializeComponent();
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLevels gameLevels = new GameLevels();
            gameLevels.Close();                                 //Close this form.
            HomePage homePage = new HomePage();                 
            homePage.Show();                                    //Open a new one.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLevels gameLevels = new GameLevels();
            gameLevels.Close();                                 //Close this form.
            EasyForm easyForm = new EasyForm();
            easyForm.Show();                                    //Open a new one.
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLevels gameLevels = new GameLevels();
            gameLevels.Close();                                 //Close this form.
            MediumForm mediumForm = new MediumForm();
            mediumForm.Show();                                    //Open a new one.
        }

        private void DifficultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLevels gameLevels = new GameLevels();
            gameLevels.Close();                                 //Close this form.
            DifficultForm difficultForm = new DifficultForm();
            difficultForm.Show();                               //Open a new one.
        }
    }
}
