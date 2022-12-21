namespace assessment_4
{
    partial class Task12
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpay = new System.Windows.Forms.TextBox();
            this.txtinv = new System.Windows.Forms.TextBox();
            this.txtdept = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT_NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PAYMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "INV_TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "DEPTNAME";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(182, 82);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 5;
            // 
            // txtpay
            // 
            this.txtpay.Location = new System.Drawing.Point(182, 133);
            this.txtpay.Name = "txtpay";
            this.txtpay.Size = new System.Drawing.Size(100, 22);
            this.txtpay.TabIndex = 6;
            // 
            // txtinv
            // 
            this.txtinv.Location = new System.Drawing.Point(182, 253);
            this.txtinv.Name = "txtinv";
            this.txtinv.Size = new System.Drawing.Size(100, 22);
            this.txtinv.TabIndex = 7;
            // 
            // txtdept
            // 
            this.txtdept.Location = new System.Drawing.Point(182, 324);
            this.txtdept.Name = "txtdept";
            this.txtdept.Size = new System.Drawing.Size(100, 22);
            this.txtdept.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(182, 201);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 22);
            this.dob.TabIndex = 10;
            // 
            // Task12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 602);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.txtinv);
            this.Controls.Add(this.txtpay);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task12";
            this.Text = "Task12";
            this.Load += new System.EventHandler(this.Task12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpay;
        private System.Windows.Forms.TextBox txtinv;
        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dob;
    }
}