using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// получатели (Library)
    /// </summary>
    public struct Recipient
    {
        public Recipient(string address, string name)
        {
            this.Address = address;
            this.Name = name;
        }
        public string Address;
        public string Name;
    }
}
