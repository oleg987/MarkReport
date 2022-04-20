using Core.Domain;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Parsers
{
    public class GroupParserFromExcel
    {
        private readonly string _pathToDataFile;

        public GroupParserFromExcel(string pathToDataFile)
        {
            _pathToDataFile = pathToDataFile; // TODO: Add null or empty check.
        }

        public IEnumerable<Group> Parse()
        {
            using var package = new ExcelPackage(_pathToDataFile); // TODO: Add null or empty check.

            var workbook = package.Workbook;
            var worksheet = workbook.Worksheets["students"];

            var students = new List<Student>();

            int dataBeginRow = 2;

            while (worksheet.Cells["A" + dataBeginRow].Value is not null && worksheet.Cells["B" + dataBeginRow].Value is not null)
            {
                students.Add(new Student(worksheet.Cells["B" + dataBeginRow].Value.ToString(), worksheet.Cells["A" + dataBeginRow].Value.ToString()));
                dataBeginRow++;
            }

            var uniqueGroupNames = students.Select(s => s.Group).Distinct();

            var groups = new List<Group>(uniqueGroupNames.Count());

            foreach (var group in uniqueGroupNames)
            {
                groups.Add(new Group(group, students.Where(s => s.Group == group)));
            }           

            return groups;
        }
    }
}
