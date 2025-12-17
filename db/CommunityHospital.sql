/*
  CommunityHospital 数据库初始化脚本（SQL Server）

  由当前项目代码（WinForms + ADO.NET + SQL Server）反推生成。
  连接串示例（代码里硬编码）：
    Data Source=.;Initial Catalog=CommunityHospital;Integrated Security=True

  使用方式：
    - 在 SSMS 中打开并执行本脚本
    - 或用 sqlcmd 执行：
        sqlcmd -S . -E -i db\CommunityHospital.sql
*/

SET NOCOUNT ON;
GO

IF DB_ID(N'CommunityHospital') IS NULL
BEGIN
    PRINT N'Creating database [CommunityHospital]...';
    CREATE DATABASE [CommunityHospital];
END
GO

USE [CommunityHospital];
GO

/* =========
   Residents
   ========= */
IF OBJECT_ID(N'dbo.Residents', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Residents
    (
        ResidentID      NVARCHAR(50)   NOT NULL,  -- 档案编号
        Name            NVARCHAR(50)   NOT NULL,
        Gender          NVARCHAR(10)   NULL,
        BirthDate       DATE           NULL,
        -- 代码里查询条件直接使用 Age（Residents WHERE Age BETWEEN ...），因此提供计算列以兼容
        Age             AS (DATEDIFF(YEAR, BirthDate, GETDATE())),
        IDCard          NVARCHAR(18)   NULL,       -- 身份证号（18位）
        Phone           NVARCHAR(30)   NULL,
        Address         NVARCHAR(200)  NULL,
        AllergyHistory  NVARCHAR(500)  NULL,
        Community       NVARCHAR(100)  NULL,
        CreateDate      DATETIME2(0)   NOT NULL CONSTRAINT DF_Residents_CreateDate DEFAULT (SYSDATETIME()),
        Status          NVARCHAR(20)   NOT NULL CONSTRAINT DF_Residents_Status DEFAULT (N'正常'),

        CONSTRAINT PK_Residents PRIMARY KEY CLUSTERED (ResidentID),
        CONSTRAINT UQ_Residents_IDCard UNIQUE (IDCard)
    );

    CREATE INDEX IX_Residents_Name ON dbo.Residents(Name);
    CREATE INDEX IX_Residents_Phone ON dbo.Residents(Phone);
    CREATE INDEX IX_Residents_Community ON dbo.Residents(Community);
    CREATE INDEX IX_Residents_CreateDate ON dbo.Residents(CreateDate);
END
GO

/* ============
   Appointments
   ============ */
IF OBJECT_ID(N'dbo.Appointments', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Appointments
    (
        AppointmentID   NVARCHAR(30)   NOT NULL,  -- APyyyyMMdd###（代码生成）
        ResidentID      NVARCHAR(50)   NOT NULL,
        VaccineName     NVARCHAR(100)  NOT NULL,
        VaccineType     NVARCHAR(50)   NULL,
        AppointmentDate DATE           NOT NULL,
        TimeSlot        NVARCHAR(50)   NULL,
        DoseNumber      NVARCHAR(50)   NULL,
        Hospital        NVARCHAR(100)  NULL,
        Clinic          NVARCHAR(100)  NULL,
        Doctor          NVARCHAR(50)   NULL,
        Remark          NVARCHAR(500)  NULL,
        Status          NVARCHAR(20)   NOT NULL CONSTRAINT DF_Appointments_Status DEFAULT (N'待审核'),
        CreateTime      DATETIME2(0)   NOT NULL CONSTRAINT DF_Appointments_CreateTime DEFAULT (SYSDATETIME()),
        Operator        NVARCHAR(50)   NULL,
        CancelTime      DATETIME2(0)   NULL,

        CONSTRAINT PK_Appointments PRIMARY KEY CLUSTERED (AppointmentID),
        CONSTRAINT FK_Appointments_Residents
            FOREIGN KEY (ResidentID) REFERENCES dbo.Residents(ResidentID)
    );

    CREATE INDEX IX_Appointments_ResidentID ON dbo.Appointments(ResidentID);
    CREATE INDEX IX_Appointments_AppointmentDate ON dbo.Appointments(AppointmentDate);
    CREATE INDEX IX_Appointments_Status ON dbo.Appointments(Status);
    CREATE INDEX IX_Appointments_CreateTime ON dbo.Appointments(CreateTime);
END
GO

/* ===================
   VaccineInventory
   （库存总表：按 VaccineName 汇总）
   =================== */
IF OBJECT_ID(N'dbo.VaccineInventory', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.VaccineInventory
    (
        VaccineName NVARCHAR(100) NOT NULL,
        Quantity    DECIMAL(18,2) NOT NULL CONSTRAINT DF_VaccineInventory_Quantity DEFAULT (0),
        Unit        NVARCHAR(10)  NOT NULL CONSTRAINT DF_VaccineInventory_Unit DEFAULT (N'支'),
        LastUpdate  DATETIME2(0)  NOT NULL CONSTRAINT DF_VaccineInventory_LastUpdate DEFAULT (SYSDATETIME()),

        CONSTRAINT PK_VaccineInventory PRIMARY KEY CLUSTERED (VaccineName)
    );
END
GO

/* ============
   VaccineStock
   （入库明细：按批号管理）
   ============ */
IF OBJECT_ID(N'dbo.VaccineStock', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.VaccineStock
    (
        StockID      NVARCHAR(30)   NOT NULL,  -- VSyyyyMMdd###（代码生成）
        VaccineName  NVARCHAR(100)  NOT NULL,
        Manufacturer NVARCHAR(200)  NULL,
        BatchNo      NVARCHAR(50)   NOT NULL,
        ProduceDate  DATE           NULL,
        ExpiryDate   DATE           NULL,
        Quantity     DECIMAL(18,2)  NOT NULL,
        Unit         NVARCHAR(10)   NOT NULL CONSTRAINT DF_VaccineStock_Unit DEFAULT (N'支'),
        Price        DECIMAL(18,2)  NOT NULL CONSTRAINT DF_VaccineStock_Price DEFAULT (0),
        TotalPrice   DECIMAL(18,2)  NOT NULL CONSTRAINT DF_VaccineStock_TotalPrice DEFAULT (0),
        StorageTemp  NVARCHAR(50)   NULL,
        Warehouse    NVARCHAR(100)  NULL,
        Remark       NVARCHAR(500)  NULL,
        StockDate    DATE           NOT NULL CONSTRAINT DF_VaccineStock_StockDate DEFAULT (CONVERT(date, GETDATE())),
        Operator     NVARCHAR(50)   NULL,
        Status       NVARCHAR(20)   NOT NULL CONSTRAINT DF_VaccineStock_Status DEFAULT (N'正常'),
        LastUpdate   DATETIME2(0)   NULL,

        CONSTRAINT PK_VaccineStock PRIMARY KEY CLUSTERED (StockID),
        -- 代码里用 (BatchNo + VaccineName) 定位并更新库存，建议唯一化避免多行被同时扣减
        CONSTRAINT UQ_VaccineStock_VaccineName_BatchNo UNIQUE (VaccineName, BatchNo)
    );

    CREATE INDEX IX_VaccineStock_VaccineName ON dbo.VaccineStock(VaccineName);
    CREATE INDEX IX_VaccineStock_ExpiryDate ON dbo.VaccineStock(ExpiryDate);
    CREATE INDEX IX_VaccineStock_ProduceDate ON dbo.VaccineStock(ProduceDate);
    CREATE INDEX IX_VaccineStock_StockDate ON dbo.VaccineStock(StockDate);
END
GO

/* ===================
   VaccinationRecords
   =================== */
IF OBJECT_ID(N'dbo.VaccinationRecords', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.VaccinationRecords
    (
        RecordID         NVARCHAR(30)   NOT NULL, -- VRyyyyMMdd###（代码生成）
        AppointmentID    NVARCHAR(30)   NOT NULL,
        ResidentID       NVARCHAR(50)   NOT NULL,
        VaccineName      NVARCHAR(100)  NOT NULL,
        BatchNo          NVARCHAR(50)   NULL,
        VaccinationTime  DATETIME2(0)   NOT NULL,
        VaccineSite      NVARCHAR(50)   NULL,
        Doctor           NVARCHAR(50)   NULL,
        Reaction         NVARCHAR(50)   NULL,
        -- 代码里 Temperature/BloodPressure 以字符串参数写入（可能为空字符串），用 NVARCHAR 避免类型转换失败
        Temperature      NVARCHAR(20)   NULL,
        BloodPressure    NVARCHAR(20)   NULL,
        HealthStatus     NVARCHAR(50)   NULL,
        Remark           NVARCHAR(500)  NULL,
        Status           NVARCHAR(20)   NOT NULL CONSTRAINT DF_VaccinationRecords_Status DEFAULT (N'草稿'),
        CreateTime       DATETIME2(0)   NOT NULL CONSTRAINT DF_VaccinationRecords_CreateTime DEFAULT (SYSDATETIME()),
        Operator         NVARCHAR(50)   NULL,

        CONSTRAINT PK_VaccinationRecords PRIMARY KEY CLUSTERED (RecordID),
        CONSTRAINT FK_VaccinationRecords_Appointments
            FOREIGN KEY (AppointmentID) REFERENCES dbo.Appointments(AppointmentID),
        CONSTRAINT FK_VaccinationRecords_Residents
            FOREIGN KEY (ResidentID) REFERENCES dbo.Residents(ResidentID),
        -- 代码逻辑：一个预约最多一条接种记录（NOT EXISTS ... VaccinationRecords WHERE AppointmentID = a.AppointmentID）
        CONSTRAINT UQ_VaccinationRecords_AppointmentID UNIQUE (AppointmentID)
    );

    CREATE INDEX IX_VaccinationRecords_ResidentID ON dbo.VaccinationRecords(ResidentID);
    CREATE INDEX IX_VaccinationRecords_VaccinationTime ON dbo.VaccinationRecords(VaccinationTime);
    CREATE INDEX IX_VaccinationRecords_VaccineName ON dbo.VaccinationRecords(VaccineName);
END
GO

PRINT N'Database schema is ready.';
GO

/* ==================
   Sample Data Seeds
   仅当对应表为空时插入示例数据，便于重复执行脚本
   ================== */

-- Residents
IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201001')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201001', N'张三', N'男', '1992-05-12', N'110101199205123456', N'13800000001', N'XX市XX区XX路1号',  N'青霉素过敏', N'东湖社区', DATEADD(DAY, -120, SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201002')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201002', N'李四', N'女', '1987-11-03', N'110101198711034321', N'13800000002', N'XX市XX区XX路2号',  NULL,          N'西苑社区', DATEADD(DAY, -90,  SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201003')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201003', N'王五', N'男', '1975-02-18', N'110101197502187654', N'13800000003', N'XX市XX区XX路3号',  N'无',          N'东湖社区', DATEADD(DAY, -30,  SYSDATETIME()), N'正常');

-- 额外病人示例数据（可重复执行，不会重复插入）
IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201004')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201004', N'赵敏', N'女', '1998-08-21', N'110101199808213219', N'13800000004', N'XX市XX区幸福路8号',  N'鸡蛋过敏',    N'南山社区', DATEADD(DAY, -15, SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201005')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201005', N'陈浩', N'男', '2001-01-09', N'110101200101093277', N'13800000005', N'XX市XX区青年路66号', N'',            N'西苑社区', DATEADD(DAY, -10, SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201006')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201006', N'刘洋', N'男', '1968-04-30', N'110101196804303188', N'13800000006', N'XX市XX区康宁路12号', N'花粉过敏',    N'东湖社区', DATEADD(DAY, -200, SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201007')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201007', N'周婷', N'女', '2018-09-15', N'110101201809153266', N'13800000007', N'XX市XX区童乐街5号',  NULL,          N'南山社区', DATEADD(DAY, -300, SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201008')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201008', N'孙强', N'男', '1990-12-02', N'110101199012023244', N'13800000008', N'XX市XX区滨河路9号',  N'海鲜过敏',    N'北苑社区', DATEADD(DAY, -45, SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201009')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201009', N'吴静', N'女', '1982-06-17', N'110101198206173211', N'13800000009', N'XX市XX区春风路18号', N'无',          N'北苑社区', DATEADD(DAY, -70, SYSDATETIME()), N'正常');

IF NOT EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID = N'R20251201010')
    INSERT INTO dbo.Residents (ResidentID, Name, Gender, BirthDate, IDCard, Phone, Address, AllergyHistory, Community, CreateDate, Status)
    VALUES (N'R20251201010', N'唐伟', N'男', '2013-03-06', N'110101201303063212', N'13800000010', N'XX市XX区书香路3号',  NULL,          N'西苑社区', DATEADD(DAY, -20, SYSDATETIME()), N'正常');
GO

-- VaccineInventory
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'新冠疫苗（灭活）')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'新冠疫苗（灭活）', 50, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'新冠疫苗（重组）')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'新冠疫苗（重组）', 40, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'流感疫苗')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'流感疫苗', 80, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'乙肝疫苗')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'乙肝疫苗', 30, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'百白破疫苗')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'百白破疫苗', 60, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'麻疹疫苗')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'麻疹疫苗', 55, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'水痘疫苗')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'水痘疫苗', 45, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'肺炎疫苗')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'肺炎疫苗', 35, N'支', SYSDATETIME());
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineInventory WHERE VaccineName = N'HPV疫苗')
    INSERT INTO dbo.VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES (N'HPV疫苗', 25, N'支', SYSDATETIME());
