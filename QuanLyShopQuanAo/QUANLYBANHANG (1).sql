CREATE DATABASE QUANLYBANHANG
GO 
USE QUANLYBANHANG
GO
CREATE TABLE DANGNHAP
(
TENDN VARCHAR(50) NOT NULL,
MK VARCHAR(50),
EMAIL VARCHAR(50),
QUYEN VARCHAR(20),
CONSTRAINT PK_DN PRIMARY KEY(TENDN)
)
CREATE TABLE LOAI
(
MALOAI INT  NOT NULL identity,
TENLOAI NVARCHAR(100),
CONSTRAINT PK_LOAI PRIMARY KEY(MALOAI)
)
CREATE TABLE SANPHAM

(
MASP INT NOT NULL identity,
TENSP NVARCHAR(50),
SOLUONG INT,
DONGIANHAP FLOAT,
DONGIABAN FLOAT,
HINHANH VARCHAR(100),
GHICHU NVARCHAR(256),
MALOAI INT,
CONSTRAINT PK_SP PRIMARY KEY(MASP),
CONSTRAINT CHK_SL CHECK (SOlUONG>0)

)
CREATE TABLE NHANVIEN
(
MANV INT  NOT NULL identity,
TENNV NVARCHAR(100),
GIOITINH NvarCHAR(10)  NOT NULL,
SDTNV CHAR(13),
CHUCVU NVARCHAR(50),
DIACHI NVARCHAR(256),
NGAYSINH DATE,
CONSTRAINT PK_NV PRIMARY KEY(MANV),
CONSTRAINT CHECK_NGAYSINH CHECK(YEAR(GETDATE())-YEAR(NGAYSINH)>18)
)
CREATE TABLE KHACHHANG
(
MAKH INT NOT NULL identity,
TENKH NVARCHAR(256),
SDTKH CHAR(13),
DIACHIKH NVARCHAR(256),
CONSTRAINT PK_KH PRIMARY KEY(MAKH)
)
CREATE TABLE HOADON
(
MAHD INT NOT NULL identity ,
MANV INT NOT NULL ,
MAKH INT NOT NULL ,
NGAYXUATHD DATE,
CONSTRAINT PK_HD PRIMARY KEY(MAHD)
)

CREATE TABLE CTHD
(
id int not null identity,
MAHD INT NOT NULL ,
MASP INT NOT NULL ,
SOLUONG INT,
DONGIA FLOAT,
CONSTRAINT PK_CTHD PRIMARY KEY(id)
)
ALTER TABLE SANPHAM
ADD CONSTRAINT FK_LOAI_SP FOREIGN KEY(MALOAI) REFERENCES LOAI(MALOAI)
ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_KH FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
ALTER TABLE HOADON
ADD CONSTRAINT FK_NV_HD FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
ALTER TABLE CTHD
ADD CONSTRAINT FK_CTHD_SP FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
ALTER TABLE CTHD
ADD CONSTRAINT FK_CTHD_HD FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)
ALTER TABLE HOADON
ADD THANHTIEN FLOAT;
ALTER TABLE NHANVIEN
ADD CONSTRAINT CHECK_GT CHECK(GIOITINH=N'Nam' OR GIOITINH=N'Nữ')
Alter table KHACHHANG
ADD CONSTRAINT DF_TEN DEFAULT N'KHÁCH LẺ' FOR TENKH

----------------INSERT DBO.LOAI------------

INSERT INTO DANGNHAP VALUES
('hoa032','123','hoa123@gmail.com','admin'),
('tam567','567','tam.456@gmail.com', 'admin'),
('nguyenanh.354','anh','nguyenanhy.643@gmail.com', 'user'),
('hung.536','hung','hung864@gmail.com', 'user')
GO

