USE [Quanlythuvien]
GO
/****** Object:  Role [nguoimuon]    Script Date: 07/01/2016 22:15:47 ******/
CREATE ROLE [nguoimuon] AUTHORIZATION [dbo]
GO
/****** Object:  Role [nhanvien]    Script Date: 07/01/2016 22:15:47 ******/
CREATE ROLE [nhanvien] AUTHORIZATION [dbo]
GO
/****** Object:  User [1]    Script Date: 07/01/2016 22:15:47 ******/
CREATE USER [1] FOR LOGIN [gv1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ql]    Script Date: 07/01/2016 22:15:47 ******/
CREATE USER [ql] FOR LOGIN [ql] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sv]    Script Date: 07/01/2016 22:15:47 ******/
CREATE USER [sv] FOR LOGIN [sv] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 07/01/2016 22:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [int] IDENTITY(1,1) NOT NULL,
	[honv] [varchar](50) NULL,
	[tennv] [varchar](12) NULL,
	[gioitinh] [bit] NULL,
	[diachi] [varchar](100) NULL,
	[dienthoai] [varchar](11) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[nhanvien] ON
INSERT [dbo].[nhanvien] ([manv], [honv], [tennv], [gioitinh], [diachi], [dienthoai], [email]) VALUES (1, N'NGUYEN', N'THI DAN', 0, N'TPHCM', N'0987777777', N'DAN@.COM')
INSERT [dbo].[nhanvien] ([manv], [honv], [tennv], [gioitinh], [diachi], [dienthoai], [email]) VALUES (2, N'NGUYEN', N'TRAN LE ANH', 0, N'BINH THUAN', N'0988878998', N'ANH@.COM')
INSERT [dbo].[nhanvien] ([manv], [honv], [tennv], [gioitinh], [diachi], [dienthoai], [email]) VALUES (3, N'TRAN', N'ANH THE', 1, N'TPHCM', N'0914853756', N'THE@.COM')
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
/****** Object:  Table [dbo].[isbn]    Script Date: 07/01/2016 22:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[isbn](
	[masach] [char](10) NOT NULL,
	[tensach] [varchar](100) NULL,
	[khosach] [varchar](5) NULL,
	[sotrang] [int] NULL,
	[gia] [bigint] NULL,
	[ngonngu] [varchar](50) NULL,
	[theloai] [varchar](50) NULL,
	[tacgia] [varchar](50) NULL,
	[tinhtrang] [bit] NULL,
	[chomuon] [bit] NULL,
 CONSTRAINT [PK_isbn] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[docgia]    Script Date: 07/01/2016 22:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[docgia](
	[madg] [bigint] NOT NULL,
	[hodg] [varchar](50) NULL,
	[tendg] [varchar](12) NULL,
	[emaildg] [nchar](50) NULL,
	[socmnd] [varchar](12) NULL,
	[gioitinh] [bit] NULL,
	[ngaysinh] [smalldatetime] NULL,
	[diachi] [varchar](50) NULL,
	[dienthoai] [varchar](11) NULL,
	[ngaylamthe] [smalldatetime] NULL,
	[ngayhethan] [smalldatetime] NULL,
	[hoatdong] [bit] NULL,
 CONSTRAINT [PK_docgia] PRIMARY KEY CLUSTERED 
(
	[madg] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[docgia] ([madg], [hodg], [tendg], [emaildg], [socmnd], [gioitinh], [ngaysinh], [diachi], [dienthoai], [ngaylamthe], [ngayhethan], [hoatdong]) VALUES (1, N'NGUYEN', N'VAN A', N'A@.COM                                            ', N'272296574', 1, CAST(0x878A0000 AS SmallDateTime), N'TP.HCM', N'0999999999', CAST(0xA6180000 AS SmallDateTime), CAST(0xABCD0000 AS SmallDateTime), 1)
INSERT [dbo].[docgia] ([madg], [hodg], [tendg], [emaildg], [socmnd], [gioitinh], [ngaysinh], [diachi], [dienthoai], [ngaylamthe], [ngayhethan], [hoatdong]) VALUES (2, N'NGUYEN', N'VAN B', N'B@.COM                                            ', N'272296575', 1, CAST(0x87A90000 AS SmallDateTime), N'TP.HCM', N'0988888888', CAST(0xA6180000 AS SmallDateTime), CAST(0xABCD0000 AS SmallDateTime), 1)
INSERT [dbo].[docgia] ([madg], [hodg], [tendg], [emaildg], [socmnd], [gioitinh], [ngaysinh], [diachi], [dienthoai], [ngaylamthe], [ngayhethan], [hoatdong]) VALUES (3, N'NGUYEN', N'THI C', N'C@.COM                                            ', N'272296756', 0, CAST(0x86580000 AS SmallDateTime), N'LONG AN', N'0977777777', CAST(0x9FCB0000 AS SmallDateTime), CAST(0xA6180000 AS SmallDateTime), 0)
INSERT [dbo].[docgia] ([madg], [hodg], [tendg], [emaildg], [socmnd], [gioitinh], [ngaysinh], [diachi], [dienthoai], [ngaylamthe], [ngayhethan], [hoatdong]) VALUES (4, N'TRAN', N'THI A', N'D@.COM                                            ', N'463748941', 0, CAST(0x80680000 AS SmallDateTime), N'DONG NAI', N'0913458764', CAST(0xA1D00000 AS SmallDateTime), CAST(0xA7850000 AS SmallDateTime), 1)
INSERT [dbo].[docgia] ([madg], [hodg], [tendg], [emaildg], [socmnd], [gioitinh], [ngaysinh], [diachi], [dienthoai], [ngaylamthe], [ngayhethan], [hoatdong]) VALUES (5, N'NGUYEN', N'THI F', N'C@.COM                                            ', N'272296756', 1, CAST(0x86580000 AS SmallDateTime), N'TAY NINH', N'0977777779', CAST(0x9FCB0000 AS SmallDateTime), CAST(0xA6180000 AS SmallDateTime), 0)
/****** Object:  StoredProcedure [dbo].[TAO_LOGIN]    Script Date: 07/01/2016 22:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TAO_LOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USRNAME VARCHAR(50),
 @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'quanlythuvien'
   IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USRNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END

IF (@ROLE ='nhanvien')
BEGIN
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addsrvrolemember @LGNAME, 'DBCreator'
  EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  EXEC sp_addrolemember 'nhanvien', @USRNAME
END
GO
/****** Object:  Table [dbo].[sach]    Script Date: 07/01/2016 22:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sach](
	[masach] [char](10) NOT NULL,
	[tensach] [varchar](50) NULL,
	[khosach] [varchar](5) NULL,
	[sotrang] [int] NULL,
	[gia] [bigint] NULL,
	[ngonngu] [varchar](50) NULL,
	[theloai] [varchar](50) NULL,
	[tinhtrang] [bit] NULL,
	[chomuon] [bit] NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[sach] ([masach], [tensach], [khosach], [sotrang], [gia], [ngonngu], [theloai], [tinhtrang], [chomuon]) VALUES (N'AT        ', N'an toan', N'a3', 30, 40000, N'tieng viet', N'cong nghe', 1, 1)
INSERT [dbo].[sach] ([masach], [tensach], [khosach], [sotrang], [gia], [ngonngu], [theloai], [tinhtrang], [chomuon]) VALUES (N'CNTT      ', N'Cong Nghe Thong Tin', N'a4', 100, 50000, N'Tieng Viet', N'Khoa Hoc', 1, 1)
INSERT [dbo].[sach] ([masach], [tensach], [khosach], [sotrang], [gia], [ngonngu], [theloai], [tinhtrang], [chomuon]) VALUES (N'DT        ', N'Dien Tu', N'a3', 50, 70000, N'Tieng Anh', N'Ky Thuat', 1, 1)
INSERT [dbo].[sach] ([masach], [tensach], [khosach], [sotrang], [gia], [ngonngu], [theloai], [tinhtrang], [chomuon]) VALUES (N'KT        ', N'Ke Toan', N'a4', 100, 50000, N'Tieng Viet', N'Khoa Hoc', 1, 0)
INSERT [dbo].[sach] ([masach], [tensach], [khosach], [sotrang], [gia], [ngonngu], [theloai], [tinhtrang], [chomuon]) VALUES (N'QT        ', N'Quan Tri', N'a4', 100, 60000, N'Tieng Anh', N'Kinh Doanh', 1, 1)
INSERT [dbo].[sach] ([masach], [tensach], [khosach], [sotrang], [gia], [ngonngu], [theloai], [tinhtrang], [chomuon]) VALUES (N'VT        ', N'Vien Thong', N'a4', 60, 55000, N'Tieng Viet', N'Ky Thuat', 1, 1)
/****** Object:  Table [dbo].[phieumuon]    Script Date: 07/01/2016 22:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieumuon](
	[maphieu] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[madg] [bigint] NULL,
	[hinhthuc] [bit] NULL,
	[ngaymuon] [smalldatetime] NULL,
	[manv] [int] NULL,
 CONSTRAINT [PK_phieumuon] PRIMARY KEY CLUSTERED 
(
	[maphieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[phieumuon] ON
INSERT [dbo].[phieumuon] ([maphieu], [madg], [hinhthuc], [ngaymuon], [manv]) VALUES (2, 2, 0, CAST(0xA6070000 AS SmallDateTime), 3)
INSERT [dbo].[phieumuon] ([maphieu], [madg], [hinhthuc], [ngaymuon], [manv]) VALUES (19, 3, 0, CAST(0xA61A0000 AS SmallDateTime), 2)
INSERT [dbo].[phieumuon] ([maphieu], [madg], [hinhthuc], [ngaymuon], [manv]) VALUES (22, 5, 0, CAST(0xA5DD0000 AS SmallDateTime), 2)
INSERT [dbo].[phieumuon] ([maphieu], [madg], [hinhthuc], [ngaymuon], [manv]) VALUES (23, 5, 0, CAST(0xA6330000 AS SmallDateTime), 2)
SET IDENTITY_INSERT [dbo].[phieumuon] OFF
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 07/01/2016 22:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER VARCHAR (50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 SELECT USERNAME = @TENUSER, 
   HOTEN = (SELECT honv + ' '+ tennv FROM Quanlythuvien.dbo.nhanvien WHERE MANV = @TENUSER),
   ROLENAME=NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER)
               )
GO
/****** Object:  Table [dbo].[ctphieumuon]    Script Date: 07/01/2016 22:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ctphieumuon](
	[maphieu] [bigint] NOT NULL,
	[masach] [char](10) NOT NULL,
	[tinhtrang] [bit] NULL,
 CONSTRAINT [PK_ctphieumuon] PRIMARY KEY CLUSTERED 
(
	[maphieu] ASC,
	[masach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ctphieumuon] ([maphieu], [masach], [tinhtrang]) VALUES (2, N'AT        ', 1)
INSERT [dbo].[ctphieumuon] ([maphieu], [masach], [tinhtrang]) VALUES (2, N'QT        ', 1)
INSERT [dbo].[ctphieumuon] ([maphieu], [masach], [tinhtrang]) VALUES (2, N'VT        ', 1)
INSERT [dbo].[ctphieumuon] ([maphieu], [masach], [tinhtrang]) VALUES (19, N'CNTT      ', 1)
INSERT [dbo].[ctphieumuon] ([maphieu], [masach], [tinhtrang]) VALUES (23, N'DT        ', 1)
/****** Object:  StoredProcedure [dbo].[sp_thongkesachquahan]    Script Date: 07/01/2016 22:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_thongkesachquahan]
as
select maphieu, madg,masach,ngaymuon 
from
     (select phieumuon.maphieu, phieumuon.madg,ctphieumuon.masach,ngaymuon 
	 from Quanlythuvien.dbo.phieumuon  
		  inner join Quanlythuvien.dbo.ctphieumuon 
		  on phieumuon.maphieu=ctphieumuon.maphieu)as thongke
		  where DATEDIFF(DAY,ngaymuon,GETDATE())>30
GO
/****** Object:  ForeignKey [FK_ctphieumuon_phieumuon]    Script Date: 07/01/2016 22:15:47 ******/
ALTER TABLE [dbo].[ctphieumuon]  WITH CHECK ADD  CONSTRAINT [FK_ctphieumuon_phieumuon] FOREIGN KEY([maphieu])
REFERENCES [dbo].[phieumuon] ([maphieu])
GO
ALTER TABLE [dbo].[ctphieumuon] CHECK CONSTRAINT [FK_ctphieumuon_phieumuon]
GO
/****** Object:  ForeignKey [FK_ctphieumuon_sach]    Script Date: 07/01/2016 22:15:47 ******/
ALTER TABLE [dbo].[ctphieumuon]  WITH CHECK ADD  CONSTRAINT [FK_ctphieumuon_sach] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
GO
ALTER TABLE [dbo].[ctphieumuon] CHECK CONSTRAINT [FK_ctphieumuon_sach]
GO
/****** Object:  ForeignKey [FK_phieumuon_docgia]    Script Date: 07/01/2016 22:15:47 ******/
ALTER TABLE [dbo].[phieumuon]  WITH CHECK ADD  CONSTRAINT [FK_phieumuon_docgia] FOREIGN KEY([madg])
REFERENCES [dbo].[docgia] ([madg])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [FK_phieumuon_docgia]
GO
/****** Object:  ForeignKey [FK_phieumuon_nhanvien]    Script Date: 07/01/2016 22:15:47 ******/
ALTER TABLE [dbo].[phieumuon]  WITH CHECK ADD  CONSTRAINT [FK_phieumuon_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [FK_phieumuon_nhanvien]
GO
