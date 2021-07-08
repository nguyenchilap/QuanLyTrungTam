use QuanLyTrungTam
go

Insert into DS_Chuyende values (0,'root','',0)
Insert into DS_MonHoc values (0,'root','',0,0)
SELECT * FROM dbo.DS_MonHoc

Insert into DS_HocPhan values (0,'root',0)
Insert into DS_NhanhHoc values (0,'root',0)
Insert into Nhom_Chuyende values (0,'root',0)

--------------------------TRUONG PHONG NHAN SU------------------------------------
UPDATE dbo.PhongBan
SET Truongphong = (SELECT ID_NV FROM dbo.NhanVien WHERE Ten_NV = 'QLNS1')
WHERE PhongBan.ID_Phongban = 2


INSERT INTO dbo.LoaiHinhDaoTao
(
    ID_Loai,
    Ten_Loai,
    Quytac
)
VALUES
(   0,   -- ID_Loai - int
    N'root', -- Ten_Loai - nvarchar(50)
    N'none'  -- Quytac - nvarchar(1000)
    )

INSERT INTO dbo.KhoaDaoTao
(
    ID_Khoa,
    Ten_Khoa,
    SoLuong,
    NgayBatdau,
    LoaiHinhDaoTao
)
VALUES
(   0,         -- ID_Khoa - int
    N'root',       -- Ten_Khoa - nvarchar(50)
    0,         -- SoLuong - int
    GETDATE(), -- NgayBatdau - date
    0          -- LoaiHinhDaoTao - int
    )

INSERT INTO dbo.LopHoc
VALUES
(   0, -- ID_Khoa - int
    0, -- ID_GV - int
    0, -- ID_Monhoc - int
    0  -- Soluong - int
    )

INSERT INTO dbo.NhanVien
(
    ID_NV,
    Ten_NV,
    Luong,
    Ngaysinh,
    SDT,
    Email,
    NgayBatdau,
    ID_Phongban
)
VALUES
(   0,         -- ID_NV - int
    N'root',       -- Ten_NV - nvarchar(50)
    0,         -- Luong - int
    GETDATE(), -- Ngaysinh - date
    N'',       -- SDT - nvarchar(50)
    N'',       -- Email - nvarchar(50)
    GETDATE(), -- NgayBatdau - date
    null          -- ID_Phongban - int
    )

INSERT INTO dbo.GiaoVien
(
    ID_NV,
    Chuyenmon
)
VALUES
(   0,  -- ID_NV - int
    N'root' -- Chuyenmon - nvarchar(50)
    )



--------------------------------------------PHONG BAN-------------------------------------------
INSERT INTO dbo.PhongBan
(
    ID_Phongban,
    Ten_Phongban,
    Truongphong
)
VALUES
(   0,   -- ID_Phongban - int
    N'root', -- Ten_Phongban - nvarchar(50)
    0    -- Truongphong - int
    )
INSERT INTO dbo.PhongBan
VALUES
(   1,   -- ID_Phongban - int
    N'Phòng Đào tạo', -- Ten_Phongban - nvarchar(50)
    0    -- Truongphong - int
    )
INSERT INTO dbo.PhongBan
VALUES
(   2,   -- ID_Phongban - int
    N'Phòng Nhân sự', -- Ten_Phongban - nvarchar(50)
    0    -- Truongphong - int
    )
INSERT INTO dbo.PhongBan
VALUES
(   3,   -- ID_Phongban - int
    N'Phòng Chuyên môn', -- Ten_Phongban - nvarchar(50)
    0    -- Truongphong - int
    )
INSERT INTO dbo.PhongBan
VALUES
(   4,   -- ID_Phongban - int
    N'Phòng Công tác Sinh viên', -- Ten_Phongban - nvarchar(50)
    0    -- Truongphong - int
    )


-------------------------------TAI KHOAN NHAN VIEN---------------------------------------------
--NHan vien quan li nhan su
INSERT INTO dbo.NhanVien
VALUES
(   2,         -- ID_NV - int
    N'QLNS1',       -- Ten_NV - nvarchar(50)
    1000,         -- Luong - int
    GETDATE(), -- Ngaysinh - date
    N'0904657891',       -- SDT - nvarchar(50)
    N'QLNS1@gmail.com',       -- Email - nvarchar(50)
    GETDATE(), -- NgayBatdau - date
    2,          -- ID_Phongban - int
	NULL
    )
INSERT INTO dbo.Taikhoan_Nhanvienn
VALUES
(   N'QLNS1', -- Ten_TK - nvarchar(50)
    N'1', -- Matkhau - nvarchar(50)
    2    -- ID_NV - int
    )	

--Nhan vien quan ly khoa hoc
INSERT INTO dbo.NhanVien
(
    ID_NV,
    Ten_NV,
    Luong,
    Ngaysinh,
    SDT,
    Email,
    NgayBatdau,
    ID_Phongban,
    NgayKetthuc
)
VALUES
(   1,         -- ID_NV - int
    N'QLKH@gmail.com',       -- Ten_NV - nvarchar(50)
    1000,         -- Luong - int
    '06/05/2000', -- Ngaysinh - date
    N'0901234567',       -- SDT - nvarchar(50)
    N'QLKH1@gmail.com',       -- Email - nvarchar(50)
    GETDATE(), -- NgayBatdau - date
    1,         -- ID_Phongban - int
    null  -- NgayKetthuc - date
    )

INSERT INTO dbo.Taikhoan_Nhanvienn
(
    Ten_TK,
    Matkhau,
    ID_NV
)
VALUES
(   N'QLKH1', -- Ten_TK - nvarchar(50)
    N'1', -- Matkhau - nvarchar(50)
    1    -- ID_NV - int
    )

INSERT INTO dbo.HocVien
(
    ID_Hocvien,
    Ten_Hocvien,
    Email,
    SDT,
    Ngaysinh
)
VALUES
(   0,        -- ID_Hocvien - int
    N'root',      -- Ten_Hocvien - nvarchar(50)
    N'email',      -- Email - nvarchar(50)
    N'sdt',      -- SDT - nvarchar(50)
    GETDATE() -- Ngaysinh - date
    )







	SELECT * FROM dbo.PhongBan

	SELECT * FROM dbo.NhanVien
	SELECT * FROM dbo.Taikhoan_Nhanvienn
	Select ID_Phongban from PhongBan where Ten_Phongban = N'Phòng Đào tạo'
	SELECT * FROM dbo.Taikhoan_Nhanvienn
	DELETE FROM dbo.NhanVien WHERE ID_NV = 3
	DELETE FROM dbo.Taikhoan_Nhanvienn WHERE Ten_TK = 'QLCM1'
	SELECT * FROM dbo.Nhom_Chuyende
	SELECT * FROM dbo.DonDangKi
	DELETE FROM dbo.DonDangKi WHERE ID_Khoa = 6
	SELECT * FROM dbo.Dangky_Nhanhhoc
	SELECT * FROM dbo.DS_NhanhHoc