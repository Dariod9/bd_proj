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
            this.view_contratos_label = new System.Windows.Forms.Label();
            this.todos_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoa_bt
            // 
            this.pessoa_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pessoa_bt.Location = new System.Drawing.Point(928, 405);
            this.pessoa_bt.Name = "pessoa_bt";
            this.pessoa_bt.Size = new System.Drawing.Size(86, 29);
            this.pessoa_bt.TabIndex = 3;
            this.pessoa_bt.Text = "Adicionar";
            this.pessoa_bt.UseVisualStyleBackColor = true;
            this.pessoa_bt.Click += new System.EventHandler(this.pessoa_bt_Click);
            // 
            // pessoa_dataGrid
            // 
            this.pessoa_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoa_dataGrid.Location = new System.Drawing.Point(200, 63);
            this.pessoa_dataGrid.MultiSelect = false;
            this.pessoa_dataGrid.Name = "pessoa_dataGrid";
            this.pessoa_dataGrid.ReadOnly = true;
            this.pessoa_dataGrid.RowHeadersVisible = false;
            this.pessoa_dataGrid.RowHeadersWidth = 51;
            this.pessoa_dataGrid.RowTemplate.Height = 24;
            this.pessoa_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pessoa_dataGrid.Size = new System.Drawing.Size(661, 371);
            this.pessoa_dataGrid.TabIndex = 11;
            this.pessoa_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pessoa_dataGrid_CellContentClick);
            // 
            // rendas
            // 
            this.rendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rendas.Location = new System.Drawing.Point(890, 180);
            this.rendas.Name = "rendas";
            this.rendas.Size = new System.Drawing.Size(111, 67);
            this.rendas.TabIndex = 12;
            this.rendas.Text = "Contratos de Renda";
            this.rendas.UseVisualStyleBackColor = true;
            this.rendas.Click += new System.EventHandler(this.rendas_Click);
            // 
            // cnodos
            // 
            this.cnodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cnodos.Location = new System.Drawing.Point(890, 272);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 225);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pessoa_textBox
            // 
            this.pessoa_textBox.Location = new System.Drawing.Point(336, 23);
            this.pessoa_textBox.Name = "pessoa_textBox";
            this.pessoa_textBox.Size = new System.Drawing.Size(183, 22);
            this.pessoa_textBox.TabIndex = 15;
            this.pessoa_textBox.TextChanged += new System.EventHandler(this.pessoa_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pesquisar Pessoa:";
            // 
            // view_contratos_label
            // 
            this.view_contratos_label.AutoSize = true;
            this.view_contratos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_contratos_label.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.view_contratos_label.Location = new System.Drawing.Point(863, 9);
            this.view_contratos_label.MaximumSize = new System.Drawing.Size(150, 0);
            this.view_contratos_label.Name = "view_contratos_label";
            this.view_contratos_label.Size = new System.Drawing.Size(92, 40);
            this.view_contratos_label.TabIndex = 18;
            this.view_contratos_label.Text = "Todos os Contratos";
            // 
            // todos_bt
            // 
            this.todos_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.todos_bt.Location = new System.Drawing.Point(890, 114);
            this.todos_bt.Name = "todos_bt";
            this.todos_bt.Size = new System.Drawing.Size(111, 36);
            this.todos_bt.TabIndex = 19;
            this.todos_bt.Text = "Todos";
            this.todos_bt.UseVisualStyleBackColor = true;
            this.todos_bt.Click += new System.EventHandler(this.todos_bt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(887, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ver:";
            // 
            // Contratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.todos_bt);
            this.Controls.Add(this.view_contratos_label);
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
        private Label view_contratos_label;
        private Button todos_bt;
        private Label label2;
    }
}