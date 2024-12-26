namespace Work_4
{
    partial class FormTypes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonTypeDelete = new Button();
            buttonTypeEdit = new Button();
            buttonTypeAdd = new Button();
            panel2 = new Panel();
            dataGridViewTypes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonTypeDelete);
            panel1.Controls.Add(buttonTypeEdit);
            panel1.Controls.Add(buttonTypeAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1029, 75);
            panel1.TabIndex = 0;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.Location = new Point(261, 23);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(99, 30);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            // 
            // buttonTypeEdit
            // 
            buttonTypeEdit.Location = new Point(118, 23);
            buttonTypeEdit.Name = "buttonTypeEdit";
            buttonTypeEdit.Size = new Size(137, 30);
            buttonTypeEdit.TabIndex = 1;
            buttonTypeEdit.Text = "Редактировать";
            buttonTypeEdit.UseVisualStyleBackColor = true;
            buttonTypeEdit.Click += buttonTypeEdit_Click;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.Location = new Point(10, 23);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(99, 30);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            buttonTypeAdd.Click += buttonTypeAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewTypes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1029, 555);
            panel2.TabIndex = 1;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(1009, 535);
            dataGridViewTypes.TabIndex = 0;
            // 
            // FormTypes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справочник CRUD";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonTypeEdit;
        private Button buttonTypeAdd;
        private Button buttonTypeDelete;
        private Panel panel2;
        private DataGridView dataGridViewTypes;
    }
}
