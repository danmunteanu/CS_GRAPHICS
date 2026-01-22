using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CS_GRAPHICS
{
    public partial class MainForm : Form
    {
        //  1. Get image dimensions
        private int _imageWidth = 1024;
        private int _imageHeight = 768;

        //  2. Define our "world" boundaries (complex plane)
        private double _viewportMinX = -2.0;
        private double _viewportMaxX = 1.0;
        private double _viewportMinY = -1.2;
        private double _viewportMaxY = 1.2;

        private int _maxIterations = 128;

        public MainForm()
        {
            InitializeComponent();

            this.CenterToScreen();

            RenderMandelbrot();
        }

        private void RenderMandelbrot()
        {
            Bitmap bmp = new Bitmap(_imageWidth, _imageHeight);

            //  Lock the Bitmap's memory
            Rectangle rect = new Rectangle(0, 0, _imageWidth, _imageHeight);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            //  Calculate how many bytes we need to store the whole image
            int bytes = Math.Abs(bmpData.Stride) * _imageHeight;

            //  Create temp byte array to hold our color data
            byte[] rgbValues = new byte[bytes];

            for (int y = 0; y < _imageHeight; y++)
            {
                //  Pre-calculation: Find the start of the row in the flat array
                int rowOffset = y * bmpData.Stride;

                for (int x = 0; x < _imageWidth; x++)
                {
                    //  4. Convert pixel (x, y) to a complex number (a + bi)
                    //  Map from image to complex plane
                    double a = _viewportMinX + (x * (_viewportMaxX - _viewportMinX) / _imageWidth);
                    double b = _viewportMinY + (y * (_viewportMaxY - _viewportMinY) / _imageHeight);

                    //  Z = Z^2 + c, c = (a + bi)

                    double zx = 0;
                    double zy = 0;

                    int iterations = 0;
                    while (iterations < _maxIterations && (zx * zx + zy * zy < 4.0))
                    {
                        //  Compute the next Z
                        //  this is the result of Z^2 + (a + bi)
                        //  (zx + zyi)^2 ... 
                        double nextZx = (zx * zx - zy * zy) + a;
                        double nextZy = (2 * zx * zy) + b;

                        zx = nextZx;
                        zy = nextZy;

                        iterations++;
                    }

                    //  Calculate the pixel index
                    //  Each pixel has bytes. 
                    //  [index] = Blue, [index + 1] = Green, [Index + 2] = Red, [Index + 3] = Alpha
                    int index = rowOffset + (x * 4);

                    if (iterations == _maxIterations)
                    {
                        rgbValues[index] = 0;           //  B
                        rgbValues[index + 1] = 0;       //  G
                        rgbValues[index + 2] = 0;       //  R
                        rgbValues[index + 3] = 255;     //  A
                    }
                    else
                    {
                        //  simple grayscale color
                        byte colorVal = (byte)(255 * (double)iterations / _maxIterations);

                        rgbValues[index] = colorVal;        //  B
                        rgbValues[index + 1] = colorVal;    //  G
                        rgbValues[index + 2] = colorVal;    //  R
                        rgbValues[index + 3] = 255;         //  A
                    }
                }
            }

            //  "teleport' the entire byte array into the Bitmap's memory address
            //  Scan0 is the memory address of the first pixel
            //  Instead of moving one pixel at a time, we move the entire image data
            //  in a very fast operation
            Marshal.Copy(rgbValues, 0, bmpData.Scan0, bytes);

            bmp.UnlockBits(bmpData);

            pictureBox.Image = bmp;
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            RenderMandelbrot();
        }
    }
}
