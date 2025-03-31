using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sorter
{
    public partial class Menu: Form
    {
        public string dir = "";
        public List<string> PictureExt = new List<string>();
        public List<string> VideoExt = new List<string>();
        public List<string> AudioExt = new List<string>();
        public List<string> DocExt = new List<string>();
        public List<string> ArchivesExt = new List<string>();
        public List<string> AppExt = new List<string>();

        public Menu()
        {
            InitializeComponent();
            if (!File.Exists($"{Environment.CurrentDirectory}\\settings.cfg")) Default_conf();
            ExtLoader();
        }

        public void Default_conf()
        {
            StreamWriter wrt = new StreamWriter($"{Environment.CurrentDirectory}\\settings.cfg");
            wrt.Write("-----Extention----- \r\n" + "Picture: .jpg .png .jpeg .webp .ico .svg .gif \r\n" +
                "Video: .mp4 .avi .mkv .mkv .mov .wmv \r\n" + "Audio: .mp3 .wav .flac .aac .ogg .m4a .wma \r\n" +
                "Doc: .doc .docx .rtf .txt .pdf .odt .xls .xlsx .ppt .pptx .csv .html .xml \r\n" +
                "Archives: .zip .7z .rar .iso .cab \r\n" + "App: .exe .bat .cmd .com \r\n");
            wrt.Close();
        }

        public void ExtLoader()
        {
            string[] lines = File.ReadAllLines($"{Environment.CurrentDirectory}\\settings.cfg");
            foreach (string exts in lines)
            {
                if (exts.Contains("Picture")) PictureExt.AddRange(exts.Substring(exts.IndexOf(":") + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                else if (exts.Contains("Video")) VideoExt.AddRange(exts.Substring(exts.IndexOf(":") + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                else if (exts.Contains("Audio")) AudioExt.AddRange(exts.Substring(exts.IndexOf(":") + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                else if (exts.Contains("Doc")) DocExt.AddRange(exts.Substring(exts.IndexOf(":") + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                else if (exts.Contains("Archives")) ArchivesExt.AddRange(exts.Substring(exts.IndexOf(":") + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                else if (exts.Contains("App")) AppExt.AddRange(exts.Substring(exts.IndexOf(":") + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }

        public void Upload_Click(object sender, EventArgs e)
        {
            if (Loader.ShowDialog() == DialogResult.OK)
            {
                AllFiles.Text = null;
                dir = Loader.SelectedPath;
                label1.Text = dir;
                Review(dir);
            }
            else return;
        }
        public void Review(string directory)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            foreach (FileInfo file in dir.GetFiles())
            {
                AllFiles.Text += file.Name + "\r\n";
            }
        }

        public static class Sorting
        {

            public static void Picture(string directory, List<string> values)
            {
                List<string> ext = new List<string>(values);
                DirectoryInfo dir = new DirectoryInfo(directory);
                dir.CreateSubdirectory(@"Картинки");
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (ext.Contains(file.Extension.ToLower())) file.MoveTo($"{dir}\\Картинки\\{file.Name}");
                }
                bool empty = (Directory.EnumerateFiles($"{directory}\\Картинки").Count() == 0) ? true : false;
                if (empty) Directory.Delete($"{directory}\\Картинки");
            }
            public static void Video(string directory, List<string> values)
            {
                List<string> ext = new List<string>(values);
                DirectoryInfo dir = new DirectoryInfo(directory);
                dir.CreateSubdirectory(@"Видео");
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (ext.Contains(file.Extension.ToLower())) file.MoveTo($"{dir}\\Видео\\{file.Name}");
                }
                bool empty = (Directory.EnumerateFiles($"{directory}\\Видео").Count() == 0) ? true : false;
                if (empty) Directory.Delete($"{directory}\\Видео");
            }
            public static void Audio(string directory, List<string> values)
            {
                List<string> ext = new List<string>(values);
                DirectoryInfo dir = new DirectoryInfo(directory);
                dir.CreateSubdirectory(@"Музыка");
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (ext.Contains(file.Extension.ToLower())) file.MoveTo($"{dir}\\Музыка\\{file.Name}");
                }
                bool empty = (Directory.EnumerateFiles($"{directory}\\Музыка").Count() == 0) ? true : false;
                if (empty) Directory.Delete($"{directory}\\Музыка");
            }
            public static void Doc(string directory, List<string> values)
            {
                List<string> ext = new List<string>(values);
                DirectoryInfo dir = new DirectoryInfo(directory);
                dir.CreateSubdirectory(@"Документы");
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (ext.Contains(file.Extension.ToLower())) file.MoveTo($"{dir}\\Документы\\{file.Name}");
                }
                bool empty = (Directory.EnumerateFiles($"{directory}\\Документы").Count() == 0) ? true : false;
                if (empty) Directory.Delete($"{directory}\\Документы");
            }

            public static void Archives(string directory, List<string> values)
            {
                List<string> ext = new List<string>(values);
                DirectoryInfo dir = new DirectoryInfo(directory);
                dir.CreateSubdirectory(@"Архивы");
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (ext.Contains(file.Extension.ToLower())) file.MoveTo($"{dir}\\Архивы\\{file.Name}");
                }
                bool empty = (Directory.EnumerateFiles($"{directory}\\Архивы").Count() == 0) ? true : false;
                if (empty) Directory.Delete($"{directory}\\Архивы");
            }
            
            public static void App(string directory, List<string> values)
            {
                List<string> ext = new List<string>(values);
                DirectoryInfo dir = new DirectoryInfo(directory);
                dir.CreateSubdirectory(@"Приложения");
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (ext.Contains(file.Extension.ToLower())) file.MoveTo($"{dir}\\Приложения\\{file.Name}");
                }
                bool empty = (Directory.EnumerateFiles($"{directory}\\Приложения").Count() == 0) ? true : false;
                if (empty) Directory.Delete($"{directory}\\Приложения");
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            bool statement;
            CheckBox check = sender as CheckBox;
            statement = check.Checked ? true : false;
            check.Checked = statement;
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ctrl in Controls.OfType<CheckBox>())
            {
                switch (ctrl.Name)
                {
                    case "Picture":
                        if (ctrl.Checked) Sorting.Picture(dir, PictureExt);
                        break;
                    case "Video":
                        if (ctrl.Checked) Sorting.Video(dir, VideoExt);
                        break;
                    case "Doc":
                        if (ctrl.Checked) Sorting.Doc(dir, DocExt);
                        break;
                    case "Audio":
                        if (ctrl.Checked) Sorting.Audio(dir, AudioExt);
                        break;
                    case "Archives":
                        if (ctrl.Checked) Sorting.Archives(dir, ArchivesExt);
                        break;
                    case "App":
                        if (ctrl.Checked) Sorting.App(dir, AppExt);
                        break;
                }
            } 
        }
    }
}
