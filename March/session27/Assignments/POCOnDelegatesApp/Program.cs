using POCOnDelegatesApp.Model;

namespace POCOnDelegatesApp
{
    public delegate void Calculation(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation(Calculator.Add);
            calculation.Invoke(10, 5); // calculation(10,5);
            calculation = Calculator.Subtract;
            calculation.Invoke(10, 5);
            calculation = Calculator.Multiply;
            calculation.Invoke(10, 5);
            calculation = Calculator.Divide;
            calculation.Invoke(10, 5);
        }
    }
}