using System;
using System.Windows.Forms;

namespace BD_Proj
{
    partial class Contratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contratos));
            this.pessoa_bt = new System.Windows.Forms.Button();
            this.pessoa_dataGrid = new System.Windows.Forms.DataGridView();
            this.rendas = new System.Windows.Forms.Button();
            this.cnodos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pessoa_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoa_bt
            // 
            this.pessoa_bt.Location = new System.Drawing.Point(939, 399);
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
            this.pessoa_dataGrid.Location = new System.Drawing.Point(280, 1);
            this.pessoa_dataGrid.MultiSelect = false;
            this.pessoa_dataGrid.Name = "pessoa_dataGrid";
            this.pessoa_dataGrid.ReadOnly = true;
            this.pessoa_dataGrid.RowHeadersVisible = false;
            this.pessoa_dataGrid.RowHeadersWidth = 51;
            this.pessoa_dataGrid.RowTemplate.Height = 24;
            this.pessoa_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pessoa_dataGrid.Size = new System.Drawing.Size(581, 371);
            this.pessoa_dataGrid.TabIndex = 11;
            this.pessoa_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pessoa_dataGrid_CellContentClick);
            // 
            // rendas
            // 
            this.rendas.Location = new System.Drawing.Point(893, 83);
            this.rendas.Name = "rendas";
            this.rendas.Size = new System.Drawing.Size(111, 67);
            this.rendas.TabIndex = 12;
            this.rendas.Text = "Contratos de Renda";
            this.rendas.UseVisualStyleBackColor = true;
            this.rendas.Click += new System.EventHandler(this.rendas_Click);
            // 
            // cnodos
            // 
            this.cnodos.Location = new System.Drawing.Point(893, 180);
            this.cnodos.Name = "cnodos";
            this.cnodos.Size = new System.Drawing.Size(111, 67);
            this.cnodos.TabIndex = 13;
            this.cnodos.Text = "Contratos de Condomínio";
            this.cnodos.UseVisualStyleBackColor = true;
            this.cnodos.Click += new System.EventHandler(this.cnodos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 224);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pessoa_textBox
            // 
            this.pessoa_textBox.Location = new System.Drawing.Point(553, 402);
            this.pessoa_textBox.Name = "pessoa_textBox";
            this.pessoa_textBox.Size = new System.Drawing.Size(138, 22);
            this.pessoa_textBox.TabIndex = 15;
            this.pessoa_textBox.TextChanged += new System.EventHandler(this.pessoa_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pesquisar Pessoa:";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(858, 399);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 18;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Contratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pessoa_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cnodos);
            this.Controls.Add(this.rendas);
            this.Controls.Add(this.pessoa_dataGrid);
            this.Controls.Add(this.pessoa_bt);
            this.Name = "Contratos";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.DadosPessoais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pessoa_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Button pessoa_bt;
        private System.Windows.Forms.DataGridView pessoa_dataGrid;
        private Button rendas;
        private Button cnodos;
        private PictureBox pictureBox1;
        private TextBox pessoa_textBox;
        private Label label1;
        private Button delete_button;
    }
}