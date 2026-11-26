namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            /* 1- Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            the second price(index 1).*/

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region Question 2

            /* 2- Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
                shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.*/

            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region Question 3

            /* 3- Write a method called PrintWelcomeMessage that takes no parameters and prints
                    "Welcome to the Library!". Call it from Main.*/

            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}

            //static void Main()
            //{
            //    PrintWelcomeMessage();
            //}

            #endregion

            #region Question 4

            /* 4- Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".*/

            //static void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}

            //static void Main()
            //{
            //    PrintBookTitle("Clean Code");
            //}

            #endregion

            #region Question 5

            /* 5- Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward.
             What do you expect to see, and why?*/

            //static void AddBonusPages(int pages)
            //{
            //    pages += 50;
            //}

            //static void Main()
            //{
            //    int pages = 400;
            //    AddBonusPages(pages);
            //    Console.WriteLine(pages); ---> 400 , because the method modifies a copy of the variable and keeps the original.
            //}

            #endregion

            #region Question 6

            /* 6- Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 };
                and print prices[0] afterward. What do you expect to see, and why?*/

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;
            //}

            //static void Main()
            //{
            //    double[] prices = { 25.5, 40.0 };
            //    ApplyDiscount(prices);
            //    Console.WriteLine(prices[0]); ---> 20.5 , because the method modifies the original array since arrays are reference types.
            //}

            #endregion

            #region Question 7

            /* 7- Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
                    Call it and print pages afterward. How is the result different from question 5?*/

            //static void AddBonusPagesByRef(ref int pages)
            //{
            //    pages += 50;
            //}

            //static void Main()
            //{
            //    int pages = 400;
            //    AddBonusPagesByRef(ref pages);
            //    Console.WriteLine(pages); ---> 450 , because the method modifies the original variable by reference.
            //}

            #endregion

            #region Question 8

            /* 8- Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
                new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward.*/

            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}

            //static void Main()
            //{
            //    double[] prices = { 25.5, 40.0, 33.75 };
            //    ReplaceArray(ref prices);
            //    Console.WriteLine(prices.Length); ---> 3
            //}

            #endregion

            #region Question 9

            /* 9- Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 
                if title is "Clean Code", otherwise returns false and sets price to 0. Call it and print the price if found */

            //static bool TryGetPrice(string title, out double price)
            //{
            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    price = 0;
            //    return false;
            //}

            //static void Main()
            //{
            //    if (TryGetPrice("Clean Code", out double price))
            //    {
            //        Console.WriteLine(price);
            //    }
            //}

            #endregion

            #region Question 10

            /* 10- Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.
                Call it once with only a title, and once passing both a title and pages. */

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"{title} - {pages} pages");
            //}

            //static void Main()
            //{
            //    PrintBookInfo("Clean Code");        // pages = 300 (default)
            //    PrintBookInfo("Clean Code", 464);   // pages = 464
            //}

            #endregion
        }
    }
}
