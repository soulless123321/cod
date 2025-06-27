namespace PR2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 50);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Создать список";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(150, 50);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(120, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Обработать";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.Location = new System.Drawing.Point(12, 100);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(258, 160);
            this.listBoxNumbers.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Обработка списка чисел";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "PR2: Работа с коллекциями";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

