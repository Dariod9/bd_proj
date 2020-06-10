namespace BD_Proj
{
    partial class CondoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CondoForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.condominios_listBox = new System.Windows.Forms.ListBox();
            this.editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 234);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(656, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Casas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(656, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Habitantes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(656, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 74);
            this.button3.TabIndex = 3;
            this.button3.Text = "Obras";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // condominios_listBox
            // 
            this.condominios_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condominios_listBox.FormattingEnabled = true;
            this.condominios_listBox.ItemHeight = 20;
            this.condominios_listBox.Location = new System.Drawing.Point(310, 87);
            this.condominios_listBox.Name = "condominios_listBox";
            this.condominios_listBox.Size = new System.Drawing.Size(254, 324);
            this.condominios_listBox.TabIndex = 4;
            // 
            // editar
            // 
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editar.Location = new System.Drawing.Point(310, 417);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 25);
            this.editar.TabIndex = 5;
            this.editar.Text = "editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione um Condomínio:";
            // 
            // add_bt
            // 
            this.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_bt.Location = new System.Drawing.Point(474, 417);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(75, 25);
            this.add_bt.TabIndex = 7;
            this.add_bt.Text = "Adicionar";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // CondoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 549);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.condominios_listBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CondoForm";
            this.Text = "NextHause";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CondoForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox condominios_listBox;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_bt;
    }
}