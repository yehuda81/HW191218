namespace HW191218
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.lessBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.powBtn = new System.Windows.Forms.Button();
            this.rootBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.randomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addBtn.Location = new System.Drawing.Point(522, 45);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 40);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // lessBtn
            // 
            this.lessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lessBtn.Location = new System.Drawing.Point(578, 45);
            this.lessBtn.Name = "lessBtn";
            this.lessBtn.Size = new System.Drawing.Size(40, 40);
            this.lessBtn.TabIndex = 3;
            this.lessBtn.Text = "-";
            this.lessBtn.UseVisualStyleBackColor = true;
            this.lessBtn.Click += new System.EventHandler(this.lessBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mulBtn.Location = new System.Drawing.Point(522, 91);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(40, 40);
            this.mulBtn.TabIndex = 4;
            this.mulBtn.Text = "X";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.divBtn.Location = new System.Drawing.Point(578, 91);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(40, 40);
            this.divBtn.TabIndex = 5;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // powBtn
            // 
            this.powBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.powBtn.Location = new System.Drawing.Point(522, 137);
            this.powBtn.Name = "powBtn";
            this.powBtn.Size = new System.Drawing.Size(40, 40);
            this.powBtn.TabIndex = 6;
            this.powBtn.Text = "^";
            this.powBtn.UseVisualStyleBackColor = true;
            this.powBtn.Click += new System.EventHandler(this.powBtn_Click);
            // 
            // rootBtn
            // 
            this.rootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rootBtn.Location = new System.Drawing.Point(578, 137);
            this.rootBtn.Name = "rootBtn";
            this.rootBtn.Size = new System.Drawing.Size(40, 40);
            this.rootBtn.TabIndex = 7;
            this.rootBtn.Text = "S";
            this.rootBtn.UseVisualStyleBackColor = true;
            this.rootBtn.Click += new System.EventHandler(this.rootBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(294, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 56);
            this.listBox1.TabIndex = 8;
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(436, 46);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(59, 55);
            this.randomBtn.TabIndex = 9;
            this.randomBtn.Text = "Random Numbers";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rootBtn);
            this.Controls.Add(this.powBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.lessBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button lessBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button powBtn;
        private System.Windows.Forms.Button rootBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button randomBtn;
    }
}

