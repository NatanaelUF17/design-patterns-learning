public class WindowsDialog : CustomDialog
{
    public override IButton createButton()
    {
        return new WindowsButton();
    }
}