namespace WindowsFormsApplication1
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
            this.titel_lbl = new System.Windows.Forms.Label();
            this.normalExecute_btn = new System.Windows.Forms.Button();
            this.asyncExecute_btn = new System.Windows.Forms.Button();
            this.siteList_lstbx = new System.Windows.Forms.ListBox();
            this.result_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titel_lbl
            // 
            this.titel_lbl.AutoSize = true;
            this.titel_lbl.Location = new System.Drawing.Point(12, 9);
            this.titel_lbl.Name = "titel_lbl";
            this.titel_lbl.Size = new System.Drawing.Size(123, 13);
            this.titel_lbl.TabIndex = 0;
            this.titel_lbl.Text = "Simple Async Demo App";
            // 
            // normalExecute_btn
            // 
            this.normalExecute_btn.Location = new System.Drawing.Point(15, 35);
            this.normalExecute_btn.Name = "normalExecute_btn";
            this.normalExecute_btn.Size = new System.Drawing.Size(472, 34);
            this.normalExecute_btn.TabIndex = 1;
            this.normalExecute_btn.Text = "Normal Execute";
            this.normalExecute_btn.UseVisualStyleBackColor = true;
            this.normalExecute_btn.Click += new System.EventHandler(this.normalExecute_btn_Click);
            // 
            // asyncExecute_btn
            // 
            this.asyncExecute_btn.Location = new System.Drawing.Point(15, 75);
            this.asyncExecute_btn.Name = "asyncExecute_btn";
            this.asyncExecute_btn.Size = new System.Drawing.Size(472, 39);
            this.asyncExecute_btn.TabIndex = 2;
            this.asyncExecute_btn.Text = "Async Execute";
            this.asyncExecute_btn.UseVisualStyleBackColor = true;
            this.asyncExecute_btn.Click += new System.EventHandler(this.asyncExecute_btn_Click);
            // 
            // siteList_lstbx
            // 
            this.siteList_lstbx.FormattingEnabled = true;
            this.siteList_lstbx.Location = new System.Drawing.Point(15, 131);
            this.siteList_lstbx.Name = "siteList_lstbx";
            this.siteList_lstbx.Size = new System.Drawing.Size(472, 108);
            this.siteList_lstbx.TabIndex = 3;
            // 
            // result_lb
            // 
            this.result_lb.AutoSize = true;
            this.result_lb.Location = new System.Drawing.Point(12, 242);
            this.result_lb.Name = "result_lb";
            this.result_lb.Size = new System.Drawing.Size(0, 13);
            this.result_lb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.Controls.Add(this.result_lb);
            this.Controls.Add(this.siteList_lstbx);
            this.Controls.Add(this.asyncExecute_btn);
            this.Controls.Add(this.normalExecute_btn);
            this.Controls.Add(this.titel_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titel_lbl;
        private System.Windows.Forms.Button normalExecute_btn;
        private System.Windows.Forms.Button asyncExecute_btn;
        private System.Windows.Forms.ListBox siteList_lstbx;
        private System.Windows.Forms.Label result_lb;
    }
}

