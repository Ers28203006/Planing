using System;

namespace Planing.Models
{
    public class PlanForWeek
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public int Weekday { get; set; }
    }
}