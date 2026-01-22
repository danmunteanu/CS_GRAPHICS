namespace CS_GRAPHICS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.CenterToScreen();

            RenderMandelbrot();
        }

        private void RenderMandelbrot()
        {
            //  1. Get image dimensions
            int width = 1024;// pictureBox.Width;
            int height = 768;// pictureBox.Height;
            Bitmap bmp = new Bitmap(width, height);

            //  2. Define our "world" boundaries (complex plane)
            double minX = -2.0;
            double maxX = 1.0;
            double minY = -1.2;
            double maxY = 1.2;

            int maxIterations = 128;

            //  3. Loop though every pixel on the screen
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //  4. Convert pixel (x, y) to a complex number (a + bi)
                    double a = minX + (x * (maxX - minX) / width);
                    double b = minY + (y * (maxY - minY) / height);

                    //  Z = Z^2 + c, c = (a + bi)

                    double zx = 0;
                    double zy = 0;

                    int iterations = 0;
                    while (iterations < maxIterations)
                    {
                        //  Check the distance from origin
                        //  Did the point escape?
                        if (zx * zx + zy * zy > 4.0)
                            break;

                        //  Compute the next Z
                        //  this is the result of Z^2 + (a + bi)
                        //  (zx + zyi)^2 ... 
                        double nextZx = (zx * zx - zy * zy) + a;
                        double nextZy = (2 * zx * zy) + b;

                        zx = nextZx;
                        zy = nextZy;

                        iterations++;
                    }

                    if (iterations == maxIterations)
                    {
                        //  paint the pixel black
                        bmp.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        //  simple grayscale color
                        int colorVal = (int)(255 * (double)iterations / maxIterations);
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
