using System;
using System.Windows.Forms;

namespace BD_Proj
{
    partial class DadosPessoais
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
            this.pessoa_dataGrid = new System.Windows.Forms.DataGridView();
            this.inquilinos = new System.Windows.Forms.Button();
            this.proprietarios = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.view_label = new System.Windows.Forms.Label();
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
            // pessoa_dataGrid
            // 
            this.pessoa_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoa_dataGrid.GridColor = System.Drawing.Color.LightSeaGreen;
            this.pessoa_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.pessoa_dataGrid.MultiSelect = false;
            this.pessoa_dataGrid.Name = "pessoa_dataGrid";
            this.pessoa_dataGrid.ReadOnly = true;
            this.pessoa_dataGrid.RowHeadersVisible = false;
            this.pessoa_dataGrid.RowHeadersWidth = 51;
            this.pessoa_dataGrid.RowTemplate.Height = 24;
            this.pessoa_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pessoa_dataGrid.Size = new System.Drawing.Size(750, 494);
            this.pessoa_dataGrid.TabIndex = 11;
            this.pessoa_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pessoa_dataGrid_CellContentClick);
            // 
            // inquilinos
            // 
            this.inquilinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inquilinos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inquilinos.Location = new System.Drawing.Point(782, 94);
            this.inquilinos.Name = "inquilinos";
            this.inquilinos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inquilinos.Size = new System.Drawing.Size(118, 30);
            this.inquilinos.TabIndex = 12;
            this.inquilinos.Text = "Inquilinos";
            this.inquilinos.UseVisualStyleBackColor = true;
            this.inquilinos.Click += new System.EventHandler(this.inquilinos_Click);
            // 
            // proprietarios
            // 
            this.proprietarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proprietarios.Location = new System.Drawing.Point(783, 145);
            this.proprietarios.Name = "proprietarios";
            this.proprietarios.Size = new System.Drawing.Size(118, 34);
            this.proprietarios.TabIndex = 13;
            this.proprietarios.Text = "Proprietários";
            this.proprietarios.UseVisualStyleBackColor = true;
            this.proprietarios.Click += new System.EventHandler(this.proprietarios_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(813, 458);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(90, 23);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // view_label
            // 
            this.view_label.AutoSize = true;
            this.view_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_label.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.view_label.Location = new System.Drawing.Point(770, 21);
            this.view_label.Name = "view_label";
            this.view_label.Size = new System.Drawing.Size(128, 24);
            this.view_label.TabIndex = 15;
            this.view_label.Text = "Proprietários";
            // 
            // DadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 493);
            this.Controls.Add(this.view_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.proprietarios);
            this.Controls.Add(this.inquilinos);
            this.Controls.Add(this.pessoa_dataGrid);
            this.Controls.Add(this.pessoas_listBox);
            this.Name = "DadosPessoais";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.DadosPessoais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pessoa_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.ListBox pessoas_listBox;
        private System.Windows.Forms.DataGridView pessoa_dataGrid;
        private Button inquilinos;
        private Button proprietarios;
        private Button delete_button;
        private Label view_label;
    }
}