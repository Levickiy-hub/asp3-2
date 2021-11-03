using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumClient
{
    public partial class Form1 : Form
    {
        private string handlerPath = "https://localhost:44380/sum";
        public Form1()
        {
            InitializeComponent();
        }
        private async void sumButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.val1Box.Text) && !string.IsNullOrWhiteSpace(this.val2Box.Text))
                {

                    this.sumButton.Enabled = false;
                    HttpWebRequest request = ConfigureHttpRequest(this.val1Box.Text, this.val2Box.Text);
                    HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            this.resultBox.Text = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                this.resultBox.Text = ex.Message;
            }
            finally
            {
                this.sumButton.Enabled = true;
            }
        }
        private HttpWebRequest ConfigureHttpRequest(string parm1,string parm2)
        {
            string postData = $"parmA={parm1}&parmB={parm2}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(handlerPath);
            request.Method = "POST";
            request.ContentLength = byteArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            return request;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void val2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void val1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
