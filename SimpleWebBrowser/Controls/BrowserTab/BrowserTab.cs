namespace SimpleWebBrowser.Controls.BrowserTab
{
    public partial class BrowserTab : UserControl
    {
        private string _tabName = null!;
        public string TabName
        {
            get => _tabName;
            set
            {
                _tabName = value;
                Text = value;
            }
        }

        public BrowserTab()
        {
            InitializeComponent();
            InitializeWebView2();
        }

        private async void InitializeWebView2()
        {
            await webviewControl.EnsureCoreWebView2Async(null);
            webviewControl.Source = new Uri("https://www.google.com");
            webviewControl.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
        }

        private void CoreWebView2_DocumentTitleChanged(object? sender, object e)
        {
            TabName = webviewControl.CoreWebView2.DocumentTitle;
            urlTextbox.Text = webviewControl.Source.ToString();
        }

        private void NavigateToUrl(string url)
        {
            if (webviewControl != null && Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                webviewControl.Source = uri;
            }
        }

        private void backwardsButton_Click(object sender, EventArgs e)
        {
            if (webviewControl.CanGoBack)
            {
                webviewControl.GoBack();
            }
        }

        private void forwardsButton_Click(object sender, EventArgs e)
        {
            if (webviewControl.CanGoForward)
            {
                webviewControl.GoForward();
            }
        }

        private void UrlTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateToUrl(urlTextbox.Text);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            NavigateToUrl(urlTextbox.Text);
        }
    }
}
