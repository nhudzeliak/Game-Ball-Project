
namespace Ball_Game_Project
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.rounded_ButtonHTP = new Ball_Game_Project.Rounded_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLight = new System.Windows.Forms.Button();
            this.buttonDark = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rounded_ButtonHTP
            // 
            this.rounded_ButtonHTP.BorderColor = System.Drawing.Color.Orange;
            this.rounded_ButtonHTP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.rounded_ButtonHTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rounded_ButtonHTP.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rounded_ButtonHTP.Location = new System.Drawing.Point(192, 50);
            this.rounded_ButtonHTP.Name = "rounded_ButtonHTP";
            this.rounded_ButtonHTP.OnHoverBorderColor = System.Drawing.Color.MediumTurquoise;
            this.rounded_ButtonHTP.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.rounded_ButtonHTP.OnHoverTextColor = System.Drawing.Color.Black;
            this.rounded_ButtonHTP.Size = new System.Drawing.Size(255, 88);
            this.rounded_ButtonHTP.TabIndex = 0;
            this.rounded_ButtonHTP.Text = "How to play";
            this.rounded_ButtonHTP.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.rounded_ButtonHTP, "Rules of the game ");
            this.rounded_ButtonHTP.UseVisualStyleBackColor = true;
            this.rounded_ButtonHTP.Click += new System.EventHandler(this.rounded_ButtonHTP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Style";
            // 
            // buttonLight
            // 
            this.buttonLight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLight.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLight.ForeColor = System.Drawing.Color.Orange;
            this.buttonLight.Location = new System.Drawing.Point(192, 253);
            this.buttonLight.Name = "buttonLight";
            this.buttonLight.Size = new System.Drawing.Size(88, 60);
            this.buttonLight.TabIndex = 2;
            this.buttonLight.Text = "Light";
            this.toolTip1.SetToolTip(this.buttonLight, "Choose light scheme");
            this.buttonLight.UseVisualStyleBackColor = false;
            this.buttonLight.Click += new System.EventHandler(this.buttonLight_Click);
            // 
            // buttonDark
            // 
            this.buttonDark.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDark.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDark.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDark.ForeColor = System.Drawing.Color.Orange;
            this.buttonDark.Location = new System.Drawing.Point(359, 253);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(88, 60);
            this.buttonDark.TabIndex = 3;
            this.buttonDark.Text = "Dark";
            this.toolTip1.SetToolTip(this.buttonDark, "Choose dark scheme");
            this.buttonDark.UseVisualStyleBackColor = false;
            this.buttonDark.Click += new System.EventHandler(this.buttonDark_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(621, 411);
            this.Controls.Add(this.buttonDark);
            this.Controls.Add(this.buttonLight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rounded_ButtonHTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rounded_Button rounded_ButtonHTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLight;
        private System.Windows.Forms.Button buttonDark;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}