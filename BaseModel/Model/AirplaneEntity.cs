using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.Model
{
    class AirplaneEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        //public List<PassengerInfo> Detail { get; set; }
        public string Key { get; set; }

        public override string ToString()
        {
            return Key;
        }
    }

    class PassengerInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
