using System;
using System.Collections.Generic;

namespace Computer
{
    public class Hdd
    {
        private readonly List<string> records = new List<string>();

        public bool HasRecords
        {
            get { return records.Count > 0; }
        }

        public void Save()
        {
            records.Add(Guid.NewGuid().ToString());
        }

        public List<string> Read()
        {
            return records;
        }

        public void Format()
        {
            records.Clear();
            records.TrimExcess();
        }
    }
}