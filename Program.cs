using System;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Energy.Core.Tilde.WriteLine("~y~Welcome");
            string name = Energy.Core.Tilde.Input("~g~Enter your name: ", "");
            if ((name = name.Trim()).Length > 0)
            {
                Energy.Core.Tilde.WriteLine($"~w~Hello, ~r~{name}~w~!");
                Energy.Core.Tilde.WriteLine("~c~Nice to meet you.");
            }
            Energy.Core.Tilde.Pause();
        }
    }
}
