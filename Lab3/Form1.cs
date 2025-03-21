using System;
using System.Drawing;
using System.Windows.Forms;

namespace week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // GroupBox ekle
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Encryption System";
            groupBox.Location = new Point(30, 10); 
            groupBox.Size = new Size(500, 400); 

            
            txtPassword.UseSystemPasswordChar = true;
            lblShift.Visible = false;
            txtShift.Visible = false;

            // GroupBox elemanları
            groupBox.Controls.Add(txtPassword);
            groupBox.Controls.Add(lblShift);
            groupBox.Controls.Add(txtShift); 
            groupBox.Controls.Add(radioButton1); 
            groupBox.Controls.Add(radioButton2); 
            groupBox.Controls.Add(btnEncrypt); 
            groupBox.Controls.Add(lblMessage); 
            groupBox.Controls.Add(lblCipher); 

            // Forma GroupBoxı ekle
            Controls.Add(groupBox);

           
            txtShift.Visible = false;
            lblShift.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtShift.Visible = radioButton1.Checked;
            lblShift.Visible = radioButton1.Checked;
        }

        public static void Encipher(char[] input, int key, ref bool success, Label successLabel, out string encryptedMessage)
        {
            encryptedMessage = string.Empty;

            if (input.Length == 0)
            {
                success = false;
                successLabel.Text = "Input is empty";
                return;
            }

            key = key % 26; // Harfler için kaydırma

            foreach (char ch in input)
            {
                if (char.IsLetter(ch)) // Harfse şifrele
                {
                    encryptedMessage += Cipher(ch, key);
                }
                else if (char.IsDigit(ch)) // Rakam ise toplama yap
                {
                    encryptedMessage += ShiftNumber(ch, key);
                }
                else // Özel karakterse olduğu gibi bırak
                {
                    encryptedMessage += ch;
                }
            }

            success = true;
            successLabel.Text = "Success";
        }

        public static char Cipher(char ch, int key)
        {
            if (char.IsLetter(ch))
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((((ch - d + key) % 26 + 26) % 26) + d);// mod içine aldık
            }
            return ch;
        }

        public static string ShiftNumber(char num, int key)
        {
            int digit = num - '0';
            int newDigit = digit + key;
            return newDigit.ToString(); // Yeni rakamı string olarak döndür
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            int shift = 1;

            bool success = false;
            string encryptedMessage;

            lblMessage.Visible = true;

            if (radioButton1.Checked) // Caesar Cipher seçildiyse
            {
                if (int.TryParse(txtShift.Text, out shift))
                {
                    // Kullanıcı geçerli bir sayı girdiyse devam et
                }
                else
                {
                    lblMessage.BackColor = Color.Red;
                    lblMessage.Text = "Hata: Geçersiz Kaydırma Kodu.";
                    lblCipher.Text = "";
                    return;
                }
            }
            else if (radioButton2.Checked) // ROT2 seçildiyse
            {
                shift = 2; // Sabit olarak 2 kaydır
            }

            char[] passwordArray = password.ToCharArray();
            Encipher(passwordArray, shift, ref success, lblMessage, out encryptedMessage);

            lblMessage.Visible = true;

            if (success)
            {
                lblMessage.BackColor = Color.Green;
                lblMessage.Text = "Success!";
                lblCipher.Text = "Cipher: " + encryptedMessage;
            }
            else
            {
                lblMessage.BackColor = Color.Red;
                lblMessage.Text = "Hata: Şifreleme Başarısız!";
                lblCipher.Text = "";
            }
        }

        private void txtShift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEncrypt.PerformClick();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtShift.Visible = false;
            lblShift.Visible = false;
        }
    }
}
