using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections;
using SharoLib.Animate;

namespace NetworkSpdTools
{
    public partial class Form1 : Form
    {
        public double total_download = 0;
        public double total_upload = 0;
        public double maxspeed_download = 0;
        public double maxspeed_upload = 0;
        int Interval = 1000;
        //使用するネットワークカードの名前
        public string NICName = "";
        PerformanceCounter upload = new PerformanceCounter("Network Interface","Bytes Sent/sec", "", ".");
        PerformanceCounter download = new PerformanceCounter("Network Interface", "Bytes Received/sec", "", ".");
        PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
        PerformanceCounter memory = new PerformanceCounter("Memory", "Available KBytes", string.Empty);


        public ArrayList datelist = new ArrayList();
        public ArrayList downloadlist = new ArrayList();
        public ArrayList uploadlist = new ArrayList();
        public int count = 0;
        public int x = 1;
        public Graph GraphF = new Graph();
        public bool form = false;

        public Point Save_Location;

        public Form1()
        {
            InitializeComponent();

            Form1.CheckForIllegalCrossThreadCalls = false;
            this.Visible = false;

            DLL.main.appcheck(DLL.main.myappname());
            DLL.main.FormStart("NetworkSpdTools", DLL.main.myappname());
            DLL.form.Icon("NetworkSpdTools", Properties.Resources.Icon, this);
            DLL.form.MoveMouseEvent(panel1,this);
            this.Icon = Properties.Resources.Icon;

            if (DLL.main.FileSearch(DLL.main.FileName) == true)
            {
                object obj;
                DLL.main.ReadBinaryData(DLL.main.FileName, out obj);
                DLL.main.Read = (DLL.main.SaveClass)obj;
                total_download = DLL.main.Read.doubles;
                total_upload = DLL.main.Read.doubles2;
                maxspeed_download = DLL.main.Read.doubles3;
                maxspeed_upload = DLL.main.Read.doubles4;

                datelist = DLL.main.Read.arraylist;
                downloadlist = DLL.main.Read.arraylist2;
                uploadlist = DLL.main.Read.arraylist3;

                try
                {
                    Save_Location = DLL.main.Read.form.Location;
                }
                catch{ }
            }

            FormNetworkSelect();

            saved();

            Saved.Enabled = true;
            Thread initials = new Thread(new ThreadStart(Initial));
            initials.Start();
            if(DLL.main.FileSearch(@".\x.conf") == true)
            {
                string read = DLL.main.FileRead(@".\x.conf");
                x = int.Parse(read);
            }
        }
        public void Initial()
        {
            DLL.main.sleep(200);
            this.Location = Save_Location;
            this.Visible = true;
            //this.Height = 28;
        }


        public void saved()
        {
            try
            {
                string date = DLL.main.date_format("yyyyMMdd");
                int search = datelist.IndexOf(date);
                if (search == -1)
                {
                    DLL.form.Msg_Show("", "日時が切り替わりました", 1000);
                    count = 0;
                    datelist.Add(date);
                    downloadlist.Add("1");
                    uploadlist.Add("1");
                }
                else { count = search;}
                DLL.main.SaveRun.arraylist = datelist;
                DLL.main.SaveRun.arraylist2 = downloadlist;
                DLL.main.SaveRun.arraylist3 = uploadlist;

                DLL.main.SaveRun.doubles = total_download;
                DLL.main.SaveRun.doubles2 = total_upload;
                DLL.main.SaveRun.form.Location = new Point(this.Location.X, this.Location.Y);

                DLL.main.Save();
            }
            catch {}
        }

