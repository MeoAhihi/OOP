var menu = new Menu();
menu.add("Add new person");
menu.add("Remove a person");
menu.add("Update a person");
menu.add("List");
menu.add("Quit");

var list = new PersonList();
int choice = 0;
do
{
    System.Console.WriteLine("\nPERSON MANAGER");
    choice = menu.getChoice();
    switch (choice)
    {
        case 1: list.add(); break;
        case 2: list.remove(); break;
        case 3: list.update(); break;
        case 4: list.sort(); list.print(); break;
    }
} while (choice >= 1 && choice < 5);