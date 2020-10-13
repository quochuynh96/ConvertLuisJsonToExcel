using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ReadLUISProjectExportFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ReadFileContent(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        private void btnSelectJson_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var fileName = openFileDialog1.FileName;
            txbJsonPath.Text = fileName;
            try
            {
                var content = ReadFileContent(fileName);
                var prjObj = JsonConvert.DeserializeObject<LUISProject>(content);

                foreach (var u in prjObj.Utterances)
                {
                    u.SetContentForEntities();
                }

                var excel = new ExcelFormat(prjObj);
                txbContent.Text = JsonConvert.SerializeObject(excel, Formatting.Indented);
                WriteToExcel.Write(excel);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
