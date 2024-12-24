using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _db.Dispose();
            _db = null;
        }

        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypeAdd form = new FormTypeAdd();
            form.ShowDialog();
        }
    }
}
