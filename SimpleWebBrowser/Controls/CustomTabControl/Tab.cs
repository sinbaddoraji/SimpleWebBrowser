namespace SimpleWebBrowser.Controls.CustomTabControl
{
    public partial class Tab : UserControl
    {
        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                if (_selected)
                {
                    UpdateSelectedStyle();
                    TabSelected?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    UpdateDeselectedStyle();
                }
            }
        }

        public string Title
        {
            get => titleLabel.Text;
            set
            {
                if (value.Length > 15)
                {
                    titleLabel.Text = value.Substring(0, 15) + @"..."; // Takes the first 27 characters and appends "..."
                }
                else
                {
                    titleLabel.Text = value;
                }

                // Adjust the width of the Tab control when the title changes
                Label1_TextChanged(titleLabel, EventArgs.Empty);
            }
        }

        private Control _content = null!;
        public Control Content
        {
            get => _content;
            set
            {
                _content = value;
                _content.Dock = DockStyle.Fill;

                _content.TextChanged += (sender, _) =>
                {
                    Title = ((Control)sender)?.Text;
                };
            }
        }

        private bool _selected;

        public event EventHandler TabSelected;
        public Tab()
        {
            InitializeComponent();
            this.Click += Tab_Click;
            foreach (Control childControl in this.Controls)
            {
                childControl.Click += (sender, e) => Tab_Click(this, e); // Propagate child control clicks to the Tab
            }
        }


        private void Label1_TextChanged(object sender, EventArgs e)
        {
            // Calculate the required width for label1's text
            int textWidth = TextRenderer.MeasureText(titleLabel.Text, titleLabel.Font).Width;

            // Width of the button
            int buttonWidth = tabButton1.Width;

            // Spacing between label1 and tabButton1 and any other desired padding
            int spacing = 10; // You can adjust this value based on your design preference

            // Calculate the total width required
            int totalWidth = textWidth + buttonWidth + spacing;

            // Update the width of the Tab control
            this.Width = totalWidth;
        }


        private void Tab_Click(object sender, EventArgs e)
        {
            Selected = true;

            // Optionally: Deselect other tabs in the parent container
            foreach (Control control in this.Parent.Controls)
            {
                if (control is Tab tab && tab != this)
                {
                    tab.Selected = false;
                }
            }
        }


        private void UpdateSelectedStyle()
        {
            // Change the style to indicate selection
            this.BackColor = Color.White; // example
            this.BorderStyle = BorderStyle.None; // Remove the border
        }

        private void UpdateDeselectedStyle()
        {
            // Revert to the default style
            this.BackColor = SystemColors.Control;
            this.BorderStyle = BorderStyle.FixedSingle; // Show the border again
        }


        private void TabButton1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }


        private void TabButton1_MouseHover(object sender, EventArgs e)
        {
            tabButton1.Text = @"X";
        }

        private void TabButton1_MouseLeave(object sender, EventArgs e)
        {
            tabButton1.Text = "";
        }
    }
}
