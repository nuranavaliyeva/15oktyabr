using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    internal class product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public decimal Price;
        public decimal Cost;
        public decimal Income;
        public int Count;
        public string GetInfo()
        {
            return $"Id: {Id}, Brand: {BrandName}, Model: {Model}, Price: {Price}, Cost: {Cost}, Income: {Income}, Count: {Count}";
        }
        public product(string brandName, string model, decimal price, decimal cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;
            Income = 0;

            Id = $"{BrandName.Substring(0, 2)}{Model.Substring(0, 2)}";
            

        }
        public void Sale(int num)
        {
            if (num > 0)
            {
                decimal totalPrice = Price * num;
                decimal totalCost = Cost * num;
                Income += (totalPrice - totalCost);

                Count -= num;
            }

            else
            {
                Console.WriteLine("Yeterli mehsul yoxdur.");
            }
        }

    }
}
