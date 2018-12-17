using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BatchRenamer
{
    public partial class BatchRenamerForm : Form
    {
        public BatchRenamerForm()
        {
            InitializeComponent();                       
        }

        private string nameRule = "";

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (nameRule == "")
            {
                MessageBox.Show("请先输入命名规则", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect=true,
                InitialDirectory = Environment.SpecialFolder.Recent.ToString(),
                Title = "选择要重命名的文件"
            };
           
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] fileNames = fileDialog.FileNames;
                Array.Sort(fileNames);

                ProcessRule();
                // rename file name based on name_rule
                foreach(string fileName in fileNames)
                {
                    string newName = GetNewName(fileName);
                    File.Move(fileName, newName);
                }
            }
        }

        private string GetNewName(string originName)
        {
            string nameWithoutPath = Path.GetFileNameWithoutExtension(originName);
           
            return originName;
        }

        private void ProcessRule()
        {
            Regex regex = new Regex(@"(\${.*?})");
            MatchCollection matches = regex.Matches(nameRule);
        }

        private void ApplyRuleButton_Click(object sender, EventArgs e)
        {
            nameRule = NameRuleTextBox.Text;
        }
    }
}
