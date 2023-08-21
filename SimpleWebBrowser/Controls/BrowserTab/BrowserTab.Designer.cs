namespace SimpleWebBrowser.Controls.BrowserTab
{
    partial class BrowserTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            webviewControl = new Microsoft.Web.WebView2.WinForms.WebView2();
            backwardsButton = new Button();
            forwardsButton = new Button();
            urlTextbox = new TextBox();
            searchButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webviewControl).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(webviewControl);
            panel1.Location = new Point(3, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 340);
            panel1.TabIndex = 0;
            // 
            // webviewControl
            // 
            webviewControl.AllowExternalDrop = true;
            webviewControl.CreationProperties = null;
            webviewControl.DefaultBackgroundColor = Color.White;
            webviewControl.Dock = DockStyle.Fill;
            webviewControl.Location = new Point(0, 0);
            webviewControl.Name = "webviewControl";
            webviewControl.Size = new Size(661, 338);
            webviewControl.TabIndex = 0;
            webviewControl.ZoomFactor = 1D;
            // 
            // backwardsButton
            // 
            backwardsButton.BackgroundImage = Properties.Resources.Backward;
            backwardsButton.BackgroundImageLayout = ImageLayout.Stretch;
            backwardsButton.FlatAppearance.BorderSize = 0;
            backwardsButton.FlatStyle = FlatStyle.Flat;
            backwardsButton.Location = new Point(5, 9);
            backwardsButton.Name = "backwardsButton";
            backwardsButton.Size = new Size(66, 38);
            backwardsButton.TabIndex = 1;
            backwardsButton.UseVisualStyleBackColor = true;
            backwardsButton.Click += backwardsButton_Click;
            // 
            // forwardsButton
            // 
            forwardsButton.BackgroundImage = Properties.Resources.Forward;
            forwardsButton.BackgroundImageLayout = ImageLayout.Stretch;
            forwardsButton.FlatAppearance.BorderSize = 0;
            forwardsButton.FlatStyle = FlatStyle.Flat;
            forwardsButton.Location = new Point(77, 9);
            forwardsButton.Name = "forwardsButton";
            forwardsButton.Size = new Size(66, 38);
            forwardsButton.TabIndex = 2;
            forwardsButton.UseVisualStyleBackColor = true;
            forwardsButton.Click += forwardsButton_Click;
            // 
            // urlTextbox
            // 
            urlTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            urlTextbox.BorderStyle = BorderStyle.FixedSingle;
            urlTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            urlTextbox.Location = new Point(149, 8);
            urlTextbox.Name = "urlTextbox";
            urlTextbox.Size = new Size(464, 39);
            urlTextbox.TabIndex = 3;
            urlTextbox.KeyDown += UrlTextbox_KeyDown;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackgroundImage = Properties.Resources.Search;
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Location = new Point(619, 9);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(47, 38);
            searchButton.TabIndex = 4;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // BrowserTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(searchButton);
            Controls.Add(urlTextbox);
            Controls.Add(forwardsButton);
            Controls.Add(backwardsButton);
            Controls.Add(panel1);
            Name = "BrowserTab";
            Size = new Size(669, 396);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webviewControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button backwardsButton;
        private Button forwardsButton;
        private TextBox urlTextbox;
        private Button searchButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webviewControl;
    }
}
