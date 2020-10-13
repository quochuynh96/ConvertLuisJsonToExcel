using System.Collections.Generic;

namespace ReadLUISProjectExportFile
{
    public class LUISProject
    {
        public List<LUISIntent> Intents { get; set; }
        public List<LUISEntity> Entities { get; set; }
        public List<LUISUtterance> Utterances { get; set; }
    }

    public class LUISIntent
    {
        public string Name { get; set; }
    }

    public class LUISEntity
    {
        public string Name { get; set; }
    }

    public class LUISUtterance
    {
        public string Text { get; set; }
        public string Intent { get; set; }
        public List<LUISUtteranceEntity> Entities { get; set; }

        public void SetContentForEntities()
        {
            foreach (var e in Entities)
            {
                e.SetContent(Text);
            }
        }
    }

    public class LUISUtteranceEntity
    {
        public string Entity { get; set; }
        public int StartPos { get; set; }
        public int EndPos { get; set; }
        public string Content { get; set; }

        public void SetContent(string text)
        {
            Content = text.Substring(StartPos, EndPos - StartPos + 1);
        }
    }
}
