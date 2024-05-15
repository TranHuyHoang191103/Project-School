namespace GUI
{
    partial class ChiTietHocPhanTheoNganh
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
            this.dgvHP = new System.Windows.Forms.DataGridView();
            this.cbBatBuoc = new System.Windows.Forms.ComboBox();
            this.cbMaHPTN = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaHP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHP
            // 
            this.dgvHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHP.Location = new System.Drawing.Point(45, 194);
            this.dgvHP.Name = "dgvHP";
            this.dgvHP.Size = new System.Drawing.Size(711, 243);
            this.dgvHP.TabIndex = 23;
            // 
            // cbBatBuoc
            // 
            this.cbBatBuoc.FormattingEnabled = true;
            this.cbBatBuoc.Location = new System.Drawing.Point(181, 126);
            this.cbBatBuoc.Name = "cbBatBuoc";
            this.cbBatBuoc.Size = new System.Drawing.Size(121, 21);
            this.cbBatBuoc.TabIndex = 22;
            // 
            // cbMaHPTN
            // 
            this.cbMaHPTN.FormattingEnabled = true;
            this.cbMaHPTN.Location = new System.Drawing.Point(183, 69);
            this.cbMaHPTN.Name = "cbMaHPTN";
            this.cbMaHPTN.Size = new System.Drawing.Size(121, 21);
            this.cbMaHPTN.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bắt buộc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã học phần theo ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // cbMaHP
            // 
            this.cbMaHP.FormattingEnabled = true;
            this.cbMaHP.Location = new System.Drawing.Point(181, 99);
            this.cbMaHP.Name = "cbMaHP";
            this.cbMaHP.Size = new System.Drawing.Size(121, 21);
            this.cbMaHP.TabIndex = 24;
            // 
            // ChiTietHocPhanTheoNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMaHP);
            this.Controls.Add(this.dgvHP);
            this.Controls.Add(this.cbBatBuoc);
            this.Controls.Add(this.cbMaHPTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietHocPhanTheoNganh";
            this.Text = "ChiTietHocPhanTheoNganh";
            this.Load += new System.EventHandler(this.ChiTietHocPhanTheoNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHP;
        private System.Windows.Forms.ComboBox cbBatBuoc;
        private System.Windows.Forms.ComboBox cbMaHPTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaHP;
    }
}