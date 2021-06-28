using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class EasyForm : Form
    {
        private HomePage homePage;
        private GameLevels gameLevels;
        private EasyForm easyForm;
        private int countDown;
        public EasyForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            EasyForm easyForm = new EasyForm();
            easyForm.Close();                                 //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                    //Open a new one.
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EasyForm easyForm = new EasyForm();
            easyForm.Close();                                 //Close this form.
            easyPlay easyPlayForm = new easyPlay();
            easyPlayForm.Show();                                    //Open a new one.
        }

        


    }
}
