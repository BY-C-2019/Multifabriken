using System;
using System.Diagnostics;
using System.ComponentModel;

namespace menu
{
public class Menu
    {
        public Menu(IEnumerable<string> items)      // Itererar över elementet
        {
            Items = items.ToArray();                // Gör om till en array
        }
        public IReadOnlyList<string> Items {get;}
        public int SelectedIndex {get; private set;} = - 1; // Utgångspunkt med inget markerat
        public string SelectedOption => SelectedIndex != - 1 ? Items[SelectedIndex] : null;


        public void MoveUp() => SelectedIndex = Math.Max(SelectedIndex - 1, 0);      // Rör dig ett steg uppåt om du inte är på högsta nivån
        public void MoveDown() => SelectedIndex = Math.Min(SelectedIndex + 1, Items.Count - 1); // Rör dig ett steg neråt om du inte är på lägsta nivån
    }
    public class ConsoleMenuPainter
    {
        readonly Menu menu;
        public ConsoleMenuPainter(Menu menu)
        {
            this.menu = menu;
        }
        public void Paint()
        {
            for (int i = 0; i < menu.Items.Count; i++){
                Console.SetCursorPosition(0, 3 + i);

                var color = menu.SelectedIndex == i ? ConsoleColor.Yellow : ConsoleColor.Gray;
                
                Console.ForegroundColor = color;
                Console.WriteLine (menu.Items[i]);
            }
        }
    }
} 