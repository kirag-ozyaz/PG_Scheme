using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormObjSelect : FormLbr.FormBase
     {
         /// <summary>
         /// Способ выбора
         /// </summary>
         public enum SelectionMethod
         {
             /// <summary>
             /// Один
             /// </summary>
             One,
             /// <summary>
             /// Множество
             /// </summary>
             Many
             
         }

        public int idObjPar = -1;
        public int[] idArray;
        public int IDABN;
        public int PARAM = 0;

        private SelectionMethod SM;

        public FormObjSelect()
        {
            InitializeComponent();
        }
        
        public FormObjSelect(int id, int par, SelectionMethod selM )
        {
            InitializeComponent();
            IDABN = id;
            PARAM = par;
            SM = selM;
        }

        private void FormObjSelect_Load(object sender, EventArgs e)
        {
            switch (SM)
            {
                case SelectionMethod.One:
                    tsObjSelect.Visible = false;
                    buttonSelect.Visible = false;
                    SelectDGVEF.Columns[0].Visible = false;
                    break;
                case SelectionMethod.Many:
                    tsObjSelect.Visible = true;
                    buttonSelect.Visible = true;
                    SelectDGVEF.Columns[0].Visible = true;
                    break;
                default:
                    break;
            }


            if (IDABN == -1)
            {
                this.SelectSqlData(dsObj1, dsObj1.vG_Obj, true, " where (not id is null) and TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and DocNumber is null order By Name ");
            }
            else
            {
                if (PARAM == 0)
                { 
                    this.SelectSqlDataTableOther(dsObj1, dsObj1.vG_Obj, "vG_Obj_NoOwner", true, " order By Name");

                    //this.SelectSqlData(dsObj1, dsObj1.vG_Obj, true, " where idAbn = " + 220863.ToString() + " AND DateEnd IS NOT NULL order By Name");
                }
                else
                {
                    if (PARAM == 100)
                        this.SelectSqlData(dsObj1, dsObj1.vG_Obj, true, " where idAbn = " + IDABN.ToString() + " AND TypeAbn in ( " + Constants.Constants.TypeAbnLegalAll + ") order By Name");
                    else
                        // что-то надо менять 
                        this.SelectSqlData(dsObj1, dsObj1.vG_Obj, true, " where idAbn = " + IDABN.ToString() + "  AND TypeAbn in ( " + Constants.Constants.TypeAbnLegalAll + ")  order By Name");
                    //AND idAbnDog IS NULL AND DateEnd IS NULL
                }
            }
            int ArrayLenght = SelectDGVEF.RowCount;
            idArray = new int[ArrayLenght];
        }

        private void SelectDGVEF_DoubleClick(object sender, EventArgs e)
        {
            idObjPar = Convert.ToInt32(SelectDGVEF.CurrentRow.Cells["id"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectDGVEF.RowCount; i++)
            {
                if (SelectDGVEF.Rows[i].Cells["SelectCell"].Value != null)
                {
                    if ((bool)SelectDGVEF.Rows[i].Cells["SelectCell"].Value == true)
                        idArray[i] = (int)SelectDGVEF.Rows[i].Cells["id"].Value;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectDGVEF.RowCount; i++)
            {
                SelectDGVEF.Rows[i].Cells["SelectCell"].Value = true; 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectDGVEF.RowCount; i++)
            {
                SelectDGVEF.Rows[i].Cells["SelectCell"].Value = false;
            }
        }

    }
}
