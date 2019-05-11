namespace NetworkSpdTools
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_upload = new System.Windows.Forms.Label();
            this.config_UserControl1 = new Lib.UserControlExtension.Config_UserControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Saved = new System.Windows.Forms.Timer(this.components);
            this.label_download = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label_cpu = new System.Windows.Forms.Label();
            this.label_memory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label_upload
            // 
            this.label_upload.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_upload.Location = new System.Drawing.Point(179, 3);
            this.label_upload.Name = "label_upload";
            this.label_upload.Size = new System.Drawing.Size(105, 23);
            this.label_upload.TabIndex = 2;
            this.label_upload.Text = "0000.00KB/s";
            this.label_upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // config_UserControl1
            // 
            this.config_UserControl1.Location = new System.Drawing.Point(313, 3);
            this.config_UserControl1.Name = "config_UserControl1";
            this.config_UserControl1.Size = new System.Drawing.Size(23, 23);
            this.config_UserControl1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetworkSpdTools.Properties.Resources.upload_icon;
            this.pictureBox1.Location = new System.Drawing.Point(155, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Upload");
            // 
            // Saved
            // 
            this.Saved.Interval = 30000;
            this.Saved.Tick += new System.EventHandler(this.Saved_Tick);
            // 
            // label_download
            // 
            this.label_download.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_download.Location = new System.Drawing.Point(50, 3);
            this.label_download.Name = "label_download";
            this.label_download.Size = new System.Drawing.Size(105, 23);
            this.label_download.TabIndex = 12;
            this.label_download.Text = "0000.00KB/s";
            this.label_download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::NetworkSpdTools.Properties.Resources.download_icon;
            this.pictureBox2.Location = new System.Drawing.Point(25, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox2, "Download");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NetworkSpdTools.Properties.Resources.graph_icon;
            this.pictureBox3.Location = new System.Drawing.Point(290, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 50);
            this.panel1.TabIndex = 16;
            this.toolTip.SetToolTip(this.panel1, "ウィンドウの移動");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::NetworkSpdTools.Properties.Resources.cpu_icon;
            this.pictureBox4.Location = new System.Drawing.Point(25, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox4, "Download");
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::NetworkSpdTools.Properties.Resources.memory_icon;
            this.pictureBox5.Location = new System.Drawing.Point(132, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox5, "Download");
            // 
            // label_cpu
            // 
            this.label_cpu.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_cpu.Location = new System.Drawing.Point(50, 26);
            this.label_cpu.Name = "label_cpu";
            this.label_cpu.Size = new System.Drawing.Size(78, 23);
            this.label_cpu.TabIndex = 17;
            this.label_cpu.Text = "000.00%";
            this.label_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_memory
            // 
            this.label_memory.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_memory.Location = new System.Drawing.Point(161, 27);
            this.label_memory.Name = "label_memory";
            this.label_memory.Size = new System.Drawing.Size(175, 23);
            this.label_memory.TabIndex = 20;
            this.label_memory.Text = "利用可能:0000.00KB";
            this.label_memory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(339, 52);
            this.Controls.Add(this.label_memory);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_cpu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_download);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.config_UserControl1);
            this.Controls.Add(this.label_upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_upload;
        private Lib.UserControlExtension.Config_UserControl config_UserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Saved;
        private System.Windows.Forms.Label label_download;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_cpu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label_memory;
    }
}

