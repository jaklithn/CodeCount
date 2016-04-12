namespace CodeCount
{
    partial class Main
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
            this.btnDirectory = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeExtensions = new System.Windows.Forms.TextBox();
            this.txtLayoutExtensions = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientCodeExtensions = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCommentIndicators = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSkipPatterns = new System.Windows.Forms.TextBox();
            this.txtSqlExtensions = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.myProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblCopyTip = new System.Windows.Forms.Label();
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDirectory
            // 
            this.btnDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectory.Location = new System.Drawing.Point(559, 54);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(26, 23);
            this.btnDirectory.TabIndex = 0;
            this.btnDirectory.Text = "...";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(141, 56);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(412, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Code extensions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodeExtensions
            // 
            this.txtCodeExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeExtensions.Location = new System.Drawing.Point(141, 82);
            this.txtCodeExtensions.Name = "txtCodeExtensions";
            this.txtCodeExtensions.Size = new System.Drawing.Size(412, 20);
            this.txtCodeExtensions.TabIndex = 4;
            // 
            // txtLayoutExtensions
            // 
            this.txtLayoutExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLayoutExtensions.Location = new System.Drawing.Point(141, 160);
            this.txtLayoutExtensions.Name = "txtLayoutExtensions";
            this.txtLayoutExtensions.Size = new System.Drawing.Size(412, 20);
            this.txtLayoutExtensions.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(480, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(73, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Layout extensions:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Client code extensions:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClientCodeExtensions
            // 
            this.txtClientCodeExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientCodeExtensions.Location = new System.Drawing.Point(141, 108);
            this.txtClientCodeExtensions.Name = "txtClientCodeExtensions";
            this.txtClientCodeExtensions.Size = new System.Drawing.Size(412, 20);
            this.txtClientCodeExtensions.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Comment indicators:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCommentIndicators
            // 
            this.txtCommentIndicators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommentIndicators.Location = new System.Drawing.Point(141, 212);
            this.txtCommentIndicators.Name = "txtCommentIndicators";
            this.txtCommentIndicators.Size = new System.Drawing.Size(412, 20);
            this.txtCommentIndicators.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(15, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Skip file patterns:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSkipPatterns
            // 
            this.txtSkipPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSkipPatterns.Location = new System.Drawing.Point(141, 186);
            this.txtSkipPatterns.Name = "txtSkipPatterns";
            this.txtSkipPatterns.Size = new System.Drawing.Size(412, 20);
            this.txtSkipPatterns.TabIndex = 31;
            // 
            // txtSqlExtensions
            // 
            this.txtSqlExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlExtensions.Location = new System.Drawing.Point(141, 134);
            this.txtSqlExtensions.Name = "txtSqlExtensions";
            this.txtSqlExtensions.Size = new System.Drawing.Size(412, 20);
            this.txtSqlExtensions.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(15, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "SQL extensions:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Navy;
            this.txtResult.Location = new System.Drawing.Point(141, 297);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(412, 156);
            this.txtResult.TabIndex = 33;
            this.txtResult.WordWrap = false;
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(141, 246);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(333, 23);
            this.myProgressBar.TabIndex = 35;
            this.myProgressBar.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(138, 15);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(415, 31);
            this.lblInstructions.TabIndex = 37;
            this.lblInstructions.Text = "This utility counts all lines in all files of a given solution directory.\r\nSpecif" +
    "y desired directory and file extensions to be included in your count.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyTip
            // 
            this.lblCopyTip.Location = new System.Drawing.Point(138, 457);
            this.lblCopyTip.Name = "lblCopyTip";
            this.lblCopyTip.Size = new System.Drawing.Size(415, 16);
            this.lblCopyTip.TabIndex = 38;
            this.lblCopyTip.Text = "The result is displayed as plain text to make it easier to copy and reuse if need" +
    "ed.";
            this.lblCopyTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCopyTip.Visible = false;
            // 
            // myBackgroundWorker
            // 
            this.myBackgroundWorker.WorkerReportsProgress = true;
            this.myBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.myBackgroundWorker_DoWork);
            this.myBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.myBackgroundWorker_ProgressChanged);
            this.myBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.myBackgroundWorker_RunWorkerCompleted);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(138, 272);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(415, 16);
            this.lblFeedback.TabIndex = 39;
            this.lblFeedback.Text = "The result is displayed as plain text to make it easier to copy and reuse if need" +
    "ed.";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFeedback.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 482);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblCopyTip);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSkipPatterns);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCommentIndicators);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSqlExtensions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClientCodeExtensions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLayoutExtensions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodeExtensions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnDirectory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeCount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeExtensions;
        private System.Windows.Forms.TextBox txtLayoutExtensions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtClientCodeExtensions;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtCommentIndicators;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtSkipPatterns;
		private System.Windows.Forms.TextBox txtSqlExtensions;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ProgressBar myProgressBar;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblCopyTip;
        private System.ComponentModel.BackgroundWorker myBackgroundWorker;
        private System.Windows.Forms.Label lblFeedback;
    }
}

