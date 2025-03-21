using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> timeZones = new Dictionary<string, int>(); // Saat dilimi ve farklarını tutar
        private DateTime currentTime;

        public Form1()
        {
            InitializeComponent();
            InitializeClock();
        }

        private void InitializeClock()
        {
            timer1.Interval = 1000; // 1 saniyede bir çalışacak
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
            dtpTime.ValueChanged += DtpTime_ValueChanged;

            currentTime = DateTime.Now;
            UpdateClockDisplay();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentTime = currentTime.AddSeconds(1);
            UpdateClockDisplay();
        }

        private void UpdateClockDisplay()
        {
            lblClock.Text = currentTime.ToString("HH:mm:ss");

            // 08:00 - 20:00 arasında kullanıcı seçtiği renk, diğer zamanlarda siyah
            if (currentTime.Hour >= 8 && currentTime.Hour < 20)
            {
                lblClock.ForeColor = lblClock.Tag != null ? (Color)lblClock.Tag : Color.Black;
            }
            else
            {
                lblClock.ForeColor = Color.Black;
            }
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblClock.Tag = colorDialog1.Color; // Renk bilgisini sakla
                UpdateClockDisplay();
            }
        }

        private void btnAddTimeZone_Click(object sender, EventArgs e)
        {
            string zoneName = txtTimeZoneName.Text.Trim();
            int timeDiff = (int)nudTimeDiff.Value;


            if (!string.IsNullOrWhiteSpace(zoneName) && !timeZones.ContainsKey(zoneName))
            {
                timeZones.Add(zoneName, timeDiff);
                clbTimeZones.Items.Add($"{zoneName} (UTC{(timeDiff >= 0 ? "+" : "")}{timeDiff})");
                cmbTimeZones.Items.Add(zoneName);

                txtTimeZoneName.Clear();
                nudTimeDiff.Value = 0;
            }

            else
            {
                MessageBox.Show("Geçerli bir saat dilimi girin veya saat dilimi zaten eklenmiş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTimeZone_Click(object sender, EventArgs e)
        {
            if (clbTimeZones.CheckedItems.Count != 1)
            {
                MessageBox.Show("Lütfen yalnızca bir saat dilimi seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }

            if (clbTimeZones.SelectedItems.Count == 1)
            {
                string selectedItem = clbTimeZones.SelectedItem.ToString();
                string zoneName = selectedItem.Split('(')[0].Trim();
                int newTimeDiff = (int)nudTimeDiff.Value;

                if (timeZones.ContainsKey(zoneName))
                {
                    timeZones[zoneName] = newTimeDiff;

                    int index = clbTimeZones.SelectedIndex;
                    clbTimeZones.Items[index] = $"{zoneName} (UTC{(newTimeDiff >= 0 ? "+" : "")}{newTimeDiff})";
                }
            }
        }

        private void btnDeleteTimeZone_Click(object sender, EventArgs e)
        {
            List<string> selectedZones = clbTimeZones.CheckedItems.Cast<string>().ToList();

            foreach (var item in selectedZones)
            {
                string zoneName = item.Split('(')[0].Trim();
                timeZones.Remove(zoneName);
                clbTimeZones.Items.Remove(item);
                cmbTimeZones.Items.Remove(zoneName);
            }
        }

        private void cmbTimeZones_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTimeZones.SelectedItem != null)
            {
                string selectedZone = cmbTimeZones.SelectedItem.ToString();
                if (timeZones.ContainsKey(selectedZone))
                {
                    DateTime updatedTime = DateTime.UtcNow.AddHours(timeZones[selectedZone]);
                    currentTime = updatedTime;
                    UpdateClockDisplay();

                    // Yeni tarih bilgisini güncelle
                    lblDate.Text = "Tarih: " + updatedTime.ToString("dd MMMM yyyy");
                }
            }
        }

        private void DtpTime_ValueChanged(object sender, EventArgs e)
        {
            currentTime = dtpTime.Value;
            UpdateClockDisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudTimeDiff.Minimum = -12; 
            nudTimeDiff.Maximum = 14;  

            nudTimeDiff.ReadOnly = true; 

            nudTimeDiff.Controls[0].KeyPress += (s, ev) => ev.Handled = true;

            lblDate.Text = "Tarih: " + DateTime.Now.ToString("dd MMMM yyyy");
        }
       
    }
}
