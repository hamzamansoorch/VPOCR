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
using IronOcr;



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
        Bitmap c;

        public Form1()
        {
            InitializeComponent();
            welcome_panel.Visible = true;
            main_pane.Visible = false;
            log_pan.Visible = false;
            Font f = new Font("Corbel", 11, FontStyle.Bold);
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
            if (!streaming)
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
            //bmp = new System.Drawing.Bitmap(2, 2, System.Drawing.Imaging.PixelFormat.Format16bppGrayScale);
            Bitmap c = new Bitmap(bmp);


            int width = c.Width;
            int height = c.Height;

            int i = 0;
            Color p;
            c.Save(@"C:\Users\Hamza_PC\Downloads\VP Project Test\abc.bmp");
            //Bitmap d = new Bitmap(c.Width, c.Height);
            int x, y;

            //The we make the cicles to read pixel by pixel and we make the comparation with the withe color.    


            // Loop through the images pixels to reset color.


            if (c != null)
            {
                // Establish a color object.
                Color curColor;
                int ret;
                // The width of the image.
                for (int iX = 0; iX < c.Width; iX++)
                {
                    // The height of the image.
                    for (int iY = 0; iY < c.Height; iY++)
                    {
                        // Get the pixel from bitmap object.
                        curColor = c.GetPixel(iX, iY);
                        // Transform RGB to Y (gray scale)
                        ret = (int)(curColor.R * 0.299 + curColor.G * 0.578 + curColor.B * 0.114);
                        // This is our threshold, you can change it and to try what are different.
                        if (ret > 120)
                        {
                            ret = 255;
                        }
                        else
                        {
                            ret = 0;
                        }
                        // Set the pixel into the bitmap object.
                        c.SetPixel(iX, iY, Color.FromArgb(ret, ret, ret));
                    } // The closing 'The height of the image'.
                } // The closing 'The width of the image'.
                  // Force to redraw.
                Invalidate();

            }

            main_pb.Image = c;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // welcome_panel.Visible = false;
            // main_pane.Visible = true;
            log_pan.Visible = true;
        }



        private void browse_btn_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";


            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap c = new Bitmap(open.FileName);
              //  Bitmap d = new Bitmap(c.Width, c.Height);

                int x, y;

                // Loop through the images pixels to reset color.
                //for (x = 0; x < c.Width; x++)
                //{
                //    for (y = 0; y < c.Height; y++)
                //    {
                //        Color oc = c.GetPixel(x, y);
                //        int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                //        Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                //        d.SetPixel(x, y, nc);
                //    }
                //}
                //if (c != null)
                //{
                //    // Establish a color object.
                //    Color curColor;
                //    int ret;
                //    // The width of the image.
                //    for (int iX = 0; iX < c.Width; iX++)
                //    {
                //        // The height of the image.
                //        for (int iY = 0; iY < c.Height; iY++)
                //        {
                //            // Get the pixel from bitmap object.
                //            curColor = c.GetPixel(iX, iY);
                //            // Transform RGB to Y (gray scale)
                //            ret = (int)(curColor.R * 0.299 + curColor.G * 0.578 + curColor.B * 0.114);
                //            // This is our threshold, you can change it and to try what are different.
                //            if (ret > 120)
                //            {
                //                ret = 255;
                //            }
                //            else
                //            {
                //                ret = 0;
                //            }
                //            // Set the pixel into the bitmap object.
                //            c.SetPixel(iX, iY, Color.FromArgb(ret, ret, ret));
                //        } // The closing 'The height of the image'.
                //    } // The closing 'The width of the image'.
                //      // Force to redraw.
                //    Invalidate();

                //}
                main_pb.Image = c;
                browse_tb.Text = open.FileName;
                path = open.FileName;
                main_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }



        private void perform_button_Click(object sender, EventArgs e)
        {
            var ocr = new IronOcr.AutoOcr();
          
            var img = cap.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.ToBitmap();
            //bmp = new System.Drawing.Bitmap(2, 2, System.Drawing.Imaging.PixelFormat.Format16bppGrayScale);
            //Bitmap c = new Bitmap(bmp);
            
            //{
            //    CleanBackgroundNoise = true,
            //EnhanceContrast = true,
            //EnhanceResolution = true,
            //Language = IronOcr.Languages.English.OcrLanguagePack,
            //Strategy = IronOcr.AdvancedOcr.OcrStrategy.Advanced,
            //ColorSpace = AdvancedOcr.OcrColorSpace.GrayScale,
            //DetectWhiteTextOnDarkBackgrounds = false,
            //InputImageType = AdvancedOcr.InputTypes.Document,
            //RotateAndStraighten = true,
            //ReadBarCodes = false,
            //ColorDepth = 4
            //};

            if (browseCheck.Checked == true)
            {
                WaitForm please = new WaitForm();
                please.Visible = true;
                Application.DoEvents();
                Image image = Image.FromFile(path);
            
                var Area = new System.Drawing.Rectangle();// { X = 0, Y = 0, Height = 250, Width = 640 };

                var Result = ocr.Read(main_pb.Image, Area);
                MessageBox.Show(Result.Text);
                please.Visible = false;

            }
            else if (liveCheck.Checked == true)
            {
                WaitForm please = new WaitForm();
                please.Visible = true;
                Application.DoEvents();
                var Area = new System.Drawing.Rectangle();// { X = 10, Y = 10, Height = 250, Width = 640 };
                var Result = ocr.Read(main_pb.Image, Area);
                MessageBox.Show(Result.Text);
                please.Visible = false;
            }
          
            
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    // Save image to stream.
            //    var Result = ocr.Read(main_pb.Image, Area);

            //    //var service = new Form1(@"C:\Program Files\Tesseract-OCR", "eng", @"C:\Program Files\Tesseract-OCR\tessdata");
            //    //var Text = service.GetText(stream);


            //    MessageBox.Show(Result.Text);
            //    please.Visible = false;
            //}

            //var Result = ocr.Read(image, Area);

            //MessageBox.Show(Result.Text);


            ////Image image = Image.FromFile(path);
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    // Save image to stream.
            //    main_pb.Image.Save(stream, ImageFormat.Bmp);


            //    var service = new Form1(@"C:\Program Files\Tesseract-OCR", "eng", @"C:\Program Files\Tesseract-OCR\tessdata");
            //    var Text = service.GetText(stream);


            //    MessageBox.Show(Text);
            //}
            //browse_tb.Text = "";
            //path = "";        

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

        private void capture_btn_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(capture_btn, "Captures image and displays iin box on right");

        }

        private void browse_btn_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(browse_btn, "Browse image from the system");
        }

        private void perform_button_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(perform_button, "Displays the text of image");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            welcome_panel.Visible = true;
            log_pan.Visible = false;
            main_pane.Visible = true;
            //tb_un.Text = "hamzamansoorch";
            //tb_pw.Text = "1234";
            //if (tb_un.Text== "hamzamansoorch" && tb_pw.Text=="1234")
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Invalid Entries");
            //}
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(c!= null)
            {
                g.DrawImage(c, 140, 10, c.Width, c.Height);
            }
        }
    }
}
