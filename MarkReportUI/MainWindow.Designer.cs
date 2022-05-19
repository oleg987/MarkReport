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
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.txtInstitute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиІнформаційнуБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиНазвуУніверситетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиНазвуІнститутуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідІзПрограмиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateBase = new System.Windows.Forms.Button();
            this.btnOpenBase = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.txtOutput.ItemHeight = 15;
            this.txtOutput.Location = new System.Drawing.Point(158, 121);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(407, 214);
            this.txtOutput.TabIndex = 3;
            // 
            // txtUniversity
            // 
            this.txtUniversity.Location = new System.Drawing.Point(158, 92);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(407, 23);
            this.txtUniversity.TabIndex = 4;
            // 
            // txtInstitute
            // 
            this.txtInstitute.Location = new System.Drawing.Point(158, 61);
            this.txtInstitute.Name = "txtInstitute";
            this.txtInstitute.Size = new System.Drawing.Size(407, 23);
            this.txtInstitute.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Назва університету:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Назва інституту:";
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
            this.змінитиНазвуУніверситетуToolStripMenuItem,
            this.змінитиНазвуІнститутуToolStripMenuItem,
            this.вихідІзПрограмиToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
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
            // створитиІнформаційнуБазуToolStripMenuItem
            // 
            this.створитиІнформаційнуБазуToolStripMenuItem.Name = "створитиІнформаційнуБазуToolStripMenuItem";
            this.створитиІнформаційнуБазуToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.створитиІнформаційнуБазуToolStripMenuItem.Text = "Створити інформаційну базу";
            // 
            // вибірПапкиДляГенераціїВідомостейToolStripMenuItem
            // 
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem.Name = "вибірПапкиДляГенераціїВідомостейToolStripMenuItem";
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.вибірПапкиДляГенераціїВідомостейToolStripMenuItem.Text = "Вибір папки для генерації відомостей";
            // 
            // змінитиНазвуУніверситетуToolStripMenuItem
            // 
            this.змінитиНазвуУніверситетуToolStripMenuItem.Name = "змінитиНазвуУніверситетуToolStripMenuItem";
            this.змінитиНазвуУніверситетуToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.змінитиНазвуУніверситетуToolStripMenuItem.Text = "Змінити назву університету";
            // 
            // змінитиНазвуІнститутуToolStripMenuItem
            // 
            this.змінитиНазвуІнститутуToolStripMenuItem.Name = "змінитиНазвуІнститутуToolStripMenuItem";
            this.змінитиНазвуІнститутуToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.змінитиНазвуІнститутуToolStripMenuItem.Text = "Змінити назву інституту";
            // 
            // вихідІзПрограмиToolStripMenuItem
            // 
            this.вихідІзПрограмиToolStripMenuItem.Name = "вихідІзПрограмиToolStripMenuItem";
            this.вихідІзПрограмиToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.вихідІзПрограмиToolStripMenuItem.Text = "Вихід із програми";
            // 
            // інформаціяПроКористуванняПрограмоюToolStripMenuItem
            // 
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem.Name = "інформаціяПроКористуванняПрограмоюToolStripMenuItem";
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.інформаціяПроКористуванняПрограмоюToolStripMenuItem.Text = "Інформація про користування програмою";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
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
            this.btnCreateBase.Location = new System.Drawing.Point(12, 121);
            this.btnCreateBase.Name = "btnCreateBase";
            this.btnCreateBase.Size = new System.Drawing.Size(140, 40);
            this.btnCreateBase.TabIndex = 10;
            this.btnCreateBase.Text = "Створити інформаційну базу";
            this.btnCreateBase.UseVisualStyleBackColor = true;
            // 
            // btnOpenBase
            // 
            this.btnOpenBase.Location = new System.Drawing.Point(12, 167);
            this.btnOpenBase.Name = "btnOpenBase";
            this.btnOpenBase.Size = new System.Drawing.Size(140, 42);
            this.btnOpenBase.TabIndex = 11;
            this.btnOpenBase.Text = "Відкрити існуючу інформаційну базу";
            this.btnOpenBase.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Вибір папки для генерації відомостей";
            this.button3.UseVisualStyleBackColor = true;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOpenBase);
            this.Controls.Add(this.btnCreateBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstitute);
            this.Controls.Add(this.txtUniversity);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private TextBox txtUniversity;
        private TextBox txtInstitute;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem створитиІнформаційнуБазуToolStripMenuItem;
        private ToolStripMenuItem вибірПапкиДляГенераціїВідомостейToolStripMenuItem;
        private ToolStripMenuItem змінитиНазвуУніверситетуToolStripMenuItem;
        private ToolStripMenuItem змінитиНазвуІнститутуToolStripMenuItem;
        private ToolStripMenuItem вихідІзПрограмиToolStripMenuItem;
        private ToolStripMenuItem інформаціяПроКористуванняПрограмоюToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private Label label3;
        private Button btnCreateBase;
        private Button btnOpenBase;
        private Button button3;
        private PictureBox pictureBox1;
    }
}