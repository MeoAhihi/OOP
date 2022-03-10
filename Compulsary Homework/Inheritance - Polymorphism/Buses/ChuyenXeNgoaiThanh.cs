class ChuyenXeNgoaiThanh : ChuyenXe
{
    private string _noiDen = "";
    private int _soNgayDiDuoc;
    public string NoiDen {
        get { return _noiDen; }
        set { _noiDen = value; }
    }
    public int SoNgayDiDuoc {
        get { return _soNgayDiDuoc; }
        set { _soNgayDiDuoc = (value > 0 ? value : 0); }
    }
    public ChuyenXeNgoaiThanh(int maSoChuyen, string tenTaiXe, byte soXe, string noiDen, int soNgayDiDuoc)
        : base(maSoChuyen, tenTaiXe, soXe)
    {
        NoiDen = noiDen;
        SoNgayDiDuoc = soNgayDiDuoc;
    }
}