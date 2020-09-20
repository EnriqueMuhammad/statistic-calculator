namespace Statistic_Calculator
{
    partial class FormStatistik
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
            this.dataGridViewStat = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.BatasBawah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatasAtas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frekuensi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kumulative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrekMid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStat
            // 
            this.dataGridViewStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatasBawah,
            this.BatasAtas,
            this.Frekuensi,
            this.Kumulative,
            this.Relative,
            this.Mid,
            this.FrekMid});
            this.dataGridViewStat.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStat.Name = "dataGridViewStat";
            this.dataGridViewStat.RowHeadersWidth = 51;
            this.dataGridViewStat.RowTemplate.Height = 24;
            this.dataGridViewStat.Size = new System.Drawing.Size(1015, 426);
            this.dataGridViewStat.TabIndex = 0;
            this.dataGridViewStat.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStat_CellEndEdit);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(12, 470);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(1015, 79);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // BatasBawah
            // 
            this.BatasBawah.HeaderText = "Bawah";
            this.BatasBawah.MinimumWidth = 6;
            this.BatasBawah.Name = "BatasBawah";
            this.BatasBawah.ReadOnly = true;
            this.BatasBawah.Width = 125;
            // 
            // BatasAtas
            // 
            this.BatasAtas.HeaderText = "Atas";
            this.BatasAtas.MinimumWidth = 6;
            this.BatasAtas.Name = "BatasAtas";
            this.BatasAtas.ReadOnly = true;
            this.BatasAtas.Width = 125;
            // 
            // Frekuensi
            // 
            this.Frekuensi.HeaderText = "Frekuensi";
            this.Frekuensi.MinimumWidth = 6;
            this.Frekuensi.Name = "Frekuensi";
            this.Frekuensi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Frekuensi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Frekuensi.Width = 125;
            // 
            // Kumulative
            // 
            this.Kumulative.HeaderText = "F.Kumulatif";
            this.Kumulative.MinimumWidth = 6;
            this.Kumulative.Name = "Kumulative";
            this.Kumulative.ReadOnly = true;
            this.Kumulative.Width = 125;
            // 
            // Relative
            // 
            this.Relative.HeaderText = "F.Relatif";
            this.Relative.MinimumWidth = 6;
            this.Relative.Name = "Relative";
            this.Relative.ReadOnly = true;
            this.Relative.Width = 125;
            // 
            // Mid
            // 
            this.Mid.HeaderText = "Mid";
            this.Mid.MinimumWidth = 6;
            this.Mid.Name = "Mid";
            this.Mid.ReadOnly = true;
            this.Mid.Width = 125;
            // 
            // FrekMid
            // 
            this.FrekMid.HeaderText = "Frek * Mid";
            this.FrekMid.MinimumWidth = 6;
            this.FrekMid.Name = "FrekMid";
            this.FrekMid.ReadOnly = true;
            this.FrekMid.Width = 125;
            // 
            // FormStatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 570);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewStat);
            this.Name = "FormStatistik";
            this.Text = "FormStatistik";
            this.Load += new System.EventHandler(this.FormStatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStat;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatasBawah;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatasAtas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frekuensi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kumulative;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relative;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrekMid;
    }
}