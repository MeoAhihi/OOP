class ProductList {
    List<Product> list = new List<Product>();
    public void AddProduct(Product product) {
        if (product != null) list.Add(product);
        else System.Console.WriteLine("Addition failed! Product is null.");
    }
    private void Line()
    {
        for (int i = 0; i < 117; i++) System.Console.Write("*");
        System.Console.WriteLine();
    }
    public void Title()
    {
        Line();
        System.Console.WriteLine($"|{"Product ID",10}|{"Product name",30}|{"Product type",20}|{"Unit price (VND)",20}|{"Stocks",10}|{"Status",20}|");
        Line();
    }

    public void PrintAll() {
        System.Console.WriteLine("LIST OF ALL PRODUCT");
        Title();
        foreach (Product item in list) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
    public void PrintFood() {
        System.Console.WriteLine("LIST OF ALL FOOD");
        Title();
        foreach (Product item in list) if (item is Food) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
    public void PrintElectronic() {
        System.Console.WriteLine("LIST OF ALL ELECTRONICS");
        Title();
        foreach (Product item in list) if (item is Electronic) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
    public void PrintCrockery() {
        System.Console.WriteLine("LIST OF ALL CROCKERY");
        Title();
        foreach (Product item in list) if (item is Crockery) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
}