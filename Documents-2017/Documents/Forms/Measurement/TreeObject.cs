namespace Documents.Forms.Measurement
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct TreeObject
    {
        [CompilerGenerated]
        private Documents.Forms.Measurement.TypeNode typeNode_0;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        [CompilerGenerated]
        private int int_2;
        [CompilerGenerated]
        private string string_0;
        public Documents.Forms.Measurement.TypeNode TypeNode
        {
            [CompilerGenerated]
            get
            {
                return this.typeNode_0;
            }
            [CompilerGenerated]
            set
            {
                this.typeNode_0 = value;
            }
        }
        public int idBus
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            set
            {
                this.int_0 = value;
            }
        }
        public int idSub
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            set
            {
                this.int_1 = value;
            }
        }
        public int idTransf
        {
            [CompilerGenerated]
            get
            {
                return this.int_2;
            }
            [CompilerGenerated]
            set
            {
                this.int_2 = value;
            }
        }
        public string NameTransf
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }
    }
}

