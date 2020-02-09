namespace SpeechTimer
{
    partial class SpeechTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeechTimer));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb10Min = new System.Windows.Forms.RadioButton();
            this.rb5Min = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rb15Min = new System.Windows.Forms.RadioButton();
            this.rb20Min = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbMinLeft = new System.Windows.Forms.Label();
            this.lbSecLeft = new System.Windows.Forms.Label();
            this.lbDot = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCEN = new System.Windows.Forms.RadioButton();
            this.rbRB = new System.Windows.Forms.RadioButton();
            this.rbLB = new System.Windows.Forms.RadioButton();
            this.rbRT = new System.Windows.Forms.RadioButton();
            this.rbLT = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlarmSec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOptions = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Location = new System.Drawing.Point(172, 156);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTimeInput
            // 
            this.txtTimeInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimeInput.Location = new System.Drawing.Point(55, 159);
            this.txtTimeInput.Name = "txtTimeInput";
            this.txtTimeInput.Size = new System.Drawing.Size(45, 21);
            this.txtTimeInput.TabIndex = 1;
            this.txtTimeInput.TextChanged += new System.EventHandler(this.txtTimeInput_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "自定义";
            // 
            // rb10Min
            // 
            this.rb10Min.AutoSize = true;
            this.rb10Min.Location = new System.Drawing.Point(92, 3);
            this.rb10Min.Name = "rb10Min";
            this.rb10Min.Size = new System.Drawing.Size(83, 16);
            this.rb10Min.TabIndex = 5;
            this.rb10Min.TabStop = true;
            this.rb10Min.Text = "10 Minutes";
            this.rb10Min.UseVisualStyleBackColor = true;
            // 
            // rb5Min
            // 
            this.rb5Min.AutoSize = true;
            this.rb5Min.Location = new System.Drawing.Point(3, 3);
            this.rb5Min.Name = "rb5Min";
            this.rb5Min.Size = new System.Drawing.Size(83, 16);
            this.rb5Min.TabIndex = 4;
            this.rb5Min.TabStop = true;
            this.rb5Min.Text = " 5 Minutes";
            this.rb5Min.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(this.rb5Min);
            this.flowLayoutPanel1.Controls.Add(this.rb10Min);
            this.flowLayoutPanel1.Controls.Add(this.rb15Min);
            this.flowLayoutPanel1.Controls.Add(this.rb20Min);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 25);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // rb15Min
            // 
            this.rb15Min.AutoSize = true;
            this.rb15Min.Location = new System.Drawing.Point(181, 3);
            this.rb15Min.Name = "rb15Min";
            this.rb15Min.Size = new System.Drawing.Size(83, 16);
            this.rb15Min.TabIndex = 6;
            this.rb15Min.TabStop = true;
            this.rb15Min.Text = "15 Minutes";
            this.rb15Min.UseVisualStyleBackColor = true;
            // 
            // rb20Min
            // 
            this.rb20Min.AutoSize = true;
            this.rb20Min.Location = new System.Drawing.Point(270, 3);
            this.rb20Min.Name = "rb20Min";
            this.rb20Min.Size = new System.Drawing.Size(83, 16);
            this.rb20Min.TabIndex = 7;
            this.rb20Min.TabStop = true;
            this.rb20Min.Text = "20 Minutes";
            this.rb20Min.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutes";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(335, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 26);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStop.Location = new System.Drawing.Point(276, 155);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 31);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbMinLeft
            // 
            this.lbMinLeft.AutoSize = true;
            this.lbMinLeft.Font = new System.Drawing.Font("微软雅黑", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMinLeft.Location = new System.Drawing.Point(34, 30);
            this.lbMinLeft.Name = "lbMinLeft";
            this.lbMinLeft.Size = new System.Drawing.Size(120, 90);
            this.lbMinLeft.TabIndex = 12;
            this.lbMinLeft.Text = "00";
            this.lbMinLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSecLeft
            // 
            this.lbSecLeft.AutoSize = true;
            this.lbSecLeft.Font = new System.Drawing.Font("微软雅黑", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSecLeft.Location = new System.Drawing.Point(217, 30);
            this.lbSecLeft.Name = "lbSecLeft";
            this.lbSecLeft.Size = new System.Drawing.Size(120, 90);
            this.lbSecLeft.TabIndex = 13;
            this.lbSecLeft.Text = "00";
            this.lbSecLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDot
            // 
            this.lbDot.AutoSize = true;
            this.lbDot.Font = new System.Drawing.Font("微软雅黑", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot.Location = new System.Drawing.Point(157, 30);
            this.lbDot.Name = "lbDot";
            this.lbDot.Size = new System.Drawing.Size(57, 90);
            this.lbDot.TabIndex = 14;
            this.lbDot.Text = ":";
            this.lbDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAlarmSec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTopMost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(10, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rbCEN
            // 
            this.rbCEN.AutoSize = true;
            this.rbCEN.Location = new System.Drawing.Point(215, 3);
            this.rbCEN.Name = "rbCEN";
            this.rbCEN.Size = new System.Drawing.Size(47, 16);
            this.rbCEN.TabIndex = 9;
            this.rbCEN.TabStop = true;
            this.rbCEN.Text = "居中";
            this.rbCEN.UseVisualStyleBackColor = true;
            this.rbCEN.CheckedChanged += new System.EventHandler(this.rbLocation_CheckedChanged);
            // 
            // rbRB
            // 
            this.rbRB.AutoSize = true;
            this.rbRB.Location = new System.Drawing.Point(162, 3);
            this.rbRB.Name = "rbRB";
            this.rbRB.Size = new System.Drawing.Size(47, 16);
            this.rbRB.TabIndex = 8;
            this.rbRB.TabStop = true;
            this.rbRB.Text = "右下";
            this.rbRB.UseVisualStyleBackColor = true;
            this.rbRB.CheckedChanged += new System.EventHandler(this.rbLocation_CheckedChanged);
            // 
            // rbLB
            // 
            this.rbLB.AutoSize = true;
            this.rbLB.Location = new System.Drawing.Point(109, 3);
            this.rbLB.Name = "rbLB";
            this.rbLB.Size = new System.Drawing.Size(47, 16);
            this.rbLB.TabIndex = 7;
            this.rbLB.TabStop = true;
            this.rbLB.Text = "左下";
            this.rbLB.UseVisualStyleBackColor = true;
            this.rbLB.CheckedChanged += new System.EventHandler(this.rbLocation_CheckedChanged);
            // 
            // rbRT
            // 
            this.rbRT.AutoSize = true;
            this.rbRT.Location = new System.Drawing.Point(56, 3);
            this.rbRT.Name = "rbRT";
            this.rbRT.Size = new System.Drawing.Size(47, 16);
            this.rbRT.TabIndex = 6;
            this.rbRT.TabStop = true;
            this.rbRT.Text = "右上";
            this.rbRT.UseVisualStyleBackColor = true;
            this.rbRT.CheckedChanged += new System.EventHandler(this.rbLocation_CheckedChanged);
            // 
            // rbLT
            // 
            this.rbLT.AutoSize = true;
            this.rbLT.Location = new System.Drawing.Point(3, 3);
            this.rbLT.Name = "rbLT";
            this.rbLT.Size = new System.Drawing.Size(47, 16);
            this.rbLT.TabIndex = 5;
            this.rbLT.TabStop = true;
            this.rbLT.Text = "左上";
            this.rbLT.UseVisualStyleBackColor = true;
            this.rbLT.CheckedChanged += new System.EventHandler(this.rbLocation_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.Controls.Add(this.rbLT);
            this.flowLayoutPanel2.Controls.Add(this.rbRT);
            this.flowLayoutPanel2.Controls.Add(this.rbLB);
            this.flowLayoutPanel2.Controls.Add(this.rbRB);
            this.flowLayoutPanel2.Controls.Add(this.rbCEN);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(81, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(276, 20);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "窗口位置 :";
            // 
            // cbTopMost
            // 
            this.cbTopMost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.Location = new System.Drawing.Point(12, 38);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbTopMost.Size = new System.Drawing.Size(84, 16);
            this.cbTopMost.TabIndex = 5;
            this.cbTopMost.Text = ": 始终置顶";
            this.cbTopMost.UseVisualStyleBackColor = true;
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.cbTopMost_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "预警时间 :";
            // 
            // txtAlarmSec
            // 
            this.txtAlarmSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAlarmSec.Location = new System.Drawing.Point(81, 55);
            this.txtAlarmSec.Name = "txtAlarmSec";
            this.txtAlarmSec.Size = new System.Drawing.Size(45, 21);
            this.txtAlarmSec.TabIndex = 7;
            this.txtAlarmSec.TextChanged += new System.EventHandler(this.txtAlarmSec_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Seconds";
            // 
            // lbOptions
            // 
            this.lbOptions.AutoSize = true;
            this.lbOptions.Location = new System.Drawing.Point(11, 192);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(53, 12);
            this.lbOptions.TabIndex = 15;
            this.lbOptions.Text = "高级设置";
            this.lbOptions.Click += new System.EventHandler(this.lbOptions_Click);
            // 
            // SpeechTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 300);
            this.Controls.Add(this.lbOptions);
            this.Controls.Add(this.lbDot);
            this.Controls.Add(this.lbSecLeft);
            this.Controls.Add(this.lbMinLeft);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeInput);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpeechTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeechTimer";
            this.Load += new System.EventHandler(this.SpeechTimer_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb10Min;
        private System.Windows.Forms.RadioButton rb5Min;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rb15Min;
        private System.Windows.Forms.RadioButton rb20Min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbMinLeft;
        private System.Windows.Forms.Label lbSecLeft;
        private System.Windows.Forms.Label lbDot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlarmSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbTopMost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbLT;
        private System.Windows.Forms.RadioButton rbRT;
        private System.Windows.Forms.RadioButton rbLB;
        private System.Windows.Forms.RadioButton rbRB;
        private System.Windows.Forms.RadioButton rbCEN;
        private System.Windows.Forms.Label lbOptions;
    }
}