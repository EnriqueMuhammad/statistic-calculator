namespace Statistic_Calculator
{
    partial class FormPilihan
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
            this.buttonNoData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNoData
            // 
            this.buttonNoData.Location = new System.Drawing.Point(12, 12);
            this.buttonNoData.Name = "buttonNoData";
            this.buttonNoData.Size = new System.Drawing.Size(427, 44);
            this.buttonNoData.TabIndex = 0;
            this.buttonNoData.Text = "Data Tidak Diketahui";
            this.buttonNoData.UseVisualStyleBackColor = true;
            this.buttonNoData.Click += new System.EventHandler(this.buttonNoData_Click);
            // 
            // FormPilihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.buttonNoData);
            this.Name = "FormPilihan";
            this.Text = "FormPilihan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNoData;
    }
}