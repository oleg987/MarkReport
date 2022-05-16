namespace MarkReportUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.fbdOutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDataSource = new System.Windows.Forms.Button();
            this.ofdDataSource = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.ListBox();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.txtInstitute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Location = new System.Drawing.Point(17, 14);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(134, 41);
            this.btnOutputDir.TabIndex = 0;
            this.btnOutputDir.Text = "Select output directory";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // btnDataSource
            // 
            this.btnDataSource.Location = new System.Drawing.Point(17, 61);
            this.btnDataSource.Name = "btnDataSource";
            this.btnDataSource.Size = new System.Drawing.Size(134, 47);
            this.btnDataSource.TabIndex = 1;
            this.btnDataSource.Text = "Select data source file";
            this.btnDataSource.UseVisualStyleBackColor = true;
            this.btnDataSource.Click += new System.EventHandler(this.btnDataSource_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 44);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.FormattingEnabled = true;
            this.txtOutput.ItemHeight = 15;
            this.txtOutput.Location = new System.Drawing.Point(157, 114);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(631, 424);
            this.txtOutput.TabIndex = 3;
            // 
            // txtUniversity
            // 
            this.txtUniversity.Location = new System.Drawing.Point(225, 24);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(563, 23);
            this.txtUniversity.TabIndex = 4;
            // 
            // txtInstitute
            // 
            this.txtInstitute.Location = new System.Drawing.Point(225, 74);
            this.txtInstitute.Name = "txtInstitute";
            this.txtInstitute.Size = new System.Drawing.Size(563, 23);
            this.txtInstitute.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "University:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Institute:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstitute);
            this.Controls.Add(this.txtUniversity);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDataSource);
            this.Controls.Add(this.btnOutputDir);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOutputDir;
        private FolderBrowserDialog fbdOutputDir;
        private Button btnDataSource;
        private OpenFileDialog ofdDataSource;
        private Button btnStart;
        private ListBox txtOutput;
        private TextBox txtUniversity;
        private TextBox txtInstitute;
        private Label label1;
        private Label label2;
    }
}