INSERT INTO LOAI VALUES
(N'ÁO'),
(N'QUẦN'),
(N'VÁY'),
(N'CHÂN VÁY'),
(N'JUM')
---------------INSERT DBO.SANPHAM--------------
INSERT INTO SANPHAM VALUES
(N'TEELAB TEE',45,150000,300000,'T5.jfif',N'BestSell',1),
(N'DRIVE TEE',99,170000,320000,'T3.jpg',N'THUN COTTON 4 CHIỀU CAO CẤP',1),
(N'QUẦN JEANỐNG RỘNG NỮ',60,200000,300000,'Q1.jpg',N'QUẦN JEAN NỮ TÔN CHIỀU CAO',2),
(N'QUẦN JEAN ỐNG RỘNG NAM',13,200000,300000,'Q2.jfif',N'QUẦN JEAN NAM TÔN CHIỀU CAO',2)
INSERT INTO NHANVIEN(TENNV,GIOITINH,SDTNV,CHUCVU,DIACHI)
VALUES 
(N'Nguyễn Ánh Tuyết',N'Nữ','0987644323', N'Thu ngân',N'TP.Hồ chí Minh'), 
(N'Nguyễn Thị Hoa',N'Nữ','0308676523', N'Bán hàng',N'TP.Hồ chí Minh'),
(N'Trần Ngọc Dung',N'Nữ','0974145734', N'Bán hàng',N'TP Cần Thơ'),
(N'Phạm Ngọc Hân',N'Nữ','0709575429', N'Bán hàng',N'Long An' ),
(N'Nguyễn Ánh Tuyết',N'Nữ','0987644121', N'Bán hàng',N'Bình Dương'),
(N'Lê Ánh Huyền',N'Nữ','0974685543', N'Bán hàng',N'Thái Bình'),
(N'Trần Văn Hiếu',N'Nam','0847382125', N'Thu ngân',N'Đà Nẵng'),
(N'Nguyễn Ánh Tuyết',N'Nữ','0984644321', N' Bán hàng',N'Quảng Nam')

------------------------INSERT DBO KHÁCH HÀNG---------------
INSERT INTO KHACHHANG(TENKH,SDTKH,DIACHIKH)
VALUES
(N'Trần Minh Đức','0918532272',N'TP.Hồ Chí Minh'),
(N'Mai Trung Dũng','0723268891',N'TP.Hồ Chí Minh'),
(N'Nguyễn Thị Mai','0857368237',N'Củ Chi'),
(N'Nguyễn Thị Quỳnh','0952457842',N'Bình Dương'),
(N'Lê Mạnh Hùng','0759737815',N'TP.Hồ Chí Minh'),
(N'Lê Minh Cường','0320859679',N'Đồng Nai'),
(N'Nguyễn Xuân Diệu','0839243632',N'Long Khánh'),
(N'Phạm Thị Hoa','0812647543',N'TP.Hồ Chí Minh')
select *from HOADON
select*from CTHD

-----------------------------------------------------------------------TÀI KHOẢN------------------------------------------------------------------------------

CREATE PROC DANHSACHTK
AS
SELECT *FROM DANGNHAP
GO
EXEC DANHSACHTK


CREATE PROC INSERT_TK @tendn varchar(20),@matkhau varchar(50),@quyen varchar(20)
as
insert into DANGNHAP(TENDN,MK,QUYEN) values(@tendn,@matkhau,@quyen)
go
CREATE PROC updateTK @tenDN varchar(20),@MK varchar(50),@Quyen varchar(20)
as begin
UPDATE DANGNHAP set  MK=@MK,QUYEN=@Quyen where TENDN=@tenDN
end
GO


CREATE PROC deleteTk @TENDN VARCHAR(20)
as
BEGIN 
	DELETE DANGNHAP where TENDN =@TENDN
END
GO

-----THỐNG KÊ TỒN KHO----------
CREATE FUNCTION THONGKE_TONKHO()
RETURNS TABLE
AS
RETURN(SELECT TENSP , SUM(SOLUONG) AS N'SỐ LƯỢNG TỒN KHO' from SANPHAM group by (TENSP))
GO
-------------------------------------------------------------HÓA ĐƠN----------------------------------------------------------------------------------------------------



---------------TRIGGER CẬP NHẬP LẠI CỘT THÀNH TIỀN TRONG HOA ĐƠN SAU KHI INSERT VÀ UPDATE
		create trigger TinhHoaDon on CTHD
		FOR INSERT
		AS	
		
			UPDATE HOADON
			SET THANHTIEN = THANHTIEN + (SELECT INSERTED.SOLUONG * DONGIABAN   FROM inserted,SANPHAM WHERE inserted.MASP = SANPHAM.MASP)
			where MAHD = (select MAHD FROM inserted)

			UPDATE HOADON
			SET THANHTIEN = (SELECT SUM( CTHD.SOLUONG * DONGIABAN)   FROM CTHD,SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.MAHD = (SELECT MAHD FROM inserted))
			where MAHD = (select MAHD FROM inserted)
	
