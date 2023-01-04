public class WebDialog : CustomDialog
{
    public override IButton createButton()
    {
        return new HtmlButton();
    }

    
}