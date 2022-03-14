class ChuyenXe
{
    private int _maSoChuyen;
    private string _tenTaiXe = "";
    private short _soXe;
    private int _doanhThu;
    public int MaSoChuyen {
        get { return _maSoChuyen; }
        set { _maSoChuyen = (value < 0 ? 999999 : value); }
    }
    public string TenTaiXe{
        get { return _tenTaiXe; }
        set { _tenTaiXe = (value == "" ? "#Undifined" : value); }
    }
    public short SoXe{
        get { return _soXe; }
        set { _soXe = value; }
    }
    public int DoanhThu {
        get { return _doanhThu; }
        set { _doanhThu = value; }
    }
    public ChuyenXe(int maSoChuyen, string tenTaiXe, short soXe, int doanhThu)
    {
        MaSoChuyen = maSoChuyen;
        TenTaiXe = tenTaiXe;
        SoXe = soXe;
        DoanhThu = doanhThu;
    }
     public override string ToString()
    {
        return $"|{MaSoChuyen,10}|{TenTaiXe,20}|{SoXe,5}|{DoanhThu,10}|";
    }
}