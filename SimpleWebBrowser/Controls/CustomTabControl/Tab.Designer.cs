namespace SimpleWebBrowser.Controls.CustomTabControl
{
    partial class Tab
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
            titleLabel = new Label();
            tabButton1 = new TabButton();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(3, 8);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(79, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "New Tab";
            titleLabel.TextChanged += Label1_TextChanged;
            // 
            // tabButton1
            // 
            tabButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tabButton1.BackColor = Color.Transparent;
            tabButton1.FlatAppearance.BorderColor = Color.Black;
            tabButton1.FlatAppearance.BorderSize = 0;
            tabButton1.FlatStyle = FlatStyle.Flat;
            tabButton1.ForeColor = Color.Black;
            tabButton1.Location = new Point(68, 4);
            tabButton1.Name = "tabButton1";
            tabButton1.Size = new Size(31, 36);
            tabButton1.TabIndex = 0;
            tabButton1.Text = "X";
            tabButton1.UseVisualStyleBackColor = false;
            tabButton1.Click += TabButton1_Click;
            tabButton1.MouseEnter += TabButton1_MouseHover;
            tabButton1.MouseLeave += TabButton1_MouseLeave;
            tabButton1.MouseHover += TabButton1_MouseHover;
            // 
            // Tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tabButton1);
            Controls.Add(titleLabel);
            Name = "Tab";
            Size = new Size(105, 43);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TabButton tabButton1;
    }
}
