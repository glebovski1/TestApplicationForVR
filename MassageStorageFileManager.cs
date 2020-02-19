using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestApplicationForVR
{
    public class MassageStorageFileManager
    {
        public XmlSerializer formatter;
        public MassageStorageFileManager()
        {
            formatter = new XmlSerializer(typeof(MassageStorageService));
        }

        public void Set(MassageStorageService massageStorage, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, massageStorage);

                
            }
        }

        public MassageStorageService Get(string fileName)
        {
            
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                try
                {
                    MassageStorageService massageStorag = (MassageStorageService)formatter.Deserialize(fs);
                    return massageStorag;
                }
                catch
                {
                    return null;
                }
                
            }
        }
    }
}
