using ControlsLbr.Forms;
using FormLbr;
using FormLbr.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Form25 : FormBase
{
    private BackgroundWorker backgroundWorker_0;
    private Button button_0;
    private DataGridView dataGridView_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
    private FormProgressBar formProgressBar_0;
    private IContainer icontainer_0;
    internal string string_0;
    private TableLayoutPanel tableLayoutPanel_0;

    internal Form25()
    {
        this.method_0();
    }

    private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
    {
        if (string.IsNullOrEmpty(e.Argument.ToString()))
        {
            MessageBox.Show("Пароль не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            try
            {
                Dispatcher.Invoke(this, new AsyncAction(this, (IntPtr) this.method_1));
                e.Result = new Class220(this.string_0).method_17();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, @"Ошибка загрузки списка с\з", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                Dispatcher.Invoke(this, new AsyncAction(this, (IntPtr) this.method_2));
            }
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form25_Load(object sender, EventArgs e)
    {
        this.formProgressBar_0 = new FormProgressBar();
        this.backgroundWorker_0.RunWorkerAsync(this.string_0);
    }

    private void Form25_Shown(object sender, EventArgs e)
    {
    }

    private void method_0()
    {
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
        this.tableLayoutPanel_0 = new TableLayoutPanel();
        this.button_0 = new Button();
        this.backgroundWorker_0 = new BackgroundWorker();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        this.tableLayoutPanel_0.SuspendLayout();
        base.SuspendLayout();
        this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_0, 2);
        this.dataGridView_0.Dock = DockStyle.Fill;
        this.dataGridView_0.Location = new Point(3, 3);
        this.dataGridView_0.Name = "dgvMemorandum";
        this.dataGridView_0.Size = new Size(0x31f, 0x19d);
        this.dataGridView_0.TabIndex = 0;
        this.dataGridViewTextBoxColumn_0.HeaderText = "Рег. №";
        this.dataGridViewTextBoxColumn_0.Name = "RegNum";
        this.dataGridViewTextBoxColumn_1.HeaderText = "Дата подп.";
        this.dataGridViewTextBoxColumn_1.Name = "DateSign";
        this.dataGridViewTextBoxColumn_2.HeaderText = "Подписал";
        this.dataGridViewTextBoxColumn_2.Name = "Sign";
        this.dataGridViewTextBoxColumn_3.HeaderText = "Адресат";
        this.dataGridViewTextBoxColumn_3.Name = "Addressee";
        this.dataGridViewTextBoxColumn_4.HeaderText = "Испольнитель";
        this.dataGridViewTextBoxColumn_4.Name = "Preformer";
        this.dataGridViewTextBoxColumn_5.HeaderText = "По вопросу";
        this.dataGridViewTextBoxColumn_5.Name = "Subject";
        this.tableLayoutPanel_0.ColumnCount = 2;
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.08696f));
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.91304f));
        this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 0, 0);
        this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 1);
        this.tableLayoutPanel_0.Dock = DockStyle.Fill;
        this.tableLayoutPanel_0.Location = new Point(0, 0);
        this.tableLayoutPanel_0.Name = "tlpGeneral";
        this.tableLayoutPanel_0.RowCount = 2;
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 92.10526f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 7.894737f));
        this.tableLayoutPanel_0.Size = new Size(0x325, 0x1c8);
        this.tableLayoutPanel_0.TabIndex = 1;
        this.button_0.Location = new Point(0x2b8, 0x1aa);
        this.button_0.Margin = new Padding(3, 7, 3, 7);
        this.button_0.Name = "button1";
        this.button_0.Size = new Size(90, 0x17);
        this.button_0.TabIndex = 1;
        this.button_0.Text = "Закрыть";
        this.button_0.UseVisualStyleBackColor = true;
        this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x325, 0x1c8);
        base.Controls.Add(this.tableLayoutPanel_0);
        base.Name = "FormMemorandum";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Служебные записки";
        base.Load += new EventHandler(this.Form25_Load);
        base.Shown += new EventHandler(this.Form25_Shown);
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        this.tableLayoutPanel_0.ResumeLayout(false);
        base.ResumeLayout(false);
    }

    [CompilerGenerated]
    private void method_1()
    {
        this.formProgressBar_0.Show();
    }

    [CompilerGenerated]
    private void method_2()
    {
        this.formProgressBar_0.Hide();
    }
}

