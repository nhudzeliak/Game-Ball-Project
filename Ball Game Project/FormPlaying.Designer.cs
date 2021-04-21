
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rounded_ButtonTheBall = new Ball_Game_Project.Rounded_Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rounded_ButtonTheBall
            // 
            this.rounded_ButtonTheBall.BorderColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.ButtonColor = System.Drawing.Color.Red;
            this.rounded_ButtonTheBall.FlatAppearance.BorderSize = 0;
            this.rounded_ButtonTheBall.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rounded_ButtonTheBall.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rounded_ButtonTheBall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_ButtonTheBall.Location = new System.Drawing.Point(325, 112);
            this.rounded_ButtonTheBall.Name = "rounded_ButtonTheBall";
            this.rounded_ButtonTheBall.OnHoverBorderColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.OnHoverButtonColor = System.Drawing.Color.Red;
            this.rounded_ButtonTheBall.OnHoverTextColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.Size = new System.Drawing.Size(150, 150);
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
            this.Controls.Add(this.rounded_ButtonTheBall);
            this.Name = "FormPlaying";
            this.Text = "Ball Game";
            this.Load += new System.EventHandler(this.FormPlaying_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Rounded_Button rounded_ButtonTheBall;
    }
}