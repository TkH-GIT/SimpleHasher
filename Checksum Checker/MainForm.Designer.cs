namespace Checksum_Checker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstOpMode = new System.Windows.Forms.ListBox();
            this.lstHash = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input/Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 45);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(435, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(435, 20);
            this.txtInput.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 213);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(471, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(48, 17);
            this.tssStatus.Text = "Ready...";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(185, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(274, 79);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pgbProgress
            // 
            this.pgbProgress.Location = new System.Drawing.Point(12, 93);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(447, 23);
            this.pgbProgress.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstOpMode);
            this.groupBox2.Controls.Add(this.lstHash);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // lstOpMode
            // 
            this.lstOpMode.FormattingEnabled = true;
            this.lstOpMode.Items.AddRange(new object[] {
            "Check",
            "Match"});
            this.lstOpMode.Location = new System.Drawing.Point(86, 19);
            this.lstOpMode.Name = "lstOpMode";
            this.lstOpMode.Size = new System.Drawing.Size(74, 30);
            this.lstOpMode.TabIndex = 5;
            // 
            // lstHash
            // 
            this.lstHash.FormattingEnabled = true;
            this.lstHash.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA512"});
            this.lstHash.Location = new System.Drawing.Point(6, 19);
            this.lstHash.Name = "lstHash";
            this.lstHash.Size = new System.Drawing.Size(74, 56);
            this.lstHash.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 235);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pgbProgress);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checksum Checker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstOpMode;
        private System.Windows.Forms.ListBox lstHash;
    }
}

