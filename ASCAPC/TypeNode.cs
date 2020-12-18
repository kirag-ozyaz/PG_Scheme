namespace ASCAPC
{

    public enum TypeCodes
    {
        Node // NODE_CODE
   , Object // OBJECT_CODE
    }

    public class TypeNode
    {
        private TypeCodes typeCode;

        public TypeNode()
        {
        }

        public TypeNode(short code, string name, TypeCodes typeCode)
        {
            Code = code;
            TypeCode = typeCode;
            Name = name;
        }

        public TypeNode(short code, string name, TypeCodes typeCode, char mETER_TYPE, double cALC_FACTOR, string codeXML) : this(code, name, typeCode)
        {
            METER_TYPE = mETER_TYPE;
            CALC_FACTOR = cALC_FACTOR;
            XML_CODE = codeXML;
        }

        public TypeNode(short code, string name, TypeCodes typeCode, char mETER_TYPE, double cALC_FACTOR, string codeXML, TypeNode parentTypeNode) : this(code, name, typeCode, mETER_TYPE, cALC_FACTOR, codeXML)
        {
            ParentTypeNode = parentTypeNode;
        }

        public short Code { get; set; } = -1; //  не равно 0
        public TypeCodes TypeCode { get => typeCode; set => typeCode = value; }
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Измерительный канал
        /// P - активный, Q - реактивный
        /// </summary>
        public char METER_TYPE { get; set; } = '\0';// MTRTYPE
        public double CALC_FACTOR { get; set; } = 1;// всегда больше 0
        public string XML_CODE { get; set; } = string.Empty;
        /// <summary>
        /// узел родитель
        /// </summary>
        public TypeNode ParentTypeNode { get; set; } 
    }
}
