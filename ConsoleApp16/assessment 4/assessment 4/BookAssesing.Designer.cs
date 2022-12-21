namespace assessment_4
{
    partial class BookAssesing
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboStuId = new System.Windows.Forms.ComboBox();
            this.comboBUid = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.BookAss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BeforeAssening Books IN library";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(705, 402);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "StudentId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "StudentNmae";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "BookUid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "BookName";
            // 
            // comboStuId
            // 
            this.comboStuId.FormattingEnabled = true;
            this.comboStuId.Location = new System.Drawing.Point(910, 93);
            this.comboStuId.Name = "comboStuId";
            this.comboStuId.Size = new System.Drawing.Size(151, 24);
            this.comboStuId.TabIndex = 8;
            this.comboStuId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBUid
            // 
            this.comboBUid.FormattingEnabled = true;
            this.comboBUid.Location = new System.Drawing.Point(910, 222);
            this.comboBUid.Name = "comboBUid";
            this.comboBUid.Size = new System.Drawing.Size(151, 24);
            this.comboBUid.TabIndex = 9;
            this.comboBUid.SelectedIndexChanged += new System.EventHandler(this.comboBUid_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(910, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 10;
            // 
            // txtbook
            // 
            this.txtbook.Location = new System.Drawing.Point(910, 296);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(151, 22);
            this.txtbook.TabIndex = 11;
            // 
            // BookAss
            // 
            this.BookAss.Location = new System.Drawing.Point(775, 407);
            this.BookAss.Name = "BookAss";
            this.BookAss.Size = new System.Drawing.Size(286, 37);
            this.BookAss.TabIndex = 13;
            this.BookAss.Text = "BOOKASSINING";
            this.BookAss.UseVisualStyleBackColor = true;
            this.BookAss.Click += new System.EventHandler(this.BookAss_Click);
            // 
            // BookAssesing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 641);
            this.Controls.Add(this.BookAss);
            this.Controls.Add(this.txtbook);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBUid);
            this.Controls.Add(this.comboStuId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "BookAssesing";
            this.Text = "BookAssesing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboStuId;
        private System.Windows.Forms.ComboBox comboBUid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.Button BookAss;
    }
}