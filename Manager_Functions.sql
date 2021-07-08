
USE QuanLyTrungTam
go

If OBJECT_ID('DangNhap') IS NOT NULL
Drop Function DangNhap
go

Create function DangNhap (@tenDN nvarchar(20), @mk nvarchar(20), @loaiTK int)
returns int
AS
BEGIN
	Declare @check int = 1;
	--loaiTk = 0 la hoc vien
	IF (@loaiTK = 0) 
	Begin
		IF ((Select COUNT(*) From Taikhoan_HocVien 
			Where Ten_TK = @tenDN)= 0)
			Set @check = 0;
		ELSE IF ((Select COUNT(*) From Taikhoan_HocVien 
			Where Matkhau = @mk)= 0)
			Set @check = -1;
	End
	--loaiTk = 1 la Nhan vien
	IF (@loaiTK = 1) 
	Begin
		IF ((Select COUNT(*) From Taikhoan_Nhanvienn 
				WHERE Ten_TK = @tenDN)= 0)
			Set @check = 0;
			IF ((Select COUNT(*) From Taikhoan_Nhanvienn 
				WHERE Matkhau = @mk AND Ten_TK = @tenDN)= 0)
			Set @check = -1;
		ELSE 
		BEGIN 
		IF ((SELECT nv.ID_Phongban FROM dbo.NhanVien nv JOIN dbo.Taikhoan_Nhanvienn tknv ON nv.ID_NV = tknv.ID_NV WHERE tknv.Ten_TK = @tenDN) = 1)
			SET @check = 1;
		ELSE IF ((SELECT nv.ID_Phongban FROM dbo.NhanVien nv JOIN dbo.Taikhoan_Nhanvienn tknv ON nv.ID_NV = tknv.ID_NV WHERE tknv.Ten_TK = @tenDN) = 2)
			SET @check = 2;
		ELSE IF ((SELECT nv.ID_Phongban FROM dbo.NhanVien nv JOIN dbo.Taikhoan_Nhanvienn tknv ON nv.ID_NV = tknv.ID_NV WHERE tknv.Ten_TK = @tenDN) = 3)
			SET @check = 3;
		ELSE IF ((SELECT nv.ID_Phongban FROM dbo.NhanVien nv JOIN dbo.Taikhoan_Nhanvienn tknv ON nv.ID_NV = tknv.ID_NV WHERE tknv.Ten_TK = @tenDN) = 4)
			SET @check = 4;
		END 
	End
	Return @check
END;
GO


SELECT * FROM dbo.Taikhoan_Nhanvienn

If OBJECT_ID('ThongtinTK','P') IS NOT NULL
Drop procedure ThongtinTK
go

Create procedure ThongtinTK (@tenDN nvarchar(20), @loaiTK int)
AS
	If (@loaiTK = 0) 
		Select tk.Ten_TK, tk.ID_Hocvien, hv.Ten_Hocvien, hv.Email
		From Taikhoan_HocVien tk join HocVien hv ON tk.ID_Hocvien = hv.ID_Hocvien
	If (@loaiTK = 1) 
		Select tk.Ten_TK, tk.ID_NV, nv.Ten_NV, nv.Email 
		From Taikhoan_Nhanvienn tk join NhanVien nv ON tk.ID_NV = nv.ID_NV
GO


If OBJECT_ID('Chitiet_LHDT','P') IS NOT NULL
Drop procedure Chitiet_LHDT
go

Create procedure Chitiet_LHDT (@idloai int)
AS
	If (EXISTS (SELECT * FROM dbo.Chungchi_Hocphan WHERE ID_Loai = @idloai)) --Lớp kỹ thuật viên
		Select A.ID_Hocphan as ID, B.Ten_Hocphan as Ten, B.Hocphi
		from Chungchi_Hocphan A JOIN DS_HocPhan B ON A.ID_Hocphan = B.ID_Hocphan Where A.ID_Loai = @idloai
	If (EXISTS (SELECT * FROM dbo.LopChuyende WHERE ID_Loai = @idloai)) --Lớp chuyên đề
		Select C.ID_Chuyende as ID, D.Ten_Monhoc as Ten, D.Hocphi 
		from Lopchuyende A JOIN Nhom_Chuyende B ON A.ID_Nhom = B.ID_Nhom
							JOIN dbo.Chitiet_NhomCD C ON C.ID_Nhom = B.ID_Nhom 
							JOIN dbo.DS_MonHoc D ON C.ID_Chuyende = D.ID_Monhoc
		WHERE A.ID_Loai = @idloai
	If (EXISTS (SELECT * FROM dbo.Chungchi_Monhoc WHERE ID_Loai = @idloai)) --Chứng chỉ A
		Select A.ID_Monhoc as ID, B.Ten_Monhoc as Ten, B.Hocphi 
		from Chungchi_Monhoc A JOIN DS_MonHoc B ON A.ID_Monhoc = B.ID_Monhoc Where A.ID_Loai = @idloai
	If (EXISTS (SELECT * FROM dbo.Chungchi_Nhanhhoc WHERE ID_Loai = @idloai)) --Chứng chỉ B
		Select A.ID_Nhanh as ID, B.Ten_Nhanh as Ten, B.Hocphi 
		from Chungchi_Nhanhhoc A INNER JOIN DS_NhanhHoc B ON A.ID_Nhanh = B.ID_Nhanh Where A.ID_Loai = @idloai
