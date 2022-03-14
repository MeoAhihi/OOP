var list = new BookList();
list.AddBook(new TextBook("HN151", new DateOnly(2019, 1, 15), 100000, 1, "NXB Bach Khoa Ha Noi", false));
list.AddBook(new TextBook("KV105", new DateOnly(2021, 5, 10), 290000, 1, "NXB Khang Viet", true));
list.AddBook(new RefBook("KV123", new DateOnly(2022, 3, 12), 49000, 1, "NXB Khang Viet", 5000));
list.AddBook(new RefBook("ND129", new DateOnly(2021, 9, 12), 300000, 5, "NXB Nhi Dong", 20000));

list.PrintAll();

list.Print1Publisher();