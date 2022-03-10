class ChuyenXe
{
    private int _maSoChuyen;
    private string _tenTaiXe = "";
    private byte _soXe;
    private int _doanhThu;
    public int MaSoChuyen {
        get { return _maSoChuyen; }
        set { _maSoChuyen = (value < 0 ? 999999 : value); }
    }
    public string TenTaiXe{
        get { return _tenTaiXe; }
        set { _tenTaiXe = (value == "" ? "#Undifined" : value); }
    }
    public byte SoXe{
        get { return _soXe; }
        set { _soXe = value; }
    }
    public int DoanhThu {
        get { return _doanhThu; }
        set { _doanhThu = value; }
    }
    public ChuyenXe(int maSoChuyen, string tenTaiXe, byte soXe)
    {
        MaSoChuyen = maSoChuyen;
        TenTaiXe = tenTaiXe;
        SoXe = soXe;
    }
}