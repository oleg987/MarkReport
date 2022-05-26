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
        private string _universityName = "ÎÄÅÑÜÊÈÉ ÍÀÖ²ÎÍÀËÜÍÈÉ ÏÎË²ÒÅÕÍ²×ÍÈÉ ÓÍ²ÂÅĞÑÈÒÅÒ";
        private string _instituteName = "²ÍÑÒÈÒÓÒ ÊÎÌÏ'ŞÒÅĞÍÈÕ ÑÈÑÒÅÌ";

        public MainWindow()
        {
            InitializeComponent();
            ofdDataSource.Filter = "Excel files(*.xlsx) | *.xlsx";
            btnStart.Enabled = false;
            txtUniversity.Text = _universityName;
            txtInstitute.Text = _instituteName;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            _universityName = txtUniversity.Text;
            _instituteName = txtInstitute.Text;

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

                parser.OnError += PrintError;

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
                    parser.OnError -= PrintError;
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
                worker = new MarkReportWorker(studyPrograms, _outputDir, _universityName, _instituteName);

                worker.OnError += PrintError;

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
                    worker.OnError -= PrintError;
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

        private void ñòâîğèòè²íôîğìàö³éíóÁàçóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateDataFile();
        }

        private void âèá³ğÏàïêèÄëÿÃåíåğàö³¿Â³äîìîñòåéToolStripMenuItem_Click(object sender, EventArgs e)
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
                txtOutput.Items.Add($"Created data file in {filePath}");
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

        private void PrintError(object? sender, OnErrorEventArgs e)
        {
            txtOutput.Items.Add(e.Message);
        }

        private void ³íôîğìàö³ÿÏğîÊîğèñòóâàííÿÏğîãğàìîşToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ïğîÏğîãğàìóToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}