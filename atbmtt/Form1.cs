using AES_File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atbmtt
{
    
    public partial class Form1 : Form
    {
        string password;
        string password1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Vui lòng nhập đường dẫn!";
            textBox1.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            //openFileDialog.Filter = "Word|*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0) { textBox1.Text = files[0]; }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Vui lòng nhập đường dẫn!")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Vui lòng nhập đường dẫn!";
                textBox1.ForeColor = Color.Gray;
            }
        }

        //Phương thức nhận dữ liệu từ form Pass
        public void ReceiveData(string data)
        {
            //Lưu dữ liệu vào biến passwork
            password = data;
        }

        private void button2_Click(object sender, EventArgs e)//Sự kiện mã hóa
        {
            // Lấy đường dẫn từ textbox
            string inputFile = textBox1.Text;

            // Kiểm tra xem đường dẫn có rỗng không
            if (inputFile=="Vui lòng nhập đường dẫn!")
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Hãy nhập đường dẫn file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Tiếp tục các bước mã hóa
                //Tạo form con
                Pass child = new Pass();
                //Gán delegate với phương thức nhận dữ liệu
                child.truyen = ReceiveData;// Mật khẩu để mã hóa
                //Hiển thị form con
                child.ShowDialog();
                AES aes = new AES(); // Tạo đối tượng AES
                aes.FileEncrypt(inputFile, password); // Gọi phương thức FileEncrypt
                // Hiển thị thông báo cho người dùng
                MessageBox.Show("Tệp tin đã được mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Tạo đường dẫn để lưu tệp tin đã mã hóa// string outputFile = Path.GetDirectoryName(inputFile);
                string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile) + ".aes");
                 // Ghi password vào outputFile
                using (StreamWriter sw = new StreamWriter(outputFile, true)) // Mở tệp tin ở chế độ Append
                {
                    sw.WriteLine(password); // Ghi password vào dòng cuối cùng của tệp tin
                    sw.Close(); // Đóng tệp tin
                }
                // Hiển thị vị trí của tệp tin đã mã hóa
                MessageBox.Show("Tệp tin đã được lưu tại: " + outputFile, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //Phương thức nhận dữ liệu từ form passdexryption
        public void ReceiveData1(string data1)
        {
            //Lưu dữ liệu vào biến passwork1
            password1 = data1;
        }
        
        private void button3_Click(object sender, EventArgs e)//Sự kiện giải mã
        {
            string inputFile = textBox1.Text; // Lấy đường dẫn từ textbox
            // Kiểm tra xem đường dẫn có rỗng không
            if (inputFile == "Vui lòng nhập đường dẫn!")
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Hãy nhập đường dẫn file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Giải mã tệp tin bằng lớp AES
                //Tạo form con
                passdecryption con = new passdecryption();

                //Gán delegate với phương thức nhận dữ liệu
                con.TruyenPass = ReceiveData1;// Mật khẩu để mã hóa

                //Hiển thị form con
                con.ShowDialog();
                // Mật khẩu để giải mã
                // Đọc password từ inputFile
                using (StreamReader sr = new StreamReader(inputFile)) // Mở tệp tin ở chế độ Read
                {
                    string line; // Biến lưu trữ mỗi dòng đọc được
                    string passwordinput = ""; // Biến lưu trữ password
                    while ((line = sr.ReadLine()) != null) // Đọc từng dòng cho đến khi hết tệp tin
                    {
                        passwordinput = line; // Gán password bằng dòng cuối cùng của tệp tin
                    }
                    sr.Close(); // Đóng tệp tin
                }

                // So sánh password với một biến khác
                string anotherPassword = password1; // Biến khác để so sánh
                if (password == anotherPassword) // Nếu hai biến bằng nhau
                {
                    AES aes = new AES(); // Tạo đối tượng AES

                    // Tạo đường dẫn để lưu tệp tin đã giải mã
                    string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile) + "_decrypted.docx");

                    // Gọi phương thức FileDecrypt
                    aes.FileDecrypt(inputFile, outputFile, password);

                    // Hiển thị thông báo cho người dùng
                    MessageBox.Show("Tệp tin đã được giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hiển thị vị trí của tệp tin đã giải mã
                    MessageBox.Show("Tệp tin đã được lưu tại: " + outputFile, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Nếu hai biến khác nhau
                {
                    MessageBox.Show("Sai mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
    }
}

namespace AES_File
{
    public class AES
    {
        // Sử dụng hằng số để định nghĩa kích thước khóa, khối và salt
        private const int KeySize = 256; // Độ dài khóa AES (tính bằng bit)
        private const int BlockSize = 128; // Độ dài khối AES (tính bằng bit)
        private const int SaltSize = 32; // Độ dài salt (tính bằng byte)

        // Phương thức sinh salt ngẫu nhiên
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[SaltSize];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(data); // Sinh salt ngẫu nhiên
            }

            return data;
        }

        // Phương thức mã hóa file
        public void FileEncrypt(string inputFile, string password)
        {
            byte[] salt = GenerateRandomSalt(); // Sinh salt ngẫu nhiên

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create); // Tạo file output

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password); // Chuyển đổi mật khẩu sang mảng byte

            RijndaelManaged AES = new RijndaelManaged(); // Tạo đối tượng AES
            AES.KeySize = KeySize; // Thiết lập độ dài khóa
            AES.BlockSize = BlockSize; // Thiết lập độ dài khối
            AES.Padding = PaddingMode.PKCS7; // Thiết lập chế độ padding

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000); // Tạo khóa từ mật khẩu và salt
            AES.Key = key.GetBytes(KeySize / 8); // Lấy khóa bí mật
            AES.IV = key.GetBytes(BlockSize / 8); // Lấy vector khởi tạo

            AES.Mode = CipherMode.CFB; // Thiết lập chế độ mã hóa

            fsCrypt.Write(salt, 0, salt.Length); // Ghi salt vào file output

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write); // Tạo luồng mã hóa

            FileStream fsIn = new FileStream(inputFile, FileMode.Open); // Mở file input

            byte[] buffer = new byte[1048576]; // Tạo bộ đệm để đọc và ghi file
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0) // Đọc file input cho đến khi hết
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read); // Ghi file output đã mã hóa
                }

                fsIn.Close(); // Đóng file input
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close(); // Đóng luồng mã hóa
                fsCrypt.Close(); // Đóng file output
                key.Dispose(); // Xóa khóa khỏi bộ nhớ
                AES.Clear(); // Xóa các thông số của AES khỏi bộ nhớ
            }
        }

        // Phương thức giải mã file
        public void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password); // Chuyển đổi mật khẩu sang mảng byte
            byte[] salt = new byte[SaltSize]; // Tạo mảng byte để lưu salt

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open); // Mở file input
            fsCrypt.Read(salt, 0, salt.Length); // Đọc salt từ file input

            RijndaelManaged AES = new RijndaelManaged(); // Tạo đối tượng AES
            AES.KeySize = KeySize; // Thiết lập độ dài khóa
            AES.BlockSize = BlockSize; // Thiết lập độ dài khối

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000); // Tạo khóa từ mật khẩu và salt
            AES.Key = key.GetBytes(KeySize / 8); // Lấy khóa bí mật
            AES.IV = key.GetBytes(BlockSize / 8); // Lấy vector khởi tạo

            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }

                fsOut.Close();//đóng luồng dữ liệu fsout và giải phóng tài nguyên liên quan
                key.Dispose();// Xóa khóa khỏi bộ nhớ
                AES.Clear();// Xóa các thông số của AES khỏi bộ nhớ

                File.Delete(inputFile);
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsCrypt.Close();
            }
        }
    }
}