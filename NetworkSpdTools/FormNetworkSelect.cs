using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections;
using System.Threading;

namespace NetworkSpdTools
{
    public partial class FormNetworkSelect : Form
    {
        public Form1 f2;
        public string network_card;
        public ArrayList Adapter = new ArrayList();
        public bool AdapterCheck = false;
        public string autoload = string.Empty;
        public string error = "";
        public FormNetworkSelect(Form1 f)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            f2 = f;
            InitializeComponent();
            this.Icon = Properties.Resources.Icon;

            NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in nis)
            {
                //ネットワーク接続しているか調べる
                if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback && ni.NetworkInterfaceType != NetworkInterfaceType.Tunnel)
                {
                    //ネットワークインターフェイスの情報を表示する
                    Adapter.Add(ni.Name);
                    comboBox1_appid.Items.Add(ni.Description);
                }
            }

            if (error == "error")
            {
                label4_app_description.Text = "アダプターに問題があるためやり直して下さい";
            }
            else if (System.IO.File.Exists(DLL.main.FileName))
            {
                object obj;
                DLL.main.ReadBinaryData(DLL.main.FileName, out obj);
                DLL.main.Read = (DLL.main.SaveClass)obj;
                autoload = DLL.main.Read.string1;
                if (autoload == true.ToString()) Form1.CheckForIllegalCrossThreadCalls = false;
                {
                    textBox_Adapter.Text = DLL.main.Read.string2;
                    checkBox1.Checked = true;
                    Thread r = new Thread(new ThreadStart(ButtonRun));
                    r.Start();
                }
            }
        }


        private void button1_downloader_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DLL.main.SaveRun.string1 = true.ToString();
                DLL.main.SaveRun.string2 = textBox_Adapter.Text;
                DLL.main.Save();
            }

            textBox_Adapter.Text = DLL.main.StringReplace(textBox_Adapter.Text, "(", "[");
            textBox_Adapter.Text = DLL.main.StringReplace(textBox_Adapter.Text, ")", "]");
            textBox_Adapter.Text = DLL.main.StringReplace(textBox_Adapter.Text, "/", "_");
            network_card = textBox_Adapter.Text;
            if (comboBox1_appid.SelectedItem != null || network_card != string.Empty)
            {
                if (AdapterCheck == true)
                {
                    if (DLL.Message.Show_Option("仮想ネットワークの可能性があるアダプタを選択しました。正常に動作しない可能性があります。このまま実行しますか？", "実行", "キャンセル") == "No")
                    {
                        return;
                    }
                }
                f2.NICName = network_card;
                this.Close();
            }
        }
        private void comboBox1_appid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_appid.SelectedItem != null)
            {
                textBox_Adapter.Text = comboBox1_appid.SelectedItem.ToString();
                network_card = textBox_Adapter.Text;
                string result = "正常なアダプタ名です。";
                if (DLL.main.StringSearch(network_card, "Hamachi") || DLL.main.StringSearch(network_card, "VMware") || DLL.main.StringSearch(network_card, "VirtualBox"))
                {
                    result = "このアダプタは仮想ネットワークカードの可能性があります";
                    AdapterCheck = true;
                }
                else { AdapterCheck = false; }
                label4_app_description.Text = "アダプタ名:" + Adapter[comboBox1_appid.SelectedIndex].ToString() + "\r\n備考:" + result;
            }
        }

        private void FormNetworkSelect_Load(object sender, EventArgs e)
        {
        }
        public void ButtonRun()
        {
            //label4_app_description.Text = "自動処理中です...";
            DLL.main.sleep(1000);
            button1_downloader.PerformClick();
        }
    }
}
