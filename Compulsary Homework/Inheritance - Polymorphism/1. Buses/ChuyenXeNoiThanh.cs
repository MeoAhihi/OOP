class ChuyenXeNoiThanh : ChuyenXe
{
    private byte _soTuyen;
    private float _soKM;
    public byte SoTuyen
    {
        get { return _soTuyen; }
        set { _soTuyen = value; }
    }
    public float SoKM
    {
        get { return _soKM; }
        set { _soKM = (value > 0 ? value : 0); }
    }
    public ChuyenXeNoiThanh(int maSoChuyen, string tenTaiXe, short soXe, int doanhThu, byte soTuyen, int soKM)
        : base(maSoChuyen, tenTaiXe, soXe, doanhThu)
    {
        SoTuyen = soTuyen;
        SoKM = soKM;
    }
    public override string ToString() {
        return base.ToString() + "Xe noi thanh        |";
    }

    //Doang Thu la input, khong can tinh
    // public void TinhDoanhThu()
    // {
    //     if (_soKM < 1) base.DoanhThu = (int)(_soKM * 15000);
    //     else if (_soKM < 5) base.DoanhThu = (int)(1 * 15000 + (_soKM - 1) * 11000);
    //     else base.DoanhThu = (int)(1 * 15000 + 4 * 11000 + (_soKM - 5) * 10000);
    // }
    
}