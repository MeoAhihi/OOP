class CDList
{
    public List<CD> list = new List<CD>();
    private bool Search(int code)
    {
        int head = 0;
        int tail = list.Count;
        int mid = (head + tail) / 2;
        bool result = false;
        while (head != tail)
        {
            if (list[mid].Code == code)
            {
                result = true;
                break;
            }
            else if (list[mid].Code < code)
            {
                head = mid;
                mid = (head + tail) / 2;
            }
            else
            {
                tail = mid;
                mid = (head + tail) / 2;
            }
        }
        return result;
    }
    public void Add(int newCode, int newNumOfSongs, float newPrice, string newTitle)
    {
        if (Search(newCode)) {
            System.Console.WriteLine("Addition failed! Element existed.");
        } else {
            list.Add(new CD(newCode, newNumOfSongs, newPrice, newTitle));
            System.Console.WriteLine("Addition successed!");
        }
    }
    public int NumOfCD() {
        return list.Count;
    }
    public float TotalPrice() {
        float totalPrice = 0;
        foreach (CD cd in list) { totalPrice += cd.Price; }
        return totalPrice;
    }
    
}