﻿IF DB_ID('QUANLYKHACHSAN') IS NOT NULL
BEGIN
	USE master;
	DROP DATABASE [QUANLYKHACHSAN]
END
CREATE DATABASE [QUANLYKHACHSAN]
GO
USE [QUANLYKHACHSAN]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[USERNAME] [varchar](20) NOT NULL,
	[PASS] [varchar](20) NOT NULL,
	[EMPLOYEE_ID] [varchar](20) NULL,
 CONSTRAINT [PK_ACCOUNT_USERNAME] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[EMPLOYEE_ID] [varchar](20) NOT NULL,
	[EMPLOYEE_NAME] [nvarchar](50) NULL,
	[ADDRESS] [nvarchar](50) NULL,
	[PHONE] [nvarchar](50) NULL,
	[ROLE] [int] NULL,
 CONSTRAINT [PK_EMPLOYEE_EMPLOYEE_ID] PRIMARY KEY CLUSTERED 
(
	[EMPLOYEE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BILL](
	[BILL_ID] [varchar](20) NOT NULL,
	[ROOM_ID] [varchar](20) NULL,
	[CUSTOMER_ID] [varchar](20) NULL,
	[DATE_NUMBERS] [int] NULL,
	[TOTALBILL] [float] NULL,
 CONSTRAINT [PK_BILL_BILL_ID] PRIMARY KEY CLUSTERED 
(
	[BILL_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL_INFO](
	[BILL_INFO_ID] [varchar](20) NOT NULL,
	[BILL_ID] [varchar](20) NOT NULL,
	[ROOM_ID] [varchar](20) NULL,
	[CUSTOMER_ID] [varchar](20) NULL,
	[CUSTOMER_NAME] [nvarchar](50) NULL,
	[ADDRESS] [nvarchar](50) NULL,
	[VALUE_PRICE] [float] NULL,
	[PRICE] [float] NULL,
	[PAY_DAY] [datetime] NULL,
	[MONEY] [float] NULL,
 CONSTRAINT [PK_BILL_INFO_BILL_INFO_ID_BILL_ID] PRIMARY KEY CLUSTERED 
(
	[BILL_INFO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[CUSTOMER_ID] [varchar](20) NOT NULL,
	[CUSTOMER_NAME] [nvarchar](50) NULL,
	[TYPE_CUSTOMER] [nvarchar](50) NULL,
	[ID_CARD] [int] NULL,
	[ADDRESS] [nvarchar](50) NULL,
 CONSTRAINT [PK_CUSTOMER_CUSTOMER_ID] PRIMARY KEY CLUSTERED 
(
	[CUSTOMER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROOM](
	[ROOM_ID] [varchar](20) NOT NULL,
	[ROOM_NAME] [nvarchar](50) NULL,
	[ROOM_TYPE] [nvarchar](50) NULL,
	[PRICE] [float] NULL,
	[STATUS] [nvarchar](50) NULL,
	[NOTE] [nvarchar](50) NULL,
	[CUSTOMER_NUMBERS] [int] NULL,
 CONSTRAINT [PK_ROOM_ROOM_ID] PRIMARY KEY CLUSTERED 
(
	[ROOM_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RENT_BILL](
	[RENT_ID] [varchar](20) NOT NULL,
	[ROOM_ID] [varchar](20) NULL,
	[START_DATE] [datetime] NULL,
	[CUSTOMER_NAME] [nvarchar](50) NULL,
	[CUSTOMER_ID] [varchar](20) NULL,
 CONSTRAINT [PK_RENT_BILL_RENT_ID] PRIMARY KEY CLUSTERED 
(
	[RENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'baminh', N'123456', N'NV04')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'thientin', N'123456', N'NV11')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'duchuy', N'123456', N'NV07')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'hoa', N'1', N'NV12')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'nhatrang', N'123456', N'NV06')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'nhuquynh', N'123456', N'NV10')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'quanghuy', N'123456', N'NV08')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'quockhanh', N'123456', N'NV09')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'thuyuyen', N'123456', N'NV02')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'tuandat', N'123456', N'NV03')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'tuankhang', N'123456', N'NV05')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASS], [EMPLOYEE_ID]) VALUES (N'tuyetnhi', N'123456', N'NV01')
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV01', N'Tuyết Nhi', N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV02', N'Thúy Uyên', N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV03', N'Tuấn Đạt',  N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV04', N'Bá Minh',  N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV05', N'Tuấn Khang', N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV06', N'Nha Trang',  N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV07', N'Đức Huy', N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 0)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV08', N'Quang Huy', N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV09', N'Quốc Khánh', N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV10', N'Như Quỳnh Như', N'227 Nguyễn Văn Cừ, quận 5', N'0123456789', 1)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV11', N'Võ Thiện Tín', N'Hà Tĩnh', N'0358235510', 0)
INSERT [dbo].[EMPLOYEE] ([EMPLOYEE_ID], [EMPLOYEE_NAME], [ADDRESS], [PHONE], [ROLE]) VALUES (N'NV12', N'Bùi Thu Hoà Hạnh', N'Hà Nội', N'123456789', 1)
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B001', N'P100', N'ND001',3, 450000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B002', N'P101', N'ND002',5, 750000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B003', N'P102', N'ND003',2, 300000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B004', N'P103', N'ND004',1, 150000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B005', N'P104', N'NN001',1, 170000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B006', N'P105', N'NN002',2, 340000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B007', N'P106', N'NN003',4, 680000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B008', N'P107', N'NN004',1, 170000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B009', N'P108', N'NN005',2, 400000 )
INSERT [dbo].[BILL] ([BILL_ID], [ROOM_ID], [CUSTOMER_ID], [DATE_NUMBERS], [TOTALBILL]) VALUES (N'B010', N'P109', N'ND005',3, 600000 )
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'ND001', N'Minh Tuyền', N'Nội địa',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'ND002', N'Thúy Uyên', N'Nội địa',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'ND003', N'Thảo Nhi', N'Nội địa',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'ND004', N'Khắc Thuận', N'Nội địa',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'ND005', N'Vũ Khanh', N'Nội địa',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'NN001', N'Thu Tuyền', N'Nước ngoài',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'NN002', N'Hà Huỳnh', N'Nước ngoài',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'NN003', N'Thảo Quyên', N'Nước ngoài',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'NN004', N'Oanh Oanh', N'Nước ngoài',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[CUSTOMER]([CUSTOMER_ID], [CUSTOMER_NAME], [TYPE_CUSTOMER], [ID_CARD], [ADDRESS]) VALUES (N'NN005', N'Nhựt Tường', N'Nước ngoài',123456789,N'227 Nguyễn Văn Cừ, quận 5')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R001',N'P100',CAST(N'2019-11-26T00:00:00.000' AS DateTime), N'Tuyết Nhi', N'ND001')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R002',N'P101',CAST(N'2019-11-20T00:00:00.000' AS DateTime), N'Thúy Uyên', N'ND002')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R003',N'P102',CAST(N'2019-11-01T00:00:00.000' AS DateTime), N'Tuấn Đạt', N'ND003')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R004',N'P103',CAST(N'2019-12-26T00:00:00.000' AS DateTime), N'Bá Minh', N'ND004')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R005',N'P104',CAST(N'2019-11-11T00:00:00.000' AS DateTime), N'Tuấn Khang', N'ND005')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R006',N'P105',CAST(N'2019-11-16T00:00:00.000' AS DateTime), N'Nha Trang', N'NN001')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R007',N'P106',CAST(N'2019-11-10T00:00:00.000' AS DateTime), N'Đức Huy', N'NN002')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R008',N'P107',CAST(N'2019-11-06T00:00:00.000' AS DateTime), N'Quang Huy', N'NN003')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R009',N'P108',CAST(N'2019-11-19T00:00:00.000' AS DateTime), N'Quốc Khánh', N'NN004')
INSERT [dbo].[RENT_BILL]([RENT_ID], [ROOM_ID], [START_DATE], [CUSTOMER_NAME], [CUSTOMER_ID]) VALUES (N'R010',N'P109',CAST(N'2019-11-29T00:00:00.000' AS DateTime), N'Thiện Tín', N'NN005')
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P100', N'Phòng 1', N'A', 150000, N'Trống',N'', 0)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P101', N'Phòng 2', N'A', 150000, N'Trống',N'', 0)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P102', N'Phòng 3', N'A', 150000, N'Có Khách',N'', 2)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P103', N'Phòng 4', N'A', 150000, N'Có Khách',N'', 1)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P104', N'Phòng 5', N'B', 170000, N'Trống',N'', 0)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P105', N'Phòng 6', N'B', 170000, N'Có Khách',N'', 3)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P106', N'Phòng 7', N'B', 170000, N'Có Khách',N'', 1)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P107', N'Phòng 8', N'B', 170000, N'Trống',N'', 0)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P108', N'Phòng 9', N'C', 200000, N'Trống',N'', 0)
INSERT [dbo].[ROOM]( [ROOM_ID], [ROOM_NAME], [ROOM_TYPE], [PRICE], [STATUS], [NOTE], [CUSTOMER_NUMBERS]) VALUES (N'P109', N'Phòng 10', N'C', 200000, N'Trống',N'', 0)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI001',N'B001',N'P100',N'ND001',N'Tuyết Nhi', N'227 Nguyễn Văn Cừ, quận 5',150000,150000,CAST(N'2019-11-27T00:00:00.000' AS DateTime), 150000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI002',N'B002',N'P101',N'ND002',N'Thuý Uyên', N'227 Nguyễn Văn Cừ, quận 5',300000,150000,CAST(N'2019-11-23T00:00:00.000' AS DateTime), 300000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI003',N'B003',N'P102',N'ND003',N'Tuấn Đạt', N'227 Nguyễn Văn Cừ, quận 5',600000,150000,CAST(N'2019-11-03T00:00:00.000' AS DateTime), 600000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI004',N'B004',N'P103',N'ND004',N'Bá Minh', N'227 Nguyễn Văn Cừ, quận 5',300000,150000,CAST(N'2019-12-28T00:00:00.000' AS DateTime), 300000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI005',N'B005',N'P104',N'ND005',N'Tuấn Khang', N'227 Nguyễn Văn Cừ, quận 5',150000,150000,CAST(N'2019-12-27T00:00:00.000' AS DateTime), 150000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI006',N'B006',N'P105',N'NN001',N'Nha Trang', N'227 Nguyễn Văn Cừ, quận 5',170000,170000,CAST(N'2019-11-17T00:00:00.000' AS DateTime), 170000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI007',N'B007',N'P106',N'NN002',N'Đức Huy', N'227 Nguyễn Văn Cừ, quận 5',340000,340000,CAST(N'2019-11-12T00:00:00.000' AS DateTime), 340000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI008',N'B008',N'P107',N'NN003',N'Quang Huy', N'227 Nguyễn Văn Cừ, quận 5',510000,170000,CAST(N'2019-11-09T00:00:00.000' AS DateTime), 510000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI009',N'B009',N'P108',N'NN004',N'Quốc Khánh', N'227 Nguyễn Văn Cừ, quận 5',170000,170000,CAST(N'2019-11-20T00:00:00.000' AS DateTime), 170000)
INSERT [dbo].[BILL_INFO] ([BILL_INFO_ID], [BILL_ID], [ROOM_ID], [CUSTOMER_ID], [CUSTOMER_NAME],	[ADDRESS],	[VALUE_PRICE],	[PRICE], [PAY_DAY],	[MONEY]) VALUES (N'BI010',N'B010',N'P109',N'NN005',N'Thiện Tín', N'227 Nguyễn Văn Cừ, quận 5',140000,170000,CAST(N'2019-11-30T00:00:00.000' AS DateTime), 170000)


ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD
CONSTRAINT FK_ACCOUNT_EMPLOYEE FOREIGN KEY([EMPLOYEE_ID])
REFERENCES [dbo].[EMPLOYEE] ([EMPLOYEE_ID])
GO

