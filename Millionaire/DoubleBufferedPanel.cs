namespace Millionaire
{
    // Use this instead of Panel, to eliminate flickering
    class DoubleBufferedPanel : System.Windows.Forms.Panel
    {
        public DoubleBufferedPanel() : base()
        {
            DoubleBuffered = true;
        }
    }
}
