namespace BD_Proj
{
    partial class Casas
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
            this.casas_listBox = new System.Windows.Forms.ListBox();
            this.add_bt = new System.Windows.Forms.Button();
            this.casas_dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.casas_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // casas_listBox
            // 
            this.casas_listBox.FormattingEnabled = true;
            this.casas_listBox.ItemHeight = 16;
            this.casas_listBox.Location = new System.Drawing.Point(22, 12);
            this.casas_listBox.Name = "casas_listBox";
            this.casas_listBox.Size = new System.Drawing.Size(201, 404);
            this.casas_listBox.TabIndex = 1;
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(713, 422);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(75, 23);
            this.add_bt.TabIndex = 3;
            this.add_bt.Text = "Add";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // casas_dataGrid
            // 
            this.casas_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casas_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.casas_dataGrid.MultiSelect = false;
            this.casas_dataGrid.Name = "casas_dataGrid";
            this.casas_dataGrid.ReadOnly = true;
            this.casas_dataGrid.RowHeadersWidth = 51;
            this.casas_dataGrid.RowTemplate.Height = 24;
            this.casas_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.casas_dataGrid.Size = new System.Drawing.Size(799, 416);
            this.casas_dataGrid.TabIndex = 11;
            // 
            // Casas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.casas_dataGrid);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.casas_listBox);
            this.Name = "Casas";
            this.Text = "Casas";
            ((System.ComponentModel.ISupportInitialize)(this.casas_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox casas_listBox;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.DataGridView casas_dataGrid;
    }
}