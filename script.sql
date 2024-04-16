﻿--MASV - HO TEN
--THANH VIEN 1: 21120065 - NGUYỄN TRANG MAI HẠNH
--THANH VIEN 2: 21120096 - HỒ CHÂU LONG
--THANH VIEN 3: 21120114 - NGUYỄN TRẦN THIÊN PHÚC
--THANH VIEN 4: 21120253 - HUỲNH QUỐC HUY
--LAB: 03 - NHOM 
--NGAY: 13/4/2024
USE MASTER
GO
IF DB_ID('QLSINHVIEN') IS NOT NULL
	DROP DATABASE QLSINHVIEN
GO
CREATE DATABASE QLSINHVIEN
GO
USE QLSINHVIEN
GO

CREATE TABLE SINHVIEN
(
	MASV VARCHAR(20),
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL,

	CONSTRAINT PK_SINHVIEN
	PRIMARY KEY(MASV)
)
CREATE TABLE NHANVIEN
(
	MANV VARCHAR(20),
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARBINARY ( MAX),
	TENDN NVARCHAR(100),
	MATKHAU VARBINARY(MAX) NOT NULL,
	PUBKEY VARCHAR(20),

	CONSTRAINT PK_NHANVIEN
	PRIMARY KEY(MANV)
)
CREATE TABLE LOP
(
	MALOP VARCHAR(20),
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20),

	CONSTRAINT PK_LOP
	PRIMARY KEY(MALOP)
)
CREATE TABLE HOCPHAN
(
	MAHP VARCHAR(20),
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT,

	CONSTRAINT PK_HOCPHAN
	PRIMARY KEY(MAHP)
)
CREATE TABLE BANGDIEM
(
	MASV VARCHAR(20),
	MAHP VARCHAR(20),
	DIEMTHI VARBINARY(MAX),

	CONSTRAINT PK_BANGDIEM
	PRIMARY KEY(MASV,MAHP)
)
ALTER TABLE SINHVIEN
ADD
	CONSTRAINT FK_SINHVIEN_LOP
	FOREIGN KEY(MALOP)
	REFERENCES LOP

ALTER TABLE LOP
ADD 
	CONSTRAINT FK_LOP_NHANVIEN
	FOREIGN KEY(MANV)
	REFERENCES NHANVIEN
ALTER TABLE BANGDIEM
ADD
	CONSTRAINT FK_BANGDIEM_HOCPHAN
	FOREIGN KEY (MAHP)
	REFERENCES HOCPHAN,

	CONSTRAINT FK_BANGDIEM_SINHVIEN
	FOREIGN KEY(MASV)
	REFERENCES SINHVIEN
--CREATE SYMMETRIC KEY SK_NHANVIEN  
--WITH  
--    ALGORITHM = AES_256  
--    ENCRYPTION BY PASSWORD = '21120253'; 
--go
GO
--===================================================================================
CREATE PROCEDURE SP_INS_PUBLIC_SINHVIEN @MASV VARCHAR(20),@HOTEN VARCHAR(100),@NGAYSINH DATETIME,
			@DIACHI VARCHAR(200), @MALOP VARCHAR(20), @TENDN VARCHAR(100),@MATKHAU VARCHAR(100)
AS
	SET NOCOUNT ON
	BEGIN
		INSERT INTO SINHVIEN
		VALUES(@MASV,CONVERT(NVARCHAR,@HOTEN),@NGAYSINH,CONVERT(NVARCHAR,@DIACHI),
		@MALOP,CONVERT(NVARCHAR,@TENDN), HashBytes('SHA1', @MATKHAU))
	END
GO

--SELECT * FROM sys.asymmetric_keys
--DROP PROCEDURE IF EXISTS SP_INS_PUBLIC_NHANVIEN
--GO
--===================================================================================

