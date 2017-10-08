
drop database QLNhaSach
-- Chay lenh tao CSDL truoc
create database QLNhaSach
go
-- Refesh lai CSDL moi lam tiep cac lenh sau
use QLNhaSach
go
-------------------------------------------------
-------------------------------------------------
-- Tao bang + khoa chinh,khoa ngoai
--select * delete from PHIEU_NHAP
create table PHIEU_NHAP(
	MaPhieuNhap nvarchar(6) Primary key,
	NgayNhap DATETIME
	)
----------------------------------------------------------------------------------------------------------
--drop table SACH
create table SACH(
	MaSach char(4) primary key,
	TenSach nvarchar(50),
	TheLoai nvarchar(50),
	TacGia nvarchar(50),
	SoLuongTon int,
	DonGia money
)
--select *  delete from sach
----------------------------------------------------------------------------------------------------------
insert into SACH values('PT01',N'Duong loi cach mang',N'Chính trị',N'NXB Quốc Gia',150,2000)
insert into SACH values('SE01',N'nhap mon cong nghe phan mem',N'lap trinh','NXB Quốc Gia',400,5000)
insert into SACH values('PT02',N'Duong loi cach mang',N'Chính trị',N'NXB Quốc Gia',150,3000)
insert into SACH values('IT08',N'laptrinh truc quan',N'lap trinh',N'NXB Quốc Gia',350,4000)
----------------------------------------------------------------------------------------------------------
create table KHACH_HANG(
	MaKhachHang varchar(8) primary key,
	HoVaTenKhachHang varchar(50),
	SoTienNoHienTai money,
	DiaChi varchar(100) ,
	Email varchar(50) ,
	DienThoai varchar(12)
)
----------------------------------------------------------------------------------------------------------
--delete from KHACH_HANG
insert into KHACH_HANG values ('KH01','Nguyen Van A',5000,'456 Nguyen Dinh Chieu','abc@gmail.com','01234567894')
insert into KHACH_HANG values ('KH00','Nguyen Van B',2000,'123 Cong Hoa','xyz@gmail.com','01254567524')

----------------------------------------------------------------------------------------------------------
--delete select * from HOA_DON_BAN_SACH
create table HOA_DON_BAN_SACH(
	MaHoaDonBanSach varchar(6) primary key,
	MaKhachHang varchar(8) NOT NULL,
	NgayLapHoaDon smalldatetime NOT NULL	
)
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------
--delete from PHIEU_THU_TIEN
create table PHIEU_THU_TIEN(
	MaPhieuThuTien nvarchar(6) primary key,
	MaKhachHang VARCHAR(8),
	NgayThuTien smalldatetime,
	SoTienThu money
)
----------------------------------------------------------------------------------------------------------
if exists (select * from sysobjects where name = 'SPPHIEU_THU_TIEN' and type = 'P')
    drop procedure SPPHIEU_THU_TIEN
go
create PROCEDURE dbo.SPPHIEU_THU_TIEN

	@MaKhachHang VARCHAR(8),
	@NgayThuTien smalldatetime,
	@SoTienThu money
AS BEGIN

--SET NOCOUNT ON;

     IF exists (SELECT * FROM dbo.PHIEU_THU_TIEN)
     BEGIN
		 INSERT INTO dbo.PHIEU_THU_TIEN(MaPhieuThuTien,MaKhachHang,NgayThuTien,SoTienThu)
		 SELECT 
				'PT' + RIGHT('0000' + CAST(MaPhieuThuTien + 1 AS NVARCHAR(4)), 4)
				,@MaKhachHang
				,@NgayThuTien
				,@SoTienThu
		 FROM (
			  SELECT TOP 1 MaPhieuThuTien = CAST(RIGHT(MaPhieuThuTien, 4) AS INT)
			  FROM dbo.PHIEU_THU_TIEN
			  ORDER BY MaPhieuThuTien DESC
		 ) t
	END
	ELSE		
	BEGIN
		INSERT INTO dbo.PHIEU_THU_TIEN(MaPhieuThuTien,MaKhachHang,NgayThuTien,SoTienThu) VALUES ('PT0000'
				,@MaKhachHang
				,@NgayThuTien
				,@SoTienThu)
	END
END 
----------------------------------------------------------------------------------------------------------
--delete from CHI_TIET_PHIEU_NHAP
create table CHI_TIET_PHIEU_NHAP(
	MaChiTietPhieuNhap NVARCHAR(6) primary key,
	MaPhieuNhap NVARCHAR(6),
	MaSach char(4),
	SoLuongNhap int,
)
----------------------------------------------------------------------------------------------------------
if exists (select * from sysobjects where name = 'SPCHITIETPHIEUNHAP' and type = 'P')
    drop procedure SPCHITIETPHIEUNHAP
