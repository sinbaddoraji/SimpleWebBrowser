namespace SimpleWebBrowser.Controls.CustomTabControl
{
    public partial class TabControl<T> : UserControl where T : Control, new()
    {
        private List<Tab> tabs = new List<Tab>();

        public TabControl()
        {
            InitializeComponent();
            AddTab();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void Tab_TabSelected(object sender, EventArgs e)
        {
            if (sender is Tab selectedTab)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(selectedTab.Content);
                selectedTab.Content.Dock = DockStyle.Fill;
            }
        }


        private void AddTab()
        {
            Tab tab = new Tab()
            {
                Title = "New Tab"
            };
            tab.TabSelected += Tab_TabSelected;

            //flowLayoutPanel1.Controls.Count > 0 should always be true because there is an add button

            flowLayoutPanel1.Controls.Add(tab); // Temporarily add to the end
            Control tmp = flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];
            flowLayoutPanel1.Controls.SetChildIndex(tmp, flowLayoutPanel1.Controls.Count - 2); // Move to second last position
            
            
            tab.Content = new T();

            tabs.Add(tab);

            tab.Selected = true;
        }
    }
}
