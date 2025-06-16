using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        var person = new { Name = "John", Age = 30 };
        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine(json);
    }
}