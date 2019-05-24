# Args Router
## About
This is a lightweight module that can handle the C# startup parameters for you.

## How to use
You can use this simply.
``` C#
using System;
using Args_Router;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            args_router.register("writeline", (arg) => {
                foreach (var item in arg)
                {
                    Console.WriteLine(item);
                }
            });

            args_router.run(args);
        }
    }
}
```