using System.Collections.Generic;
using System.Linq;

namespace ReadLUISProjectExportFile
{
    public class ExcelFormat
    {
        public List<ExcelFormatIntent> Intents { get; set; }

        public List<string> Entities { get; set; }

        public ExcelFormat(LUISProject project)
        {
            Intents = new List<ExcelFormatIntent>();
            Entities = new List<string>();

            foreach (var entity in project.Intents)
            {
                Intents.Add(new ExcelFormatIntent
                {
                    Name = entity.Name,
                    Utterances = new List<ExcelFormatUtterance>()
                });
            }

            foreach (var utterance in project.Utterances)
            {
                var intent = Intents.FirstOrDefault(i => i.Name == utterance.Intent);

                var entities = utterance.Entities.Select(entity => new ExcelFormatEntity { Name = entity.Entity, Content = entity.Content }).ToList();

                intent?.Utterances?.Add(new ExcelFormatUtterance
                {
                    Text = utterance.Text,
                    Entities = entities
                });
            }

            foreach (var entity in project.Entities)
            {
                Entities.Add(entity.Name);
            }
        }
    }

    public class ExcelFormatIntent
    {
        public string Name { get; set; }
        public List<ExcelFormatUtterance> Utterances { get; set; }
    }

    public class ExcelFormatUtterance
    {
        public string Text { get; set; }
        public List<ExcelFormatEntity> Entities { get; set; }

        public string GetEntityContent()
        {
            return string.Join(",", Entities.Select(e => $"{e.Name}: {e.Content}").ToArray());
        }
    }

    public class ExcelFormatEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
