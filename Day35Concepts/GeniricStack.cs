using System;
using System.Collections.Generic;

namespace Day35Concepts.GeniricStack
{
    public class StackExample
    {
        static ShoppingCart _shoppingCart;
        public void ShoppingCartUsingStack()
        {
            int option = 0;
            _shoppingCart = new ShoppingCart();

            while (option != 5)
            {
                Console.WriteLine("\n\t\t Menu-select the Option");
                Console.WriteLine("\t\t--------");
                Console.WriteLine("\t\t 1.Add an Item into the shopping Cart");
                Console.WriteLine("\t\t 2. Undo");
                Console.WriteLine("\t\t 3.Redo");
                Console.WriteLine("\t\t 4.View Cart");
                Console.WriteLine("Option:");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.WriteLine("Enter an Item (type'n' to stop):");
                            var itemName = Console.ReadLine().ToLower();
                            if (itemName != "n")
                            {
                                _shoppingCart.Add(itemName);
                            }
                            repeat = itemName == "n" ? false : true;
                        }
                        ShowCartItems();
                        break;
                    case 2:
                        _shoppingCart.Undo();
                        ShowCartItems();
                        break;
                    case 3:
                        _shoppingCart.Redo();
                        ShowCartItems();
                        break;
                    case 4:
                        ShowCartItems();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }

        public void ShowCartItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t Cart Items");
            Console.WriteLine("\t--------");
            _shoppingCart.ViewCart();
            Console.WriteLine("\t-------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class ShoppingCart
    {
        Stack<string> cart = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        public void Add(string itemName)
        {
            cart.Push(itemName);
        }

        public void Undo()
        {
            var item = cart.Pop();
            redoStack.Push(item);
        }

        public void Redo()
        {
            var item = redoStack.Pop();
            cart.Push(item);
        }

        public void ViewCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}

