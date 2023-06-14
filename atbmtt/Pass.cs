using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace atbmtt
{
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }
        private Form1 fm; // tạo biến để lưu formmain
        public Pass(Form1 f) // tạo tham số kiểu formmain cho hàm tạo
        {
            InitializeComponent();
            fm = f; // gán formmain được truyền vào cho biến fm
        }

        private void pass_Load(object sender, EventArgs e)
        {
            PassWork.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public delegate void TruyenPassword(string txt);
        public TruyenPassword truyen;
        private void button1_Click(object sender, EventArgs e)
        {
            string password = PassWork.Text; // Lấy pass từ textbox
             // Kiểm tra xem password có rỗng không
            if (password.Length > 0)
            {
                if (truyen != null)
                {
                    truyen(password);
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
                PassWork.PasswordChar = '\0';
            }
            else
            {
                // Nếu checkbox không được tích, đặt thuộc tính PasswordChar của textbox là '*' để ẩn các ký tự
                PassWork.PasswordChar = '*';
            }
        }
    }
}
