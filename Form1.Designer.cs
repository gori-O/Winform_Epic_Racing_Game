namespace racingGame
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            this.TNT = new System.Windows.Forms.PictureBox();
            this.lblgameover = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.pictureBox_coin = new System.Windows.Forms.PictureBox();
            this.lbl_myscore = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.pBox_start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_start)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(180, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(180, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 116);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(180, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 116);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(180, -76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 116);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(357, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 449);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 449);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_car.Image")));
            this.pictureBox_car.Location = new System.Drawing.Point(159, 326);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(58, 96);
            this.pictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_car.TabIndex = 6;
            this.pictureBox_car.TabStop = false;
            // 
            // TNT
            // 
            this.TNT.Image = ((System.Drawing.Image)(resources.GetObject("TNT.Image")));
            this.TNT.Location = new System.Drawing.Point(274, 28);
            this.TNT.Name = "TNT";
            this.TNT.Size = new System.Drawing.Size(58, 79);
            this.TNT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TNT.TabIndex = 7;
            this.TNT.TabStop = false;
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblgameover.ForeColor = System.Drawing.Color.Yellow;
            this.lblgameover.Location = new System.Drawing.Point(92, 122);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Size = new System.Drawing.Size(195, 40);
            this.lblgameover.TabIndex = 8;
            this.lblgameover.Text = "게임 오버";
            this.lblgameover.Visible = false;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblscore.ForeColor = System.Drawing.Color.Lime;
            this.lblscore.Location = new System.Drawing.Point(26, 9);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(98, 20);
            this.lblscore.TabIndex = 9;
            this.lblscore.Text = "score : 0";
            // 
            // pictureBox_coin
            // 
            this.pictureBox_coin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coin.Image")));
            this.pictureBox_coin.Location = new System.Drawing.Point(30, 32);
            this.pictureBox_coin.Name = "pictureBox_coin";
            this.pictureBox_coin.Size = new System.Drawing.Size(45, 48);
            this.pictureBox_coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_coin.TabIndex = 10;
            this.pictureBox_coin.TabStop = false;
            // 
            // lbl_myscore
            // 
            this.lbl_myscore.AutoSize = true;
            this.lbl_myscore.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_myscore.Location = new System.Drawing.Point(96, 177);
            this.lbl_myscore.Name = "lbl_myscore";
            this.lbl_myscore.Size = new System.Drawing.Size(17, 18);
            this.lbl_myscore.TabIndex = 11;
            this.lbl_myscore.Text = "-";
            this.lbl_myscore.Visible = false;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_speed.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_speed.Location = new System.Drawing.Point(255, 417);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(95, 18);
            this.lbl_speed.TabIndex = 12;
            this.lbl_speed.Text = "speed : 0";
            // 
            // pBox_start
            // 
            this.pBox_start.Image = ((System.Drawing.Image)(resources.GetObject("pBox_start.Image")));
            this.pBox_start.Location = new System.Drawing.Point(108, 177);
            this.pBox_start.Name = "pBox_start";
            this.pBox_start.Size = new System.Drawing.Size(163, 75);
            this.pBox_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_start.TabIndex = 13;
            this.pBox_start.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(378, 444);
            this.Controls.Add(this.pBox_start);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.lbl_myscore);
            this.Controls.Add(this.pictureBox_coin);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblgameover);
            this.Controls.Add(this.TNT);
            this.Controls.Add(this.pictureBox_car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "분노의 질주";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox TNT;
        private System.Windows.Forms.Label lblgameover;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox pictureBox_coin;
        private System.Windows.Forms.Label lbl_myscore;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.PictureBox pictureBox_car;
        private System.Windows.Forms.PictureBox pBox_start;
    }
}