GO

-- VaccineStock
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201001')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201001', N'新冠疫苗（灭活）', N'科兴生物',   N'BATCH-COVID-202511', DATEADD(MONTH, -1, CONVERT(date, GETDATE())), DATEADD(YEAR, 1, CONVERT(date, GETDATE())), 50, N'支', 120.00, 6000.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201002')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201002', N'流感疫苗',         N'华兰生物',   N'BATCH-FLU-202510',  DATEADD(MONTH, -2, CONVERT(date, GETDATE())), DATEADD(MONTH, 10, CONVERT(date, GETDATE())), 80, N'支',  60.00, 4800.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201003')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201003', N'乙肝疫苗',         N'深圳康泰',   N'BATCH-HBV-202509',  DATEADD(MONTH, -3, CONVERT(date, GETDATE())), DATEADD(MONTH,  9, CONVERT(date, GETDATE())), 30, N'支',  35.00, 1050.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

-- 补充更多疫苗种类的入库数据（至少保证每种疫苗有可用批号，方便“登记接种”自动带出批号）
IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201004')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201004', N'新冠疫苗（重组）', N'智飞生物',   N'BATCH-COVIDR-202512', DATEADD(MONTH, -1, CONVERT(date, GETDATE())), DATEADD(YEAR, 1, CONVERT(date, GETDATE())), 40, N'支', 110.00, 4400.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201005')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201005', N'百白破疫苗',       N'长春生物',   N'BATCH-DTP-202510A',  DATEADD(MONTH, -2, CONVERT(date, GETDATE())), DATEADD(MONTH, 12, CONVERT(date, GETDATE())), 60, N'支',  25.00, 1500.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201006')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201006', N'麻疹疫苗',         N'兰州生物',   N'BATCH-MEASLES-202510', DATEADD(MONTH, -2, CONVERT(date, GETDATE())), DATEADD(MONTH, 12, CONVERT(date, GETDATE())), 55, N'支',  18.00,  990.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201007')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201007', N'水痘疫苗',         N'长春祈健',   N'BATCH-VARICELLA-202511', DATEADD(MONTH, -1, CONVERT(date, GETDATE())), DATEADD(MONTH, 11, CONVERT(date, GETDATE())), 45, N'支',  85.00, 3825.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201008')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201008', N'肺炎疫苗',         N'辉瑞制药',   N'BATCH-PNEUMO-202509', DATEADD(MONTH, -3, CONVERT(date, GETDATE())), DATEADD(MONTH,  9, CONVERT(date, GETDATE())), 35, N'支', 160.00, 5600.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());

