
namespace Ball_Game_Project
{
    partial class FormRating
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlace,
            this.ColumnPlayer,
            this.ColumnBestTime});
            this.dataGridView1.Location = new System.Drawing.Point(34, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(400, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Best players";
            // 
            // ColumnPlace
            // 
            this.ColumnPlace.HeaderText = "Place";
            this.ColumnPlace.MinimumWidth = 8;
            this.ColumnPlace.Name = "ColumnPlace";
            this.ColumnPlace.ReadOnly = true;
            this.ColumnPlace.Width = 50;
            // 
            // ColumnPlayer
            // 
            this.ColumnPlayer.HeaderText = "Player";
            this.ColumnPlayer.MinimumWidth = 8;
            this.ColumnPlayer.Name = "ColumnPlayer";
            this.ColumnPlayer.ReadOnly = true;
            this.ColumnPlayer.Width = 113;
            // 
            // ColumnBestTime
            // 
            this.ColumnBestTime.HeaderText = "Time";
            this.ColumnBestTime.MinimumWidth = 8;
            this.ColumnBestTime.Name = "ColumnBestTime";
            this.ColumnBestTime.ReadOnly = true;
            // 
            // FormRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRating";
            this.Text = "Rating";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBestTime;
    }
}