namespace Ransomware2._0
{
    partial class UnReal
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnReal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.codebox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmr_hide = new System.Windows.Forms.Timer(this.components);
            this.tmr_show = new System.Windows.Forms.Timer(this.components);
            this.tmr_if = new System.Windows.Forms.Timer(this.components);
            this.tmr_encrypt = new System.Windows.Forms.Timer(this.components);
            this.tmr_clock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(737, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(-622, 163);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 24);
            this.lbl1.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl2.Location = new System.Drawing.Point(179, 13);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(555, 320);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = resources.GetString("lbl2.Text");
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 5);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(55, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl3.Location = new System.Drawing.Point(766, 79);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(91, 28);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Decrypt";
            // 
            // codebox
            // 
            this.codebox.BackColor = System.Drawing.Color.Red;
            this.codebox.ForeColor = System.Drawing.SystemColors.Info;
            this.codebox.Location = new System.Drawing.Point(135, 437);
            this.codebox.Name = "codebox";
            this.codebox.Size = new System.Drawing.Size(596, 20);
            this.codebox.TabIndex = 7;
            this.codebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codebox.TextChanged += new System.EventHandler(this.codebox_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(757, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(669, -1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btt1
            // 
            this.btt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btt1.Location = new System.Drawing.Point(135, 349);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(593, 68);
            this.btt1.TabIndex = 11;
            this.btt1.Text = "DECRYPT";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(749, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "00:00:00";
            // 
            // tmr_hide
            // 
            this.tmr_hide.Interval = 10000;
            this.tmr_hide.Tick += new System.EventHandler(this.tmr_hide_Tick);
            // 
            // tmr_show
            // 
            this.tmr_show.Enabled = true;
            this.tmr_show.Interval = 1000;
            this.tmr_show.Tick += new System.EventHandler(this.tmr_show_Tick);
            // 
            // tmr_if
            // 
            this.tmr_if.Enabled = true;
            this.tmr_if.Interval = 300;
            this.tmr_if.Tick += new System.EventHandler(this.tmt_if_Tick);
            // 
            // tmr_encrypt
            // 
            this.tmr_encrypt.Enabled = true;
            this.tmr_encrypt.Interval = 1000;
            this.tmr_encrypt.Tick += new System.EventHandler(this.tmr_encrypt_Tick);
            // 
            // tmr_clock
            // 
            this.tmr_clock.Enabled = true;
            this.tmr_clock.Interval = 60000;
            this.tmr_clock.Tick += new System.EventHandler(this.tmr_clock_Tick);
            // 
            // UnReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(869, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.codebox);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnReal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " UnReal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnReal_FormClosing);
            this.Load += new System.EventHandler(this.UnReal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox codebox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmr_hide;
        private System.Windows.Forms.Timer tmr_show;
        private System.Windows.Forms.Timer tmr_if;
        private System.Windows.Forms.Timer tmr_encrypt;
        private System.Windows.Forms.Timer tmr_clock;
    }
}