CREATE PROCEDURE SP_INS_PUBLIC_NHANVIEN @MANV VARCHAR(20),@HOTEN NVARCHAR(100),@EMAIL VARCHAR(20),
					@LUONG INT,@TENDN NVARCHAR(100),@MATKHAU VARCHAR(100)

AS  
BEGIN  

	EXEC('CREATE ASYMMETRIC KEY '+@MANV+' WITH ALGORITHM = RSA_2048 ENCRYPTION BY PASSWORD = '''+@MATKHAU+'''')
    INSERT INTO NHANVIEN
    VALUES (@MANV,@HOTEN,@EMAIL,
			ENCRYPTBYASYMKEY(ASYMKEY_ID(@MANV), CONVERT(VARBINARY(max),@LUONG)),
			CONVERT(NVARCHAR,@TENDN),HashBytes('SHA1', @MATKHAU),
			@MANV)
	--PRINT('CREATE ASYMMETRIC KEY '+@MANV+' WITH ALGORITHM = RSA_2048 
	--		ENCRYPTION BY PASSWORD = '''+@MATKHAU+'''')
END  
GO
--EXEC SP_INS_PUBLIC_NHANVIEN 'NV01', N'NGUYEN VAN A', 'NVB@', 3000000, 'NV01', 'abcd12'

--=========================================================================

DROP PROCEDURE IF EXISTS SP_SEL_PUBLIC_NHANVIEN
GO
 
CREATE PROCEDURE SP_SEL_PUBLIC_NHANVIEN @TENDN NVARCHAR(100),@MATKHAU VARCHAR(100)
AS
BEGIN
	SELECT MANV,HOTEN,EMAIL,
	CONVERT(INT, DECRYPTBYASYMKEY(ASYMKEY_ID(MANV), LUONG,CONVERT(NVARCHAR,@MATKHAU))) LUONGCB
	FROM NHANVIEN WHERE CONVERT(NVARCHAR,@TENDN) = TENDN AND MATKHAU = HashBytes('SHA1', @MATKHAU)
END
GO
-- TAO DU LIEU
--NHANVIEN----------------------
EXEC SP_INS_PUBLIC_NHANVIEN 'NV01', N'NGUYEN VAN A', 'nva@yahoo.com', 3000000, 'NV01', '123456'
EXEC SP_INS_PUBLIC_NHANVIEN 'NV02', N'NGUYEN VAN B', 'nvb@yahoo.com', 2000000, 'NV02', '1234567'
EXEC SP_INS_PUBLIC_NHANVIEN 'NV03', N'NGUYEN VAN C', 'nvc@yahoo.com', 7500000, 'NV03', '12345678'

SELECT* FROM NHANVIEN
--XEM NHANVIEN CHUA MA HOA (NV02)
exec SP_SEL_PUBLIC_NHANVIEN 'NV02', '1234567'
GO

--LOP---------------------------
INSERT INTO LOP VALUES('LOP01',N'LOPHOCA','NV01')
INSERT INTO LOP VALUES('LOP02',N'LOPHOCB','NV02')
INSERT INTO LOP VALUES('LOP03',N'LOPHOCC','NV03')

SELECT*FROM LOP

--SINHVIEN---------------------
SET DATEFORMAT DMY
EXEC SP_INS_PUBLIC_SINHVIEN 'SV01', 'NGUYEN VAN M', '1/1/1990', '280 AN DUONG VUONG', 'LOP01', 'SV01', '123456'
EXEC SP_INS_PUBLIC_SINHVIEN 'SV02', 'NGUYEN VAN N', '1/2/1990', '17 BINH THANH', 'LOP01', 'SV02', '123456'
EXEC SP_INS_PUBLIC_SINHVIEN 'SV03', 'NGUYEN VAN O', '17/12/1990', '20 LAC LONG QUAN', 'LOP02', 'SV03', '123456'
EXEC SP_INS_PUBLIC_SINHVIEN 'SV04', 'NGUYEN VAN P', '2/3/1990', '10 TRAN PHU', 'LOP02', 'SV04', '123456'
EXEC SP_INS_PUBLIC_SINHVIEN 'SV05', 'NGUYEN VAN Q', '9/1/1990', '91 LUONG DINH CUA', 'LOP03', 'SV05', '123456'
EXEC SP_INS_PUBLIC_SINHVIEN 'SV06', 'NGUYEN VAN R', '27/10/1990', 'Q1 TP HCM', 'LOP03', 'SV06', '123456'
EXEC SP_INS_PUBLIC_SINHVIEN 'SV07', 'NGUYEN VAN S', '29/12/1990', '15 TRAN NHAT DUAT', 'LOP03', 'SV07', '123456'

SELECT * FROM SINHVIEN
--WHERE MATKHAU =  HashBytes('SHA1', '123456')
--GO

--HOCPHAN ------------------------------
INSERT INTO HOCPHAN VALUES('HP01',N'VAT LY LUONG TU',4)
INSERT INTO HOCPHAN VALUES('HP02',N'HOA HUU CO',4)
INSERT INTO HOCPHAN VALUES('HP03',N'CO HOC',4)

SELECT * FROM HOCPHAN

-- BANGDIEM----------------------------------
INSERT INTO BANGDIEM VALUES('SV01','HP01',NULL)
INSERT INTO BANGDIEM VALUES('SV02','HP01',NULL)
INSERT INTO BANGDIEM VALUES('SV03','HP02',NULL)
INSERT INTO BANGDIEM VALUES('SV04','HP02',NULL)
INSERT INTO BANGDIEM VALUES('SV05','HP03',NULL)
INSERT INTO BANGDIEM VALUES('SV06','HP03',NULL)
INSERT INTO BANGDIEM VALUES('SV07','HP03',NULL)

SELECT* FROM BANGDIEM
GO
--=========================================================================================

-- PROCEDURE CUA HUY NHA =================================================================
-- PROCEDURE UPDATE BANG DIEM
CREATE PROCEDURE SP_INS_PUBLIC_BANGDIEM @MASV VARCHAR(20),@MAHP VARCHAR(20),
					@DIEM FLOAT,@PUBKEY VARCHAR(100)
AS
BEGIN
	UPDATE BANGDIEM
	SET DIEMTHI = ENCRYPTBYASYMKEY(ASYMKEY_ID(@PUBKEY),CONVERT(VARBINARY,CONVERT(VARCHAR,@DIEM)))
	WHERE MASV = @MASV AND MAHP = @MAHP
END
GO
EXEC SP_INS_PUBLIC_BANGDIEM 'SV01','HP01',9.5,'NV01'
GO

SELECT CONVERT(VARCHAR,DECRYPTBYASYMKEY(ASYMKEY_ID('NV01'), DIEMTHI,CONVERT(NVARCHAR,'123456')))
FROM BANGDIEM WHERE MASV = 'SV01' AND MAHP = 'HP01'
GO
--PROCEDURE LẤY TOÀN BỘ THÔNG TIN CỦA LỚP HỌC MÀ NGƯỜI ĐANG ĐĂNG NHẬP DẠY.
CREATE PROCEDURE SP_UV_BANGDIEM @TENDN VARCHAR(100), @MATKHAU VARCHAR(100)
AS 
BEGIN
	SELECT SV.MASV,SV.HOTEN,HP.TENHP
	FROM BANGDIEM BD JOIN SINHVIEN SV ON BD.MASV = SV.MASV JOIN HOCPHAN HP ON BD.MAHP = HP.MAHP
	JOIN LOP L ON SV.MALOP = L.MALOP JOIN NHANVIEN NV ON L.MANV = NV.MANV
	WHERE CONVERT(NVARCHAR,@TENDN) = NV.TENDN AND NV.MATKHAU = HashBytes('SHA1', @MATKHAU)
END
GO
EXEC SP_UV_BANGDIEM 'NV03','12345678'
GO
