namespace NoteTakingUI;

public partial class AboutForm : Form
{
	public AboutForm()
	{
		InitializeComponent();
	}

	private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		System.Diagnostics.ProcessStartInfo githubURL = new()
		{
			FileName = "https://github.com/Ershovoy",
			UseShellExecute = true
		};

		try
		{
			System.Diagnostics.Process.Start(githubURL);
		}
		catch (Exception exception)
		{
			MessageBox.Show(exception.Message, "Error occured");
		}
	}
}