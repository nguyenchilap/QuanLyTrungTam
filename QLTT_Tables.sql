DROP DATABASE QuanLyTrungTam
CREATE DATABASE QuanLyTrungTam
GO
USE QuanLyTrungTam
GO
-->>>>>>>>TAO BANG<<<<<<<<<--


--DROP TABLE DS_Chuyende
CREATE TABLE DS_Chuyende
(
	ID_Chuyende INT NOT null,
	Ten_Chuyende NVARCHAR(50) NOT null,
	Mota NVARCHAR(500),
	Hocphi INT ,
	CONSTRAINT PK_DS_Chuyende PRIMARY KEY (ID_Chuyende)
)

--DROP TABLE Nhom_Chuyende
CREATE TABLE Nhom_Chuyende
(
	ID_Nhom INT NOT null,
	Ten_Nhom NVARCHAR(50) NOT null,
	Hocphi INT ,
	CONSTRAINT PK_Nhom_Chuyende PRIMARY KEY (ID_Nhom)
)

--DROP TABLE Chitiet_NhomCD
CREATE TABLE Chitiet_NhomCD
(
	ID_Nhom INT NOT null,
	ID_Chuyende INT NOT null,
	
	CONSTRAINT PK_Chitiet_NhomCD PRIMARY KEY (ID_Nhom,ID_Chuyende)
)

--DROP TABLE LoaiHinhDaoTao
CREATE TABLE LoaiHinhDaoTao
(
	ID_Loai INT NOT null,
	Ten_Loai NVARCHAR(50) NOT NULL,
	Quytac NVARCHAR(1000),
	CONSTRAINT PK_LoaiHinhDaoTao PRIMARY KEY (ID_Loai)
)

--ROP TABLE DS_NhanhHoc
CREATE TABLE DS_NhanhHoc
(
	ID_Nhanh INT NOT null,
	Ten_Nhanh NVARCHAR(50) NOT NULL,
	Hocphi INT,
	CONSTRAINT PK_DS_NhanhHoc PRIMARY KEY (ID_Nhanh)
)

--DROP TABLE Chungchi_Nhanhhoc
CREATE TABLE Chungchi_Nhanhhoc
(
	ID_Nhanh INT NOT NULL,
	ID_Loai INT NOT null,
	CONSTRAINT PK_Chungchi_Nhanhhoc PRIMARY KEY (ID_Loai,ID_Nhanh)
)

--DROP TABLE LopChuyende
CREATE TABLE LopChuyende
(
	ID_Nhom INT NOT NULL,
	ID_Loai INT NOT null,
	CONSTRAINT PK_LopChuyende PRIMARY KEY (ID_Loai,ID_Nhom)
)

--DROP TABLE Dangky_Nhanhhoc
CREATE TABLE Dangky_Nhanhhoc
(
	ID_Loai INT NOT null,
	ID_Nhanh INT NOT NULL,
	ID_Hocvien INT NOT null,
	ID_Khoa INT NOT NULL,
	Ngay DATE,
	CONSTRAINT PK_Dangky_Nhanhhoc PRIMARY KEY (ID_Loai,ID_Nhanh,ID_Hocvien,ID_Khoa)
)

--DROP TABLE KhoaDaoTao
CREATE TABLE KhoaDaoTao
(
	
	ID_Khoa INT NOT NULL,
	Ten_Khoa NVARCHAR(50),
	SoLuong INT,
	NgayBatdau DATE,
	LoaiHinhDaoTao INT NOT null,
	ID_NVQL INT,
	CONSTRAINT PK_KhoaDaoTao PRIMARY KEY (ID_Khoa)
)
 

--DROP TABLE DangKi
CREATE TABLE DangKi
(
	
	ID_Khoa INT NOT NULL,
	ID_Hocvien INT NOT NULL,
	Totnghiep NVARCHAR(50),
	NV_Duyet INT,
	
	CONSTRAINT PK_DangKi PRIMARY KEY (ID_Khoa,ID_Hocvien)
) 

--DROP TABLE HocVien
CREATE TABLE HocVien
(
	ID_Hocvien INT NOT NULL,
	Ten_Hocvien nvarchar(50),
	Email NVARCHAR(50),
	SDT NVARCHAR(50),
	Ngaysinh DATE,
	CONSTRAINT PK_HocVien PRIMARY KEY (ID_Hocvien)
)

