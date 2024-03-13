namespace bryuan;

public partial class MainPage : ContentPage
{


	

	public MainPage()
	{
      InitializeComponent();
	}
private void bbcreditos(object sender, EventArgs args)
  {
    frameSettings.IsVisible = true;
  }

   private void botaovoltar(object sender, EventArgs args)
  {
    frameSettings.IsVisible = false;
  }

private void start(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new JogoPage();
  }


  }
