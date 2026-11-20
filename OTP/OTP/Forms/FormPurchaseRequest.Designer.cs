namespace OTP.Forms
{
    partial class FormPurchaseRequest
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
            labelCount = new System.Windows.Forms.Label();
            numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            labelRequestDate = new System.Windows.Forms.Label();
            dateTimePickerRequestDate = new System.Windows.Forms.DateTimePicker();
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
            // labelCount
            //
            labelCount.AutoSize = true;
            labelCount.Location = new System.Drawing.Point(12, 50);
            labelCount.Text = "Количество в партии";
            labelCount.Name = "labelCount";
            labelCount.TabIndex = 2;
            //
            // numericUpDownCount
            //
            numericUpDownCount.Location = new System.Drawing.Point(130, 47);
            numericUpDownCount.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            numericUpDownCount.Minimum = new decimal(new int[] {1, 0, 0, 0});
            numericUpDownCount.Size = new System.Drawing.Size(250, 23);
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.TabIndex = 3;
            //
            // labelRequestDate
            //
            labelRequestDate.AutoSize = true;
            labelRequestDate.Location = new System.Drawing.Point(12, 85);
            labelRequestDate.Text = "Дата заявки";
            labelRequestDate.Name = "labelRequestDate";
            labelRequestDate.TabIndex = 4;
            //
            // dateTimePickerRequestDate
            //
            dateTimePickerRequestDate.Enabled = false;
            dateTimePickerRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerRequestDate.Location = new System.Drawing.Point(130, 82);
            dateTimePickerRequestDate.Size = new System.Drawing.Size(250, 23);
            dateTimePickerRequestDate.Name = "dateTimePickerRequestDate";
            dateTimePickerRequestDate.TabIndex = 5;
            //
            // buttonSave
            //
            buttonSave.Location = new System.Drawing.Point(170, 130);
            buttonSave.Size = new System.Drawing.Size(100, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Name = "buttonSave";
            buttonSave.TabIndex = 6;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new System.Drawing.Point(280, 130);
            buttonCancel.Size = new System.Drawing.Size(100, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.TabIndex = 7;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormPurchaseRequest
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 175);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPurchaseRequest";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Заявка на закупку";
            Controls.Add(labelMaterial);
            Controls.Add(comboBoxMaterial);
            Controls.Add(labelCount);
            Controls.Add(numericUpDownCount);
            Controls.Add(labelRequestDate);
            Controls.Add(dateTimePickerRequestDate);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelRequestDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequestDate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
