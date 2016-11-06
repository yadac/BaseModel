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
        private Airplane myModel;

        public AirplanePresenter()
        {
            myModel = new Airplane();
        }

        public void InsertData()
        {
            // 追加用リストの作成
            List<AirplaneEntity> list = new List<AirplaneEntity>()
            {
                new AirplaneEntity() {Id = "101", Name = "ana101", Key = "101ana101"},
                new AirplaneEntity() {Id = "102", Name = "ana102", Key = "102ana102"},
                new AirplaneEntity() {Id = "201", Name = "jal201", Key = "201jal201"},
                new AirplaneEntity() {Id = "202", Name = "jal202", Key = "202jal202"},
            };
            // 追加
            myModel.Insert(list);
        }

        public void DeleteData()
        {
            // 削除用リストの作成
            List<AirplaneEntity> list = new List<AirplaneEntity>()
            {
                new AirplaneEntity() {Id = "101", Name = "ana101", Key = "101ana101"},
                new AirplaneEntity() {Id = "102", Name = "ana102", Key = "102ana102"},
            };
            // 削除
            myModel.Delete(list);

        }
    }
}
