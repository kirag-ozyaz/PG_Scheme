﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginInterfaces;
using System.Windows.Forms;

namespace PluginTest
{
    /// <summary>
	/// Plugin1
	/// </summary>
    public class Plugin2 : IPlugin  // <-- See how we inherited the IPlugin interface?
    {
        public FormLbr.Classes.EISSettings eisSettings = new FormLbr.Classes.EISSettings();
        public Plugin2()
        {
            //
            // TODO: Add constructor logic here
            //

        }

        //Declarations of all our internal plugin variables
        string myName = "Plugin1";
        string myDescription = "Test Plugin!";
        string myAuthor = "Coder.ul";
        string myVersion = "1.0.0";
        IPluginHost myHost = null;

        System.Windows.Forms.ToolStripMenuItem myMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        System.Windows.Forms.ToolStripMenuItem myMenuItemMeasurement = new System.Windows.Forms.ToolStripMenuItem();
        System.Windows.Forms.ToolStripMenuItem myMenuItemLinkAbn = new System.Windows.Forms.ToolStripMenuItem();

        /// <summary>
        /// Description of the Plugin's purpose
        /// </summary>
        public string Description
        {
            get { return myDescription; }
        }

        /// <summary>
        /// Author of the plugin
        /// </summary>
        public string Author
        {
            get { return myAuthor; }

        }

        /// <summary>
        /// Host of the plugin.
        /// </summary>
        public IPluginHost Host
        {
            get { return myHost; }
            set { myHost = value; }
        }

        public string Name
        {
            get { return myName; }
        }
        public System.Windows.Forms.ToolStripMenuItem MenuItem
        {
            get { return myMenuItem; }
        }

        public string Version
        {
            get { return myVersion; }
        }

        public void Initialize()
        {
            myMenuItem.Text = "Plugin1";
            myMenuItem.Click += new EventHandler(myMenuItem_Click);


            //////System.Windows.Forms.ToolStripMenuItem mySubMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            //////mySubMenuItem1.Text = "Plugin1_1";
            //////mySubMenuItem1.Click += new EventHandler(mySubMenuItem1_Click);

            //////System.Windows.Forms.ToolStripMenuItem mySubMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            //////mySubMenuItem2.Text = "Plugin1_2";

            //////myMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //////mySubMenuItem1,
            //////mySubMenuItem2});
            ////////This is the first Function called by the host...
            ////////Put anything needed to start with here first

            //myMenuItemMeasurement.Text = "Журнал замеров";
            //this.ShowMdiForm(typeof(SchemeReports.FormLinkAbnNewAndOld));

            //Documents.Measurement.FormMeasurement frm = new Documents.Measurement.FormMeasurement();
            //((Form)frm).MdiParent = (Form)this;
            //frm.SqlSettings = this.eisSettings.SqlSettings;
            //frm.ShowForm += new ShowFormEventHandler(this.form_ShowForm);
            //frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            //((Control)frm).Show();

        }
        // как передать SqlSettings
        void myMenuItem_Click(object sender, EventArgs e)
        {

            

        }

        void mySubMenuItem1_Click(object sender, EventArgs e)
        {
            FormTest f = new FormTest();

            if (Host is System.Windows.Forms.Form)
                f.MdiParent = (System.Windows.Forms.Form)Host;
            if (Host is FormLbr.FormBase)
                f.SqlSettings = ((FormLbr.FormBase)Host).SqlSettings;
            f.Show();
        }

        public void Dispose()
        {
            //Put any cleanup code in here for when the program is stopped
        }
    }
}
