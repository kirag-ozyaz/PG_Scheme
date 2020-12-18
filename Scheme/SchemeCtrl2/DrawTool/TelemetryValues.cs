using System;

namespace SchemeCtrl2.DrawTool
{
	public struct TelemetryValues
	{
		static TelemetryValues()
		{
			
			TelemetryValues.Empty = default(TelemetryValues);
			TelemetryValues.Empty.float_0 = float.NaN;
			TelemetryValues.Empty.float_1 = float.NaN;
			TelemetryValues.Empty.float_2 = float.NaN;
			TelemetryValues.Empty.float_3 = float.NaN;
			TelemetryValues.Empty.nullable_0 = null;
			TelemetryValues.Empty.nullable_1 = null;
			TelemetryValues.Empty.nullable_2 = null;
			TelemetryValues.Empty.nullable_3 = null;
			TelemetryValues.Empty.nullable_4 = null;
			TelemetryValues.Empty.nullable_5 = null;
			TelemetryValues.Empty.nullable_6 = null;
			TelemetryValues.Empty.nullable_7 = null;
			TelemetryValues.Empty.nullable_8 = null;
			TelemetryValues.Empty.nullable_9 = null;
			TelemetryValues.Empty.nullable_10 = null;
			TelemetryValues.Empty.nullable_11 = null;
		}

		public bool IsEmpty
		{
			get
			{
				return float.IsNaN(this.float_0) && float.IsNaN(this.float_1) && float.IsNaN(this.float_2) && float.IsNaN(this.VoltageUnbalance) && this.SwitchOn == null && this.NoClosureInterfacial == null && this.NoArc == null && this.nullable_5 == null && this.DoorRU04_Closed == null && this.DoorRU10_Closed == null && this.DoorRU10_04_Closed == null && this.NoFire == null && this.IsVoltageAVR == null && this.InVoltageBP == null && this.OutVoltageBP == null && this.Link == null;
			}
		}

		public float AmperageLoad
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public float AmperageGroundFault
		{
			get
			{
				return this.float_1;
			}
			set
			{
				this.float_1 = value;
			}
		}

		public float LineVoltage
		{
			get
			{
				return this.float_2;
			}
			set
			{
				this.float_2 = value;
			}
		}

		public float VoltageUnbalance
		{
			get
			{
				return this.float_3;
			}
			set
			{
				this.float_3 = value;
			}
		}

		public bool? SwitchOn
		{
			get
			{
				return this.nullable_0;
			}
			set
			{
				this.nullable_0 = value;
			}
		}

		public bool? NoClosureInterfacial
		{
			get
			{
				return this.nullable_1;
			}
			set
			{
				this.nullable_1 = value;
			}
		}

		public bool? NoArc
		{
			get
			{
				return this.nullable_2;
			}
			set
			{
				this.nullable_2 = value;
			}
		}

		public bool? DoorRU10_Closed
		{
			get
			{
				return this.nullable_3;
			}
			set
			{
				this.nullable_3 = value;
			}
		}

		public bool? DoorRU04_Closed
		{
			get
			{
				return this.nullable_4;
			}
			set
			{
				this.nullable_4 = value;
			}
		}

		public bool? DoorCHSD_Closed
		{
			get
			{
				return this.nullable_5;
			}
			set
			{
				this.nullable_5 = value;
			}
		}

		public bool? DoorRU10_04_Closed
		{
			get
			{
				return this.nullable_6;
			}
			set
			{
				this.nullable_6 = value;
			}
		}

		public bool? NoFire
		{
			get
			{
				return this.nullable_7;
			}
			set
			{
				this.nullable_7 = value;
			}
		}

		public bool? IsVoltageAVR
		{
			get
			{
				return this.nullable_8;
			}
			set
			{
				this.nullable_8 = value;
			}
		}

		public bool? InVoltageBP
		{
			get
			{
				return this.nullable_9;
			}
			set
			{
				this.nullable_9 = value;
			}
		}

		public bool? OutVoltageBP
		{
			get
			{
				return this.nullable_10;
			}
			set
			{
				this.nullable_10 = value;
			}
		}

		public bool? Link
		{
			get
			{
				return this.nullable_11;
			}
			set
			{
				this.nullable_11 = value;
			}
		}

		private float float_0;

		private float float_1;

		private float float_2;

		private float float_3;

		private bool? nullable_0;

		private bool? nullable_1;

		private bool? nullable_2;

		private bool? nullable_3;

		private bool? nullable_4;

		private bool? nullable_5;

		private bool? nullable_6;

		private bool? nullable_7;

		private bool? nullable_8;

		private bool? nullable_9;

		private bool? nullable_10;

		private bool? nullable_11;

		public static TelemetryValues Empty;
	}
}
