
using Core.Parsers;
using Core.Workers;
using OfficeOpenXml;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

var parser = new StudyProgramParserFromExcel("data.xlsx");

var studyPrograms = parser.Parse();

foreach (var studyProgram in studyPrograms)
{
    Console.WriteLine(studyProgram);
}

var worker = new MarkReportWorker(studyPrograms);

worker.CreateMarkReports();
