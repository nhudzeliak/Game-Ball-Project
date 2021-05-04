
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRating));
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.ColumnPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.AllowUserToResizeColumns = false;
            this.dataGridViewTable.AllowUserToResizeRows = false;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlace,
            this.ColumnPlayer,
            this.ColumnBestTime});
            this.dataGridViewTable.Location = new System.Drawing.Point(80, 71);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.RowHeadersVisible = false;
            this.dataGridViewTable.RowHeadersWidth = 62;
            this.dataGridViewTable.RowTemplate.Height = 28;
            this.dataGridViewTable.Size = new System.Drawing.Size(400, 439);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // ColumnPlace
            // 
            this.ColumnPlace.HeaderText = "Place";
            this.ColumnPlace.MinimumWidth = 8;
            this.ColumnPlace.Name = "ColumnPlace";
            this.ColumnPlace.ReadOnly = true;
            this.ColumnPlace.Width = 40;
            // 
            // ColumnPlayer
            // 
            this.ColumnPlayer.HeaderText = "Player";
            this.ColumnPlayer.MinimumWidth = 8;
            this.ColumnPlayer.Name = "ColumnPlayer";
            this.ColumnPlayer.ReadOnly = true;
            this.ColumnPlayer.Width = 97;
            // 
            // ColumnBestTime
            // 
            this.ColumnBestTime.HeaderText = "Time";
            this.ColumnBestTime.MinimumWidth = 8;
            this.ColumnBestTime.Name = "ColumnBestTime";
            this.ColumnBestTime.ReadOnly = true;
            this.ColumnBestTime.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Best players";
            // 
            // FormRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(565, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "FormRating";
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.FormRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBestTime;
    }
}