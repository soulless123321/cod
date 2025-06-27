namespace PR3
{
    partial class HelpForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;

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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Size = new System.Drawing.Size(300, 100);
            this.label1.Text = "Это окно с информацией о программе.";
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.Controls.Add(this.label1);
            this.Name = "HelpForm";
            this.Text = "Помощь";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}