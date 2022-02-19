create database SCADAMasanHD
Go

use SCADAMasanHD
go

create table Account
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(200),
	Username nvarchar(200),
	Pass nvarchar(200),
	Email nvarchar(200),
	Phone nvarchar(200)
)
go
insert into Account(DisplayName, UserName, Pass) values(N'Doan Ngoc Minh', N'admin', N'admin')
go

create table TruongCa
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(200),
)
go
insert into TruongCa(DisplayName) values(N'Doan Ngoc Minh')
insert into TruongCa(DisplayName) values(N'Le Van Cong')
insert into TruongCa(DisplayName) values(N'Vu Van Hoan')
insert into TruongCa(DisplayName) values(N'Nguyen Van Linh')
go

create table SanPham
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(500),
)
go
insert into SanPham(DisplayName) values(N'Mì hảo hảo')
insert into SanPham(DisplayName) values(N'Bột canh')
insert into SanPham(DisplayName) values(N'Súp')
insert into SanPham(DisplayName) values(N'Nước tương')
go

create table CaiDatCaSanXuat
(	
	Id int identity(1,1) primary key,
	TruongCa1 nvarchar(200),
	TruongCa2 nvarchar(200),
	TruongCa3 nvarchar(200),
	HourCa1 int,
	MinuteCa1 int,
	HourCa2 int,
	MinuteCa2 int,
	HourCa3 int,
	MinuteCa3 int
)
go
insert into CaiDatCaSanXuat(TruongCa1, TruongCa2, TruongCa3, HourCa1, MinuteCa1, HourCa2, MinuteCa2, HourCa3, MinuteCa3) values('Doan Ngoc Minh','Le Van Cong', 'Vu Van Hoan', 8,12,13,17,18,22)
go

create table ThongSo
(
	Id int identity(1,1) primary key,
	DayChuyenSo int,
	MaySo int, 
	SanPham nvarchar(500),
	CaSanXuat int,
	TocDoChuan int,
	TimeDungMay int,
	TimeChapNhanGoi int,
	TimeTinhGoiCan int,
	TimeDayGoiCan int,
	TimeUpdatePLC int,
	TimeXilanhDayGoi int
)
go
insert into ThongSo(TocDoChuan, TimeDungMay, TimeChapNhanGoi, TimeTinhGoiCan, TimeDayGoiCan, TimeUpdatePLC, TimeXilanhDayGoi) values(120,50,2,5,7,70,10)
go

create table Report
(
	Id int identity(1,1) primary key,
	NgaySanXuat datetime,
	SanPham	nvarchar(500),
	CaSanXuat int,
	DayChuyen int,
	MaySo int,
	TongSoGoi int,
	SoGoiCan int,
	SoGoiRong int
)
go
insert into Report values('2022-01-03 14:44:56.240',N'Bột canh', 1,3,2,1200,20,10)
go

--Create random datatime datatype v1
DECLARE @FromDate DATETIME2(0)
DECLARE @ToDate   DATETIME2(0)

SET @FromDate = '2021-07-01 08:00:00' 
SET @ToDate = '2022-01-10 17:30:00'

DECLARE @Seconds INT = DATEDIFF(SECOND, @FromDate, @ToDate)
DECLARE @Random INT = ROUND(((@Seconds-1) * RAND()), 0)
----

insert into Report values(DATEADD(SECOND, @Random, @FromDate),N'Bột canh', FLOOR(RAND(CHECKSUM(NEWID()))*(3-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(8-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(4-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(5000-1000+1)+1000),
FLOOR(RAND(CHECKSUM(NEWID()))*(50-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(30-1+1)+1))
go


--Create random datatime datatype v2 
DECLARE @FromDate DATETIME2(0)
DECLARE @ToDate   DATETIME2(0)

SET @FromDate = '2021-07-01 08:00:00' 
SET @ToDate = '2022-01-10 17:30:00'

DECLARE @Seconds INT = DATEDIFF(SECOND, @FromDate, @ToDate)
DECLARE @Random INT = ROUND(((@Seconds-1) * RAND()), 0)
----

insert into Report values(DATEADD(SECOND, @Random, @FromDate),
choose(CAST(RAND() * 3 + 1 AS INT), N'Bột canh',N'Súp',N'Nước gạo'), 
FLOOR(RAND(CHECKSUM(NEWID()))*(3-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(8-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(4-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(5000-1000+1)+1000),
FLOOR(RAND(CHECKSUM(NEWID()))*(50-1+1)+1),
FLOOR(RAND(CHECKSUM(NEWID()))*(30-1+1)+1))
go

-- Xoa nhung hang bi null
DELETE FROM [dbo].[Report]
      WHERE [SanPham] IS NULL
GO
