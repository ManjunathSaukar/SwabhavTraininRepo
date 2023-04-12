using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternApp.Model
{
    internal class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> _childern;
        public Folder(string name)
        {
            _childern = new List<IStorageItem>();
            _name = name;
        }
        public void AddChild(IStorageItem item)
        {
            _childern.Add(item);
        }
        public void Display(int depth = 0)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"{_name}");
            foreach(IStorageItem item in _childern)
            {
                int temp = depth;
                item.Display(++temp);
            }
        }
    }
}
