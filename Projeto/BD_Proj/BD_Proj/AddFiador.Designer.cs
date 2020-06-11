namespace BD_Proj
{
    partial class AddFiador
    { /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFiador));
            this.label1 = new System.Windows.Forms.Label();
            this.fname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lname_textbox = new System.Windows.Forms.TextBox();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.nif_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Nome";
            // 
            // fname_textbox
            // 
            this.fname_textbox.Location = new System.Drawing.Point(25, 31);
            this.fname_textbox.Name = "fname_textbox";
            this.fname_textbox.Size = new System.Drawing.Size(231, 22);
            this.fname_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // submit_bt
            // 
            this.submit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_bt.Location = new System.Drawing.Point(683, 257);
            this.submit_bt.Name = "submit_bt";
            this.submit_bt.Size = new System.Drawing.Size(75, 25);
            this.submit_bt.TabIndex = 4;
            this.submit_bt.Text = "Adicionar";
            this.submit_bt.UseVisualStyleBackColor = true;
            this.submit_bt.Click += new System.EventHandler(this.submit_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_bt.Location = new System.Drawing.Point(600, 257);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 25);
            this.cancel_bt.TabIndex = 5;
            this.cancel_bt.Text = "Cancelar";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Último Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // lname_textbox
            // 
            this.lname_textbox.Location = new System.Drawing.Point(25, 94);
            this.lname_textbox.Name = "lname_textbox";
            this.lname_textbox.Size = new System.Drawing.Size(100, 22);
            this.lname_textbox.TabIndex = 10;
            // 
            // tel_textbox
            // 
            this.tel_textbox.Location = new System.Drawing.Point(25, 163);
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(211, 22);
            this.tel_textbox.TabIndex = 12;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(316, 30);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(121, 22);
            this.id_textBox.TabIndex = 17;
            // 
            // nif_textBox
            // 
            this.nif_textBox.Location = new System.Drawing.Point(316, 95);
            this.nif_textBox.Name = "nif_textBox";
            this.nif_textBox.Size = new System.Drawing.Size(121, 22);
            this.nif_textBox.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AddFiador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 285);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nif_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.tel_textbox);
            this.Controls.Add(this.lname_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.submit_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname_textbox);
            this.Controls.Add(this.label1);
            this.Name = "AddFiador";
            this.Text = "Adicionar Proprietário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lname_textbox;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox nif_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}