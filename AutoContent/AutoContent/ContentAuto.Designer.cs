namespace AutoContent
{
    partial class ContentAuto
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnContent = new System.Windows.Forms.Button();
            this.webContent = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 8);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(688, 21);
            this.txtUrl.TabIndex = 0;
            // 
            // btnContent
            // 
            this.btnContent.Location = new System.Drawing.Point(729, 8);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(75, 23);
            this.btnContent.TabIndex = 1;
            this.btnContent.Text = "抽取";
            this.btnContent.UseVisualStyleBackColor = true;
            this.btnContent.Click += new System.EventHandler(this.btnContent_Click);
            // 
            // webContent
            // 
            this.webContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webContent.Location = new System.Drawing.Point(13, 51);
            this.webContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webContent.Name = "webContent";
            this.webContent.Size = new System.Drawing.Size(852, 436);
            this.webContent.TabIndex = 2;
            // 
            // ContentAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 499);
            this.Controls.Add(this.webContent);
            this.Controls.Add(this.btnContent);
            this.Controls.Add(this.txtUrl);
            this.Name = "ContentAuto";
            this.Text = "智能获取内容";
            this.Load += new System.EventHandler(this.ContentAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnContent;
        private System.Windows.Forms.WebBrowser webContent;
    }
}

