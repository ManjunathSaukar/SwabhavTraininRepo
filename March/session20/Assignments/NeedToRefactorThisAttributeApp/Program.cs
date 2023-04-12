using NeedToRefactorThisAttributeApp.Model;
using System;
using System.Reflection;

namespace NeedToRefactorThisAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMethodsThatNeedsRefactoring(typeof(Foo));
            FindMethodsThatNeedsRefactoring(typeof(Bar));
        }
        public static void FindMethodsThatNeedsRefactoring(Type type)
        {
            Console.WriteLine($"Methods in {type.Name} that need refactoring:");
            foreach (var method in type.GetMethods())
            {
                if (method.GetCustomAttribute(typeof(NeedToRefactorThis)) != null)
                {
                    Console.WriteLine(method.Name);
                }
            }
        }
    }
}