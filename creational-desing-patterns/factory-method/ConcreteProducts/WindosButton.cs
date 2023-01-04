public class WindowsButton : IButton
{
    public void OnClick(string e)
    {
        // Bind a native OS click event.
        Console.WriteLine($"Triggering event: {e}");
    }

    public void Render()
    {
        // Render a button in Windows style.
        Console.WriteLine("Start rendering windows button");
    }
}