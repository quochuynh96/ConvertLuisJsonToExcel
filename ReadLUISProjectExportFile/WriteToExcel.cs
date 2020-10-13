using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.Linq;

namespace ReadLUISProjectExportFile
{
    public static class WriteToExcel
    {
        public static void Write(ExcelFormat data)
        {
            using (var excelEngine = new ExcelEngine())
            {
                excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2016;

                var intents = new List<string> { "Intents", "Entities" };
                intents.AddRange(data.Intents.Select(i => i.Name).ToList());

                var workbook = excelEngine.Excel.Workbooks.Create(intents.ToArray());

                var worksheet0 = workbook.Worksheets[0];
                var worksheet1 = workbook.Worksheets[1];
                var row0 = 1;
                var row1 = 1;
                foreach (var intent in data.Intents)
                {
                    worksheet0.Range[$"A{row0++}"].Text = intent.Name;
                }

                foreach (var entity in data.Entities)
                {
                    worksheet1.Range[$"A{row1++}"].Text = entity;
                }

                for (var i = 0; i < data.Intents.Count; i++)
                {
                    var intent = data.Intents[i];
                    var row = 1;
                    var worksheet = workbook.Worksheets[i + 2];

                    foreach (var t in intent.Utterances)
                    {
                        worksheet.Range[$"A{row}"].Text = t.Text;
                        worksheet.Range[$"B{row}"].Text = t.GetEntityContent();
                        row++;
                    }
                }

                workbook.SaveAs("Output.xlsx");
            }
        }
    }
}
