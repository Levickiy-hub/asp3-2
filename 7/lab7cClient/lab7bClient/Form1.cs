using lab7bClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7bClient
{
    public partial class Form1 : Form
    {
        private PhoneDictionaryServiceSoapClient service { get; set; }
        public Form1()
        {
            service = new PhoneDictionaryServiceSoapClient();
            InitializeComponent();
            LoadPhoneList();
        }


        private void Add(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows[0] != null &&
                    dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null)
                {

                    service.Add(new Phone
                    {
                        Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                        Phone_number = dataGridView1.SelectedRows[0].Cells[2].Value.ToString()
                    });
                    LoadPhoneList();
                }
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows[0] != null &&
                    dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null)
                {
                    service.Update(new Phone
                    {
                        Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                        Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                        Phone_number = dataGridView1.SelectedRows[0].Cells[2].Value.ToString()
                    });
                    LoadPhoneList();
                }
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows[0] != null &&
                    dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null)
                {
                    int Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    service.Remove(Id);
                    LoadPhoneList();
                }
            }
        }

        private void LoadPhoneList()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Phone_Number", "Phone_number");
            int rowNumber;
            foreach (var phone in service.GetAll().ToList())
            {
                rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["Id"].Value = phone.Id;
                dataGridView1.Rows[rowNumber].Cells[0].ReadOnly = true;
                dataGridView1.Rows[rowNumber].Cells["Name"].Value = phone.Name;
                dataGridView1.Rows[rowNumber].Cells["Phone_number"].Value = phone.Phone_number;
            }
        }
    }
}
