
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(339, 227);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(148, 41);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRating
            // 
            this.buttonRating.Location = new System.Drawing.Point(536, 233);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(119, 35);
            this.buttonRating.TabIndex = 2;
            this.buttonRating.Text = "Rating";
            this.buttonRating.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 166);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(317, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 32);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Game name";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(222, 169);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(608, 338);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(84, 31);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.Location = new System.Drawing.Point(12, 12);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Size = new System.Drawing.Size(109, 41);
            this.buttonAboutUs.TabIndex = 7;
            this.buttonAboutUs.Text = "About us";
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAboutUs);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonPlay);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAboutUs;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

