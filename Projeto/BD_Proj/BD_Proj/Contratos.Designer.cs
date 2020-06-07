﻿using System;
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
            this.pessoa_bt = new System.Windows.Forms.Button();
            this.pessoa_dataGrid = new System.Windows.Forms.DataGridView();
            this.rendas = new System.Windows.Forms.Button();
            this.cnodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoa_bt
            // 
            this.pessoa_bt.Location = new System.Drawing.Point(695, 415);
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
            this.pessoa_dataGrid.Location = new System.Drawing.Point(12, 3);
            this.pessoa_dataGrid.MultiSelect = false;
            this.pessoa_dataGrid.Name = "pessoa_dataGrid";
            this.pessoa_dataGrid.ReadOnly = true;
            this.pessoa_dataGrid.RowHeadersVisible = false;
            this.pessoa_dataGrid.RowHeadersWidth = 51;
            this.pessoa_dataGrid.RowTemplate.Height = 24;
            this.pessoa_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pessoa_dataGrid.Size = new System.Drawing.Size(581, 445);
            this.pessoa_dataGrid.TabIndex = 11;
            this.pessoa_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pessoa_dataGrid_CellContentClick);
            // 
            // rendas
            // 
            this.rendas.Location = new System.Drawing.Point(659, 84);
            this.rendas.Name = "rendas";
            this.rendas.Size = new System.Drawing.Size(111, 67);
            this.rendas.TabIndex = 12;
            this.rendas.Text = "Contratos de Renda";
            this.rendas.UseVisualStyleBackColor = true;
            this.rendas.Click += new System.EventHandler(this.rendas_Click);
            // 
            // cnodos
            // 
            this.cnodos.Location = new System.Drawing.Point(659, 177);
            this.cnodos.Name = "cnodos";
            this.cnodos.Size = new System.Drawing.Size(111, 67);
            this.cnodos.TabIndex = 13;
            this.cnodos.Text = "Contratos de Condomínio";
            this.cnodos.UseVisualStyleBackColor = true;
            this.cnodos.Click += new System.EventHandler(this.cnodos_Click);
            // 
            // Contratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.cnodos);
            this.Controls.Add(this.rendas);
            this.Controls.Add(this.pessoa_dataGrid);
            this.Controls.Add(this.pessoa_bt);
            this.Name = "Contratos";
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
        private System.Windows.Forms.Button pessoa_bt;
        private System.Windows.Forms.DataGridView pessoa_dataGrid;
        private Button rendas;
        private Button cnodos;
    }
}