---------------TRIGGER CẬP NHẬP LẠI CỘT THÀNH TIỀN TRONG HOA ĐƠN SAU KHI XÓA
		create trigger TinhHoaDon_Xoa on CTHD
		FOR delete
		AS	
			UPDATE HOADON
			SET THANHTIEN = THANHTIEN - (SELECT deleted.SOLUONG * DONGIABAN   FROM deleted,SANPHAM WHERE deleted.MASP = SANPHAM.MASP)
			where HOADON.MAHD = (select MAHD FROM deleted)


			---------------TRIGGER CẬP NHẬP LẠI CỘT THÀNH TIỀN TRONG HOA ĐƠN SAU KHI INSERT VÀ UPDATE ---- Tạm Thời chưa dùng được
		create trigger TinhHoaDon_Sua on CTHD
		FOR update
		AS	
		begin
			UPDATE HOADON
			SET THANHTIEN = THANHTIEN + (SELECT deleted.SOLUONG * DONGIABAN   FROM deleted,SANPHAM WHERE SANPHAM.MASP =  deleted.MASP ) - (SELECT INSERTED.SOLUONG * DONGIABAN   FROM inserted,SANPHAM WHERE SANPHAM.MASP= inserted.MASP  )
			from HOADON , deleted , inserted
			where HOADON.MAHD = (select MAHD FROM CTHD)
		end
			drop trigger TinhHoaDon_Xoa
SELECT * FROM HOADON
SELECT * FROM CTHD
---------------TRIGGER CẬP NHẬP LẠI CỘT ĐƠN GIÁ TRONG CHI TIẾT HÓA ĐƠN
		create trigger UPDATE_DONGIA_CTHD on CTHD
		FOR INSERT,UPDATE
		AS
			UPDATE CTHD
			SET DONGIA = (SELECT DONGIABAN   FROM SANPHAM WHERE CTHD.MASP = SANPHAM.MASP)
			where MAHD = (select MAHD FROM inserted)
			DROP TRIGGER UPDATE_DONGIA_CTHD

---------------TRIGGER CẬP NHẬP LẠI CỘT ĐƠN GIÁ TRONG CHI TIẾT HÓA ĐƠN
		create trigger UPDATE_SOLUONG_SP on CTHD
		FOR INSERT,UPDATE,DELETE
		AS
		IF UPDATE(SOLUONG)
		begin
		DECLARE  @MASP INT
			declare X CURSOR FOR SELECT SOLUONG FROM inserted		
			OPEN X
			FETCH NEXT FROM X INTO @MASP
			WHILE (@@FETCH_STATUS = 0 )
				BEGIN				
					UPDATE SANPHAM
					SET SOLUONG  = SANPHAM.SOLUONG - inserted.SOLUONG 
					FROM inserted,SANPHAM
					WHERE SANPHAM.MASP = inserted.MASP
					FETCH NEXT FROM X INTO @MASP
				END
				CLOSE X
				DEALLOCATE X
		END
			
---- thủ tục load hóa đơn
CREATE PROC LOADHD
AS
SELECT *FROM HOADON
GO
---- thủ tục thêm hóa đơn
create Proc insertHD @makh int,@manv int
AS 
BEGIN 
	INSERT INTO HOADON values (@makh,@manv,GETDATE(),0)

END
--XOA hóa đơn
CREATE PROC XOA_HD @MAHD INT
AS
BEGIN
	DELETE FROM CTHD WHERE MAHD=@MAHD
	DELETE FROM HOADON WHERE MAHD=@MAHD
END

drop PROC XOA_HD
---THỦ TỤC CẬP NHẬP HÓA ĐƠN
CREATE PROC SuaHD @MAHD INT, @MANV INT,@MAKH INT
AS
BEGIN
	 UPDATE HOADON 
	SET MANV = @MANV, MAKH = @MAKH
	WHERE  MAHD = @MAHD
END
---- thủ tục thêm chi tiết hóa đơn
create Proc insertCTHD @mahd int,@masp int, @sl int
AS 
BEGIN 
	INSERT INTO CTHD(MAHD,MASP,SOLUONG) values (@mahd,@masp,@sl)
END
--thủ tục Xóa chi tiết hóa đơn
CREATE PROC XOA_CTHD @MAHD INT,@MASP INT
AS
BEGIN
	DELETE FROM CTHD WHERE MAHD=@MAHD AND MASP = @MASP
