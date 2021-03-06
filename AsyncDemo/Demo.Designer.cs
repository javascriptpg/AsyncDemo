﻿namespace AsyncDemo
{
    partial class Demo
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnSyncTypewriter = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnAsyncTypewriter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInput.Location = new System.Drawing.Point(13, 13);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(443, 180);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutput.Location = new System.Drawing.Point(12, 208);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(443, 180);
            this.txtOutput.TabIndex = 1;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(462, 13);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(126, 23);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnSyncTypewriter
            // 
            this.btnSyncTypewriter.Location = new System.Drawing.Point(463, 43);
            this.btnSyncTypewriter.Name = "btnSyncTypewriter";
            this.btnSyncTypewriter.Size = new System.Drawing.Size(125, 23);
            this.btnSyncTypewriter.TabIndex = 3;
            this.btnSyncTypewriter.Text = "Sync(typewriter)";
            this.btnSyncTypewriter.UseVisualStyleBackColor = true;
            this.btnSyncTypewriter.Click += new System.EventHandler(this.btnSyncTypewriter_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(463, 73);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(125, 23);
            this.btnAsync.TabIndex = 4;
            this.btnAsync.Text = "Async";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnAsyncTypewriter
            // 
            this.btnAsyncTypewriter.Location = new System.Drawing.Point(463, 103);
            this.btnAsyncTypewriter.Name = "btnAsyncTypewriter";
            this.btnAsyncTypewriter.Size = new System.Drawing.Size(125, 23);
            this.btnAsyncTypewriter.TabIndex = 5;
            this.btnAsyncTypewriter.Text = "Async(typewriter)";
            this.btnAsyncTypewriter.UseVisualStyleBackColor = true;
            this.btnAsyncTypewriter.Click += new System.EventHandler(this.btnAsyncTypewriter_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnAsyncTypewriter);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSyncTypewriter);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Demo";
            this.Text = "DemoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnSyncTypewriter;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnAsyncTypewriter;
    }
}

