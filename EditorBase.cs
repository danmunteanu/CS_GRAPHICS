namespace CS_GRAPHICS
{
    public partial class EditorBase : UserControl
    {
        public EditorBase()
        {
            InitializeComponent();
        }

        public virtual void LoadState(object item)
            => throw new NotImplementedException("Implement LoadState()");

        public virtual void SaveState(object item)
            => throw new NotImplementedException("Implement SaveState()");

        public virtual void ResetState() {}

        public virtual bool ValidateState() => true;

    }
}
