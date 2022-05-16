using Core.Domain;
using Core.Events;
using Core.Parsers;
using Core.Workers;

namespace MarkReportUI
{
    public partial class MainWindow : Form
    {
        private string _outputDir;
        private bool _outputDirSet = false;
        private string _dataSourcePath;
        private bool _dataSourcePathSet = false;
        private string _universityName = "Œƒ≈—‹ »… Õ¿÷≤ŒÕ¿À‹Õ»… œŒÀ≤“≈’Õ≤◊Õ»… ”Õ≤¬≈–—»“≈“";
        private string _instituteName = "≤Õ—“»“”“  ŒÃœ'ﬁ“≈–Õ»’ —»—“≈Ã";

        public MainWindow()
        {
            InitializeComponent();
            ofdDataSource.Filter = "Excel files(*.xlsx) | *.xlsx";
            btnStart.Enabled = false;
            txtUniversity.Text = _universityName;
            txtInstitute.Text = _instituteName;
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            if (fbdOutputDir.ShowDialog() == DialogResult.OK)
            {
                _outputDir = fbdOutputDir.SelectedPath;
                _outputDirSet = true;
            }
            CanStart();
        }

        private void btnDataSource_Click(object sender, EventArgs e)
        {
            if (ofdDataSource.ShowDialog() == DialogResult.OK)
            {
                _dataSourcePath = ofdDataSource.FileName;
                _dataSourcePathSet = true;
            }
            CanStart();
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
                MessageBox.Show($"Unknown error: {ex.Message}");                
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
                return;
            }

            MarkReportWorker worker = null;

            bool isSuccess = true;

            try
            {
                worker = new MarkReportWorker(studyPrograms, _outputDir, _universityName, _instituteName);

                worker.OnError += PrintError;

                await worker.CreateMarkReportsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error: {ex.Message}");
            }
            finally
            {
                if (worker is not null)
                {
                    worker.OnError -= PrintError;
                }
            }            
        }

        private void PrintError(object? sender, OnErrorEventArgs e)
        {
            txtOutput.Text += e.Message + "\r\n";
        }

        private void CanStart()
        {
            if (_dataSourcePathSet && _outputDirSet)
            {
                btnStart.Enabled = true;
            }
        }
    }
}