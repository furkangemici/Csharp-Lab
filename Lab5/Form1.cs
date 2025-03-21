using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Ayakkabı modelleri ekleme
            lstShoes.Items.AddRange(new string[] { "Nike Air Max", "Vans", "Puma RS-X", "New Balance 574" ,"Nike Dunk" , "Adidas Superstar" , "Nike Air Jordan" });

            // Şehirleri ekleme
            lstCity.Items.Add("İstanbul");
            lstCity.Items.Add("Eskişehir");
            lstCity.Items.Add("Ankara");
            lstCity.Items.Add("Samsun");

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            // Ad-Soyad ve Telefon Kontrolü
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(mtxtPhone.Text))
            {
                MessageBox.Show("Lütfen müşteri bilgilerini eksiksiz giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mtxtPhone.MaskCompleted)
            {
                MessageBox.Show("Lütfen telefon numarasını eksiksiz giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ayakkabı Seçimi Kontrolü
            if (lstShoes.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ayakkabı modeli seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Numara Seçimi
            var selectedSizes = this.Controls.OfType<CheckBox>().Where(c => c.Checked).Select(c => c.Text).ToList();
            if (!selectedSizes.Any())
            {
                MessageBox.Show("Lütfen ayakkabı numarası seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Şehir ve İlçe Seçimi Kontrolü
            if (lstCity.SelectedItem == null || lstDistrict.SelectedItem == null)
            {
                MessageBox.Show("Lütfen şehir ve ilçe seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Siparişi daha düzenli göstermek için her bilgiyi ayrı satır olarak ekle
            // Seçilen her numara için ayrı sipariş ekleme
            foreach (var size in selectedSizes)
            {
                lstOrders.Items.Add($"Müşteri: {txtFullName.Text}");
                lstOrders.Items.Add($"Telefon: {mtxtPhone.Text}");
                lstOrders.Items.Add($"Ayakkabı: {lstShoes.SelectedItem}");
                lstOrders.Items.Add($"Numara: {size}"); // Tek numara ekleniyor
                lstOrders.Items.Add($"Adres: {lstCity.SelectedItem}, {lstDistrict.SelectedItem}");
                lstOrders.Items.Add($"Tarih: {DateTime.Now}");
                lstOrders.Items.Add("-------------------------");
            }

            MessageBox.Show("Sipariş başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen şehre göre ilçeleri güncelle
            lstDistrict.Items.Clear();
            if (lstCity.SelectedItem.ToString() == "Eskişehir")
            {
                lstDistrict.Items.AddRange(new string[] { "Tepebaşı", "Odunpazarı" , "Sivrihisar" });
            }
            else if (lstCity.SelectedItem.ToString() == "Ankara")
            {
                lstDistrict.Items.AddRange(new string[] { "Çankaya", "Keçiören", "Sincan" });
            }
            else if (lstCity.SelectedItem.ToString() == "Samsun")
            {
                lstDistrict.Items.AddRange(new string[] { "İlkadım", "Atakum", "Bafra" });
            }
            else if (lstCity.SelectedItem.ToString() == "İstanbul")
            {
                lstDistrict.Items.AddRange(new string[] { "Kadıköy", "Üsküdar", "Beşiktaş" });
            }

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harf ve boşluk karakteri kabul et, diğer her şeyi engelle
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtxtPhone.Mask = "000 000 00 00"; // Türkiye telefon formatı
            mtxtPhone.PromptChar = '_'; // Boş kalan alanları _ ile göster
            mtxtPhone.BeepOnError = true; // Yanlış girişte uyarı sesi ver

       
        }

    }
}
