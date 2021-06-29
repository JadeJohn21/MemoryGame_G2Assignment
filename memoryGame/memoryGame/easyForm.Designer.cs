
namespace memoryGame
{
    partial class EasyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyForm));
            this.helloImage = new System.Windows.Forms.PictureBox();
            this.englishLabel = new System.Windows.Forms.Label();
            this.afrikaansLabel = new System.Windows.Forms.Label();
            this.helloLabel = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.BackButton = new System.Windows.Forms.Label();
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.halloLabel = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.huisLabel = new System.Windows.Forms.Label();
            this.kitchenLabel = new System.Windows.Forms.Label();
            this.kombuisLabel = new System.Windows.Forms.Label();
            this.dogLabel = new System.Windows.Forms.Label();
            this.hondLabel = new System.Windows.Forms.Label();
            this.captainLabel = new System.Windows.Forms.Label();
            this.kapteinLabel = new System.Windows.Forms.Label();
            this.notificationLabel1 = new System.Windows.Forms.Label();
            this.notificationLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.helloImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // helloImage
            // 
            this.helloImage.Image = global::memoryGame.Properties.Resources.hello;
            this.helloImage.Location = new System.Drawing.Point(236, 41);
            this.helloImage.Name = "helloImage";
            this.helloImage.Size = new System.Drawing.Size(368, 245);
            this.helloImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helloImage.TabIndex = 1;
            this.helloImage.TabStop = false;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.englishLabel.Location = new System.Drawing.Point(277, 315);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(73, 21);
            this.englishLabel.TabIndex = 2;
            this.englishLabel.Text = "English";
            // 
            // afrikaansLabel
            // 
            this.afrikaansLabel.AutoSize = true;
            this.afrikaansLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.afrikaansLabel.Location = new System.Drawing.Point(468, 315);
            this.afrikaansLabel.Name = "afrikaansLabel";
            this.afrikaansLabel.Size = new System.Drawing.Size(94, 21);
            this.afrikaansLabel.TabIndex = 3;
            this.afrikaansLabel.Text = "Afrikaans";
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.helloLabel.Location = new System.Drawing.Point(289, 360);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(43, 20);
            this.helloLabel.TabIndex = 4;
            this.helloLabel.Text = "Hello";
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
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
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            // 
            // LeftArrow
            // 
            this.LeftArrow.Image = global::memoryGame.Properties.Resources.arrow_left_circle_318_1450_removebg_preview;
            this.LeftArrow.Location = new System.Drawing.Point(12, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(48, 44);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 9;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // startBtn
            // 
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.startBtn.Location = new System.Drawing.Point(678, 118);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(123, 58);
            this.startBtn.TabIndex = 33;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // halloLabel
            // 
            this.halloLabel.AutoSize = true;
            this.halloLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.halloLabel.Location = new System.Drawing.Point(487, 360);
            this.halloLabel.Name = "halloLabel";
            this.halloLabel.Size = new System.Drawing.Size(44, 20);
            this.halloLabel.TabIndex = 34;
            this.halloLabel.Text = "Hallo";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.houseLabel.Location = new System.Drawing.Point(289, 396);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(49, 20);
            this.houseLabel.TabIndex = 35;
            this.houseLabel.Text = "House";
            // 
            // huisLabel
            // 
            this.huisLabel.AutoSize = true;
            this.huisLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.huisLabel.Location = new System.Drawing.Point(487, 396);
            this.huisLabel.Name = "huisLabel";
            this.huisLabel.Size = new System.Drawing.Size(38, 20);
            this.huisLabel.TabIndex = 36;
            this.huisLabel.Text = "Huis";
            // 
            // kitchenLabel
            // 
            this.kitchenLabel.AutoSize = true;
            this.kitchenLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kitchenLabel.Location = new System.Drawing.Point(289, 437);
            this.kitchenLabel.Name = "kitchenLabel";
            this.kitchenLabel.Size = new System.Drawing.Size(57, 20);
            this.kitchenLabel.TabIndex = 37;
            this.kitchenLabel.Text = "Kitchen";
            // 
            // kombuisLabel
            // 
            this.kombuisLabel.AutoSize = true;
            this.kombuisLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kombuisLabel.Location = new System.Drawing.Point(487, 437);
            this.kombuisLabel.Name = "kombuisLabel";
            this.kombuisLabel.Size = new System.Drawing.Size(65, 20);
            this.kombuisLabel.TabIndex = 38;
            this.kombuisLabel.Text = "Kombuis";
            // 
            // dogLabel
            // 
            this.dogLabel.AutoSize = true;
            this.dogLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dogLabel.Location = new System.Drawing.Point(289, 479);
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Size = new System.Drawing.Size(36, 20);
            this.dogLabel.TabIndex = 39;
            this.dogLabel.Text = "Dog";
            // 
            // hondLabel
            // 
            this.hondLabel.AutoSize = true;
            this.hondLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hondLabel.Location = new System.Drawing.Point(487, 479);
            this.hondLabel.Name = "hondLabel";
            this.hondLabel.Size = new System.Drawing.Size(44, 20);
            this.hondLabel.TabIndex = 40;
            this.hondLabel.Text = "Hond";
            // 
            // captainLabel
            // 
            this.captainLabel.AutoSize = true;
            this.captainLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.captainLabel.Location = new System.Drawing.Point(286, 521);
            this.captainLabel.Name = "captainLabel";
            this.captainLabel.Size = new System.Drawing.Size(60, 20);
            this.captainLabel.TabIndex = 41;
            this.captainLabel.Text = "Captain";
            // 
            // kapteinLabel
            // 
            this.kapteinLabel.AutoSize = true;
            this.kapteinLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kapteinLabel.Location = new System.Drawing.Point(487, 521);
            this.kapteinLabel.Name = "kapteinLabel";
            this.kapteinLabel.Size = new System.Drawing.Size(58, 20);
            this.kapteinLabel.TabIndex = 42;
            this.kapteinLabel.Text = "Kaptein";
            // 
            // notificationLabel1
            // 
            this.notificationLabel1.AutoSize = true;
            this.notificationLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notificationLabel1.Location = new System.Drawing.Point(661, 41);
            this.notificationLabel1.Name = "notificationLabel1";
            this.notificationLabel1.Size = new System.Drawing.Size(168, 20);
            this.notificationLabel1.TabIndex = 43;
            this.notificationLabel1.Text = "You may take as long as ";
            // 
            // notificationLabel2
            // 
            this.notificationLabel2.AutoSize = true;
            this.notificationLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notificationLabel2.Location = new System.Drawing.Point(660, 72);
            this.notificationLabel2.Name = "notificationLabel2";
            this.notificationLabel2.Size = new System.Drawing.Size(169, 20);
            this.notificationLabel2.TabIndex = 44;
            this.notificationLabel2.Text = " you wish to do this level.";
            // 
            // EasyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.notificationLabel2);
            this.Controls.Add(this.notificationLabel1);
            this.Controls.Add(this.kapteinLabel);
            this.Controls.Add(this.captainLabel);
            this.Controls.Add(this.hondLabel);
            this.Controls.Add(this.dogLabel);
            this.Controls.Add(this.kombuisLabel);
            this.Controls.Add(this.kitchenLabel);
            this.Controls.Add(this.huisLabel);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.halloLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.afrikaansLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.helloImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EasyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Level";
            ((System.ComponentModel.ISupportInitialize)(this.helloImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox helloImage;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label afrikaansLabel;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.PictureBox LeftArrow;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label halloLabel;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label huisLabel;
        private System.Windows.Forms.Label kitchenLabel;
        private System.Windows.Forms.Label kombuisLabel;
        private System.Windows.Forms.Label dogLabel;
        private System.Windows.Forms.Label hondLabel;
        private System.Windows.Forms.Label captainLabel;
        private System.Windows.Forms.Label kapteinLabel;
        private System.Windows.Forms.Label notificationLabel1;
        private System.Windows.Forms.Label notificationLabel2;
    }
}