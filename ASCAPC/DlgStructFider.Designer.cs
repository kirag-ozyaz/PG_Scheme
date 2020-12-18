namespace ASCAPC
{
    partial class DlgStructFider
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
            ASCAPC.TypeNode typeNode1 = new ASCAPC.TypeNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnEditElement = new System.Windows.Forms.Button();
            this.btnDeleteElement = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewNodes = new System.Windows.Forms.TreeView();
            this.controlFider1 = new ASCAPC.ControlFiderN();
            this.datasetTOK5 = new ASCAPC.DataSet.dsASCAPC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetTOK5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(406, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddObject);
            this.panel2.Controls.Add(this.btnEditElement);
            this.panel2.Controls.Add(this.btnDeleteElement);
            this.panel2.Controls.Add(this.btnAddNode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 32);
            this.panel2.TabIndex = 2;
            // 
            // btnAddObject
            // 
            this.btnAddObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddObject.Location = new System.Drawing.Point(11, 4);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(110, 23);
            this.btnAddObject.TabIndex = 5;
            this.btnAddObject.Text = "Добавить объект";
            this.btnAddObject.UseVisualStyleBackColor = true;
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click_1);
            // 
            // btnEditElement
            // 
            this.btnEditElement.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditElement.Location = new System.Drawing.Point(239, 4);
            this.btnEditElement.Name = "btnEditElement";
            this.btnEditElement.Size = new System.Drawing.Size(110, 23);
            this.btnEditElement.TabIndex = 4;
            this.btnEditElement.Text = "Редактировать";
            this.btnEditElement.UseVisualStyleBackColor = true;
            this.btnEditElement.Click += new System.EventHandler(this.btnEditElement_Click);
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteElement.Location = new System.Drawing.Point(354, 4);
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteElement.TabIndex = 3;
            this.btnDeleteElement.Text = "Удалить";
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.btnDeleteElement_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNode.Location = new System.Drawing.Point(125, 4);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(110, 23);
            this.btnAddNode.TabIndex = 2;
            this.btnAddNode.Text = "Добавить";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.treeViewNodes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.controlFider1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 227);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // treeViewNodes
            // 
            this.treeViewNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNodes.Location = new System.Drawing.Point(3, 3);
            this.treeViewNodes.Name = "treeViewNodes";
            this.treeViewNodes.Size = new System.Drawing.Size(241, 221);
            this.treeViewNodes.TabIndex = 1;
            this.treeViewNodes.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewNodes_BeforeCollapse);
            this.treeViewNodes.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewNodes_BeforeExpand);
            this.treeViewNodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNodes_AfterSelect);
            this.treeViewNodes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewNodes_NodeMouseDoubleClick);
            this.treeViewNodes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewNodes_MouseDown);
            // 
            // controlFider1
            // 
            this.controlFider1.Location = new System.Drawing.Point(250, 3);
            this.controlFider1.Name = "controlFider1";
            this.controlFider1.Size = new System.Drawing.Size(241, 211);
            this.controlFider1.TabIndex = 2;
            typeNode1.CALC_FACTOR = 1D;
            typeNode1.Code = ((short)(-1));
            typeNode1.METER_TYPE = '\0';
            typeNode1.Name = "";
            typeNode1.ParentTypeNode = null;
            typeNode1.TypeCode = ASCAPC.TypeCodes.Node;
            typeNode1.XML_CODE = "";
            this.controlFider1.TypeNode = typeNode1;
            // 
            // datasetTOK5
            // 
            this.datasetTOK5.DataSetName = "dsASCAPC";
            this.datasetTOK5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DlgStructFider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 291);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DlgStructFider";
            this.PermissionsControlsEnabled = false;
            this.PermissionsControlsVisible = false;
            this.Text = "DlgStructFider";
            this.Load += new System.EventHandler(this.DlgStructFider_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasetTOK5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteElement;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView treeViewNodes;
        private DataSet.dsASCAPC datasetTOK5;
        private ControlFiderN controlFider1;
        private System.Windows.Forms.Button btnEditElement;
        private System.Windows.Forms.Button btnAddObject;
    }
}