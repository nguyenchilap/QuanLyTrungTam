use QuanLyTrungTam
go

--Drop Trigger Sum_Hocphi_Hocphan
Create Trigger Sum_Hocphi_Hocphan ON Chitiet_Hocphan
AFTER INSERT,DELETE AS
BEGIN
	UPDATE DS_HocPhan
	Set Hocphi += TEMP.Hocphi
	FROM DS_HocPhan dshp INNER JOIN (SELECT inserted.ID_Hocphan, SUM(dsmh.Hocphi) AS Hocphi 
									FROM inserted INNER JOIN DS_MonHoc dsmh ON inserted.ID_Monhoc = dsmh.ID_Monhoc
									GROUP BY inserted.ID_Hocphan) TEMP
	ON dshp.ID_Hocphan = TEMP.ID_Hocphan

	UPDATE DS_HocPhan
	Set Hocphi -= TEMP.Hocphi
	FROM DS_HocPhan dshp INNER JOIN (SELECT deleted.ID_Hocphan, SUM(dsmh.Hocphi) AS Hocphi 
									FROM deleted INNER JOIN DS_MonHoc dsmh ON deleted.ID_Monhoc = dsmh.ID_Monhoc
									GROUP BY deleted.ID_Hocphan) TEMP
	ON dshp.ID_Hocphan = TEMP.ID_Hocphan
END
GO

--Drop Trigger Sum_Hocphi_NhomCD
CREATE TRIGGER Sum_Hocphi_NhomCD ON dbo.Chitiet_NhomCD
AFTER INSERT,DELETE AS
BEGIN 
	UPDATE dbo.Nhom_Chuyende
	SET Hocphi += TEMP.Hocphi
	FROM dbo.Nhom_Chuyende A INNER JOIN (SELECT Inserted.ID_Nhom, SUM(dbo.DS_MonHoc.Hocphi) AS Hocphi
										FROM inserted INNER JOIN dbo.DS_MonHoc ON inserted.ID_Chuyende = dbo.DS_MonHoc.ID_Monhoc
										GROUP BY Inserted.ID_Nhom) TEMP
	ON A.ID_Nhom = TEMP .ID_Nhom

	UPDATE dbo.Nhom_Chuyende
	SET Hocphi -= TEMP.Hocphi
	FROM dbo.Nhom_Chuyende A INNER JOIN (SELECT Deleted.ID_Nhom, SUM(dbo.DS_MonHoc.Hocphi) AS Hocphi
										FROM Deleted INNER JOIN dbo.DS_MonHoc ON Deleted.ID_Chuyende = dbo.DS_MonHoc.ID_Monhoc
										GROUP BY Deleted.ID_Nhom) TEMP
	ON A.ID_Nhom = TEMP .ID_Nhom
END 
GO

--Drop trigger Sum_Hocphi_Nhanhhoc
CREATE TRIGGER Sum_Hocphi_Nhanhhoc ON dbo.Chitiet_NhanhHoc
AFTER INSERT,DELETE AS 
BEGIN 
	UPDATE dbo.DS_NhanhHoc
	SET Hocphi += TEMP.Hocphi
	FROM dbo.DS_NhanhHoc A INNER JOIN (SELECT Inserted.ID_Nhanh, SUM(dbo.DS_MonHoc.Hocphi) AS Hocphi
										FROM inserted INNER JOIN dbo.DS_MonHoc ON Inserted.ID_MonHoc = dbo.DS_MonHoc.ID_Monhoc
										GROUP BY Inserted.ID_Nhanh) TEMP
	ON TEMP.ID_Nhanh = A.ID_Nhanh

	UPDATE dbo.DS_NhanhHoc
	SET Hocphi -= TEMP.Hocphi
	FROM dbo.DS_NhanhHoc A INNER JOIN (SELECT Deleted.ID_Nhanh, SUM(dbo.DS_MonHoc.Hocphi) AS Hocphi
										FROM Deleted INNER JOIN dbo.DS_MonHoc ON Deleted.ID_MonHoc = dbo.DS_MonHoc.ID_Monhoc
										GROUP BY Deleted.ID_Nhanh) TEMP
	ON TEMP.ID_Nhanh = A.ID_Nhanh
END 
go

