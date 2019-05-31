namespace TeaBagMaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tea = new System.Windows.Forms.ComboBox();
            this.put = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.namdohee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tea
            // 
            this.tea.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tea.FormattingEnabled = true;
            this.tea.Items.AddRange(new object[] {
            "홍차",
            "녹차",
            "루이보스차",
            "국화차"});
            this.tea.Location = new System.Drawing.Point(13, 13);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(256, 20);
            this.tea.TabIndex = 0;
            // 
            // put
            // 
            this.put.Location = new System.Drawing.Point(13, 135);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(256, 49);
            this.put.TabIndex = 1;
            this.put.Text = "담그기!";
            this.put.UseVisualStyleBackColor = true;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(123, 82);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(36, 12);
            this.count.TabIndex = 2;
            this.count.Text = "count";
            // 
            // namdohee
            // 
            this.namdohee.AutoSize = true;
            this.namdohee.Location = new System.Drawing.Point(12, 195);
            this.namdohee.Name = "namdohee";
            this.namdohee.Size = new System.Drawing.Size(69, 12);
            this.namdohee.TabIndex = 3;
            this.namdohee.Text = "3106 남도희";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 216);
            this.Controls.Add(this.namdohee);
            this.Controls.Add(this.count);
            this.Controls.Add(this.put);
            this.Controls.Add(this.tea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tea;
        private System.Windows.Forms.Button put;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label namdohee;
    }
}

