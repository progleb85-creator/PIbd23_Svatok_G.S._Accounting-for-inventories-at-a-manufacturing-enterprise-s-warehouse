namespace OTP.Forms
{
    partial class FormProductionIssue
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelProduct = new System.Windows.Forms.Label();
            comboBoxProduct = new System.Windows.Forms.ComboBox();
            labelWarehouse = new System.Windows.Forms.Label();
            comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            labelIssueDate = new System.Windows.Forms.Label();
            dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            groupBoxMaterials = new System.Windows.Forms.GroupBox();
            dataGridViewMaterials = new System.Windows.Forms.DataGridView();
            ColumnMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).BeginInit();
            groupBoxMaterials.SuspendLayout();
            SuspendLayout();
            //
            // labelProduct
            //
            labelProduct.AutoSize = true;
            labelProduct.Location = new System.Drawing.Point(12, 15);
            labelProduct.Text = "Продукция";
            labelProduct.Name = "labelProduct";
            labelProduct.TabIndex = 0;
            //
            // comboBoxProduct
            //
            comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new System.Drawing.Point(130, 12);
            comboBoxProduct.Size = new System.Drawing.Size(318, 23);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.TabIndex = 1;
            //
            // labelWarehouse
            //
            labelWarehouse.AutoSize = true;
            labelWarehouse.Location = new System.Drawing.Point(12, 50);
            labelWarehouse.Text = "Склад";
            labelWarehouse.Name = "labelWarehouse";
            labelWarehouse.TabIndex = 2;
            //
            // comboBoxWarehouse
            //
            comboBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxWarehouse.FormattingEnabled = true;
            comboBoxWarehouse.Location = new System.Drawing.Point(130, 47);
            comboBoxWarehouse.Size = new System.Drawing.Size(318, 23);
            comboBoxWarehouse.Name = "comboBoxWarehouse";
            comboBoxWarehouse.TabIndex = 3;
            //
            // labelIssueDate
            //
            labelIssueDate.AutoSize = true;
            labelIssueDate.Location = new System.Drawing.Point(12, 85);
            labelIssueDate.Text = "Дата передачи";
            labelIssueDate.Name = "labelIssueDate";
            labelIssueDate.TabIndex = 4;
            //
            // dateTimePickerIssueDate
            //
            dateTimePickerIssueDate.Enabled = false;
            dateTimePickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerIssueDate.Location = new System.Drawing.Point(130, 82);
            dateTimePickerIssueDate.Size = new System.Drawing.Size(318, 23);
            dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            dateTimePickerIssueDate.TabIndex = 5;
            //
            // groupBoxMaterials
            //
            groupBoxMaterials.Location = new System.Drawing.Point(12, 120);
            groupBoxMaterials.Size = new System.Drawing.Size(436, 230);
            groupBoxMaterials.TabStop = false;
            groupBoxMaterials.Text = "Материалы";
            groupBoxMaterials.Name = "groupBoxMaterials";
            groupBoxMaterials.TabIndex = 6;
            groupBoxMaterials.Controls.Add(dataGridViewMaterials);
            //
            // dataGridViewMaterials
            //
            dataGridViewMaterials.AllowUserToResizeColumns = false;
            dataGridViewMaterials.AllowUserToResizeRows = false;
            dataGridViewMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewMaterials.Location = new System.Drawing.Point(3, 19);
            dataGridViewMaterials.MultiSelect = false;
            dataGridViewMaterials.RowHeadersVisible = false;
            dataGridViewMaterials.Size = new System.Drawing.Size(430, 208);
            dataGridViewMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnMaterial, ColumnCount });
            dataGridViewMaterials.Name = "dataGridViewMaterials";
            dataGridViewMaterials.TabIndex = 7;
            //
            // ColumnMaterial
            //
            ColumnMaterial.HeaderText = "Материал";
            ColumnMaterial.Name = "ColumnMaterial";
            ColumnCount.HeaderText = "Количество";
            ColumnCount.Name = "ColumnCount";
            //
            // buttonSave
            //
            buttonSave.Location = new System.Drawing.Point(238, 365);
            buttonSave.Size = new System.Drawing.Size(100, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Name = "buttonSave";
            buttonSave.TabIndex = 10;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new System.Drawing.Point(348, 365);
            buttonCancel.Size = new System.Drawing.Size(100, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.TabIndex = 11;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormProductionIssue
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 410);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProductionIssue";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Передача материалов в производство";
            Controls.Add(labelProduct);
            Controls.Add(comboBoxProduct);
            Controls.Add(labelWarehouse);
            Controls.Add(comboBoxWarehouse);
            Controls.Add(labelIssueDate);
            Controls.Add(dateTimePickerIssueDate);
            Controls.Add(groupBoxMaterials);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).EndInit();
            groupBoxMaterials.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.GroupBox groupBoxMaterials;
        private System.Windows.Forms.DataGridView dataGridViewMaterials;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
