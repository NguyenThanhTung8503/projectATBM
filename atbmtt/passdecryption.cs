using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atbmtt
{
    public partial class passdecryption : Form
    {
        public passdecryption()
        {
            InitializeComponent();
        }
        private Form1 frm; // tạo biến để lưu formmain
        public passdecryption(Form1 fm) // tạo tham số kiểu formmain cho hàm tạo
        {
            InitializeComponent();
            frm = fm; // gán formmain được truyền vào cho biến fm
        }
        private void passdecryption_Load(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }
        public delegate void TruyenPasswordMH(string txt);
        public TruyenPasswordMH TruyenPass;
        private void button1_Click(object sender, EventArgs e)
        {
            string passwordMH = txtpass.Text; // Lấy pass từ textbox
                                             // Kiểm tra xem password có rỗng không
            if (passwordMH.Length > 0)
            {
                if (TruyenPass != null)
                {
                    TruyenPass(passwordMH);
                }
                this.Close();
            }
            else
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Hãy nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của checkbox
            if (checkBox1.Checked)
            {
                // Nếu checkbox được tích, đặt thuộc tính PasswordChar của textbox là '\0' để hiển thị các ký tự
                txtpass.PasswordChar = '\0';
            }
            else
            {
                // Nếu checkbox không được tích, đặt thuộc tính PasswordChar của textbox là '*' để ẩn các ký tự
                txtpass.PasswordChar = '*';
            }
        }
    }

}
