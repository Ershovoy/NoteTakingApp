namespace NoteTakingUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new();
			aboutForm.ShowDialog();
		}
	}
}