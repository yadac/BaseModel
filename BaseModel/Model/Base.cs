using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Base<T> where T : class
    {
        public List<T> _list;
        private Object thisLock = new Object();

        /// <summary>
        /// 全ての要素を返却する
        /// </summary>
        /// <returns></returns>
        internal virtual List<T> SelectAll()
        {
            List<T> ret = new List<T>();
            lock (thisLock)
            {
                ret = _list;
            }
            return ret;
        }

        /// <summary>
        /// 引数で受け取ったキーと一致する要素を返却（1件だけどList）
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        internal virtual List<T> Select(string selectKey)
        {
            List<T> temp = new List<T>();
            var record = _list.FirstOrDefault(c => c.ToString() == selectKey);
            temp.Add(record);
            return temp;
        }

        /// <summary>
        /// 引数で受け取った要素を追加する
        /// </summary>
        /// <param name="addList"></param>
        internal virtual void Insert(List<T> list)
        {

        }

        /// <summary>
        /// 引数で受け取った要素とキーが一致する要素を上書きする
        /// </summary>
        /// <param name="list"></param>
        internal virtual void Update(List<T> list)
        {

        }

        /// <summary>
        /// 引数で受け取った要素とキーが一致する要素を削除する
        /// </summary>
        /// <param name="list"></param>
        internal virtual void Delete(List<T> list)
        {

        }
    }
}