GO


If OBJECT_ID('KhoaHoc_Dangki') IS NOT NULL
Drop function Khoahoc_Dangki
go

Create function Khoahoc_Dangki (@idKhoahoc INT)
RETURNS int
AS
begin
	DECLARE @res int;
	SET @res = (SELECT COUNT(*) FROM DangKi WHERE ID_Khoa = @idKhoahoc)
	RETURN @res
end
GO

If OBJECT_ID('Khoahoc_Trangthai') IS NOT NULL
Drop function Khoahoc_Trangthai
go

Create function Khoahoc_Trangthai (@current DATETIME, @begin DATETIME, @idKhoahoc int)
RETURNS NVARCHAR(20)
AS
begin
	DECLARE @res NVARCHAR(20);
	IF (@current >= @begin)
		SET @res = N'Đang diễn ra';
	IF (@current < @begin)
		SET @res = N'Đang mở đăng kí';
	IF ((SELECT COUNT(*) FROM dbo.DangKi WHERE ID_Khoa = @idKhoahoc) = (SELECT SoLuong FROM dbo.KhoaDaoTao WHERE ID_Khoa = @idKhoahoc))
		SET @res = N'Đã đóng đăng kí';
	RETURN @res
end
GO


If OBJECT_ID('Check_Cur_Pass') IS NOT NULL
Drop function Check_Cur_Pass
go

Create function Check_Cur_Pass (@input VARCHAR(20), @id INT , @type int)
RETURNS int
AS
BEGIN
	DECLARE @check INT = 0
	IF (@type = 0) --Hocvien
	begin
		IF ((SELECT Matkhau FROM dbo.Taikhoan_HocVien WHERE ID_Hocvien = @id) = @input)
			SET @check = 1
	end
	ELSE 
	begin
		IF ((SELECT Matkhau FROM dbo.Taikhoan_Nhanvienn WHERE ID_NV = @id) = @input)
			SET @check = 1
	end
	RETURN @check
END
GO




If OBJECT_ID('KhoaHoc_Hocphi','P') IS NOT NULL
Drop procedure KhoaHoc_Hocphi
go

Create PROCEDURE KhoaHoc_Hocphi (@idKhoa INT)
AS 
	IF (EXISTS(SELECT * FROM dbo.KhoaDaoTao A JOIN dbo.Chungchi_Hocphan B ON A.LoaiHinhDaoTao = B.ID_Loai WHERE A.ID_Khoa = @idKhoa))
		SELECT SUM(C.Hocphi) AS Hocphi FROM dbo.KhoaDaoTao A JOIN dbo.Chungchi_Hocphan B ON A.LoaiHinhDaoTao = B.ID_Loai
												JOIN dbo.DS_HocPhan C ON B.ID_Hocphan = C.ID_Hocphan 
												WHERE A.ID_Khoa = @idKhoa
	IF (EXISTS(SELECT * FROM dbo.KhoaDaoTao A JOIN dbo.Chungchi_Monhoc B ON A.LoaiHinhDaoTao = B.ID_Loai WHERE A.ID_Khoa = @idKhoa))
		SELECT SUM(C.Hocphi) AS Hocphi FROM dbo.KhoaDaoTao A JOIN dbo.Chungchi_Monhoc B ON A.LoaiHinhDaoTao = B.ID_Loai
													JOIN dbo.DS_MonHoc C ON C.ID_Monhoc = B.ID_Monhoc
													WHERE A.ID_Khoa = @idKhoa
	IF (EXISTS(SELECT * FROM dbo.KhoaDaoTao A JOIN dbo.LopChuyende B ON A.LoaiHinhDaoTao = B.ID_Loai
											  JOIN dbo.Chitiet_NhomCD C ON C.ID_Nhom = B.ID_Nhom
											  WHERE A.ID_Khoa = @idKhoa))
		SELECT SUM(D.Hocphi) AS Hocphi FROM dbo.KhoaDaoTao A JOIN dbo.LopChuyende B ON A.LoaiHinhDaoTao = B.ID_Loai
													JOIN dbo.Chitiet_NhomCD C ON C.ID_Nhom = B.ID_Nhom
													JOIN dbo.DS_MonHoc D ON D.ID_Monhoc = C.ID_Chuyende
													WHERE A.ID_Khoa = @idKhoa
GO 



If OBJECT_ID('DangKy_Hocphi','P') IS NOT NULL
Drop procedure DangKy_Hocphi
go

