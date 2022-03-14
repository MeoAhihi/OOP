class DanhSachChuyenXe
{
    List<ChuyenXe> danhSach = new List<ChuyenXe>();
    private int _doanhThuNoiThanh = 0;
    private int _doanhThuNgoaiThanh = 0;
    public void ThemChuyenXe(ChuyenXe xe)
    {
        if (xe == null) throw new ArgumentNullException("DanhSachChuyenXe.Add.xe", "Khong the them xe rong thao danh sach!");
        else danhSach.Add(xe);
    }
    public void Line()
    {
        for (byte i = 0; i < 71; i++) System.Console.Write("*");
        System.Console.WriteLine();
    }
    public void Title()
    {
        Line();
        System.Console.WriteLine("|{0,10}|{1,20}|{2,5}|{3,10}|{4,20}|", "Ma So Xe", "Ten Tai Xe", "So xe", "Doanh Thu", "Ghi chu");
        Line();
    }
    public void TinhDoanhThu()
    {
        foreach (var item in danhSach)
        {
            if (item is ChuyenXeNoiThanh) _doanhThuNoiThanh += item.DoanhThu;
            else _doanhThuNgoaiThanh += item.DoanhThu;
        }
    }
    public void XuatDanhSach()
    {
        Title();
        foreach (var item in danhSach)
        {
            System.Console.WriteLine(item);
        }
        Line();
        TinhDoanhThu();
        System.Console.WriteLine(
            "|{0, -69}|\n|{1, -69}|\n|{2,-69}|",
            "Doanh thu noi thanh: " + _doanhThuNoiThanh,
            "Doanh thu ngoai thanh: " + _doanhThuNgoaiThanh,
            "Tong doanh thu: " + (_doanhThuNgoaiThanh + _doanhThuNoiThanh)
        );
        Line();
    }
}