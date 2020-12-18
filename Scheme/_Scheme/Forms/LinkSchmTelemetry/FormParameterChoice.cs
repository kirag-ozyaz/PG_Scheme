using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;

namespace Scheme.Forms.LinkSchmTelemetry
{
	public partial class FormParameterChoice : FormBase
	{
		public FormParameterChoice(SQLSettings SqlSettings, int objId)
		{
			
			this.dataTable_0 = new DataTable();
			
			this.method_0();
			this.SqlSettings = SqlSettings;
			this.ParameterId = -1;
			SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString());
			SqlCommand sqlCommand = new SqlCommand("SELECT [TypeCodeId] from [tSchm_ObjList] WHERE [Id] = " + objId.ToString(), sqlConnection);
			sqlConnection.Open();
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			int num = -1;
			string str = string.Empty;
			if (sqlDataReader.Read())
			{
				num = (int)sqlDataReader[0];
			}
			sqlDataReader.Close();
			if (num <= 563)
			{
				if (num <= 84)
				{
					if (num == 79)
					{
						goto IL_1FB;
					}
					if (num != 84)
					{
						goto IL_1EE;
					}
					goto IL_1CD;
				}
				else
				{
					if (num == 95)
					{
						goto IL_20D;
					}
					switch (num)
					{
					case 535:
					case 536:
					case 537:
					case 538:
						goto IL_1FB;
					case 539:
					case 542:
					case 543:
					case 544:
					case 545:
					case 546:
					case 547:
					case 548:
					case 549:
					case 551:
					case 555:
					case 557:
						goto IL_1EE;
					case 540:
					case 541:
						goto IL_1CD;
					case 550:
						break;
					case 552:
					case 553:
					case 554:
					case 558:
					case 559:
						goto IL_20D;
					case 556:
						goto IL_204;
					default:
						if (num != 563)
						{
							goto IL_1EE;
						}
						goto IL_1CD;
					}
				}
			}
			else if (num <= 903)
			{
				if (num == 564)
				{
					goto IL_1CD;
				}
				switch (num)
				{
				case 653:
				case 654:
				case 668:
				case 669:
				case 670:
					goto IL_1CD;
				case 655:
				case 656:
				case 657:
				case 658:
				case 659:
				case 660:
				case 661:
				case 662:
				case 663:
				case 664:
				case 665:
				case 666:
				case 667:
					goto IL_1EE;
				case 671:
				case 672:
				case 673:
				case 674:
				case 675:
				case 676:
				case 677:
				case 678:
				case 679:
					break;
				default:
					if (num != 903)
					{
						goto IL_1EE;
					}
					goto IL_20D;
				}
			}
			else
			{
				if (num == 975)
				{
					goto IL_20D;
				}
				if (num == 976)
				{
					goto IL_204;
				}
				if (num != 1034)
				{
					goto IL_1EE;
				}
				goto IL_1FB;
			}
			str = "Ячейка";
			goto IL_214;
			IL_1CD:
			str = "Секция шин";
			goto IL_214;
			IL_1EE:
			this.comboBox_0.Enabled = false;
			return;
			IL_1FB:
			str = "Подстанция";
			goto IL_214;
			IL_204:
			str = "Трансформатор";
			goto IL_214;
			IL_20D:
			str = "Коммутационный аппарат";
			IL_214:
			sqlCommand.CommandText = "SELECT [Id], [Description] FROM [OPC_Config].[dbo].[Parameters] WHERE [ObjectDescription] like " + str;
			sqlDataReader = sqlCommand.ExecuteReader();
			this.dataTable_0.Load(sqlDataReader);
			sqlDataReader.Close();
			sqlConnection.Close();
			this.comboBox_0.DataSource = this.dataTable_0;
			this.comboBox_0.DisplayMember = "[Description]";
			this.comboBox_0.ValueMember = "[Id]";
		}

		public int ParameterId { get; set; }

		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ParameterId = (int)this.comboBox_0.SelectedValue;
		}

		private void method_0()
		{
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_0 = new Label();
			this.comboBox_0 = new ComboBox();
			base.SuspendLayout();
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(232, 71);
			this.button_0.Name = "buttonCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.DialogResult = DialogResult.OK;
			this.button_1.Location = new Point(151, 71);
			this.button_1.Name = "buttonOk";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 0;
			this.button_1.Text = "ОК";
			this.button_1.UseVisualStyleBackColor = true;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 9);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(109, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Выберите параметр";
			this.comboBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(12, 35);
			this.comboBox_0.Name = "comboBox1";
			this.comboBox_0.Size = new Size(295, 21);
			this.comboBox_0.TabIndex = 2;
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(319, 106);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormParameterChoice";
			base.ShowIcon = false;
			this.Text = "Выбор параметра";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void FsEAfKUMOMgvuB7c3Xt(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private DataTable dataTable_0;

		[CompilerGenerated]
		private int int_0;

		private Button button_0;

		private Button button_1;

		private Label label_0;

		private ComboBox comboBox_0;
	}
}