Create PROCEDURE DangKy_Hocphi (@idKhoa INT, @tenHV NVARCHAR(50))
AS
	IF (EXISTS(SELECT * FROM dbo.HocVien A JOIN dbo.Dangky_Nhanhhoc B ON A.ID_Hocvien = B.ID_Hocvien WHERE B.ID_Khoa = @idKhoa AND A.Ten_Hocvien = @tenHV))
		SELECT dbo.DS_NhanhHoc.Hocphi FROM dbo.Dangky_Nhanhhoc JOIN dbo.DS_NhanhHoc ON DS_NhanhHoc.ID_Nhanh = Dangky_Nhanhhoc.ID_Nhanh
										JOIN dbo.HocVien ON HocVien.ID_Hocvien = Dangky_Nhanhhoc.ID_Hocvien
										WHERE ID_Khoa = @idKhoa AND @tenHV = Ten_Hocvien

	ELSE EXEC dbo.KhoaHoc_Hocphi @idKhoa = @idKhoa-- int
GO


If OBJECT_ID('DiemTB_Hocphan') IS NOT NULL
Drop function DiemTB_Hocphan
go

CREATE FUNCTION DiemTB_Hocphan (@idHocvien INT , @tenHocphan NVARCHAR(50))
RETURNS FLOAT 
AS
BEGIN 
	DECLARE @res FLOAT = 0.0;
	
	SET @res = (SELECT SUM(C.Diemthi) FROM dbo.KetquaHocphan A JOIN dbo.Chitiet_Hocphan B ON B.ID_Hocphan = A.ID_Hocphan 
												JOIN dbo.DSLopHoc C ON C.ID_Monhoc = B.ID_Monhoc AND C.ID_Hocvien = A.ID_Hocvien
												JOIN dbo.DS_HocPhan D ON D.ID_Hocphan = A.ID_Hocphan
					   WHERE A.ID_Hocvien = @idHocvien AND D.Ten_Hocphan = @tenHocphan
					   GROUP BY A.ID_Hocvien) 
					   / 
				(SELECT COUNT(dbo.Chitiet_Hocphan.ID_MonHoc) FROM dbo.KetquaHocphan JOIN dbo.Chitiet_Hocphan ON Chitiet_Hocphan.ID_Hocphan = KetquaHocphan.ID_Hocphan
																					JOIN dbo.DS_HocPhan ON DS_HocPhan.ID_Hocphan = KetquaHocphan.ID_Hocphan
					WHERE dbo.DS_HocPhan.Ten_Hocphan = @tenHocphan AND ID_Hocvien = @idHocvien
					GROUP BY KetquaHocphan.ID_Hocphan)
	RETURN @res
END 
GO



If OBJECT_ID('Tao_LichThi','P') IS NOT NULL
Drop procedure Tao_LichThi
go

CREATE PROCEDURE Tao_LichThi (@idKhoaHoc INT, @ngaythi DATETIME)
AS
	DECLARE @loai INT = (SELECT LoaiHinhDaoTao FROM dbo.KhoaDaoTao WHERE ID_Khoa = @idKhoaHoc)
	IF EXISTS (SELECT * FROM dbo.Chungchi_Hocphan WHERE ID_Loai = @loai)
		INSERT INTO dbo.Lichthi
		SELECT
			@idKhoaHoc,
			b.ID_Monhoc,
			0,
			@ngaythi
		FROM dbo.Chungchi_Hocphan a JOIN dbo.Chitiet_Hocphan b ON a.ID_Hocphan = b.ID_Hocphan WHERE a.ID_Loai = @loai 

	IF EXISTS (SELECT * FROM dbo.Chungchi_Nhanhhoc WHERE ID_Loai = @loai)
		INSERT INTO dbo.Lichthi
		SELECT
			@idKhoaHoc,
			b.ID_Monhoc,
			0,
			@ngaythi
		FROM dbo.Chungchi_Nhanhhoc a JOIN dbo.Chitiet_NhanhHoc b ON a.ID_Nhanh = b.ID_Nhanh WHERE a.ID_Loai = @loai 

	IF EXISTS (SELECT * FROM dbo.Chungchi_Monhoc WHERE ID_Loai = @loai)
		INSERT INTO dbo.Lichthi
		SELECT
			@idKhoaHoc,
			a.ID_Monhoc,
			0,
			@ngaythi
		FROM dbo.Chungchi_Monhoc a WHERE a.ID_Loai = @loai

	IF EXISTS (SELECT * FROM dbo.LopChuyende WHERE ID_Loai = @loai)
		INSERT INTO dbo.Lichthi
		SELECT
			@idKhoaHoc,
			b.ID_Chuyende,
			0,
			@ngaythi
		FROM dbo.LopChuyende a JOIN dbo.Chitiet_NhomCD b ON a.ID_Nhom = b.ID_Nhom 
GO















SELECT * FROM LopHoc JOIN dbo.KhoaDaoTao ON KhoaDaoTao.ID_Khoa = LopHoc.ID_Khoa WHERE ID_GV = 8


Select * from DSLopHoc 

UPDATE dbo.DSLopHoc
SET Diemthi = 0
WHERE ID_Hocvien = 1