namespace BD_Proj
{
    partial class Condominios
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
            this.cond_dataGridView = new System.Windows.Forms.DataGridView();
            this.edit_bt = new System.Windows.Forms.Button();
            this.add_cond_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cond_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cond_dataGridView
            // 
            this.cond_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.cond_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cond_dataGridView.ColumnHeadersHeight = 29;
            this.cond_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.cond_dataGridView.Name = "cond_dataGridView";
            this.cond_dataGridView.RowHeadersVisible = false;
            this.cond_dataGridView.RowHeadersWidth = 51;
            this.cond_dataGridView.RowTemplate.Height = 24;
            this.cond_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cond_dataGridView.Size = new System.Drawing.Size(364, 453);
            this.cond_dataGridView.TabIndex = 0;
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(552, 400);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(123, 48);
            this.edit_bt.TabIndex = 1;
            this.edit_bt.Text = "Mudar gerente";
            this.edit_bt.UseVisualStyleBackColor = true;
            // 
            // add_cond_bt
            // 
            this.add_cond_bt.Location = new System.Drawing.Point(690, 400);
            this.add_cond_bt.Name = "add_cond_bt";
            this.add_cond_bt.Size = new System.Drawing.Size(105, 48);
            this.add_cond_bt.TabIndex = 2;
            this.add_cond_bt.Text = "Adicionar";
            this.add_cond_bt.UseVisualStyleBackColor = true;
            this.add_cond_bt.Click += new System.EventHandler(this.add_cond_bt_Click);
            // 
            // Condominios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_cond_bt);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.cond_dataGridView);
            this.Name = "Condominios";
            this.Text = "Condominios";
            ((System.ComponentModel.ISupportInitialize)(this.cond_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cond_dataGridView;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.Button add_cond_bt;
    }
}