
namespace RandomCallApp
{
    partial class Form
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
            this.buttonRandomCall = new System.Windows.Forms.Button();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonPreviewStudentList = new System.Windows.Forms.Button();
            this.buttonViewRecentlyCalled = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRandomCall
            // 
            this.buttonRandomCall.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRandomCall.Location = new System.Drawing.Point(12, 61);
            this.buttonRandomCall.Name = "buttonRandomCall";
            this.buttonRandomCall.Size = new System.Drawing.Size(260, 55);
            this.buttonRandomCall.TabIndex = 0;
            this.buttonRandomCall.Text = "点击进行随机点名";
            this.buttonRandomCall.UseVisualStyleBackColor = true;
            this.buttonRandomCall.Click += new System.EventHandler(this.buttonRandomCall_Click_1);
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChooseFile.Location = new System.Drawing.Point(12, 190);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(260, 46);
            this.buttonChooseFile.TabIndex = 1;
            this.buttonChooseFile.Text = "选择学生名单";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click_1);
            // 
            // buttonPreviewStudentList
            // 
            this.buttonPreviewStudentList.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPreviewStudentList.Location = new System.Drawing.Point(12, 131);
            this.buttonPreviewStudentList.Name = "buttonPreviewStudentList";
            this.buttonPreviewStudentList.Size = new System.Drawing.Size(125, 44);
            this.buttonPreviewStudentList.TabIndex = 2;
            this.buttonPreviewStudentList.Text = "预览";
            this.buttonPreviewStudentList.UseVisualStyleBackColor = true;
            this.buttonPreviewStudentList.Click += new System.EventHandler(this.buttonPreviewStudentList_Click_1);
            // 
            // buttonViewRecentlyCalled
            // 
            this.buttonViewRecentlyCalled.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonViewRecentlyCalled.Location = new System.Drawing.Point(155, 131);
            this.buttonViewRecentlyCalled.Name = "buttonViewRecentlyCalled";
            this.buttonViewRecentlyCalled.Size = new System.Drawing.Size(117, 44);
            this.buttonViewRecentlyCalled.TabIndex = 3;
            this.buttonViewRecentlyCalled.Text = "历史";
            this.buttonViewRecentlyCalled.UseVisualStyleBackColor = true;
            this.buttonViewRecentlyCalled.Click += new System.EventHandler(this.buttonViewRecentlyCalled_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(97, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "点名器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "powered by C#,made by lwen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "@2023";
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonViewRecentlyCalled);
            this.Controls.Add(this.buttonPreviewStudentList);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.buttonRandomCall);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机点名";
            this.Load += new System.EventHandler(this.Form_Load);
            this.FormClosing += Form_Closing;

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRandomCall;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button buttonPreviewStudentList;
        private System.Windows.Forms.Button buttonViewRecentlyCalled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

