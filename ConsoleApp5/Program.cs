//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace ConsoleApp5
{
    /*
    enum :type not char string, include int long byte
    public enum Month {}
    [Flags]
    public enum DAY
    {
        NONE = 0b_0000_0000,
        MONDAY = 0b_0000_0001,
        TUESDAY = 0b_0000_0010,
        WEDNESDAY = 0b_0000_0100,
        THUESDAY = 0b_0000_1000,
        FRIDAY = 0b_0001_0000,
        SATURDAY = 0b_0010_0000,
        SUNDAY = 0b_0100_0000,
        WEEKEND = SATURDAY | SUNDAY,
        BUSDAY = MONDAY | TUESDAY | WEDNESDAY | THUESDAY | FRIDAY
    }

    static IEnumerable<T> Filter<T>(IEnumerable<T> enumerable, Func<T, bool> func)
       {
           foreach(var item in enumerable)
           {
               if(func(item))
               {
                   yield return item;
               }
           }
       }
       */
    // static void Print<T>(T data) { Console.WriteLine(data); }
    /*
                // var article = "Hi new line is here is good for like in the iraq is have nice day goodbye";
                // Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>();
                // foreach (var word in article.Split())
                // {
                //     foreach (var ch in word)
                //     {
                //         char c = Char.ToLower(ch);
                //         if (!dictionary.ContainsKey(c))
                //         {
                //             dictionary.Add(c, new List<string> { word.ToLower() });
                //         }
                //         else
                //         {
                //             dictionary[c].Add(word);
                //         }
                //     }
                // }
                //
                // foreach (var item in dictionary)
                // {
                //     Console.Write($"'{item.Key}'");
                //     foreach (var word in item.Value)
                //     {
                //         Console.WriteLine("\t\t" + word);
                //     }
                // }

                private static void Print(List<Country> list)
       {
       foreach (var country in list)
       {
       Console.WriteLine(country);
       }
       
       
       Console.WriteLine(list.Count);
       Console.WriteLine(list.Capacity);
       }
                */


    internal abstract class Program
    {
        private static void Main()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}