using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class HomePage : Form
    {
        private HomePage homePage;
        private GameLevels gameLevels;
        private EasyForm easyForm;
        public HomePage()
        {
            InitializeComponent();
        }


        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Close();                               //Close this form.
            GameLevels gameLevels = new GameLevels();       
            gameLevels.Show();                              //Open a new one.
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
