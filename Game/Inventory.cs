using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Inventory
    {
        public List<IItem> _playerInventory = new List<IItem>();
        public void AddToInventory(IItem item)
        {
            _playerInventory.Add(item);
        }
        public void InventoryMenu()
        {
            //Console.Clear();
            Console.WriteLine($"__________________________________________________________________________________________\n\n" +
                $"----------------------------------------INVENTORY-----------------------------------------\n" +
                $"__________________________________________________________________________________________\n\n\n" +
                $"{"TYPE",-8}      {"NAME",-20}      {"DESCRIPTION",50}\n" +
                $"------------------------------------------------------------------------------------------");
            foreach(IItem item in _playerInventory)
            {
                Console.WriteLine($"{item.Type, -8}  ||  {item.Name, -20}  ||  {item.Description, 50}");
            }
            Console.ReadLine();
        }
    }
}
