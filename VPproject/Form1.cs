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
using Emgu.CV;
using Emgu.CV.Structure;

namespace VPproject
{
    public partial class Form1 : Form
    {
        Capture cap;
        bool streaming;
        Stopwatch s = new Stopwatch();
        string path = "";
        private readonly string _tesseractExePath;
        private readonly string _language;

        public Form1()
        {
            InitializeComponent();
            welcome_panel.Visible = true;
            main_pane.Visible = false;
            Font f = new Font("Consolas", 11, FontStyle.Bold);
            browse_btn.Font = f;
            button1.Font = f;
            perform_button.Font = f;
            capture_btn.Font = f;
            streamOnOff.Font = f;
            back_button.Font = f;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            streaming = false;
            cap = new Capture(); 
        }

        private void streamOnOff_Click(object sender, EventArgs e)
        {
            if(!streaming)
            {
                Application.Idle += streamProcess;
                     
            }
            else
            {
                Application.Idle -= streamProcess;

            }

            streaming = !streaming;
             
        }

        private void streamProcess(object sender, System.EventArgs e)
        {
            var img = cap.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.ToBitmap();
            picStream.Image = bmp;
        }

        private void capture_btn_Click(object sender, EventArgs e)
        {
            var img = cap.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.ToBitmap();
            main_pb.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // welcome_panel.Visible = false;
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
        }

            

        private void perform_button_Click(object sender, EventArgs e)
        {
                WaitForm please = new WaitForm();
                please.Visible = true;
                Application.DoEvents();
                //Image image = Image.FromFile(path);
                using (MemoryStream stream = new MemoryStream())
                {
                    // Save image to stream.
                    main_pb.Image.Save(stream, ImageFormat.Bmp);


                    var service = new Form1(@"C:\Program Files\Tesseract-OCR", "eng", @"C:\Program Files\Tesseract-OCR\tessdata");
                    var Text = service.GetText(stream);
                    please.Visible = false;

                    MessageBox.Show(Text);
                }
                browse_tb.Text = "";
                path = "";        

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



        private void main_pane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            main_pane.Visible = false;
            welcome_panel.Visible = true;
        }

        private void streamOnOff_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(streamOnOff, "Starts live picture");
        }
    }
}
