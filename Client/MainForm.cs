using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Windows.Forms;

namespace FanTest.WebAPI.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            string url = this.txtAddress.Text;

            WebRequest request = HttpWebRequest.Create(url);
            request.Credentials = new NetworkCredential("admin", "");
            if (this.chkPost.Checked)
            {
                string contentType = this.cboContentType.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(this.txtData.Text);

                request.Method = "POST";
                request.ContentType = contentType;
                request.ContentLength = buffer.Length;
                using (Stream rs = request.GetRequestStream())
                {
                    rs.Write(buffer, 0, buffer.Length);
                }
            }
            else
            {
                request.Method = "GET";
            }
            //request.Accept = "*/*";
            //request.KeepAlive = true;
            //request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        this.txtResult.Text = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                this.txtResult.Text = ex.ToString();
            }
        }

        private void chkPost_CheckedChanged(object sender, EventArgs e)
        {
            this.cboContentType.Enabled = this.chkPost.Checked;
            this.txtData.Enabled = this.chkPost.Checked;
        }
    }
}
