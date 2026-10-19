using Backend;
using System.ComponentModel;



var list = new DoublyLinkedList<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Enter value to add: ");
            list.AddOrder(Console.ReadLine()!);
            //Console.WriteLine("Item added successfully.");
            break;
        case "2":
            Console.WriteLine("---List (showing Forward---)");
            Console.WriteLine(list);
            break;
        case "3":
            Console.WriteLine("---List (showing Backward---)");
            Console.WriteLine(list.ToStringReverse());
            break;
        case "4":
            list.ReverseLinks();
            Console.WriteLine("List sorted descending successfully.");
            break;
        case "5":

        case "6":

        case "7":
            Console.Write("Enter value to search: ");
            var itemToSearch = Console.ReadLine()!;
            Console.WriteLine(list.Contains(itemToSearch)
                ? $"The item: '{itemToSearch}' exists!"
                : $"The item: '{itemToSearch}' doesn't exist!");
            break;
        case "8":
            Console.Write("Enter value to remove (first occurrence): ");
            var itemToRemove = Console.ReadLine()!;
            if (!list.Contains(itemToRemove))
            {
                Console.WriteLine($"Item: '{itemToRemove}' not exists in the list.");
                break;
            }
            list.Remove(itemToRemove);
            Console.WriteLine($"Item: '{itemToRemove}' removed.");
            break;
        case "9":

        case "0":
            Console.WriteLine("Exiting program...");
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }

} while (option != "0");

string Menu()
{
    Console.WriteLine("========================================");
    Console.WriteLine("     LINKED LIST WORKSHOP #5            ");
    Console.WriteLine("========================================");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Show forward");
    Console.WriteLine("3. Show backward");
    Console.WriteLine("4. Sort descending");
    Console.WriteLine("5. Show mode(s)");
    Console.WriteLine("6. Show graphic");
    Console.WriteLine("7. Exists");
    Console.WriteLine("8. Remove one occurrence");
    Console.WriteLine("9. Remove all occurrences");
    Console.WriteLine("0. Exit");
    Console.Write("\nEnter your option: ");
    return Console.ReadLine()!;
}