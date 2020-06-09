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
            this.pessoa_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.pessoa_dataGrid.MultiSelect = false;
            this.pessoa_dataGrid.Name = "pessoa_dataGrid";
            this.pessoa_dataGrid.ReadOnly = true;
            this.pessoa_dataGrid.RowHeadersVisible = false;
            this.pessoa_dataGrid.RowHeadersWidth = 51;
            this.pessoa_dataGrid.RowTemplate.Height = 24;
            this.pessoa_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pessoa_dataGrid.Size = new System.Drawing.Size(640, 445);
            this.pessoa_dataGrid.TabIndex = 11;
            this.pessoa_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pessoa_dataGrid_CellContentClick);
            // 
            // inquilinos
            // 
            this.inquilinos.Location = new System.Drawing.Point(646, 73);
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
            this.proprietarios.Location = new System.Drawing.Point(646, 135);
            this.proprietarios.Name = "proprietarios";
            this.proprietarios.Size = new System.Drawing.Size(118, 34);
            this.proprietarios.TabIndex = 13;
            this.proprietarios.Text = "Proprietários";
            this.proprietarios.UseVisualStyleBackColor = true;
            this.proprietarios.Click += new System.EventHandler(this.proprietarios_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(674, 415);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(90, 23);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // DadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}