namespace AdminCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lgBtn = new System.Windows.Forms.Button();
            this.adminLbl = new System.Windows.Forms.Label();
            this.usLbl = new System.Windows.Forms.Label();
            this.usTb = new System.Windows.Forms.TextBox();
            this.pwTb = new System.Windows.Forms.TextBox();
            this.pwLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conTxt = new System.Windows.Forms.Label();
            this.recordLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lgBtn
            // 
            this.lgBtn.FlatAppearance.BorderSize = 5;
            this.lgBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgBtn.Location = new System.Drawing.Point(182, 284);
            this.lgBtn.Name = "lgBtn";
            this.lgBtn.Size = new System.Drawing.Size(75, 23);
            this.lgBtn.TabIndex = 0;
            this.lgBtn.Text = "Log In";
            this.lgBtn.UseVisualStyleBackColor = true;
            this.lgBtn.Click += new System.EventHandler(this.lgBtn_Click);
            // 
            // adminLbl
            // 
            this.adminLbl.AutoSize = true;
            this.adminLbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLbl.Location = new System.Drawing.Point(178, 147);
            this.adminLbl.Name = "adminLbl";
            this.adminLbl.Size = new System.Drawing.Size(132, 24);
            this.adminLbl.TabIndex = 1;
            this.adminLbl.Text = "Admin Log In";
            // 
            // usLbl
            // 
            this.usLbl.AutoSize = true;
            this.usLbl.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usLbl.Location = new System.Drawing.Point(12, 187);
            this.usLbl.Name = "usLbl";
            this.usLbl.Size = new System.Drawing.Size(70, 17);
            this.usLbl.TabIndex = 2;
            this.usLbl.Text = "UserName";
            // 
            // usTb
            // 
            this.usTb.Location = new System.Drawing.Point(103, 187);
            this.usTb.Name = "usTb";
            this.usTb.Size = new System.Drawing.Size(311, 20);
            this.usTb.TabIndex = 3;
            this.usTb.TextChanged += new System.EventHandler(this.usTb_TextChanged);
            // 
            // pwTb
            // 
            this.pwTb.Location = new System.Drawing.Point(103, 244);
            this.pwTb.MaxLength = 4;
            this.pwTb.Name = "pwTb";
            this.pwTb.PasswordChar = '*';
            this.pwTb.Size = new System.Drawing.Size(311, 20);
            this.pwTb.TabIndex = 4;
            this.pwTb.TextChanged += new System.EventHandler(this.pwTb_TextChanged);
            this.pwTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwTb_KeyPress);
            // 
            // pwLbl
            // 
            this.pwLbl.AutoSize = true;
            this.pwLbl.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLbl.Location = new System.Drawing.Point(12, 244);
            this.pwLbl.Name = "pwLbl";
            this.pwLbl.Size = new System.Drawing.Size(65, 17);
            this.pwLbl.TabIndex = 5;
            this.pwLbl.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 132);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // conTxt
            // 
            this.conTxt.AutoSize = true;
            this.conTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conTxt.Location = new System.Drawing.Point(12, 292);
            this.conTxt.Name = "conTxt";
            this.conTxt.Size = new System.Drawing.Size(2, 15);
            this.conTxt.TabIndex = 7;
            // 
            // recordLbl
            // 
            this.recordLbl.AutoSize = true;
            this.recordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLbl.ForeColor = System.Drawing.Color.Red;
            this.recordLbl.Location = new System.Drawing.Point(310, 292);
            this.recordLbl.Name = "recordLbl";
            this.recordLbl.Size = new System.Drawing.Size(0, 13);
            this.recordLbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.lgBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(476, 327);
            this.Controls.Add(this.recordLbl);
            this.Controls.Add(this.conTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pwLbl);
            this.Controls.Add(this.pwTb);
            this.Controls.Add(this.usTb);
            this.Controls.Add(this.usLbl);
            this.Controls.Add(this.adminLbl);
            this.Controls.Add(this.lgBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Log In ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lgBtn;
        private System.Windows.Forms.Label adminLbl;
        private System.Windows.Forms.Label usLbl;
        private System.Windows.Forms.TextBox usTb;
        private System.Windows.Forms.TextBox pwTb;
        private System.Windows.Forms.Label pwLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label conTxt;
        private System.Windows.Forms.Label recordLbl;
    }
}