END
DROP PROC XOA_CTHD
---THỦ TỤC CẬP NHẬP CHI TIẾT HÓA ĐƠN
CREATE PROC SuaCTHD @MAHD INT, @MASP INT,@SOLUONG INT
AS
BEGIN
	 UPDATE CTHD 
	SET MASP = @MASP, SOLUONG = @SOLUONG
	WHERE  MAHD = @MAHD
END


drop proc SuaHD
SELECT * FROM dbo.TimKiem_MaNV(2)
---HÀM  truyền vào tham số mãhóa đơn sẽ trả về THÔNG TIN hóa đơn đó.
--FUNCTION 
CREATE FUNCTION TimKiem_MaHD_FUNC (@MaHD INT)
RETURNS TABLE
AS
	RETURN (SELECT *  FROM HOADON WHERE @MaHD = MAHD )
SELECT * FROM dbo.TimKiem_MaHD_FUNC(2)

--THEM HOA DON
GO
CREATE PROC THEM_HD
@mahd int,@SDT CHAR(13),@HOTENKH NVARCHAR(50),@DIACHI NVARCHAR(256),@MANV INT, @totalPrice float
AS
BEGIN

	INSERT INTO KHACHHANG(TENKH,SDTKH,DIACHIKH)
	VALUES(@HOTENKH,@SDT,@DIACHI);

	INSERT INTO HOADON
	VALUES(@mahd,@MANV,(SELECT MAKH FROM KHACHHANG WHERE @HOTENKH=TENKH),GETDATE(),@totalPrice)

END

go


SELECT * FROM KHACHHANG
SELECT *FROM HOADON
select *from CTHD

DELETE FROM KHACHHANG WHERE MAKH=13
DELETE FROM HOADON WHERE MAHD=1

UPDATE HOADON
SET MANV=2,MAKH=5,NGAYXUATHD='2000-1-1'
WHERE MAHD=3



-----------------------------------------------------------------------SẢN PHẨM------------------------------------------------------------------------------


-----------STORED PROCEDURE------------
CREATE PROC LOADLOAISP
AS
SELECT *FROM LOAI
GO
EXEC LOADLOAISP

CREATE PROC [dbo].[InsertDataHang]  @TenHang nvarchar(50), @Soluong int, @DonGiaNhap float, @DonGiaBan float,@HinhAnh varchar(400) ,@GhiChu nvarchar(20),@maloai int
AS 
BEGIN 
	INSERT INTO SANPHAM values (@TenHang,@Soluong,@DonGiaNhap,@DonGiaBan,@HinhAnh,@GhiChu,@maloai)

END

CREATE PROC [dbo].[DanhSachHang] 
AS
BEGIN
SELECT *FROM SANPHAM
END
GO

select HINHANH from SANPHAM where MASP=2
SELECT *FROM SANPHAM


CREATE PROC [dbo].[UpdateHang] @maHang int, @tenHang nvarchar(50), @soLuong int , 
@donGiaNhap float , @donGiaBan float , @hinhAnh nvarchar(400), @ghiChu nvarchar(50),@maLoai int
as begin
UPDATE SANPHAM set TENSP = @tenHang , SOLUONG = @soLuong , DONGIANHAP = @donGiaNhap , DONGIABAN = @donGiaBan,
HINHANH = @hinhAnh , GHICHU = @ghiChu,MALOAI=@maLoai
where MASP = @maHang;
end
GO


CREATE PROC [dbo].[DeleteDataFromHang] @masp int
as
BEGIN 
	DELETE SANPHAM where MASP = @masp 
END
GO
exec DeleteDataFromHang 10
select *from SANPHAM




CREATE PROC SearchHang @tenSP nvarchar (50)
AS 
BEGIN
	SELECT * FROM SANPHAM WHERE TENSP like '%'  + @tenSP + '%'
END
EXEC SearchHang 'tEe'
------------
CREATE PROC LOADSP
AS
SELECT *FROM SANPHAM
GO
exec LOADSP


---------------TRIGGER KIỂM TRA GIÁ NHẬP VÀ GIÁ BÁN
create trigger KT_GiaNhap_GiaBan on SANPHAM
for insert
as
	if(select DONGIANHAP from inserted) > (select DONGIABAN from inserted)
		rollback tran

		drop  trigger KT_GiaNhap_GiaBan

