namespace PR3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label lblSum;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.файлToolStripMenuItem,
                this.помощьToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.обработатьToolStripMenuItem
            });
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.обработатьToolStripMenuItem.Name = "обработатьToolStripMenuItem";
            this.обработатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обработатьToolStripMenuItem.Text = "Обработать";
            this.обработатьToolStripMenuItem.Click += new System.EventHandler(this.btnProcess_Click);
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(250, 20);
            this.помощьToolStripMenuItem.Text = "ссылка на меня ilasemonaev@gmail.com";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            this.txtInput.Location = new System.Drawing.Point(12, 50);
            this.txtInput.Size = new System.Drawing.Size(400, 20);
            this.txtInput.Name = "txtInput";
            this.btnProcess.Location = new System.Drawing.Point(420, 48);
            this.btnProcess.Size = new System.Drawing.Size(80, 23);
            this.btnProcess.Text = "Обработать";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 80);
            this.lstOutput.Size = new System.Drawing.Size(488, 150);
            this.lstOutput.Name = "lstOutput";
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(12, 240);
            this.lblSum.Size = new System.Drawing.Size(52, 13);
            this.lblSum.Text = "Сумма: 0";
            this.ClientSize = new System.Drawing.Size(520, 270);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Парсер словаря";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}