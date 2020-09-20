namespace Statistic_Calculator
{
    partial class FormData
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRendah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTinggi = new System.Windows.Forms.TextBox();
            this.textBoxJumlahData = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxTeliti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai Terendah :";
            // 
            // textBoxRendah
            // 
            this.textBoxRendah.Location = new System.Drawing.Point(219, 30);
            this.textBoxRendah.Name = "textBoxRendah";
            this.textBoxRendah.Size = new System.Drawing.Size(169, 22);
            this.textBoxRendah.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai Tertinggi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jumlah Data :";
            // 
            // textBoxTinggi
            // 
            this.textBoxTinggi.Location = new System.Drawing.Point(219, 73);
            this.textBoxTinggi.Name = "textBoxTinggi";
            this.textBoxTinggi.Size = new System.Drawing.Size(169, 22);
            this.textBoxTinggi.TabIndex = 3;
            // 
            // textBoxJumlahData
            // 
            this.textBoxJumlahData.Location = new System.Drawing.Point(219, 155);
            this.textBoxJumlahData.Name = "textBoxJumlahData";
            this.textBoxJumlahData.Size = new System.Drawing.Size(169, 22);
            this.textBoxJumlahData.TabIndex = 7;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(9, 211);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(427, 79);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxTeliti
            // 
            this.textBoxTeliti.Location = new System.Drawing.Point(219, 113);
            this.textBoxTeliti.Name = "textBoxTeliti";
            this.textBoxTeliti.Size = new System.Drawing.Size(169, 22);
            this.textBoxTeliti.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ketelitian :";
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 302);
            this.Controls.Add(this.textBoxTeliti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxJumlahData);
            this.Controls.Add(this.textBoxTinggi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRendah);
            this.Controls.Add(this.label1);
            this.Name = "FormData";
            this.Text = "FormData";
            this.Load += new System.EventHandler(this.FormData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRendah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTinggi;
        private System.Windows.Forms.TextBox textBoxJumlahData;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxTeliti;
        private System.Windows.Forms.Label label4;
    }
}