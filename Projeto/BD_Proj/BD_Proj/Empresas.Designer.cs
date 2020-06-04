namespace BD_Proj
{
    partial class Empresas
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
            this.empresas_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_bt = new System.Windows.Forms.Button();
            this.edit_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empresas_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empresas_dataGridView1
            // 
            this.empresas_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empresas_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresas_dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.empresas_dataGridView1.MultiSelect = false;
            this.empresas_dataGridView1.Name = "empresas_dataGridView1";
            this.empresas_dataGridView1.ReadOnly = true;
            this.empresas_dataGridView1.RowHeadersVisible = false;
            this.empresas_dataGridView1.RowHeadersWidth = 51;
            this.empresas_dataGridView1.RowTemplate.Height = 24;
            this.empresas_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresas_dataGridView1.Size = new System.Drawing.Size(631, 445);
            this.empresas_dataGridView1.TabIndex = 0;
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(702, 415);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(86, 23);
            this.add_bt.TabIndex = 1;
            this.add_bt.Text = "Adicionar";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(702, 376);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(86, 23);
            this.edit_bt.TabIndex = 2;
            this.edit_bt.Text = "Editar";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.empresas_dataGridView1);
            this.Name = "Empresas";
            this.Text = "Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.empresas_dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empresas_dataGridView1;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button edit_bt;
    }
}