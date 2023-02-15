using Microsoft.Maui.Platform;

namespace mauiTemplate;

public partial class MainPage : ContentPage {
	public MainPage() {
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e) {
		var droidContext = Handler.MauiContext.Context;
		var myDialog = new MyDialog(droidContext);
		// If you replace the Button with a Label, it will work.
		var dialogContent = new Button { Text = "Hello from the dialog", Padding = new Thickness(30) };
		myDialog.Content = dialogContent.ToPlatform(Application.Current.Handler.MauiContext);
		myDialog.ShowDialog();
	}
}