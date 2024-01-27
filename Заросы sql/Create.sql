--СОЗДАНИЕ МОЕЙ БД,НА ВСЯКИЙ СЛУЧАЙ,ЛУЧШЕ ПОЛЬЗОВАТЬ МИГРАЦИЯМИ!!!!!


USE Translaters_Buro
GO

-- Создание таблиц
CREATE TABLE [dbo].[Users] (
    [ID_Пользователя] INT PRIMARY KEY,
    [Имя] NVARCHAR(32),
    [Электронная_почта] NVARCHAR(32),
    [Пароль] NVARCHAR(32),
    [Дата_регистрации] DATETIME,
    [Рейтинг] INT,
    [ФИО_пользователя] NVARCHAR(40)
);

CREATE TABLE [dbo].[Ratings] (
    [ID_Оценки] INT PRIMARY KEY,
    [Значение] INT,
    [Дата_оценки] DATETIME
);

CREATE TABLE [dbo].[Comments] (
    [ID_Комментария] INT PRIMARY KEY,
    [Текст] NVARCHAR(32),
    [Дата_комментария] DATETIME
);

CREATE TABLE [dbo].[Orders] (
    [ID_Заказа] INT PRIMARY KEY,
    [ID_Исходного_языка] NVARCHAR(32),
    [ID_Итогового_файла] INT,
    [Статус] BIT,
    [Дата_заказа] DATETIME,
    [Стоимость_заказа] DECIMAL(16, 2)
);

CREATE TABLE [dbo].[TranslationTypes] (
    [ID_Типа_перевода] INT PRIMARY KEY,
    [Название_типа_перевода] NVARCHAR(32),
    [Коэффициент] INT
);

CREATE TABLE [dbo].[FinalFiles] (
    [ID_Итогового_файла] INT PRIMARY KEY,
    [Дата_загрузки] DATETIME,
    [Страницы] INT,
    [Ссылка_на_итоговый_файл] NVARCHAR(32)
);

CREATE TABLE [dbo].[SourceFiles] (
    [ID_Исходного_файла] INT PRIMARY KEY,
    [Ссылка_на_исходный_файл] NVARCHAR(32),
    [Дата_загрузки] DATETIME,
    [Количество_страниц] INT
);

CREATE TABLE [dbo].[Translators] (
    [ID_Переводчика] INT PRIMARY KEY,
    [Рейтинг] INT,
    [Зарплата] DECIMAL(16, 2),
    [Дата_рождения] DATETIME
);

CREATE TABLE [dbo].[TranslatorCertificates] (
    [ID_Сертификата] INT PRIMARY KEY,
    [Название_сертификата] NVARCHAR(32),
    [Организация_выдавшая] NVARCHAR(32),
    [Дата_выдачи] DATETIME,
    [Дата_истечения] DATETIME
);

CREATE TABLE [dbo].[Languages] (
    [ID_Языка] INT PRIMARY KEY,
    [Название_языка] NVARCHAR(32),
    [Код_языка] INT
);

CREATE TABLE [dbo].[PaymentInformation] (
    [ID_Типа_платежа] INT PRIMARY KEY,
    [Название_платежной_системы] NVARCHAR(32),
    [Статус_платежа] BIT,
    [Дедлайн_платежа] DATETIME
);
