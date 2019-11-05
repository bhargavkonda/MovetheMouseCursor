using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(Convert.ToInt32(1000));
                MoveTheMouseCursor();
            }
        }
        private static void MoveTheMouseCursor()
        {
            Point currentPosition = Cursor.Position;
            Point newPosition = new Point(currentPosition.X + 5, currentPosition.Y);
            Cursor.Position = newPosition;
            Thread.Sleep(100);
            Cursor.Position = currentPosition;
        }
    }
}
