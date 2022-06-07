using Ossyria.News;

namespace Ossyria
{
    public partial class Ossyria : Form
    {

        private Parse newsParse = new Parse();

        public Ossyria()
        {
            InitializeComponent();
            newsParse.LoadPage();
            LoadNews();
        }
        private void Ossyria_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }

        public void LoadNews()
        {
            foreach (var post in newsParse.GetPosts())
            {
                Panel newPanel = new Panel();
                newPanel.Size = new Size(374, 301);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(374, 211);                
                pictureBox.LoadAsync(post.BackgroundImage);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Top;
                pictureBox.Click += (s, e) => OpenPage(s, e, post.Link);
                pictureBox.MouseEnter += (s, e) => PanelEnter(s, e, newPanel);
                pictureBox.MouseLeave += (s, e) => PanelLeave(s, e, newPanel);

                Label title = new Label();
                title.Text = post.Title;
                title.Width = pictureBox.Width;
                title.TextAlign = ContentAlignment.MiddleCenter;
                title.Location = new Point(0, 212);

                newPanel.Click += (s, e) => OpenPage(s, e, post.Link);
                newPanel.MouseEnter += (s, e) => PanelEnter(s, e, newPanel);
                newPanel.MouseLeave += (s, e) => PanelLeave(s, e, newPanel);
                newPanel.BackColor = Color.White;
                newPanel.BorderStyle = BorderStyle.FixedSingle;
                newPanel.Controls.Add(title);
                newPanel.Controls.Add(pictureBox);
                newsPanel.Controls.Add(newPanel);

            }
        }

        private void OpenPage(object? sender, EventArgs e, string link)
        {
            System.Diagnostics.Debug.WriteLine(link);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://maplestory.nexon.net" + link) {
                UseShellExecute = true
            });
        }

        private void PanelEnter(object? sender, EventArgs e, Panel panel)
        {
            this.Cursor = Cursors.Hand;
        }

        private void PanelLeave(object? sender, EventArgs e, Panel panel)
        {
            this.Cursor = Cursors.Default;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}