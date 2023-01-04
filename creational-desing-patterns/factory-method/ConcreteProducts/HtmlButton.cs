public class HtmlButton : IButton
{
    public void OnClick(string e)
    {
        // Bind a web browser click event.
        Console.WriteLine($"Triggering event: {e}");
    }

    public void Render()
    {
        // Return an HTML representation of a button.
        Console.WriteLine("Start rendering HTML button");
    }
}