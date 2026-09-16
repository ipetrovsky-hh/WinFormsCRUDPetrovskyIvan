using WinFormsCRUDPetrovskyIvan.Data;

namespace WinFormsCRUDPetrovskyIvan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializedataGridView();

            InitializeTreeView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void InitializedataGridView()
        {
            WorkingData wData = new WorkingData(StaticJsonValues.textJson);
            dataGridView1.DataSource = wData.FullSortDataGrid();

            dataGridView1.Columns["Name"].HeaderText = "Наименование";
            dataGridView1.Columns["Specification"].HeaderText = "Спецификация";
            dataGridView1.Columns["CategoryName"].HeaderText = "Наименование категории";
            dataGridView1.Columns["ListPrice"].HeaderText = "Строимость";
            dataGridView1.Columns["Description"].HeaderText = "Описание";
            dataGridView1.Columns["Address"].HeaderText = "Адрес сотрудника";
            dataGridView1.Columns["Database"].HeaderText = "База данных";
        }

        private void InitializeTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Меню дерево с ветвями");
            treeView1.Nodes[0].Nodes.Add("Базы данных>");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("MS SQL");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Oracle");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("MongoDB");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Postgresql");
            treeView1.Nodes[0].Nodes.Add("Языки программирования");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("С++");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("С#");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Visual Basic");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Java");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("TypeScript");
            treeView1.EndUpdate();
        }
    }
}
