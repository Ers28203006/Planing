namespace Planing.DataAccess
{
    using Planing.Models;
    using System.Data.Entity;

    public class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }
        public virtual DbSet<Purpose> Purposes { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<PlanForDay> PlanForDays { get; set; }
        public virtual DbSet<PlanForMonth> PlanForMonths { get; set; }
        public virtual DbSet<PlanForWeek> PlanForWeeks { get; set; }
        public virtual DbSet<PlanForYear> PlanForYears { get; set; }
    }
}