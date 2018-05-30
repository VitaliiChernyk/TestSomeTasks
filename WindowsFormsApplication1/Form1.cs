using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void normalExecute_btn_Click(object sender, EventArgs e)
        {
            siteList_lstbx.Items.Clear();
            var watch = Stopwatch.StartNew();
            RunDownloadSync();
            watch.Stop();
            var elepsedMs = watch.ElapsedMilliseconds;
            result_lb.Text = String.Format("Total execution time: {0}", elepsedMs);
        }

        private void RunDownloadSync()
        {
            List<string> websites = PrepData();

            foreach (string site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                ReportWebsiteInfo(results);
            }
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();
            result_lb.Text = string.Empty;
            output.Add("https://yahoo.com");
            output.Add("https://google.com");
            output.Add("https://microsoft.com");
            output.Add("https://cnn.com");
            output.Add("https://codeproject.com");
            output.Add("https://stackoverflow.com");
            return output;
        }

        private WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();
            output.WebsiteURL = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);
            return output;
        }
        private async Task<WebsiteDataModel> DownloadWebsiteAsync(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();
            output.WebsiteURL = websiteURL;
            output.WebsiteData = await client.DownloadStringTaskAsync(websiteURL);
            return output;
        }
        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            //siteList_lstbx.Text += );
            siteList_lstbx.Items.Add(string.Format("{0} downloaded {1} characters long.\n", data.WebsiteURL,
                data.WebsiteURL.Length));
        }

        private async void asyncExecute_btn_Click(object sender, EventArgs e)
        {
            siteList_lstbx.Items.Clear();
            var watch = Stopwatch.StartNew();
            //await RunDownloadASync();
            await RunDownloadParalelASync();
            watch.Stop();
            var elepsedMs = watch.ElapsedMilliseconds;
            result_lb.Text = String.Format("Total execution time: {0}", elepsedMs);
        }
        private async Task RunDownloadASync()
        {
            List<string> websites = PrepData();

            foreach (string site in websites)
            {
                WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                ReportWebsiteInfo(results);
            }
        }
        private async Task RunDownloadParalelASync()
        {
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (string site in websites)
            {
                //WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                tasks.Add(Task.Run(() => DownloadWebsiteAsync(site)));
                //ReportWebsiteInfo(results);
            }
            var results = await Task.WhenAll(tasks);
            foreach (var item in results)
            {
                ReportWebsiteInfo(item);
            }
        }
    }
}
