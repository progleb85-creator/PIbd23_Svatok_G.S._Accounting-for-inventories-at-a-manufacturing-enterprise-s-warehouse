namespace OTP.Forms
{
    partial class Form1
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
            menuStripMain = new System.Windows.Forms.MenuStrip();
            directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            warehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            productionIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            defectReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            purchaseRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            //
            // menuStripMain
            //
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new System.Drawing.Size(800, 24);
            menuStripMain.TabIndex = 0;
            //
            // directoriesToolStripMenuItem
            //
            directoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { materialsToolStripMenuItem, productsToolStripMenuItem, warehousesToolStripMenuItem });
            directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            directoriesToolStripMenuItem.Text = "Справочники";
            //
            // materialsToolStripMenuItem
            //
            materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            materialsToolStripMenuItem.Text = "Материалы и комплектующие";
            materialsToolStripMenuItem.Click += MaterialsToolStripMenuItem_Click;
            //
            // productsToolStripMenuItem
            //
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Text = "Продукция";
            productsToolStripMenuItem.Click += ProductsToolStripMenuItem_Click;
            //
            // warehousesToolStripMenuItem
            //
            warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            warehousesToolStripMenuItem.Text = "Склады";
            warehousesToolStripMenuItem.Click += WarehousesToolStripMenuItem_Click;
            //
            // operationsToolStripMenuItem
            //
            operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { productionIssuesToolStripMenuItem, defectReturnsToolStripMenuItem, purchaseRequestsToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Text = "Операции";
            //
            // productionIssuesToolStripMenuItem
            //
            productionIssuesToolStripMenuItem.Name = "productionIssuesToolStripMenuItem";
            productionIssuesToolStripMenuItem.Text = "Передача в производство";
            productionIssuesToolStripMenuItem.Click += ProductionIssuesToolStripMenuItem_Click;
            //
            // defectReturnsToolStripMenuItem
            //
            defectReturnsToolStripMenuItem.Name = "defectReturnsToolStripMenuItem";
            defectReturnsToolStripMenuItem.Text = "Возврат брака";
            defectReturnsToolStripMenuItem.Click += DefectReturnsToolStripMenuItem_Click;
            //
            // purchaseRequestsToolStripMenuItem
            //
            purchaseRequestsToolStripMenuItem.Name = "purchaseRequestsToolStripMenuItem";
            purchaseRequestsToolStripMenuItem.Text = "Заявки на закупку";
            purchaseRequestsToolStripMenuItem.Click += PurchaseRequestsToolStripMenuItem_Click;
            //
            // reportsToolStripMenuItem
            //
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Text = "Отчеты";
            //
            // Form1
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
