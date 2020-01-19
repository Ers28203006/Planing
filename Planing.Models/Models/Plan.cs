using System.Collections.Generic;

namespace Planing.Models
{
    public class Plan
    {
        public Plan()
        {
            PlanForDays = new List<PlanForDay>();
            PlanForMonthes = new List<PlanForMonth>();
            PlanForYears = new List<PlanForYear>();
            PlanForWeeks = new List<PlanForWeek>();
        }
        public int Id { get; set; }
        public ICollection<PlanForDay> PlanForDays { get; set; }
        public ICollection<PlanForMonth> PlanForMonthes { get; set; }
        public ICollection<PlanForYear> PlanForYears { get; set; }
        public ICollection<PlanForWeek> PlanForWeeks { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
    }
}