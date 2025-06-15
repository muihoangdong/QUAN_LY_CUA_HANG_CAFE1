using QUAN_LY_CUA_HANG_CAFE1.Login;
using QUAN_LY_CUA_HANG_CAFE1.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_CUA_HANG_CAFE1
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Nhập tên đăng nhập")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Nhập tên đăng nhập";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Nhập mật khẩu")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Nhập mật khẩu";
                textBox2.ForeColor = Color.Gray;
                textBox2.UseSystemPasswordChar = false;
            }
        }
        private void dangky_btn_MouseClick(object sender, MouseEventArgs e)
        {
            dangky dk = new dangky();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }

        private void dangnhap_btn_MouseClick(object sender, MouseEventArgs e)
        {
            trangchu tc = new trangchu();
            this.Hide();
            tc.ShowDialog();
            this.Close();
        }

        private void quenmatkhau_btn_MouseClick(object sender, MouseEventArgs e)
        {
            quenmatkhau qmk = new quenmatkhau();
            this.Hide();
            qmk.ShowDialog();
            this.Show();
        }

        private void thoat_btn_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát không?",
        "Thông báo",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
