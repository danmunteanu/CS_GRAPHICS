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

            //  3. Loop though every pixel on the screen
            for (int x = 0; x < _imageWidth; x++)
            {
                for (int y = 0; y < _imageHeight; y++)
                {
                    //  4. Convert pixel (x, y) to a complex number (a + bi)
                    double a = _viewportMinX + (x * (_viewportMaxX - _viewportMinX) / _imageWidth);
                    double b = _viewportMinY + (y * (_viewportMaxY - _viewportMinY) / _imageHeight);

                    //  Z = Z^2 + c, c = (a + bi)

                    double zx = 0;
                    double zy = 0;

                    int iterations = 0;
                    while (iterations < _maxIterations)
                    {
                        //  Check the distance from origin
                        //  Did the point escape?
                        if (zx * zx + zy * zy > 4.0)
                            break;

                        /*  Squaring a complex number
                         *  Z = x + yi
                         *  Z^2 = (x + yi) * (x + yi)
                         *         x * x + x * y * i + x * y * i + y * y * i * i
                         *         x^2 + 2 * x * y * i - y^2
                         *         (x^2 - y^2) + (2 * x * y) * i
                         *         
                         * Adding a constant to a complex number
                         *  Z^2 + c = (x^2 - y^2 + a) + (2 * x * y + b) * i
                         */

                        //  Compute the next Z
                        //  this is the result of Z^2 + (a + bi)
                        //  (zx + zyi)^2 ... 
                        double nextZx = (zx * zx - zy * zy) + a;
                        double nextZy = (2 * zx * zy) + b;

                        zx = nextZx;
                        zy = nextZy;

                        iterations++;
                    }

                    if (iterations == _maxIterations)
                    {
                        //  paint the pixel black
                        bmp.SetPixel(x, y, Color.Black);

                        
                    }
                    else
                    {
                        //  simple grayscale color
                        int colorVal = (int)(255 * (double)iterations / _maxIterations);
                        bmp.SetPixel(x, y, Color.FromArgb(colorVal, colorVal, colorVal));
                    }
                }
            }

            pictureBox.Image = bmp;
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            RenderMandelbrot();
        }
    }
}