--Drop Trigger Add_Course
Create Trigger Add_Course ON KhoaDaoTao
AFTER INSERT AS
BEGIN
	If (EXISTS (SELECT * FROM inserted INNER JOIN Chungchi_Hocphan cchp ON inserted.LoaiHinhDaoTao = cchp.ID_Loai))
	BEGIN 
		INSERT INTO dbo.LopHoc
		(
		    ID_Khoa,
		    ID_Monhoc,
		    ID_GV,
		    Soluong
		)
		SELECT 
		   (SELECT Inserted.ID_Khoa FROM Inserted), 
		    dbo.Chitiet_Hocphan.ID_Monhoc, 
		    0, 
		    0  
		FROM dbo.Chungchi_Hocphan JOIN dbo.Chitiet_Hocphan ON Chitiet_Hocphan.ID_Hocphan = Chungchi_Hocphan.ID_Hocphan
						   JOIN Inserted ON Inserted.LoaiHinhDaoTao = dbo.Chungchi_Hocphan.ID_Loai
	End	

	IF (EXISTS (SELECT * FROM inserted INNER JOIN dbo.Chungchi_Monhoc ccmh ON inserted.LoaiHinhDaoTao = ccmh.ID_Loai))
	BEGIN
		INSERT INTO dbo.LopHoc
		(
		    ID_Khoa,
		    ID_Monhoc,
		    ID_GV,
		    Soluong
		)
		SELECT 
		   (SELECT Inserted.ID_Khoa FROM Inserted), 
		    dbo.Chungchi_Monhoc.ID_Monhoc, 
		    0, 
		    0  
		FROM dbo.Chungchi_Monhoc JOIN Inserted ON Inserted.LoaiHinhDaoTao = dbo.Chungchi_Monhoc.ID_Loai 
    END


	IF (EXISTS (SELECT * FROM inserted INNER JOIN dbo.Chungchi_Nhanhhoc ccmh ON inserted.LoaiHinhDaoTao = ccmh.ID_Loai))
	BEGIN
		INSERT INTO dbo.LopHoc
		(
		    ID_Khoa,
		    ID_Monhoc,
		    ID_GV,
		    Soluong
		)
		SELECT 
		   (SELECT Inserted.ID_Khoa FROM Inserted), 
		    dbo.Chitiet_NhanhHoc.ID_Monhoc, 
		    0, 
		    0  
		FROM dbo.Chungchi_Nhanhhoc JOIN dbo.Chitiet_NhanhHoc ON Chitiet_NhanhHoc.ID_Nhanh = Chungchi_Nhanhhoc.ID_Nhanh
								   JOIN Inserted ON Inserted.LoaiHinhDaoTao = dbo.Chungchi_Nhanhhoc.ID_Loai
    END

	IF (EXISTS (SELECT * FROM Inserted INNER JOIN dbo.LopChuyende lcd ON Inserted.LoaiHinhDaoTao = lcd.ID_Loai))
	BEGIN 
		INSERT INTO dbo.LopHoc
		(
		    ID_Khoa,
			ID_Monhoc,
		    ID_GV,
		    Soluong
		)
		SELECT
			(SELECT Inserted.ID_Khoa FROM Inserted), -- ID_Khoa - int
		    dbo.Chitiet_NhomCD.ID_Chuyende, -- ID_Monhoc - int
		    0, -- ID_GV - int
		    0  -- Soluong - int
		FROM dbo.LopChuyende JOIN dbo.Chitiet_NhomCD ON Chitiet_NhomCD.ID_Nhom = LopChuyende.ID_Nhom
	END
END
go

