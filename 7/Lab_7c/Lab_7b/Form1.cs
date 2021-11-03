using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab7b
{
    public partial class Form1 : Form
    {
        ServiceReference.MyServiceClient client;

        public Form1()
        {
            InitializeComponent();

            this.client = new ServiceReference.MyServiceClient();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            dynamic array = JsonConvert.DeserializeObject(Convert.ToString(this.client.GetAll()));
            foreach (var item in array)
            {
                this.richTextBox1.Text += "[" + item.id + "] - " + item.surname + " - " + item.number + "\n";
            }
        }

        private void Post_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name.Text;
                int number = Convert.ToInt32(this.number.Text);

                if (this.client.AddDict(name, number) == "OK")
                {
                    Get_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed add");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Fill required fields");
            }
        }

        private void Put_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name.Text;
                int number = Convert.ToInt32(this.number.Text);
                int id = Convert.ToInt32(this.id.Text);

                if (this.client.UpdDict(id, name, number) == "OK")
                {
                    Get_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed update");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Fill required fields");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.id.Text);

                if (this.client.DelDict(id) == "OK")
                {
                    Get_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed delete");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Fill required fields");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
