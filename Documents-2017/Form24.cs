using Constants;
using Documents.DataSets;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Form24 : FormBase
{
    private BindingSource bindingSource_0;
    private Button button_0;
    private Button button_1;
    private DataSetGES dataSetGES_0;
    private IContainer icontainer_0;
    [CompilerGenerated]
    private int int_0;
    [CompilerGenerated]
    private int int_1;
    private Label label_0;
    [CompilerGenerated]
    private StateFormCreate stateFormCreate_0;
    private TextBox textBox_0;

    internal Form24()
    {
        this.method_2();
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        this.dataSetGES_0.tJ_BossUserGroup.Rows[0].EndEdit();
        if (this.method_0() == null)
        {
            this.dataSetGES_0.tJ_BossUserGroup.Rows[0].EndEdit();
            this.Id = base.InsertSqlDataOneRow(this.dataSetGES_0.tJ_BossUserGroup.Rows[0]);
        }
        else
        {
            this.dataSetGES_0.tJ_BossUserGroup.Rows[0].EndEdit();
            base.UpdateSqlDataOnlyChange(this.dataSetGES_0.tJ_BossUserGroup);
        }
        base.Close();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form24_Load(object sender, EventArgs e)
    {
        if (this.method_0() == null)
        {
            this.Text = "Добавление группы";
            DataSetGES.Class147 class2 = this.dataSetGES_0.tJ_BossUserGroup.method_5();
            if (this.IdParent > 0)
            {
                class2.idParent = this.IdParent;
            }
            class2.Deleted = false;
            this.dataSetGES_0.tJ_BossUserGroup.method_0(class2);
        }
        else
        {
            this.Text = "Редактирование группы";
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_BossUserGroup, true, "WHERE id = " + this.Id.ToString());
        }
    }

    [CompilerGenerated]
    internal StateFormCreate method_0()
    {
        return this.stateFormCreate_0;
    }

    [CompilerGenerated]
    internal void method_1(StateFormCreate stateFormCreate_1)
    {
        this.stateFormCreate_0 = stateFormCreate_1;
    }

    private void method_2()
    {
        this.icontainer_0 = new Container();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetGES_0 = new DataSetGES();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataSetGES_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 15);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x53, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Наименование";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_BossUserGroup.Name", true));
        this.textBox_0.Location = new Point(0x65, 12);
        this.textBox_0.Name = "tbNameGroup";
        this.textBox_0.Size = new Size(0x126, 20);
        this.textBox_0.TabIndex = 1;
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(0xe4, 0x2e);
        this.button_0.Name = "btnAccept";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 2;
        this.button_0.Text = "Добавить";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(320, 0x2e);
        this.button_1.Name = "btnCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 3;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x197, 0x4d);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.Name = "FormAddBossUserGroup";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Добавление группы";
        base.Load += new EventHandler(this.Form24_Load);
        this.dataSetGES_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    internal int Id
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

    internal int IdParent
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
}