--DROP TABLE Taikhoan_HocVien
CREATE TABLE Taikhoan_HocVien
(
	Ten_TK nvarchar(50) NOT NULL,
	Matkhau NVARCHAR(50),
	ID_Hocvien INT NOT NULL,
	CONSTRAINT PK_Taikhoan_HocVien PRIMARY KEY (Ten_TK)
)


--DROP TABLE KetquaHocphan
CREATE TABLE KetquaHocphan
(
	ID_Hocvien INT NOT NULL,
	ID_Hocphan INT NOT NULL,
	ID_Khoa INT NOT NULL,
	Solanthilai INT,
	Hoanthanh NVARCHAR(50),
	
	CONSTRAINT PK_KetquaHocphan PRIMARY KEY (ID_Hocvien,ID_Hocphan,ID_Khoa)
)


--DROP TABLE DS_HocPhan
CREATE TABLE DS_HocPhan
(
	ID_Hocphan INT NOT NULL,
	Ten_Hocphan NVARCHAR(50) NOT NULL,
	Hocphi INT,
	CONSTRAINT PK_DS_HocPhan PRIMARY KEY (ID_Hocphan)
)

--DROP TABLE Chungchi_Hocphan
CREATE TABLE Chungchi_Hocphan
(
	ID_Hocphan INT NOT NULL,
	ID_Loai INT NOT NULL,
	
	CONSTRAINT PK_Chungchi_Hocphan PRIMARY KEY (ID_Hocphan,ID_Loai)
)


--DROP TABLE DS_MonHoc
CREATE TABLE DS_MonHoc
(
	ID_Monhoc INT NOT NULL,
	Ten_Monhoc NVARCHAR(50) NOT NULL,
	Mota NVARCHAR(200),
	Hocphi INT,
	Loai int, --0 la mon hoc, 1 la chuyen de
	CONSTRAINT PK_DS_MonHoc PRIMARY KEY (ID_Monhoc)
)


--DROP TABLE Chungchi_Monhoc
CREATE TABLE Chungchi_Monhoc
(
	ID_Monhoc INT NOT NULL,
	ID_Loai INT NOT NULL,
	
	CONSTRAINT PK_Chungchi_Monhoc PRIMARY KEY (ID_Monhoc,ID_Loai)
)


--DROP TABLE Chitiet_NhanhHoc
CREATE TABLE Chitiet_NhanhHoc
(
	ID_Nhanh INT NOT NULL,
	ID_MonHoc INT NOT NULL,
	
	CONSTRAINT PK_Chitiet_NhanhHoc PRIMARY KEY (ID_Nhanh,ID_MonHoc)	
)


--DROP TABLE Chitiet_Hocphan
CREATE TABLE Chitiet_Hocphan
(
	ID_Hocphan INT NOT NULL,
	ID_Monhoc INT NOT NULL,
	batbuoc NVARCHAR(50),
	CONSTRAINT PK_Chitiet_Hocphan PRIMARY KEY (ID_Hocphan,ID_Monhoc)
)


--DROP TABLE Chitiet_Khoahoc
CREATE TABLE Chitiet_Khoahoc
(
	ID_Khoa INT NOT NULL,
	ID_Lophoc INT NOT NULL,
	
	CONSTRAINT PK_Chitiet_Khoahoc PRIMARY KEY (ID_Khoa,ID_Lophoc)
)

--DROP TABLE Lichthi
CREATE TABLE Lichthi
(
	ID_Khoa INT NOT NULL,
	ID_Monhoc INT NOT NULL,
	GiaoVienCoiThi INT NOT NULL,
	Thoigian DATE,
	
	CONSTRAINT PK_Lichthi PRIMARY KEY (ID_Khoa,ID_Monhoc)
)

--DROP TABLE LopHoc
CREATE TABLE LopHoc
(
	ID_Khoa INT,
	ID_GV INT ,
	ID_Monhoc INT NOT NULL,
	Soluong int,
	CONSTRAINT PK_LopHoc PRIMARY KEY (ID_Khoa,ID_Monhoc)
)

--DROP TABLE DSLopHoc
CREATE TABLE DSLopHoc
(
	ID_Hocvien INT NOT NULL,
	ID_Monhoc INT NOT NULL,
	ID_Khoa INT NOT NULL,
	Sobuoivang INT,
	Diemthi FLOAT,
	CONSTRAINT PK_DSLopHoc PRIMARY KEY (ID_Hocvien,ID_Khoa,ID_Monhoc)
)


