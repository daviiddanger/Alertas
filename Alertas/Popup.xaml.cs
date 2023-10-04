using MauiPopup;
using MauiPopup.Views;

namespace Alertas;

public partial class Popup : BasePopupPage
{
	public Popup()
	{
		InitializeComponent();
	}

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {
        PopupAction.ClosePopup();
    }
}