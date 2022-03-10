static class Print {
    private List<string> attribute = new List<string>;
    private List<int> cellWidth = new List<int>;
    private readonly int tableWidth;
    public Print(List<string> attribute, List<int> cellWidth)
    {
        this.attribute = attribute;
        this.cellWidth = cellWidth;
        foreach (var w in cellWidth) tableWidth += w;
        tableWidth += 1 + cellWidth.Count;
    }
    public static void HorizontalLine() {
        for (int i = 0; i < ; i++) System.Console.Write("*");
        System.Console.WriteLine();
    }
    public static void Title() {
        HorizontalLine();
        
    }
}