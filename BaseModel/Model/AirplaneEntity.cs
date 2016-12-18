using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.Model
{
    [Serializable]
    public class AirplaneEntity : BaseAirplaneEntity
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public List<PassengerInfo> PassengerInfoList { get; set; }
    }

    public class PassengerInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
