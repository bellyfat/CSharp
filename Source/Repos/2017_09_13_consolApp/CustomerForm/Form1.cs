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

namespace CustomerForm
{
    public partial class Form1 : Form
    {
        private const string CustomerFileName = "customers.txt";
        private List<Customer> customerlist = new List<Customer>();
        private StreamReader streamreader;

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(CustomerFileName))
            {
                streamreader = new StreamReader(CustomerFileName);
                while (streamreader.Peek() >= 0)
                {
                    string[] customerinfoparts = streamreader.ReadLine().Split(';');
                    
                    customerlist.Add(new Customer {
                        Name = customerinfoparts[0],
                        Birthday = DateTime.Parse(customerinfoparts[1]),
                        TelNr = customerinfoparts[2]
                    });
                }
                streamreader.Close();

                updatePreviewList();
            }
            else
            {
                File.Create(CustomerFileName).Close();
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            
            StreamWriter streamwriter = new StreamWriter(CustomerFileName);
            customerlist.Add(new Customer
            {
                Name = txbName.Text,
                Birthday = datetmBirthday.Value,
                TelNr = txbTelNr.Text
            });

            updatePreviewList();

            foreach (Customer customer in customerlist)
            {
                streamwriter.WriteLine(customer.Name + ";" + customer.Birthday + ";" + customer.TelNr);
            }

            streamwriter.Close();
        }

        private void updatePreviewList()
        {
            lstbxCustomersPreview.DataSource = customerlist.Select(s => s.Name).ToList();
            lstbxCustomersPreview.Update();
        }
    }
}
