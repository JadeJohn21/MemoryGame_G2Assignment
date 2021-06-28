
namespace memoryGame
{
    partial class MediumForm
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
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountDownControl1 = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.overweightPic = new System.Windows.Forms.PictureBox();
            this.englishLabel = new System.Windows.Forms.Label();
            this.afrikaansLabel = new System.Windows.Forms.Label();
            this.overweightLabel = new System.Windows.Forms.Label();
            this.oorgewigLabel = new System.Windows.Forms.Label();
            this.grayHairPic = new System.Windows.Forms.PictureBox();
            this.grayHairLabel = new System.Windows.Forms.Label();
            this.grysHareLabel = new System.Windows.Forms.Label();
            this.iToldYouSoPic = new System.Windows.Forms.PictureBox();
            this.iToldYouSoLabel = new System.Windows.Forms.Label();
            this.ekHetJouGesêLabel = new System.Windows.Forms.Label();
            this.youAreBannedPic = new System.Windows.Forms.PictureBox();
            this.youAreBannedLabel = new System.Windows.Forms.Label();
            this.jyIsVerbanLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overweightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHairPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iToldYouSoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youAreBannedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftArrow
            // 
            this.LeftArrow.Image = global::memoryGame.Properties.Resources.arrow_left_circle_318_1450_removebg_preview;
            this.LeftArrow.Location = new System.Drawing.Point(12, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(48, 44);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 5;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(12, 59);
            this.BackButton.Name = "BackButton";
            this.BackButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BackButton.Size = new System.Drawing.Size(41, 16);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(676, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 10;
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
            this.label1.TabIndex = 9;
            this.label1.Text = "You have: ";
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
            this.CountDownControl1.TabIndex = 11;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.startBtn.Location = new System.Drawing.Point(360, 276);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(123, 58);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // overweightPic
            // 
            this.overweightPic.Image = global::memoryGame.Properties.Resources.overweight;
            this.overweightPic.Location = new System.Drawing.Point(236, 41);
            this.overweightPic.Name = "overweightPic";
            this.overweightPic.Size = new System.Drawing.Size(368, 245);
            this.overweightPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.overweightPic.TabIndex = 13;
            this.overweightPic.TabStop = false;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.englishLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.englishLabel.Location = new System.Drawing.Point(277, 315);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(73, 21);
            this.englishLabel.TabIndex = 14;
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
            this.afrikaansLabel.TabIndex = 15;
            this.afrikaansLabel.Text = "Afrikaans";
            // 
            // overweightLabel
            // 
            this.overweightLabel.AutoSize = true;
            this.overweightLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.overweightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overweightLabel.Location = new System.Drawing.Point(273, 360);
            this.overweightLabel.Name = "overweightLabel";
            this.overweightLabel.Size = new System.Drawing.Size(82, 20);
            this.overweightLabel.TabIndex = 16;
            this.overweightLabel.Text = "Overweight";
            // 
            // oorgewigLabel
            // 
            this.oorgewigLabel.AutoSize = true;
            this.oorgewigLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.oorgewigLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oorgewigLabel.Location = new System.Drawing.Point(480, 360);
            this.oorgewigLabel.Name = "oorgewigLabel";
            this.oorgewigLabel.Size = new System.Drawing.Size(71, 20);
            this.oorgewigLabel.TabIndex = 17;
            this.oorgewigLabel.Text = "Oorgewig";
            // 
            // grayHairPic
            // 
            this.grayHairPic.Image = global::memoryGame.Properties.Resources.gray_hair;
            this.grayHairPic.Location = new System.Drawing.Point(236, 41);
            this.grayHairPic.Name = "grayHairPic";
            this.grayHairPic.Size = new System.Drawing.Size(368, 245);
            this.grayHairPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grayHairPic.TabIndex = 18;
            this.grayHairPic.TabStop = false;
            // 
            // grayHairLabel
            // 
            this.grayHairLabel.AutoSize = true;
            this.grayHairLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grayHairLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grayHairLabel.Location = new System.Drawing.Point(251, 360);
            this.grayHairLabel.Name = "grayHairLabel";
            this.grayHairLabel.Size = new System.Drawing.Size(128, 20);
            this.grayHairLabel.TabIndex = 19;
            this.grayHairLabel.Text = "You have gray hair";
            // 
            // grysHareLabel
            // 
            this.grysHareLabel.AutoSize = true;
            this.grysHareLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grysHareLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grysHareLabel.Location = new System.Drawing.Point(453, 360);
            this.grysHareLabel.Name = "grysHareLabel";
            this.grysHareLabel.Size = new System.Drawing.Size(107, 20);
            this.grysHareLabel.TabIndex = 20;
            this.grysHareLabel.Text = "Jy het grys hare";
            // 
            // iToldYouSoPic
            // 
            this.iToldYouSoPic.Image = global::memoryGame.Properties.Resources.I_told_you_so;
            this.iToldYouSoPic.Location = new System.Drawing.Point(236, 41);
            this.iToldYouSoPic.Name = "iToldYouSoPic";
            this.iToldYouSoPic.Size = new System.Drawing.Size(368, 245);
            this.iToldYouSoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iToldYouSoPic.TabIndex = 21;
            this.iToldYouSoPic.TabStop = false;
            // 
            // iToldYouSoLabel
            // 
            this.iToldYouSoLabel.AutoSize = true;
            this.iToldYouSoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.iToldYouSoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iToldYouSoLabel.Location = new System.Drawing.Point(270, 360);
            this.iToldYouSoLabel.Name = "iToldYouSoLabel";
            this.iToldYouSoLabel.Size = new System.Drawing.Size(87, 20);
            this.iToldYouSoLabel.TabIndex = 22;
            this.iToldYouSoLabel.Text = "I told you so";
            // 
            // ekHetJouGesêLabel
            // 
            this.ekHetJouGesêLabel.AutoSize = true;
            this.ekHetJouGesêLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ekHetJouGesêLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekHetJouGesêLabel.Location = new System.Drawing.Point(463, 360);
            this.ekHetJouGesêLabel.Name = "ekHetJouGesêLabel";
            this.ekHetJouGesêLabel.Size = new System.Drawing.Size(103, 20);
            this.ekHetJouGesêLabel.TabIndex = 23;
            this.ekHetJouGesêLabel.Text = "Ek het jou gesê";
            // 
            // youAreBannedPic
            // 
            this.youAreBannedPic.Image = global::memoryGame.Properties.Resources.You_re_banned;
            this.youAreBannedPic.Location = new System.Drawing.Point(236, 41);
            this.youAreBannedPic.Name = "youAreBannedPic";
            this.youAreBannedPic.Size = new System.Drawing.Size(368, 245);
            this.youAreBannedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.youAreBannedPic.TabIndex = 24;
            this.youAreBannedPic.TabStop = false;
            // 
            // youAreBannedLabel
            // 
            this.youAreBannedLabel.AutoSize = true;
            this.youAreBannedLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.youAreBannedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.youAreBannedLabel.Location = new System.Drawing.Point(260, 360);
            this.youAreBannedLabel.Name = "youAreBannedLabel";
            this.youAreBannedLabel.Size = new System.Drawing.Size(104, 20);
            this.youAreBannedLabel.TabIndex = 25;
            this.youAreBannedLabel.Text = "You\'re banned!";
            // 
            // jyIsVerbanLabel
            // 
            this.jyIsVerbanLabel.AutoSize = true;
            this.jyIsVerbanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.jyIsVerbanLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jyIsVerbanLabel.Location = new System.Drawing.Point(472, 360);
            this.jyIsVerbanLabel.Name = "jyIsVerbanLabel";
            this.jyIsVerbanLabel.Size = new System.Drawing.Size(87, 20);
            this.jyIsVerbanLabel.TabIndex = 26;
            this.jyIsVerbanLabel.Text = "Jy is verban!";
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
            this.label3.TabIndex = 27;
            this.label3.Text = "60";
            // 
            // MediumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jyIsVerbanLabel);
            this.Controls.Add(this.youAreBannedLabel);
            this.Controls.Add(this.youAreBannedPic);
            this.Controls.Add(this.ekHetJouGesêLabel);
            this.Controls.Add(this.iToldYouSoLabel);
            this.Controls.Add(this.iToldYouSoPic);
            this.Controls.Add(this.grysHareLabel);
            this.Controls.Add(this.grayHairLabel);
            this.Controls.Add(this.grayHairPic);
            this.Controls.Add(this.oorgewigLabel);
            this.Controls.Add(this.overweightLabel);
            this.Controls.Add(this.afrikaansLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.overweightPic);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.CountDownControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LeftArrow);
            this.Name = "MediumForm";
            this.Text = "mediumForm";
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overweightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHairPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iToldYouSoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youAreBannedPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftArrow;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer CountDownTimer1;
        private System.Windows.Forms.Label CountDownControl1;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox overweightPic;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label afrikaansLabel;
        private System.Windows.Forms.Label overweightLabel;
        private System.Windows.Forms.Label oorgewigLabel;
        private System.Windows.Forms.PictureBox grayHairPic;
        private System.Windows.Forms.Label grayHairLabel;
        private System.Windows.Forms.Label grysHareLabel;
        private System.Windows.Forms.PictureBox iToldYouSoPic;
        private System.Windows.Forms.Label iToldYouSoLabel;
        private System.Windows.Forms.Label ekHetJouGesêLabel;
        private System.Windows.Forms.PictureBox youAreBannedPic;
        private System.Windows.Forms.Label youAreBannedLabel;
        private System.Windows.Forms.Label jyIsVerbanLabel;
        private System.Windows.Forms.Label label3;
    }
}