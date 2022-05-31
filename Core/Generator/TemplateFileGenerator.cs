using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Generator
{
    public class TemplateFileGenerator
    {
        public void Generate()
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using var dataFileStream = asm.GetManifestResourceStream("Core.baseTemplate.xlsx");

            using var dataFile = new ExcelPackage(dataFileStream);

            var file = new FileInfo("template.xlsx");

            if (file.Exists)
            {
                file.Delete();
            }

            dataFile.SaveAs("template.xlsx");
        }
    }
}
