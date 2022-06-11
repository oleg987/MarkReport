using Core.Domain;
using Core.Events;
using Core.Generator;
using Core.Parsers;
using Core.Workers;
using System.Diagnostics;

namespace MarkReportUI
{
    public partial class MainWindow : Form
    {
        private string _outputDir;
        private bool _outputDirSet = false;
        private string _dataSourcePath;
        private bool _dataSourcePathSet = false;

        public MainWindow()
        {
            InitializeComponent();
            ofdDataSource.Filter = "Excel files(*.xlsx) | *.xlsx";
            btnStart.Enabled = false;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            txtOutput.Items.Clear();

            if (string.IsNullOrWhiteSpace(_outputDir) || string.IsNullOrWhiteSpace(_dataSourcePath))
            {
                MessageBox.Show("Error!!!");
                return;
            }

            IEnumerable<StudyProgram> studyPrograms = null;

            StudyProgramParserFromExcel parser = null;

            try
            {
                parser = new StudyProgramParserFromExcel(_dataSourcePath);

                parser.OnMessage += PrintMessage;

                studyPrograms = parser.Parse();
            }
            catch (Exception ex)
            {
                txtOutput.Items.Add(ex.Message);
                return;
            }
            finally
            {
                if (parser is not null)
                {
                    parser.OnMessage -= PrintMessage;
                }
            }

            if (studyPrograms is null)
            {
                txtOutput.Items.Add("No study programs.");
                return;
            }

            MarkReportWorker worker = null;

            try
            {
                worker = new MarkReportWorker(studyPrograms, _outputDir);

                worker.OnMessage += PrintMessage;

                await worker.CreateMarkReportsAsync();
            }
            catch (Exception ex)
            {
                txtOutput.Items.Add(ex.Message);
                return;
            }
            finally
            {
                if (worker is not null)
                {
                    worker.OnMessage -= PrintMessage;
                }
            }

            txtOutput.Items.Add("Success!");

            var processInfo = new ProcessStartInfo
            {
                FileName = _outputDir,
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(processInfo);
        }

        private void btnOpenBase_Click(object sender, EventArgs e)
        {
            if (ofdDataSource.ShowDialog() == DialogResult.OK)
            {
                _dataSourcePath = ofdDataSource.FileName;
                _dataSourcePathSet = true;
            }
            CanStart();
        }

        private void btnCreateBase_Click(object sender, EventArgs e)
        {
            GenerateDataFile();
        }

        private void створитиІнформаційнуБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateDataFile();
        }

        private void вибірПапкиДляГенераціїВідомостейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectOutputDir();
        }

        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            SelectOutputDir();
        }

        private void GenerateDataFile()
        {
            if (fbdOutputDir.ShowDialog() == DialogResult.OK)
            {
                var generator = new DataFileGenerator(fbdOutputDir.SelectedPath);
                var filePath = generator.Generate();
                _dataSourcePath = filePath;
                _dataSourcePathSet = true;
                var processInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };
                Process.Start(processInfo);

                PrintMessage(null, new OnMessageEventArgs($"Створено файл інформаційної бази в директорії: {filePath}"));                
            }
            CanStart();
        }

        private void SelectOutputDir()
        {
            if (fbdOutputDir.ShowDialog() == DialogResult.OK)
            {
                _outputDir = fbdOutputDir.SelectedPath;
                _outputDirSet = true;
            }
            CanStart();
        }

        private void CanStart()
        {
            if (_dataSourcePathSet && _outputDirSet)
            {
                btnStart.Enabled = true;
            }
        }

        private void PrintMessage(object? sender, OnMessageEventArgs e)
        {
            if (e is not null && string.IsNullOrWhiteSpace(e.Message))
            {
                int messageLength = e.Message.Length;
                for (int i = 0; i < e.Message.Length; i += 45)
                {
                    messageLength -= 45;
                    txtOutput.Items.Add(messageLength > 0 ? e.Message.Substring(i, 45) : e.Message.Substring(i));
                }
            }
        }

        private void інформаціяПроКористуванняПрограмоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = "Info.html",
                UseShellExecute = true
            };
            Process.Start(processInfo);
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = "About.html",
                UseShellExecute = true
            };
            Process.Start(processInfo);
        }

        private void вихідІзПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = "template.xlsx",
                UseShellExecute = true
            };
            Process.Start(processInfo);
        }

        private void відновитиШаблонВідомостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var generator = new TemplateFileGenerator();

            generator.Generate();

            var processInfo = new ProcessStartInfo
            {
                FileName = "template.xlsx",
                UseShellExecute = true
            };
            Process.Start(processInfo);
        }
    }
}