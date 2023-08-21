using System;

namespace ConsoleApp5
{

    public class Command
    {
        /*
     // Peek تؤشر على قمة الاستاك
           Stack<int> a = new Stack<int>(new[] { 1, 2, 3, 4, 5 });
           while (a.Count > 0)
           {
           Console.WriteLine(a.Pop());
           
           }
            static void Print(string name, Stack<Command> command)
               {
               Console.WriteLine($"{name} history");
               Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkMagenta : ConsoleColor.DarkBlue;
               foreach (var item in command)
               {
               Console.WriteLine(item);
               
               }
               
               Console.BackgroundColor = ConsoleColor.Black;
               }
                    Stack<Command> undo = new Stack<Command>();
                    Stack<Command> redo = new Stack<Command>();
                    string line;
                    while (true)
                    {
                        Console.Write("url 'exit'");
                        line = Console.ReadLine().ToLower();
                        if (line == "exit")
                            break;
                        else if (line == "back")
                        {
                            if (undo.Count > 0)
                                redo.Push(undo.Pop());
                            else
                                continue;
                        }
                        else if (line == "forward")
                        {
                            if (redo.Count > 0)
                                undo.Push(redo.Pop());
                            else
                                continue;
                        }
                        else
                        {
                            undo.Push(new Command(line));
                        }
                        Console.Clear();
                        Print("Back", undo);
                        Print("Forward", redo);
    
                    }
                    */

        private readonly DateTime _creatAT;
        private readonly string _url;

        public Command(string url)
        {
            _creatAT = DateTime.Now;
            _url = url;
        }

        public override string ToString()
        {
            return $"{_creatAT:yyyy-MM-dd hh:mm:ss} : {_url}";
        }
    }
}