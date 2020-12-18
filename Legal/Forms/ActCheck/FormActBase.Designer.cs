namespace Legal.Forms.ActCheck
{
    partial class FormActBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsAbnObjAkt1 = new Legal.DataSet.dsAbnObjAct();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAkt1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsAbnObjAct1
            // 
            this.dsAbnObjAkt1.DataSetName = "dsAbnObjAkt";
            this.dsAbnObjAkt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormActBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "FormActBase";
            this.Text = "FormActBase";
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAkt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DataSet.dsAbnObjAct dsAbnObjAkt1;
    }
}