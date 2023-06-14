namespace atbmtt
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaHoa = new System.Windows.Forms.Button();
            this.GiaiMa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(28, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(341, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter_1);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn file cần mã hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(157, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã hóa AES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MaHoa
            // 
            this.MaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHoa.Location = new System.Drawing.Point(128, 176);
            this.MaHoa.Name = "MaHoa";
            this.MaHoa.Size = new System.Drawing.Size(75, 31);
            this.MaHoa.TabIndex = 6;
            this.MaHoa.Text = "Mã hóa";
            this.MaHoa.UseVisualStyleBackColor = true;
            this.MaHoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // GiaiMa
            // 
            this.GiaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaiMa.Location = new System.Drawing.Point(284, 177);
            this.GiaiMa.Name = "GiaiMa";
            this.GiaiMa.Size = new System.Drawing.Size(75, 31);
            this.GiaiMa.TabIndex = 7;
            this.GiaiMa.Text = "Giải mã";
            this.GiaiMa.UseVisualStyleBackColor = true;
            this.GiaiMa.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 243);
            this.Controls.Add(this.GiaiMa);
            this.Controls.Add(this.MaHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mã hóa file AES-256bit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MaHoa;
        private System.Windows.Forms.Button GiaiMa;
    }
}

