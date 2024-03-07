namespace SIREMA.Interface
{
    partial class ProdiFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kodeTxt = new System.Windows.Forms.TextBox();
            this.prodiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.tutupBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.jurusanDgv = new System.Windows.Forms.DataGridView();
            this.jurusanCmb = new System.Windows.Forms.ComboBox();
            this.cKodeProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaJurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jurusanDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Prodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Prodi";
            // 
            // kodeTxt
            // 
            this.kodeTxt.Enabled = false;
            this.kodeTxt.Location = new System.Drawing.Point(226, 54);
            this.kodeTxt.Name = "kodeTxt";
            this.kodeTxt.Size = new System.Drawing.Size(741, 26);
            this.kodeTxt.TabIndex = 2;
            // 
            // prodiTxt
            // 
            this.prodiTxt.Location = new System.Drawing.Point(226, 110);
            this.prodiTxt.Name = "prodiTxt";
            this.prodiTxt.Size = new System.Drawing.Size(741, 26);
            this.prodiTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Jurusan";
            // 
            // simpanBtn
            // 
            this.simpanBtn.Location = new System.Drawing.Point(46, 242);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(194, 52);
            this.simpanBtn.TabIndex = 6;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.Location = new System.Drawing.Point(286, 242);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(194, 52);
            this.hapusBtn.TabIndex = 7;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = true;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // batalBtn
            // 
            this.batalBtn.Location = new System.Drawing.Point(527, 242);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(194, 52);
            this.batalBtn.TabIndex = 8;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // tutupBtn
            // 
            this.tutupBtn.Location = new System.Drawing.Point(773, 242);
            this.tutupBtn.Name = "tutupBtn";
            this.tutupBtn.Size = new System.Drawing.Size(194, 52);
            this.tutupBtn.TabIndex = 9;
            this.tutupBtn.Text = "Tutup";
            this.tutupBtn.UseVisualStyleBackColor = true;
            this.tutupBtn.Click += new System.EventHandler(this.tutupBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(46, 333);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(921, 30);
            this.searchTxt.TabIndex = 14;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // jurusanDgv
            // 
            this.jurusanDgv.AllowUserToAddRows = false;
            this.jurusanDgv.AllowUserToDeleteRows = false;
            this.jurusanDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jurusanDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jurusanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jurusanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKodeProdi,
            this.cNamaProdi,
            this.cNamaJurusan});
            this.jurusanDgv.Location = new System.Drawing.Point(45, 384);
            this.jurusanDgv.Name = "jurusanDgv";
            this.jurusanDgv.ReadOnly = true;
            this.jurusanDgv.RowHeadersWidth = 62;
            this.jurusanDgv.RowTemplate.Height = 28;
            this.jurusanDgv.Size = new System.Drawing.Size(922, 248);
            this.jurusanDgv.TabIndex = 13;
            this.jurusanDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusanDgv_CellClick);
            // 
            // jurusanCmb
            // 
            this.jurusanCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jurusanCmb.FormattingEnabled = true;
            this.jurusanCmb.Location = new System.Drawing.Point(226, 178);
            this.jurusanCmb.Name = "jurusanCmb";
            this.jurusanCmb.Size = new System.Drawing.Size(741, 28);
            this.jurusanCmb.TabIndex = 15;
            // 
            // cKodeProdi
            // 
            this.cKodeProdi.DataPropertyName = "kode_prodi";
            this.cKodeProdi.HeaderText = "Kode Prodi";
            this.cKodeProdi.MinimumWidth = 8;
            this.cKodeProdi.Name = "cKodeProdi";
            this.cKodeProdi.ReadOnly = true;
            this.cKodeProdi.Width = 150;
            // 
            // cNamaProdi
            // 
            this.cNamaProdi.DataPropertyName = "nama_prodi";
            this.cNamaProdi.HeaderText = "Nama Prodi";
            this.cNamaProdi.MinimumWidth = 8;
            this.cNamaProdi.Name = "cNamaProdi";
            this.cNamaProdi.ReadOnly = true;
            this.cNamaProdi.Width = 150;
            // 
            // cNamaJurusan
            // 
            this.cNamaJurusan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNamaJurusan.DataPropertyName = "nama_jurusan";
            this.cNamaJurusan.HeaderText = "Nama Jurusan";
            this.cNamaJurusan.MinimumWidth = 8;
            this.cNamaJurusan.Name = "cNamaJurusan";
            this.cNamaJurusan.ReadOnly = true;
            // 
            // ProdiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 672);
            this.Controls.Add(this.jurusanCmb);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.jurusanDgv);
            this.Controls.Add(this.tutupBtn);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodiTxt);
            this.Controls.Add(this.kodeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdiFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdiFrm";
            this.Load += new System.EventHandler(this.ProdiFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jurusanDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kodeTxt;
        private System.Windows.Forms.TextBox prodiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button tutupBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView jurusanDgv;
        private System.Windows.Forms.ComboBox jurusanCmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKodeProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaJurusan;
    }
}