namespace BD_Proj
{
    partial class Obras
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
            this.obras_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_bt = new System.Windows.Forms.Button();
            this.edit_bt = new System.Windows.Forms.Button();
            this.gastoT_label = new System.Windows.Forms.Label();
            this.valor_gastoT_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obras_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // obras_dataGridView1
            // 
            this.obras_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obras_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obras_dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.obras_dataGridView1.MultiSelect = false;
            this.obras_dataGridView1.Name = "obras_dataGridView1";
            this.obras_dataGridView1.ReadOnly = true;
            this.obras_dataGridView1.RowHeadersVisible = false;
            this.obras_dataGridView1.RowHeadersWidth = 51;
            this.obras_dataGridView1.RowTemplate.Height = 24;
            this.obras_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.obras_dataGridView1.Size = new System.Drawing.Size(590, 450);
            this.obras_dataGridView1.TabIndex = 0;
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(696, 415);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(92, 23);
            this.add_bt.TabIndex = 1;
            this.add_bt.Text = "Adicionar";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(696, 376);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(92, 23);
            this.edit_bt.TabIndex = 2;
            this.edit_bt.Text = "Editar";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // gastoT_label
            // 
            this.gastoT_label.AutoSize = true;
            this.gastoT_label.Location = new System.Drawing.Point(605, 24);
            this.gastoT_label.Name = "gastoT_label";
            this.gastoT_label.Size = new System.Drawing.Size(81, 17);
            this.gastoT_label.TabIndex = 3;
            this.gastoT_label.Text = "Gasto total:";
            // 
            // valor_gastoT_label
            // 
            this.valor_gastoT_label.AutoSize = true;
            this.valor_gastoT_label.Location = new System.Drawing.Point(696, 24);
            this.valor_gastoT_label.Name = "valor_gastoT_label";
            this.valor_gastoT_label.Size = new System.Drawing.Size(46, 17);
            this.valor_gastoT_label.TabIndex = 4;
            this.valor_gastoT_label.Text = "label1";
            // 
            // Obras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valor_gastoT_label);
            this.Controls.Add(this.gastoT_label);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.obras_dataGridView1);
            this.Name = "Obras";
            this.Text = "Obras";
            ((System.ComponentModel.ISupportInitialize)(this.obras_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView obras_dataGridView1;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.Label gastoT_label;
        private System.Windows.Forms.Label valor_gastoT_label;
    }
}