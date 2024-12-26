namespace Work_4
{
    public partial class FormTypeAdd : Form
    {
        private string _msgError = "Поле не моет быть пустым";

        public FormTypeAdd()
        {
            InitializeComponent();
        }

        private void TextBoxType_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxType.Text))
            {
                errorProvider.SetError(textBoxType, _msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxType.Text))
            {
                errorProvider.SetError(textBoxType, "Поле не может быть пустым");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