go
create PROCEDURE dbo.SPCHITIETPHIEUNHAP
	@MaPhieuNhap NVARCHAR(6),
	@MaSach char(4),
	@SoLuongNhap int
AS BEGIN

SET NOCOUNT ON;

     IF exists (SELECT * FROM dbo.CHI_TIET_PHIEU_NHAP)
     BEGIN
		 INSERT INTO dbo.CHI_TIET_PHIEU_NHAP(MaChiTietPhieuNhap,MaPhieuNhap,MaSach,SoLuongNhap)
		 SELECT 
				'CN' + RIGHT('0000' + CAST(MaChiTietPhieuNhap + 1 AS NVARCHAR(4)), 4)
				,@MaPhieuNhap
				,@MaSach		  
				,@SoLuongNhap
		 FROM (
			  SELECT TOP 1 MaChiTietPhieuNhap = CAST(RIGHT(MaChiTietPhieuNhap, 4) AS INT)
			  FROM dbo.CHI_TIET_PHIEU_NHAP
			  ORDER BY MaChiTietPhieuNhap DESC
		 ) t
	END
	ELSE		
	BEGIN
		INSERT INTO dbo.CHI_TIET_PHIEU_NHAP(MaChiTietPhieuNhap,MaPhieuNhap,MaSach,SoLuongNhap) VALUES ('DN0000'
				,@MaPhieuNhap
				,@MaSach		  
				,@SoLuongNhap)
	END
END 
----------------------------------------------------------------------------------------------------------
--delete from CHI_TIET_HOA_DON
create table CHI_TIET_HOA_DON(
	MaChiTietHoaDon nvarchar(6) primary key,
	MaHoaDonBanSach varchar(6),
	MaSach char(4),
	SoLuongBan int
)
----------------------------------------------------------------------------------------------------
create table THAM_SO(
	SoLuongNhapToiThieu int,
	SoLuongTonDuocPhepNhap int,
	SoTienNoToiDa money,
	SoLuongTonToiThieuSauBan int,
	ApDungQuiDinh4 BIT
)
----------------------------------------------------------------------------------------------------------
insert into THAM_SO values (150,300,20000,20,1)

set dateformat dmy
-------------------------------------------
-- CHI_TIET_PHIEU_NHAP	
ALTER TABLE CHI_TIET_PHIEU_NHAP ADD CONSTRAINT FK_CT_PHIEU_NHAP FOREIGN KEY(MaPhieuNhap) REFERENCES PHIEU_NHAP(MaPhieuNhap)
ALTER TABLE CHI_TIET_PHIEU_NHAP ADD CONSTRAINT FK_CT_PHIEU_NHAP01 FOREIGN KEY(MaSach) REFERENCES SACH(MaSach)
-------------------------------------------
-- PHIEU_THU_TIEN
ALTER TABLE PHIEU_THU_TIEN ADD CONSTRAINT FK_PHIEU_THU_TIEN FOREIGN KEY(MaKhachHang) REFERENCES KHACH_HANG(MaKhachHang)
-------------------------------------------
-- HOA_DON_BAN_SACH
ALTER TABLE HOA_DON_BAN_SACH ADD CONSTRAINT FK01_HD_BAN_SACH FOREIGN KEY(MaKhachHang) REFERENCES KHACH_HANG(MaKhachHang)
-------------------------------------------
-- CHI_TIET_HOA_DON
ALTER TABLE CHI_TIET_HOA_DON ADD CONSTRAINT FK01_CTHD FOREIGN KEY(MaSach) REFERENCES SACH(MaSach)
ALTER TABLE CHI_TIET_HOA_DON ADD CONSTRAINT FK02_CTHD FOREIGN KEY(MaHoaDonBanSach) REFERENCES HOA_DON_BAN_SACH(MaHoaDonBanSach)
-- BAO CAO TON
ALTER TABLE BAOCAOTON ADD CONSTRAINT FK01_BCT FOREIGN KEY(MaSach) REFERENCES SACH(MaSach)
-- BAO CAO CONG NO
ALTER TABLE BAOCAOCONGNO ADD CONSTRAINT FK01_BCCN FOREIGN KEY(MaKhachHang) REFERENCES KHACH_HANG(MaKhachHang)
-------------------------------------------
--select * from BAOCAOTON
--drop table BAOCAOTON
create table BAOCAOTON(
	MaBaoCaoTon varchar(6) Primary key,
	Thang date,
	MaSach char(4),
	TonDau int,
	PhatSinhTon int,
	TonCuoi int
)

--drop table BAOCAOCONGNO
--delete from BAOCAOCONGNO
create table BAOCAOCONGNO(
	MaBaoCaoCongNo varchar(6) primary key,
	MaKhachHang varchar(8),
	Thang date,
	NoDau money,
	PhatSinhCongNo money,
	NoCuoi money,
)

