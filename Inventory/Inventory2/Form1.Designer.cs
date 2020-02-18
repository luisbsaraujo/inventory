namespace Inventory2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.qtySoldBox = new System.Windows.Forms.TextBox();
            this.qtySoldLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qtyRestockedBox = new System.Windows.Forms.TextBox();
            this.loadInventoryDataButton = new System.Windows.Forms.Button();
            this.updateSoldQtyButton = new System.Windows.Forms.Button();
            this.deleteSelectedInventoryItemButton = new System.Windows.Forms.Button();
            this.updateRestockedQtySelectedItemButton = new System.Windows.Forms.Button();
            this.saveInventoryDataButton = new System.Windows.Forms.Button();
            this.saveSalesReportButton = new System.Windows.Forms.Button();
            this.saveRestockNeedsReportButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 15;
            this.inventoryListBox.Location = new System.Drawing.Point(31, 48);
            this.inventoryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(893, 184);
            this.inventoryListBox.TabIndex = 0;
            // 
            // qtySoldBox
            // 
            this.qtySoldBox.Location = new System.Drawing.Point(106, 246);
            this.qtySoldBox.Margin = new System.Windows.Forms.Padding(2);
            this.qtySoldBox.Name = "qtySoldBox";
            this.qtySoldBox.Size = new System.Drawing.Size(37, 20);
            this.qtySoldBox.TabIndex = 1;
            // 
            // qtySoldLabel
            // 
            this.qtySoldLabel.AutoSize = true;
            this.qtySoldLabel.Location = new System.Drawing.Point(32, 249);
            this.qtySoldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtySoldLabel.Name = "qtySoldLabel";
            this.qtySoldLabel.Size = new System.Drawing.Size(70, 13);
            this.qtySoldLabel.TabIndex = 2;
            this.qtySoldLabel.Text = "Quantity Sold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity Restocked";
            // 
            // qtyRestockedBox
            // 
            this.qtyRestockedBox.Location = new System.Drawing.Point(250, 246);
            this.qtyRestockedBox.Margin = new System.Windows.Forms.Padding(2);
            this.qtyRestockedBox.Name = "qtyRestockedBox";
            this.qtyRestockedBox.Size = new System.Drawing.Size(37, 20);
            this.qtyRestockedBox.TabIndex = 3;
            // 
            // loadInventoryDataButton
            // 
            this.loadInventoryDataButton.Location = new System.Drawing.Point(38, 280);
            this.loadInventoryDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadInventoryDataButton.Name = "loadInventoryDataButton";
            this.loadInventoryDataButton.Size = new System.Drawing.Size(69, 50);
            this.loadInventoryDataButton.TabIndex = 5;
            this.loadInventoryDataButton.Text = "Load Inventory Data";
            this.loadInventoryDataButton.UseVisualStyleBackColor = true;
            this.loadInventoryDataButton.Click += new System.EventHandler(this.loadInventoryDataButton_Click);
            // 
            // updateSoldQtyButton
            // 
            this.updateSoldQtyButton.Location = new System.Drawing.Point(199, 280);
            this.updateSoldQtyButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateSoldQtyButton.Name = "updateSoldQtyButton";
            this.updateSoldQtyButton.Size = new System.Drawing.Size(83, 50);
            this.updateSoldQtyButton.TabIndex = 6;
            this.updateSoldQtyButton.Text = "Update Sold Qty for selected Item";
            this.updateSoldQtyButton.UseVisualStyleBackColor = true;
            this.updateSoldQtyButton.Click += new System.EventHandler(this.updateSoldQtyButton_Click);
            // 
            // deleteSelectedInventoryItemButton
            // 
            this.deleteSelectedInventoryItemButton.Location = new System.Drawing.Point(111, 280);
            this.deleteSelectedInventoryItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSelectedInventoryItemButton.Name = "deleteSelectedInventoryItemButton";
            this.deleteSelectedInventoryItemButton.Size = new System.Drawing.Size(83, 50);
            this.deleteSelectedInventoryItemButton.TabIndex = 7;
            this.deleteSelectedInventoryItemButton.Text = "Delete Selected Inventory Item";
            this.deleteSelectedInventoryItemButton.UseVisualStyleBackColor = true;
            this.deleteSelectedInventoryItemButton.Click += new System.EventHandler(this.deleteSelectedInventoryItemButton_Click);
            // 
            // updateRestockedQtySelectedItemButton
            // 
            this.updateRestockedQtySelectedItemButton.Location = new System.Drawing.Point(286, 280);
            this.updateRestockedQtySelectedItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateRestockedQtySelectedItemButton.Name = "updateRestockedQtySelectedItemButton";
            this.updateRestockedQtySelectedItemButton.Size = new System.Drawing.Size(96, 50);
            this.updateRestockedQtySelectedItemButton.TabIndex = 8;
            this.updateRestockedQtySelectedItemButton.Text = "Update Restocked Qty for Selected Item";
            this.updateRestockedQtySelectedItemButton.UseVisualStyleBackColor = true;
            this.updateRestockedQtySelectedItemButton.Click += new System.EventHandler(this.updateRestockedQtySelectedItemButton_Click);
            // 
            // saveInventoryDataButton
            // 
            this.saveInventoryDataButton.Location = new System.Drawing.Point(483, 249);
            this.saveInventoryDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveInventoryDataButton.Name = "saveInventoryDataButton";
            this.saveInventoryDataButton.Size = new System.Drawing.Size(96, 39);
            this.saveInventoryDataButton.TabIndex = 9;
            this.saveInventoryDataButton.Text = "Save Inventory Data";
            this.saveInventoryDataButton.UseVisualStyleBackColor = true;
            this.saveInventoryDataButton.Click += new System.EventHandler(this.saveInventoryDataButton_Click);
            // 
            // saveSalesReportButton
            // 
            this.saveSalesReportButton.Location = new System.Drawing.Point(483, 291);
            this.saveSalesReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveSalesReportButton.Name = "saveSalesReportButton";
            this.saveSalesReportButton.Size = new System.Drawing.Size(96, 39);
            this.saveSalesReportButton.TabIndex = 10;
            this.saveSalesReportButton.Text = "Save Sales Report";
            this.saveSalesReportButton.UseVisualStyleBackColor = true;
            this.saveSalesReportButton.Click += new System.EventHandler(this.saveSalesReportButton_Click);
            // 
            // saveRestockNeedsReportButton
            // 
            this.saveRestockNeedsReportButton.Location = new System.Drawing.Point(483, 335);
            this.saveRestockNeedsReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveRestockNeedsReportButton.Name = "saveRestockNeedsReportButton";
            this.saveRestockNeedsReportButton.Size = new System.Drawing.Size(96, 39);
            this.saveRestockNeedsReportButton.TabIndex = 11;
            this.saveRestockNeedsReportButton.Text = "Save Restock Needs Report";
            this.saveRestockNeedsReportButton.UseVisualStyleBackColor = true;
            this.saveRestockNeedsReportButton.Click += new System.EventHandler(this.saveRestockNeedsReportButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusLabel.Location = new System.Drawing.Point(45, 335);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(337, 59);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Operation Status Displayed Here";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(353, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 24);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Inventory Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 399);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.saveRestockNeedsReportButton);
            this.Controls.Add(this.saveSalesReportButton);
            this.Controls.Add(this.saveInventoryDataButton);
            this.Controls.Add(this.updateRestockedQtySelectedItemButton);
            this.Controls.Add(this.deleteSelectedInventoryItemButton);
            this.Controls.Add(this.updateSoldQtyButton);
            this.Controls.Add(this.loadInventoryDataButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtyRestockedBox);
            this.Controls.Add(this.qtySoldLabel);
            this.Controls.Add(this.qtySoldBox);
            this.Controls.Add(this.inventoryListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.TextBox qtySoldBox;
        private System.Windows.Forms.Label qtySoldLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtyRestockedBox;
        private System.Windows.Forms.Button loadInventoryDataButton;
        private System.Windows.Forms.Button updateSoldQtyButton;
        private System.Windows.Forms.Button deleteSelectedInventoryItemButton;
        private System.Windows.Forms.Button updateRestockedQtySelectedItemButton;
        private System.Windows.Forms.Button saveInventoryDataButton;
        private System.Windows.Forms.Button saveSalesReportButton;
        private System.Windows.Forms.Button saveRestockNeedsReportButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

