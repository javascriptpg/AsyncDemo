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
        delegate void UICallBack(string str);

        private Thread myThread;

        /// <summary>
        /// Demo建構式
        /// </summary>
        public Demo()
        {
            this.myThread = null;
            InitializeComponent();
        }

        /// <summary>
        /// btnSync_Click方法，更新 txtOutput.Text
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnSync_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = this.txtInput.Text;
        }

        /// <summary>
        /// btnSyncTypewriter_Click方法，動步打字機效果更新 txtOutput.Text
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnSyncTypewriter_Click(object sender, EventArgs e)
        {
            this.ExecutingTypewriter();
        }

        /// <summary>
        /// btnAsync_Click方法，非動步方式更新 txtOutput.Text
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnAsync_Click(object sender, EventArgs e)
        {
            this.myThread = new Thread(() =>
            {
                this.ShowMessage(this.txtInput.Text);
            });
            this.myThread.Start();
        }

        /// <summary>
        /// btnAsyncTypewriter_Click方法，非動步打字機效果更新 txtOutput.Text
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnAsyncTypewriter_Click(object sender, EventArgs e)
        {
            this.myThread = new Thread(ExecutingTypewriter);
            this.myThread.Start();
        }

        /// <summary>
        /// 打字機效果
        /// </summary>
        /// <param name="str"></param>
        private void ExecutingTypewriter()
        {
            string message = string.Empty;
            string inputContent = this.txtInput.Text;
            char[] charArray = new char[inputContent.Length];
            charArray = inputContent.ToArray();
            
            //// 每0.3秒增加一個字元到 txtOutput.Text
            for (int i = 0; i < inputContent.Length; i++)
            {
                Thread.Sleep(300);
                message += charArray[i].ToString();
                this.ShowMessage(message);
            }
        }

        /// <summary>
        /// 更新 txtOutput.Text
        /// </summary>
        private void ShowMessage(string str)
        {
            //// Windows Form 控制項的安全執行緒呼叫
            //// 請參照 https://msdn.microsoft.com/zh-tw/library/ms171728(v=vs.110).aspx
            if (this.txtOutput.InvokeRequired)
            {
                UICallBack callBack = new UICallBack(ShowMessage);
                this.Invoke(callBack, new object[] {str});
            }
            else
            {
                this.txtOutput.Text = str;
            }
        }
    }
}
