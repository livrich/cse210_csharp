/* Note to Self
Things that could be improved:
- Have preset products and a UI that lets user choose a product from a list
- Ask user if they want to add another product
        * Instead of asking how many they want to add once upfront
- Way to add as many orders as user wants (instead of hardcoded 2 orders)
        * Loop that asks user if they want to add another order
- Error handling code incase user types string where int is required
        * Such as with quantity of product
- Add area code to address
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        // List of orders
        List<Order> orders = new List<Order>();

        // Order 1
        Console.WriteLine("Order 1:");
        Order order1 = MakeOrder();

        // Determine how many products to add to order
        Console.Write($"Hi {order1.GetCustomer().GetName()}, how many " +
        "products do you want to add to your order: ");
        int numP1 = Int32.Parse(Console.ReadLine());
        int i = 0;
        // Add right number of products
        while (i < numP1)
        {
            // Calls CreateProduct then adds product 
            // list of products in Order
            order1.AddProductToOrder();
            // Increment count variable
            i++;
        }

        // Calculate total price of order
        order1.CalcOrderTotal();

        // Add order to list of orders
        orders.Add(order1);


        // Order 2
        Console.WriteLine("\nOrder 2:");
        Order order2 = MakeOrder();

        // Determine how many products to add to order
        Console.Write($"Hi {order2.GetCustomer().GetName()}, how many " +
        "products do you want to add to your order: ");
        int numP2 = Int32.Parse(Console.ReadLine());
        int ii = 0;
        // Add right number of products
        while (ii < numP2)
        {
            // Calls CreateProduct then adds product 
            // list of products in Order
            order2.AddProductToOrder();
            // Increment count variable
            ii ++;
        }

        // Calculate total price of order
        order2.CalcOrderTotal();

        // Add order to list of orders
        orders.Add(order2);


        // Display information about orders
        foreach (Order o in orders)
        {
            DisplayOrder(o);
        }


        // Function to create an order
        Order MakeOrder()
        {
            Order o = new Order();
            return o;
        }

        // Function to display order information
        void DisplayOrder(Order order)
        {
            // Header message
            Console.WriteLine("\n\nOrder Information");
            // Packing label
            order.PackingLabel();
            // Blank line for better readability
            Console.WriteLine();
            // Shipping label
            order.ShippingLabel();
            // Blank line for better readability
            Console.WriteLine();
            // Total price of order
            Console.WriteLine($"Total: ${order.GetOrderTotal()}");
        }

        // // Instance of Product class
        // Product p = new Product("Rubber Duck", "123", 1.50, 20);
        // // Test to see if class is working
        // Console.WriteLine(p.GetName());
        // Console.WriteLine(p.ComputePrice());

        // // Instance of Address class
        // Address a = new Address("743 E Whisper Bend Dr", "Draper", "UT", "USA");
        // // Test to see if class is working
        // Console.WriteLine(a.GetStateProvince());
        // Console.WriteLine(a.IsInUSA());
        // Console.WriteLine(a.SingleString());

        // // Instance of Customer class
        // Customer c = new Customer("Jake");
        // // Test to see if class is working
        // Console.WriteLine(c.GetAddress());
        // Address address = c.GetAddress();
        // Console.WriteLine(address.SingleString());
    }
}