
namespace Ball_Game_Project
{
    partial class FormMainMenu
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rounded_Button1 = new Ball_Game_Project.Rounded_Button();
            this.rounded_ButtonRating = new Ball_Game_Project.Rounded_Button();
            this.rounded_ButtonPlay = new Ball_Game_Project.Rounded_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(319, 246);
            this.textBoxUser.MaxLength = 15;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(145, 26);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBoxUser, "Enter your username here");
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(233, 81);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(342, 81);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "CATCHy";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(205, 250);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(99, 22);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            // 
            // rounded_Button1
            // 
            this.rounded_Button1.BorderColor = System.Drawing.Color.Orange;
            this.rounded_Button1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.rounded_Button1.FlatAppearance.BorderSize = 0;
            this.rounded_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_Button1.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rounded_Button1.Location = new System.Drawing.Point(12, 12);
            this.rounded_Button1.Name = "rounded_Button1";
            this.rounded_Button1.OnHoverBorderColor = System.Drawing.Color.LightSkyBlue;
            this.rounded_Button1.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.rounded_Button1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.rounded_Button1.Size = new System.Drawing.Size(175, 60);
            this.rounded_Button1.TabIndex = 11;
            this.rounded_Button1.Text = "Settings";
            this.rounded_Button1.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.rounded_Button1, "Edit the style");
            this.rounded_Button1.UseVisualStyleBackColor = true;
            // 
            // rounded_ButtonRating
            // 
            this.rounded_ButtonRating.BorderColor = System.Drawing.Color.Orange;
            this.rounded_ButtonRating.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.rounded_ButtonRating.FlatAppearance.BorderSize = 0;
            this.rounded_ButtonRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_ButtonRating.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rounded_ButtonRating.Location = new System.Drawing.Point(613, 21);
            this.rounded_ButtonRating.Name = "rounded_ButtonRating";
            this.rounded_ButtonRating.OnHoverBorderColor = System.Drawing.Color.LightSkyBlue;
            this.rounded_ButtonRating.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.rounded_ButtonRating.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.rounded_ButtonRating.Size = new System.Drawing.Size(175, 60);
            this.rounded_ButtonRating.TabIndex = 10;
            this.rounded_ButtonRating.Text = "Leaderboards";
            this.rounded_ButtonRating.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.rounded_ButtonRating, "Best players");
            this.rounded_ButtonRating.UseVisualStyleBackColor = true;
            this.rounded_ButtonRating.Click += new System.EventHandler(this.rounded_ButtonRating_Click);
            // 
            // rounded_ButtonPlay
            // 
            this.rounded_ButtonPlay.BorderColor = System.Drawing.Color.Orange;
            this.rounded_ButtonPlay.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.rounded_ButtonPlay.FlatAppearance.BorderSize = 0;
            this.rounded_ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_ButtonPlay.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rounded_ButtonPlay.Location = new System.Drawing.Point(284, 324);
            this.rounded_ButtonPlay.Name = "rounded_ButtonPlay";
            this.rounded_ButtonPlay.OnHoverBorderColor = System.Drawing.Color.LightSkyBlue;
            this.rounded_ButtonPlay.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.rounded_ButtonPlay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.rounded_ButtonPlay.Size = new System.Drawing.Size(222, 81);
            this.rounded_ButtonPlay.TabIndex = 9;
            this.rounded_ButtonPlay.Text = "Play";
            this.rounded_ButtonPlay.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.rounded_ButtonPlay, "Start the game");
            this.rounded_ButtonPlay.UseVisualStyleBackColor = true;
            this.rounded_ButtonPlay.Click += new System.EventHandler(this.rounded_ButtonPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click and speed up";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 93);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rounded_Button1);
            this.Controls.Add(this.rounded_ButtonRating);
            this.Controls.Add(this.rounded_ButtonPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxUser);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private Rounded_Button rounded_ButtonPlay;
        private Rounded_Button rounded_ButtonRating;
        private Rounded_Button rounded_Button1;
        private System.Windows.Forms.Button button1;
    }
}

