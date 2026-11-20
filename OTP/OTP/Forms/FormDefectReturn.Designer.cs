namespace OTP.Forms
{
    partial class FormDefectReturn
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
            labelMaterial = new System.Windows.Forms.Label();
            comboBoxMaterial = new System.Windows.Forms.ComboBox();
            labelWarehouse = new System.Windows.Forms.Label();
            comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            labelCount = new System.Windows.Forms.Label();
            numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            labelReturnDate = new System.Windows.Forms.Label();
            dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            SuspendLayout();
            //
            // labelMaterial
            //
            labelMaterial.AutoSize = true;
            labelMaterial.Location = new System.Drawing.Point(12, 15);
            labelMaterial.Text = "Материал";
            labelMaterial.Name = "labelMaterial";
            labelMaterial.TabIndex = 0;
            //
            // comboBoxMaterial
            //
            comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMaterial.FormattingEnabled = true;
            comboBoxMaterial.Location = new System.Drawing.Point(130, 12);
            comboBoxMaterial.Size = new System.Drawing.Size(250, 23);
            comboBoxMaterial.Name = "comboBoxMaterial";
            comboBoxMaterial.TabIndex = 1;
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
            comboBoxWarehouse.Size = new System.Drawing.Size(250, 23);
            comboBoxWarehouse.Name = "comboBoxWarehouse";
            comboBoxWarehouse.TabIndex = 3;
            //
            // labelCount
            //
            labelCount.AutoSize = true;
            labelCount.Location = new System.Drawing.Point(12, 85);
            labelCount.Text = "Количество брака";
            labelCount.Name = "labelCount";
            labelCount.TabIndex = 4;
            //
            // numericUpDownCount
            //
            numericUpDownCount.Location = new System.Drawing.Point(130, 82);
            numericUpDownCount.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            numericUpDownCount.Minimum = new decimal(new int[] {1, 0, 0, 0});
            numericUpDownCount.Size = new System.Drawing.Size(250, 23);
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.TabIndex = 5;
            //
            // labelReturnDate
            //
            labelReturnDate.AutoSize = true;
            labelReturnDate.Location = new System.Drawing.Point(12, 120);
            labelReturnDate.Text = "Дата возврата";
            labelReturnDate.Name = "labelReturnDate";
            labelReturnDate.TabIndex = 6;
            //
            // dateTimePickerReturnDate
            //
            dateTimePickerReturnDate.Enabled = false;
            dateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerReturnDate.Location = new System.Drawing.Point(130, 117);
            dateTimePickerReturnDate.Size = new System.Drawing.Size(250, 23);
            dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            dateTimePickerReturnDate.TabIndex = 7;
            //
            // buttonSave
            //
            buttonSave.Location = new System.Drawing.Point(170, 165);
            buttonSave.Size = new System.Drawing.Size(100, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Name = "buttonSave";
            buttonSave.TabIndex = 8;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new System.Drawing.Point(280, 165);
            buttonCancel.Size = new System.Drawing.Size(100, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.TabIndex = 9;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormDefectReturn
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 210);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDefectReturn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Возврат брака на склад";
            Controls.Add(labelMaterial);
            Controls.Add(comboBoxMaterial);
            Controls.Add(labelWarehouse);
            Controls.Add(comboBoxWarehouse);
            Controls.Add(labelCount);
            Controls.Add(numericUpDownCount);
            Controls.Add(labelReturnDate);
            Controls.Add(dateTimePickerReturnDate);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
