using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncDemo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = this.txtInput.Text;
        }

        /// <summary>
        /// 動步方式更新 txtOutput.Text
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnSyncTypewriter_Click(object sender, EventArgs e)
        {
            //// 將 txtInput.Text 轉 char陣列
            string inputContent = this.txtInput.Text;
            char[] charArray = new char[inputContent.Length];
            charArray = inputContent.ToArray();

            //// 每0.3秒增加一個字元到 txtOutput.Text
            this.txtOutput.Text = string.Empty;
            for (int i = 0; i < inputContent.Length; i++)
            {
                Thread.Sleep(300);
                this.txtOutput.Text += charArray[i].ToString();
            }
        }

        /// <summary>
        /// 非動步方式更新 txtOutput.Text
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnAsync_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                this.txtOutput.Text = this.txtInput.Text;
            });
            thread.Start();
        }

        private void btnAsyncTypewriter_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                //// 將 txtInput.Text 轉 char陣列
                string inputContent = this.txtInput.Text;
                char[] charArray = new char[inputContent.Length];
                charArray = inputContent.ToArray();

                //// 每0.3秒增加一個字元到 txtOutput.Text
                this.txtOutput.Text = string.Empty;
                for (int i = 0; i < inputContent.Length; i++)
                {
                    Thread.Sleep(300);
                    this.txtOutput.Text += charArray[i].ToString();
                }
            });
            thread.Start();
        }
    }
}
