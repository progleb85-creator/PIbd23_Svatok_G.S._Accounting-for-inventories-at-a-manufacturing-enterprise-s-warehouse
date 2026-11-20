namespace OTP.Forms
{
    partial class FormMaterial
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
            labelName = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            labelMaterialType = new System.Windows.Forms.Label();
            comboBoxMaterialType = new System.Windows.Forms.ComboBox();
            labelUnit = new System.Windows.Forms.Label();
            textBoxUnit = new System.Windows.Forms.TextBox();
            labelMinimumStock = new System.Windows.Forms.Label();
            numericUpDownMinimumStock = new System.Windows.Forms.NumericUpDown();
            labelStorageCondition = new System.Windows.Forms.Label();
            checkedListBoxStorageCondition = new System.Windows.Forms.CheckedListBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinimumStock).BeginInit();
            SuspendLayout();
            //
            // labelName
            //
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(12, 15);
            labelName.Text = "Название";
            labelName.Name = "labelName";
            labelName.TabIndex = 0;
            //
            // textBoxName
            //
            textBoxName.Location = new System.Drawing.Point(190, 12);
            textBoxName.Size = new System.Drawing.Size(220, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.TabIndex = 1;
            //
            // labelMaterialType
            //
            labelMaterialType.AutoSize = true;
            labelMaterialType.Location = new System.Drawing.Point(12, 50);
            labelMaterialType.Text = "Тип";
            labelMaterialType.Name = "labelMaterialType";
            labelMaterialType.TabIndex = 2;
            //
            // comboBoxMaterialType
            //
            comboBoxMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMaterialType.FormattingEnabled = true;
            comboBoxMaterialType.Location = new System.Drawing.Point(190, 47);
            comboBoxMaterialType.Size = new System.Drawing.Size(220, 23);
            comboBoxMaterialType.Name = "comboBoxMaterialType";
            comboBoxMaterialType.TabIndex = 3;
            //
            // labelUnit
            //
            labelUnit.AutoSize = true;
            labelUnit.Location = new System.Drawing.Point(12, 85);
            labelUnit.Text = "Единица измерения";
            labelUnit.Name = "labelUnit";
            labelUnit.TabIndex = 4;
            //
            // textBoxUni
            //
            textBoxUnit.Location = new System.Drawing.Point(190, 82);
            textBoxUnit.Size = new System.Drawing.Size(220, 23);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.TabIndex = 5;
            //
            // labelMinimumStock
            //
            labelMinimumStock.AutoSize = true;
            labelMinimumStock.Location = new System.Drawing.Point(12, 120);
            labelMinimumStock.Text = "Минимальный остаток";
            labelMinimumStock.Name = "labelMinimumStock";
            labelMinimumStock.TabIndex = 6;
            //
            // numericUpDownMinimumStock
            //
            numericUpDownMinimumStock.Location = new System.Drawing.Point(190, 117);
            numericUpDownMinimumStock.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            numericUpDownMinimumStock.Minimum = new decimal(new int[] {0, 0, 0, 0});
            numericUpDownMinimumStock.Size = new System.Drawing.Size(220, 23);
            numericUpDownMinimumStock.Name = "numericUpDownMinimumStock";
            numericUpDownMinimumStock.TabIndex = 7;
            //
            // labelStorageCondition
            //
            labelStorageCondition.AutoSize = true;
            labelStorageCondition.Location = new System.Drawing.Point(12, 155);
            labelStorageCondition.Text = "Условия хранения";
            labelStorageCondition.Name = "labelStorageCondition";
            labelStorageCondition.TabIndex = 8;
            //
            // checkedListBoxStorageCondition
            //
            checkedListBoxStorageCondition.CheckOnClick = true;
            checkedListBoxStorageCondition.FormattingEnabled = true;
            checkedListBoxStorageCondition.Location = new System.Drawing.Point(190, 152);
            checkedListBoxStorageCondition.Size = new System.Drawing.Size(220, 94);
            checkedListBoxStorageCondition.Name = "checkedListBoxStorageCondition";
            checkedListBoxStorageCondition.TabIndex = 9;
            //
            // buttonSave
            //
            buttonSave.Location = new System.Drawing.Point(190, 262);
            buttonSave.Size = new System.Drawing.Size(105, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Name = "buttonSave";
            buttonSave.TabIndex = 10;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new System.Drawing.Point(305, 262);
            buttonCancel.Size = new System.Drawing.Size(105, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.TabIndex = 11;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormMaterial
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 310);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMaterial";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Материал";
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelMaterialType);
            Controls.Add(comboBoxMaterialType);
            Controls.Add(labelUnit);
            Controls.Add(textBoxUnit);
            Controls.Add(labelMinimumStock);
            Controls.Add(numericUpDownMinimumStock);
            Controls.Add(labelStorageCondition);
            Controls.Add(checkedListBoxStorageCondition);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinimumStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMaterialType;
        private System.Windows.Forms.ComboBox comboBoxMaterialType;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelMinimumStock;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimumStock;
        private System.Windows.Forms.Label labelStorageCondition;
        private System.Windows.Forms.CheckedListBox checkedListBoxStorageCondition;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
