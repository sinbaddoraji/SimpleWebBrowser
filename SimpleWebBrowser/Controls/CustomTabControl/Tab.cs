using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebBrowser.Controls.CustomTabControl
{
    public partial class Tab : UserControl
    {
        public bool Selected
        {
            get { return _selected; }
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
            get { return label1.Text; }
            set
            {
                if (value.Length > 15)
                {
                    label1.Text = value.Substring(0, 15) + "..."; // Takes the first 27 characters and appends "..."
                }
                else
                {
                    label1.Text = value;
                }

                // Adjust the width of the Tab control when the title changes
                Label1_TextChanged(label1, EventArgs.Empty);
            }
        }

        private Control _content;
        public Control Content
        {
            get => _content;
            set
            {
                _content = value;
                _content.Dock = DockStyle.Fill;

                _content.TextChanged += (sender, args) =>
                {
                    Title = ((Control)sender).Text;
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

            TabSelected += OnTabSelected;

            
        }

        private void OnTabSelected(object? sender, EventArgs e)
        {
            string url = "https://www.google.com/";
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {
            // Calculate the required width for label1's text
            int textWidth = TextRenderer.MeasureText(label1.Text, label1.Font).Width;

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


        private void tabButton1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }


        private void tabButton1_MouseHover(object sender, EventArgs e)
        {
            tabButton1.Text = "X";
        }

        private void tabButton1_MouseLeave(object sender, EventArgs e)
        {
            tabButton1.Text = "";
        }
    }
}
