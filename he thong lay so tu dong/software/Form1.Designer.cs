namespace test
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNgatketnoi = new System.Windows.Forms.Button();
            this.btnKetnoi = new System.Windows.Forms.Button();
            this.cmbTencom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_service1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_service2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.none = new System.Windows.Forms.Label();
            this.txt_ticket = new System.Windows.Forms.TextBox();
            this.receive_char = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNgatketnoi);
            this.groupBox1.Controls.Add(this.btnKetnoi);
            this.groupBox1.Controls.Add(this.cmbTencom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quan ly Com";
            // 
            // btnNgatketnoi
            // 
            this.btnNgatketnoi.Location = new System.Drawing.Point(191, 92);
            this.btnNgatketnoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnNgatketnoi.Name = "btnNgatketnoi";
            this.btnNgatketnoi.Size = new System.Drawing.Size(116, 39);
            this.btnNgatketnoi.TabIndex = 3;
            this.btnNgatketnoi.Text = "Ngat ket noi";
            this.btnNgatketnoi.UseVisualStyleBackColor = true;
            this.btnNgatketnoi.Click += new System.EventHandler(this.btnNgatketnoi_Click);
            // 
            // btnKetnoi
            // 
            this.btnKetnoi.Location = new System.Drawing.Point(40, 92);
            this.btnKetnoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnKetnoi.Name = "btnKetnoi";
            this.btnKetnoi.Size = new System.Drawing.Size(116, 39);
            this.btnKetnoi.TabIndex = 2;
            this.btnKetnoi.Text = "Ket noi";
            this.btnKetnoi.UseVisualStyleBackColor = true;
            this.btnKetnoi.Click += new System.EventHandler(this.btnKetnoi_Click);
            // 
            // cmbTencom
            // 
            this.cmbTencom.FormattingEnabled = true;
            this.cmbTencom.Items.AddRange(new object[] {
            "COM5"});
            this.cmbTencom.Location = new System.Drawing.Point(191, 39);
            this.cmbTencom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTencom.Name = "cmbTencom";
            this.cmbTencom.Size = new System.Drawing.Size(160, 28);
            this.cmbTencom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten cong  Com:";
            // 
            // txt_service1
            // 
            this.txt_service1.Location = new System.Drawing.Point(40, 246);
            this.txt_service1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_service1.MaxLength = 4;
            this.txt_service1.MinimumSize = new System.Drawing.Size(4, 4);
            this.txt_service1.Multiline = true;
            this.txt_service1.Name = "txt_service1";
            this.txt_service1.Size = new System.Drawing.Size(139, 32);
            this.txt_service1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "SERVICE 1";
            // 
            // txt_service2
            // 
            this.txt_service2.Location = new System.Drawing.Point(247, 246);
            this.txt_service2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_service2.MaxLength = 4;
            this.txt_service2.Multiline = true;
            this.txt_service2.Name = "txt_service2";
            this.txt_service2.Size = new System.Drawing.Size(139, 32);
            this.txt_service2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "SERVICE 2";
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.none.Location = new System.Drawing.Point(60, 315);
            this.none.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(76, 24);
            this.none.TabIndex = 0;
            this.none.Text = "TICKET";
            // 
            // txt_ticket
            // 
            this.txt_ticket.Location = new System.Drawing.Point(40, 341);
            this.txt_ticket.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ticket.Multiline = true;
            this.txt_ticket.Name = "txt_ticket";
            this.txt_ticket.Size = new System.Drawing.Size(139, 32);
            this.txt_ticket.TabIndex = 2;
            // 
            // receive_char
            // 
            this.receive_char.Location = new System.Drawing.Point(247, 341);
            this.receive_char.Margin = new System.Windows.Forms.Padding(4);
            this.receive_char.Multiline = true;
            this.receive_char.Name = "receive_char";
            this.receive_char.Size = new System.Drawing.Size(139, 32);
            this.receive_char.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(286, 295);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 28);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "button1";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 409);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_service2);
            this.Controls.Add(this.receive_char);
            this.Controls.Add(this.txt_ticket);
            this.Controls.Add(this.txt_service1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.none);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNgatketnoi;
        private System.Windows.Forms.Button btnKetnoi;
        private System.Windows.Forms.ComboBox cmbTencom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_service1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_service2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label none;
        private System.Windows.Forms.TextBox txt_ticket;
        private System.Windows.Forms.TextBox receive_char;
        private System.Windows.Forms.Button btn_send;
    }
}

