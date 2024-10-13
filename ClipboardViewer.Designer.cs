namespace ClipboardManager
{
    partial class ClipboardViewer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstClipboardHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnClearHistory;

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
            this.lstClipboardHistory = new System.Windows.Forms.ListBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClipboardHistory
            // 
            this.lstClipboardHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstClipboardHistory.FormattingEnabled = true;
            this.lstClipboardHistory.ItemHeight = 20;
            this.lstClipboardHistory.Location = new System.Drawing.Point(12, 40);
            this.lstClipboardHistory.Name = "lstClipboardHistory";
            this.lstClipboardHistory.Size = new System.Drawing.Size(360, 260);
            this.lstClipboardHistory.TabIndex = 0;
            this.lstClipboardHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.lstClipboardHistory.DoubleClick += new System.EventHandler(this.lstClipboardHistory_DoubleClick);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistory.Location = new System.Drawing.Point(12, 10);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(142, 28);
            this.lblHistory.TabIndex = 1;
            this.lblHistory.Text = "Clipboard History";
            this.lblHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClearHistory.Location = new System.Drawing.Point(272, 310);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(100, 30);
            this.btnClearHistory.TabIndex = 2;
            this.btnClearHistory.Text = "Clear";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lstClipboardHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "Form1";
            this.Text = "Clipboard Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
