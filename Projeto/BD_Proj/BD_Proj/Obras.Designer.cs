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
            ((System.ComponentModel.ISupportInitialize)(this.obras_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // obras_dataGridView1
            // 
            this.obras_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obras_dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.obras_dataGridView1.Name = "obras_dataGridView1";
            this.obras_dataGridView1.RowHeadersWidth = 51;
            this.obras_dataGridView1.RowTemplate.Height = 24;
            this.obras_dataGridView1.Size = new System.Drawing.Size(469, 448);
            this.obras_dataGridView1.TabIndex = 0;
            // 
            // Obras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.obras_dataGridView1);
            this.Name = "Obras";
            this.Text = "Obras";
            ((System.ComponentModel.ISupportInitialize)(this.obras_dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView obras_dataGridView1;
    }
}