--DROP TABLE GiaoVien
CREATE TABLE GiaoVien
(
	ID_NV INT NOT NULL,
	Chuyenmon NVARCHAR(50),
	
)
ALTER TABLE dbo.GiaoVien
ADD CONSTRAINT PK_GiaoVien PRIMARY KEY (ID_NV)

--DROP TABLE NhanVien
CREATE TABLE NhanVien
(
	ID_NV INT NOT NULL,
	Ten_NV NVARCHAR(50) NOT NULL,
	Luong INT,
	Ngaysinh DATE,
	SDT NVARCHAR(50),
	Email NVARCHAR(50),
	NgayBatdau DATE,
	ID_Phongban INT,
	NgayKetthuc DATE,
	
	CONSTRAINT PK_NhanVien PRIMARY KEY (ID_NV)
)

--DROP TABLE Taikhoan_Nhanvien
CREATE TABLE Taikhoan_Nhanvienn
(
	Ten_TK NVARCHAR(50),
	Matkhau NVARCHAR(50),
	ID_NV INT NOT NULL,
	CONSTRAINT Taikhoan_Nhanvien PRIMARY KEY (Ten_TK)
)


--DROP TABLE PhongBan
CREATE TABLE PhongBan
(
	ID_Phongban INT,
	Ten_Phongban NVARCHAR(50),
	Truongphong INT,

	CONSTRAINT PK_PhongBan PRIMARY KEY (ID_Phongban)
)

--DROP TABLE DSThi
CREATE TABLE DSThi
(
	ID_Hocvien INT NOT NULL,
	ID_Khoa INT NOT NULL,
	ID_Lophoc INT NOT NULL,
	ID_Lichthi INT NOT NULL,
	
	diem FLOAT,
	CONSTRAINT PK_DSThi PRIMARY KEY (ID_Hocvien,ID_Khoa,ID_Lophoc,ID_Lichthi)
)

--CREATE TABLE Lophoc_Chuyende
--(
	--ID_Khoa INT,
	--ID_Chuyende INT,
	--ID_GV INT,
	--Soluong INT,

	--CONSTRAINT PK_LHCD PRIMARY KEY (ID_Khoa,ID_Chuyende)
--)

CREATE TABLE DonDangKi
(
	ID_Hocvien INT ,
	ID_Khoa INT ,
	Hocphi INT,
	Ghichu NVARCHAR(1000),
	CONSTRAINT PK_DonDangki PRIMARY KEY (ID_Hocvien,ID_Khoa)
)


ALTER TABLE dbo.Chitiet_NhomCD  --DROP FK_Chitiet_NhomCD_DS_Chuyende
ADD CONSTRAINT FK_Chitiet_NhomCD_DSMH
FOREIGN KEY (ID_Chuyende) REFERENCES dbo.DS_MonHoc(ID_Monhoc);

ALTER TABLE dbo.Chitiet_NhomCD
ADD CONSTRAINT FK_Chitiet_NhomCD_NhomChuyende
FOREIGN KEY (ID_Nhom) REFERENCES dbo.Nhom_Chuyende(ID_Nhom);



ALTER TABLE dbo.LopChuyende
ADD CONSTRAINT FK_LopChuyende_LoaiHinhDaoTao
FOREIGN KEY (ID_Loai) REFERENCES dbo.LoaiHinhDaoTao(ID_Loai);

ALTER TABLE dbo.LopChuyende 
ADD CONSTRAINT FK_LopChuyende_NhomChuyende
FOREIGN KEY (ID_Nhom) REFERENCES dbo.Nhom_Chuyende(ID_Nhom);



ALTER TABLE dbo.Chungchi_Nhanhhoc
ADD CONSTRAINT FK_Chungchi_Nhanhhoc_LoaiHinhDaoTao
FOREIGN KEY (ID_Loai) REFERENCES dbo.LoaiHinhDaoTao(ID_Loai);

ALTER TABLE dbo.Chungchi_Nhanhhoc
ADD CONSTRAINT FK_Chungchi_Nhanhhoc_DS_Nhanhhoc
FOREIGN KEY (ID_Nhanh) REFERENCES dbo.DS_NhanhHoc(ID_Nhanh);



ALTER TABLE dbo.Dangky_Nhanhhoc
ADD CONSTRAINT FK_Dangky_Nhanhhoc_DonDangKi
FOREIGN KEY (ID_Hocvien,ID_Khoa) REFERENCES dbo.DonDangKi(ID_Hocvien,ID_Khoa);


