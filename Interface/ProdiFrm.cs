using SIREMA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREMA.Interface
{
    public partial class ProdiFrm : Form
    {
        private Jurusan jurusan = new Jurusan();
        private Prodi prodi = new Prodi();

        public ProdiFrm()
        {
            InitializeComponent();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (!prodi.isExist(kodeTxt.Text))
            {
                prodi.Kode_Prodi = kodeTxt.Text;
                prodi.Nama_Prodi = prodiTxt.Text;
                prodi.Nama_Jurusan = jurusanCmb.Text;

                if (prodi.store() > 0)
                {
                    MessageBox.Show("Data Berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kodeTxt.Text = "";
                    prodiTxt.Text = "";
                    jurusanDgv.DataSource = prodi.showAll();
                    kodeTxt.Text = prodi.createCode();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Apakah Data akan diubah?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prodi.Kode_Prodi = kodeTxt.Text;
                    prodi.Nama_Prodi = prodiTxt.Text;
                    prodi.Nama_Jurusan = jurusanCmb.Text;

                    if (prodi.update(kodeTxt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil diubah.",
                            "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kodeTxt.Text = "";
                        prodiTxt.Text = "";
                        jurusanDgv.DataSource = prodi.showAll();
                        kodeTxt.Text = prodi.createCode();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah data.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void combo()
        {
            jurusanCmb.Items.Clear();
            DataTable jurusandata = prodi.isicombo();
            jurusanCmb.DataSource = jurusandata;

            jurusanCmb.DisplayMember = "nama_jurusan";
            jurusanCmb.ValueMember = "nama_jurusan";
        }

        private void ProdiFrm_Load(object sender, EventArgs e)
        {
            jurusanDgv.DataSource = prodi.showAll();
            kodeTxt.Text = prodi.createCode();
            combo();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (prodi.isExist(kodeTxt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus>",
                    "KONFIRMAASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (prodi.delete(kodeTxt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        kodeTxt.Text = "";
                        prodiTxt.Text = "";
                        jurusanDgv.DataSource = prodi.showAll();
                        kodeTxt.Text = prodi.createCode();
                    }
                }
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                jurusanDgv.DataSource = prodi.showAll();
            }
            else
            {
                jurusanDgv.DataSource = prodi.search(searchTxt.Text);
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            kodeTxt.Text = prodi.createCode();
            prodiTxt.Text = "";
        }

        private void tutupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void jurusanDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                kodeTxt.Text = jurusanDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                prodiTxt.Text = jurusanDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                jurusanCmb.Text = jurusanDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}