using System;                       // namespace bawaan untuk fitur dasar C#
using System.Collections.Generic;   // digunakan agar bisa memakai List<T>
using System.Text;                  // digunakan untuk StringBuilder
using System.Windows.Forms;         // library utama untuk aplikasi Windows Form

namespace UlanganHarian              // namespace project (namanya UlanganHarian)
{
    public partial class Form1 : Form   // deklarasi class Form1 yang mewarisi dari Form (Windows Form)
    {
        public Form1()                  // constructor Form1
        {
            InitializeComponent();      // inisialisasi semua komponen yang dibuat di Designer (form UI)
        }

        // --- Submit: tampilkan hasil dari input pengguna ---
        private void buttonSubmit_Click(object sender, EventArgs e)   // event handler saat tombol "Submit" diklik
        {
            lblHasil.Visible = true;    // menampilkan label hasil agar terlihat di form

            StringBuilder sb = new StringBuilder();   // membuat objek StringBuilder untuk menyusun teks hasil

            // mengambil teks dari setiap TextBox dan menambahkannya ke hasil
            sb.AppendLine("Nama : " + txtNama.Text);
            sb.AppendLine("Kelas : " + txtKelas.Text);
            sb.AppendLine("Absen : " + txtAbsen.Text);
            sb.AppendLine("NIS : " + txtNIS.Text);
            sb.AppendLine("Jurusan : " + txtJurusan.Text);
            sb.AppendLine("Alamat : " + txtAlamat.Text);
            sb.AppendLine("Tempat/Tanggal Lahir : " + TTL.Text);  // TTL harus TextBox (bukan Label)

            // bagian untuk menentukan jenis kelamin berdasarkan radio button
            if (rblaki.Checked)
                sb.AppendLine("Jenis Kelamin : Laki-laki");     // kalau RadioButton laki-laki terpilih
            else if (rbcewe.Checked)
                sb.AppendLine("Jenis Kelamin : Perempuan");    // kalau RadioButton perempuan terpilih
            else
                sb.AppendLine("Jenis Kelamin : Belum dipilih"); // kalau belum pilih apa-apa

            // membuat list kosong untuk menampung hobi yang dipilih
            var hobiList = new List<string>();

            // cek setiap checkbox, kalau terpilih tambahkan ke list
            if (cbOlahraga.Checked) hobiList.Add("Olahraga");
            if (cbMenggambar.Checked) hobiList.Add("Menggambar/Design Grafis");
            if (cbMenari.Checked) hobiList.Add("Menari");
            if (cbMemasak.Checked) hobiList.Add("Memasak");
            if (cbGamers.Checked) hobiList.Add("Gamers/Streaming");
            if (cbMembaca.Checked) hobiList.Add("Membaca");

            // kalau ada hobi yang dipilih, gabungkan jadi satu string
            if (hobiList.Count > 0)
                sb.AppendLine("Hobi : " + string.Join(", ", hobiList));
            else
                sb.AppendLine("Hobi : Belum dipilih");   // kalau tidak ada checkbox yang dipilih

            // hasil akhir ditampilkan ke label hasil
            lblHasil.Text = sb.ToString();
        }

        // --- Clear: hanya hapus hasil, bukan input ---
        private void buttonClear_Click(object sender, EventArgs e)   // event handler tombol "Clear"
        {
            lblHasil.Text = string.Empty;   // hapus teks hasil
            lblHasil.Visible = false;       // sembunyikan label hasil
        }

        // --- Exit ---
        private void buttonExit_Click(object sender, EventArgs e)   // event handler tombol "Exit"
        {
            this.Close();   // menutup form (aplikasi)
        }

        // --- Handler kosong (supaya tidak error kalau terhubung dari Designer) ---
        private void textBox1_TextChanged(object sender, EventArgs e) { }   // tidak ada fungsi
        private void cbOlahraga_CheckedChanged(object sender, EventArgs e) { }
        private void cbMenggambar_CheckedChanged(object sender, EventArgs e) { }
        private void cbMenari_CheckedChanged(object sender, EventArgs e) { }
        private void rbanakke1_CheckedChanged(object sender, EventArgs e) { }
        private void txtanak_Click(object sender, EventArgs e) { }
    }
}
