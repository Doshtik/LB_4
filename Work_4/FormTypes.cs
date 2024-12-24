using Microsoft.EntityFrameworkCore;

namespace Work_4
{
    public partial class FormTypes : Form
    {
        private Models.AppContext _db;

        public FormTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _db = new Models.AppContext();
            _db.AnimeTypes.Load();
            dataGridViewTypes.DataSource = _db.AnimeTypes.Local.OrderBy(o => o.AnimeOfType).ToList();

            // �������� ��������� ��������
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            // ��������� �������� ���������� ��������
            dataGridViewTypes.Columns["AnimeOfType"].HeaderText = "���";
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
