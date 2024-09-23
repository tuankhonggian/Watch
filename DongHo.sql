use DongHo

CREATE TABLE TaiKhoan (
    TaiKhoan NVARCHAR(50) PRIMARY KEY,
    ChucVu NVARCHAR(50),
    MatKhau NVARCHAR(50),
    Email NVARCHAR(50)
);
CREATE TABLE SanPham (
    MaSP NVARCHAR(50) PRIMARY KEY,
    TenSP NVARCHAR(50),
    NhaCungCap NVARCHAR(50),
    XuatXU NVARCHAR(50),
	HangSanXuat NVARCHAR(50),
	GiaTien int
);
CREATE TABLE NhanVien (
    MaNV NVARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(50),
	SDT INT,
    DiaChi NVARCHAR(50),
    Email NVARCHAR(50),
	TaiKhoan NVARCHAR(50),
	MatKhau NVARCHAR(50)
);
CREATE TABLE NhaCungCap (
    MaNCC NVARCHAR(50) PRIMARY KEY,
    TenNCC NVARCHAR(50),
	Email NVARCHAR(50),
	SDT INT
);
CREATE TABLE KhoHang (
    MaSP NVARCHAR(50) PRIMARY KEY,
    TenSP NVARCHAR(50),
	SoLuongTonKho INT,
    NgayNhap date
);
CREATE TABLE DanhSachSanPhamNhap (
    MaSP NVARCHAR(50) PRIMARY KEY,
    MaNCC NVARCHAR(50),
    HangSanXuat NVARCHAR(50),
    TenSP NVARCHAR(50),
	XuatXU NVARCHAR(50),
	GiaTien int
);
CREATE TABLE DanhSachSanPham (
    MaSP NVARCHAR(50) PRIMARY KEY,
    TenSP NVARCHAR(50),
	SoLuongMua int,
	GiaTien int,
	ThanhTien int
);
CREATE TABLE ChiTietHD (
    MaHD NVARCHAR(50) PRIMARY KEY,
    MaNV NVARCHAR(50),
    HoTenKH NVARCHAR(50),
	SDTKH INT,
    DiaChi NVARCHAR(50),
	NgayMua datetime,
	TongTien int
);

