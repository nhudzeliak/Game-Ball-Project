
namespace Ball_Game_Project
{
    partial class FormPlaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaying));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelScoreShow = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTimeShow = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonHome = new System.Windows.Forms.Button();
            this.rounded_ButtonTheBall = new Ball_Game_Project.Rounded_Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Orange;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.splitContainer1.Panel1.Controls.Add(this.buttonRestart);
            this.splitContainer1.Panel1.Controls.Add(this.labelScoreShow);
            this.splitContainer1.Panel1.Controls.Add(this.labelScore);
            this.splitContainer1.Panel1.Controls.Add(this.labelTimeShow);
            this.splitContainer1.Panel1.Controls.Add(this.labelTime);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.rounded_ButtonTheBall);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonRestart
            // 
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestart.Image")));
            this.buttonRestart.Location = new System.Drawing.Point(40, 298);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(77, 53);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelScoreShow
            // 
            this.labelScoreShow.AutoSize = true;
            this.labelScoreShow.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreShow.ForeColor = System.Drawing.Color.White;
            this.labelScoreShow.Location = new System.Drawing.Point(65, 148);
            this.labelScoreShow.Name = "labelScoreShow";
            this.labelScoreShow.Size = new System.Drawing.Size(22, 22);
            this.labelScoreShow.TabIndex = 3;
            this.labelScoreShow.Text = "0";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(48, 111);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(55, 20);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score";
            // 
            // labelTimeShow
            // 
            this.labelTimeShow.AutoSize = true;
            this.labelTimeShow.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeShow.ForeColor = System.Drawing.Color.White;
            this.labelTimeShow.Location = new System.Drawing.Point(12, 71);
            this.labelTimeShow.Name = "labelTimeShow";
            this.labelTimeShow.Size = new System.Drawing.Size(85, 20);
            this.labelTimeShow.TabIndex = 1;
            this.labelTimeShow.Text = "00:00:00";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(56, 31);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(47, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(40, 379);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 45);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // rounded_ButtonTheBall
            // 
            this.rounded_ButtonTheBall.BorderColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.ButtonColor = System.Drawing.Color.Red;
            this.rounded_ButtonTheBall.FlatAppearance.BorderSize = 0;
            this.rounded_ButtonTheBall.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rounded_ButtonTheBall.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rounded_ButtonTheBall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_ButtonTheBall.Location = new System.Drawing.Point(269, 148);
            this.rounded_ButtonTheBall.Name = "rounded_ButtonTheBall";
            this.rounded_ButtonTheBall.OnHoverBorderColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.OnHoverButtonColor = System.Drawing.Color.Red;
            this.rounded_ButtonTheBall.OnHoverTextColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.Size = new System.Drawing.Size(140, 140);
            this.rounded_ButtonTheBall.TabIndex = 0;
            this.rounded_ButtonTheBall.TextColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.UseVisualStyleBackColor = true;
            this.rounded_ButtonTheBall.Click += new System.EventHandler(this.rounded_ButtonTheBall_Click);
            // 
            // FormPlaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "FormPlaying";
            this.Text = "Ball Game";
            this.Load += new System.EventHandler(this.FormPlaying_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Rounded_Button rounded_ButtonTheBall;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelTimeShow;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelScoreShow;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonRestart;
    }
}