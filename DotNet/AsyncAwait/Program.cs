// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

await SimpleTask();

File.WriteAllText(@"SomeFile.txt", "blah blah blah");
string contents = await ReadFile();
Console.WriteLine(contents);

async Task SimpleTask()
{
    Console.WriteLine("Starting of the task ");
    Task.Delay(2000);
    Console.WriteLine("Task Complete");
}

async Task<string> ReadFile()
{
    using (StreamReader r = new StreamReader(@"SomeFile.txt")) 
    {
        return await r.ReadToEndAsync();
    }
}
