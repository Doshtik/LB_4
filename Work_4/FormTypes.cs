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

            // Сокрытие некоторых столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            // Изменение название заголовков столбцов
            dataGridViewTypes.Columns["AnimeOfType"].HeaderText = "Тип";
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