create trigger KT_SOLUONG_SP on SANPHAM
for insert
as
	if(select SOLUONG from inserted) <0
		rollback tran



CREATE PROC GETLISTBILLALL  @nd datetime,@nc datetime
as
select *from HOADON where NGAYXUATHD>=@nd and NGAYXUATHD<=@nc
go
exec GETLISTBILLALL '2022-12-15','2022-12-21'

CREATE PROC GETLISTBILLNV  @nd datetime,@nc datetime,@manv int
as
select HOADON.MAHD,HOADON.MAKH,HOADON.MANV,HOADON.NGAYXUATHD,HOADON.THANHTIEN from HOADON where NGAYXUATHD>=@nd and NGAYXUATHD<=@nc and HOADON.MANV=@manv
go
exec GETLISTBILLNV '2022-12-15','2022-12-22',3


CREATE PROC GETLISTBILLSP  @nd datetime,@nc datetime,@masp int
as
select HOADON.MAHD,HOADON.MAKH,HOADON.MANV,HOADON.NGAYXUATHD,HOADON.THANHTIEN from HOADON,CTHD as b where NGAYXUATHD>=@nd and NGAYXUATHD<=@nc and HOADON.MAHD=b.MAHD and b.MASP=@masp
go
exec GETLISTBILLSP '2022-12-15','2022-12-22',4

CREATE PROC InsertBillInfo @idBill INT , @idsp INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = b.id, @foodCount = b.SOLUONG
	FROM dbo.CTHD b 
	WHERE  MAHD= @idBill AND MASP = @idsp

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.CTHD	SET SOLUONG = @foodCount + @count WHERE MASP = @idsp and MAHD=@idBill
		ELSE
			DELETE dbo.CTHD WHERE MAHD = @idBill AND MASP = @idsp
	END
	ELSE
	BEGIN
		INSERT	dbo.CTHD
        ( MAHD, MASP, SOLUONG)
		VALUES  ( @idBill, -- idBill - varchar
          @idsp, -- idFood - varchar
          @count  -- count - int
          )
	END
END

exec InsertBillInfo 7,3,2
select *from CTHD
select*from hoadon
select * from NHANVIEN
select *from KHACHHANG
delete from KHACHHANG where MAKH between 10 and 22




---------------------------------------------------------------------PHÂN QUYỀN----------------------------------------------------------------------------------

---Tạo người dùng có tên là QLBH_11 được quyền tạo các Table trong Database   ( quyền quản lý của admin )
CREATE LOGIN QLBH_11 WITH PASSWORD = '123';
CREATE USER QLBH_11 FROM LOGIN QLBH_11;
GRANT CREATE TABLE TO QLBH_11;
GRANT ALTER ON SCHEMA :: DBO TO QLBH_11;

--Test chức năng QLBH_11---
CREATE TABLE TEST
(
MA_TABLE NCHAR(20) NOT NULL,
TEN_TABLE NVARCHAR(20) NULL,
CONSTRAINT PK_MATABLE PRIMARY KEY(MA_TABLE)
)
DROP TABLE TEST



CREATE LOGIN QLBH_12 WITH PASSWORD = '123';
CREATE USER QLBH_12 FROM LOGIN QLBH_12;
GRANT SELECT, INSERT, DELETE, UPDATE ON DBO.KHACHHANG TO QLBH_12;


CREATE LOGIN QLBH_13 WITH PASSWORD = '123'
CREATE VIEW VIEW123 AS SELECT TENSP,SOLUONG,DONGIANHAP,DONGIABAN,HINHANH,GHICHU,MALOAI FROM DBO.SANPHAM
CREATE USER QLBH_13 FROM LOGIN QLBH_13
GRANT SELECT ON VIEW123 TO QLBH_13
GRANT INSERT,UPDATE(TENSP,SOLUONG,DONGIANHAP,DONGIABAN,HINHANH,GHICHU,MALOAI) ON VIEW123  TO QLBH_13


---------------------------------------------------------------------------TÌM KIẾM----------------------------------------------------------------------------
-- HAM truyền vào tham số mã nhân viên sẽ trả về tên nhân viên và chức vụ.
drop function TimKiem_MANV_CHUCVU

create function TimKiem_MANV_CHUCVU (@manv int)
returns table
as
return (SELECT TENNV,CHUCVU FROM  NHANVIEN
	WHERE @MANV = MANV)