IF NOT EXISTS (SELECT 1 FROM dbo.VaccineStock WHERE StockID = N'VS20251201009')
    INSERT INTO dbo.VaccineStock
        (StockID, VaccineName, Manufacturer, BatchNo, ProduceDate, ExpiryDate, Quantity, Unit, Price, TotalPrice, StorageTemp, Warehouse, Remark, StockDate, Operator, Status, LastUpdate)
    VALUES
        (N'VS20251201009', N'HPV疫苗',          N'默沙东',     N'BATCH-HPV-202510',   DATEADD(MONTH, -2, CONVERT(date, GETDATE())), DATEADD(MONTH, 14, CONVERT(date, GETDATE())), 25, N'支', 620.00, 15500.00, N'2-8', N'冷藏库', N'示例入库', CONVERT(date, GETDATE()), N'admin', N'正常', SYSDATETIME());
GO

-- Appointments
IF NOT EXISTS (SELECT 1 FROM dbo.Appointments)
BEGIN
    -- 一个“已审核且可接种”的预约（AppointmentDate <= GETDATE 且没有接种记录）
    INSERT INTO dbo.Appointments
        (AppointmentID, ResidentID, VaccineName, VaccineType, AppointmentDate, TimeSlot, DoseNumber, Hospital, Clinic, Doctor, Remark, Status, CreateTime, Operator, CancelTime)
    VALUES
        (N'AP20251201001', N'R20251201001', N'新冠疫苗（灭活）', N'第一针', CONVERT(date, DATEADD(DAY, -1, GETDATE())), N'上午', N'第1剂', N'社区医院', N'预防接种门诊', N'张医生', N'示例预约（可接种）', N'已审核', DATEADD(DAY, -2, SYSDATETIME()), N'admin', NULL),
        (N'AP20251201002', N'R20251201002', N'流感疫苗',         N'年度接种', CONVERT(date, DATEADD(DAY,  3, GETDATE())), N'下午', N'年度',  N'社区医院', N'预防接种门诊', N'李医生', N'示例预约（待审核）', N'待审核', DATEADD(DAY, -1, SYSDATETIME()), N'admin', NULL),
        (N'AP20251201003', N'R20251201003', N'乙肝疫苗',         N'第一针', CONVERT(date, DATEADD(DAY, -5, GETDATE())), N'上午', N'第1剂', N'社区医院', N'预防接种门诊', N'王医生', N'示例预约（已完成）', N'已完成', DATEADD(DAY, -6, SYSDATETIME()), N'admin', NULL),
        (N'AP20251201004', N'R20251201002', N'新冠疫苗（灭活）', N'第二针', CONVERT(date, DATEADD(DAY,  7, GETDATE())), N'上午', N'第2剂', N'社区医院', N'预防接种门诊', N'张医生', N'示例预约（已取消）', N'已取消', DATEADD(DAY, -3, SYSDATETIME()), N'admin', DATEADD(DAY, -2, SYSDATETIME()));
END
GO

-- VaccinationRecords
IF NOT EXISTS (SELECT 1 FROM dbo.VaccinationRecords)
BEGIN
    -- 给 AP20251201003 插入一条已完成接种记录（用于演示记录列表）
    INSERT INTO dbo.VaccinationRecords
        (RecordID, AppointmentID, ResidentID, VaccineName, BatchNo, VaccinationTime, VaccineSite, Doctor, Reaction, Temperature, BloodPressure, HealthStatus, Remark, Status, CreateTime, Operator)
    VALUES
        (N'VR20251201001', N'AP20251201003', N'R20251201003', N'乙肝疫苗', N'BATCH-HBV-202509',
         DATEADD(DAY, -5, SYSDATETIME()), N'左臂', N'王医生', N'无', N'36.6', N'120/80', N'良好', N'示例接种记录', N'已完成', DATEADD(DAY, -5, SYSDATETIME()), N'admin');
END
GO