ALTER TABLE [dbo].[RENT_BILL]  WITH CHECK ADD 
CONSTRAINT FK_RENT_BILL_ROOM FOREIGN KEY([ROOM_ID])
REFERENCES [dbo].[ROOM] ([ROOM_ID])
GO
ALTER TABLE [dbo].[RENT_BILL]  WITH CHECK ADD
CONSTRAINT FK_RENT_BILL_CUSTOMER FOREIGN KEY([CUSTOMER_ID])
REFERENCES [dbo].[CUSTOMER] ([CUSTOMER_ID])
GO

ALTER TABLE [dbo].[BILL]  WITH CHECK ADD
CONSTRAINT FK_BILL_ROOM FOREIGN KEY([ROOM_ID])
REFERENCES [dbo].[ROOM] ([ROOM_ID])
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD
CONSTRAINT FK_BILL_CUSTOMER FOREIGN KEY([CUSTOMER_ID])
REFERENCES [dbo].[CUSTOMER] ([CUSTOMER_ID])
GO

ALTER TABLE [dbo].[BILL_INFO]  WITH CHECK ADD
CONSTRAINT FK_BILL_INFO_BILL FOREIGN KEY([BILL_ID])
REFERENCES [dbo].[BILL] ([BILL_ID])
GO
ALTER TABLE [dbo].[BILL_INFO]  WITH CHECK ADD
CONSTRAINT FK_BILL_INFO_ROOM FOREIGN KEY([ROOM_ID])
REFERENCES [dbo].[ROOM] ([ROOM_ID])
GO
ALTER TABLE [dbo].[BILL_INFO]  WITH CHECK ADD
CONSTRAINT FK_BILL_INFO_CUSTOMER FOREIGN KEY([CUSTOMER_ID])
REFERENCES [dbo].[CUSTOMER] ([CUSTOMER_ID])
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@userName varchar(20), 
@passWord varchar(20)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE USERNAME = @userName AND PASS = @passWord
END
GO