using System;
using System.Data;
using Passport.Forms.Documents;

internal class Class7
{
	internal Class7(GInterface0 ginterface0_1, int int_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.ginterface0_0 = ginterface0_1;
		Class7.int_0 = int_1;
		this.method_2();
	}

	private bool method_0(int int_1, int int_2, ref string string_0)
	{
		if (this.method_5(0, int_1))
		{
			string_0 = this.struct1_0[0].dataTable_0.Rows[int_1 % Class7.int_0][int_2].ToString();
			return true;
		}
		if (this.method_5(1, int_1))
		{
			string_0 = this.struct1_0[1].dataTable_0.Rows[int_1 % Class7.int_0][int_2].ToString();
			return true;
		}
		return false;
	}

	internal string method_1(int int_1, int int_2)
	{
		string result = null;
		if (this.method_0(int_1, int_2, ref result))
		{
			return result;
		}
		return this.method_3(int_1, int_2);
	}

	private void method_2()
	{
		this.struct1_0 = new Class7.Struct1[]
		{
			new Class7.Struct1(this.ginterface0_0.SupplyPageOfData(Class7.Struct1.smethod_0(0), Class7.int_0), 0),
			new Class7.Struct1(this.ginterface0_0.SupplyPageOfData(Class7.Struct1.smethod_0(Class7.int_0), Class7.int_0), Class7.int_0)
		};
	}

	private string method_3(int int_1, int int_2)
	{
		DataTable dataTable_ = this.ginterface0_0.SupplyPageOfData(Class7.Struct1.smethod_0(int_1), Class7.int_0);
		this.struct1_0[this.method_4(int_1)] = new Class7.Struct1(dataTable_, int_1);
		return this.method_1(int_1, int_2);
	}

	private int method_4(int int_1)
	{
		if (int_1 > this.struct1_0[0].method_1() && int_1 > this.struct1_0[1].method_1())
		{
			int num = int_1 - this.struct1_0[0].method_1();
			int num2 = int_1 - this.struct1_0[1].method_1();
			if (num < num2)
			{
				return 1;
			}
			return 0;
		}
		else
		{
			int num3 = this.struct1_0[0].method_0() - int_1;
			int num4 = this.struct1_0[1].method_0() - int_1;
			if (num3 < num4)
			{
				return 1;
			}
			return 0;
		}
	}

	private bool method_5(int int_1, int int_2)
	{
		return int_2 <= this.struct1_0[int_1].method_1() && int_2 >= this.struct1_0[int_1].method_0();
	}

	private static int int_0;

	private Class7.Struct1[] struct1_0;

	private GInterface0 ginterface0_0;

	internal struct Struct1
	{
		internal Struct1(DataTable dataTable_1, int int_2)
		{
			Class330.Mus9JxKz1CNxy();
			this.dataTable_0 = dataTable_1;
			this.int_0 = Class7.Struct1.smethod_0(int_2);
			this.int_1 = Class7.Struct1.smethod_1(int_2);
		}

		internal int method_0()
		{
			return this.int_0;
		}

		internal int method_1()
		{
			return this.int_1;
		}

		internal static int smethod_0(int int_2)
		{
			return int_2 / Class7.int_0 * Class7.int_0;
		}

		internal static int smethod_1(int int_2)
		{
			return Class7.Struct1.smethod_0(int_2) + Class7.int_0 - 1;
		}

		internal DataTable dataTable_0;

		private int int_0;

		private int int_1;
	}
}
