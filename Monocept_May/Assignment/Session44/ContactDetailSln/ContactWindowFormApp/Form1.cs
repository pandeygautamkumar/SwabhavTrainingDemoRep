using ContactDALLib.Model;
using ContactDALLib.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactWindowFormApp
{
    public partial class Form1 : Form
    {
        private ContactRepository contactRepository;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtMobileNumber;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnDisplay;
        private DataGridView dataGridView1;
        public Form1()
        {
            InitializeComponent();
            contactRepository = new ContactRepository();

            // Instantiate the controls
            txtId = new TextBox();
            txtName = new TextBox();
            txtMobileNumber = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnDisplay = new Button();
            dataGridView1 = new DataGridView();

            Form1_Load(this, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Properties For the Controls

            txtId.Location = new Point(400, 30);
            txtName.Location = new Point(400, 60);
            txtMobileNumber.Location = new Point(400, 90);
            txtAddress.Location = new Point(400, 120);

            Label lblId = new Label();
            lblId.Text = "ID:";
            lblId.ForeColor = Color.Blue;
            lblId.Location = new Point(250, 30);

            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.ForeColor = Color.Blue;
            lblName.Location = new Point(250, 60);

            Label lblMobileNumber = new Label();
            lblMobileNumber.Text = "Mobile Number:";
            lblMobileNumber.ForeColor = Color.Blue;
            lblMobileNumber.Location = new Point(250, 90);

            Label lblAddress = new Label();
            lblAddress.Text = "Address:";
            lblAddress.ForeColor = Color.Blue;
            lblAddress.Location = new Point(250, 120);

            btnAdd.Location = new Point(280, 160);
            btnAdd.Text = "Add";
            btnAdd.BackColor = Color.LightBlue;
            btnAdd.Click += btnAddContact_Click;

            btnDisplay.Location = new Point(380, 160);
            btnDisplay.Text = "Display";
            btnDisplay.BackColor = Color.LightBlue;
            btnDisplay.Click += btnDisplay_Click;

            dataGridView1.Location = new Point(250, 200);
            dataGridView1.AutoSize = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Add the controls to the form
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblMobileNumber);
            Controls.Add(txtMobileNumber);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnAdd);
            Controls.Add(btnDisplay);
            Controls.Add(dataGridView1);
        }
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                MobileNumber = txtMobileNumber.Text,
                Address = txtAddress.Text
            };
            contactRepository.AddContact(contact);
            MessageBox.Show("Contact added successfully.");
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = contactRepository.GetContact();
            if (contacts.Count == 0)
            {
                MessageBox.Show("No contacts found.");
            }
            else
            {
                dataGridView1.DataSource = contacts;
            }
        }
    }
}
