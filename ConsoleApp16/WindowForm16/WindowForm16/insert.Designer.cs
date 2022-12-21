namespace WindowForm16
{
    partial class insert
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
            this.textsno = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "sno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // textsno
            // 
            this.textsno.Location = new System.Drawing.Point(199, 61);
            this.textsno.Name = "textsno";
            this.textsno.Size = new System.Drawing.Size(100, 22);
            this.textsno.TabIndex = 2;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(199, 143);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 22);
            this.textname.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textsno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert";
            this.Text = "insert";
            this.Load += new System.EventHandler(this.insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsno;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Button button1;
    }
}