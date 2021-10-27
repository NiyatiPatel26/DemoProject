using System;
using System.Collections.Generic;

#nullable disable

namespace DemoProject.DataServices.EntityData.EntityModels
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            UserPersonals = new HashSet<UserPersonal>();
        }

        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Uadd { get; set; }

        public virtual ICollection<UserPersonal> UserPersonals { get; set; }
    }
}
