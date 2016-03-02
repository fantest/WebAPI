namespace FanTest.WebAPI.Client
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cboContentType = new System.Windows.Forms.ComboBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chkPost = new System.Windows.Forms.CheckBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtData);
            this.splitContainer1.Panel1.Controls.Add(this.cboContentType);
            this.splitContainer1.Panel1.Controls.Add(this.chkPost);
            this.splitContainer1.Panel1.Controls.Add(this.btnCall);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Size = new System.Drawing.Size(704, 311);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(48, 41);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(603, 113);
            this.txtData.TabIndex = 3;
            // 
            // cboContentType
            // 
            this.cboContentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboContentType.FormattingEnabled = true;
            this.cboContentType.Items.AddRange(new object[] {
            "application/json",
            "multipart/form-data"});
            this.cboContentType.Location = new System.Drawing.Point(48, 21);
            this.cboContentType.Name = "cboContentType";
            this.cboContentType.Size = new System.Drawing.Size(603, 20);
            this.cboContentType.TabIndex = 6;
            this.cboContentType.Text = "application/json";
            // 
            // btnCall
            // 
            this.btnCall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCall.Location = new System.Drawing.Point(651, 21);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(53, 133);
            this.btnCall.TabIndex = 4;
            this.btnCall.Text = "&Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress.Location = new System.Drawing.Point(0, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(704, 21);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "http://localhost:8800/service3/v1/MPI/PKG_PAT_ARCH/GET_PAT_CARD_INFO$LIST";
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(704, 153);
            this.txtResult.TabIndex = 4;
            // 
            // chkPost
            // 
            this.chkPost.AutoSize = true;
            this.chkPost.Checked = true;
            this.chkPost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPost.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkPost.Location = new System.Drawing.Point(0, 21);
            this.chkPost.Name = "chkPost";
            this.chkPost.Size = new System.Drawing.Size(48, 133);
            this.chkPost.TabIndex = 7;
            this.chkPost.Text = "POST";
            this.chkPost.UseVisualStyleBackColor = true;
            this.chkPost.CheckedChanged += new System.EventHandler(this.chkPost_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 311);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "WEB API";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cboContentType;
        private System.Windows.Forms.CheckBox chkPost;

    }
}

