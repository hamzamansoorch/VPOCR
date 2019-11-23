using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPproject
{
    public partial class Form1 : Form
    {
        string path = "";
        private readonly string _tesseractExePath;
        private readonly string _language;

        public Form1()
        {
            InitializeComponent();
            welcome_panel.Visible = true;
            main_pane.Visible = false;
        }

        public Form1(string tesseractDir, string language = "en", string dataDir = null)
        {

            //Tesseract Initiation
            // Tesseract configs.
            _tesseractExePath = Path.Combine(tesseractDir, "tesseract.exe");
            _language = language;

            if (String.IsNullOrEmpty(dataDir))
                dataDir = Path.Combine(tesseractDir, "tessdata");

            Environment.SetEnvironmentVariable("TESSDATA_PREFIX", dataDir);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            welcome_panel.Visible = false;
            main_pane.Visible = true;
        }



        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                main_pb.Image = new Bitmap(open.FileName);
                browse_tb.Text = open.FileName;
                path = open.FileName;
                main_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            Image image = Image.FromFile(path);

            using (MemoryStream stream = new MemoryStream())
            {
                // Save image to stream.
                image.Save(stream, ImageFormat.Bmp);


                var service = new Form1(@"C:\Program Files\Tesseract-OCR", "eng", @"C:\Program Files\Tesseract-OCR\tessdata");
                var Text = service.GetText(stream);
                MessageBox.Show(Text);
            }
        }

        //TEXT Tesseract code
        public string GetText(params Stream[] images)
        {
            var output = string.Empty;

            if (images.Any())
            {
                var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                Directory.CreateDirectory(tempPath);
                var tempInputFile = NewTempFileName(tempPath);
                var tempOutputFile = NewTempFileName(tempPath);

                try
                {
                    WriteInputFiles(images, tempPath, tempInputFile);

                    var info = new ProcessStartInfo
                    {
                        FileName = _tesseractExePath,
                        Arguments = $"{tempInputFile} {tempOutputFile} -l {_language}",
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };

                    using (var ps = Process.Start(info))
                    {
                        ps.WaitForExit();

                        var exitCode = ps.ExitCode;

                        if (exitCode == 0)
                        {
                            output = File.ReadAllText(tempOutputFile + ".txt");
                        }
                        else
                        {
                            var stderr = ps.StandardError.ReadToEnd();
                            throw new InvalidOperationException(stderr);
                        }
                    }
                }
                finally
                {
                    Directory.Delete(tempPath, true);
                }
            }

            return output;
        }

        private static void WriteInputFiles(Stream[] inputStreams, string tempPath, string tempInputFile)
        {
            // If there is more thant one image file, so build the list file using the images as input files.
            if (inputStreams.Length > 1)
            {
                var imagesListFileContent = new StringBuilder();

                foreach (var inputStream in inputStreams)
                {
                    var imageFile = NewTempFileName(tempPath);

                    using (var tempStream = File.OpenWrite(imageFile))
                    {
                        CopyStream(inputStream, tempStream);
                    }

                    imagesListFileContent.AppendLine(imageFile);
                }

                File.WriteAllText(tempInputFile, imagesListFileContent.ToString());
            }
            else
            {
                // If is only one image file, than use the image file as input file.
                using (var tempStream = File.OpenWrite(tempInputFile))
                {
                    CopyStream(inputStreams.First(), tempStream);
                }
            }
        }

        private static void CopyStream(Stream input, Stream output)
        {
            if (input.CanSeek)
                input.Seek(0, SeekOrigin.Begin);

            input.CopyTo(output);
            input.Close();
        }

        private static string NewTempFileName(string tempPath)
        {
            return Path.Combine(tempPath, Guid.NewGuid().ToString());
        }

    }
}
