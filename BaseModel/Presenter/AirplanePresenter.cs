using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModel.Model;

namespace BaseModel.Presenter
{
    class AirplanePresenter
    {
        private Airplane _myModel;

        public AirplanePresenter()
        {
            _myModel = Airplane.GetInstance();
        }

        public void InsertData()
        {
            // 追加用リストの作成
            List<AirplaneEntity> list = new List<AirplaneEntity>()
            {
                new AirplaneEntity("aaa"),
                new AirplaneEntity("bbb"),
                new AirplaneEntity("ccc"),
                new AirplaneEntity("ddd"),
            };
            // 追加
            _myModel.Insert(list);
        }

        public void DeleteData()
        {
            // 削除用リストの作成
            List<AirplaneEntity> list = new List<AirplaneEntity>()
            {
                new AirplaneEntity("bbb"),
                new AirplaneEntity("ddd"),
            };
            // 削除
            _myModel.Delete(list);

        }
    }
}
