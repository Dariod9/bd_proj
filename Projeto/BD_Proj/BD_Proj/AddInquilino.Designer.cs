namespace BD_Proj
{
    partial class AddInquilino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInquilino));
            this.label1 = new System.Windows.Forms.Label();
            this.fname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lname_textbox = new System.Windows.Forms.TextBox();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.nif_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reg_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cert_textBox = new System.Windows.Forms.TextBox();
            this.morada_box = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fname_textbox
            // 
            this.fname_textbox.Location = new System.Drawing.Point(25, 31);
            this.fname_textbox.Name = "fname_textbox";
            this.fname_textbox.Size = new System.Drawing.Size(231, 22);
            this.fname_textbox.TabIndex = 1;
            this.fname_textbox.TextChanged += new System.EventHandler(this.morada_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identification";
            // 
            // submit_bt
            // 
            this.submit_bt.Location = new System.Drawing.Point(693, 319);
            this.submit_bt.Name = "submit_bt";
            this.submit_bt.Size = new System.Drawing.Size(75, 23);
            this.submit_bt.TabIndex = 4;
            this.submit_bt.Text = "Submit";
            this.submit_bt.UseVisualStyleBackColor = true;
            this.submit_bt.Click += new System.EventHandler(this.submit_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(612, 319);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 5;
            this.cancel_bt.Text = "Cancel";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
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
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Certificado";
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
            this.pictureBox1.Location = new System.Drawing.Point(511, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // reg_textBox
            // 
            this.reg_textBox.Location = new System.Drawing.Point(25, 247);
            this.reg_textBox.Name = "reg_textBox";
            this.reg_textBox.Size = new System.Drawing.Size(222, 22);
            this.reg_textBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Registo Criminal";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cert_textBox
            // 
            this.cert_textBox.Location = new System.Drawing.Point(316, 163);
            this.cert_textBox.Name = "cert_textBox";
            this.cert_textBox.Size = new System.Drawing.Size(100, 22);
            this.cert_textBox.TabIndex = 22;
            // 
            // morada_box
            // 
            this.morada_box.FormattingEnabled = true;
            this.morada_box.Location = new System.Drawing.Point(310, 245);
            this.morada_box.Name = "morada_box";
            this.morada_box.Size = new System.Drawing.Size(121, 24);
            this.morada_box.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Morada";
            // 
            // AddInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 354);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.morada_box);
            this.Controls.Add(this.cert_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reg_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nif_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.tel_textbox);
            this.Controls.Add(this.lname_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.submit_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname_textbox);
            this.Controls.Add(this.label1);
            this.Name = "AddInquilino";
            this.Text = "Adicionar Inquilino";
            this.Load += new System.EventHandler(this.AddCasa_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lname_textbox;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox nif_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox reg_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cert_textBox;
        private System.Windows.Forms.ComboBox morada_box;
        private System.Windows.Forms.Label label8;
    }
}