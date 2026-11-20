namespace OTP.Forms
{
    partial class FormWarehouse
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
            labelAddress = new System.Windows.Forms.Label();
            textBoxAddress = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
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
            textBoxName.Location = new System.Drawing.Point(110, 12);
            textBoxName.Size = new System.Drawing.Size(300, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.TabIndex = 1;
            //
            // labelAddress
            //
            labelAddress.AutoSize = true;
            labelAddress.Location = new System.Drawing.Point(12, 50);
            labelAddress.Text = "Адрес";
            labelAddress.Name = "labelAddress";
            labelAddress.TabIndex = 2;
            //
            // textBoxAddress
            //
            textBoxAddress.Location = new System.Drawing.Point(110, 47);
            textBoxAddress.Size = new System.Drawing.Size(300, 23);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.TabIndex = 3;
            //
            // buttonSave
            //
            buttonSave.Location = new System.Drawing.Point(200, 95);
            buttonSave.Size = new System.Drawing.Size(100, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Name = "buttonSave";
            buttonSave.TabIndex = 4;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new System.Drawing.Point(310, 95);
            buttonCancel.Size = new System.Drawing.Size(100, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.TabIndex = 5;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormWarehouse
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 140);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormWarehouse";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Склад";
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
