using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIREMA.Model;

namespace SIREMA
{
    public partial class Form1 : Form
    {
        private Jurusan jurusan = new Jurusan();

        public Form1()
        {
            InitializeComponent();
        }

        private void cekBtn_Click(object sender, EventArgs e)
        {
            if (!jurusan.isExist(kodeTxt.Text))
            {
                jurusan.Kode_urusan = kodeTxt.Text;
                jurusan.Nama_jurusan = namaTxt.Text;

                if (jurusan.store() > 0)
                {
                    MessageBox.Show("Data Berhasil Disimpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kodeTxt.Text = "";
                    namaTxt.Text = "";
                    jurusanDgv.DataSource = jurusan.showAll();
                }
                else
                {
                    MessageBox.Show("Data Gagal Disimpan", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    kodeTxt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Data Sudah Ada", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            jurusan.Nama_jurusan = namaTxt.Text;

            if (jurusan.update(kodeTxt.Text) > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengubah data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Data Berhasil Diubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kodeTxt.Text = "";
                    namaTxt.Text = "";
                    jurusanDgv.DataSource = jurusan.showAll();
                }
            }
            else
            {
                MessageBox.Show("Data Gagal Diubah", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                kodeTxt.Focus();
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (jurusan.delete(kodeTxt.Text) > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Data Berhasil Dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kodeTxt.Text = "";
                    namaTxt.Text = "";
                    jurusanDgv.DataSource = jurusan.showAll();
                }
            }
            else
            {
                MessageBox.Show("Data Gagal Dihapus", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                kodeTxt.Focus();
            }
        }

        private void cariBtn_Click(object sender, EventArgs e)
        {
            string keyword = namaTxt.Text;
            DataTable hasilPencarian = jurusan.search(keyword);

            if (hasilPencarian != null && hasilPencarian.Rows.Count > 0)
            {
                jurusanDgv.DataSource = hasilPencarian;
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jurusanDgv.DataSource = jurusan.showAll();
            stripTable(jurusanDgv);
            kodeTxt.Text = jurusan.createCode();
        }

        private void clearCode()
        {
            kodeTxt.Text = jurusan.createCode();
            namaTxt.Text = "";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearCode();
        }

        private void jurusanDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = jurusanDgv.Rows[e.RowIndex];
                kodeTxt.Text = row.Cells[0].Value.ToString();
                namaTxt.Text = row.Cells[1].Value.ToString();
                namaTxt.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jurusanDgv.DataSource = jurusan.showAll();
            kodeTxt.Text = jurusan.createCode();
            namaTxt.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                cekBtn.PerformClick();
            }
        }

        private void stripTable(DataGridView grd)
        {
            foreach (DataGridViewRow row in grd.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Index % 2 == 0)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                jurusanDgv.DataSource = jurusan.showAll();
            }
            else
            {
                jurusanDgv.DataSource = jurusan.search(searchTxt.Text);
            }
        }

        private void kodeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}