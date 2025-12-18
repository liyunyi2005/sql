# 社区医院疫苗接种管理系统

## 项目简介

这是一个基于 C# Windows Forms 开发的社区医院疫苗接种管理系统，用于管理社区居民的疫苗接种预约、记录和统计。系统采用 ADO.NET 连接 SQL Server 数据库，实现了完整的疫苗接种管理流程。

## 技术栈

- **开发语言**: C# (.NET Framework 4.8)
- **开发框架**: Windows Forms
- **数据库**: SQL Server
- **数据访问**: ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)
- **开发工具**: Visual Studio

## 系统功能

### 1. 用户登录
- 用户身份验证
- 支持多角色登录（管理员、医生、护士）
- 默认测试账号：
  - 管理员：`admin` / `123456`
  - 医生：`doctor` / `123456`
  - 护士：`nurse` / `123456`

### 2. 主界面
- 系统导航菜单
- 实时统计数据展示
- 快捷操作按钮
- 状态栏信息（用户、时间、版本）

### 3. 居民档案管理
- **居民查询**：支持多条件查询
  - 按姓名、身份证号、电话查询
  - 按性别、年龄段筛选
  - 按过敏史、社区筛选
  - 按建档日期范围查询
- 居民档案详情查看
- 居民档案删除
- 数据导出功能

### 4. 疫苗管理
- **疫苗入库**：
  - 疫苗基本信息录入（名称、生产厂家、批号）
  - 生产日期和有效期管理
  - 入库数量和价格管理
  - 存储温度和仓库管理
  - 自动更新库存总表
- **库存查询**：
  - 入库记录列表
  - 过期疫苗预警（即将过期/已过期）
  - 库存详情查看
  - 入库记录删除

### 5. 预约管理
- **新建预约**：
  - 居民选择（支持搜索）
  - 疫苗类型选择
  - 预约日期和时段设置
  - 接种剂次选择
  - 医院、科室、医生选择
  - 预约状态管理（待审核、已审核、已完成、已取消）
- **预约记录查询**：
  - 最近30天预约记录
  - 预约状态筛选
  - 预约详情查看
  - 预约取消功能
  - 预约凭证打印

### 6. 接种记录管理
- **登记接种**：
  - 选择已审核的预约记录
  - 自动获取疫苗批号
  - 接种信息录入（时间、部位、医生）
  - 健康信息记录（体温、血压、健康状况）
  - 不良反应记录
  - 支持草稿保存和完成提交
  - 自动更新预约状态和疫苗库存
- **接种记录查询**：
  - 最近30天接种记录
  - 记录详情查看
  - 记录编辑和删除
  - 数据导出功能

### 7. 统计报表
- **疫苗接种统计**：
  - 按疫苗类型统计
  - 按时间段统计
  - 接种人次统计
  - 性别分布统计
  - 年龄段分布统计
  - 接种率统计
- 报表导出（Excel/CSV）
- 报表打印功能

## 数据库设计

### 数据表结构

#### 1. Residents（居民表）
- `ResidentID`: 档案编号（主键）
- `Name`: 姓名
- `Gender`: 性别
- `BirthDate`: 出生日期
- `Age`: 年龄（计算列）
- `IDCard`: 身份证号（唯一）
- `Phone`: 联系电话
- `Address`: 家庭地址
- `AllergyHistory`: 过敏史
- `Community`: 所属社区
- `CreateDate`: 建档日期
- `Status`: 档案状态

#### 2. Appointments（预约表）
- `AppointmentID`: 预约编号（主键，格式：APyyyyMMdd###）
- `ResidentID`: 居民编号（外键）
- `VaccineName`: 疫苗名称
- `VaccineType`: 疫苗类型
- `AppointmentDate`: 预约日期
- `TimeSlot`: 预约时段
- `DoseNumber`: 接种剂次
- `Hospital`: 接种医院
- `Clinic`: 接种科室
- `Doctor`: 接种医生
- `Remark`: 备注
- `Status`: 预约状态（待审核、已审核、已完成、已取消）
- `CreateTime`: 创建时间
- `Operator`: 操作人员
- `CancelTime`: 取消时间

#### 3. VaccineInventory（疫苗库存总表）
- `VaccineName`: 疫苗名称（主键）
- `Quantity`: 库存数量
- `Unit`: 单位
- `LastUpdate`: 最后更新时间

#### 4. VaccineStock（疫苗入库明细表）
- `StockID`: 入库编号（主键，格式：VSyyyyMMdd###）
- `VaccineName`: 疫苗名称
- `Manufacturer`: 生产厂家
- `BatchNo`: 批号
- `ProduceDate`: 生产日期
- `ExpiryDate`: 有效期至
- `Quantity`: 入库数量
- `Unit`: 单位
- `Price`: 单价
- `TotalPrice`: 总价
- `StorageTemp`: 存储温度
- `Warehouse`: 存放仓库
- `Remark`: 备注
- `StockDate`: 入库日期
- `Operator`: 操作人员
- `Status`: 状态
- `LastUpdate`: 最后更新时间

