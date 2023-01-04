public abstract class CustomDialog
{
    public abstract IButton createButton();

    public void RenderDialog(string e = "CloseDialog")
    {
        IButton okButton = createButton();
        okButton.OnClick(e);
        okButton.Render();
    }
}