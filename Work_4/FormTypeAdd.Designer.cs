namespace Work_4
{
    partial class FormTypeAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panel2 = new Panel();
            textBoxType = new TextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 106);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(528, 45);
            panel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(273, 6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(91, 31);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(370, 6);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(144, 31);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxType);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(528, 106);
            panel2.TabIndex = 2;
            // 
            // textBoxType
            // 
            textBoxType.Dock = DockStyle.Top;
            textBoxType.Location = new Point(15, 43);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(498, 33);
            textBoxType.TabIndex = 1;
            textBoxType.TextChanged += TextBoxType_TextChanged;
            textBoxType.Validating += textBoxType_Validating;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(498, 28);
            label1.TabIndex = 0;
            label1.Text = "Тип Аниме";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormTypeAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 151);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTypeAdd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSave;
        protected internal TextBox textBoxType;
        private ErrorProvider errorProvider;
    }
}