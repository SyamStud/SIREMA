﻿namespace SIREMA
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
            this.jurusanDgv = new System.Windows.Forms.DataGridView();
            this.cKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jurusanDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeTxt
            // 
            this.kodeTxt.Enabled = false;
            this.kodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodeTxt.Location = new System.Drawing.Point(70, 97);
            this.kodeTxt.Name = "kodeTxt";
            this.kodeTxt.Size = new System.Drawing.Size(789, 30);
            this.kodeTxt.TabIndex = 0;
            this.kodeTxt.TextChanged += new System.EventHandler(this.kodeTxt_TextChanged);
            // 
            // cekBtn
            // 
            this.cekBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cekBtn.FlatAppearance.BorderSize = 0;
            this.cekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cekBtn.Location = new System.Drawing.Point(72, 256);
            this.cekBtn.Name = "cekBtn";
            this.cekBtn.Size = new System.Drawing.Size(186, 46);
            this.cekBtn.TabIndex = 2;
            this.cekBtn.Text = "Create";
            this.cekBtn.UseVisualStyleBackColor = false;
            this.cekBtn.Click += new System.EventHandler(this.cekBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Jurusan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Jurusan";
            // 
            // namaTxt
            // 
            this.namaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTxt.Location = new System.Drawing.Point(70, 198);
            this.namaTxt.Name = "namaTxt";
            this.namaTxt.Size = new System.Drawing.Size(650, 30);
            this.namaTxt.TabIndex = 4;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(276, 256);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(186, 46);
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
            this.hapusBtn.Location = new System.Drawing.Point(470, 256);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(186, 46);
            this.hapusBtn.TabIndex = 7;
            this.hapusBtn.Text = "Delete";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
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
            this.cKode,
            this.cNama});
            this.jurusanDgv.Location = new System.Drawing.Point(70, 382);
            this.jurusanDgv.Name = "jurusanDgv";
            this.jurusanDgv.ReadOnly = true;
            this.jurusanDgv.RowHeadersWidth = 62;
            this.jurusanDgv.RowTemplate.Height = 28;
            this.jurusanDgv.Size = new System.Drawing.Size(789, 301);
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
            this.clearBtn.Location = new System.Drawing.Point(673, 256);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(186, 46);
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
            this.button1.Location = new System.Drawing.Point(741, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(72, 332);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(789, 30);
            this.searchTxt.TabIndex = 12;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 725);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.jurusanDgv);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cekBtn);
            this.Controls.Add(this.kodeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIREMA";
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
        private System.Windows.Forms.DataGridView jurusanDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTxt;
    }
}

