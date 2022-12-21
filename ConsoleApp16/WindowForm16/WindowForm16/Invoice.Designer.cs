namespace WindowForm16
{
    partial class invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textinv = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ronline = new System.Windows.Forms.RadioButton();
            this.roffiline = new System.Windows.Forms.RadioButton();
            this.textdept = new System.Windows.Forms.TextBox();
            this.dateTimePickere = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.texttype = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "invno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "clientname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "paymentmode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "edate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "invtype";
            // 
            // textinv
            // 
            this.textinv.Location = new System.Drawing.Point(176, 76);
            this.textinv.Name = "textinv";
            this.textinv.Size = new System.Drawing.Size(197, 22);
            this.textinv.TabIndex = 5;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(176, 125);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(197, 22);
            this.textname.TabIndex = 6;
            this.textname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "dept name";
            // 
            // ronline
            // 
            this.ronline.AutoSize = true;
            this.ronline.Location = new System.Drawing.Point(194, 185);
            this.ronline.Name = "ronline";
            this.ronline.Size = new System.Drawing.Size(64, 20);
            this.ronline.TabIndex = 8;
            this.ronline.TabStop = true;
            this.ronline.Text = "online";
            this.ronline.UseVisualStyleBackColor = true;
            // 
            // roffiline
            // 
            this.roffiline.AutoSize = true;
            this.roffiline.Location = new System.Drawing.Point(349, 181);
            this.roffiline.Name = "roffiline";
            this.roffiline.Size = new System.Drawing.Size(66, 20);
            this.roffiline.TabIndex = 9;
            this.roffiline.TabStop = true;
            this.roffiline.Text = "offiline";
            this.roffiline.UseVisualStyleBackColor = true;
            // 
            // textdept
            // 
            this.textdept.Location = new System.Drawing.Point(194, 357);
            this.textdept.Name = "textdept";
            this.textdept.Size = new System.Drawing.Size(197, 22);
            this.textdept.TabIndex = 12;
            // 
            // dateTimePickere
            // 
            this.dateTimePickere.Location = new System.Drawing.Point(194, 249);
            this.dateTimePickere.Name = "dateTimePickere";
            this.dateTimePickere.Size = new System.Drawing.Size(297, 22);
            this.dateTimePickere.TabIndex = 13;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(251, 415);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 14;
            this.save.Text = "button1";
            this.save.UseVisualStyleBackColor = true;
            // 
            // texttype
            // 
            this.texttype.Location = new System.Drawing.Point(194, 308);
            this.texttype.Name = "texttype";
            this.texttype.Size = new System.Drawing.Size(100, 22);
            this.texttype.TabIndex = 15;
            // 
            // online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texttype);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dateTimePickere);
            this.Controls.Add(this.textdept);
            this.Controls.Add(this.roffiline);
            this.Controls.Add(this.ronline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textinv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "online";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textinv;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton ronline;
        private System.Windows.Forms.RadioButton roffiline;
        private System.Windows.Forms.TextBox textdept;
        private System.Windows.Forms.DateTimePicker dateTimePickere;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox texttype;
    }
}