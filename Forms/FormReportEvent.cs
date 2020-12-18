
using EIS.Classes;
using FormLbr;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EIS.Forms
{
    public class FormReportEvent : FormBase
    {
        private EventHandler eventHandler1;

        public event EventHandler NewEvent
        {
            add
            {
                EventHandler eventHandler = this.eventHandler1;
                EventHandler eventHandler2;
                do
                {
                    eventHandler2 = eventHandler;
                    EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                    eventHandler = System.Threading.Interlocked.CompareExchange<EventHandler>(ref this.eventHandler1, value2, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
            remove
            {
                EventHandler eventHandler = this.eventHandler1;
                EventHandler eventHandler2;
                do
                {
                    eventHandler2 = eventHandler;
                    EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                    eventHandler = System.Threading.Interlocked.CompareExchange<EventHandler>(ref this.eventHandler1, value2, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
        }
        public FormReportEvent()
        {
            this.InitializeComponent();
        }

        public void FEEvent(object sender, MainEventsArgs e)
        {
            if (this.eventHandler1 != null)
            {
                this.eventHandler1((object)this, new EventArgs());
            }
            this.richTextBox1.AppendText(e.Message);
        }
        #region Дизайнер формы
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(536, 169);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // FormReportEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 262);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormReportEvent";
            this.Text = "FormReportEvent";
            this.ResumeLayout(false);

        }
        private RichTextBox richTextBox1;
        #endregion
    }
}
