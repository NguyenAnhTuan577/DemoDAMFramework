namespace DemoDAMFramework
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
            this.grvCellphone = new System.Windows.Forms.DataGridView();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbHangSX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvCellphone)).BeginInit();
            this.SuspendLayout();
            // 
            // grvCellphone
            // 
            this.grvCellphone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCellphone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCellphone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDT,
            this.TenDT,
            this.NSX,
            this.SoMau,
            this.Price});
            this.grvCellphone.Location = new System.Drawing.Point(0, 210);
            this.grvCellphone.Name = "grvCellphone";
            this.grvCellphone.Size = new System.Drawing.Size(736, 198);
            this.grvCellphone.TabIndex = 0;
            // 
            // MaDT
            // 
            this.MaDT.HeaderText = "Mã điện thoại";
            this.MaDT.Name = "MaDT";
            // 
            // TenDT
            // 
            this.TenDT.HeaderText = "Tên điện thoại";
            this.TenDT.Name = "TenDT";
            // 
            // NSX
            // 
            this.NSX.HeaderText = "Hãng điện thoại";
            this.NSX.Name = "NSX";
            // 
            // SoMau
            // 
            this.SoMau.HeaderText = "Số màu";
            this.SoMau.Name = "SoMau";
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(593, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(593, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 35);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbHangSX
            // 
            this.cbHangSX.FormattingEnabled = true;
            this.cbHangSX.Location = new System.Drawing.Point(378, 35);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.Size = new System.Drawing.Size(121, 21);
            this.cbHangSX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hãng điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã điện thoại";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(104, 92);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(135, 20);
            this.txtTen.TabIndex = 9;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(104, 36);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(135, 20);
            this.txtMa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Màu sắc";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(378, 92);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 12;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Location = new System.Drawing.Point(104, 147);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(135, 20);
            this.txtGiatien.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá tiền";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiatien);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHangSX);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grvCellphone);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng điện thoại";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCellphone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvCellphone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbHangSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

