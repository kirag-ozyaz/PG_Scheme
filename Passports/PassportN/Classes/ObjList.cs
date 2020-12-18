using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using DataSql;

namespace Passport.Classes
{
	public class ObjList
	{
		public ObjList()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		public ObjList(SQLSettings settings)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.SqlSettings = settings;
		}

		public event EventHandler<ObjListEventArgs> ObjListChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler<ObjListEventArgs> eventHandler = this.eventHandler_0;
				EventHandler<ObjListEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ObjListEventArgs> value2 = (EventHandler<ObjListEventArgs>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<ObjListEventArgs>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<ObjListEventArgs> eventHandler = this.eventHandler_0;
				EventHandler<ObjListEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ObjListEventArgs> value2 = (EventHandler<ObjListEventArgs>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<ObjListEventArgs>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		protected virtual void OnObjListChanged(ObjListEventArgs e)
		{
			EventHandler<ObjListEventArgs> eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		public int Id
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				this.method_0();
				this.OnObjListChanged(new ObjListEventArgs(this.int_0));
			}
		}

		public string Name { get; private set; }

		public string FullName { get; private set; }

		public int IdLocation { get; private set; }

		public int TypeCodeId { get; private set; }

		public int IdParent { get; private set; }

		public int IdParentAddl { get; private set; }

		public int IdPassport { get; private set; }

		public int IdGroup { get; private set; }

		public string ClassifierName { get; private set; }

		public string ClassifierSocrName { get; private set; }

		public string ParentKey { get; private set; }

		public decimal ClassifierValue { get; private set; }

		public TypeObjList Type { get; private set; }

		public TypeObjListGroup GroupType { get; private set; }

		private void method_0()
		{
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("SELECT * FROM vP_GetObjListData WHERE id = {0}", this.int_0));
			if (dataTable.Rows.Count > 0)
			{
				this.Name = dataTable.Rows[0]["Name"].ToString();
				this.FullName = ((dataTable.Rows[0]["SocrName"].ToString().Length > 0) ? (dataTable.Rows[0]["SocrName"].ToString() + "-" + dataTable.Rows[0]["Name"].ToString()) : dataTable.Rows[0]["Name"].ToString());
				this.TypeCodeId = ((dataTable.Rows[0]["TypeCodeId"] == DBNull.Value) ? -1 : ((int)dataTable.Rows[0]["TypeCodeId"]));
				this.IdLocation = ((dataTable.Rows[0]["Location"] == DBNull.Value) ? -1 : ((int)dataTable.Rows[0]["Location"]));
				this.IdParent = ((dataTable.Rows[0]["IdParent"] == DBNull.Value) ? -1 : ((int)dataTable.Rows[0]["IdParent"]));
				this.IdParentAddl = ((dataTable.Rows[0]["IdParentAddl"] == DBNull.Value) ? -1 : ((int)dataTable.Rows[0]["IdParentAddl"]));
				this.IdPassport = ((dataTable.Rows[0]["IdPassport"] == DBNull.Value) ? -1 : ((int)dataTable.Rows[0]["IdPassport"]));
				this.IdGroup = ((dataTable.Rows[0]["IdGroup"] == DBNull.Value) ? -1 : ((int)dataTable.Rows[0]["IdGroup"]));
				this.ClassifierName = dataTable.Rows[0]["ClassifierName"].ToString();
				this.ClassifierSocrName = dataTable.Rows[0]["SocrName"].ToString();
				this.ParentKey = dataTable.Rows[0]["ParentKey"].ToString();
				this.ClassifierValue = ((dataTable.Rows[0]["Value"] == DBNull.Value) ? -1m : ((decimal)dataTable.Rows[0]["Value"]));
			}
			else
			{
				this.Name = "";
				this.FullName = "";
				this.TypeCodeId = -1;
				this.IdLocation = -1;
				this.IdParent = -1;
				this.IdParentAddl = -1;
				this.IdPassport = -1;
				this.IdGroup = -1;
				this.ClassifierName = "";
				this.ClassifierSocrName = "";
				this.ParentKey = "";
				this.ClassifierValue = -1m;
			}
			this.method_1();
		}

		private void method_1()
		{
			this.Type = ObjList.GetType(this.ParentKey, this.ClassifierValue);
			this.GroupType = ObjList.GetGroupType(this.ParentKey);
		}

