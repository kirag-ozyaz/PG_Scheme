using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Documents.Forms.JournalOrder
{
    internal struct SchmObject
    {
        public SchmObject(int id, string text)
        {

            this.Text = text;
            this.Id = id;
        }

        public override string ToString()
        {
            return this.Text;
        }

        public string Text;

        public int Id;
    }

    internal enum eSearchNode
    {
        First,
        Next,
        Prev
    }
}
