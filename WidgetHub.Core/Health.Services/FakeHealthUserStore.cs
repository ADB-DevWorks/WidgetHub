using System;
using System.Collections.Generic;
using System.Text;
using WidgetHub.Core.Health.Models;

/*
 * Temperary service to access user infromation
 *
 * TODO: Update when database added
 */

namespace WidgetHub.Core.Health.Services
{
    public static class FakeHealthUserStore
    {
        public static List<HealthUser> Users { get; set; } = new();
    }
}
