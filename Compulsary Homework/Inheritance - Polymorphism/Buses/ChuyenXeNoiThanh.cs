class ChuyenXeNoiThanh : ChuyenXe
{
    private byte _soTuyen;
    private int _soKM;
    public byte SoTuyen
    {
        get { return _soTuyen; }
        set { _soTuyen = value; }
    }
    public int SoKM
    {
        get { return _soKM; }
        set { _soKM = (value > 0 ? value : 0); }
    }
    public ChuyenXeNoiThanh(int maSoChuyen, string tenTaiXe, byte soXe, byte soTuyen, int soKM)
        : base(maSoChuyen, tenTaiXe, soXe)
    {
        SoTuyen = soTuyen;
        SoKM = soKM;
    }
    public void TinhDoanhThu()
    {

    }
}