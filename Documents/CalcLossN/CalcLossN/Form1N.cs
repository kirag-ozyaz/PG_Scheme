using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSql;

namespace DailyReportN.OtherForms
{
    public partial class Form1N : Form
    {
        public SQLSettings SqlSettings { get; private set; }

        public Form1N()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void OpenDokument(int TypeDoc, int idDoc = -1, bool statusPositioningOnCloseForm = false)
        {

            switch (TypeDoc)
            {
                case (int)eTypeDocuments.DamageSL: // 2254
                case (int)eTypeDocuments.DamageLV: // 1401 или 2254
                    {
                        FormDamageLVAddEdit form4 = new FormDamageLVAddEdit(idDoc, (eTypeDocuments)TypeDoc);
                        form4.SqlSettings = this.SqlSettings;
                        form4.MdiParent = base.MdiParent;
                        form4.SetFormViewMode(statusPositioningOnCloseForm);
                        if (!statusPositioningOnCloseForm)
                        {
                            form4.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                        }
                        form4.Show();
                        break;
                    }
                case (int)eTypeDocuments.DamageHV:// 1402:
                    {
                        FormDamageHVAddEdit form = new FormDamageHVAddEdit(idDoc);
                        form.SqlSettings = this.SqlSettings;
                        form.MdiParent = base.MdiParent;
                        form.SetFormViewMode(statusPositioningOnCloseForm);
                        if (!statusPositioningOnCloseForm)
                        {
                            form.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                        }
                        form.Show();
                        break;
                    }
                case (int)eTypeDocuments.DefectLV:// 1403:
                    break;
                case (int)eTypeDocuments.DefectHV:// 1844:
                    break;
                case (int)eTypeDocuments.ActDetection:// 1874:
                    {
                        Form86 form3 = new Form86(new int?(idDoc));
                        form3.SqlSettings = this.SqlSettings;
                        form3.MdiParent = base.MdiParent;
                        form3.method_1(statusPositioningOnCloseForm);
                        form3.Show();

                        break;
                    }
                default:
                    break;
            }


        }

        private void Dokument_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1N_Load(object sender, EventArgs e)
        {
            //
        }

        private void Form1N_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
