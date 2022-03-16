class ProductList
{
    List<Product> list = new List<Product>();
    public void AddProduct(Product product)
    {
        if (product == null) System.Console.WriteLine("Addition failed! Product is null");
        else if (list.Count == 0) list.Add(product);
        else if (Search(product.Id) != null) System.Console.WriteLine("Addition failed! ID existed.");
        else list.Add(product);
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
    public void PrintAll()
    {
        System.Console.WriteLine("LIST OF ALL PRODUCT");
        Title();
        foreach (Product item in list) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
    public void PrintFood()
    {
        System.Console.WriteLine("LIST OF ALL FOOD");
        Title();
        foreach (Product item in list) if (item is Food) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
    public void PrintElectronic()
    {
        System.Console.WriteLine("LIST OF ALL ELECTRONICS");
        Title();
        foreach (Product item in list) if (item is Electronic) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
    public void PrintCrockery()
    {
        System.Console.WriteLine("LIST OF ALL CROCKERY");
        Title();
        foreach (Product item in list) if (item is Crockery) System.Console.WriteLine(item);
        Line();
        System.Console.WriteLine();
    }
    public Product Search(string id)
    {
        /* Binary search somehow made the code to stop but not exit
        Linear search is being used as a alternative solution */
        foreach (var item in list)
        {
            if (item.Id == id) return item;
        }
        // var tempList = list;
        // tempList.Sort(new SortByID());
        // int head = 0, tail = tempList.Count;
        // while (head <= tail) {
        //     int mid = (head + tail) / 2;
        //     if (tempList[mid].Id == id) return tempList[mid];
        //     else if (tempList[mid].Id.CompareTo(id) < 0) head = mid;
        //     else tail = mid;
        // }
        return null;
    }
    public void PrintDifficultToSell()
    {
        System.Console.WriteLine("LIST OF DIFFICULT TO SELL GOODS");
        Title();
        foreach (var item in list)
        {
            if (item is Food) if (item.Status() != "---") System.Console.WriteLine(item);
        }
        Line();
    }
    public void SortByName() => list.Sort(new SortByName());
    public void SortByStock() => list.Sort(new SortByStock());
    public void Remove(string id) {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Id == id)
            {
                list.RemoveAt(i);
                System.Console.WriteLine(id + " has been removed.");
                goto label;
            }
        }
        System.Console.WriteLine(id + " doesn't exist, nothing has been delete.");
        label:;
    }
    public void ChangeUnitPrice(string id, int newUnitPrice) {
        foreach (var item in list)
        {
            if (item.Id == id) item.UnitPrice = newUnitPrice; break;
        }
    }
}

class SortByID : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x == null || y == null) throw new ArgumentNullException();
        return x.Id.CompareTo(y.Id);
    }
}
class SortByName : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x == null || y == null) throw new ArgumentNullException();
        return x.Name.CompareTo(y.Name);
    }
}
class SortByStock : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x == null || y == null) throw new ArgumentNullException();
        return -x.Stock.CompareTo(y.Stock);
    }
}