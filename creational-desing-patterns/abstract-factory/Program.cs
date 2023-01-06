IGUIFactory factory;

var osConfig = string.Empty;

Console.Write("Choose OS config: ");
osConfig = Console.ReadLine();

void Initialize()
{
    if (osConfig?.ToLower() == "windows")
    {
        factory = new WindowsFactory();
    } 
    else if (osConfig?.ToLower() == "mac") 
    {
        factory = new MacFactory();
    }
    else
    {
        throw new Exception("Error! Unknown operating system.");
    }

    Application app = new Application(factory);
    app.CreateUI();
    app.Paint();
}

Initialize();
Console.WriteLine(factory.GetType());