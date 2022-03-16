ProductList VP = new ProductList();
VP.AddProduct(new Food("1", "Salad", 12000, 130, "Vuon rau Da Lat", new DateOnly(2022, 2, 19), new DateOnly(2022, 3, 19)));
VP.AddProduct(new Food("2", "Ca Chua", 30000, 500, "Rau sach Ha Noi", new DateOnly(2022, 2, 15), new DateOnly(2022, 3, 1)));
VP.AddProduct(new Electronic("3", "Noi com dien ICook", 1299000, 90, 12, 1300));
VP.AddProduct(new Crockery("4", "Bo am tra Co dien kieu Nhat", 1900000, 50, new DateOnly(2021, 1, 30), new DateOnly(2021, 5, 21)));
VP.PrintAll();
VP.Remove("5");
VP.ChangeUnitPrice("1", 15000);
VP.PrintAll();