--Drop Trigger Hocvien_Dangki
CREATE TRIGGER Hocvien_Dangki ON DangKi
AFTER INSERT AS 
BEGIN
	If (EXISTS (SELECT * FROM inserted INNER JOIN dbo.KhoaDaoTao kdt ON kdt.ID_Khoa = Inserted.ID_Khoa
									   INNER JOIN Chungchi_Hocphan cchp ON kdt.LoaiHinhDaoTao = cchp.ID_Loai))
	BEGIN 

		INSERT INTO dbo.KetquaHocphan
		SELECT 
			(SELECT ID_Hocvien FROM Inserted),  -- ID_Hocvien - int
		    dbo.Chungchi_Hocphan.ID_Hocphan,  -- ID_Hocphan - int
		    dbo.KhoaDaoTao.ID_Khoa,  -- ID_Khoa - int
		    0,  -- Solanthilai - int
		    N'Chưa hoàn thành' -- Hoanthanh - nvarchar(50)
		FROM dbo.KhoaDaoTao JOIN dbo.Chungchi_Hocphan ON dbo.Chungchi_Hocphan.ID_Loai = dbo.KhoaDaoTao.LoaiHinhDaoTao
		WHERE dbo.KhoaDaoTao.ID_Khoa = (SELECT ID_Khoa FROM Inserted)
	END 

	IF (NOT EXISTS (SELECT * FROM Inserted INNER JOIN dbo.KhoaDaoTao ON KhoaDaoTao.ID_Khoa = Inserted.ID_Khoa
									    INNER JOIN dbo.Chungchi_Nhanhhoc ON dbo.KhoaDaoTao.LoaiHinhDaoTao = dbo.Chungchi_Nhanhhoc.ID_Loai))
	BEGIN
		INSERT INTO dbo.DSLopHoc
		SELECT 
			dbo.HocVien.ID_Hocvien,  -- ID_Hocvien - int
			dbo.LopHoc.ID_Monhoc,  -- ID_Monhoc - int
			dbo.LopHoc.ID_Khoa,  -- ID_Khoa - int
			0,  -- Sobuoivang - int
			0.0 -- Diemthi - float
		FROM Inserted JOIN dbo.HocVien ON HocVien.ID_Hocvien = Inserted.ID_Hocvien 
					JOIN dbo.LopHoc ON Inserted.ID_Khoa = dbo.LopHoc.ID_Khoa
	END

	ELSE 
	BEGIN 
		INSERT INTO dbo.DSLopHoc
		SELECT 
			Inserted.ID_Hocvien,  -- ID_Hocvien - int
		    dbo.Chitiet_NhanhHoc.ID_MonHoc,  -- ID_Monhoc - int
		    Inserted.ID_Khoa,  -- ID_Khoa - int
		    0,  -- Sobuoivang - int
		    0.0 -- Diemthi - float
		FROM Inserted JOIN dbo.Dangky_Nhanhhoc ON Dangky_Nhanhhoc.ID_Hocvien = Inserted.ID_Hocvien
					  JOIN dbo.Chitiet_NhanhHoc ON Chitiet_NhanhHoc.ID_Nhanh = Dangky_Nhanhhoc.ID_Nhanh
	END 
END 
go

--Drop Trigger Hocvien_DangkyNhanhhoc
CREATE TRIGGER HocVien_DangkyNhanhhoc ON dbo.Dangky_Nhanhhoc
AFTER INSERT AS
BEGIN
	IF (EXISTS (SELECT * FROM Inserted INNER JOIN dbo.KhoaDaoTao ON KhoaDaoTao.ID_Khoa = Inserted.ID_Khoa
									    INNER JOIN dbo.Chungchi_Nhanhhoc ON dbo.KhoaDaoTao.LoaiHinhDaoTao = dbo.Chungchi_Nhanhhoc.ID_Loai))
	BEGIN 
		INSERT INTO dbo.DSLopHoc
		SELECT
		    Inserted.ID_Hocvien,  -- ID_Hocvien - int
		    dbo.Chitiet_NhanhHoc.ID_MonHoc,  -- ID_Monhoc - int
		    dbo.LopHoc.ID_Khoa,  -- ID_Khoa - int
		    0,  -- Sobuoivang - int
		    0.0 -- Diemthi - float
		FROM Inserted JOIN dbo.Chitiet_NhanhHoc ON Chitiet_NhanhHoc.ID_Nhanh = Inserted.ID_Nhanh
							     JOIN dbo.LopHoc ON LopHoc.ID_Monhoc = Chitiet_NhanhHoc.ID_MonHoc 
		WHERE dbo.LopHoc.ID_Khoa = Inserted.ID_Khoa
	END
END
GO
















SELECT * FROM dbo.LopHoc

SELECT * FROM PhongBan

SELECT * FROM dbo.Chitiet_NhanhHoc


INSERT INTO dbo.DangKi
(
    ID_Khoa,
    ID_Hocvien,
    Totnghiep
)
VALUES
(   1,  -- ID_Khoa - int
    1,  -- ID_Hocvien - int
    N'Chưa' -- Totnghiep - nvarchar(50)
    )



SELECT * FROM dbo.DSLopHoc
SELECT * FROM dbo.DangKi
SELECT * FROM dbo.KetquaHocphan

SELECT * FROM dbo.KhoaDaoTao
SELECT * FROM dbo.LoaiHinhDaoTao