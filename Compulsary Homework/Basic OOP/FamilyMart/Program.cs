var p1 = new Product("1", "Rice", 100000, new DateOnly(2021, 10, 7), new DateOnly(2022, 8, 10));
var p2 = new Product("2", "Noodle", 5000, new DateOnly(2022,1,2), new DateOnly(2022, 1,3));
var p3 = new Product("3", "Water", 100000, new DateOnly(2021, 10, 7), new DateOnly(2022, 8, 1));

Product.Title();
System.Console.WriteLine(p1);
System.Console.WriteLine(p2);
System.Console.WriteLine(p3);
Product.HorizontalLine();