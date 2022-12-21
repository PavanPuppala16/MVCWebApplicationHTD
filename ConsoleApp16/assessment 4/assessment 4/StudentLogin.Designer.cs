namespace assessment_4
{
    partial class StudentLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtsuid = new System.Windows.Forms.TextBox();
            this.txtstpss = new System.Windows.Forms.TextBox();
            this.txtLCode = new System.Windows.Forms.TextBox();
            this.txtLp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Studentid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "studentpassword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "LibraryCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "LibraryPassword";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login to Library";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsuid
            // 
            this.txtsuid.Location = new System.Drawing.Point(333, 109);
            this.txtsuid.Name = "txtsuid";
            this.txtsuid.Size = new System.Drawing.Size(100, 22);
            this.txtsuid.TabIndex = 5;
            // 
            // txtstpss
            // 
            this.txtstpss.Location = new System.Drawing.Point(333, 174);
            this.txtstpss.Name = "txtstpss";
            this.txtstpss.Size = new System.Drawing.Size(100, 22);
            this.txtstpss.TabIndex = 6;
            // 
            // txtLCode
            // 
            this.txtLCode.Location = new System.Drawing.Point(333, 267);
            this.txtLCode.Name = "txtLCode";
            this.txtLCode.Size = new System.Drawing.Size(100, 22);
            this.txtLCode.TabIndex = 7;
            // 
            // txtLp
            // 
            this.txtLp.Location = new System.Drawing.Point(333, 343);
            this.txtLp.Name = "txtLp";
            this.txtLp.Size = new System.Drawing.Size(100, 22);
            this.txtLp.TabIndex = 8;
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 538);
            this.Controls.Add(this.txtLp);
            this.Controls.Add(this.txtLCode);
            this.Controls.Add(this.txtstpss);
            this.Controls.Add(this.txtsuid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsuid;
        private System.Windows.Forms.TextBox txtstpss;
        private System.Windows.Forms.TextBox txtLCode;
        private System.Windows.Forms.TextBox txtLp;
    }
}