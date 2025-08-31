using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining.Snippets
{
    internal class Cup
    {
        IDrink drink;
        
        public Cup(IDrink drink)
        {
            this.drink = drink;
        }

        public void Fill()
        {
            this.drink.Pour();
        }
    }
    interface IDrink
    {
        void Pour();
    }

    class OrangeJuice : IDrink
    {
        public void Pour()
        {
            Console.WriteLine("Orange Juice is pouirng...");
        }
    }

    class Water : IDrink
    {
        public void Pour()
        {
            Console.WriteLine("Water is pouring...");
        }
    }
}
