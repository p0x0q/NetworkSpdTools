namespace NetworkSpdTools
{
    partial class FormNetworkSelect
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
            this.label4_app_description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_appid = new System.Windows.Forms.ComboBox();
            this.button1_downloader = new System.Windows.Forms.Button();
            this.textBox_Adapter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.userAccount1 = new Lib.UserControlExtension.UserAccount();
            this.SuspendLayout();
            // 
            // label4_app_description
            // 
            this.label4_app_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4_app_description.Location = new System.Drawing.Point(12, 115);
            this.label4_app_description.Name = "label4_app_description";
            this.label4_app_description.Size = new System.Drawing.Size(324, 36);
            this.label4_app_description.TabIndex = 13;
            this.label4_app_description.Text = "選択するかアダプタ名を直接入力して下さい";
            this.label4_app_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 1);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // comboBox1_appid
            // 
            this.comboBox1_appid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1_appid.FormattingEnabled = true;
            this.comboBox1_appid.Location = new System.Drawing.Point(12, 11);
            this.comboBox1_appid.Name = "comboBox1_appid";
            this.comboBox1_appid.Size = new System.Drawing.Size(252, 20);
            this.comboBox1_appid.TabIndex = 11;
            this.comboBox1_appid.Text = "使用しているアダプター名を選択して下さい";
            this.comboBox1_appid.SelectedIndexChanged += new System.EventHandler(this.comboBox1_appid_SelectedIndexChanged);
            // 
            // button1_downloader
            // 
            this.button1_downloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_downloader.Location = new System.Drawing.Point(270, 11);
            this.button1_downloader.Name = "button1_downloader";
            this.button1_downloader.Size = new System.Drawing.Size(66, 19);
            this.button1_downloader.TabIndex = 10;
            this.button1_downloader.Text = "Run";
            this.button1_downloader.UseVisualStyleBackColor = true;
            this.button1_downloader.Click += new System.EventHandler(this.button1_downloader_Click);
            // 
            // textBox_Adapter
            // 
            this.textBox_Adapter.Location = new System.Drawing.Point(70, 36);
            this.textBox_Adapter.Name = "textBox_Adapter";
            this.textBox_Adapter.Size = new System.Drawing.Size(266, 19);
            this.textBox_Adapter.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "アダプタ名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(70, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 16);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "選択を記憶し自動的に開始する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // userAccount1
            // 
            this.userAccount1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userAccount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userAccount1.Location = new System.Drawing.Point(0, 0);
            this.userAccount1.Name = "userAccount1";
            this.userAccount1.Size = new System.Drawing.Size(348, 170);
            this.userAccount1.TabIndex = 4;
            // 
            // FormNetworkSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 166);
            this.Controls.Add(this.userAccount1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Adapter);
            this.Controls.Add(this.label4_app_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_appid);
            this.Controls.Add(this.button1_downloader);
            this.Name = "FormNetworkSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNetworkSelect";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormNetworkSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4_app_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_appid;
        private System.Windows.Forms.Button button1_downloader;
        private System.Windows.Forms.TextBox textBox_Adapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private Lib.UserControlExtension.UserAccount userAccount1;
    }
}