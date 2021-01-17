using System;

namespace Application
{
    public class ReportInput
    {
        public CalculationRecord[] Records { get; set; }
    }

    public class CalculationRecord {
        public string Equation { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}