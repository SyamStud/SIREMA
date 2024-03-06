using SIREMA.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREMA.Model
{
    internal class Jurusan
    {
        // ATTRIBUTE
        private string kodeJurusan;

        private string namaJurusan;

        // CONNECTION ATTRIBUTE
        private ConnectionCls conn;

        private DataTable temp;
        private string query;

        // CONSTRUCTOR
        public Jurusan()
        {
            kodeJurusan = "";
            namaJurusan = "";

            conn = new ConnectionCls();
            temp = new DataTable();
            query = "";
        }

        // PROPERTIES
        public string Kode_urusan
        {
            set { kodeJurusan = value; }
        }

        public string Nama_jurusan
        {
            set { namaJurusan = value; }
        }

        public bool isExist(string kode)
        {
            query = "SELECT * FROM jurusan WHERE kode_jurusan = '" + kode + "'";
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

        public int store()
        {
            int result = -1;
            query = "INSERT INTO jurusan VALUES ('" + kodeJurusan + "', '" + namaJurusan + "')";

            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Disimpan");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int update(string kode)
        {
            int result = -1;
            query = "UPDATE jurusan SET nama_jurusan = '" + namaJurusan + "' WHERE kode_jurusan = '" + kode + "'";

            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Diubah");
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int delete(string kode)
        {
            int result = -1;
            query = "DELETE FROM jurusan WHERE kode_jurusan = '" + kode + "'";
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
            DataTable data = new DataTable();
            query = "SELECT * FROM jurusan";
            data = conn.Query(query);
            return data;
        }

        public DataTable search(string nama)
        {
            DataTable data = new DataTable();
            query = "SELECT * FROM jurusan WHERE nama_jurusan LIKE '%" + nama + "%'";
            data = conn.Query(query);
            return data;
        }

        public string createCode()
        {
            string kode = "";
            int result = -1;
            query = "SELECT IFNULL(MAX(kode_jurusan), 0) + 1 AS KODE FROM jurusan";
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