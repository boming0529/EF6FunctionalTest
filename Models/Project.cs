using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF7TEST.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public ICollection<Dev> Devs { get; set; }
        public Project()
        {
            Devs = new HashSet<Dev>();
        }
    }
}