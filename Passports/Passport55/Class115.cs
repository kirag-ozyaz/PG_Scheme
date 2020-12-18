using System;
using System.Windows.Forms;
using DataSql;

internal static class Class115
{
	internal static bool smethod_0(SQLSettings sqlsettings_0, int int_0, int int_1, DateTime dateTime_0, string string_0, string string_1, int int_2, string string_2)
	{
		int num = -1;
		string string_3 = "";
		string string_4 = "";
		string string_5 = "";
		string string_6 = "";
		Class116 @class = new Class116(sqlsettings_0);
		bool result;
		try
		{
			if (@class.method_7(int_0))
			{
				num = @class.method_11(int_0);
				@class.method_18(int_0, num, out string_3, out string_4);
				@class.method_19(int_0, out string_5, out string_6);
				if (!@class.method_22(num, int_0))
				{
					throw new Exception("Move to substation errors.", new Exception("Delete node in xml transformer caused the exception. FormTransMove.cs Line: ###"));
				}
			}
			int int_3;
			int int_4;
			int int_5;
			@class.method_17(int_0, out int_3, out int_4, out int_5);
			if (!@class.method_25(int_1, int_0))
			{
				throw new Exception("Move to substation errors.", new Exception("Update data in tSchm_ObjList caused the exception. FormTransMove.cs Line: ###"));
			}
			if (!@class.method_20(int_0, int_3, num, int_4, int_5, string_3, string_4, string_5, string_6, dateTime_0, int_2, string_1, string_2, false))
			{
				throw new Exception("Move to substation errors.", new Exception("Insert data in tSchm_Move caused the exception. FormTransMove.cs Line: ###"));
			}
			@class.method_4();
			@class.method_0();
			result = true;
		}
		catch (Exception)
		{
			@class.method_5();
			@class.method_0();
			result = false;
		}
		finally
		{
			@class.method_0();
		}
		return result;
	}

	internal static bool smethod_1(SQLSettings sqlsettings_0, int int_0, string string_0, DateTime dateTime_0, int int_1, string string_1, int int_2, string string_2)
	{
		int num = -1;
		string string_3 = "";
		string string_4 = "";
		string string_5 = "";
		string string_6 = "";
		Class116 @class = new Class116(sqlsettings_0);
		bool result;
		try
		{
			if (!@class.method_8(int_1))
			{
				if (@class.method_7(int_0))
				{
					num = @class.method_11(int_0);
					@class.method_18(int_0, num, out string_3, out string_4);
					@class.method_19(int_0, out string_5, out string_6);
					if (!@class.method_22(num, int_0))
					{
						throw new Exception("Move to substation errors.", new Exception("Delete node in xml transformer caused the exception. FormTransMove.cs Line: ###"));
					}
				}
				if (!@class.method_9(int_0))
				{
					int int_3 = @class.method_13(int_1);
					@class.method_23(int_0, int_3);
				}
				int int_4;
				int int_5;
				int int_6;
				@class.method_17(int_0, out int_4, out int_5, out int_6);
				int int_7 = @class.method_14(int_1);
				int int_8 = @class.method_10(int_1);
				if (!@class.method_21(int_1, int_8, int_0))
				{
					throw new Exception("Move to substation errors.", new Exception("Insert node in xml transformer caused the exception. FormTransMove.cs Line: ###"));
				}
				string string_7 = @class.method_16(int_1);
				if (!@class.method_26(int_0, int_8, int_7, string_0))
				{
					throw new Exception("Move to substation errors.", new Exception("Update data in tSchm_ObjList caused the exception. FormTransMove.cs Line: ###"));
				}
				if (!@class.method_20(int_0, int_4, num, int_5, int_6, string_3, string_4, string_5, string_6, dateTime_0, 863, string_7, string_2, false))
				{
					throw new Exception("Move to substation errors.", new Exception("Insert data in tSchm_Move caused the exception. FormTransMove.cs Line: ###"));
				}
				@class.method_4();
				result = true;
			}
			else
			{
				MessageBox.Show("На данной ячейке уже существует трансформатор. Пожалуйста, выберите другую ячейку", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				@class.method_5();
				@class.method_0();
				result = false;
			}
		}
		catch (Exception)
		{
			@class.method_5();
			@class.method_0();
			result = false;
		}
		finally
		{
			@class.method_0();
		}
		return result;
	}

	internal static bool smethod_2(SQLSettings sqlsettings_0, int int_0)
	{
		return true;
	}

	internal static bool smethod_3(SQLSettings sqlsettings_0, int int_0, DateTime dateTime_0, string string_0)
	{
		int num = -1;
		string string_ = "";
		string string_2 = "";
		string string_3 = "";
		string string_4 = "";
		Class116 @class = new Class116(sqlsettings_0);
		bool result;
		try
		{
			if (@class.method_7(int_0))
			{
				num = @class.method_11(int_0);
				@class.method_18(int_0, num, out string_, out string_2);
				@class.method_19(int_0, out string_3, out string_4);
				if (!@class.method_22(num, int_0))
				{
					throw new Exception("Move to substation errors.", new Exception("Delete node in xml transformer caused the exception. FormTransMove.cs Line: ###"));
				}
			}
			int int_;
			int int_2;
			int int_3;
			@class.method_17(int_0, out int_, out int_2, out int_3);
			int int_4 = @class.method_12(";Passport;ObjLocation;", 5.0);
			int int_5 = @class.method_12(";Passport;MoveAction;", 2.0);
			if (!@class.method_24(int_4, int_0))
			{
				throw new Exception("Dispose to substation errors.", new Exception("Update objList caused the exception. FormTransMove.cs Line: ###"));
			}
			if (!@class.method_20(int_0, int_, num, int_2, int_3, string_, string_2, string_3, string_4, dateTime_0, int_5, "Списан", string_0, false))
			{
				throw new Exception("Move to substation errors.", new Exception("Insert data in tSchm_Move caused the exception. FormTransMove.cs Line: ###"));
			}
			@class.method_4();
			@class.method_0();
			result = true;
		}
		catch (Exception)
		{
			@class.method_5();
			@class.method_0();
			result = false;
		}
		finally
		{
			@class.method_0();
		}
		return result;
	}
}
