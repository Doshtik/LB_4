using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Work_4.Models;

namespace Work_4
{
    public partial class FormTypes : Form
    {
        private Models.AppContext _db;

        public FormTypes()
        {
            InitializeComponent();
        }

        // Вызывается при загрузке формы
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

        // Вызывается при закрытии формы
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _db.Dispose();
            _db = null;
        }

        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypeAdd formTypeAdd = new FormTypeAdd();
            DialogResult result = formTypeAdd.ShowDialog(this);

            if (DialogResult == DialogResult.Cancel || formTypeAdd.textBoxType.Text == "")
                return;

            AnimeType animeType = new AnimeType
            {
                AnimeOfType = formTypeAdd.textBoxType.Text
            };

            _db.AnimeTypes.Add(animeType);
            _db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
            dataGridViewTypes.DataSource = _db.AnimeTypes.Local.OrderBy(o => o.AnimeOfType).ToList();
        }

        private void buttonTypeEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeType animeType = _db.AnimeTypes.Find(id);
            FormTypeAdd formTypeAdd = new FormTypeAdd();

            formTypeAdd.textBoxType.Text = animeType.AnimeOfType;

            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            animeType.AnimeOfType = formTypeAdd.textBoxType.Text;
            _db.SaveChanges();

            MessageBox.Show("Объект обновлен");
            dataGridViewTypes.DataSource = _db.AnimeTypes.Local.OrderBy(o => o.AnimeOfType).ToList();
        }
    }
}