        public bool is_disable_autoconnect = false;
        public void FormNetworkSelect()
        {
            string errorcode = "";
            while(true){
            FormNetworkSelect f = new FormNetworkSelect(this);
            f.error = errorcode;
            f.ShowDialog();
                try
                {
                    upload.InstanceName = NICName;
                    download.InstanceName = NICName;

                    float test = upload.NextValue();

                    // 上り通信速度取得スレッド
                    Thread TranUPThread = new Thread((new ThreadStart(upload_view)));
                    TranUPThread.IsBackground = true;
                    TranUPThread.Start();

                    // 下り通信速度取得スレッド
                    Thread downloadThread = new Thread((new ThreadStart(download_view)));
                    downloadThread.IsBackground = true;
                    downloadThread.Start();

                    // CPU取得スレッド
                    Thread cpuThread = new Thread((new ThreadStart(cpu_view)));
                    cpuThread.IsBackground = true;
                    cpuThread.Start();

                    // Memory取得スレッド
                    Thread memoryThread = new Thread((new ThreadStart(memory_view)));
                    memoryThread.IsBackground = true;
                    memoryThread.Start();



                    break;
                }
                catch
                {
                    errorcode = "error";
                    is_disable_autoconnect = true;
                    if (DLL.Message.Show_Option("このアダプター名は無効です。再認証しますか？", "再認証", "終了") == "No")
                    {
                        DLL.main.taskkill(DLL.main.myappname());
                        break;
                    }
                }
            }
        }

        public void cpu_view()
        {
            while (true)
            {
                float cpus = cpu.NextValue();
                label_cpu.Text = cpus.ToString("###0.00") + "%";
                System.Threading.Thread.Sleep(Interval);
            }
        }
        public void memory_view()
        {
            while (true)
            {
                float f = memory.NextValue();
                //GBに変換
                //float a = (7852 - f) / 1024;
                string str = DLL.main.kb(f);
                label_memory.Text = "利用可能:" + str;
                System.Threading.Thread.Sleep(Interval);
            }
        }
        private void download_view()
        {
            float speed_download;
            while (true)
            {
                // Get Transfer(DOWN)
                //パフォーマンスカウンタの値の取得
                speed_download = download.NextValue();
                //KByteに変換するため、1024で割る
                speed_download = speed_download / 1024;

                double download_val = double.Parse(speed_download.ToString("###0.00"));
                download_val *= x;
                total_download += download_val;
                double totallist = 1024;
                try
                {
                    totallist = double.Parse(downloadlist[count].ToString()) + download_val;
                }
                catch { totallist = 1024; }
                downloadlist[count] = totallist.ToString();

                double datasize = download_val;
                double datasize2 = total_download;
                string size = DLL.main.kb(datasize);
                string total_size = DLL.main.kb(datasize2);
                double download_check = download_val * 8;
                if (download_check > maxspeed_download) { maxspeed_download = download_check; }

                label_download.Text = size + "/s";
                if (form == true)
                {
                    GraphF.label_day_download.Text = DLL.main.kb(double.Parse(downloadlist[count].ToString())) + "/day";
                    GraphF.label_total_download.Text = DLL.main.kb(total_download) + "/total";
                    GraphF.label_maxspeed_download.Text = DLL.main.kb(maxspeed_download) + "ps";
                }

                System.Threading.Thread.Sleep(Interval);
            }
        }
        private void upload_view()
        {
            float speed_upload;
            while (true)
            {
                // Get Transfer(UP)
                //パフォーマンスカウンタの値の取得
                speed_upload = upload.NextValue();
                //KByteに変換するため、1024で割る
                speed_upload = speed_upload / 1024;

                double upload_val = double.Parse(speed_upload.ToString("###0.00"));
                upload_val *= x;
                total_upload += upload_val;
                double totallist = 1024;
                try
                {
                    totallist = double.Parse(uploadlist[count].ToString()) + upload_val;
                }
                catch { totallist = 1024; }
                uploadlist[count] = totallist.ToString();

                double datasize = upload_val;
                double datasize2 = total_upload;
                string size = DLL.main.kb(datasize);
                string total_size = DLL.main.kb(datasize2);
                double upload_check = upload_val * 8;
                if (upload_check  > maxspeed_upload) { maxspeed_upload = upload_check; }

                label_upload.Text = size + "/s";
                if (form == true)
                {
                    GraphF.label_day_upload.Text = DLL.main.kb(double.Parse(uploadlist[count].ToString())) + "/day";
                    GraphF.label_total_upload.Text = DLL.main.kb(total_upload) + "/total";
                    GraphF.label_maxspeed_upload.Text = DLL.main.kb(maxspeed_upload) + "ps";
                }

                System.Threading.Thread.Sleep(Interval);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e){saved();}
        private void Saved_Tick(object sender, EventArgs e){saved();}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            form = true;
            GraphF.ShowDialog();
            form = false;
        }
    }
}