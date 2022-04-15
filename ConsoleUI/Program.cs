
using Core.Parsers;
using OfficeOpenXml;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

var parser = new GroupParserFromExcel("data.xlsx");

var groups = parser.Parse();

foreach (var group in groups)
{
    Console.WriteLine(group);
}
