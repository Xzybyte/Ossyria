namespace Ossyria
{
    partial class Ossyria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigation = new System.Windows.Forms.Panel();
            this.news = new System.Windows.Forms.Button();
            this.newsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigation.Controls.Add(this.news);
            this.navigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigation.Location = new System.Drawing.Point(0, 675);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(1154, 105);
            this.navigation.TabIndex = 0;
            // 
            // news
            // 
            this.news.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.news.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.news.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.news.Location = new System.Drawing.Point(34, 21);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(109, 55);
            this.news.TabIndex = 0;
            this.news.Text = "News";
            this.news.UseVisualStyleBackColor = true;
            // 
            // newsPanel
            // 
            this.newsPanel.Location = new System.Drawing.Point(0, 43);
            this.newsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.newsPanel.Size = new System.Drawing.Size(1154, 737);
            this.newsPanel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Ossyria.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(1109, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "\r\n";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Ossyria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1154, 780);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.newsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ossyria";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ossyria_MouseDown);
            this.navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel navigation;
        private Button news;
        private FlowLayoutPanel newsPanel;
        private Button closeButton;
    }
}