ALTER TABLE Dangky_Nhanhhoc
ADD CONSTRAINT FK_Dangky_Nhanhhoc_Chungchi_Nhanhhoc
FOREIGN KEY (ID_Loai,ID_Nhanh) REFERENCES Chungchi_Nhanhhoc(ID_Loai,ID_Nhanh);


ALTER TABLE KhoaDaoTao
ADD CONSTRAINT FK_KhoaDaoTao_LoaiHinhDaoTao
FOREIGN KEY (LoaiHinhDaoTao) REFERENCES LoaiHinhDaoTao(ID_Loai);

ALTER TABLE dbo.KhoaDaoTao
ADD CONSTRAINT FK_KhoaDaoTao_NhanVien
FOREIGN KEY (ID_NVQL) REFERENCES dbo.NhanVien(ID_NV);


ALTER TABLE Chitiet_NhanhHoc 
ADD CONSTRAINT FK_Chitiet_NhanhHoc_DSNhanhHoc
FOREIGN KEY (ID_Nhanh) REFERENCES DS_NhanhHoc(ID_Nhanh);

ALTER TABLE Chitiet_NhanhHoc
ADD CONSTRAINT FK_Chitiet_NhanhHoc_DS_MonHoc
FOREIGN KEY (ID_MonHoc) REFERENCES dbo.DS_MonHoc(ID_Monhoc);



--ALTER TABLE dbo.DangKi --DROP FK_DangKi_HocVien
--ADD CONSTRAINT FK_DangKi_HocVien
--FOREIGN KEY (ID_Hocvien) REFERENCES dbo.HocVien(ID_Hocvien);

--ALTER TABLE dbo.DangKi --DROP FK_DangKi_KhoaDaoTao
--ADD CONSTRAINT FK_DangKi_KhoaDaoTao
--FOREIGN KEY (ID_Khoa) REFERENCES dbo.KhoaDaoTao(ID_Khoa);

ALTER TABLE dbo.DangKi
ADD CONSTRAINT FK_DK_DDK
FOREIGN KEY (ID_Hocvien,ID_Khoa) REFERENCES dbo.DonDangKi(ID_Hocvien,ID_Khoa)

ALTER TABLE dbo.DangKi
ADD CONSTRAINT FK_DK_NV
FOREIGN KEY (NV_Duyet) REFERENCES dbo.NhanVien(ID_NV)


ALTER TABLE Chungchi_Monhoc
ADD CONSTRAINT FK_Chungchi_Monhoc_LHDT
FOREIGN KEY (ID_Loai) REFERENCES LoaiHinhDaoTao(ID_Loai);

ALTER TABLE Chungchi_Monhoc
ADD CONSTRAINT FK_Chungchi_Monhoc_DS_MonHoc
FOREIGN KEY (ID_Monhoc) REFERENCES DS_MonHoc(ID_Monhoc);



ALTER TABLE dbo.Chungchi_Hocphan
ADD CONSTRAINT FK_Chungchi_Hocphan_LoaiHinhDaoTao
FOREIGN KEY (ID_Loai) REFERENCES dbo.LoaiHinhDaoTao(ID_Loai);

ALTER TABLE dbo.Chungchi_Hocphan
ADD CONSTRAINT FK_Chungchi_Hocphan_DS_HocPhan
FOREIGN KEY (ID_Hocphan) REFERENCES dbo.DS_HocPhan(ID_Hocphan);



ALTER TABLE dbo.KetquaHocphan
ADD CONSTRAINT FK_KetquaHocphan_DangKi
FOREIGN KEY (ID_Khoa,ID_Hocvien) REFERENCES dbo.DangKi(ID_Khoa,ID_Hocvien);

ALTER TABLE dbo.KetquaHocphan
ADD CONSTRAINT FK_KetquaHocphan_DS_HocPhan
FOREIGN KEY (ID_Hocphan) REFERENCES dbo.DS_HocPhan(ID_Hocphan);


ALTER TABLE dbo.Taikhoan_HocVien
ADD CONSTRAINT FK_Taikhoan_HocVien_HocVien
FOREIGN KEY (ID_Hocvien ) REFERENCES dbo.HocVien(ID_Hocvien);



ALTER TABLE dbo.Chitiet_Hocphan
ADD CONSTRAINT FK_Chitiet_Hocphan_DS_MonHoc
FOREIGN KEY (ID_Monhoc ) REFERENCES dbo.DS_MonHoc(ID_Monhoc);

