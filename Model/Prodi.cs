using SIREMA.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREMA.Model
{
    internal class Prodi
    {
        // ATTRIBUTE
        private string kodeProdi;

        private string namaProdi;
        private string namaJurusan;

        // CONNECTION ATTRIBUTE
        private ConnectionCls conn;

        private DataTable temp;
        private string query;

        // CONSTRUCTOR
        public Prodi()
        {
            kodeProdi = "";
            namaProdi = "";
            namaJurusan = "";

            conn = new ConnectionCls();
            temp = new DataTable();
            query = "";
        }

        // PROPERTIES
        public string Kode_Prodi
        {
            set { kodeProdi = value; }
        }

        public string Nama_Prodi
        {
            set { namaProdi = value; }
        }

        public string Nama_Jurusan
        {
            set { namaJurusan = value; }
        }

        public bool isExist(string kode)
        {
            query = "SELECT * FROM prodi WHERE kode_prodi = '" + kode + "'";
            temp = conn.Query(query);

            if (temp.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetKodeJurusan(string nama)
        {
            string kodeJurusan = string.Empty;

            // Query the database to retrieve kode_jurusan based on nama_jurusan
            string query = "SELECT kode_jurusan FROM jurusan WHERE nama_jurusan = '" + namaJurusan + "'";
            DataTable result = conn.Query(query);

            if (result.Rows.Count > 0)
            {
                // Assuming kode_jurusan is in the first column of the result DataTable
                kodeJurusan = result.Rows[0]["kode_jurusan"].ToString();
            }

            return kodeJurusan;
        }

        public int store()
        {
            int result = -1;

            string kodeJurusan = GetKodeJurusan("Perhutanan");

            if (string.IsNullOrEmpty(kodeJurusan))
            {
                throw new Exception("Kode Jurusan not found for selected nama_jurusan");
            }

            query = "INSERT INTO prodi (kode_prodi, nama_prodi, kode_jurusan) VALUES ('" + kodeProdi + "', '" + namaProdi + "', '" + kodeJurusan + "')";

            try
            {
                result = conn.NonQuery(query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan.");
                }
            }
            catch (Exception e)
            {
                // Handle the exception appropriately
            }
            return result;
        }

        public DataTable isicombo()
        {
            query = "SELECT nama_jurusan FROM jurusan";
            return conn.Query(query);
        }

        public int update(string kode)
        {
            int result = -1;

            // Retrieve kode_jurusan based on selected nama_jurusan
            string kodeJurusan = GetKodeJurusan(namaJurusan);

            try
            {
                if (string.IsNullOrEmpty(kodeJurusan))
                {
                    throw new Exception("Kode Jurusan Tidak Ditemukan.");
                }

                // Construct the SQL query for updating data
                query = "UPDATE prodi SET nama_prodi = '" + namaProdi + "', kode_jurusan = '" + kodeJurusan + "' WHERE kode_prodi = '" + kode + "'";

                // Execute the SQL query using LayananCls object
                result = conn.NonQuery(query);

                if (result < 0)
                {
                    throw new Exception("Gagal Mengubah.");
                }
            }
            catch (Exception e)
            {
                // Handle or log the exception
                throw;
            }

            return result;
        }

        public int delete(string kode)
        {
            int result = -1;
            query = "DELETE FROM prodi WHERE kode_prodi = '" + kode + "'";
            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Dihapus");
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public DataTable showAll()
        {
            query = "select a.kode_prodi, a.nama_prodi, b.nama_jurusan from prodi a, jurusan b where a.kode_jurusan = b.kode_jurusan";
            return conn.Query(query);
        }

        public DataTable search(string nama)
        {
            DataTable data = new DataTable();
            query = "SELECT a.kode_prodi, a.nama_prodi, b.nama_jurusan FROM prodi a, jurusan b WHERE nama_prodi LIKE '%" + nama + "%'";
            data = conn.Query(query);
            return data;
        }

        public string createCode()
        {
            string kode = "";
            int result = -1;
            query = "SELECT IFNULL(MAX(kode_prodi), 0) + 1 AS KODE FROM prodi";
            temp = conn.Query(query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }

                if (result > 0 && result < 10)
                {
                    kode = "0" + result.ToString();
                }
                else if (result >= 10 && result < 100)
                {
                    kode = result.ToString();
                }
            }

            return kode;
        }
    }
}