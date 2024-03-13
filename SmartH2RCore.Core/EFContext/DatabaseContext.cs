using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Core.EFContext
{
    public class DatabaseContext : IdentityDbContext<User, Role, int>, IDatabaseContext
    {
        public DbSet<BranchCity> BranchCity { get; private set; } = default!;
        public DbSet<BranchCountry> BranchCountry { get; private set; } = default!;
        public DbSet<BranchCurrencyCode> BranchCurrencyCode { get; private set; } = default!;
        public DbSet<BranchDepartment> BranchDepartment { get; private set; } = default!;
        public DbSet<BranchDepartmentType> BranchDepartmentType { get; private set; } = default!;
        public DbSet<BranchDesignation> BranchDesignation { get; private set; } = default!;
        public DbSet<BranchEmployeeStatus> BranchEmployeeStatus { get; private set; } = default!;
        public DbSet<BranchEmployeeSubType> BranchEmployeeSubType { get; private set; } = default!;
        public DbSet<BranchEmployeeType> BranchEmployeeType { get; private set; } = default!;
        public DbSet<BranchGrade> BranchGrade { get; private set; } = default!;
        public DbSet<BranchState> BranchState { get; private set; } = default!;
        public DbSet<BranchRole> BranchRole { get; private set; } = default!;
        public DbSet<BranchAccountType> BranchAccountTypes { get; private set; } = default!;
        public DbSet<BranchBank> BranchBanks { get; private set; } = default!;

        public DbSet<Company> Company { get; private set; } = default!;
        public DbSet<AccountType> AccountType { get; private set; } = default!;
        
        public DbSet<Department> Department { get; private set; } = default!;
        public DbSet<EmployeeStatus> EmployeeStatus { get; private set; } = default!;
        public DbSet<DepartmentType> DepartmentType { get; private set; } = default!;
        public DbSet<EmployeeSubType> EmployeeSubType { get; private set; } = default!;
        public DbSet<EmployeeType> EmployeeType { get; private set; } = default!;
        public DbSet<Designation> Designation { get; private set; } = default!;
        public DbSet<Currency> Currency { get; private set; } = default!;
        public DbSet<Grade> Grade { get; private set; } = default!;
        public DbSet<Country> Country { get; private set; } = default!;
        public DbSet<State> State { get; private set; } = default!;
        public DbSet<City> City { get; private set; } = default!;
        public DbSet<Bank> Bank { get; private set; } = default!;

        public DbSet<EmailSetting> EmailSetting { get; private set; } = default!;

        public DbSet<ApproverInformation> ApproverInformation { get; private set; } = default!;
        public DbSet<ChildrenDetails> ChildrenDetails { get; private set; } = default!;
        public DbSet<ContactList> ContactList { get; private set; } = default!;
        public DbSet<DocumentDetails> DocumentDetails { get; private set; } = default!;
        public DbSet<EducationalQualification> EducationalQualification { get; private set; } = default!;
        public DbSet<EmergencyContactDetails> EmergencyContactDetails { get; private set; } = default!;
        public DbSet<ExperienceDetails> ExperienceDetails { get; private set; } = default!;
        public DbSet<JobDetails> JobDetails { get; private set; } = default!;
        public DbSet<PersonalDetails> PersonalDetails { get; private set; } = default!;
        public DbSet<ProfessionalQualification> ProfessionalQualification { get; private set; } = default!;
        public DbSet<TrainingDetails> TrainingDetails { get; private set; } = default!;
        
        public DbSet<ModuleMaster> ModuleMaster { get; private set; } = default!;

        public DbSet<ScreenMaster> ScreenMaster { get; private set; } = default!;

        public DbSet<RolePermission> RolePermission { get; private set; } = default!;

        public DbSet<User> AspNetUsers { get; private set; } = default!;

        public const string SCHEMA_MASTER = "Master";

        public const string SCHEMA_COMPANY = "Company";

        public const string SCHEMA_EMPLOYEE = "Employee";

        public const string SCHEMA_PERMISSION = "Permission";


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            #region Master
            {
                var entity = builder.Entity<Country>();
                entity.ToTable(nameof(Country), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<State>();
                entity.ToTable(nameof(State), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<City>();
                entity.ToTable(nameof(City), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }
            {
                var entity = builder.Entity<Bank>();
                entity.ToTable(nameof(Bank), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<Currency>();
                entity.ToTable(nameof(Currency), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<Grade>();
                entity.ToTable(nameof(Grade), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<Designation>();
                entity.ToTable(nameof(Designation), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<AccountType>();
                entity.ToTable(nameof(AccountType), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<Department>();
                entity.ToTable(nameof(Department), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<EmployeeSubType>();
                entity.ToTable(nameof(EmployeeSubType), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<EmployeeType>();
                entity.ToTable(nameof(EmployeeType), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<EmployeeStatus>();
                entity.ToTable(nameof(EmployeeStatus), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<DepartmentType>();
                entity.ToTable(nameof(DepartmentType), SCHEMA_MASTER);
                entity.HasKey(x => x.Id);

            }


            #endregion

            #region Company

            {
                var entity = builder.Entity<EmailSetting>();
                entity.ToTable(nameof(EmailSetting), SCHEMA_COMPANY);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<Company>();
                entity.ToTable(nameof(Company), SCHEMA_COMPANY);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<BranchCity>();
                entity.ToTable(nameof(BranchCity), SCHEMA_COMPANY);
                entity.HasKey(p => new { p.BranchId, p.CityId });
            }

            {
                var entity = builder.Entity<BranchCountry>();
                entity.HasKey(p => new { p.BranchId, p.CountryId });
                entity.ToTable(nameof(BranchCountry), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchState>();
                entity.HasKey(p => new { p.BranchId, p.StateId });
                entity.ToTable(nameof(BranchState), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchCurrencyCode>();
                entity.HasKey(p => new { p.BranchId, p.CurrencyId });
                entity.ToTable(nameof(BranchCurrencyCode), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchDepartment>();
                entity.HasKey(p => new { p.BranchId, p.DepartmentId });
                entity.ToTable(nameof(BranchDepartment), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchDepartmentType>();
                entity.HasKey(p => new { p.BranchId, p.DepartmentTypeId });
                entity.ToTable(nameof(BranchDepartmentType), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchDesignation>();
                entity.HasKey(p => new { p.BranchId, p.DesignationId });
                entity.ToTable(nameof(BranchDesignation), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchEmployeeStatus>();
                entity.HasKey(p => new { p.BranchId, p.EmployeeStatusId });
                entity.ToTable(nameof(BranchEmployeeStatus), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchEmployeeType>();
                entity.HasKey(p => new { p.BranchId, p.EmployeeTypeId });
                entity.ToTable(nameof(BranchEmployeeType), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchEmployeeSubType>();
                entity.HasKey(p => new { p.BranchId, p.EmployeeSubTypeId });
                entity.ToTable(nameof(BranchEmployeeSubType), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchGrade>();
                entity.HasKey(p => new { p.BranchId, p.GradeId });
                entity.ToTable(nameof(BranchGrade), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchRole>();
                entity.HasKey(p => new { p.BranchId, p.RoleId });
                entity.ToTable(nameof(BranchRole), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchBank>();
                entity.HasKey(p => new { p.BranchId, p.BankId });
                entity.ToTable(nameof(BranchBank), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<BranchAccountType>();
                entity.HasKey(p => new { p.BranchId, p.AccountTypeId });
                entity.ToTable(nameof(BranchAccountType), SCHEMA_COMPANY);
            }

            {
                var entity = builder.Entity<Branch>();
                entity.ToTable(nameof(Branch), SCHEMA_COMPANY);
            }

            #endregion

            #region Employee
            {
                var entity = builder.Entity<ApproverInformation>();
                entity.ToTable(nameof(ApproverInformation), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<ChildrenDetails>();
                entity.ToTable(nameof(ChildrenDetails), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<ContactList>();
                entity.ToTable(nameof(ContactList), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<EducationalQualification>();
                entity.ToTable(nameof(EducationalQualification), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<EmergencyContactDetails>();
                entity.ToTable(nameof(EmergencyContactDetails), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<ExperienceDetails>();
                entity.Property(v => v.TotalExperience).HasPrecision(15, 2);
                entity.ToTable(nameof(Company), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<JobDetails>();
                entity.Property(v => v.CTCPerAnnum).HasPrecision(15, 2);
                entity.ToTable(nameof(JobDetails), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<PersonalDetails>();
                entity.ToTable(nameof(PersonalDetails), SCHEMA_EMPLOYEE);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<ProfessionalQualification>();
                entity.ToTable(nameof(ProfessionalQualification), SCHEMA_COMPANY);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            {
                var entity = builder.Entity<TrainingDetails>();
                entity.ToTable(nameof(TrainingDetails), SCHEMA_COMPANY);
                entity.HasOne(v => v.Employee).WithMany().HasForeignKey(v => v.EmployeeId);
                entity.HasKey(x => x.Id);
            }

            #endregion

            #region Permission 
            {
                var entity = builder.Entity<ModuleMaster>();
                entity.ToTable(nameof(ModuleMaster), SCHEMA_PERMISSION);
                entity.HasKey(x => x.Id);
            }
            {
                var entity = builder.Entity<ScreenMaster>();
                entity.ToTable(nameof(ScreenMaster), SCHEMA_PERMISSION);
                entity.HasKey(x => x.Id);
            }
            {
                var entity = builder.Entity<RolePermission>();
                entity.ToTable(nameof(RolePermission), SCHEMA_PERMISSION);
                entity.HasKey(x => x.Id);
            }
            #endregion

            base.OnModelCreating(builder);
        }
    }
}