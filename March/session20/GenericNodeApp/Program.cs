using GenericNodeApp.Model;
using System.Xml.Linq;

namespace GenericNodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nodeA= new Node<object>();
            var nodeB= new Node<object>();
            var nodeC= new Node<object>();
            var nodeD = new Node<object>();
            var nodeE = new Node<object>();
            var nodeF = new Node<object>();

            nodeA.Data= 100;
            nodeB.Data= 200;
            nodeC.Data= 300;
            nodeD.Data = "Manjunath";
            nodeE.Data = "Abhi";
            nodeF.Data = "Srinivas";

            nodeA.Next= nodeB;
            nodeB.Next= nodeC;
            nodeC.Next = nodeD;
            nodeD.Next = nodeE;
            nodeE.Next = nodeF;
            PrintDetails(nodeA);
            //PrintDetails(nodeD);
        }

        private static void PrintDetails<T>(Node<T> node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }
}