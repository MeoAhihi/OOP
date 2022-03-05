class Triagle
{
    private float ma, mb, mc;
    public Triagle()
    {
        ma = 0;
        mb = 0;
        mc = 0;
    }
    public Triagle(float ma, float mb, float mc)
    {
        if ((ma < 0) || (mb < 0) || (mc < 0) || (ma + mb < mc) || (ma + mc < mb) || (mb + mc < ma))
        {
            this.ma = 0;
            this.mb = 0;
            this.mc = 0;
        }
        else
        {
            this.ma = ma;
            this.mb = mb;
            this.mc = mc;
        }
    }
    public float getma() { return this.ma; }
    public float getmb() { return this.mb; }
    public float getmc() { return this.mc; }
    public void setma(float ma) { if ((ma > 0) || (this.mb + this.mc > ma)) this.ma = ma; }
    public void setmb(float mb) { if ((mb > 0) || (this.ma + this.mc > mb)) this.mb = mb; }
    public void setmc(float mc) { if ((mc > 0) || (this.ma + this.mb > mc)) this.mc = mc; }
    public float perimeter() { return ma + mb + mc; }
    public float area()
    {
        float p = perimeter() / 2;
        return (float)Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
    }
    public string type()
    {
        if ((ma == 0) && (mb == 0) && (mc == 0)) return "Not triagle";
        else if ((ma == mb) || (mb == mc) || (ma == mc))
        {
            if ((ma == mb) && (ma == mc)) return "Equilateral triagle";
            else if ((ma * ma + mb * mb == mc * mc) || (ma * ma + mc * mc == mb * mb) || (mb * mb + mc * mc == ma * ma)) return "tam giac vuong can";
            else return "Isosceles triagle";
        }
        else if ((ma * ma + mb * mb == mc * mc) || (ma * ma + mc * mc == mb * mb) || (mb * mb + mc * mc == ma * ma))
        {
            return "Right triagle";
        }
        else return "Regular triagle";
    }
    public void toString()
    {
        System.Console.WriteLine("|{0,5}|{1,5}|{2,5}|{3,20}|{4,5}|{5,5}|", ma, mb, mc, type(), perimeter(), Math.Round(area(),2));
    }
}