namespace Homework8;
class Program
{
    static void Main(string[] args)
    {
        // Creating Customer objects and customer_list
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Call Q1 method
        TotalCredits(customer_list);
        // Call Q2 method
        AmarilloAverageAge(customer_list);
        // Call Q3 method
        CanyonAge(customer_list);
    }

    // Q1. Calculate and print the total credit of all customers in the customer_list
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = customer_list.Sum(c => c.CustomerCredit);
        Console.WriteLine($"Q1: The total credits: {totalCredit:F1}");
    }

    // Q2. Calculate and print the average age of customers living in Amarillo
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        var amarilloCustomers = customer_list.Where(c => c.CustomerCity == "Amarillo");
        double averageAge = amarilloCustomers.Average(c => c.CustomerAge);
        Console.WriteLine($"Q2: The average age of customers in Amarillo: {averageAge:F2}");
    }

    // Q3. Print the names of customers who live in Canyon and are older than 30
    public static void CanyonAge(Customer[] customer_list)
    {
        var canyonCustomers = customer_list.Where(c => c.CustomerCity == "Canyon" && c.CustomerAge > 30);
        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");
        Console.WriteLine(string.Join(", ", canyonCustomers.Select(c => c.CustomerName)));
    }
}

// Q0. Create a class called Customer
class Customer
{
    public string CustomerName { get; set; }
    public int CustomerAge { get; set; }
    public string CustomerCity { get; set; }
    public double CustomerCredit { get; set; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}