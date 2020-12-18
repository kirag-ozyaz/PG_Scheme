namespace Documents.Forms.TechnologicalConnection.Contract
{
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public class FormPaymentSheduleAddEdit : FormBase
    {
        private IContainer icontainer_0;

        public FormPaymentSheduleAddEdit()
        {
            this.method_0();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void method_0()
        {
            this.icontainer_0 = new Container();
            base.AutoScaleMode = AutoScaleMode.Font;
            this.Text = "FormPaymentSheduleAddEdit";
        }
    }
}

