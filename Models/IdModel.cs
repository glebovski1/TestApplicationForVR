using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForVR.Models
{
    [Serializable]
    public class IdModel
    {
        public int IdCount { get; set; }

        public IdModel()
        {
            IdCount = 1;
        }

        public int GetId()
        {
            int id = IdCount;
            IdCount++;
            return id;
        }
    }
}
