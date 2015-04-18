using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerMVCApp.Models
{
    public class Bug
    {
        public int id { get; set; }
        public string title { get; set; }
        public bool isClosed { get; set; }
        public DateTime createdAt { get; set; }
    }
}
