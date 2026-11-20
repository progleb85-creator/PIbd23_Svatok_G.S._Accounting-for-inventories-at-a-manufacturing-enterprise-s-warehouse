namespace OTP.Forms
{
    partial class FormMain
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
            menuStripMain = new MenuStrip();
            directoriesToolStripMenuItem = new ToolStripMenuItem();
            materialsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            warehousesToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            productionIssuesToolStripMenuItem = new ToolStripMenuItem();
            defectReturnsToolStripMenuItem = new ToolStripMenuItem();
            purchaseRequestsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 24);
            menuStripMain.TabIndex = 0;
            // 
            // directoriesToolStripMenuItem
            // 
            directoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { materialsToolStripMenuItem, productsToolStripMenuItem, warehousesToolStripMenuItem });
            directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            directoriesToolStripMenuItem.Size = new Size(94, 20);
            directoriesToolStripMenuItem.Text = "Справочники";
            // 
            // materialsToolStripMenuItem
            // 
            materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            materialsToolStripMenuItem.Size = new Size(244, 22);
            materialsToolStripMenuItem.Text = "Материалы и комплектующие";
            materialsToolStripMenuItem.Click += MaterialsToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(244, 22);
            productsToolStripMenuItem.Text = "Продукция";
            productsToolStripMenuItem.Click += ProductsToolStripMenuItem_Click;
            // 
            // warehousesToolStripMenuItem
            // 
            warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            warehousesToolStripMenuItem.Size = new Size(244, 22);
            warehousesToolStripMenuItem.Text = "Склады";
            warehousesToolStripMenuItem.Click += WarehousesToolStripMenuItem_Click;
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productionIssuesToolStripMenuItem, defectReturnsToolStripMenuItem, purchaseRequestsToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(75, 20);
            operationsToolStripMenuItem.Text = "Операции";
            // 
            // productionIssuesToolStripMenuItem
            // 
            productionIssuesToolStripMenuItem.Name = "productionIssuesToolStripMenuItem";
            productionIssuesToolStripMenuItem.Size = new Size(215, 22);
            productionIssuesToolStripMenuItem.Text = "Передача в производство";
            productionIssuesToolStripMenuItem.Click += ProductionIssuesToolStripMenuItem_Click;
            // 
            // defectReturnsToolStripMenuItem
            // 
            defectReturnsToolStripMenuItem.Name = "defectReturnsToolStripMenuItem";
            defectReturnsToolStripMenuItem.Size = new Size(215, 22);
            defectReturnsToolStripMenuItem.Text = "Возврат брака";
            defectReturnsToolStripMenuItem.Click += DefectReturnsToolStripMenuItem_Click;
            // 
            // purchaseRequestsToolStripMenuItem
            // 
            purchaseRequestsToolStripMenuItem.Name = "purchaseRequestsToolStripMenuItem";
            purchaseRequestsToolStripMenuItem.Size = new Size(215, 22);
            purchaseRequestsToolStripMenuItem.Text = "Заявки на закупку";
            purchaseRequestsToolStripMenuItem.Click += PurchaseRequestsToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(60, 20);
            reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.b120e9f9_a1c5_4044_a0e3_8168ec75d463;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет материальных запасов на складе";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defectReturnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}
