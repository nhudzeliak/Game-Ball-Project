
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rounded_ButtonTheBall = new Ball_Game_Project.Rounded_Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rounded_ButtonTheBall);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // rounded_ButtonTheBall
            // 
            this.rounded_ButtonTheBall.BorderColor = System.Drawing.Color.White;
            this.rounded_ButtonTheBall.ButtonColor = System.Drawing.Color.Red;
            this.rounded_ButtonTheBall.FlatAppearance.BorderSize = 0;
            this.rounded_ButtonTheBall.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rounded_ButtonTheBall.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rounded_ButtonTheBall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_ButtonTheBall.Location = new System.Drawing.Point(264, 174);
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
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPlaying";
            this.Text = "Ball Game";
            this.Load += new System.EventHandler(this.FormPlaying_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Rounded_Button rounded_ButtonTheBall;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}