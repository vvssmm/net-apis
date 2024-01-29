using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.Apis.Domain.Persistence
{
    public class DatabaseConst
    {
        public static class BaseColumns
        {
            public const string CreatedDate = "CREATED_DATE";
            public const string CreatedBy = "CREATED_BY";
            public const string UpdatedDate = "UPDATED_DATE";
            public const string UpdatedBy="UPDATED_BY";
            public const string DeletedDate = "DELETED_DATE";
            public const string DeletedBy = "DELETED_BY";
        }
    }
}
