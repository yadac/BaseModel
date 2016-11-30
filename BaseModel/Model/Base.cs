using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.Model
{
    /// <summary>
    /// crud for all of derived data class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Base<T> where T : BaseEntity
    {
        protected List<T> _list;
        private object _obj = new object();

        public Base(List<T> list)
        {
            this._list = list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal virtual List<T> SelectAll()
        {
            List<T> ret;
            lock (_obj)
            {
                ret = new List<T>();
                foreach (var item in _list)
                    ret.Add(this.Clone(item));
            }
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        internal virtual T Select(string key)
        {
            lock (_obj)
            { 
                return _list.FirstOrDefault(c => c.Key == key);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        internal virtual void Insert(List<T> list)
        {
            lock (_obj) { 
                _list.AddRange(list);
            }
        }

        /// <summary>
        /// 引数で受け取った要素とキーが一致する要素を上書きする
        /// </summary>
        /// <param name="list"></param>
        internal virtual void Update(List<T> list)
        {
            // todo : implement something to update procedure
        }

        /// <summary>
        /// 引数で受け取った要素とキーが一致する要素を削除する
        /// </summary>
        /// <param name="list"></param>
        internal virtual void Delete(List<T> list)
        {
            lock (_obj)
            {
                // todo : implement something to delete procedure
            }
        }

        // todo : add delete insert method at once (during semaphore)

        // refer to : http://smdn.jp/programming/netfx/cloning/
        private T Clone(T t)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                binaryFormatter.Serialize(stream, t);
                stream.Seek(0, SeekOrigin.Begin);
                return binaryFormatter.Deserialize(stream) as T;
            }
        }
    }
    }
}
