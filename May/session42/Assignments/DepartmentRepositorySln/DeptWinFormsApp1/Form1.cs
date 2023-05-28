using DepartmentRepositoryCoreLib.Model;
using DepartmentRepositoryCoreLib.Repository;
using System.Windows.Forms;

namespace DeptWinFormsApp1
{
    public partial class Form1 : Form
    {
        private DepartmentRepository _departmentRepository;
        private TextBox txtDeptNo;
        private TextBox txtDeptName;
        private TextBox txtDeptLoc;
        private Button btnAdd;
        private Button btnDisplay;
        private Button btnCount;
        private DataGridView dataGridView1;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MonoceptDB;Integrated Security=True";
            _departmentRepository = new DepartmentRepository(connectionString);

            //Instantiate the controls
            txtDeptNo = new TextBox();
            txtDeptName = new TextBox();
            txtDeptLoc = new TextBox();
            btnAdd = new Button();
            btnDisplay = new Button();
            btnCount = new Button();
            dataGridView1 = new DataGridView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int deptNo;
            if (!int.TryParse(txtDeptNo.Text, out deptNo))
            {
                MessageBox.Show("Invalid Department Number.");
                return;
            }
            string deptName = txtDeptName.Text;
            string deptLoc = txtDeptLoc.Text;

            Department department = new Department
            {
                DEPTNO = deptNo,
                DNAME = deptName,
                LOC = deptLoc
            };

            _departmentRepository.Add(department);
            MessageBox.Show("Department added successfully.");
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var departments = _departmentRepository.Get();
            dataGridView1.DataSource = departments;
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = _departmentRepository.Count();
            MessageBox.Show($"Total departments: {count}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set properties for the controls
            txtDeptNo.Location = new System.Drawing.Point(150, 10);
            txtDeptName.Location = new System.Drawing.Point(150, 40);
            txtDeptLoc.Location = new System.Drawing.Point(150, 70);

            Label lblDeptNo = new Label();
            lblDeptNo.Text = "DEPTNO:";
            lblDeptNo.Location = new System.Drawing.Point(10, 10);

            Label lblDeptName = new Label();
            lblDeptName.Text = "DNAME:";
            lblDeptName.Location = new System.Drawing.Point(10, 40);

            Label lblDeptLoc = new Label();
            lblDeptLoc.Text = "LOC:";
            lblDeptLoc.Location = new System.Drawing.Point(10, 70);

            btnAdd.Location = new System.Drawing.Point(150, 100);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;

            btnDisplay.Location = new System.Drawing.Point(250, 100);
            btnDisplay.Text = "Display";
            btnDisplay.Click += btnDisplay_Click;

            btnCount.Location = new System.Drawing.Point(350, 100);
            btnCount.Text = "Count";
            btnCount.Click += btnCount_Click;

            dataGridView1.Location = new System.Drawing.Point(10, 140);
            dataGridView1.Size = new System.Drawing.Size(400, 200);

            // Add the controls to the form
            Controls.Add(lblDeptNo);
            Controls.Add(txtDeptNo);
            Controls.Add(lblDeptName);
            Controls.Add(txtDeptName);
            Controls.Add(lblDeptLoc);
            Controls.Add(txtDeptLoc);
            Controls.Add(btnAdd);
            Controls.Add(btnDisplay);
            Controls.Add(btnCount);
            Controls.Add(dataGridView1);

        }
    }
}