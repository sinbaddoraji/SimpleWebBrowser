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
            label1 = new Label();
            tabButton1 = new TabButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextChanged += Label1_TextChanged;
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
            tabButton1.Click += tabButton1_Click;
            tabButton1.MouseEnter += tabButton1_MouseHover;
            tabButton1.MouseLeave += tabButton1_MouseLeave;
            tabButton1.MouseHover += tabButton1_MouseHover;
            // 
            // Tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tabButton1);
            Controls.Add(label1);
            Name = "Tab";
            Size = new Size(105, 43);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabButton tabButton1;
    }
}
