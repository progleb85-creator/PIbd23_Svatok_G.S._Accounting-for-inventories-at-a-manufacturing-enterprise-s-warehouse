namespace OTP.Forms
{
    partial class FormProduct
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
            labelArticle = new System.Windows.Forms.Label();
            textBoxArticle = new System.Windows.Forms.TextBox();
            labelDescription = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
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
            // labelArticle
            //
            labelArticle.AutoSize = true;
            labelArticle.Location = new System.Drawing.Point(12, 50);
            labelArticle.Text = "Артикул";
            labelArticle.Name = "labelArticle";
            labelArticle.TabIndex = 2;
            //
            // textBoxArticle
            //
            textBoxArticle.Location = new System.Drawing.Point(110, 47);
            textBoxArticle.Size = new System.Drawing.Size(300, 23);
            textBoxArticle.Name = "textBoxArticle";
            textBoxArticle.TabIndex = 3;
            //
            // labelDescription
            //
            labelDescription.AutoSize = true;
            labelDescription.Location = new System.Drawing.Point(12, 85);
            labelDescription.Text = "Описание";
            labelDescription.Name = "labelDescription";
            labelDescription.TabIndex = 4;
            //
            // textBoxDescription
            //
            textBoxDescription.Location = new System.Drawing.Point(110, 82);
            textBoxDescription.Size = new System.Drawing.Size(300, 90);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.TabIndex = 5;
            //
            // buttonSave
            //
            buttonSave.Location = new System.Drawing.Point(200, 190);
            buttonSave.Size = new System.Drawing.Size(100, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Name = "buttonSave";
            buttonSave.TabIndex = 6;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new System.Drawing.Point(310, 190);
            buttonCancel.Size = new System.Drawing.Size(100, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.TabIndex = 7;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormProduct
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Продукция";
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelArticle);
            Controls.Add(textBoxArticle);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
