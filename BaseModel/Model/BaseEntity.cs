using System;
using System.Runtime.Serialization;

namespace BaseModel.Model
{
    [Serializable]
    public class BaseEntity
    {
        public string Key { get; private set; }

        protected BaseEntity(string key)
        {
            this.Key = key;
        }
    }
}