ALTER TABLE dbo.Chitiet_Hocphan
ADD CONSTRAINT FK_Chitiet_Hocphan_DS_HocPhan
FOREIGN KEY (ID_Hocphan ) REFERENCES dbo.DS_HocPhan(ID_Hocphan);




ALTER TABLE dbo.GiaoVien
ADD CONSTRAINT FK_GiaoVien_NhanVien
FOREIGN KEY (ID_NV ) REFERENCES dbo.NhanVien(ID_NV);



ALTER TABLE dbo.Lichthi
ADD CONSTRAINT FK_Lichthi_LopHoc
FOREIGN KEY (ID_Khoa,ID_Monhoc ) REFERENCES dbo.LopHoc(ID_Khoa,ID_Monhoc);

ALTER TABLE dbo.Lichthi
ADD CONSTRAINT FK_Lichthi_GiaoVien
FOREIGN KEY (GiaoVienCoiThi ) REFERENCES dbo.GiaoVien(ID_NV);



ALTER TABLE dbo.DSLopHoc
ADD CONSTRAINT FK_DSLopHoc_Hocvien
FOREIGN KEY (ID_Hocvien) REFERENCES dbo.HocVien(ID_Hocvien);


ALTER TABLE dbo.DSLopHoc
ADD CONSTRAINT FK_DSLopHoc_LopHoc
FOREIGN KEY (ID_Khoa,ID_Monhoc) REFERENCES dbo.LopHoc(ID_Khoa,ID_Monhoc);


--ALTER TABLE dbo.DSThi
--ADD CONSTRAINT FK_DSThi_DSLopHoc
--FOREIGN KEY (ID_Lophoc,ID_Hocvien,ID_Khoa ) REFERENCES dbo.DSLopHoc(ID_Lophoc,ID_Hocvien,ID_Khoa);

--ALTER TABLE dbo.DSThi
--ADD CONSTRAINT FK_DSThi_Lichthi
--FOREIGN KEY (ID_Lichthi ) REFERENCES dbo.Lichthi(ID_Lichthi);



ALTER TABLE dbo.LopHoc
ADD CONSTRAINT FK_LopHoc_GiaoVien
FOREIGN KEY (ID_GV ) REFERENCES dbo.GiaoVien(ID_NV);

ALTER TABLE dbo.LopHoc
ADD CONSTRAINT FK_LopHoc_DS_MonHoc
FOREIGN KEY (ID_Monhoc ) REFERENCES dbo.DS_MonHoc(ID_Monhoc);
ALTER TABLE dbo.LopHoc
ADD CONSTRAINT FK_LopHoc_KhoaDaoTao
FOREIGN KEY (ID_Khoa) REFERENCES dbo.KhoaDaoTao(ID_Khoa);




ALTER TABLE dbo.Taikhoan_Nhanvienn
ADD CONSTRAINT FK_Taikhoan_Nhanvien_NhanVienn
FOREIGN KEY (ID_NV ) REFERENCES dbo.NhanVien(ID_NV);

ALTER TABLE dbo.NhanVien
ADD CONSTRAINT FK_Nhanvien_Phongban
FOREIGN KEY (ID_Phongban) REFERENCES dbo.PhongBan(ID_Phongban);

ALTER TABLE dbo.PhongBan
ADD CONSTRAINT FK_PhongBan_Nhanvien
FOREIGN KEY (Truongphong) REFERENCES dbo.NhanVien(ID_NV);


ALTER TABLE dbo.DonDangKi
ADD CONSTRAINT FK_DonDK_HV 
FOREIGN KEY (ID_Hocvien) REFERENCES dbo.HocVien(ID_Hocvien)

ALTER TABLE dbo.DonDangKi
ADD CONSTRAINT FK_DonDK_KDT 
FOREIGN KEY (ID_Khoa) REFERENCES dbo.KhoaDaoTao(ID_Khoa)


--ALTER TABLE dbo.Lophoc_Chuyende
--ADD CONSTRAINT FK_LHCD_KDT
--FOREIGN KEY (ID_Khoa) REFERENCES dbo.KhoaDaoTao(ID_Khoa)

--ALTER TABLE dbo.Lophoc_Chuyende
--ADD CONSTRAINT FK_LHCD_DSCD
--FOREIGN KEY (ID_Chuyende) REFERENCES dbo.DS_Chuyende(ID_Chuyende)

--ALTER TABLE dbo.Lophoc_Chuyende
--ADD CONSTRAINT FK_LHCD_GIAOVIEN
--FOREIGN KEY (ID_GV) REFERENCES dbo.GiaoVien(ID_NV)
