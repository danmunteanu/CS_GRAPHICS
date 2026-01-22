namespace CS_GRAPHICS
{
    public partial class EditorMandelbrot : EditorBase
    {
        public EditorMandelbrot()
        {
            InitializeComponent();

            //  load iterations into cmb box
            int[] iterations = { 64, 128, 256, 512, 768, 1024, 2048 };
            foreach (int iter in iterations)
            {
                cmbMaxIter.Items.Add(iter);
            }
            cmbMaxIter.SelectedIndex = 0;
        }
        public override void LoadState(object item)
        {
            if (item is not Mandelbrot mandel)
                return;

            //  Loads mandelbrot fractal data
            int idx = cmbMaxIter.Items.IndexOf(mandel.MaxIterations);
            if (idx != -1)
                cmbMaxIter.SelectedIndex = idx;
            else
                cmbMaxIter.SelectedIndex = 0;

        }

        public override void SaveState(object item)
        {
            if (item is not Mandelbrot mandel)
                return;

            //  Saves mandelbrot fractal data
            if (cmbMaxIter.SelectedItem is int iterations)
            {
                mandel.MaxIterations = iterations;
            }
        }
    }
}
