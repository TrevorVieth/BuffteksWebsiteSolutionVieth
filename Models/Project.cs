using System;

namespace BuffteksWebsite.Models
{
    public class Project
    {
        public int ProjectID{ get; set; }
        public string ClientsAssigned{ get; set; }
        public string MembersAssigned{ get; set; }
        public string Description{ get; set; }
        public string DueDate{ get; set; }

    }
}