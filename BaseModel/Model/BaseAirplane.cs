using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.Model
{
    public class BaseAirplane<T, V>
        where V : T
        where V : BaseEntity  : Base<T>
    {
        private List<AirplaneEntity> list;

        public BaseAirplane(List<T> list) : base(list)
        {
        }
    }
}
