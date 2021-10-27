using System;
using System.Collections.Generic;

#nullable disable

namespace DemoProject.DataServices.EntityData.EntityModels
{
    public partial class UserPersonal
    {
        public int Upid { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string EmailId { get; set; }
        public int? Uid { get; set; }

        public virtual UserInfo UidNavigation { get; set; }
    }
}
