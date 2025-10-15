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
}
