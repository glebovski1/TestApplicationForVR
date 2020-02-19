using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplicationForVR.Models;

namespace TestApplicationForVR
{
    [Serializable]
    public class MassageStorageService
    {
        public List<Massage> CommonMassages { get; set; }

        public int maxSizeForCommonMassages;

        public IdModel IdModel { get; set; }
        public List<User> Users { get; set; }

        public MassageStorageService()
        {
            CommonMassages = new List<Massage>();
                        
            maxSizeForCommonMassages = 20;

            Users = new List<User>();

            IdModel = new IdModel();
            
        }

        public void AddMassage(string userName, string text)
        {
            var user = Users.Find(item => item.Name == userName);

            if (user == null)
            {
                user = new User(userName, IdModel);
                
            }
            Massage massage = new Massage(user.ID, text);
            user.AddMassage(massage);
            Users.Add(user);

            if (CommonMassages.Count == maxSizeForCommonMassages)
            {
                CommonMassages.RemoveAt(maxSizeForCommonMassages);
                CommonMassages.Add(massage);
            }
            else
            {
                CommonMassages.Add(massage);
            }
        }

        public List<Massage> GetMassages()
        {
            List<Massage> massages = new List<Massage>();

            massages.AddRange(CommonMassages);

            foreach(User user in Users)
            {
                var userList = user.GetMassages();
                massages.AddRange(userList.Except<Massage>(massages));
            }

            return massages;
        }
    }
}
