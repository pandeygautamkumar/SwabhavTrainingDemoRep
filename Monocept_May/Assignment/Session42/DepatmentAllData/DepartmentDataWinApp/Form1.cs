using DepartmentDataLibApp.Model;

namespace DepartmentDataWinApp
{
    public partial class Form1 : Form
    {
        DepartmentRepository repository = new DepartmentRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            var deptDetails = await repository.GetAsync();
            DataGridView grid = new DataGridView();
            grid.AutoGenerateColumns = true;
            grid.DataSource = deptDetails;
            grid.Location = new Point(20, 250);
            grid.AutoSize = true;
            this.Controls.Add(grid);
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Department department = new Department
            {
                Dno = Convert.ToInt32((textBoxDno.Text).ToString()),
                Dname = ((textBoxDname.Text).ToString()),
                Location = ((textBox2.Text).ToString())
            };
            textBoxDno.Text = "";
            textBoxDname.Text = "";
            textBox2.Text = "";
            await repository.AddAstnc(department);
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