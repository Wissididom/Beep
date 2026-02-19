if (OperatingSystem.IsWindows())
{
    if (args.Length < 2 && args.Length > 0)
    {
        if (args[0].Equals("help", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Usage: {AppDomain.CurrentDomain.FriendlyName} <beep frequency|filepath to list of frequencies and durations separated by |, one line per beep|help> [<duration>]");
            return;
        }
        var lines = File.ReadAllLines(args[0]);
        for (int i = 0; i < lines.Length; i++)
        {
            var parts = lines[i].Split('|');
            if (parts.Length < 2)
            {
                Console.WriteLine($"Line {i + 1} does not have 2 integers to use as frequency and duration!");
                continue;
            }
            if (!int.TryParse(parts[0], out var freq))
            {
                Console.WriteLine($"Couldn't convert frequency of line {i + 1} to integer!");
                continue;
            }
            if (!int.TryParse(parts[1], out var duration))
            {
                Console.WriteLine($"Couldn't convert duration of line {i + 1} to integer!");
                continue;
            }
            Console.Beep(freq, duration);
        }
    }
    else if (args.Length > 1)
    {
        Console.Beep(int.Parse(args[0]), int.Parse(args[1]));
    }
    else
    {
        Console.Beep();
    }
}
else
{
    // TODO: Polyfill for Linux and Mac
    Console.WriteLine("This application is only supported on Windows");
    Console.ReadKey();
}
