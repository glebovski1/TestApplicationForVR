using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForVR.Models
{
    [Serializable]
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSizeForUserMassages { get; set; }
        public List<Massage> UserMassages { get; set; }
        public User()
        {
            UserMassages = new List<Massage>();
            MaxSizeForUserMassages = 10;

        }

        public User(string name, IdModel idModel)
        {
            Name = name;
            UserMassages = new List<Massage>();
            MaxSizeForUserMassages = 10;
            this.SetId(idModel);
        }
        

        public void AddMassage(Massage massage)
        {
            if (UserMassages.Count == MaxSizeForUserMassages)
            {
                UserMassages.RemoveAt(MaxSizeForUserMassages);
                UserMassages.Add(massage);
            }
            else
            {
                UserMassages.Add(massage);
            }
        }

        public List<Massage> GetMassages()
        {
            return UserMassages;
        }

        public void SetId(IdModel idModel)
        {
            this.ID = idModel.GetId();
        }
    }
}