-----procedure chi tiết hóa đơn
if exists (select * from sysobjects where name = 'SPCHI_TIET_HOA_DON' and type = 'P')
    drop procedure SPCHI_TIET_HOA_DON
go
create PROCEDURE dbo.SPCHI_TIET_HOA_DON
    
	@MaHoaDonBanSach varchar(6),
	@MaSach char(4),
	@SoLuongBan int
AS BEGIN

SET NOCOUNT ON;

     IF exists (SELECT * FROM dbo.CHI_TIET_HOA_DON)
     BEGIN
		 INSERT INTO dbo.CHI_TIET_HOA_DON(MaChiTietHoaDon,MaHoaDonBanSach,MaSach,SoLuongBan)
		 SELECT 
				'CB' + RIGHT('0000' + CAST(MaChiTietHoaDon + 1 AS NVARCHAR(4)), 4)
				,@MaHoaDonBanSach
				,@MaSach			  
				,@SoLuongBan
		 FROM (
			  SELECT TOP 1 MaChiTietHoaDon = CAST(RIGHT(MaChiTietHoaDon, 4) AS INT)
			  FROM dbo.CHI_TIET_HOA_DON
			  ORDER BY MaChiTietHoaDon DESC
		 ) t
	END
	ELSE		
	BEGIN
		INSERT INTO dbo.CHI_TIET_HOA_DON(MaChiTietHoaDon,MaHoaDonBanSach,MaSach,SoLuongBan) VALUES ('DN0000'
				,@MaHoaDonBanSach
				,@MaSach			  
				,@SoLuongBan)
	END
END 
------
-- procedure baocaoton
if exists (select * from sysobjects where name = 'SPBAOCAOTON' and type = 'P')
    drop procedure SPBAOCAOTON
go
create PROCEDURE dbo.SPBAOCAOTON
    @Thang date,
	@MaSach char(4),
	@TonDau money,
	@PhatSinhTon money,
	@TonCuoi money
AS BEGIN

SET NOCOUNT ON;

     IF exists (SELECT * FROM dbo.BAOCAOTON)
     BEGIN
		 INSERT INTO dbo.BAOCAOTON(MaBaoCaoTon,Thang,MaSach,TonDau,PhatSinhTon,TonCuoi)
		 SELECT 
				'BCT' + RIGHT('000' + CAST(MaBaoCaoTon + 1 AS NVARCHAR(4)), 3)
				,@Thang
				,@MaSach	
				,@TonDau
				,@PhatSinhTon	  
				,@TonCuoi
		 FROM (
			  SELECT TOP 1 MaBaoCaoTon = CAST(RIGHT(MaBaoCaoTon, 3) AS INT)
			  FROM dbo.BAOCAOTON
			  ORDER BY MaBaoCaoTon DESC
		 ) t
	END
	ELSE		
	BEGIN
		INSERT INTO dbo.BAOCAOTON(MaBaoCaoTon,Thang,MaSach,TonDau,PhatSinhTon,TonCuoi) VALUES ('BCT000'
				,@Thang
				,@MaSach	
				,@TonDau
				,@PhatSinhTon	  
				,@TonCuoi)
	END
END 
---- procedure Báo cáo nợ công
if exists (select * from sysobjects where name = 'SPBAOCAOCONGNO' and type = 'P')
    drop procedure SPBAOCAOCONGNO
go
create PROCEDURE dbo.SPBAOCAOCONGNO
    @Thang date,
	@MaKhachHang varchar(8),
	@NoDau money,
	@PhatSinhCongNo money,
	@NoCuoi money
AS BEGIN

SET NOCOUNT ON;

     IF exists (SELECT * FROM dbo.BAOCAOCONGNO)
     BEGIN
		 INSERT INTO dbo.BAOCAOCONGNO(MaBaoCaoCongNo,Thang,MaKhachHang,NoDau,PhatSinhCongNo,NoCuoi)
		 SELECT 
				'CB' + RIGHT('0000' + CAST(MaBaoCaoCongNo + 1 AS NVARCHAR(4)), 4)
				,@Thang
				,@MaKhachHang	
				,@NoDau
				,@PhatSinhCongNo	  
				,@NoCuoi
		 FROM (
			  SELECT TOP 1 MaBaoCaoCongNo = CAST(RIGHT(MaBaoCaoCongNo, 4) AS INT)
			  FROM dbo.BAOCAOCONGNO
			  ORDER BY MaBaoCaoCongNo DESC
		 ) t
	END
	ELSE		
	BEGIN
		INSERT INTO dbo.BAOCAOCONGNO(MaBaoCaoCongNo,Thang,MaKhachHang,NoDau,PhatSinhCongNo,NoCuoi) VALUES ('DN0000'
				,@Thang
				,@MaKhachHang
				,@NoDau
				,@PhatSinhCongNo	  
				,@NoCuoi)
	END
END 
