using Backend;



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

        case "3":

        case "4":

        case "5":

        case "6":

        case "7":

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