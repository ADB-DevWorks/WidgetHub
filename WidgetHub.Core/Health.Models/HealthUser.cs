using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetHub.Core.Health.Models
{
    //Class is public to import out of .Core
    public class HealthUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
