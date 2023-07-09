namespace dolare_pesos;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(!String.IsNullOrEmpty(dola.Text))
		{
			double dato1;
			dato1 = Double.Parse(dola.Text);
			double convertir = (dato1 * 17.51);
			peso.Text = "$" + Convert.ToString(convertir) + "Pesos";
		}
		else
		{
			DisplayAlert("Error", "Introduce el campo", "ok");
		}
    }
}

