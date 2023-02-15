using Android.Content;
using Android.OS;
using View = Android.Views.View;
using Google.Android.Material.BottomSheet;

namespace mauiTemplate;

public class MyDialog : BottomSheetDialog {
    public View Content { get; set; }

    public MyDialog(Context context) : base(context) {}

    protected override void OnCreate(Bundle savedInstanceState) {
        base.OnCreate(savedInstanceState);
        SetContentView(Content);
    }

    public void ShowDialog() {
        if (!IsShowing)
            Show();
    }
}