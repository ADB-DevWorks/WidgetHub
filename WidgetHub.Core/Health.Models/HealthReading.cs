using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetHub.Core.Health.Models
{
    internal class HealthReading
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int SystolicPressure { get; set; }
        public int DiastolicPressure { get; set; }
        public int? HeartRate { get; set; } //Nullable for user option to not record
        public int? OxygenLevel { get; set; }

        public DateTime TimeStamp { get; set; } = DateTime.Now;

        // Computed property to calculte hypertension stage
        public string Catagory
        {
            get
            {
                if (SystolicPressure < 120 && DiastolicPressure < 80) return "Normal";
                if (SystolicPressure < 130 && DiastolicPressure < 80) return "Elevated";
                if (SystolicPressure < 140 || DiastolicPressure < 90) return "Stage 1 Hypertension";
                if (SystolicPressure >= 140 || DiastolicPressure > 90) return "Stage 2 Hypertension";
                if (SystolicPressure > 180 || DiastolicPressure > 120) return "Severe Hypertension. If experencing any other syptoms call 911";
                return "unKnown";   
            }
        }

    }
}
