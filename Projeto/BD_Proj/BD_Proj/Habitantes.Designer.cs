using System;
using System.Windows.Forms;

namespace BD_Proj
{
    partial class Habitantes
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
            this.pessoas_listBox = new System.Windows.Forms.ListBox();
            this.pessoa_bt = new System.Windows.Forms.Button();
            this.pessoa_dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoas_listBox
            // 
            this.pessoas_listBox.FormattingEnabled = true;
            this.pessoas_listBox.ItemHeight = 16;
            this.pessoas_listBox.Location = new System.Drawing.Point(22, 12);
            this.pessoas_listBox.Name = "pessoas_listBox";
            this.pessoas_listBox.Size = new System.Drawing.Size(201, 404);
            this.pessoas_listBox.TabIndex = 1;
            // 
            // pessoa_bt
            // 
            this.pessoa_bt.Location = new System.Drawing.Point(713, 422);
            this.pessoa_bt.Name = "pessoa_bt";
            this.pessoa_bt.Size = new System.Drawing.Size(75, 23);
            this.pessoa_bt.TabIndex = 3;
            this.pessoa_bt.Text = "Add";
            this.pessoa_bt.UseVisualStyleBackColor = true;
            this.pessoa_bt.Click += new System.EventHandler(this.pessoa_bt_Click);
            // 
            // pessoa_dataGrid
            // 
            this.pessoa_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoa_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.pessoa_dataGrid.MultiSelect = false;
            this.pessoa_dataGrid.Name = "pessoa_dataGrid";
            this.pessoa_dataGrid.ReadOnly = true;
            this.pessoa_dataGrid.RowHeadersVisible = false;
            this.pessoa_dataGrid.RowHeadersWidth = 51;
            this.pessoa_dataGrid.RowTemplate.Height = 24;
            this.pessoa_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pessoa_dataGrid.Size = new System.Drawing.Size(667, 445);
            this.pessoa_dataGrid.TabIndex = 11;
            this.pessoa_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pessoa_dataGrid_CellContentClick);
            // 
            // Habitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pessoa_dataGrid);
            this.Controls.Add(this.pessoa_bt);
            this.Controls.Add(this.pessoas_listBox);
            this.Name = "Habitantes";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.DadosPessoais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private void pessoa_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ListBox pessoas_listBox;
        private System.Windows.Forms.Button pessoa_bt;
        private System.Windows.Forms.DataGridView pessoa_dataGrid;
    }
}