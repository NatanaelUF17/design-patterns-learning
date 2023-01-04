CustomDialog dialog;

var osConfig = string.Empty;

Console.Write("Choose OS config: ");
osConfig = Console.ReadLine();

void Initialize()
{
    if (osConfig?.ToLower() == "windows")
    {
        dialog = new WindowsDialog();
    }
    else if (osConfig?.ToLower() == "web")
    {
        dialog = new WebDialog();
    }
    else
    {
        throw new Exception("Error! Unknown operating system.");
    }
}

Initialize();
dialog.RenderDialog("Opening dialog...");
Console.WriteLine(dialog.GetType()); // Verifying one last time that we are getting the correct instance on runtime.