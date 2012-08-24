namespace dyplom
{
    partial class ctrBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrBalance));
            this.containCtrBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // containCtrBox
            // 
            this.containCtrBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.containCtrBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.containCtrBox.Location = new System.Drawing.Point(0, 0);
            this.containCtrBox.Name = "containCtrBox";
            this.containCtrBox.Size = new System.Drawing.Size(759, 22);
            this.containCtrBox.TabIndex = 1;
            // 
            // ctrBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 549);
            this.Controls.Add(this.containCtrBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ctrBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Small Buisness Accounting v1.5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ctrBalance_FormClosed);
            this.Load += new System.EventHandler(this.ctrBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox containCtrBox;

    }
}