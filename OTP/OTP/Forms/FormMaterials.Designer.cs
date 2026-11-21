namespace OTP.Forms
{
    partial class FormMaterials
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
            dataGridViewData = new DataGridView();
            panelButtons = new Panel();
            buttonAdd = new Button();
            buttonUpd = new Button();
            buttonDel = new Button();
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
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.MultiSelect = false;
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new Size(680, 450);
            dataGridViewData.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Controls.Add(buttonUpd);
            panelButtons.Controls.Add(buttonDel);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(680, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(120, 450);
            panelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources._25340;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(10, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 80);
            buttonAdd.TabIndex = 2;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.BackgroundImage = Properties.Resources.images;
            buttonUpd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUpd.Location = new Point(10, 105);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(98, 90);
            buttonUpd.TabIndex = 3;
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += ButtonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = Properties.Resources.minus_sign;
            buttonDel.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDel.Location = new Point(10, 214);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(100, 87);
            buttonDel.TabIndex = 4;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // FormMaterials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewData);
            Controls.Add(panelButtons);
            Name = "FormMaterials";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Материалы и комплектующие";
            Load += FormMaterials_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
    }
}
