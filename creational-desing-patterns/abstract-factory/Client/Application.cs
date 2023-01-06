public class Application
{
    private IGUIFactory _factory;
    private IButton _button;
    private ICheckbox _checkbox;

    public Application(IGUIFactory factory)
    {
        _factory = factory;
    }

    public void CreateUI()
    {
        _button = _factory.CreateButton();
        _checkbox = _factory.CreateCheckBox();
    }

    public void Paint()
    {
        _button.Paint();
        _checkbox.Paint();
    }
}