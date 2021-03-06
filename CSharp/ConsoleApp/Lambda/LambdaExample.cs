﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Lambda
{
    public class LambdaExample
    {
        Func<int, int, int> Calculator { get; set; }
        Action<int> SomeAction { get; set; }
        Action AnotherAction { get; set; }

        public void Test()
        {
            Calculator += //delegate (int a, int b) { return a + b};
                          //(a, b) => { return a + b; };
                          (a, b) => a + b;

            SomeAction += //(a) => Console.WriteLine(a);
                            a => Console.WriteLine(a);

            AnotherAction += () => Console.WriteLine("Action!");

            SomeMethod(s =>
            {
                var @string = s.Replace(',', '0');
                Console.WriteLine(@string);
            },
            "ABC,ABC,ABC");
        }       

        void SomeMethod(Action<string> stringAction, string @string )
        {
            stringAction.Invoke(@string);
        }
    }
}
