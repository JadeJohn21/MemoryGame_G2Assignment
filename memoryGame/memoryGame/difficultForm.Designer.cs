
namespace memoryGame
{
    partial class DifficultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifficultForm));
            this.startBtn = new System.Windows.Forms.Button();
            this.CountDownControl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.goodNewsPic = new System.Windows.Forms.PictureBox();
            this.englishLabel = new System.Windows.Forms.Label();
            this.afrikaansLabel = new System.Windows.Forms.Label();
            this.goodNewsLbl = new System.Windows.Forms.Label();
            this.goeieNussLbl = new System.Windows.Forms.Label();
            this.carPic = new System.Windows.Forms.PictureBox();
            this.canIUseYouCarLbl = new System.Windows.Forms.Label();
            this.kanEkJouKarGebruik = new System.Windows.Forms.Label();
            this.dustPic = new System.Windows.Forms.PictureBox();
            this.shelfWithDustLbl = new System.Windows.Forms.Label();
            this.dieRakLbl = new System.Windows.Forms.Label();
            this.visitPic = new System.Windows.Forms.PictureBox();
            this.tomorrowVisitLbl = new System.Windows.Forms.Label();
            this.ekGaanMoreKomKuierLbl = new System.Windows.Forms.Label();
            this.tomorrowVisitLbl2 = new System.Windows.Forms.Label();
            this.niceFoodLbl = new System.Windows.Forms.Label();
            this.niceFoodPic = new System.Windows.Forms.PictureBox();
            this.lekkerKosLbl = new System.Windows.Forms.Label();
            this.loudNeighboursPic = new System.Windows.Forms.PictureBox();
            this.loudNeighboursLbl = new System.Windows.Forms.Label();
            this.raasBureLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodNewsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dustPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niceFoodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loudNeighboursPic)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.startBtn.Location = new System.Drawing.Point(360, 276);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(123, 58);
            this.startBtn.TabIndex = 17;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // CountDownControl1
            // 
            this.CountDownControl1.AutoSize = true;
            this.CountDownControl1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountDownControl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountDownControl1.Location = new System.Drawing.Point(717, 68);
            this.CountDownControl1.Name = "CountDownControl1";
            this.CountDownControl1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.CountDownControl1.Size = new System.Drawing.Size(20, 32);
            this.CountDownControl1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(676, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seconds to memorize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(710, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "You have: ";
            // 
            // LeftArrow
            // 
            this.LeftArrow.Image = global::memoryGame.Properties.Resources.arrow_left_circle_318_1450_removebg_preview;
            this.LeftArrow.Location = new System.Drawing.Point(12, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(48, 44);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 13;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(717, 68);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "60";
            // 
            // goodNewsPic
            // 
            this.goodNewsPic.Image = global::memoryGame.Properties.Resources.the_good_new_dancing_gif;
            this.goodNewsPic.Location = new System.Drawing.Point(236, 41);
            this.goodNewsPic.Name = "goodNewsPic";
            this.goodNewsPic.Size = new System.Drawing.Size(368, 245);
            this.goodNewsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goodNewsPic.TabIndex = 29;
            this.goodNewsPic.TabStop = false;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.englishLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.englishLabel.Location = new System.Drawing.Point(277, 315);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(73, 21);
            this.englishLabel.TabIndex = 30;
            this.englishLabel.Text = "English";
            // 
            // afrikaansLabel
            // 
            this.afrikaansLabel.AutoSize = true;
            this.afrikaansLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.afrikaansLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.afrikaansLabel.Location = new System.Drawing.Point(468, 315);
            this.afrikaansLabel.Name = "afrikaansLabel";
            this.afrikaansLabel.Size = new System.Drawing.Size(94, 21);
            this.afrikaansLabel.TabIndex = 31;
            this.afrikaansLabel.Text = "Afrikaans";
            // 
            // goodNewsLbl
            // 
            this.goodNewsLbl.AutoSize = true;
            this.goodNewsLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.goodNewsLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goodNewsLbl.Location = new System.Drawing.Point(255, 360);
            this.goodNewsLbl.Name = "goodNewsLbl";
            this.goodNewsLbl.Size = new System.Drawing.Size(124, 20);
            this.goodNewsLbl.TabIndex = 32;
            this.goodNewsLbl.Text = "That is good news";
            // 
            // goeieNussLbl
            // 
            this.goeieNussLbl.AutoSize = true;
            this.goeieNussLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.goeieNussLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goeieNussLbl.Location = new System.Drawing.Point(459, 360);
            this.goeieNussLbl.Name = "goeieNussLbl";
            this.goeieNussLbl.Size = new System.Drawing.Size(113, 20);
            this.goeieNussLbl.TabIndex = 33;
            this.goeieNussLbl.Text = "Dit is goeie nuss";
            // 
            // carPic
            // 
            this.carPic.Image = ((System.Drawing.Image)(resources.GetObject("carPic.Image")));
            this.carPic.Location = new System.Drawing.Point(236, 41);
            this.carPic.Name = "carPic";
            this.carPic.Size = new System.Drawing.Size(368, 245);
            this.carPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPic.TabIndex = 34;
            this.carPic.TabStop = false;
            // 
            // canIUseYouCarLbl
            // 
            this.canIUseYouCarLbl.AutoSize = true;
            this.canIUseYouCarLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.canIUseYouCarLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canIUseYouCarLbl.Location = new System.Drawing.Point(255, 360);
            this.canIUseYouCarLbl.Name = "canIUseYouCarLbl";
            this.canIUseYouCarLbl.Size = new System.Drawing.Size(130, 20);
            this.canIUseYouCarLbl.TabIndex = 35;
            this.canIUseYouCarLbl.Text = "Can I use your car?";
            // 
            // kanEkJouKarGebruik
            // 
            this.kanEkJouKarGebruik.AutoSize = true;
            this.kanEkJouKarGebruik.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kanEkJouKarGebruik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kanEkJouKarGebruik.Location = new System.Drawing.Point(445, 360);
            this.kanEkJouKarGebruik.Name = "kanEkJouKarGebruik";
            this.kanEkJouKarGebruik.Size = new System.Drawing.Size(157, 20);
            this.kanEkJouKarGebruik.TabIndex = 36;
            this.kanEkJouKarGebruik.Text = "Kan Ek jou kar gebruik?";
            // 
            // dustPic
            // 
            this.dustPic.Image = ((System.Drawing.Image)(resources.GetObject("dustPic.Image")));
            this.dustPic.Location = new System.Drawing.Point(236, 41);
            this.dustPic.Name = "dustPic";
            this.dustPic.Size = new System.Drawing.Size(368, 245);
            this.dustPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dustPic.TabIndex = 37;
            this.dustPic.TabStop = false;
            // 
            // shelfWithDustLbl
            // 
            this.shelfWithDustLbl.AutoSize = true;
            this.shelfWithDustLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.shelfWithDustLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shelfWithDustLbl.Location = new System.Drawing.Point(255, 360);
            this.shelfWithDustLbl.Name = "shelfWithDustLbl";
            this.shelfWithDustLbl.Size = new System.Drawing.Size(150, 20);
            this.shelfWithDustLbl.TabIndex = 38;
            this.shelfWithDustLbl.Text = "The shelf is full of dust";
            // 
            // dieRakLbl
            // 
            this.dieRakLbl.AutoSize = true;
            this.dieRakLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dieRakLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dieRakLbl.Location = new System.Drawing.Point(455, 360);
            this.dieRakLbl.Name = "dieRakLbl";
            this.dieRakLbl.Size = new System.Drawing.Size(119, 20);
            this.dieRakLbl.TabIndex = 39;
            this.dieRakLbl.Text = "Die rak is vol stof";
            // 
            // visitPic
            // 
            this.visitPic.Image = ((System.Drawing.Image)(resources.GetObject("visitPic.Image")));
            this.visitPic.Location = new System.Drawing.Point(236, 41);
            this.visitPic.Name = "visitPic";
            this.visitPic.Size = new System.Drawing.Size(368, 245);
            this.visitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visitPic.TabIndex = 40;
            this.visitPic.TabStop = false;
            // 
            // tomorrowVisitLbl
            // 
            this.tomorrowVisitLbl.AutoSize = true;
            this.tomorrowVisitLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tomorrowVisitLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tomorrowVisitLbl.Location = new System.Drawing.Point(247, 360);
            this.tomorrowVisitLbl.Name = "tomorrowVisitLbl";
            this.tomorrowVisitLbl.Size = new System.Drawing.Size(138, 20);
            this.tomorrowVisitLbl.TabIndex = 41;
            this.tomorrowVisitLbl.Text = "I am going to come ";
            // 
            // ekGaanMoreKomKuierLbl
            // 
            this.ekGaanMoreKomKuierLbl.AutoSize = true;
            this.ekGaanMoreKomKuierLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ekGaanMoreKomKuierLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekGaanMoreKomKuierLbl.Location = new System.Drawing.Point(439, 360);
            this.ekGaanMoreKomKuierLbl.Name = "ekGaanMoreKomKuierLbl";
            this.ekGaanMoreKomKuierLbl.Size = new System.Drawing.Size(163, 20);
            this.ekGaanMoreKomKuierLbl.TabIndex = 42;
            this.ekGaanMoreKomKuierLbl.Text = "Ek gaan more kom kuier";
            // 
            // tomorrowVisitLbl2
            // 
            this.tomorrowVisitLbl2.AutoSize = true;
            this.tomorrowVisitLbl2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tomorrowVisitLbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tomorrowVisitLbl2.Location = new System.Drawing.Point(247, 380);
            this.tomorrowVisitLbl2.Name = "tomorrowVisitLbl2";
            this.tomorrowVisitLbl2.Size = new System.Drawing.Size(134, 20);
            this.tomorrowVisitLbl2.TabIndex = 43;
            this.tomorrowVisitLbl2.Text = "and visit tomorrow ";
            // 
            // niceFoodLbl
            // 
            this.niceFoodLbl.AutoSize = true;
            this.niceFoodLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.niceFoodLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.niceFoodLbl.Location = new System.Drawing.Point(247, 360);
            this.niceFoodLbl.Name = "niceFoodLbl";
            this.niceFoodLbl.Size = new System.Drawing.Size(138, 20);
            this.niceFoodLbl.TabIndex = 45;
            this.niceFoodLbl.Text = "The food is very nice";
            // 
            // niceFoodPic
            // 
            this.niceFoodPic.Image = ((System.Drawing.Image)(resources.GetObject("niceFoodPic.Image")));
            this.niceFoodPic.Location = new System.Drawing.Point(236, 41);
            this.niceFoodPic.Name = "niceFoodPic";
            this.niceFoodPic.Size = new System.Drawing.Size(368, 245);
            this.niceFoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.niceFoodPic.TabIndex = 46;
            this.niceFoodPic.TabStop = false;
            // 
            // lekkerKosLbl
            // 
            this.lekkerKosLbl.AutoSize = true;
            this.lekkerKosLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lekkerKosLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lekkerKosLbl.Location = new System.Drawing.Point(445, 360);
            this.lekkerKosLbl.Name = "lekkerKosLbl";
            this.lekkerKosLbl.Size = new System.Drawing.Size(142, 20);
            this.lekkerKosLbl.TabIndex = 47;
            this.lekkerKosLbl.Text = "Die kos is baie lekker";
            // 
            // loudNeighboursPic
            // 
            this.loudNeighboursPic.Image = ((System.Drawing.Image)(resources.GetObject("loudNeighboursPic.Image")));
            this.loudNeighboursPic.Location = new System.Drawing.Point(236, 41);
            this.loudNeighboursPic.Name = "loudNeighboursPic";
            this.loudNeighboursPic.Size = new System.Drawing.Size(368, 245);
            this.loudNeighboursPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loudNeighboursPic.TabIndex = 48;
            this.loudNeighboursPic.TabStop = false;
            // 
            // loudNeighboursLbl
            // 
            this.loudNeighboursLbl.AutoSize = true;
            this.loudNeighboursLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loudNeighboursLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loudNeighboursLbl.Location = new System.Drawing.Point(227, 360);
            this.loudNeighboursLbl.Name = "loudNeighboursLbl";
            this.loudNeighboursLbl.Size = new System.Drawing.Size(189, 20);
            this.loudNeighboursLbl.TabIndex = 49;
            this.loudNeighboursLbl.Text = "The neighbors are very noisy";
            // 
            // raasBureLbl
            // 
            this.raasBureLbl.AutoSize = true;
            this.raasBureLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.raasBureLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.raasBureLbl.Location = new System.Drawing.Point(449, 360);
            this.raasBureLbl.Name = "raasBureLbl";
            this.raasBureLbl.Size = new System.Drawing.Size(125, 20);
            this.raasBureLbl.TabIndex = 50;
            this.raasBureLbl.Text = "Die bure raas baie";
            // 
            // DifficultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.raasBureLbl);
            this.Controls.Add(this.loudNeighboursLbl);
            this.Controls.Add(this.loudNeighboursPic);
            this.Controls.Add(this.lekkerKosLbl);
            this.Controls.Add(this.niceFoodPic);
            this.Controls.Add(this.niceFoodLbl);
            this.Controls.Add(this.tomorrowVisitLbl2);
            this.Controls.Add(this.ekGaanMoreKomKuierLbl);
            this.Controls.Add(this.tomorrowVisitLbl);
            this.Controls.Add(this.visitPic);
            this.Controls.Add(this.dieRakLbl);
            this.Controls.Add(this.shelfWithDustLbl);
            this.Controls.Add(this.dustPic);
            this.Controls.Add(this.kanEkJouKarGebruik);
            this.Controls.Add(this.canIUseYouCarLbl);
            this.Controls.Add(this.carPic);
            this.Controls.Add(this.goeieNussLbl);
            this.Controls.Add(this.goodNewsLbl);
            this.Controls.Add(this.afrikaansLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.goodNewsPic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.CountDownControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftArrow);
            this.Location = new System.Drawing.Point(236, 41);
            this.Name = "DifficultForm";
            this.Text = "difficultForm";
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodNewsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dustPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niceFoodPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loudNeighboursPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label CountDownControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LeftArrow;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox goodNewsPic;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label afrikaansLabel;
        private System.Windows.Forms.Label goodNewsLbl;
        private System.Windows.Forms.Label goeieNussLbl;
        private System.Windows.Forms.PictureBox carPic;
        private System.Windows.Forms.Label canIUseYouCarLbl;
        private System.Windows.Forms.Label kanEkJouKarGebruik;
        private System.Windows.Forms.PictureBox dustPic;
        private System.Windows.Forms.Label shelfWithDustLbl;
        private System.Windows.Forms.Label dieRakLbl;
        private System.Windows.Forms.PictureBox visitPic;
        private System.Windows.Forms.Label tomorrowVisitLbl;
        private System.Windows.Forms.Label ekGaanMoreKomKuierLbl;
        private System.Windows.Forms.Label tomorrowVisitLbl2;
        private System.Windows.Forms.Label niceFoodLbl;
        private System.Windows.Forms.PictureBox niceFoodPic;
        private System.Windows.Forms.Label lekkerKosLbl;
        private System.Windows.Forms.PictureBox loudNeighboursPic;
        private System.Windows.Forms.Label loudNeighboursLbl;
        private System.Windows.Forms.Label raasBureLbl;
    }
}