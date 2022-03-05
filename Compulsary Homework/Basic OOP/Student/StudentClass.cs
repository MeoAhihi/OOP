class Student
{
    private int id;
    private string name;
    private float theory, practice;

    public Student()
    {
        id = 1;
        name = "unknown";
        theory = 0;
        practice = 0;
    }
    public Student(int newID, string newName, float newTheo, float newPrac)
    { //Kiem tra dieu kien
        if (newID > 0) id = newID; else id = 1;
        if (newName != string.Empty) name = newName; else name = "unknown";
        if ((newTheo >= 0) && (newTheo <= 10)) theory = newTheo; else theory = 0;
        if ((newPrac >= 0) && (newPrac <= 10)) practice = newPrac; else practice = 0;
    }
    public int getID()
    {
        return this.id;
    }
    public string getName()
    {
        return this.name;
    }
    public float getTheory()
    {
        return this.theory;
    }
    public float getPractice()
    {
        return this.practice;
    }

    public void setId(int newID)
    {//Kiem tra dieu kien
        if (newID > 0) id = newID; else id = 1;
    }
    public void setName(string newName)
    {//Kiem tra dieu kien
        if (newName != string.Empty) name = newName; else name = "unknown";
    }
    public void setTheory(float newTheoryMark)
    {//Kiem tra dieu kien
        if ((newTheoryMark >= 0) && (newTheoryMark <= 10)) theory = newTheoryMark; else theory = 0;
    }
    public void setPractice(float newPracticeMark)
    {//Kiem tra dieu kien
        if ((newPracticeMark >= 0) && (newPracticeMark <= 10)) practice = newPracticeMark; else practice = 0;
    }
    public float Average()
    {
        return (theory + practice) / 2;
    }
    public void toString()
    {
        System.Console.WriteLine("|{0,3}|{1,-25}|{2,10}|{3,10}|{4,10}|", id, name, theory, practice, this.Average());
    }
    public static void title()
    {
        System.Console.WriteLine("*****************************************************************");
        System.Console.WriteLine("|{0,-3}|{1,-25}|{2,-10}|{3,-10}|{4,-10}|", "ID", "Name", "Theory", "Practice", "Average");
        System.Console.WriteLine("*****************************************************************");
        //Dau "-" de can le trai
    }
    public static void end() {
        System.Console.WriteLine("*****************************************************************");
    }
}