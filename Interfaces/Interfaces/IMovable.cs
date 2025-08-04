using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMovable
    {
        public void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The bicycle is moving.");
        }
    }
}
