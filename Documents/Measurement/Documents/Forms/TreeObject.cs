    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

namespace Documents.Measurement
{


    [StructLayout(LayoutKind.Sequential)]
    public struct TreeObject
    {
         public TypeNode TypeNode
        {
            get;
            set;
        }
        public int idBus
        {
            get;
            set;
        }
        public int idSub
        {
            get;
            set;
        }
        public int idTransf
        {
            get;
            set;
        }
        public string NameTransf
        {
            get;
            set;
        }
    }
}

