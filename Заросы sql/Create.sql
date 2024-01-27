--�������� ���� ��,�� ������ ������,����� ���������� ����������!!!!!


USE Translaters_Buro
GO

-- �������� ������
CREATE TABLE [dbo].[Users] (
    [ID_������������] INT PRIMARY KEY,
    [���] NVARCHAR(32),
    [�����������_�����] NVARCHAR(32),
    [������] NVARCHAR(32),
    [����_�����������] DATETIME,
    [�������] INT,
    [���_������������] NVARCHAR(40)
);

CREATE TABLE [dbo].[Ratings] (
    [ID_������] INT PRIMARY KEY,
    [��������] INT,
    [����_������] DATETIME
);

CREATE TABLE [dbo].[Comments] (
    [ID_�����������] INT PRIMARY KEY,
    [�����] NVARCHAR(32),
    [����_�����������] DATETIME
);

CREATE TABLE [dbo].[Orders] (
    [ID_������] INT PRIMARY KEY,
    [ID_���������_�����] NVARCHAR(32),
    [ID_���������_�����] INT,
    [������] BIT,
    [����_������] DATETIME,
    [���������_������] DECIMAL(16, 2)
);

CREATE TABLE [dbo].[TranslationTypes] (
    [ID_����_��������] INT PRIMARY KEY,
    [��������_����_��������] NVARCHAR(32),
    [�����������] INT
);

CREATE TABLE [dbo].[FinalFiles] (
    [ID_���������_�����] INT PRIMARY KEY,
    [����_��������] DATETIME,
    [��������] INT,
    [������_��_��������_����] NVARCHAR(32)
);

CREATE TABLE [dbo].[SourceFiles] (
    [ID_���������_�����] INT PRIMARY KEY,
    [������_��_��������_����] NVARCHAR(32),
    [����_��������] DATETIME,
    [����������_�������] INT
);

CREATE TABLE [dbo].[Translators] (
    [ID_�����������] INT PRIMARY KEY,
    [�������] INT,
    [��������] DECIMAL(16, 2),
    [����_��������] DATETIME
);

CREATE TABLE [dbo].[TranslatorCertificates] (
    [ID_�����������] INT PRIMARY KEY,
    [��������_�����������] NVARCHAR(32),
    [�����������_��������] NVARCHAR(32),
    [����_������] DATETIME,
    [����_���������] DATETIME
);

CREATE TABLE [dbo].[Languages] (
    [ID_�����] INT PRIMARY KEY,
    [��������_�����] NVARCHAR(32),
    [���_�����] INT
);

CREATE TABLE [dbo].[PaymentInformation] (
    [ID_����_�������] INT PRIMARY KEY,
    [��������_���������_�������] NVARCHAR(32),
    [������_�������] BIT,
    [�������_�������] DATETIME
);
