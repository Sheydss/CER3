using CER3.Controllers;

namespace CER3
{
    public class program
    {
        internal ConsoleController ConsoleController
        {
            get => default;
            set
            {
            }
        }

        static public void Main(string[] args)
        {
            new ConsoleController(100);
        }
    }
}