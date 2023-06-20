using DepartmentDataLibApp.Model;
using System.Data;

namespace DepartmentDetailsWinFormApp
{
    public partial class Form1 : Form
    {
        DepartmentRepository repository = new DepartmentRepository();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var deptDetails = repository.Get();
            string allData = "";
            foreach (var dept in deptDetails)
            {
                allData += $"{dept.Dno}-->{dept.Dname}-->{dept.Location}\n";
            }
            DataGridView grid = new DataGridView();
            grid.AutoGenerateColumns = true;
            grid.DataSource = deptDetails;
            grid.Location = new Point(20, 250);
            grid.AutoSize = true;
            this.Controls.Add(grid);
            MessageBox.Show(allData);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Department department = new Department
            {
                Dno=Convert.ToInt32((textBoxDno.Text).ToString()),
                Dname=((textBoxDname.Text).ToString()),
                Location=((textBox2.Text).ToString())
            };
            textBoxDno.Text = "";
            textBoxDname.Text = "";
            textBox2.Text = "";
            repository.AddDepartment(department);
        }
        private void textBoxDno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}