		public static TypeObjList GetType(string parentKey, decimal classifierValue)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(parentKey);
			if (num <= 1824009846u)
			{
				if (num <= 619851038u)
				{
					if (num != 244801998u)
					{
						if (num != 306514569u)
						{
							if (num != 619851038u)
							{
								return TypeObjList.None;
							}
							if (parentKey == ";SCM;Clutch;")
							{
								return ObjList.GetClutchType(classifierValue);
							}
							return TypeObjList.None;
						}
						else
						{
							if (parentKey == ";SCM;INLINE_OBJ;SWITCH;")
							{
								return ObjList.GetSwitchType(classifierValue);
							}
							return TypeObjList.None;
						}
					}
					else
					{
						if (!(parentKey == ";SCM;BUS;BUSLV;"))
						{
							return TypeObjList.None;
						}
						goto IL_1AE;
					}
				}
				else if (num <= 1209073615u)
				{
					if (num != 748583216u)
					{
						if (num != 1209073615u)
						{
							return TypeObjList.None;
						}
						if (!(parentKey == ";SCM;Cell;CellMV;"))
						{
							return TypeObjList.None;
						}
					}
					else if (!(parentKey == ";SCM;Cell;CellLV;"))
					{
						return TypeObjList.None;
					}
				}
				else if (num != 1762496807u)
				{
					if (num != 1824009846u)
					{
						return TypeObjList.None;
					}
					if (parentKey == ";SCM;SwGear;")
					{
						return ObjList.GetSwGearType(classifierValue);
					}
					return TypeObjList.None;
				}
				else
				{
					if (parentKey == ";SCM;Pole;")
					{
						return ObjList.GetPoleType(classifierValue);
					}
					return TypeObjList.None;
				}
			}
			else if (num <= 3247993878u)
			{
				if (num <= 2186602028u)
				{
					if (num != 1913166004u)
					{
						if (num != 2186602028u)
						{
							return TypeObjList.None;
						}
						if (!(parentKey == ";SCM;Cell;CellHV;"))
						{
							return TypeObjList.None;
						}
					}
					else
					{
						if (parentKey == ";SCM;CP;")
						{
							return TypeObjList.PointConnecting;
						}
						return TypeObjList.None;
					}
				}
				else if (num != 2863170221u)
				{
					if (num != 3247993878u)
					{
						return TypeObjList.None;
					}
					if (parentKey == ";SCM;INLINE_OBJ;FUSE;")
					{
						return TypeObjList.SwitchFuse;
					}
					return TypeObjList.None;
				}
				else
				{
					if (!(parentKey == ";SCM;BUS;BUSMV;"))
					{
						return TypeObjList.None;
					}
					goto IL_1AE;
				}
			}
			else if (num <= 3830252874u)
			{
				if (num != 3685938186u)
				{
					if (num != 3830252874u)
					{
						return TypeObjList.None;
					}
					if (parentKey == ";SCM;BUS;BUSHV;")
					{
						goto IL_1AE;
					}
					return TypeObjList.None;
				}
				else
				{
					if (parentKey == ";SCM;PS;")
					{
						return ObjList.GetSubstationType(classifierValue);
					}
					return TypeObjList.None;
				}
			}
			else if (num != 3937203273u)
			{
				if (num == 3966524927u && parentKey == ";SCM;Line;")
				{
					return ObjList.GetLineType(classifierValue);
				}
				return TypeObjList.None;
			}
			else
			{
				if (!(parentKey == ";SCM;INLINE_OBJ;OTHER_OBJ;"))
				{
					return TypeObjList.None;
				}
				return TypeObjList.SwitchOther;
			}
			return ObjList.GetCellType(classifierValue);
			IL_1AE:
			return ObjList.GetBusType(classifierValue);
		}

		public static TypeObjListGroup GetGroupType(string parentKey)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(parentKey);
			if (num <= 1824009846u)
			{
				if (num <= 619851038u)
				{
					if (num != 244801998u)
					{
						if (num != 306514569u)
						{
							if (num != 619851038u)
							{
								return TypeObjListGroup.None;
							}
							if (parentKey == ";SCM;Clutch;")
							{
								return TypeObjListGroup.Clutches;
							}
							return TypeObjListGroup.None;
						}
						else
						{
							if (parentKey == ";SCM;INLINE_OBJ;SWITCH;")
							{
								return TypeObjListGroup.Switches;
							}
							return TypeObjListGroup.None;
						}
					}
					else
					{
						if (!(parentKey == ";SCM;BUS;BUSLV;"))
						{
							return TypeObjListGroup.None;
						}
						return TypeObjListGroup.Buses;
					}
				}
				else if (num <= 1209073615u)
				{
					if (num != 748583216u)
					{
						if (num != 1209073615u)
						{
							return TypeObjListGroup.None;
						}
						if (!(parentKey == ";SCM;Cell;CellMV;"))
						{
							return TypeObjListGroup.None;
						}
					}
					else if (!(parentKey == ";SCM;Cell;CellLV;"))
					{
						return TypeObjListGroup.None;
					}
				}
				else if (num != 1762496807u)
				{
					if (num != 1824009846u)
					{
						return TypeObjListGroup.None;
					}
					if (parentKey == ";SCM;SwGear;")
					{
						return TypeObjListGroup.SwGearses;
					}
					return TypeObjListGroup.None;
				}
				else
				{
					if (parentKey == ";SCM;Pole;")
					{
						return TypeObjListGroup.Poles;
					}
					return TypeObjListGroup.None;
				}
			}
			else if (num <= 3247993878u)
			{
				if (num <= 2186602028u)
				{
					if (num != 1913166004u)
					{
						if (num != 2186602028u)
						{
							return TypeObjListGroup.None;
						}
						if (!(parentKey == ";SCM;Cell;CellHV;"))
						{
							return TypeObjListGroup.None;
						}
					}
					else
					{
						if (parentKey == ";SCM;CP;")
						{
							return TypeObjListGroup.PointConnectes;
						}
						return TypeObjListGroup.None;
					}
				}
				else if (num != 2863170221u)
				{
					if (num != 3247993878u)
					{
						return TypeObjListGroup.None;
					}
					if (parentKey == ";SCM;INLINE_OBJ;FUSE;")
					{
						return TypeObjListGroup.SwitchFuses;
					}
					return TypeObjListGroup.None;
				}
				else
				{
					if (!(parentKey == ";SCM;BUS;BUSMV;"))
					{
						return TypeObjListGroup.None;
					}
					return TypeObjListGroup.Buses;
				}
			}
			else if (num <= 3830252874u)
			{
				if (num != 3685938186u)
				{
					if (num != 3830252874u)
					{
						return TypeObjListGroup.None;
					}
					if (parentKey == ";SCM;BUS;BUSHV;")
					{
						return TypeObjListGroup.Buses;
					}
					return TypeObjListGroup.None;
				}
				else
				{
					if (parentKey == ";SCM;PS;")
					{
						return TypeObjListGroup.Substations;
					}
					return TypeObjListGroup.None;
				}
			}
			else if (num != 3937203273u)
			{
				if (num == 3966524927u && parentKey == ";SCM;Line;")
				{
					return TypeObjListGroup.Lines;
				}
				return TypeObjListGroup.None;
			}
			else
			{
				if (!(parentKey == ";SCM;INLINE_OBJ;OTHER_OBJ;"))
				{
					return TypeObjListGroup.None;
				}
				return TypeObjListGroup.SwitchOthers;
			}
			return TypeObjListGroup.Cells;
		}

		public static string GetParentKey(TypeObjList value)
		{
			switch (value)
			{
			default:
				return "";
			case TypeObjList.LineCable:
			case TypeObjList.LineAir:
			case TypeObjList.LineProtectedAir:
			case TypeObjList.LineMixed:
				return ";SCM;Line;";
			case TypeObjList.ClutchEnd:
			case TypeObjList.ClutchConnecting:
				return ";SCM;Clutch;";
			case TypeObjList.SwitchAuto:
			case TypeObjList.SwitchVacuum:
			case TypeObjList.SwitchLoad:
			case TypeObjList.SwitchGround:
			case TypeObjList.SwitchEnd:
			case TypeObjList.SwitchLine:
			case TypeObjList.SwitchOil:
			case TypeObjList.SwitchLineOut:
			case TypeObjList.SwitchDamageCable:
			case TypeObjList.const_16:
			case TypeObjList.SwitchTransf:
			case TypeObjList.SwitchTransfCurrent:
			case TypeObjList.SwitchTransfVoltage:
				return ";SCM;INLINE_OBJ;SWITCH;";
			case TypeObjList.SwitchFuse:
				return ";SCM;INLINE_OBJ;FUSE;";
			case TypeObjList.SwitchOther:
				return ";SCM;INLINE_OBJ;OTHER_OBJ;";
			case TypeObjList.PoleEnd:
			case TypeObjList.PoleIntermediate:
			case TypeObjList.PoleJunction:
			case TypeObjList.PoleAngle:
				return ";SCM;Pole;";
			case TypeObjList.SubstationTransformer:
			case TypeObjList.SubstationTransitional:
			case TypeObjList.SubstationConnecting:
			case TypeObjList.SubstationDistribution:
			case TypeObjList.SubstationCenter:
				return ";SCM;PS;";
			case TypeObjList.const_31:
			case TypeObjList.SwGear04:
			case TypeObjList.SwGear10:
			case TypeObjList.const_34:
			case TypeObjList.SwGear35:
			case TypeObjList.SwGear6:
				return ";SCM;SwGear;";
			case TypeObjList.PointConnecting:
				return ";SCM;CP;";
			case TypeObjList.Bus023:
			case TypeObjList.Bus04:
				return ";SCM;BUS;BUSLV;";
			case TypeObjList.Bus10:
			case TypeObjList.Bus35:
			case TypeObjList.Bus6:
				return ";SCM;BUS;BUSMV;";
			case TypeObjList.Bus110:
				return ";SCM;BUS;BUSHV;";
			case TypeObjList.Cell023:
			case TypeObjList.Cell04:
				return ";SCM;Cell;CellLV;";
			case TypeObjList.Cell10:
			case TypeObjList.Cell35:
			case TypeObjList.Cell6:
				return ";SCM;Cell;CellMV;";
			case TypeObjList.Cell110:
				return ";SCM;Cell;CellHV;";
			}
		}

		public static TypeObjList GetCellType(decimal classifierValue)
		{
			if (classifierValue == Convert.ToDecimal(0.23))
			{
				return TypeObjList.Cell023;
			}
			if (classifierValue == Convert.ToDecimal(0.4))
			{
				return TypeObjList.Cell04;
			}
			if (classifierValue == 10m)
			{
				return TypeObjList.Cell10;
			}
			if (classifierValue == 110m)
			{
				return TypeObjList.Cell110;
			}
			if (classifierValue == 35m)
			{
				return TypeObjList.Cell35;
			}
			if (classifierValue == 6m)
			{
				return TypeObjList.Cell6;
			}
			return TypeObjList.None;
		}

		public static TypeObjList GetBusType(decimal classifierValue)
		{
			if (classifierValue == Convert.ToDecimal(0.23))
			{
				return TypeObjList.Bus023;
			}
			if (classifierValue == Convert.ToDecimal(0.4))
			{
				return TypeObjList.Bus04;
			}
			if (classifierValue == 10m)
			{
				return TypeObjList.Bus10;
			}
			if (classifierValue == 110m)
			{
				return TypeObjList.Bus110;
			}
			if (classifierValue == 35m)
			{
				return TypeObjList.Bus35;
			}
			if (classifierValue == 6m)
			{
				return TypeObjList.Bus6;
			}
			return TypeObjList.None;
		}

		public static TypeObjList GetSwGearType(decimal classifierValue)
		{
			if (classifierValue == Convert.ToDecimal(0.23))
			{
				return TypeObjList.const_31;
			}
			if (classifierValue == Convert.ToDecimal(0.4))
			{
				return TypeObjList.SwGear04;
			}
			if (classifierValue == 10m)
			{
				return TypeObjList.SwGear10;
			}
			if (classifierValue == 110m)
			{
				return TypeObjList.const_34;
			}
			if (classifierValue == 35m)
			{
				return TypeObjList.SwGear35;
			}
			if (classifierValue == 6m)
			{
				return TypeObjList.SwGear6;
			}
			return TypeObjList.None;
		}

		public static TypeObjList GetSubstationType(decimal classifierValue)
		{
			if (classifierValue == 1m)
			{
				return TypeObjList.SubstationTransitional;
			}
			if (classifierValue == 2m)
			{
				return TypeObjList.SubstationDistribution;
			}
			if (classifierValue == 3m)
			{
				return TypeObjList.SubstationConnecting;
			}
			if (classifierValue == 4m)
			{
				return TypeObjList.SubstationTransformer;
			}
			if (classifierValue == 5m)
			{
				return TypeObjList.SubstationCenter;
			}
			return TypeObjList.None;
		}

		public static TypeObjList GetPoleType(decimal classifierValue)
		{
			if (classifierValue == 1m)
			{
				return TypeObjList.PoleEnd;
			}
			if (classifierValue == 2m)
			{
				return TypeObjList.PoleIntermediate;
			}
			if (classifierValue == 3m)
			{
				return TypeObjList.PoleJunction;
			}
			if (classifierValue == 4m)
			{
				return TypeObjList.PoleAngle;
			}
			return TypeObjList.None;
		}

		public static TypeObjList GetSwitchType(decimal classifierValue)
		{
			if (classifierValue == 1m)
			{
				return TypeObjList.SwitchAuto;
			}
			if (classifierValue == 2m)
			{
				return TypeObjList.SwitchVacuum;
			}
			if (classifierValue == 3m)
			{
				return TypeObjList.SwitchLoad;
			}
			if (classifierValue == 4m)
			{
				return TypeObjList.SwitchGround;
			}
			if (classifierValue == 5m)
			{
				return TypeObjList.SwitchEnd;
			}
			if (classifierValue == 6m)
			{
				return TypeObjList.SwitchLine;
			}
			if (classifierValue == 7m)
			{
				return TypeObjList.SwitchOil;
			}
			if (classifierValue == 8m)
			{
				return TypeObjList.SwitchLineOut;
			}
			if (classifierValue == 9m)
			{
				return TypeObjList.SwitchDamageCable;
			}
			if (classifierValue == 10m)
			{
				return TypeObjList.const_16;
			}
			if (classifierValue == 11m)
			{
				return TypeObjList.SwitchTransf;
			}
			if (classifierValue == 12m)
			{
				return TypeObjList.SwitchTransfCurrent;
			}
			if (classifierValue == 13m)
			{
				return TypeObjList.SwitchTransfVoltage;
			}
			return TypeObjList.None;
		}

		public static TypeObjList GetClutchType(decimal classifierValue)
		{
			if (classifierValue == 1m)
			{
				return TypeObjList.ClutchEnd;
			}
			if (classifierValue == 2m)
			{
				return TypeObjList.ClutchConnecting;
			}
			return TypeObjList.None;
		}

		public static TypeObjList GetLineType(decimal classifierValue)
		{
			if (classifierValue == 1m)
			{
				return TypeObjList.LineCable;
			}
			if (classifierValue == 2m)
			{
				return TypeObjList.LineAir;
			}
			if (classifierValue == 3m)
			{
				return TypeObjList.LineProtectedAir;
			}
			if (classifierValue == 4m)
			{
				return TypeObjList.LineMixed;
			}
			return TypeObjList.None;
		}

		public static decimal[] GetGroupValue(TypeObjListGroup group)
		{
			switch (group)
			{
			case TypeObjListGroup.Substations:
				return new decimal[]
				{
					1m,
					2m,
					3m,
					4m,
					5m,
					6m
				};
			case TypeObjListGroup.Clutches:
				return new decimal[]
				{
					1m,
					2m
				};
			case TypeObjListGroup.Lines:
				return new decimal[]
				{
					1m,
					2m,
					3m,
					4m
				};
			case TypeObjListGroup.CableLines:
				return new decimal[]
				{
					1m
				};
			case TypeObjListGroup.AirLines:
				return new decimal[]
				{
					2m,
					3m
				};
			case TypeObjListGroup.SwGearses:
			case TypeObjListGroup.Buses:
			case TypeObjListGroup.Cells:
				return new decimal[]
				{
					0.23m,
					0.4m,
					6m,
					10m,
					35m,
					110m
				};
			case TypeObjListGroup.Switches:
				return new decimal[]
				{
					1m,
					2m,
					3m,
					6m,
					7m,
					8m
				};
			case TypeObjListGroup.SwitchFuses:
				return new decimal[]
				{
					1m
				};
			case TypeObjListGroup.SwitchOthers:
				return new decimal[]
				{
					1m
				};
			case TypeObjListGroup.Poles:
				return new decimal[]
				{
					1m,
					2m,
					3m,
					4m
				};
			case TypeObjListGroup.PointConnectes:
				return new decimal[]
				{
					1m
				};
			case TypeObjListGroup.Transformer:
				return new decimal[]
				{
					11m
				};
			case TypeObjListGroup.VoltageTransformer:
				return new decimal[]
				{
					13m
				};
			}
			return new decimal[]
			{
				-1m
			};
		}

		public static decimal GetValue(TypeObjList value)
		{
			switch (value)
			{
			default:
				return -1m;
			case TypeObjList.LineCable:
			case TypeObjList.ClutchEnd:
			case TypeObjList.SwitchAuto:
			case TypeObjList.SwitchFuse:
			case TypeObjList.SwitchOther:
			case TypeObjList.PoleEnd:
			case TypeObjList.SubstationTransitional:
			case TypeObjList.PointConnecting:
				return 1m;
			case TypeObjList.LineAir:
			case TypeObjList.ClutchConnecting:
			case TypeObjList.SwitchVacuum:
			case TypeObjList.PoleIntermediate:
			case TypeObjList.SubstationDistribution:
				return 2m;
			case TypeObjList.LineProtectedAir:
			case TypeObjList.SwitchLoad:
			case TypeObjList.PoleJunction:
			case TypeObjList.SubstationConnecting:
				return 3m;
			case TypeObjList.LineMixed:
			case TypeObjList.SwitchGround:
			case TypeObjList.PoleAngle:
			case TypeObjList.SubstationTransformer:
				return 4m;
			case TypeObjList.SwitchEnd:
			case TypeObjList.SubstationCenter:
				return 5m;
			case TypeObjList.SwitchLine:
			case TypeObjList.SwGear6:
			case TypeObjList.Bus6:
			case TypeObjList.Cell6:
				return 6m;
			case TypeObjList.SwitchOil:
				return 7m;
			case TypeObjList.SwitchLineOut:
				return 8m;
			case TypeObjList.SwitchDamageCable:
				return 9m;
			case TypeObjList.const_16:
			case TypeObjList.SwGear10:
			case TypeObjList.Bus10:
			case TypeObjList.Cell10:
				return 10m;
			case TypeObjList.SwitchTransf:
				return 11m;
			case TypeObjList.SwitchTransfCurrent:
				return 12m;
			case TypeObjList.SwitchTransfVoltage:
				return 13m;
			case TypeObjList.const_31:
			case TypeObjList.Bus023:
			case TypeObjList.Cell023:
				return 0.23m;
			case TypeObjList.SwGear04:
			case TypeObjList.Bus04:
			case TypeObjList.Cell04:
				return 0.4m;
			case TypeObjList.const_34:
			case TypeObjList.Bus110:
			case TypeObjList.Cell110:
				return 110m;
			case TypeObjList.SwGear35:
			case TypeObjList.Bus35:
			case TypeObjList.Cell35:
				return 35m;
			}
		}

		public static string GetGroupParentKey(TypeObjListGroup group)
		{
			switch (group)
			{
			case TypeObjListGroup.Substations:
				return ";SCM;PS;";
			case TypeObjListGroup.Clutches:
				return ";SCM;Clutch;";
			case TypeObjListGroup.Lines:
			case TypeObjListGroup.CableLines:
			case TypeObjListGroup.AirLines:
				return ";SCM;Line;";
			case TypeObjListGroup.SwGearses:
				return ";SCM;SwGear;";
			case TypeObjListGroup.Buses:
				return ";SCM;BUS;";
			case TypeObjListGroup.Cells:
				return ";SCM;Cell;";
			case TypeObjListGroup.Switches:
			case TypeObjListGroup.Transformer:
				return ";SCM;INLINE_OBJ;SWITCH;";
			case TypeObjListGroup.SwitchFuses:
				return ";SCM;INLINE_OBJ;FUSE;";
			case TypeObjListGroup.SwitchOthers:
				return ";SCM;INLINE_OBJ;OTHER_OBJ;";
			case TypeObjListGroup.Poles:
				return ";SCM;Pole;";
			case TypeObjListGroup.PointConnectes:
				return ";SCM;CP;";
			}
			return "NONE";
		}

		public static int GetTypeId(SQLSettings settings, TypeObjList value)
		{
			DataTable dataTable = new SqlDataCommand(settings).SelectSqlData(string.Format("SELECT id FROM tR_Classifier WHERE ParentKey LIKE '{0}' AND Value = {1} AND isGroup = ((0))", ObjList.GetParentKey(value), ObjList.GetValue(value).ToString().Replace(',', '.')));
			if (dataTable.Rows.Count <= 0)
			{
				return -1;
			}
			return (int)dataTable.Rows[0]["id"];
		}

		public SQLSettings SqlSettings;

		private int int_0;

		[CompilerGenerated]
		private EventHandler<ObjListEventArgs> eventHandler_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private int int_4;

		[CompilerGenerated]
		private int int_5;

		[CompilerGenerated]
		private int int_6;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private string string_4;

		[CompilerGenerated]
		private decimal decimal_0;

		[CompilerGenerated]
		private TypeObjList typeObjList_0;

		[CompilerGenerated]
		private TypeObjListGroup typeObjListGroup_0;
	}
}
