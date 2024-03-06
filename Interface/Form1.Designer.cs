namespace SIREMA
{
    partial class Form1
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
            this.kodeTxt = new System.Windows.Forms.TextBox();
            this.cekBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namaTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.cariBtn = new System.Windows.Forms.Button();
            this.jurusanDgv = new System.Windows.Forms.DataGridView();
            this.cKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jurusanDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeTxt
            // 
            this.kodeTxt.Enabled = false;
            this.kodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodeTxt.Location = new System.Drawing.Point(71, 97);
            this.kodeTxt.Name = "kodeTxt";
            this.kodeTxt.Size = new System.Drawing.Size(370, 30);
            this.kodeTxt.TabIndex = 0;
            // 
            // cekBtn
            // 
            this.cekBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cekBtn.FlatAppearance.BorderSize = 0;
            this.cekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cekBtn.Location = new System.Drawing.Point(613, 55);
            this.cekBtn.Name = "cekBtn";
            this.cekBtn.Size = new System.Drawing.Size(247, 35);
            this.cekBtn.TabIndex = 2;
            this.cekBtn.Text = "Create";
            this.cekBtn.UseVisualStyleBackColor = false;
            this.cekBtn.Click += new System.EventHandler(this.cekBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Jurusan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Jurusan";
            // 
            // namaTxt
            // 
            this.namaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTxt.Location = new System.Drawing.Point(71, 198);
            this.namaTxt.Name = "namaTxt";
            this.namaTxt.Size = new System.Drawing.Size(495, 30);
            this.namaTxt.TabIndex = 4;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(613, 103);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(247, 35);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.Red;
            this.hapusBtn.FlatAppearance.BorderSize = 0;
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hapusBtn.Location = new System.Drawing.Point(613, 151);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(247, 35);
            this.hapusBtn.TabIndex = 7;
            this.hapusBtn.Text = "Delete";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // cariBtn
            // 
            this.cariBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cariBtn.FlatAppearance.BorderSize = 0;
            this.cariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cariBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cariBtn.Location = new System.Drawing.Point(459, 97);
            this.cariBtn.Name = "cariBtn";
            this.cariBtn.Size = new System.Drawing.Size(107, 34);
            this.cariBtn.TabIndex = 8;
            this.cariBtn.Text = "Search";
            this.cariBtn.UseVisualStyleBackColor = false;
            this.cariBtn.Click += new System.EventHandler(this.cariBtn_Click);
            // 
            // jurusanDgv
            // 
            this.jurusanDgv.AllowUserToAddRows = false;
            this.jurusanDgv.AllowUserToDeleteRows = false;
            this.jurusanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jurusanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKode,
            this.cNama});
            this.jurusanDgv.Location = new System.Drawing.Point(71, 276);
            this.jurusanDgv.Name = "jurusanDgv";
            this.jurusanDgv.ReadOnly = true;
            this.jurusanDgv.RowHeadersWidth = 62;
            this.jurusanDgv.RowTemplate.Height = 28;
            this.jurusanDgv.Size = new System.Drawing.Size(789, 255);
            this.jurusanDgv.TabIndex = 9;
            this.jurusanDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusanDgv_CellClick);
            // 
            // cKode
            // 
            this.cKode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cKode.DataPropertyName = "kode_jurusan";
            this.cKode.HeaderText = "Kode Jurusan";
            this.cKode.MinimumWidth = 8;
            this.cKode.Name = "cKode";
            this.cKode.ReadOnly = true;
            this.cKode.Width = 143;
            // 
            // cNama
            // 
            this.cNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNama.DataPropertyName = "nama_jurusan";
            this.cNama.HeaderText = "Nama Jurusan";
            this.cNama.MinimumWidth = 8;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearBtn.Location = new System.Drawing.Point(613, 199);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(123, 35);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(742, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.jurusanDgv);
            this.Controls.Add(this.cariBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cekBtn);
            this.Controls.Add(this.kodeTxt);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jurusanDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodeTxt;
        private System.Windows.Forms.Button cekBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namaTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button cariBtn;
        private System.Windows.Forms.DataGridView jurusanDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button1;
    }
}

