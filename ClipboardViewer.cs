using System.Runtime.InteropServices;

namespace ClipboardManager
{
    public partial class ClipboardViewer : Form
    {
        private List<string> clipboardHistory = new List<string>();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        public ClipboardViewer()
        {
            InitializeComponent();
            this.Load += ClipboardViewer_Load;
        }

        private void ClipboardViewer_Load(object sender, EventArgs e)
        {
            SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0308) // WM_DRAWCLIPBOARD
            {
                OnClipboardUpdate();
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void OnClipboardUpdate()
        {
            if (Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();
                AddClipboardTextToHistory(text);
            }
        }

        private void AddClipboardTextToHistory(string text)
        {
            if (!clipboardHistory.Contains(text))
            {
                clipboardHistory.Insert(0, text);
                UpdateClipboardList();
            }
        }

        private void UpdateClipboardList()
        {
            lstClipboardHistory.Items.Clear();
            foreach (var item in clipboardHistory)
            {
                lstClipboardHistory.Items.Add(item);
            }
        }

        private void lstClipboardHistory_DoubleClick(object sender, EventArgs e)
        {
            if (lstClipboardHistory.SelectedItem != null)
            {
                Clipboard.SetText(lstClipboardHistory.SelectedItem.ToString());
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            clipboardHistory.Clear();
            UpdateClipboardList();
        }

    }
}
