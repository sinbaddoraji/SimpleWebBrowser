namespace SimpleWebBrowser.Controls.BrowserTab
{
    public partial class BrowserTab : UserControl
    {
      

        private string _tabName;
        public string TabName
        {
            get
            {
                return _tabName;
            }
            set
            {
                _tabName = value;
                Text = value;
                OnTabNameChanged();
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

        private void CoreWebView2_DocumentTitleChanged(object sender, object e)
        {
            TabName = webviewControl.CoreWebView2.DocumentTitle;
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

        private void urlTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateToUrl(urlTextbox.Text);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            NavigateToUrl(urlTextbox.Text);
        }

        private void OnTabNameChanged()
        {
            // You can implement logic here if you want to reflect the change of tab name elsewhere, 
            // such as updating the tab header if you have a tab control, or triggering some other event.
        }
        
    }
}
