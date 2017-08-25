using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CurrencyReplacer
{
    public partial class MainForm : Form
    {
        //MySettings mySettings = new MySettings();
        string SearchWord = "EUR";
        string FileExtension = "*.txt";
        string SourcePath = @"C:\Work\";
        public string DestinationPath = @"C:\Work1";
        private string[] sourceDirectoryFiles;
        string[] FilesFound;
        string subDestinationPathMore = @"\MoreThan100\";
        string subDestinationPathLess = @"\LessThan100\";
        double DoubleFinalValue = 0.0;
        int countMoreFiles = 0;
        int countLessFiles = 0;
        int total = 0;
        int countFIles = 0;

        public MainForm()
        {
            InitializeComponent();
            tbSourceFolder.Text = SourcePath;
            tbDestinationFolder.Text = DestinationPath;
        }

        private void BtnMoreBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogMore.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialogMore.SelectedPath))
            {
                SourcePath = Path.GetDirectoryName(folderBrowserDialogMore.SelectedPath);
                FilesFound = Directory.GetFiles(folderBrowserDialogMore.SelectedPath);
                SourcePath = tbSourceFolder.Text = folderBrowserDialogMore.SelectedPath;
                MessageBox.Show("Files found: " + FilesFound.Length.ToString(), "Message");
            }
        }

        private void BtnLessBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogLess.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialogLess.SelectedPath))
            {
                DestinationPath = Path.GetDirectoryName(folderBrowserDialogLess.SelectedPath);
                var FilesFound = Directory.GetFiles(folderBrowserDialogLess.SelectedPath);
                DestinationPath = tbDestinationFolder.Text = folderBrowserDialogLess.SelectedPath;
                MessageBox.Show("Files found: " + FilesFound.Length.ToString(), "Message");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Value = 0;
            backgroundWorker.RunWorkerAsync();
        }

        private void SearchMoney(string fileName, double MaxValue, string[] readContents)
        {
            #region Directorys creation
            if (!Directory.Exists(SourcePath))
                Directory.CreateDirectory(SourcePath);
            if (!Directory.Exists(DestinationPath))
                Directory.CreateDirectory(DestinationPath);
            if (!Directory.Exists(DestinationPath + subDestinationPathMore))
                Directory.CreateDirectory(DestinationPath + subDestinationPathMore);
            if (!Directory.Exists(DestinationPath + subDestinationPathLess))
                Directory.CreateDirectory(DestinationPath + subDestinationPathLess); 
            #endregion

            sourceDirectoryFiles = Directory.GetFiles(tbSourceFolder.Text);
            countFIles = Convert.ToInt32(sourceDirectoryFiles.Length);

            #region Here was foreach
            foreach (var line in readContents)
            {
                //Go next line if word wasn't found
                if (!line.Contains(SearchWord))
                    continue;

                #region Get number logic
                var stringFinalValue = new StringBuilder();
                var startIndex = line.IndexOf(SearchWord);
                var lineCharArray = line.Substring(startIndex, 8).ToCharArray();

                //TODO: replace logic with Regex Match
                foreach (var symbol in lineCharArray)
                {
                    if (Char.IsDigit(symbol) || symbol == '.')
                        stringFinalValue.Append(symbol);
                    else if (symbol == ',')
                        stringFinalValue.Append('.');
                }

                if (stringFinalValue.Length == 0)
                    continue;

                //DoubleFinalValue = Convert.ToDouble(stringFinalValue.ToString());
                DoubleFinalValue = Double.Parse(stringFinalValue.ToString());

                if (DoubleFinalValue > MaxValue)
                    MaxValue = DoubleFinalValue;
                #endregion
            }

            #region Replacing file
            try
            {
                if (MaxValue > 100)
                {
                    File.Copy(SourcePath + "\\" + fileName, DestinationPath + subDestinationPathMore + fileName, true);
                    countMoreFiles++;
                }
                else if (MaxValue < 100)
                {
                    File.Copy(SourcePath + "\\" + fileName, DestinationPath + subDestinationPathLess + fileName, true);
                    countLessFiles++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
            total++;
            #endregion
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            foreach (var file in Directory.EnumerateFiles(SourcePath, FileExtension, SearchOption.AllDirectories))
            {
                var fileName = Path.GetFileName(file);
                var MaxValue = 0.0;
                var readContents = File.ReadAllLines(file);

                SearchMoney(fileName, MaxValue, readContents);
                
                int persentage = Convert.ToInt32((total * 100) / countFIles);
                backgroundWorker.ReportProgress(persentage);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var text = $"TOTAL: {countFIles} \r\nThere are {countMoreFiles} files > 100 \r\n AND " +
                                           $"\r\nThere are {countLessFiles} files < 100";

            MessageBox.Show(text, "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            progressBar.Value = 0;
            countMoreFiles = 0;
            countLessFiles = 0;
            total = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (File.Exists("settings.xml"))
            //{
            //    MySettings settings = new MySettings();
            //    settings = mySettings.Deserialize();

            //    SearchWord = settings.SearchWord;
            //    fileExtension = settings.FileExtension;
            //    SourcePath = settings.SourcePath;
            //    DestinationPath = settings.DestinationPath;
            //    tbSourceFolder.Text = SourcePath;
            //    tbDestinationFolder.Text = DestinationPath;
            //}
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mySettings = new MySettings();
            //mySettings.Serialize(mySettings);
            Application.Exit();
        }

        #region Mouse move over TextBoxes
        private void TbSourceFolder_MouseMove(object sender, MouseEventArgs e)
        {
            tbSourceFolder.Text = "Source path";
        }

        private void TbSourceFolder_MouseLeave(object sender, EventArgs e)
        {
            tbSourceFolder.Text = SourcePath;
        }

        private void TbDestinationFolder_MouseMove(object sender, MouseEventArgs e)
        {
            tbDestinationFolder.Text = "Destination path";
        }

        private void TbDestinationFolder_MouseLeave(object sender, EventArgs e)
        {
            tbDestinationFolder.Text = DestinationPath;
        }
        #endregion
    }
}