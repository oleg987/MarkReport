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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.fbdOutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdDataSource = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиІнформаційнуБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відновитиШаблонВідомостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідІзПрограмиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateBase = new System.Windows.Forms.Button();
            this.btnOpenBase = new System.Windows.Forms.Button();
            this.btnSelectOutputDir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(615, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 41);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Почати генерацію відомостей";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.FormattingEnabled = true;
            this.txtOutput.HorizontalScrollbar = true;
            this.txtOutput.ItemHeight = 15;
            this.txtOutput.Location = new System.Drawing.Point(158, 64);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(407, 229);
            this.txtOutput.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиІнформаційнуБазуToolStripMenuItem,
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem,
            this.відновитиШаблонВідомостіToolStripMenuItem,
            this.вихідІзПрограмиToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // створитиІнформаційнуБазуToolStripMenuItem
            // 
            this.створитиІнформаційнуБазуToolStripMenuItem.Name = "створитиІнформаційнуБазуToolStripMenuItem";
            this.створитиІнформаційнуБазуToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.створитиІнформаційнуБазуToolStripMenuItem.Text = "Створити інформаційну базу";
            this.створитиІнформаційнуБазуToolStripMenuItem.Click += new System.EventHandler(this.створитиІнформаційнуБазуToolStripMenuItem_Click);
            // 
            // вибірПапкиДляГенераціїВідомостейToolStripMenuItem
            // 
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem.Name = "вибірПапкиДляГенераціїВідомостейToolStripMenuItem";
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem.Text = "Вибір папки для генерації відомостей";
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem.Click += new System.EventHandler(this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem_Click);
            // 
            // відновитиШаблонВідомостіToolStripMenuItem
            // 
            this.відновитиШаблонВідомостіToolStripMenuItem.Name = "відновитиШаблонВідомостіToolStripMenuItem";
            this.відновитиШаблонВідомостіToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.відновитиШаблонВідомостіToolStripMenuItem.Text = "Відновити шаблон відомості";
            this.відновитиШаблонВідомостіToolStripMenuItem.Click += new System.EventHandler(this.відновитиШаблонВідомостіToolStripMenuItem_Click);
            // 
            // вихідІзПрограмиToolStripMenuItem
            // 
            this.вихідІзПрограмиToolStripMenuItem.Name = "вихідІзПрограмиToolStripMenuItem";
            this.вихідІзПрограмиToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.вихідІзПрограмиToolStripMenuItem.Text = "Вихід із програми";
            this.вихідІзПрограмиToolStripMenuItem.Click += new System.EventHandler(this.вихідІзПрограмиToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Довідка";
            // 
            // інформаціяПроКористуванняПрограмоюToolStripMenuItem
            // 
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem.Name = "інформаціяПроКористуванняПрограмоюToolStripMenuItem";
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem.Text = "Інформація про користування програмою";
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem.Click += new System.EventHandler(this.інформаціяПроКористуванняПрограмоюToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(223, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Генератор відомостей (Додаток 3)";
            // 
            // btnCreateBase
            // 
            this.btnCreateBase.Location = new System.Drawing.Point(12, 64);
            this.btnCreateBase.Name = "btnCreateBase";
            this.btnCreateBase.Size = new System.Drawing.Size(140, 40);
            this.btnCreateBase.TabIndex = 10;
            this.btnCreateBase.Text = "Створити інформаційну базу";
            this.btnCreateBase.UseVisualStyleBackColor = true;
            this.btnCreateBase.Click += new System.EventHandler(this.btnCreateBase_Click);
            // 
            // btnOpenBase
            // 
            this.btnOpenBase.Location = new System.Drawing.Point(12, 110);
            this.btnOpenBase.Name = "btnOpenBase";
            this.btnOpenBase.Size = new System.Drawing.Size(140, 42);
            this.btnOpenBase.TabIndex = 11;
            this.btnOpenBase.Text = "Відкрити існуючу інформаційну базу";
            this.btnOpenBase.UseVisualStyleBackColor = true;
            this.btnOpenBase.Click += new System.EventHandler(this.btnOpenBase_Click);
            // 
            // btnSelectOutputDir
            // 
            this.btnSelectOutputDir.Location = new System.Drawing.Point(12, 158);
            this.btnSelectOutputDir.Name = "btnSelectOutputDir";
            this.btnSelectOutputDir.Size = new System.Drawing.Size(140, 41);
            this.btnSelectOutputDir.TabIndex = 12;
            this.btnSelectOutputDir.Text = "Вибір папки для генерації відомостей";
            this.btnSelectOutputDir.UseVisualStyleBackColor = true;
            this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(12, 205);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(140, 41);
            this.btnTemplate.TabIndex = 14;
            this.btnTemplate.Text = "Шаблон відомості";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 356);
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectOutputDir);
            this.Controls.Add(this.btnOpenBase);
            this.Controls.Add(this.btnCreateBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Генератор відомостей (Додаток 3)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FolderBrowserDialog fbdOutputDir;
        private OpenFileDialog ofdDataSource;
        private Button btnStart;
        private ListBox txtOutput;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem створитиІнформаційнуБазуToolStripMenuItem;
        private ToolStripMenuItem вибірПапкиДляГенераціїВідомостейToolStripMenuItem;
        private ToolStripMenuItem вихідІзПрограмиToolStripMenuItem;
        private ToolStripMenuItem інформаціяПроКористуванняПрограмоюToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private Label label3;
        private Button btnCreateBase;
        private Button btnOpenBase;
        private Button btnSelectOutputDir;
        private PictureBox pictureBox1;
        private Button btnTemplate;
        private ToolStripMenuItem відновитиШаблонВідомостіToolStripMenuItem;
    }
}