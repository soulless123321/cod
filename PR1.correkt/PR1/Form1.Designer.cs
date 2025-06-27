namespace PR1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Button btnShow;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(10, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(360, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(10, 60);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(37, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Автор";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(10, 80);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(360, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(10, 110);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(25, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Год";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(10, 130);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(360, 20);
            this.txtYear.TabIndex = 5;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(10, 160);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(79, 13);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Издательство";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(10, 180);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(360, 20);
            this.txtPublisher.TabIndex = 7;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(10, 210);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(49, 13);
            this.lblPages.TabIndex = 8;
            this.lblPages.Text = "Страниц";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(10, 230);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(360, 20);
            this.txtPages.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(10, 270);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 30);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Показать";
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.btnShow);
            this.Name = "MainForm";
            this.Text = "Книга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

