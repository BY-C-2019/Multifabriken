using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mainMenu = {"Lägg till produkt i kundvagnen", "Visa kundvagnen", "Bekräfta beställning och avsluta"};
            string welcomeMessage = "Hej och välkommen till Multifabriken ABs konsollapp! Här kan du beställa en hel hög olika produkter!\nVad vill du göra?";
            bool isProgramRunning = true;
            Order currentOrder = new Order();
            while (isProgramRunning) {
                switch (Menu.DisplayMenu(mainMenu, welcomeMessage)) {                    
                    case 0:
                        string [] productOptions = {"Bil", "Godis", "Rör", "Havremjölk", "Tillbaka till huvudmenyn"};
                        int productIndex = Menu.DisplayMenu(productOptions, "Vad vill du beställa?");
                        if (productIndex != 4) {
                            currentOrder.AddProduct = productIndex;
                        }
                        
                        break;
                    // View shopping cart
                    case 1:
                        currentOrder.PrintCart();
                        break;
                    // Quit program
                    case 2:
                        currentOrder.ConfirmOrder();
                        if (currentOrder.IsOrderCompleted) {
                            Console.WriteLine("Tack för att du handlar hos Multifabriken AB!");
                            isProgramRunning = false;
                        }
                        break;
                }
            }
        }
    }
}