namespace Duitku
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.llOutcome = new System.Windows.Forms.LinkLabel();
            this.llIncome = new System.Windows.Forms.LinkLabel();
            this.llHome = new System.Windows.Forms.LinkLabel();
            this.tbUangKeluar = new System.Windows.Forms.TextBox();
            this.lbPengeluaran = new System.Windows.Forms.Label();
            this.lbRp = new System.Windows.Forms.Label();
            this.lbKetUangKeluar = new System.Windows.Forms.Label();
            this.dtpDanaKeluar = new System.Windows.Forms.DateTimePicker();
            this.lbDateKeluar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.lblRiwayatDanaKeluar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddOutcome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // llOutcome
            // 
            this.llOutcome.AutoSize = true;
            this.llOutcome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llOutcome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llOutcome.Location = new System.Drawing.Point(950, 31);
            this.llOutcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llOutcome.Name = "llOutcome";
            this.llOutcome.Size = new System.Drawing.Size(121, 28);
            this.llOutcome.TabIndex = 28;
            this.llOutcome.TabStop = true;
            this.llOutcome.Text = "Outcome";
            this.llOutcome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOutcome_LinkClicked);
            // 
            // llIncome
            // 
            this.llIncome.AutoSize = true;
            this.llIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llIncome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llIncome.Location = new System.Drawing.Point(698, 31);
            this.llIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llIncome.Name = "llIncome";
            this.llIncome.Size = new System.Drawing.Size(101, 28);
            this.llIncome.TabIndex = 27;
            this.llIncome.TabStop = true;
            this.llIncome.Text = "Income";
            this.llIncome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llIncome_LinkClicked_1);
            // 
            // llHome
            // 
            this.llHome.AutoSize = true;
            this.llHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llHome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llHome.Location = new System.Drawing.Point(428, 31);
            this.llHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llHome.Name = "llHome";
            this.llHome.Size = new System.Drawing.Size(81, 28);
            this.llHome.TabIndex = 26;
            this.llHome.TabStop = true;
            this.llHome.Text = "Home";
            this.llHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHome_LinkClicked_1);
            // 
            // tbUangKeluar
            // 
            this.tbUangKeluar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUangKeluar.Location = new System.Drawing.Point(192, 168);
            this.tbUangKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.tbUangKeluar.Name = "tbUangKeluar";
            this.tbUangKeluar.Size = new System.Drawing.Size(289, 42);
            this.tbUangKeluar.TabIndex = 29;
            this.tbUangKeluar.TextChanged += new System.EventHandler(this.tbPengeluaran_TextChanged);
            // 
            // lbPengeluaran
            // 
            this.lbPengeluaran.AutoSize = true;
            this.lbPengeluaran.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPengeluaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbPengeluaran.Location = new System.Drawing.Point(192, 130);
            this.lbPengeluaran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPengeluaran.Name = "lbPengeluaran";
            this.lbPengeluaran.Size = new System.Drawing.Size(184, 34);
            this.lbPengeluaran.TabIndex = 30;
            this.lbPengeluaran.Text = "Dana Keluar";
            // 
            // lbRp
            // 
            this.lbRp.AutoSize = true;
            this.lbRp.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbRp.Location = new System.Drawing.Point(135, 161);
            this.lbRp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRp.Name = "lbRp";
            this.lbRp.Size = new System.Drawing.Size(51, 34);
            this.lbRp.TabIndex = 31;
            this.lbRp.Text = "Rp";
            // 
            // lbKetUangKeluar
            // 
            this.lbKetUangKeluar.AutoSize = true;
            this.lbKetUangKeluar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbKetUangKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbKetUangKeluar.Location = new System.Drawing.Point(192, 214);
            this.lbKetUangKeluar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKetUangKeluar.Name = "lbKetUangKeluar";
            this.lbKetUangKeluar.Size = new System.Drawing.Size(407, 19);
            this.lbKetUangKeluar.TabIndex = 32;
            this.lbKetUangKeluar.Text = "Masukkan uang pengeluaran Anda (dalam rupiah)";
            // 
            // dtpDanaKeluar
            // 
            this.dtpDanaKeluar.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDanaKeluar.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpDanaKeluar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDanaKeluar.Location = new System.Drawing.Point(818, 168);
            this.dtpDanaKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDanaKeluar.Name = "dtpDanaKeluar";
            this.dtpDanaKeluar.Size = new System.Drawing.Size(444, 37);
            this.dtpDanaKeluar.TabIndex = 33;
            // 
            // lbDateKeluar
            // 
            this.lbDateKeluar.AutoSize = true;
            this.lbDateKeluar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbDateKeluar.Location = new System.Drawing.Point(818, 128);
            this.lbDateKeluar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateKeluar.Name = "lbDateKeluar";
            this.lbDateKeluar.Size = new System.Drawing.Size(125, 34);
            this.lbDateKeluar.TabIndex = 34;
            this.lbDateKeluar.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(818, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Masukkan uang pengeluaran Anda\r\n";
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Location = new System.Drawing.Point(192, 462);
            this.dgvRiwayat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.RowHeadersWidth = 62;
            this.dgvRiwayat.RowTemplate.Height = 33;
            this.dgvRiwayat.Size = new System.Drawing.Size(1049, 412);
            this.dgvRiwayat.TabIndex = 36;
            // 
            // lblRiwayatDanaKeluar
            // 
            this.lblRiwayatDanaKeluar.AutoSize = true;
            this.lblRiwayatDanaKeluar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRiwayatDanaKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRiwayatDanaKeluar.Location = new System.Drawing.Point(192, 409);
            this.lblRiwayatDanaKeluar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiwayatDanaKeluar.Name = "lblRiwayatDanaKeluar";
            this.lblRiwayatDanaKeluar.Size = new System.Drawing.Size(309, 34);
            this.lblRiwayatDanaKeluar.TabIndex = 38;
            this.lblRiwayatDanaKeluar.Text = "Riwayat Pengeluaran";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(168, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 47);
            this.label2.TabIndex = 41;
            this.label2.Text = "Duitku";
            // 
            // btnAddOutcome
            // 
            this.btnAddOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddOutcome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddOutcome.ForeColor = System.Drawing.Color.White;
            this.btnAddOutcome.Location = new System.Drawing.Point(215, 264);
            this.btnAddOutcome.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddOutcome.Name = "btnAddOutcome";
            this.btnAddOutcome.Size = new System.Drawing.Size(211, 62);
            this.btnAddOutcome.TabIndex = 42;
            this.btnAddOutcome.Text = "Add";
            this.btnAddOutcome.UseVisualStyleBackColor = false;
            this.btnAddOutcome.Click += new System.EventHandler(this.btnAddOutcome_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.btnAddOutcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRiwayatDanaKeluar);
            this.Controls.Add(this.dgvRiwayat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDateKeluar);
            this.Controls.Add(this.dtpDanaKeluar);
            this.Controls.Add(this.lbKetUangKeluar);
            this.Controls.Add(this.lbRp);
            this.Controls.Add(this.lbPengeluaran);
            this.Controls.Add(this.tbUangKeluar);
            this.Controls.Add(this.llOutcome);
            this.Controls.Add(this.llIncome);
            this.Controls.Add(this.llHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel llOutcome;
        private LinkLabel llIncome;
        private LinkLabel llHome;
        private TextBox tbUangKeluar;
        private Label lbPengeluaran;
        private Label lbRp;
        private Label lbKetUangKeluar;
        private DateTimePicker dtpDanaKeluar;
        private Label lbDateKeluar;
        private Label label1;
        private DataGridView dgvRiwayat;
        private Label lblRiwayatDanaKeluar;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddOut;
        private Label label2;
        private Button btnAddOutcome;
    }
}