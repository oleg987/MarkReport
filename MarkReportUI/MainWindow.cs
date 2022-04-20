using Core.Parsers;
using Core.Workers;

namespace MarkReportUI
{
    public partial class MainWindow : Form
    {
        private string _outputDir;
        private string _dataSourcePath;

        public MainWindow()
        {
            InitializeComponent();
            ofdDataSource.Filter = "Excel files(*.xlsx) | *.xlsx";
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            if (fbdOutputDir.ShowDialog() == DialogResult.OK)
            {
                _outputDir = fbdOutputDir.SelectedPath;
            }            
        }

        private void btnDataSource_Click(object sender, EventArgs e)
        {
            if (ofdDataSource.ShowDialog() == DialogResult.OK)
            {
                _dataSourcePath = ofdDataSource.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_outputDir) || string.IsNullOrWhiteSpace(_dataSourcePath))
            {
                MessageBox.Show("Error!!!");
                return;
            }

            var parser = new StudyProgramParserFromExcel(_dataSourcePath);

            var studyPrograms = parser.Parse();

            var worker = new MarkReportWorker(studyPrograms, _outputDir);

            worker.CreateMarkReports();

            MessageBox.Show("Success =)");
        }
    }
}