#### 5. VaccinationRecords（接种记录表）
- `RecordID`: 记录编号（主键，格式：VRyyyyMMdd###）
- `AppointmentID`: 预约编号（外键，唯一）
- `ResidentID`: 居民编号（外键）
- `VaccineName`: 疫苗名称
- `BatchNo`: 疫苗批号
- `VaccinationTime`: 接种时间
- `VaccineSite`: 接种部位
- `Doctor`: 接种医生
- `Reaction`: 不良反应
- `Temperature`: 体温
- `BloodPressure`: 血压
- `HealthStatus`: 健康状况
- `Remark`: 备注
- `Status`: 记录状态（草稿、已完成、异常）
- `CreateTime`: 创建时间
- `Operator`: 操作人员

## 项目结构

```
sjk/
├── db/
│   └── CommunityHospital.sql          # 数据库初始化脚本
├── s/
│   ├── s.sln                          # 解决方案文件
│   └── s/
│       ├── Program.cs                 # 程序入口
│       ├── LoginForm.cs               # 登录窗体
│       ├── MainForm.cs                # 主界面窗体
│       ├── ResidentQueryForm.cs       # 居民查询窗体
│       ├── VaccineStockForm.cs        # 疫苗入库窗体
│       ├── AppointmentAddForm.cs      # 预约管理窗体
│       ├── RecordAddForm.cs           # 接种记录窗体
│       ├── ReportVaccineForm.cs       # 统计报表窗体
│       ├── App.config                 # 应用程序配置
│       └── CommunityHospital.csproj   # 项目文件
└── README.md                          # 项目说明文档
```

## 环境要求

- **操作系统**: Windows 7 及以上版本
- **开发环境**: Visual Studio 2017 及以上版本
- **.NET Framework**: 4.8
- **数据库**: SQL Server 2012 及以上版本（或 SQL Server Express）

## 安装部署

### 1. 数据库配置

1. 打开 SQL Server Management Studio (SSMS)
2. 执行数据库初始化脚本：
   ```sql
   -- 在 SSMS 中打开并执行
   db/CommunityHospital.sql
   ```
   或者使用命令行：
   ```bash
   sqlcmd -S . -E -i db\CommunityHospital.sql
   ```

3. 数据库连接字符串（默认使用 Windows 身份验证）：
   ```
   Data Source=.;Initial Catalog=CommunityHospital;Integrated Security=True
   ```

   如需修改连接字符串，请在各个 Form 的 `InitializeDatabaseConnection()` 方法中修改。

### 2. 编译运行

1. 使用 Visual Studio 打开 `s/s/s.sln`
2. 还原 NuGet 包（如有）
3. 设置启动项目为 `CommunityHospital`
4. 按 `F5` 运行或 `Ctrl+F5` 运行（不调试）

### 3. 发布部署

1. 在 Visual Studio 中右键项目 → 发布
2. 选择发布目标（文件夹、IIS等）
3. 配置发布设置
4. 发布后，将 `bin/Release` 目录下的文件复制到目标机器
5. 确保目标机器已安装 .NET Framework 4.8

## 使用说明

### 登录系统
1. 启动应用程序
2. 输入用户名和密码（默认：`admin` / `123456`）
3. 点击"登录"按钮

### 居民档案查询
1. 在主界面选择"居民档案管理" → "档案查询"
2. 输入查询条件（姓名、身份证号、电话等）
3. 点击"查询"按钮
4. 双击记录可查看详情

### 疫苗入库
1. 在主界面选择"疫苗管理" → "疫苗入库"
2. 填写疫苗信息（名称、厂家、批号、数量、价格等）
3. 点击"保存"按钮
4. 系统自动更新库存

### 新建预约
1. 在主界面选择"预约管理" → "新建预约"
2. 在居民列表中选择预约的居民
3. 选择疫苗类型、预约日期、时段等信息
4. 点击"提交"按钮
5. 预约状态为"待审核"，需等待审核

### 登记接种
1. 在主界面选择"接种记录" → "登记接种"
2. 选择已审核的预约记录
3. 系统自动填充疫苗信息
4. 填写接种信息（部位、医生、体温、血压等）
5. 点击"完成"按钮提交，或点击"暂存"保存草稿

### 查看统计报表
1. 在主界面选择"统计报表" → "疫苗接种统计"
2. 选择统计时间段和疫苗类型
3. 点击"查询"按钮
4. 可导出 Excel 或打印报表

## 注意事项

1. **数据库连接**：确保 SQL Server 服务已启动，且数据库已创建
2. **权限设置**：确保数据库用户有足够的权限执行增删改查操作
3. **数据备份**：定期备份数据库，防止数据丢失
4. **库存管理**：接种完成后会自动扣减库存，删除记录会恢复库存
5. **预约状态**：预约需审核后才能进行接种登记
6. **身份证隐私**：系统对身份证号进行了脱敏显示（仅显示首尾）

## 开发说明

### 代码特点
- 使用 ADO.NET 进行数据库操作
- 采用参数化查询防止 SQL 注入
- 使用事务保证数据一致性
- 实现了完整的异常处理机制
- 支持数据导出和打印功能

### 待完善功能
- 用户管理和权限控制
- 预约审核功能
- 数据导入功能
- 更完善的报表统计
- 系统日志记录
- 数据备份和恢复

## 版本信息

- **当前版本**: v1.0.0
- **开发日期**: 2024年
- **最后更新**: 2024年
