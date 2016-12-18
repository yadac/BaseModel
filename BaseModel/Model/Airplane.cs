using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.Model
{
    public class Airplane : BaseAirplane<BaseAirplaneEntity>
    {
        private static Airplane _instance;

        public static Airplane GetInstance()
        {
            if (_instance == null)
                _instance = new Airplane();
            return _instance;
        }

        public Airplane() : base(new List<AirplaneEntity>())
        {
            // nothing to do
        }
    }
}
