namespace CSharp_TinhToanTrenDaySo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSbd = new TextBox();
            txtSkt = new TextBox();
            txtTong = new TextBox();
            txtTich = new TextBox();
            txtTongC = new TextBox();
            txtTongL = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 33);
            label1.TabIndex = 0;
            label1.Text = "Giới hạn của dãy số:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 33);
            label2.TabIndex = 0;
            label2.Text = "Số bắt đầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 9);
            label3.Name = "label3";
            label3.Size = new Size(158, 33);
            label3.TabIndex = 0;
            label3.Text = "Số kết thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(195, 33);
            label4.TabIndex = 0;
            label4.Text = "Tổng các số lẻ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 53);
            label5.Name = "label5";
            label5.Size = new Size(116, 33);
            label5.TabIndex = 0;
            label5.Text = "Kết quả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 133);
            label6.Name = "label6";
            label6.Size = new Size(155, 33);
            label6.TabIndex = 0;
            label6.Text = "Tích các số:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 97);
            label7.Name = "label7";
            label7.Size = new Size(167, 33);
            label7.TabIndex = 0;
            label7.Text = "Tổng các số:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 169);
            label8.Name = "label8";
            label8.Size = new Size(231, 33);
            label8.TabIndex = 0;
            label8.Text = "Tổng các số chẵn:";
            // 
            // txtSbd
            // 
            txtSbd.Location = new Point(433, 6);
            txtSbd.Name = "txtSbd";
            txtSbd.Size = new Size(100, 40);
            txtSbd.TabIndex = 1;
            // 
            // txtSkt
            // 
            txtSkt.Location = new Point(703, 6);
            txtSkt.Name = "txtSkt";
            txtSkt.Size = new Size(100, 40);
            txtSkt.TabIndex = 1;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(254, 94);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(279, 40);
            txtTong.TabIndex = 1;
            // 
            // txtTich
            // 
            txtTich.Location = new Point(254, 130);
            txtTich.Name = "txtTich";
            txtTich.ReadOnly = true;
            txtTich.Size = new Size(279, 40);
            txtTich.TabIndex = 1;
            // 
            // txtTongC
            // 
            txtTongC.Location = new Point(254, 166);
            txtTongC.Name = "txtTongC";
            txtTongC.ReadOnly = true;
            txtTongC.Size = new Size(279, 40);
            txtTongC.TabIndex = 1;
            // 
            // txtTongL
            // 
            txtTongL.Location = new Point(254, 202);
            txtTongL.Name = "txtTongL";
            txtTongL.ReadOnly = true;
            txtTongL.Size = new Size(279, 40);
            txtTongL.TabIndex = 1;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(334, 248);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(120, 40);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0d6d1a1e83c73bbf767436b6a854bab2;
            ClientSize = new Size(808, 539);
            Controls.Add(btnTinh);
            Controls.Add(txtSkt);
            Controls.Add(txtTongL);
            Controls.Add(txtTongC);
            Controls.Add(txtTich);
            Controls.Add(txtTong);
            Controls.Add(txtSbd);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Tính Toán Trên Dãy Số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSbd;
        private TextBox txtSkt;
        private TextBox txtTong;
        private TextBox txtTich;
        private TextBox txtTongC;
        private TextBox txtTongL;
        private Button btnTinh;
    }
}
