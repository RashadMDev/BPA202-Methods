using System.Runtime.CompilerServices;

namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        #region Method with int return type call
        // int price = 1200;
        // int discount = 20;

        // int discountedPrice = price - (price * discount / 100);
        // Console.WriteLine(discountedPrice);

        // System.Console.Write("Enter price: ");
        // int price = Convert.ToInt32(Console.ReadLine());
        // System.Console.Write("Enter discount: ");
        // int discount = Convert.ToInt32(Console.ReadLine());
        // int calculated = CalculateDiscountedPrice(price, discount);
        // Console.WriteLine($"Discounted Price: {calculated}");
        #endregion

        #region Method with boolean return type call
        // System.Console.Write("Enter your age: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // bool isEligible = IsEligibleToVote(age);
        // Console.WriteLine(isEligible);
        #endregion

        #region Method with string return type call

        // Console.Write("Enter first name: ");
        // string firstName = Console.ReadLine();
        // firstName = firstName.Trim().ToUpper();
        // Console.Write("Enter last name: ");
        // string lastName = Console.ReadLine();
        // lastName = lastName.Trim().ToUpper();

        // string fullName = CreateFullName(firstName, lastName);
        // Console.WriteLine(fullName);
        #endregion

        #region Method Overloading Examples call

        // Console.WriteLine(Sum(10, 20, 10));
        // Console.WriteLine(Sum(500, 20));
        // Console.WriteLine(Sum(10.5, 20.3));
        // Console.WriteLine(Sum(10, 20, 30));
        // Console.WriteLine(Sum(100.5, 200.5));

        #endregion

        #region Params Keyword call
        // System.Console.WriteLine(ArrSum(100, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20));
        #endregion

        #region ref out keyword call
        //ref keyword

        // int a = 10;
        // int b = 20;

        // int result = Sum(ref a, b);
        // Console.WriteLine($"Result: {result}");
        // Console.WriteLine($"a: {a} b: {b}");



        //out keyword

        // int a, b;

        // SetValues(out a, out b);
        // Console.WriteLine($"a: {a} b: {b}");



        //ref out together

        // int a = 50, b = 95;
        // Calculate(ref a, b, out int sum, out int multiply);
        // Console.WriteLine($"a: {a} b: {b} sum: {sum} multiply: {multiply}");

        #endregion

    }

    #region Method with int return type
    // public static int CalculateDiscountedPrice(int price, int discount)
    // {
    //     int discountedPrice = price - (price * discount / 100);
    //     return discountedPrice;
    // }
    #endregion

    #region Method with boolean return type

    // public static bool IsEligibleToVote(int age)
    // {
    //     if (age >= 18)
    //     {
    //         return true;
    //     }
    //     return false;
    // }

    #endregion

    #region Method with string return type

    // public static string CreateFullName(string firstName, string lastName = "XXXX")
    // {
    //     return firstName + " " + lastName;
    // }

    #endregion

    #region Method Overloading Examples
    // public static int Sum(int a, int b)
    // {
    //     return a + b;
    // }


    // public static double Sum(double a, double b)
    // {
    //     return a + b;
    // }

    // public static int Sum(int a, int b, int c)
    // {
    //     return a + b + c;
    // }
    #endregion

    #region Params Keyword
    // public static int ArrSum(params int[] numbers)
    // {
    //     int sum = default;
    //     foreach (int number in numbers)
    //     {
    //         sum += number;
    //     }
    //     return sum;
    // }
    #endregion

    #region ref out keyword
    //ref keyword
    // public static int Sum(ref int a, int b)
    // {
    //     return a += b;
    // }


    //out keyword

    // public static void SetValues(out int a, out int b)
    // {
    //     a = 100;
    //     b = 200;
    // }

    //ref out together

    // public static int Calculate(ref int a, int b, out int sum, out int multiply)
    // {
    //     sum = a + b;
    //     multiply = a * b;
    //     a += 10;
    //     b += 20;
    //     return b;
    // }

    #endregion

}