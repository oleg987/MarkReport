using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Generator
{
    public class DataFileGenerator
    {
        private readonly string _path;

        public DataFileGenerator(string path)
        {
            _path = !string.IsNullOrWhiteSpace(path) ? path : throw new ArgumentNullException(nameof(path));
        }

        public string Generate()
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using var dataFileStream = asm.GetManifestResourceStream("Core.data.xlsx");

            using var dataFile = new ExcelPackage(dataFileStream);

            var filePath = $"{_path}/data{DateTimeOffset.Now.ToUnixTimeSeconds()}.xlsx";

            dataFile.SaveAs(filePath);

            return filePath;
        }
    }
}
