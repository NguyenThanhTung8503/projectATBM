namespace atbmtt
{
    partial class passdecryption
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(39, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 23);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(309, 80);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(60, 27);
            this.OK.TabIndex = 2;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(39, 80);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(233, 27);
            this.txtpass.TabIndex = 3;
            // 
            // passdecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 183);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "passdecryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập mật khẩu giải mã";
            this.Load += new System.EventHandler(this.passdecryption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox txtpass;
    }
}