select * from dbo.TimKiem_MANV_CHUCVU(1) 

------------------------------------------------------------------------------------------------------------------------------------------------------------------------
---thủ tục truyền vào tham số HỌ TÊN NHÂN VIÊN  sẽ trả về THÔNG TIN NHÂN VIÊN ĐÓ.'
drop proc TIMKIEM_TENNV

CREATE PROC TIMKIEM_TENNV @HOTEN NVARCHAR(30)
AS 
	SELECT * FROM  NHANVIEN WHERE TENNV = @HOTEN
EXEC TIMKIEM_TENNV N'Trần Ngọc Dung'
--HAM vào tham số HỌ TÊN NHÂN VIÊN  sẽ trả về THÔNG TIN NHÂN VIÊN ĐÓ.'
drop function TimKiem_HovaTen_NV
create function TimKiem_HovaTen_NV (@hoten nvarchar(30))
returns table
as
	return (SELECT *FROM  NHANVIEN WHERE @HOTEN = TENNV)
select * from dbo.TimKiem_HovaTen_NV(N'Trần Ngọc Dung') 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
---thủ tục truyền vào tham số Tên gần giống sẽ trả về THÔNG TIN những NHÂN VIÊN ĐÓ.
CREATE PROC TIMKIEM_TENNV_Like @HOTEN NVARCHAR(30)
AS 
	SELECT * FROM  NHANVIEN WHERE TENNV like '%' + @HOTEN + '%'
EXEC TIMKIEM_TENNV_Like N'hoa'
--Hàm truyền vào tham số Tên gần giống sẽ trả về THÔNG TIN những NHÂN VIÊN ĐÓ.
create function TimKiem_hoten_nv_like (@hoten nvarchar(30))
returns table
as
	return(SELECT * FROM  NHANVIEN WHERE TENNV like '%' + @HOTEN + '%')
select * from dbo.TimKiem_hoten_nv_like(N'hiếu')
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
---thủ tục truyền vào tham số Tên gần giống sẽ trả về THÔNG TIN những KHÁCH HÀNG ĐÓ.
CREATE PROC TIMKIEM_TENKH_Like @HOTEN NVARCHAR(30)
AS 
	SELECT * FROM  KHACHHANG WHERE TENKH like '%' + @HOTEN + '%'
EXEC TIMKIEM_TENKH_Like N'Đức'
-- Hàm vào tham số Tên gần giống sẽ trả về THÔNG TIN những KHÁCH HÀNG ĐÓ.
create function TimKiem_Ten_KH_like (@hoten nvarchar(30))
returns table
as
	return(SELECT * FROM  KHACHHANG WHERE TENKH like '%' + @HOTEN + '%')
select *from dbo.TimKiem_Ten_KH_like(N'Đức')
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--hàm truyền tham số sdt xuất thông tin khách hàng
create function TimKiem_SDT_KH (@sdt int)
returns table
as
	return(select * from KHACHHANG where SDTKH = @sdt)
select *from dbo.TimKiem_SDT_KH (0812647543)   
---HÀM  truyền vào tham số mã nhân viên sẽ thống kê số hóa đơn mà khách hàng đó có.
CREATE FUNCTION ThongKeHoaDon_KH (@MAKH INT)
RETURNS INT
AS
BEGIN
	DECLARE @SLHD INT
	SET @SLHD =  (SELECT COUNT(KHACHHANG.MAKH) AS N' SỐ LƯỢNG HÓA ĐƠN'  FROM KHACHHANG,HOADON WHERE @MAKH = KHACHHANG.MAKH AND HOADON.MAKH = KHACHHANG.MAKH )
	RETURN @SLHD
END

DECLARE @SLHD INT
SET @SLHD = dbo.ThongKeHoaDon_KH(3)
PRINT @SLHD
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--thủ tụctính tổng số lượng mà hóa đơn đó bán được
create proc Tong_SL_sanpham @masp int
as
begin
	select @masp, sum(CTHD.SOLUONG) as 'Tổng số lượng đã bán'
	from CTHD, SANPHAM
	where CTHD.MASP = SANPHAM.MASP and CTHD.MASP = @masp
	group by SANPHAM.MASP
end
exec Tong_SL_sanpham 2

