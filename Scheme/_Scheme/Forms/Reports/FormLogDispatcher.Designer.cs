namespace Scheme.Forms.Reports
{
	public partial class FormLogDispatcher : global::FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.veArhpSudu != null)
			{
				this.veArhpSudu.Dispose();
			}
			base.Dispose(disposing);
		}

		private global::System.ComponentModel.IContainer veArhpSudu;
	}
}
