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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDataSource);
            this.Controls.Add(this.btnOutputDir);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOutputDir;
        private FolderBrowserDialog fbdOutputDir;
        private Button btnDataSource;
        private OpenFileDialog ofdDataSource;
        private Button btnStart;
    }
}