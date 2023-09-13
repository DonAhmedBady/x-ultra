using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ViX
{
    public partial class Form2 : Form
    {
        int reportsCount = 0;
        bool newReports = true;
        string dirPath = null;
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(string dirPath)
        {
            InitializeComponent();
            this.newReports = false;
            this.dirPath = dirPath;
        }
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Task.Run(()=>
            {
                try
                {
                    string jsonFile = e.FullPath;
                    string content = File.ReadAllText(jsonFile);
                    string jsonString = content;

                    var wb = JsonConvert.DeserializeObject<WhistleBlowerReport> (jsonString);
                    wb.RID = Path.GetFileName(e.FullPath);
                    this.Invoke((MethodInvoker)delegate
                    {
                        reportsCount += 1;
                        ReportList report = new ReportList(wb , reportsCount);
                        this.flowLayoutPanel1.Controls.Add(report);
                    });
                }catch(Exception){ }
            });

        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {

        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {

        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (this.newReports)
            {
                Utils.CreateRoundedCorners(this, this.Width, this.Height);
                Task.Run(() =>
                {
                    try
                    {

                        string directoryPath = @"D:\X-ULTRA";

                        // Create a new FileSystemWatcher instance
                        FileSystemWatcher watcher = new FileSystemWatcher();
                        watcher.IncludeSubdirectories = true;
                        // Set the path to the directory you want to monitor
                        watcher.Path = directoryPath;

                        // Subscribe to events
                        watcher.Created += OnCreated;
                        watcher.Deleted += OnDeleted;
                        watcher.Changed += OnChanged;
                        watcher.Renamed += OnRenamed;

                        // Enable the watcher
                        watcher.EnableRaisingEvents = true;

                        Console.WriteLine("Press 'q' to quit the program.");
                        while (Console.Read() != 'q') ;
                    }
                    catch (Exception) { }
                });
            }
            else
            {
                foreach (string file in Directory.GetFiles(dirPath))
                {
                    try
                    {
                        string content = File.ReadAllText(file);
                        string jsonString = content;

                        var wb = JsonConvert.DeserializeObject<WhistleBlowerReport>(jsonString);
                        wb.RID = Path.GetFileName(file);
                        this.Invoke((MethodInvoker)delegate
                        {
                            reportsCount += 1;
                            ReportList report = new ReportList(wb, reportsCount);
                            this.flowLayoutPanel1.Controls.Add(report);
                        });
                    }
                    catch (Exception) { }
                }
            }
        }
    }
}