--hàm tính số lượng hiện tại trong và số lượng đã bán 
create function Tong_SL_Ban (@masp int)
returns int
as 
begin
	declare @soluongban int
	select @soluongban = sum(CTHD.SOLUONG)
	from CTHD, SANPHAM
	where CTHD.MASP = SANPHAM.MASP and CTHD.MASP = @masp
	group by SANPHAM.MASP
	return @soluongban
end

select distinct CTHD.MASP, SANPHAM.SOLUONG, dbo.Tong_SL_Ban(1) 'Số lượng đã bán',
SANPHAM.SOLUONG- dbo.Tong_SL_Ban(1) 'Só lượng hiện có'
from CTHD, SANPHAM
where CTHD.MASP = 1 and SANPHAM.MASP = CTHD.MASP



--------------------------------------------------------KHÁCH HÀNG-------------------------------------------------------------------------------- 
CREATE PROC XOA_KH @MAKH INT
AS
BEGIN
	DELETE FROM KHACHHANG WHERE MAKH=@MAKH
END
EXEC XOA_KH 10


create proc them_kh @ten_KH nvarchar(30), @SDT CHAR(13), @DIACHIKH nvarchar(256)
as
	insert INTO KHACHHANG ( TENKH, SDTKH, DIACHIKH)
	values(@ten_KH, @SDT, @DIACHIKH)

CREATE PROC Suakh  @maKH int, @ten_KH nvarchar(30), @SDT CHAR(13), @DIACHIKH nvarchar(256)
AS
BEGIN
	 UPDATE KHACHHANG 
	SET  TENKH = @ten_KH,SDTKH = @SDT , DIACHIKH = @DIACHIKH
	WHERE  MAKH = @maKH
END

CREATE PROC CHECK_KH
@SDT CHAR(10), @SDT_CAPNHAT CHAR(10) OUT,@TENKH NVARCHAR(30) OUT,@DIACHI NVARCHAR(100) OUT
AS
BEGIN
	SET @SDT = (SELECT SDTKH FROM KHACHHANG WHERE SDTKH=@SDT)
END




-- ràng buộc số điện thoại khách hàng phải phân biệt
ALTER TABLE khachhang 
ADD CONSTRAINT unique_sdtkh unique (SDTKH)


-------ĐẾM SỐ LƯỢNG KHÁCH HÀNG ĐẾN MUA BAO NHIÊU LẦN
CREATE FUNCTION TIM_KH(@sdt char(13))
RETURNS TABLE
AS
RETURN (SELECT MAKH ,COUNT(MAKH) AS N'SỐ LẦN MUA' 
        FROM KHACHHANG
		WHERE SDTKH=@sdt
		group by MAKH)
GO



----------------------------------------------------------------NHÂN VIÊN--------------------------------------------------------------------------------
CREATE PROC XOA_NV @MANV INT
AS
BEGIN
	DELETE FROM NHANVIEN WHERE MANV =  @MANV
END
CREATE PROC SuaNV  @manv int, @ten_nv nvarchar(30), @gioitinh nvarchar(10), @sdt_nv char(13), @chucvu nvarchar(50), @diachi nvarchar(256)
AS
BEGIN
	 UPDATE NHANVIEN 
	SET  TENNV = @ten_nv,GIOITINH = @gioitinh , SDTNV = @sdt_nv , CHUCVU = @chucvu , DIACHI = @diachi
	WHERE  MANV = @manv
END

--thủ tục them nhan vien mơi 
create proc them_nv @ten_nv nvarchar(30), @gioitinh nvarchar(10), @sdt_nv char(13), @chucvu nvarchar(50), @diachi nvarchar(256)
as
	insert NHANVIEN (TENNV,GIOITINH,SDTNV,CHUCVU,DIACHI)
	values(@ten_nv, @gioitinh, @sdt_nv, @chucvu, @diachi)
exec them_nv N'Võ Thành Đạt', N'Nữ', '0987654321', N'Bảo vệ', N'Nha Trang','03/01/2002'
select * from NHANVIEN
DROP proc them_nv

create proc loadNV
as
select *from NHANVIEN
go

exec loadNV


--- check giới tính nhân viên
alter table nhanvien
add constraint chk_Gtinh_nhanvien check(GIOITINH =N'Nam' or GIOITINH =N'Nữ')

-- ràng buộc số điện thoại nhân viên phải phân biệt
ALTER TABLE nhanvien 
ADD CONSTRAINT unique_sdtnv unique (SDTNV)