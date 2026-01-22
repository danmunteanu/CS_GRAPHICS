namespace CS_GRAPHICS
{
    public partial class MainForm : Form
    {
        private Mandelbrot _fractal = new();
        private EditorMandelbrot _editorMandelbrot = new();

        public MainForm()
        {
            InitializeComponent();

            _editorMandelbrot.Dock = DockStyle.Fill;
            panelEditor.Controls.Clear();
            panelEditor.Controls.Add(_editorMandelbrot);
            _editorMandelbrot.BringToFront();

            _editorMandelbrot.LoadState(_fractal);

            this.CenterToScreen();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            _editorMandelbrot.SaveState(_fractal);

            _fractal.Render();
            pictureBox.Image = _fractal.Buffer;
        }
    }
}
