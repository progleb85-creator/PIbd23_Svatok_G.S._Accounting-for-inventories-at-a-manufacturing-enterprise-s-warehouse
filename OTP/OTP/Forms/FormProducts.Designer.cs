namespace OTP.Forms
{
    partial class FormProducts
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
            dataGridViewData = new System.Windows.Forms.DataGridView();
            panelButtons = new System.Windows.Forms.Panel();
            buttonAdd = new System.Windows.Forms.Button();
            buttonUpd = new System.Windows.Forms.Button();
            buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            //
            // dataGridViewData
            //
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AllowUserToResizeColumns = false;
            dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewData.Location = new System.Drawing.Point(0, 0);
            dataGridViewData.MultiSelect = false;
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new System.Drawing.Size(680, 450);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.TabIndex = 0;
            //
            // panelButtons
            //
            panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            panelButtons.Location = new System.Drawing.Point(680, 0);
            panelButtons.Size = new System.Drawing.Size(120, 450);
            panelButtons.Name = "panelButtons";
            panelButtons.TabIndex = 1;
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Controls.Add(buttonUpd);
            panelButtons.Controls.Add(buttonDel);
            //
            // buttonAdd
            //
            buttonAdd.Location = new System.Drawing.Point(10, 10);
            buttonAdd.Size = new System.Drawing.Size(100, 40);
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.TabIndex = 2;
            buttonAdd.Click += ButtonAdd_Click;
            //
            // buttonUpd
            //
            buttonUpd.Location = new System.Drawing.Point(10, 60);
            buttonUpd.Size = new System.Drawing.Size(100, 40);
            buttonUpd.Text = "Изменить";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Name = "buttonUpd";
            buttonUpd.TabIndex = 3;
            buttonUpd.Click += ButtonUpd_Click;
            //
            // buttonDel
            //
            buttonDel.Location = new System.Drawing.Point(10, 110);
            buttonDel.Size = new System.Drawing.Size(100, 40);
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Name = "buttonDel";
            buttonDel.TabIndex = 4;
            buttonDel.Click += ButtonDel_Click;
            //
            // FormProducts
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Name = "FormProducts";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Продукция";
            Controls.Add(dataGridViewData);
            Controls.Add(panelButtons);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
            Load += FormProducts_Load;
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
    }
}
