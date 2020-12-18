using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Constants;
using DataSql;
using FormLbr;
using FormLbr.Classes;
using netDxf;
using Passport.Classes;
using Passport.Controls;
using Passport.Forms;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas.Forms;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeCtrl2.Properties;
using SchemeCtrl2.SnapPoint;
using SchemeCtrl2.WCF;
using SchemeModel;
using SchemeModel.Calculations;
using Telemetry;
using WinFormsUI.Docking;
using System.Runtime.Serialization.Formatters.Binary;
using Proxy_Singleton = SchemeCtrl2.WCF.Proxy_Singleton;

namespace SchemeCtrl2.Canvas
{
    partial class CanvasControl
	{
        public new void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected override void Dispose(bool disposing)
        {
            this.Disconnect();
            this.ProxySingleton.ProxyCallBackEvent -= this.ProxySingleton_ProxyCallBackEvent;
            this.ProxySingleton.ProxyEvent -= this.ProxySingleton_ProxyEvent;
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            if (!this.bool_10)
            {
                if (disposing)
                {
                    if (this.graphics_0 != null)
                    {
                        this.graphics_0.Dispose();
                    }
                    if (this.dsScheme != null)
                    {
                        this.dsScheme.Dispose();
                    }
                    if (this.control0_0 != null)
                    {
                        this.control0_0.Dispose();
                    }
                    if (this.checkServTimer != null)
                    {
                        this.checkServTimer.Dispose();
                    }
                    if (this.staticImage != null)
                    {
                        this.staticImage.Dispose();
                    }
                    if (this.list_1 != null)
                    {
                        this.list_1.Clear();
                    }
                    if (this.backgroundLayer_0 != null)
                    {
                        this.backgroundLayer_0.Dispose();
                    }
                    if (this.list_4 != null)
                    {
                        this.list_4.Clear();
                    }
                    IEnumerable<int> source = from o in this.loadedPoints
                                              select o.Key;
                    while (source.Count<int>() > 0)
                    {
                        this.loadedPoints[source.First<int>()].Dispose();
                        this.loadedPoints.Remove(source.First<int>());
                    }
                    if (this.list_0 != null)
                    {
                        while (this.list_0.Count > 0)
                        {
                            if (this.list_0[0] is IDisposable)
                            {
                                ((IDisposable)this.list_0[0]).Dispose();
                                this.list_0.RemoveAt(0);
                            }
                            else
                            {
                                this.list_0[0] = null;
                                this.list_0.RemoveAt(0);
                            }
                        }
                    }
                }
                this.bool_10 = true;
            }
            this.UnlockMonopoly();
            base.Dispose(disposing);
        }

        ~CanvasControl()
        {
            this.Dispose(false);
        }
        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CanvasControl));
            this.statusStrip = new StatusStrip();
            this.labelMousePosition = new ToolStripStatusLabel();
            this.toolBtnZoom = new ToolStripSplitButton();
            this.toolTxtZoomChanged = new ToolStripTextBox();
            this.toolBtnZoom800 = new ToolStripMenuItem();
            this.toolBtnZoom400 = new ToolStripMenuItem();
            this.toolBtnZoom200 = new ToolStripMenuItem();
            this.toolBtnZoom150 = new ToolStripMenuItem();
            this.toolBtnZoom125 = new ToolStripMenuItem();
            this.toolBtnZoom100 = new ToolStripMenuItem();
            this.toolBtnZoom75 = new ToolStripMenuItem();
            this.toolBtnZoom50 = new ToolStripMenuItem();
            this.toolBtnZoom25 = new ToolStripMenuItem();
            this.labelInfo = new ToolStripStatusLabel();
            this.GihsIhiuKn = new ToolStripStatusLabel();
            this.labelProgressBar = new ToolStripStatusLabel();
            this.toolProgressBarSave = new ToolStripProgressBar();
            this.toolStripStatusLabelConnected = new ToolStripStatusLabel();
            this.dsScheme = new DataSetScheme();
            this.printDocument = new PrintDocument();
            this.printDialog = new PrintDialog();
            this.pageSetupDialog_0 = new PageSetupDialog();
            this.printPreviewDialog = new PrintPreviewDialog();
            this.propertyGrid1 = new PropertyGrid();
            this.bigBoldButton = new Button();
            this.buttonCheck = new Button();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.tbPopup = new Label();
            this.contextMenuSelectedObjects = new ContextMenuStrip(this.components);
            this.toolMenuItemFilterSelectedObjects = new ToolStripMenuItem();
            this.toolMenuItemAddFilterSelectedObjects = new ToolStripMenuItem();
            this.toolMenuItemDeleteFilterSelectedObjects = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.toolStripMenuItemBookmark = new ToolStripMenuItem();
            this.toolStripMenuItemRemoveBookmark = new ToolStripMenuItem();
            this.toolStripSeparator9 = new ToolStripSeparator();
            this.toolMenuItemSelectedPowerBullshit = new ToolStripMenuItem();
            this.toolMenuItemSelectedAlign = new ToolStripMenuItem();
            this.toolMenuItemSelectedAlignByTop = new ToolStripMenuItem();
            this.toolMenuItemSelectedAlignByBottom = new ToolStripMenuItem();
            this.toolMenuItemSelectedAlignByRigth = new ToolStripMenuItem();
            this.toolMenuItemSelectedAlignByLeft = new ToolStripMenuItem();
            this.toolMenuItemSelectedAlignByHorCenter = new ToolStripMenuItem();
            this.toolMenuItemSelectedAlignByVertCenter = new ToolStripMenuItem();
            this.toolStripSeparator13 = new ToolStripSeparator();
            this.toolStripMenuItemGroupSelectedObject = new ToolStripMenuItem();
            this.toolStripMenuItemGroupProperty = new ToolStripMenuItem();
            this.toolStripSeparatorGroup = new ToolStripSeparator();
            this.toolMenuItemCenterSElectedObjects = new ToolStripMenuItem();
            this.toolMenuItemCopySelectedObjects = new ToolStripMenuItem();
            this.toolMenuItemCopySelectedObjectsToImage = new ToolStripMenuItem();
            this.toolMenuItemExportSelectedObjectsToDXF = new ToolStripMenuItem();
            this.toolMenuItemPasteSelectedObjects = new ToolStripMenuItem();
            this.toolMenuItemDeleteSelectedObjects = new ToolStripMenuItem();
            this.contextMenuRectnagle = new ContextMenuStrip(this.components);
            this.twFspjsly3 = new ToolStripMenuItem();
            this.toolMenuItemRectRecipientsPower = new ToolStripMenuItem();
            this.toolStripSeparator10 = new ToolStripSeparator();
            this.toolMenuItemRectFilter = new ToolStripMenuItem();
            this.toolMenuItemRectFilterAdd = new ToolStripMenuItem();
            this.toolMenuItemRectFilterDel = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolMenuItemRectCopy = new ToolStripMenuItem();
            this.toolMenuItemRectPaste = new ToolStripMenuItem();
            this.toolMenuItemRectDel = new ToolStripMenuItem();
            this.toolStripMenuItemRectanglePosition = new ToolStripMenuItem();
            this.toolStripMenuItemReflect = new ToolStripMenuItem();
            this.toolStripMenuItemVReflect = new ToolStripMenuItem();
            this.toolStripMenuItemHReflect = new ToolStripMenuItem();
            this.toolStripMenuItemRotateRectangle = new ToolStripMenuItem();
            this.toolStripMenuItemRotate90 = new ToolStripMenuItem();
            this.toolStripMenuItemRotate180 = new ToolStripMenuItem();
            this.toolStripMenuItemRotate170 = new ToolStripMenuItem();
            this.toolMenuItemRectAlign = new ToolStripMenuItem();
            this.toolStripMenuItemAdjacentSubstation = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolMenuItemRectFile = new ToolStripMenuItem();
            this.toolMenuItemRectProperty = new ToolStripMenuItem();
            this.contextMenuShina = new ContextMenuStrip(this.components);
            this.toolMenuItemShinaAddChild = new ToolStripMenuItem();
            this.toolMenuItemShinaAddCell = new ToolStripMenuItem();
            this.toolMenuItemShinaBridge = new ToolStripMenuItem();
            this.toolMenuItemShinaSplitter = new ToolStripMenuItem();
            this.toolStripMenuItemAddWhitePoint = new ToolStripMenuItem();
            this.toolMeniItemShinaAddPattern = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn = new ToolStripMenuItem();
            this.oGyhJxxeRR = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn2 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn3 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn4 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn5 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn6 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn7 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn8 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn9 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbn10 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto1 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto2 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto3 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto4 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto5 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto6 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto7 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto8 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto9 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnAuto10 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve1 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve2 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve3 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve4 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve5 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve6 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve7 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve8 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve9 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnReserve10 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS1 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS2 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS3 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS4 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS5 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS6 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS7 = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS8 = new ToolStripMenuItem();
            this.EhkrgnfgYC = new ToolStripMenuItem();
            this.toolMenuItemShinaAddPatternAbnRPS10 = new ToolStripMenuItem();
            this.toolStripSeparator7 = new ToolStripSeparator();
            this.waWrHaQms2 = new ToolStripMenuItem();
            this.ldtrvofZuY = new ToolStripMenuItem();
            this.toolMenuItemShinaCopy = new ToolStripMenuItem();
            this.toolMenuItemShinaPaste = new ToolStripMenuItem();
            this.toolMenuItemShinaDel = new ToolStripMenuItem();
            this.toolStripSeparatorEditShina = new ToolStripSeparator();
            this.toolStripMenuItemBusMeasurement = new ToolStripMenuItem();
            this.toolMenuItemShinaPowerSource = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripMenuItem5 = new ToolStripMenuItem();
            this.toolMenuItemShinaRecipientsPower = new ToolStripMenuItem();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripMenuItem11 = new ToolStripMenuItem();
            this.toolStripMenuItemAllPower = new ToolStripMenuItem();
            this.toolStripMenuItemAdjacentSubstation2 = new ToolStripMenuItem();
            this.toolStripMenuItemShinaGetOldAbn = new ToolStripMenuItem();
            this.toolStripMenuItemShinaOldAbnCurrentRect = new ToolStripMenuItem();
            this.toolStripMenuItemShinaOldAbnNextRect = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.toolMenuItemShinaFilter = new ToolStripMenuItem();
            this.toolMenuItemShinaFilterAdd = new ToolStripMenuItem();
            this.toolMenuItemShinaFilterDel = new ToolStripMenuItem();
            this.toolStripSeparator11 = new ToolStripSeparator();
            this.toolMenuItemShinaFile = new ToolStripMenuItem();
            this.toolMenuItemShinaProperty = new ToolStripMenuItem();
            this.contextMenuSwitchTool = new ContextMenuStrip(this.components);
            this.toolMenuItemSwitchPassport = new ToolStripMenuItem();
            this.toolMenuItemSwitchOn = new ToolStripMenuItem();
            this.toolStripMenuChangeArrowDirection = new ToolStripMenuItem();
            this.toolMenuItemSwitchFilter = new ToolStripMenuItem();
            this.toolMenuItemSwitchFilterAdd = new ToolStripMenuItem();
            this.toolMenuItemSwitchFilterDel = new ToolStripMenuItem();
            this.toolStripMenuItemOOLDisplayGrLevel = new ToolStripMenuItem();
            this.toolStripMenuItemSwitchAddTelemetry = new ToolStripMenuItem();
            this.toolMenuItemSwitchErcloud = new ToolStripMenuItem();
            this.toolMenuItemSwitchLinkErcloud = new ToolStripMenuItem();
            this.toolMenuItemSwitchShowDataErcloud = new ToolStripMenuItem();
            this.toolStripSeparator12 = new ToolStripSeparator();
            this.toolStripMenuItemCSRollingOut = new ToolStripMenuItem();
            this.toolStripMenuItemCSRepairMode = new ToolStripMenuItem();
            this.toolStripMenuItemCSTestMode = new ToolStripMenuItem();
            this.toolStripMenuItemCSNormalMode = new ToolStripMenuItem();
            this.toolStripSeparatorCS = new ToolStripSeparator();
            this.toolMenuItemStateDel = new ToolStripMenuItem();
            this.toolMenuItemSwitchCopy = new ToolStripMenuItem();
            this.toolMenuItemSwitchDel = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripMenuItemSwitchMeasurement = new ToolStripMenuItem();
            this.toolMenuItemSwitchLogDispatcher = new ToolStripMenuItem();
            this.toolMenuItemSwitchFile = new ToolStripMenuItem();
            this.MSMZJEXRVG = new ToolStripMenuItem();
            this.contextMenuLineTool = new ContextMenuStrip(this.components);
            this.toolMenuItemLineAddChild = new ToolStripMenuItem();
            this.toolMenuItemLineAddBranch = new ToolStripMenuItem();
            this.toolMenuItemLineAddPoint = new ToolStripMenuItem();
            this.toolStripSeparatorLineAddBranchPoint = new ToolStripSeparator();
            this.toolMenuItemLineAddOutsideLineDisconnector = new ToolStripMenuItem();
            this.toolMenuItemLineAddVacuumSwitch = new ToolStripMenuItem();
            this.toolMenuItemLineAddTransformer = new ToolStripMenuItem();
            this.toolMenuItemLineAddVoltageTransformer = new ToolStripMenuItem();
            this.toolStripMenuItemAddAmperageTransformerTool = new ToolStripMenuItem();
            this.toolMenuItemLineAddLoadSwitch = new ToolStripMenuItem();
            this.toolMenuItemLineAddLoadSwitchWaxwork = new ToolStripMenuItem();
            this.toolMenuItemLineAddRPS = new ToolStripMenuItem();
            this.toolMenuItemLineAddLinearDisconnector = new ToolStripMenuItem();
            this.toolMenuItemLineAddLinearDisconnectorWaxwork = new ToolStripMenuItem();
            this.toolMenuItemLineAddLubricantDisconnector = new ToolStripMenuItem();
            this.toolMenuItemLineAddFuseTool = new ToolStripMenuItem();
            this.toolMenuItemLineAddDischargerTool = new ToolStripMenuItem();
            this.toolMenuItemLineAddVoltageLimetedTool = new ToolStripMenuItem();
            this.toolMenuItemLineAddEndTrim = new ToolStripMenuItem();
            this.toolMenuItemLineAddCircuitBreakerTool = new ToolStripMenuItem();
            this.toolMenuItemLineAddGroundingTool = new ToolStripMenuItem();
            this.toolMenuItemLineAddSeparatorTool = new ToolStripMenuItem();
            this.toolStripMenuItemAddMagneticStarterTool = new ToolStripMenuItem();
            this.toolStripMenuItemAddElectricMeter = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.toolMenuItemAddLineText = new ToolStripMenuItem();
            this.toolMenuItemLineCopy = new ToolStripMenuItem();
            this.uBbItwaYjM = new ToolStripMenuItem();
            this.toolStripMenuItemDevideLine = new ToolStripMenuItem();
            this.toolStripMenuItemDisconnectLine = new ToolStripMenuItem();
            this.toolMenuItemLineDel = new ToolStripMenuItem();
            this.toolMenuItemLineDelObj = new ToolStripMenuItem();
            this.toolMenuItemLineDelPoint = new ToolStripMenuItem();
            this.toolStripSeparatorEditLine = new ToolStripSeparator();
            this.toolMenuItemLineSetStatus = new ToolStripMenuItem();
            this.toolMenuItemLineSetStatusGrounding = new ToolStripMenuItem();
            this.toolMenuItemLineSetStatusBrakeDown = new ToolStripMenuItem();
            this.toolMenuItemLineSetStatusOff = new ToolStripMenuItem();
            this.toolMenuItemLineSetStatusNoPhased = new ToolStripMenuItem();
            this.toolMenuItemLineSetStatusArrow = new ToolStripMenuItem();
            this.toolStripSeparatorSetStatus = new ToolStripSeparator();
            this.toolMenuItemLineTextHere = new ToolStripMenuItem();
            this.toolStripSeparatorLineTextHere = new ToolStripSeparator();
            this.toolMenuItemLineFilter = new ToolStripMenuItem();
            this.toolMenuItemLineFilterAdd = new ToolStripMenuItem();
            this.toolMenuItemLineFilterDel = new ToolStripMenuItem();
            this.toolMenuItemLinePowerSource = new ToolStripSeparator();
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem6 = new ToolStripMenuItem();
            this.toolStripMenuItem8 = new ToolStripMenuItem();
            this.toolMenuItemLineRecipientsPower = new ToolStripMenuItem();
            this.toolStripMenuItem7 = new ToolStripMenuItem();
            this.toolStripMenuItem9 = new ToolStripMenuItem();
            this.toolStripMenuItem10 = new ToolStripMenuItem();
            this.toolStripMenuItem12 = new ToolStripMenuItem();
            this.toolStripMenuItem13 = new ToolStripMenuItem();
            this.toolStripMenuItem14 = new ToolStripMenuItem();
            this.QyjrxReCs8 = new ToolStripMenuItem();
            this.toolStripSeparator8 = new ToolStripSeparator();
            this.toolMenuItemLinePropertyPoint = new ToolStripMenuItem();
            this.toolStripMenuItemLineAlignBranch = new ToolStripMenuItem();
            this.toolStripMenuItemAlignBranchByTop = new ToolStripMenuItem();
            this.toolStripMenuItemAlignBranchByBottom = new ToolStripMenuItem();
            this.toolStripMenuItemAlignBranchByRigth = new ToolStripMenuItem();
            this.toolStripMenuItemAlignBranchByLeft = new ToolStripMenuItem();
            this.toolMenuItemLinePropertyBranch = new ToolStripMenuItem();
            this.toolStripSeparator14 = new ToolStripSeparator();
            this.toolMenuItemLineRelayProtection = new ToolStripMenuItem();
            this.toolMenuItemLineLogDispatcher = new ToolStripMenuItem();
            this.toolMenuItemLinePassport = new ToolStripMenuItem();
            this.toolMenuItemLinePassportOpen = new ToolStripMenuItem();
            this.toolMenuItemLineDeLinkPassport = new ToolStripMenuItem();
            this.toolMenuItemLineLinkPassport = new ToolStripMenuItem();
            this.toolMenuItemLineFile = new ToolStripMenuItem();
            this.toolMenuItemLineProperty = new ToolStripMenuItem();
            this.contextMenuCanvas = new ContextMenuStrip(this.components);
            this.toolStripMenuItemAddFreeLabel = new ToolStripMenuItem();
            this.toolStripMenuItemAddTelemetryLabel2Level = new ToolStripMenuItem();
            this.toolMenuItemAddNode = new ToolStripMenuItem();
            this.toolMenuCanvasPaste = new ToolStripMenuItem();
            this.imageList_0 = new ImageList(this.components);
            this.contextMenuLabelTool = new ContextMenuStrip(this.components);
            this.toolMenuItemLabelUpdate = new ToolStripMenuItem();
            this.toolMenuItemLabelDel = new ToolStripMenuItem();
            this.toolMenuItemLabelProperty = new ToolStripMenuItem();
            this.contextMenuStripWhitePoint = new ContextMenuStrip(this.components);
            this.toolStripMenuItemRemoveWhitePoint = new ToolStripMenuItem();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.contextMenuFrame = new ContextMenuStrip(this.components);
            this.toolStripMenuFramePrint = new ToolStripMenuItem();
            this.toolStripMenuFrameCopyToImage = new ToolStripMenuItem();
            this.toolStripMenuFrameExportToImage = new ToolStripMenuItem();
            this.toolStripMenuFrameFitZoom = new ToolStripMenuItem();
            this.textBoxSearch = new TextBox();
            this.button1 = new Button();
            this.contextMenuTextBranchTool = new ContextMenuStrip(this.components);
            this.reArSpApSW = new ToolStripMenuItem();
            this.toolStripMenuItemTBTDisplayGrLevel = new ToolStripMenuItem();
            this.toolMenuItemTextBranchDel = new ToolStripMenuItem();
            this.WcgruJuvXg = new ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            ((ISupportInitialize)this.dsScheme).BeginInit();
            this.contextMenuSelectedObjects.SuspendLayout();
            this.contextMenuRectnagle.SuspendLayout();
            this.contextMenuShina.SuspendLayout();
            this.contextMenuSwitchTool.SuspendLayout();
            this.contextMenuLineTool.SuspendLayout();
            this.contextMenuCanvas.SuspendLayout();
            this.contextMenuLabelTool.SuspendLayout();
            this.contextMenuStripWhitePoint.SuspendLayout();
            this.contextMenuFrame.SuspendLayout();
            this.contextMenuTextBranchTool.SuspendLayout();
            base.SuspendLayout();
            this.statusStrip.ImageScalingSize = new Size(20, 20);
            this.statusStrip.Items.AddRange(new ToolStripItem[]
            {
                this.labelMousePosition,
                this.toolBtnZoom,
                this.labelInfo,
                this.GihsIhiuKn,
                this.labelProgressBar,
                this.toolProgressBarSave,
                this.toolStripStatusLabelConnected
            });
            this.statusStrip.Location = new Point(0, 465);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new Size(754, 29);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            this.labelMousePosition.AutoSize = false;
            this.labelMousePosition.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
            this.labelMousePosition.Image = (Image)resources.GetObject("labelMousePosition.Image");
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new Size(140, 24);
            this.toolBtnZoom.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolTxtZoomChanged,
                this.toolBtnZoom800,
                this.toolBtnZoom400,
                this.toolBtnZoom200,
                this.toolBtnZoom150,
                this.toolBtnZoom125,
                this.toolBtnZoom100,
                this.toolBtnZoom75,
                this.toolBtnZoom50,
                this.toolBtnZoom25
            });
            this.toolBtnZoom.Name = "toolBtnZoom";
            this.toolBtnZoom.Size = new Size(51, 27);
            this.toolBtnZoom.Text = "100%";
            this.toolTxtZoomChanged.Name = "toolTxtZoomChanged";
            this.toolTxtZoomChanged.Size = new Size(100, 23);
            this.toolTxtZoomChanged.KeyDown += this.toolTxtZoomChanged_KeyDown;
            this.toolBtnZoom800.Name = "toolBtnZoom800";
            this.toolBtnZoom800.Size = new Size(160, 22);
            this.toolBtnZoom800.Tag = "800";
            this.toolBtnZoom800.Text = "800%";
            this.toolBtnZoom800.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom400.Name = "toolBtnZoom400";
            this.toolBtnZoom400.Size = new Size(160, 22);
            this.toolBtnZoom400.Tag = "400";
            this.toolBtnZoom400.Text = "400%";
            this.toolBtnZoom400.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom200.Name = "toolBtnZoom200";
            this.toolBtnZoom200.Size = new Size(160, 22);
            this.toolBtnZoom200.Tag = "200";
            this.toolBtnZoom200.Text = "200%";
            this.toolBtnZoom200.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom150.Name = "toolBtnZoom150";
            this.toolBtnZoom150.Size = new Size(160, 22);
            this.toolBtnZoom150.Tag = "150";
            this.toolBtnZoom150.Text = "150%";
            this.toolBtnZoom150.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom125.Name = "toolBtnZoom125";
            this.toolBtnZoom125.Size = new Size(160, 22);
            this.toolBtnZoom125.Tag = "125";
            this.toolBtnZoom125.Text = "125%";
            this.toolBtnZoom125.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom100.Name = "toolBtnZoom100";
            this.toolBtnZoom100.Size = new Size(160, 22);
            this.toolBtnZoom100.Tag = "100";
            this.toolBtnZoom100.Text = "100%";
            this.toolBtnZoom100.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom75.Name = "toolBtnZoom75";
            this.toolBtnZoom75.Size = new Size(160, 22);
            this.toolBtnZoom75.Tag = "75";
            this.toolBtnZoom75.Text = "75%";
            this.toolBtnZoom75.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom50.Name = "toolBtnZoom50";
            this.toolBtnZoom50.Size = new Size(160, 22);
            this.toolBtnZoom50.Tag = "50";
            this.toolBtnZoom50.Text = "50%";
            this.toolBtnZoom50.Click += this.toolBtnZoom25_Click;
            this.toolBtnZoom25.Name = "toolBtnZoom25";
            this.toolBtnZoom25.Size = new Size(160, 22);
            this.toolBtnZoom25.Tag = "25";
            this.toolBtnZoom25.Text = "25%";
            this.toolBtnZoom25.Click += this.toolBtnZoom25_Click;
            this.labelInfo.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new Size(17, 24);
            this.labelInfo.Text = "  ";
            this.GihsIhiuKn.Name = "toolLabelEmpty";
            this.GihsIhiuKn.Size = new Size(531, 24);
            this.GihsIhiuKn.Spring = true;
            this.labelProgressBar.BorderSides = ToolStripStatusLabelBorderSides.Left;
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new Size(77, 24);
            this.labelProgressBar.Text = "Сохранение";
            this.labelProgressBar.Visible = false;
            this.toolProgressBarSave.Name = "toolProgressBarSave";
            this.toolProgressBarSave.Size = new Size(100, 23);
            this.toolProgressBarSave.Visible = false;
            this.toolStripStatusLabelConnected.Name = "toolStripStatusLabelConnected";
            this.toolStripStatusLabelConnected.Size = new Size(0, 24);
            this.dsScheme.DataSetName = "DataSetScheme";
            this.dsScheme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.printDocument.DocumentName = "Sheme";
            this.printDocument.BeginPrint += this.printDocument_BeginPrint;
            this.printDocument.EndPrint += this.printDocument_EndPrint;
            this.printDocument.PrintPage += this.printDocument_PrintPage;
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            this.pageSetupDialog_0.Document = this.printDocument;
            this.pageSetupDialog_0.EnableMetric = true;
            this.printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            this.printPreviewDialog.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog.ClientSize = new Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            this.propertyGrid1.Location = new Point(0, 32);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new Size(187, 361);
            this.propertyGrid1.TabIndex = 1;
            this.bigBoldButton.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.bigBoldButton.Location = new Point(0, 3);
            this.bigBoldButton.Name = "bigBoldButton";
            this.bigBoldButton.Size = new Size(187, 23);
            this.bigBoldButton.TabIndex = 2;
            this.bigBoldButton.Text = "BIG BOLD BUTTON";
            this.bigBoldButton.TextImageRelation = TextImageRelation.ImageAboveText;
            this.bigBoldButton.Click += this.bigBoldButton_Click;
            this.buttonCheck.Location = new Point(723, 3);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new Size(47, 23);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Visible = false;
            this.buttonCheck.Click += this.buttonCheck_Click;
            this.timer_1.Interval = 1500;
            this.timer_1.Tick += this.timer_1_Tick;
            this.tbPopup.AutoSize = true;
            this.tbPopup.Location = new Point(648, 8);
            this.tbPopup.Name = "tbPopup";
            this.tbPopup.Size = new Size(35, 13);
            this.tbPopup.TabIndex = 4;
            this.tbPopup.Text = "label1";
            this.tbPopup.Visible = false;
            this.contextMenuSelectedObjects.ImageScalingSize = new Size(20, 20);
            this.contextMenuSelectedObjects.Items.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemFilterSelectedObjects,
                this.toolStripSeparator4,
                this.toolStripMenuItemBookmark,
                this.toolStripMenuItemRemoveBookmark,
                this.toolStripSeparator9,
                this.toolMenuItemSelectedPowerBullshit,
                this.toolMenuItemSelectedAlign,
                this.toolStripSeparator13,
                this.toolStripMenuItemGroupSelectedObject,
                this.toolStripMenuItemGroupProperty,
                this.toolStripSeparatorGroup,
                this.toolMenuItemCenterSElectedObjects,
                this.toolMenuItemCopySelectedObjects,
                this.toolMenuItemCopySelectedObjectsToImage,
                this.toolMenuItemExportSelectedObjectsToDXF,
                this.toolMenuItemPasteSelectedObjects,
                this.toolMenuItemDeleteSelectedObjects
            });
            this.contextMenuSelectedObjects.Name = "contextMenuSelectedObjects";
            this.contextMenuSelectedObjects.Size = new Size(202, 314);
            this.contextMenuSelectedObjects.Opening += this.QpatEeerlY;
            this.toolMenuItemFilterSelectedObjects.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemAddFilterSelectedObjects,
                this.toolMenuItemDeleteFilterSelectedObjects
            });
            this.toolMenuItemFilterSelectedObjects.Name = "toolMenuItemFilterSelectedObjects";
            this.toolMenuItemFilterSelectedObjects.Size = new Size(201, 22);
            this.toolMenuItemFilterSelectedObjects.Text = "Фильтр";
            this.toolMenuItemAddFilterSelectedObjects.Name = "toolMenuItemAddFilterSelectedObjects";
            this.toolMenuItemAddFilterSelectedObjects.Size = new Size(183, 22);
            this.toolMenuItemAddFilterSelectedObjects.Text = "Добавить в фильтр";
            this.toolMenuItemAddFilterSelectedObjects.Click += this.toolMenuItemAddFilterSelectedObjects_Click;
            this.toolMenuItemDeleteFilterSelectedObjects.Name = "toolMenuItemDeleteFilterSelectedObjects";
            this.toolMenuItemDeleteFilterSelectedObjects.Size = new Size(183, 22);
            this.toolMenuItemDeleteFilterSelectedObjects.Text = "Удалить из фильтра";
            this.toolMenuItemDeleteFilterSelectedObjects.Click += this.toolMenuItemDeleteFilterSelectedObjects_Click;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(198, 6);
            this.toolStripMenuItemBookmark.Name = "toolStripMenuItemBookmark";
            this.toolStripMenuItemBookmark.Size = new Size(201, 22);
            this.toolStripMenuItemBookmark.Text = "Поставить метку";
            this.toolStripMenuItemBookmark.Click += this.toolStripMenuItemBookmark_Click;
            this.toolStripMenuItemRemoveBookmark.Name = "toolStripMenuItemRemoveBookmark";
            this.toolStripMenuItemRemoveBookmark.Size = new Size(201, 22);
            this.toolStripMenuItemRemoveBookmark.Text = "Снять метку";
            this.toolStripMenuItemRemoveBookmark.Click += this.toolStripMenuItemRemoveBookmark_Click;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new Size(198, 6);
            this.toolMenuItemSelectedPowerBullshit.Name = "toolMenuItemSelectedPowerBullshit";
            this.toolMenuItemSelectedPowerBullshit.Size = new Size(201, 22);
            this.toolMenuItemSelectedPowerBullshit.Text = "Варианты питания";
            this.toolMenuItemSelectedPowerBullshit.Visible = false;
            this.toolMenuItemSelectedPowerBullshit.Click += this.aqXtzFkSaU;
            this.toolMenuItemSelectedAlign.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemSelectedAlignByTop,
                this.toolMenuItemSelectedAlignByBottom,
                this.toolMenuItemSelectedAlignByRigth,
                this.toolMenuItemSelectedAlignByLeft,
                this.toolMenuItemSelectedAlignByHorCenter,
                this.toolMenuItemSelectedAlignByVertCenter
            });
            this.toolMenuItemSelectedAlign.Name = "toolMenuItemSelectedAlign";
            this.toolMenuItemSelectedAlign.Size = new Size(201, 22);
            this.toolMenuItemSelectedAlign.Text = "Выравнить";
            this.toolMenuItemSelectedAlignByTop.Name = "toolMenuItemSelectedAlignByTop";
            this.toolMenuItemSelectedAlignByTop.Size = new Size(171, 22);
            this.toolMenuItemSelectedAlignByTop.Tag = "T";
            this.toolMenuItemSelectedAlignByTop.Text = "По верхней точке";
            this.toolMenuItemSelectedAlignByTop.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
            this.toolMenuItemSelectedAlignByBottom.Name = "toolMenuItemSelectedAlignByBottom";
            this.toolMenuItemSelectedAlignByBottom.Size = new Size(171, 22);
            this.toolMenuItemSelectedAlignByBottom.Tag = "B";
            this.toolMenuItemSelectedAlignByBottom.Text = "По нижней точке";
            this.toolMenuItemSelectedAlignByBottom.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
            this.toolMenuItemSelectedAlignByRigth.Name = "toolMenuItemSelectedAlignByRigth";
            this.toolMenuItemSelectedAlignByRigth.Size = new Size(171, 22);
            this.toolMenuItemSelectedAlignByRigth.Tag = "R";
            this.toolMenuItemSelectedAlignByRigth.Text = "По правой точке";
            this.toolMenuItemSelectedAlignByRigth.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
            this.toolMenuItemSelectedAlignByLeft.Name = "toolMenuItemSelectedAlignByLeft";
            this.toolMenuItemSelectedAlignByLeft.Size = new Size(171, 22);
            this.toolMenuItemSelectedAlignByLeft.Tag = "L";
            this.toolMenuItemSelectedAlignByLeft.Text = "По левой точке";
            this.toolMenuItemSelectedAlignByLeft.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
            this.toolMenuItemSelectedAlignByHorCenter.Name = "toolMenuItemSelectedAlignByHorCenter";
            this.toolMenuItemSelectedAlignByHorCenter.Size = new Size(171, 22);
            this.toolMenuItemSelectedAlignByHorCenter.Tag = "H";
            this.toolMenuItemSelectedAlignByHorCenter.Text = "По горизонтали";
            this.toolMenuItemSelectedAlignByHorCenter.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
            this.toolMenuItemSelectedAlignByVertCenter.Name = "toolMenuItemSelectedAlignByVertCenter";
            this.toolMenuItemSelectedAlignByVertCenter.Size = new Size(171, 22);
            this.toolMenuItemSelectedAlignByVertCenter.Tag = "V";
            this.toolMenuItemSelectedAlignByVertCenter.Text = "По вертикали";
            this.toolMenuItemSelectedAlignByVertCenter.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new Size(198, 6);
            this.toolStripSeparator13.Visible = false;
            this.toolStripMenuItemGroupSelectedObject.Name = "toolStripMenuItemGroupSelectedObject";
            this.toolStripMenuItemGroupSelectedObject.Size = new Size(201, 22);
            this.toolStripMenuItemGroupSelectedObject.Text = "Сгруппировать";
            this.toolStripMenuItemGroupSelectedObject.Click += this.toolStripMenuItemGroupSelectedObject_Click;
            this.toolStripMenuItemGroupProperty.Name = "toolStripMenuItemGroupProperty";
            this.toolStripMenuItemGroupProperty.Size = new Size(201, 22);
            this.toolStripMenuItemGroupProperty.Text = "Свойства группы";
            this.toolStripMenuItemGroupProperty.Click += this.toolStripMenuItemGroupProperty_Click;
            this.toolStripSeparatorGroup.Name = "toolStripSeparatorGroup";
            this.toolStripSeparatorGroup.Size = new Size(198, 6);
            this.toolMenuItemCenterSElectedObjects.Name = "toolMenuItemCenterSElectedObjects";
            this.toolMenuItemCenterSElectedObjects.Size = new Size(201, 22);
            this.toolMenuItemCenterSElectedObjects.Text = "Подогнать под размер";
            this.toolMenuItemCenterSElectedObjects.Click += this.toolMenuItemCenterSElectedObjects_Click;
            this.toolMenuItemCopySelectedObjects.Name = "toolMenuItemCopySelectedObjects";
            this.toolMenuItemCopySelectedObjects.Size = new Size(201, 22);
            this.toolMenuItemCopySelectedObjects.Text = "Копировать";
            this.toolMenuItemCopySelectedObjects.Click += this.reArSpApSW_Click;
            this.toolMenuItemCopySelectedObjectsToImage.Name = "toolMenuItemCopySelectedObjectsToImage";
            this.toolMenuItemCopySelectedObjectsToImage.Size = new Size(201, 22);
            this.toolMenuItemCopySelectedObjectsToImage.Text = "Копировать в картинку";
            this.toolMenuItemCopySelectedObjectsToImage.Click += this.toolMenuItemCopySelectedObjectsToImage_Click;
            this.toolMenuItemExportSelectedObjectsToDXF.Name = "toolMenuItemExportSelectedObjectsToDXF";
            this.toolMenuItemExportSelectedObjectsToDXF.Size = new Size(201, 22);
            this.toolMenuItemExportSelectedObjectsToDXF.Text = "Экспорт в AutoCAD";
            this.toolMenuItemExportSelectedObjectsToDXF.Click += this.toolMenuItemExportSelectedObjectsToDXF_Click;
            this.toolMenuItemPasteSelectedObjects.Name = "toolMenuItemPasteSelectedObjects";
            this.toolMenuItemPasteSelectedObjects.Size = new Size(201, 22);
            this.toolMenuItemPasteSelectedObjects.Text = "Вставить";
            this.toolMenuItemPasteSelectedObjects.Click += this.uBbItwaYjM_Click;
            this.toolMenuItemDeleteSelectedObjects.Name = "toolMenuItemDeleteSelectedObjects";
            this.toolMenuItemDeleteSelectedObjects.Size = new Size(201, 22);
            this.toolMenuItemDeleteSelectedObjects.Text = "Удалить";
            this.toolMenuItemDeleteSelectedObjects.Click += this.toolMenuItemDeleteSelectedObjects_Click;
            this.contextMenuRectnagle.ImageScalingSize = new Size(20, 20);
            this.contextMenuRectnagle.Items.AddRange(new ToolStripItem[]
            {
                this.twFspjsly3,
                this.toolMenuItemRectRecipientsPower,
                this.toolStripSeparator10,
                this.toolMenuItemRectFilter,
                this.toolStripSeparator1,
                this.toolMenuItemRectCopy,
                this.toolMenuItemRectPaste,
                this.toolMenuItemRectDel,
                this.toolStripMenuItemRectanglePosition,
                this.toolMenuItemRectAlign,
                this.toolStripMenuItemAdjacentSubstation,
                this.toolStripSeparator2,
                this.toolMenuItemRectFile,
                this.toolMenuItemRectProperty
            });
            this.contextMenuRectnagle.Name = "contextMenuRectnagle";
            this.contextMenuRectnagle.Size = new Size(198, 264);
            this.contextMenuRectnagle.Opening += this.contextMenuRectnagle_Opening;
            this.twFspjsly3.Name = "toolMenuItemRectPowerSource";
            this.twFspjsly3.Size = new Size(197, 22);
            this.twFspjsly3.Text = "Просчитать запитку";
            this.twFspjsly3.Click += this.toolStripMenuItem8_Click;
            this.toolMenuItemRectRecipientsPower.Name = "toolMenuItemRectRecipientsPower";
            this.toolMenuItemRectRecipientsPower.Size = new Size(197, 22);
            this.toolMenuItemRectRecipientsPower.Text = "Просчитать схему";
            this.toolMenuItemRectRecipientsPower.Click += this.toolStripMenuItem9_Click;
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new Size(194, 6);
            this.toolMenuItemRectFilter.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemRectFilterAdd,
                this.toolMenuItemRectFilterDel
            });
            this.toolMenuItemRectFilter.Name = "toolMenuItemRectFilter";
            this.toolMenuItemRectFilter.Size = new Size(197, 22);
            this.toolMenuItemRectFilter.Text = "Фильтр";
            this.toolMenuItemRectFilterAdd.Name = "toolMenuItemRectFilterAdd";
            this.toolMenuItemRectFilterAdd.Size = new Size(183, 22);
            this.toolMenuItemRectFilterAdd.Text = "Добавить в фильтр";
            this.toolMenuItemRectFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
            this.toolMenuItemRectFilterDel.Name = "toolMenuItemRectFilterDel";
            this.toolMenuItemRectFilterDel.Size = new Size(183, 22);
            this.toolMenuItemRectFilterDel.Text = "Удалить из фильтра";
            this.toolMenuItemRectFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(194, 6);
            this.toolMenuItemRectCopy.Name = "toolMenuItemRectCopy";
            this.toolMenuItemRectCopy.Size = new Size(197, 22);
            this.toolMenuItemRectCopy.Text = "Копировать";
            this.toolMenuItemRectCopy.Click += this.reArSpApSW_Click;
            this.toolMenuItemRectPaste.Name = "toolMenuItemRectPaste";
            this.toolMenuItemRectPaste.Size = new Size(197, 22);
            this.toolMenuItemRectPaste.Text = "Вставить";
            this.toolMenuItemRectPaste.Click += this.uBbItwaYjM_Click;
            this.toolMenuItemRectDel.Name = "toolMenuItemRectDel";
            this.toolMenuItemRectDel.Size = new Size(197, 22);
            this.toolMenuItemRectDel.Text = "Удалить";
            this.toolMenuItemRectDel.Click += this.toolMenuItemTextBranchDel_Click;
            this.toolStripMenuItemRectanglePosition.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemReflect,
                this.toolStripMenuItemRotateRectangle
            });
            this.toolStripMenuItemRectanglePosition.Name = "toolStripMenuItemRectanglePosition";
            this.toolStripMenuItemRectanglePosition.Size = new Size(197, 22);
            this.toolStripMenuItemRectanglePosition.Text = "Положение";
            this.toolStripMenuItemReflect.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemVReflect,
                this.toolStripMenuItemHReflect
            });
            this.toolStripMenuItemReflect.Name = "toolStripMenuItemReflect";
            this.toolStripMenuItemReflect.Size = new Size(133, 22);
            this.toolStripMenuItemReflect.Text = "Отразить";
            this.toolStripMenuItemVReflect.Name = "toolStripMenuItemVReflect";
            this.toolStripMenuItemVReflect.Size = new Size(163, 22);
            this.toolStripMenuItemVReflect.Tag = "V";
            this.toolStripMenuItemVReflect.Text = "По вертикали";
            this.toolStripMenuItemVReflect.Click += this.toolStripMenuItemHReflect_Click;
            this.toolStripMenuItemHReflect.Name = "toolStripMenuItemHReflect";
            this.toolStripMenuItemHReflect.Size = new Size(163, 22);
            this.toolStripMenuItemHReflect.Tag = "H";
            this.toolStripMenuItemHReflect.Text = "По горизонтали";
            this.toolStripMenuItemHReflect.Click += this.toolStripMenuItemHReflect_Click;
            this.toolStripMenuItemRotateRectangle.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemRotate90,
                this.toolStripMenuItemRotate180,
                this.toolStripMenuItemRotate170
            });
            this.toolStripMenuItemRotateRectangle.Name = "toolStripMenuItemRotateRectangle";
            this.toolStripMenuItemRotateRectangle.Size = new Size(133, 22);
            this.toolStripMenuItemRotateRectangle.Text = "Повернуть";
            this.toolStripMenuItemRotate90.Name = "toolStripMenuItemRotate90";
            this.toolStripMenuItemRotate90.Size = new Size(144, 22);
            this.toolStripMenuItemRotate90.Text = "90 градусов";
            this.toolStripMenuItemRotate180.Name = "toolStripMenuItemRotate180";
            this.toolStripMenuItemRotate180.Size = new Size(144, 22);
            this.toolStripMenuItemRotate180.Text = "180 градусов";
            this.toolStripMenuItemRotate170.Name = "toolStripMenuItemRotate170";
            this.toolStripMenuItemRotate170.Size = new Size(144, 22);
            this.toolStripMenuItemRotate170.Text = "270 градусов";
            this.toolMenuItemRectAlign.Name = "toolMenuItemRectAlign";
            this.toolMenuItemRectAlign.Size = new Size(197, 22);
            this.toolMenuItemRectAlign.Text = "Выровнить объекты";
            this.toolMenuItemRectAlign.Click += this.toolMenuItemRectAlign_Click;
            this.toolStripMenuItemAdjacentSubstation.Name = "toolStripMenuItemAdjacentSubstation";
            this.toolStripMenuItemAdjacentSubstation.Size = new Size(197, 22);
            this.toolStripMenuItemAdjacentSubstation.Text = "Смежные подстанции";
            this.toolStripMenuItemAdjacentSubstation.Click += this.toolStripMenuItemAdjacentSubstation2_Click;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(194, 6);
            this.toolMenuItemRectFile.Name = "toolMenuItemRectFile";
            this.toolMenuItemRectFile.Size = new Size(197, 22);
            this.toolMenuItemRectFile.Text = "Файлы";
            this.toolMenuItemRectFile.Click += this.toolMenuItemLineFile_Click;
            this.toolMenuItemRectProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
            this.toolMenuItemRectProperty.Name = "toolMenuItemRectProperty";
            this.toolMenuItemRectProperty.Size = new Size(197, 22);
            this.toolMenuItemRectProperty.Text = "Свойства объекта";
            this.toolMenuItemRectProperty.Click += this.WcgruJuvXg_Click;
            this.contextMenuShina.ImageScalingSize = new Size(20, 20);
            this.contextMenuShina.Items.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemShinaAddChild,
                this.toolMenuItemShinaCopy,
                this.toolMenuItemShinaPaste,
                this.toolMenuItemShinaDel,
                this.toolStripSeparatorEditShina,
                this.toolStripMenuItemBusMeasurement,
                this.toolMenuItemShinaPowerSource,
                this.toolMenuItemShinaRecipientsPower,
                this.toolStripMenuItem11,
                this.toolStripMenuItemAllPower,
                this.toolStripMenuItemAdjacentSubstation2,
                this.toolStripMenuItemShinaGetOldAbn,
                this.toolStripSeparator3,
                this.toolMenuItemShinaFilter,
                this.toolStripSeparator11,
                this.toolMenuItemShinaFile,
                this.toolMenuItemShinaProperty
            });
            this.contextMenuShina.Name = "contextMenuShina";
            this.contextMenuShina.Size = new Size(277, 330);
            this.contextMenuShina.Opening += this.contextMenuShina_Opening;
            this.toolMenuItemShinaAddChild.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemShinaAddCell,
                this.toolMenuItemShinaBridge,
                this.toolMenuItemShinaSplitter,
                this.toolStripMenuItemAddWhitePoint,
                this.toolMeniItemShinaAddPattern,
                this.toolStripSeparator7,
                this.waWrHaQms2,
                this.ldtrvofZuY
            });
            this.toolMenuItemShinaAddChild.Name = "toolMenuItemShinaAddChild";
            this.toolMenuItemShinaAddChild.Size = new Size(276, 22);
            this.toolMenuItemShinaAddChild.Text = "Добавить";
            this.toolMenuItemShinaAddCell.Name = "toolMenuItemShinaAddCell";
            this.toolMenuItemShinaAddCell.Size = new Size(232, 22);
            this.toolMenuItemShinaAddCell.Text = "Ячейку";
            this.toolMenuItemShinaAddCell.Click += this.toolMenuItemShinaAddCell_Click;
            this.toolMenuItemShinaBridge.Name = "toolMenuItemShinaBridge";
            this.toolMenuItemShinaBridge.Size = new Size(232, 22);
            this.toolMenuItemShinaBridge.Text = "Межшинный мост";
            this.toolMenuItemShinaBridge.Visible = false;
            this.toolMenuItemShinaBridge.Click += this.toolMenuItemShinaBridge_Click;
            this.toolMenuItemShinaSplitter.Name = "toolMenuItemShinaSplitter";
            this.toolMenuItemShinaSplitter.Size = new Size(232, 22);
            this.toolMenuItemShinaSplitter.Text = "Разветвитель";
            this.toolMenuItemShinaSplitter.Visible = false;
            this.toolMenuItemShinaSplitter.Click += this.toolMenuItemShinaSplitter_Click;
            this.toolStripMenuItemAddWhitePoint.Name = "toolStripMenuItemAddWhitePoint";
            this.toolStripMenuItemAddWhitePoint.Size = new Size(232, 22);
            this.toolStripMenuItemAddWhitePoint.Text = "ВН на трансформаторе";
            this.toolStripMenuItemAddWhitePoint.Click += this.toolStripMenuItemAddWhitePoint_Click;
            this.toolMeniItemShinaAddPattern.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemShinaAddPatternAbn,
                this.toolMenuItemShinaAddPatternAbnAuto,
                this.toolMenuItemShinaAddPatternAbnReserve,
                this.toolMenuItemShinaAddPatternAbnRPS
            });
            this.toolMeniItemShinaAddPattern.Name = "toolMeniItemShinaAddPattern";
            this.toolMeniItemShinaAddPattern.Size = new Size(232, 22);
            this.toolMeniItemShinaAddPattern.Text = "Шаблон";
            this.toolMenuItemShinaAddPatternAbn.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.oGyhJxxeRR,
                this.toolMenuItemShinaAddPatternAbn2,
                this.toolMenuItemShinaAddPatternAbn3,
                this.toolMenuItemShinaAddPatternAbn4,
                this.toolMenuItemShinaAddPatternAbn5,
                this.toolMenuItemShinaAddPatternAbn6,
                this.toolMenuItemShinaAddPatternAbn7,
                this.toolMenuItemShinaAddPatternAbn8,
                this.toolMenuItemShinaAddPatternAbn9,
                this.toolMenuItemShinaAddPatternAbn10
            });
            this.toolMenuItemShinaAddPatternAbn.Name = "toolMenuItemShinaAddPatternAbn";
            this.toolMenuItemShinaAddPatternAbn.Size = new Size(271, 22);
            this.toolMenuItemShinaAddPatternAbn.Text = "Выходная на потребителя(ЛР)";
            this.toolMenuItemShinaAddPatternAbn.Click += this.toolMenuItemShinaAddPatternAbn_Click;
            this.oGyhJxxeRR.Name = "toolMenuItemShinaAddPatternAbn1";
            this.oGyhJxxeRR.Size = new Size(86, 22);
            this.oGyhJxxeRR.Tag = "1";
            this.oGyhJxxeRR.Text = "1";
            this.oGyhJxxeRR.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn2.Name = "toolMenuItemShinaAddPatternAbn2";
            this.toolMenuItemShinaAddPatternAbn2.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn2.Tag = "2";
            this.toolMenuItemShinaAddPatternAbn2.Text = "2";
            this.toolMenuItemShinaAddPatternAbn2.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn3.Name = "toolMenuItemShinaAddPatternAbn3";
            this.toolMenuItemShinaAddPatternAbn3.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn3.Tag = "3";
            this.toolMenuItemShinaAddPatternAbn3.Text = "3";
            this.toolMenuItemShinaAddPatternAbn3.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn4.Name = "toolMenuItemShinaAddPatternAbn4";
            this.toolMenuItemShinaAddPatternAbn4.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn4.Tag = "4";
            this.toolMenuItemShinaAddPatternAbn4.Text = "4";
            this.toolMenuItemShinaAddPatternAbn4.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn5.Name = "toolMenuItemShinaAddPatternAbn5";
            this.toolMenuItemShinaAddPatternAbn5.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn5.Tag = "5";
            this.toolMenuItemShinaAddPatternAbn5.Text = "5";
            this.toolMenuItemShinaAddPatternAbn5.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn6.Name = "toolMenuItemShinaAddPatternAbn6";
            this.toolMenuItemShinaAddPatternAbn6.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn6.Tag = "6";
            this.toolMenuItemShinaAddPatternAbn6.Text = "6";
            this.toolMenuItemShinaAddPatternAbn6.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn7.Name = "toolMenuItemShinaAddPatternAbn7";
            this.toolMenuItemShinaAddPatternAbn7.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn7.Tag = "7";
            this.toolMenuItemShinaAddPatternAbn7.Text = "7";
            this.toolMenuItemShinaAddPatternAbn7.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn8.Name = "toolMenuItemShinaAddPatternAbn8";
            this.toolMenuItemShinaAddPatternAbn8.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn8.Tag = "8";
            this.toolMenuItemShinaAddPatternAbn8.Text = "8";
            this.toolMenuItemShinaAddPatternAbn8.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn9.Name = "toolMenuItemShinaAddPatternAbn9";
            this.toolMenuItemShinaAddPatternAbn9.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn9.Tag = "9";
            this.toolMenuItemShinaAddPatternAbn9.Text = "9";
            this.toolMenuItemShinaAddPatternAbn9.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbn10.Name = "toolMenuItemShinaAddPatternAbn10";
            this.toolMenuItemShinaAddPatternAbn10.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbn10.Tag = "10";
            this.toolMenuItemShinaAddPatternAbn10.Text = "10";
            this.toolMenuItemShinaAddPatternAbn10.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemShinaAddPatternAbnAuto1,
                this.toolMenuItemShinaAddPatternAbnAuto2,
                this.toolMenuItemShinaAddPatternAbnAuto3,
                this.toolMenuItemShinaAddPatternAbnAuto4,
                this.toolMenuItemShinaAddPatternAbnAuto5,
                this.toolMenuItemShinaAddPatternAbnAuto6,
                this.toolMenuItemShinaAddPatternAbnAuto7,
                this.toolMenuItemShinaAddPatternAbnAuto8,
                this.toolMenuItemShinaAddPatternAbnAuto9,
                this.toolMenuItemShinaAddPatternAbnAuto10
            });
            this.toolMenuItemShinaAddPatternAbnAuto.Name = "toolMenuItemShinaAddPatternAbnAuto";
            this.toolMenuItemShinaAddPatternAbnAuto.Size = new Size(271, 22);
            this.toolMenuItemShinaAddPatternAbnAuto.Text = "Выходная на потребителя (автомат)";
            this.toolMenuItemShinaAddPatternAbnAuto1.Name = "toolMenuItemShinaAddPatternAbnAuto1";
            this.toolMenuItemShinaAddPatternAbnAuto1.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto1.Tag = "1";
            this.toolMenuItemShinaAddPatternAbnAuto1.Text = "1";
            this.toolMenuItemShinaAddPatternAbnAuto1.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto2.Name = "toolMenuItemShinaAddPatternAbnAuto2";
            this.toolMenuItemShinaAddPatternAbnAuto2.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto2.Tag = "2";
            this.toolMenuItemShinaAddPatternAbnAuto2.Text = "2";
            this.toolMenuItemShinaAddPatternAbnAuto2.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto3.Name = "toolMenuItemShinaAddPatternAbnAuto3";
            this.toolMenuItemShinaAddPatternAbnAuto3.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto3.Tag = "3";
            this.toolMenuItemShinaAddPatternAbnAuto3.Text = "3";
            this.toolMenuItemShinaAddPatternAbnAuto3.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto4.Name = "toolMenuItemShinaAddPatternAbnAuto4";
            this.toolMenuItemShinaAddPatternAbnAuto4.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto4.Tag = "4";
            this.toolMenuItemShinaAddPatternAbnAuto4.Text = "4";
            this.toolMenuItemShinaAddPatternAbnAuto4.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto5.Name = "toolMenuItemShinaAddPatternAbnAuto5";
            this.toolMenuItemShinaAddPatternAbnAuto5.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto5.Tag = "5";
            this.toolMenuItemShinaAddPatternAbnAuto5.Text = "5";
            this.toolMenuItemShinaAddPatternAbnAuto5.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto6.Name = "toolMenuItemShinaAddPatternAbnAuto6";
            this.toolMenuItemShinaAddPatternAbnAuto6.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto6.Tag = "6";
            this.toolMenuItemShinaAddPatternAbnAuto6.Text = "6";
            this.toolMenuItemShinaAddPatternAbnAuto6.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto7.Name = "toolMenuItemShinaAddPatternAbnAuto7";
            this.toolMenuItemShinaAddPatternAbnAuto7.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto7.Tag = "7";
            this.toolMenuItemShinaAddPatternAbnAuto7.Text = "7";
            this.toolMenuItemShinaAddPatternAbnAuto7.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto8.Name = "toolMenuItemShinaAddPatternAbnAuto8";
            this.toolMenuItemShinaAddPatternAbnAuto8.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto8.Tag = "8";
            this.toolMenuItemShinaAddPatternAbnAuto8.Text = "8";
            this.toolMenuItemShinaAddPatternAbnAuto8.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto9.Name = "toolMenuItemShinaAddPatternAbnAuto9";
            this.toolMenuItemShinaAddPatternAbnAuto9.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto9.Tag = "9";
            this.toolMenuItemShinaAddPatternAbnAuto9.Text = "9";
            this.toolMenuItemShinaAddPatternAbnAuto9.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnAuto10.Name = "toolMenuItemShinaAddPatternAbnAuto10";
            this.toolMenuItemShinaAddPatternAbnAuto10.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnAuto10.Tag = "10";
            this.toolMenuItemShinaAddPatternAbnAuto10.Text = "10";
            this.toolMenuItemShinaAddPatternAbnAuto10.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemShinaAddPatternAbnReserve1,
                this.toolMenuItemShinaAddPatternAbnReserve2,
                this.toolMenuItemShinaAddPatternAbnReserve3,
                this.toolMenuItemShinaAddPatternAbnReserve4,
                this.toolMenuItemShinaAddPatternAbnReserve5,
                this.toolMenuItemShinaAddPatternAbnReserve6,
                this.toolMenuItemShinaAddPatternAbnReserve7,
                this.toolMenuItemShinaAddPatternAbnReserve8,
                this.toolMenuItemShinaAddPatternAbnReserve9,
                this.toolMenuItemShinaAddPatternAbnReserve10
            });
            this.toolMenuItemShinaAddPatternAbnReserve.Name = "toolMenuItemShinaAddPatternAbnReserve";
            this.toolMenuItemShinaAddPatternAbnReserve.Size = new Size(271, 22);
            this.toolMenuItemShinaAddPatternAbnReserve.Text = "Выходная на потребителя (резерв)";
            this.toolMenuItemShinaAddPatternAbnReserve.Click += this.toolMenuItemShinaAddPatternAbnReserve_Click;
            this.toolMenuItemShinaAddPatternAbnReserve1.Name = "toolMenuItemShinaAddPatternAbnReserve1";
            this.toolMenuItemShinaAddPatternAbnReserve1.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve1.Tag = "1";
            this.toolMenuItemShinaAddPatternAbnReserve1.Text = "1";
            this.toolMenuItemShinaAddPatternAbnReserve1.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve2.Name = "toolMenuItemShinaAddPatternAbnReserve2";
            this.toolMenuItemShinaAddPatternAbnReserve2.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve2.Tag = "2";
            this.toolMenuItemShinaAddPatternAbnReserve2.Text = "2";
            this.toolMenuItemShinaAddPatternAbnReserve2.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve3.Name = "toolMenuItemShinaAddPatternAbnReserve3";
            this.toolMenuItemShinaAddPatternAbnReserve3.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve3.Tag = "3";
            this.toolMenuItemShinaAddPatternAbnReserve3.Text = "3";
            this.toolMenuItemShinaAddPatternAbnReserve3.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve4.Name = "toolMenuItemShinaAddPatternAbnReserve4";
            this.toolMenuItemShinaAddPatternAbnReserve4.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve4.Tag = "4";
            this.toolMenuItemShinaAddPatternAbnReserve4.Text = "4";
            this.toolMenuItemShinaAddPatternAbnReserve4.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve5.Name = "toolMenuItemShinaAddPatternAbnReserve5";
            this.toolMenuItemShinaAddPatternAbnReserve5.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve5.Tag = "5";
            this.toolMenuItemShinaAddPatternAbnReserve5.Text = "5";
            this.toolMenuItemShinaAddPatternAbnReserve5.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve6.Name = "toolMenuItemShinaAddPatternAbnReserve6";
            this.toolMenuItemShinaAddPatternAbnReserve6.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve6.Tag = "6";
            this.toolMenuItemShinaAddPatternAbnReserve6.Text = "6";
            this.toolMenuItemShinaAddPatternAbnReserve6.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve7.Name = "toolMenuItemShinaAddPatternAbnReserve7";
            this.toolMenuItemShinaAddPatternAbnReserve7.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve7.Tag = "7";
            this.toolMenuItemShinaAddPatternAbnReserve7.Text = "7";
            this.toolMenuItemShinaAddPatternAbnReserve7.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve8.Name = "toolMenuItemShinaAddPatternAbnReserve8";
            this.toolMenuItemShinaAddPatternAbnReserve8.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve8.Tag = "8";
            this.toolMenuItemShinaAddPatternAbnReserve8.Text = "8";
            this.toolMenuItemShinaAddPatternAbnReserve8.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve9.Name = "toolMenuItemShinaAddPatternAbnReserve9";
            this.toolMenuItemShinaAddPatternAbnReserve9.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve9.Tag = "9";
            this.toolMenuItemShinaAddPatternAbnReserve9.Text = "9";
            this.toolMenuItemShinaAddPatternAbnReserve9.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnReserve10.Name = "toolMenuItemShinaAddPatternAbnReserve10";
            this.toolMenuItemShinaAddPatternAbnReserve10.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnReserve10.Tag = "10";
            this.toolMenuItemShinaAddPatternAbnReserve10.Text = "10";
            this.toolMenuItemShinaAddPatternAbnReserve10.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemShinaAddPatternAbnRPS1,
                this.toolMenuItemShinaAddPatternAbnRPS2,
                this.toolMenuItemShinaAddPatternAbnRPS3,
                this.toolMenuItemShinaAddPatternAbnRPS4,
                this.toolMenuItemShinaAddPatternAbnRPS5,
                this.toolMenuItemShinaAddPatternAbnRPS6,
                this.toolMenuItemShinaAddPatternAbnRPS7,
                this.toolMenuItemShinaAddPatternAbnRPS8,
                this.EhkrgnfgYC,
                this.toolMenuItemShinaAddPatternAbnRPS10
            });
            this.toolMenuItemShinaAddPatternAbnRPS.Name = "toolMenuItemShinaAddPatternAbnRPS";
            this.toolMenuItemShinaAddPatternAbnRPS.Size = new Size(271, 22);
            this.toolMenuItemShinaAddPatternAbnRPS.Text = "Выходная на потребителя (РПС)";
            this.toolMenuItemShinaAddPatternAbnRPS.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS1.Name = "toolMenuItemShinaAddPatternAbnRPS1";
            this.toolMenuItemShinaAddPatternAbnRPS1.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS1.Tag = "1";
            this.toolMenuItemShinaAddPatternAbnRPS1.Text = "1";
            this.toolMenuItemShinaAddPatternAbnRPS1.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS2.Name = "toolMenuItemShinaAddPatternAbnRPS2";
            this.toolMenuItemShinaAddPatternAbnRPS2.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS2.Tag = "2";
            this.toolMenuItemShinaAddPatternAbnRPS2.Text = "2";
            this.toolMenuItemShinaAddPatternAbnRPS2.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS3.Name = "toolMenuItemShinaAddPatternAbnRPS3";
            this.toolMenuItemShinaAddPatternAbnRPS3.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS3.Tag = "3";
            this.toolMenuItemShinaAddPatternAbnRPS3.Text = "3";
            this.toolMenuItemShinaAddPatternAbnRPS3.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS4.Name = "toolMenuItemShinaAddPatternAbnRPS4";
            this.toolMenuItemShinaAddPatternAbnRPS4.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS4.Tag = "4";
            this.toolMenuItemShinaAddPatternAbnRPS4.Text = "4";
            this.toolMenuItemShinaAddPatternAbnRPS4.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS5.Name = "toolMenuItemShinaAddPatternAbnRPS5";
            this.toolMenuItemShinaAddPatternAbnRPS5.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS5.Tag = "5";
            this.toolMenuItemShinaAddPatternAbnRPS5.Text = "5";
            this.toolMenuItemShinaAddPatternAbnRPS5.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS6.Name = "toolMenuItemShinaAddPatternAbnRPS6";
            this.toolMenuItemShinaAddPatternAbnRPS6.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS6.Tag = "6";
            this.toolMenuItemShinaAddPatternAbnRPS6.Text = "6";
            this.toolMenuItemShinaAddPatternAbnRPS6.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS7.Name = "toolMenuItemShinaAddPatternAbnRPS7";
            this.toolMenuItemShinaAddPatternAbnRPS7.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS7.Tag = "7";
            this.toolMenuItemShinaAddPatternAbnRPS7.Text = "7";
            this.toolMenuItemShinaAddPatternAbnRPS7.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS8.Name = "toolMenuItemShinaAddPatternAbnRPS8";
            this.toolMenuItemShinaAddPatternAbnRPS8.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS8.Tag = "8";
            this.toolMenuItemShinaAddPatternAbnRPS8.Text = "8";
            this.toolMenuItemShinaAddPatternAbnRPS8.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.EhkrgnfgYC.Name = "toolMenuItemShinaAddPatternAbnRPS9";
            this.EhkrgnfgYC.Size = new Size(86, 22);
            this.EhkrgnfgYC.Tag = "9";
            this.EhkrgnfgYC.Text = "9";
            this.EhkrgnfgYC.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolMenuItemShinaAddPatternAbnRPS10.Name = "toolMenuItemShinaAddPatternAbnRPS10";
            this.toolMenuItemShinaAddPatternAbnRPS10.Size = new Size(86, 22);
            this.toolMenuItemShinaAddPatternAbnRPS10.Tag = "10";
            this.toolMenuItemShinaAddPatternAbnRPS10.Text = "10";
            this.toolMenuItemShinaAddPatternAbnRPS10.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new Size(229, 6);
            this.waWrHaQms2.Name = "toolStripMenuItemMeasurement";
            this.waWrHaQms2.Size = new Size(232, 22);
            this.waWrHaQms2.Text = "Вывести данные о замерах";
            this.waWrHaQms2.Click += this.waWrHaQms2_Click;
            this.ldtrvofZuY.Name = "toolStripMenuItemShinaAddTelemetryLabel";
            this.ldtrvofZuY.Size = new Size(232, 22);
            this.ldtrvofZuY.Text = "Вывести данные телеметрии";
            this.ldtrvofZuY.Click += this.QyjrxReCs8_Click;
            this.toolMenuItemShinaCopy.Name = "toolMenuItemShinaCopy";
            this.toolMenuItemShinaCopy.Size = new Size(276, 22);
            this.toolMenuItemShinaCopy.Text = "Копировать";
            this.toolMenuItemShinaCopy.Click += this.reArSpApSW_Click;
            this.toolMenuItemShinaPaste.Name = "toolMenuItemShinaPaste";
            this.toolMenuItemShinaPaste.Size = new Size(276, 22);
            this.toolMenuItemShinaPaste.Text = "Вставить";
            this.toolMenuItemShinaPaste.Click += this.uBbItwaYjM_Click;
            this.toolMenuItemShinaDel.Name = "toolMenuItemShinaDel";
            this.toolMenuItemShinaDel.Size = new Size(276, 22);
            this.toolMenuItemShinaDel.Text = "Удалить";
            this.toolMenuItemShinaDel.Click += this.toolMenuItemTextBranchDel_Click;
            this.toolStripSeparatorEditShina.Name = "toolStripSeparatorEditShina";
            this.toolStripSeparatorEditShina.Size = new Size(273, 6);
            this.toolStripMenuItemBusMeasurement.Name = "toolStripMenuItemBusMeasurement";
            this.toolStripMenuItemBusMeasurement.Size = new Size(276, 22);
            this.toolStripMenuItemBusMeasurement.Text = "Замеры";
            this.toolStripMenuItemBusMeasurement.Click += this.toolStripMenuItemBusMeasurement_Click;
            this.toolMenuItemShinaPowerSource.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem2,
                this.toolStripMenuItem5
            });
            this.toolMenuItemShinaPowerSource.Name = "toolMenuItemShinaPowerSource";
            this.toolMenuItemShinaPowerSource.Size = new Size(276, 22);
            this.toolMenuItemShinaPowerSource.Text = "Просчитать запитку";
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(186, 22);
            this.toolStripMenuItem2.Tag = "1";
            this.toolStripMenuItem2.Text = "Выделить";
            this.toolStripMenuItem2.Click += this.toolStripMenuItem8_Click;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new Size(186, 22);
            this.toolStripMenuItem5.Tag = "2";
            this.toolStripMenuItem5.Text = "Выделить миганием";
            this.toolStripMenuItem5.Click += this.toolStripMenuItem8_Click;
            this.toolMenuItemShinaRecipientsPower.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem3,
                this.toolStripMenuItem4
            });
            this.toolMenuItemShinaRecipientsPower.Name = "toolMenuItemShinaRecipientsPower";
            this.toolMenuItemShinaRecipientsPower.Size = new Size(276, 22);
            this.toolMenuItemShinaRecipientsPower.Text = "Просчитать схему";
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(186, 22);
            this.toolStripMenuItem3.Tag = "1";
            this.toolStripMenuItem3.Text = "Выделить";
            this.toolStripMenuItem3.Click += this.toolStripMenuItem9_Click;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(186, 22);
            this.toolStripMenuItem4.Tag = "2";
            this.toolStripMenuItem4.Text = "Выделить миганием";
            this.toolStripMenuItem4.Click += this.toolStripMenuItem9_Click;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new Size(276, 22);
            this.toolStripMenuItem11.Text = "Альтернативные источники питания";
            this.toolStripMenuItem11.Click += this.toolStripMenuItem11_Click;
            this.toolStripMenuItemAllPower.Name = "toolStripMenuItemAllPower";
            this.toolStripMenuItemAllPower.Size = new Size(276, 22);
            this.toolStripMenuItemAllPower.Text = "Все возможные источники питания";
            this.toolStripMenuItemAllPower.Visible = false;
            this.toolStripMenuItemAllPower.Click += this.toolStripMenuItem10_Click;
            this.toolStripMenuItemAdjacentSubstation2.Name = "toolStripMenuItemAdjacentSubstation2";
            this.toolStripMenuItemAdjacentSubstation2.Size = new Size(276, 22);
            this.toolStripMenuItemAdjacentSubstation2.Text = "Смежные подстанции";
            this.toolStripMenuItemAdjacentSubstation2.Click += this.toolStripMenuItemAdjacentSubstation2_Click;
            this.toolStripMenuItemShinaGetOldAbn.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemShinaOldAbnCurrentRect,
                this.toolStripMenuItemShinaOldAbnNextRect
            });
            this.toolStripMenuItemShinaGetOldAbn.Name = "toolStripMenuItemShinaGetOldAbn";
            this.toolStripMenuItemShinaGetOldAbn.Size = new Size(276, 22);
            this.toolStripMenuItemShinaGetOldAbn.Text = "Абоненты";
            this.toolStripMenuItemShinaOldAbnCurrentRect.Name = "toolStripMenuItemShinaOldAbnCurrentRect";
            this.toolStripMenuItemShinaOldAbnCurrentRect.Size = new Size(191, 22);
            this.toolStripMenuItemShinaOldAbnCurrentRect.Text = "Текущей подстанции";
            this.toolStripMenuItemShinaOldAbnCurrentRect.Click += this.toolStripMenuItem14_Click;
            this.toolStripMenuItemShinaOldAbnNextRect.Name = "toolStripMenuItemShinaOldAbnNextRect";
            this.toolStripMenuItemShinaOldAbnNextRect.Size = new Size(191, 22);
            this.toolStripMenuItemShinaOldAbnNextRect.Tag = "1";
            this.toolStripMenuItemShinaOldAbnNextRect.Text = "По цепочке";
            this.toolStripMenuItemShinaOldAbnNextRect.Click += this.toolStripMenuItem14_Click;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(273, 6);
            this.toolMenuItemShinaFilter.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemShinaFilterAdd,
                this.toolMenuItemShinaFilterDel
            });
            this.toolMenuItemShinaFilter.Name = "toolMenuItemShinaFilter";
            this.toolMenuItemShinaFilter.Size = new Size(276, 22);
            this.toolMenuItemShinaFilter.Text = "Фильтр";
            this.toolMenuItemShinaFilterAdd.Name = "toolMenuItemShinaFilterAdd";
            this.toolMenuItemShinaFilterAdd.Size = new Size(183, 22);
            this.toolMenuItemShinaFilterAdd.Text = "Добавить в фильтр";
            this.toolMenuItemShinaFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
            this.toolMenuItemShinaFilterDel.Name = "toolMenuItemShinaFilterDel";
            this.toolMenuItemShinaFilterDel.Size = new Size(183, 22);
            this.toolMenuItemShinaFilterDel.Text = "Удалить из фильтра";
            this.toolMenuItemShinaFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new Size(273, 6);
            this.toolMenuItemShinaFile.Name = "toolMenuItemShinaFile";
            this.toolMenuItemShinaFile.Size = new Size(276, 22);
            this.toolMenuItemShinaFile.Text = "Файлы";
            this.toolMenuItemShinaFile.Click += this.toolMenuItemLineFile_Click;
            this.toolMenuItemShinaProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
            this.toolMenuItemShinaProperty.Name = "toolMenuItemShinaProperty";
            this.toolMenuItemShinaProperty.Size = new Size(276, 22);
            this.toolMenuItemShinaProperty.Text = "Свойства объекта";
            this.toolMenuItemShinaProperty.Click += this.WcgruJuvXg_Click;
            this.contextMenuSwitchTool.ImageScalingSize = new Size(20, 20);
            this.contextMenuSwitchTool.Items.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemSwitchPassport,
                this.toolMenuItemSwitchOn,
                this.toolStripMenuChangeArrowDirection,
                this.toolMenuItemSwitchFilter,
                this.toolStripMenuItemOOLDisplayGrLevel,
                this.toolStripMenuItemSwitchAddTelemetry,
                this.toolMenuItemSwitchErcloud,
                this.toolStripSeparator12,
                this.toolStripMenuItemCSRollingOut,
                this.toolStripMenuItemCSNormalMode,
                this.toolStripSeparatorCS,
                this.toolMenuItemStateDel,
                this.toolMenuItemSwitchCopy,
                this.toolMenuItemSwitchDel,
                this.toolStripSeparator5,
                this.ToolStripMenuItemSwitchMeasurement,
                this.toolMenuItemSwitchLogDispatcher,
                this.toolMenuItemSwitchFile,
                this.MSMZJEXRVG
            });
            this.contextMenuSwitchTool.Name = "contextMenuSwitchTool";
            this.contextMenuSwitchTool.Size = new Size(251, 374);
            this.contextMenuSwitchTool.Opening += this.contextMenuSwitchTool_Opening;
            this.toolMenuItemSwitchPassport.Name = "toolMenuItemSwitchPassport";
            this.toolMenuItemSwitchPassport.Size = new Size(250, 22);
            this.toolMenuItemSwitchPassport.Text = "Паспорт";
            this.toolMenuItemSwitchPassport.Click += this.toolMenuItemSwitchPassport_Click;
            this.toolMenuItemSwitchOn.Name = "toolMenuItemSwitchOn";
            this.toolMenuItemSwitchOn.Size = new Size(250, 22);
            this.toolMenuItemSwitchOn.Text = "Включить";
            this.toolMenuItemSwitchOn.Click += this.toolMenuItemSwitchOn_Click;
            this.toolStripMenuChangeArrowDirection.Name = "toolStripMenuChangeArrowDirection";
            this.toolStripMenuChangeArrowDirection.Size = new Size(250, 22);
            this.toolStripMenuChangeArrowDirection.Text = "Изменить направление стрелки";
            this.toolStripMenuChangeArrowDirection.Click += this.toolStripMenuChangeArrowDirection_Click;
            this.toolMenuItemSwitchFilter.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemSwitchFilterAdd,
                this.toolMenuItemSwitchFilterDel
            });
            this.toolMenuItemSwitchFilter.Name = "toolMenuItemSwitchFilter";
            this.toolMenuItemSwitchFilter.Size = new Size(250, 22);
            this.toolMenuItemSwitchFilter.Text = "Фильтр";
            this.toolMenuItemSwitchFilterAdd.Name = "toolMenuItemSwitchFilterAdd";
            this.toolMenuItemSwitchFilterAdd.Size = new Size(183, 22);
            this.toolMenuItemSwitchFilterAdd.Text = "Добавить в фильтр";
            this.toolMenuItemSwitchFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
            this.toolMenuItemSwitchFilterDel.Name = "toolMenuItemSwitchFilterDel";
            this.toolMenuItemSwitchFilterDel.Size = new Size(183, 22);
            this.toolMenuItemSwitchFilterDel.Text = "Удалить из фильтра";
            this.toolMenuItemSwitchFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
            this.toolStripMenuItemOOLDisplayGrLevel.Name = "toolStripMenuItemOOLDisplayGrLevel";
            this.toolStripMenuItemOOLDisplayGrLevel.Size = new Size(250, 22);
            this.toolStripMenuItemOOLDisplayGrLevel.Text = "Отобразить на первом уровне";
            this.toolStripMenuItemOOLDisplayGrLevel.Click += this.toolStripMenuItemTBTDisplayGrLevel_Click;
            this.toolStripMenuItemSwitchAddTelemetry.Name = "toolStripMenuItemSwitchAddTelemetry";
            this.toolStripMenuItemSwitchAddTelemetry.Size = new Size(250, 22);
            this.toolStripMenuItemSwitchAddTelemetry.Text = "Вывести данные телеметрии";
            this.toolStripMenuItemSwitchAddTelemetry.Click += this.QyjrxReCs8_Click;
            this.toolMenuItemSwitchErcloud.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemSwitchLinkErcloud,
                this.toolMenuItemSwitchShowDataErcloud
            });
            this.toolMenuItemSwitchErcloud.Name = "toolMenuItemSwitchErcloud";
            this.toolMenuItemSwitchErcloud.Size = new Size(250, 22);
            this.toolMenuItemSwitchErcloud.Text = "Ercloud";
            this.toolMenuItemSwitchLinkErcloud.Name = "toolMenuItemSwitchLinkErcloud";
            this.toolMenuItemSwitchLinkErcloud.Size = new Size(221, 22);
            this.toolMenuItemSwitchLinkErcloud.Text = "Привязать объект к АСКУЭ";
            this.toolMenuItemSwitchLinkErcloud.Click += this.toolMenuItemSwitchLinkErcloud_Click;
            this.toolMenuItemSwitchShowDataErcloud.Name = "toolMenuItemSwitchShowDataErcloud";
            this.toolMenuItemSwitchShowDataErcloud.Size = new Size(221, 22);
            this.toolMenuItemSwitchShowDataErcloud.Text = "Данные АСКУЭ";
            this.toolMenuItemSwitchShowDataErcloud.Click += this.toolMenuItemSwitchShowDataErcloud_Click;
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new Size(247, 6);
            this.toolStripMenuItemCSRollingOut.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemCSRepairMode,
                this.toolStripMenuItemCSTestMode
            });
            this.toolStripMenuItemCSRollingOut.Name = "toolStripMenuItemCSRollingOut";
            this.toolStripMenuItemCSRollingOut.Size = new Size(250, 22);
            this.toolStripMenuItemCSRollingOut.Text = "Выкатить";
            this.toolStripMenuItemCSRepairMode.Name = "toolStripMenuItemCSRepairMode";
            this.toolStripMenuItemCSRepairMode.Size = new Size(136, 22);
            this.toolStripMenuItemCSRepairMode.Text = "Ремонт";
            this.toolStripMenuItemCSRepairMode.Click += this.toolStripMenuItemCSRepairMode_Click;
            this.toolStripMenuItemCSTestMode.Name = "toolStripMenuItemCSTestMode";
            this.toolStripMenuItemCSTestMode.Size = new Size(136, 22);
            this.toolStripMenuItemCSTestMode.Text = "Испытания";
            this.toolStripMenuItemCSTestMode.Click += this.toolStripMenuItemCSTestMode_Click;
            this.toolStripMenuItemCSNormalMode.Name = "toolStripMenuItemCSNormalMode";
            this.toolStripMenuItemCSNormalMode.Size = new Size(250, 22);
            this.toolStripMenuItemCSNormalMode.Text = "Рабочий режим";
            this.toolStripMenuItemCSNormalMode.Click += this.toolStripMenuItemCSNormalMode_Click;
            this.toolStripSeparatorCS.Name = "toolStripSeparatorCS";
            this.toolStripSeparatorCS.Size = new Size(247, 6);
            this.toolMenuItemStateDel.Name = "toolMenuItemStateDel";
            this.toolMenuItemStateDel.Size = new Size(250, 22);
            this.toolMenuItemStateDel.Text = "Убрать статус";
            this.toolMenuItemStateDel.Click += this.toolMenuItemStateDel_Click;
            this.toolMenuItemSwitchCopy.Name = "toolMenuItemSwitchCopy";
            this.toolMenuItemSwitchCopy.Size = new Size(250, 22);
            this.toolMenuItemSwitchCopy.Text = "Копировать";
            this.toolMenuItemSwitchCopy.Click += this.reArSpApSW_Click;
            this.toolMenuItemSwitchDel.Name = "toolMenuItemSwitchDel";
            this.toolMenuItemSwitchDel.Size = new Size(250, 22);
            this.toolMenuItemSwitchDel.Text = "Удалить";
            this.toolMenuItemSwitchDel.Click += this.toolMenuItemTextBranchDel_Click;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(247, 6);
            this.ToolStripMenuItemSwitchMeasurement.Name = "ToolStripMenuItemSwitchMeasurement";
            this.ToolStripMenuItemSwitchMeasurement.Size = new Size(250, 22);
            this.ToolStripMenuItemSwitchMeasurement.Text = "Замеры";
            this.ToolStripMenuItemSwitchMeasurement.Click += this.ToolStripMenuItemSwitchMeasurement_Click;
            this.toolMenuItemSwitchLogDispatcher.Name = "toolMenuItemSwitchLogDispatcher";
            this.toolMenuItemSwitchLogDispatcher.Size = new Size(250, 22);
            this.toolMenuItemSwitchLogDispatcher.Text = "Отчет диспетчера";
            this.toolMenuItemSwitchLogDispatcher.Click += this.toolMenuItemSwitchLogDispatcher_Click;
            this.toolMenuItemSwitchFile.Name = "toolMenuItemSwitchFile";
            this.toolMenuItemSwitchFile.Size = new Size(250, 22);
            this.toolMenuItemSwitchFile.Text = "Файлы";
            this.toolMenuItemSwitchFile.Click += this.toolMenuItemLineFile_Click;
            this.MSMZJEXRVG.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
            this.MSMZJEXRVG.Name = "toolMenuItemSwitchProperty";
            this.MSMZJEXRVG.Size = new Size(250, 22);
            this.MSMZJEXRVG.Text = "Свойства объекта";
            this.MSMZJEXRVG.Click += this.WcgruJuvXg_Click;
            this.contextMenuLineTool.ImageScalingSize = new Size(20, 20);
            this.contextMenuLineTool.Items.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemLineAddChild,
                this.toolMenuItemLineCopy,
                this.uBbItwaYjM,
                this.toolStripMenuItemDevideLine,
                this.toolStripMenuItemDisconnectLine,
                this.toolMenuItemLineDel,
                this.toolStripSeparatorEditLine,
                this.toolMenuItemLineSetStatus,
                this.toolStripSeparatorSetStatus,
                this.toolMenuItemLineTextHere,
                this.toolStripSeparatorLineTextHere,
                this.toolMenuItemLineFilter,
                this.toolMenuItemLinePowerSource,
                this.toolStripMenuItem1,
                this.toolMenuItemLineRecipientsPower,
                this.toolStripMenuItem10,
                this.toolStripMenuItem12,
                this.QyjrxReCs8,
                this.toolStripSeparator8,
                this.toolMenuItemLinePropertyPoint,
                this.toolStripMenuItemLineAlignBranch,
                this.toolMenuItemLinePropertyBranch,
                this.toolStripSeparator14,
                this.toolMenuItemLineRelayProtection,
                this.toolMenuItemLineLogDispatcher,
                this.toolMenuItemLinePassport,
                this.toolMenuItemLineFile,
                this.toolMenuItemLineProperty
            });
            this.contextMenuLineTool.Name = "contextMenuLineTool";
            this.contextMenuLineTool.Size = new Size(272, 524);
            this.contextMenuLineTool.Closed += this.contextMenuLineTool_Closed;
            this.contextMenuLineTool.Opening += this.contextMenuLineTool_Opening;
            this.toolMenuItemLineAddChild.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemLineAddBranch,
                this.toolMenuItemLineAddPoint,
                this.toolStripSeparatorLineAddBranchPoint,
                this.toolMenuItemLineAddOutsideLineDisconnector,
                this.toolMenuItemLineAddVacuumSwitch,
                this.toolMenuItemLineAddTransformer,
                this.toolMenuItemLineAddVoltageTransformer,
                this.toolStripMenuItemAddAmperageTransformerTool,
                this.toolMenuItemLineAddLoadSwitch,
                this.toolMenuItemLineAddLoadSwitchWaxwork,
                this.toolMenuItemLineAddRPS,
                this.toolMenuItemLineAddLinearDisconnector,
                this.toolMenuItemLineAddLinearDisconnectorWaxwork,
                this.toolMenuItemLineAddLubricantDisconnector,
                this.toolMenuItemLineAddFuseTool,
                this.toolMenuItemLineAddDischargerTool,
                this.toolMenuItemLineAddVoltageLimetedTool,
                this.toolMenuItemLineAddEndTrim,
                this.toolMenuItemLineAddCircuitBreakerTool,
                this.toolMenuItemLineAddGroundingTool,
                this.toolMenuItemLineAddSeparatorTool,
                this.toolStripMenuItemAddMagneticStarterTool,
                this.toolStripMenuItemAddElectricMeter,
                this.toolStripSeparator6,
                this.toolMenuItemAddLineText
            });
            this.toolMenuItemLineAddChild.Name = "toolMenuItemLineAddChild";
            this.toolMenuItemLineAddChild.Size = new Size(271, 22);
            this.toolMenuItemLineAddChild.Text = "Добавить";
            this.toolMenuItemLineAddBranch.Name = "toolMenuItemLineAddBranch";
            this.toolMenuItemLineAddBranch.Size = new Size(276, 22);
            this.toolMenuItemLineAddBranch.Text = "Ветку";
            this.toolMenuItemLineAddBranch.Click += this.toolMenuItemLineAddBranch_Click;
            this.toolMenuItemLineAddPoint.Name = "toolMenuItemLineAddPoint";
            this.toolMenuItemLineAddPoint.Size = new Size(276, 22);
            this.toolMenuItemLineAddPoint.Text = "Узел";
            this.toolMenuItemLineAddPoint.Click += this.toolMenuItemLineAddPoint_Click;
            this.toolStripSeparatorLineAddBranchPoint.Name = "toolStripSeparatorLineAddBranchPoint";
            this.toolStripSeparatorLineAddBranchPoint.Size = new Size(273, 6);
            this.toolMenuItemLineAddOutsideLineDisconnector.Name = "toolMenuItemLineAddOutsideLineDisconnector";
            this.toolMenuItemLineAddOutsideLineDisconnector.Size = new Size(276, 22);
            this.toolMenuItemLineAddOutsideLineDisconnector.Text = "Разъеденитель линейный наружный";
            this.toolMenuItemLineAddOutsideLineDisconnector.Click += this.toolMenuItemLineAddOutsideLineDisconnector_Click;
            this.toolMenuItemLineAddVacuumSwitch.Name = "toolMenuItemLineAddVacuumSwitch";
            this.toolMenuItemLineAddVacuumSwitch.Size = new Size(276, 22);
            this.toolMenuItemLineAddVacuumSwitch.Text = "Вакуумный выключатель";
            this.toolMenuItemLineAddVacuumSwitch.Click += this.toolMenuItemLineAddVacuumSwitch_Click;
            this.toolMenuItemLineAddTransformer.Name = "toolMenuItemLineAddTransformer";
            this.toolMenuItemLineAddTransformer.Size = new Size(276, 22);
            this.toolMenuItemLineAddTransformer.Text = "Трансформатор";
            this.toolMenuItemLineAddTransformer.Click += this.toolMenuItemLineAddTransformer_Click;
            this.toolMenuItemLineAddVoltageTransformer.Name = "toolMenuItemLineAddVoltageTransformer";
            this.toolMenuItemLineAddVoltageTransformer.Size = new Size(276, 22);
            this.toolMenuItemLineAddVoltageTransformer.Text = "Трансформатор напряжения";
            this.toolMenuItemLineAddVoltageTransformer.Click += this.toolMenuItemLineAddVoltageTransformer_Click;
            this.toolStripMenuItemAddAmperageTransformerTool.Name = "toolStripMenuItemAddAmperageTransformerTool";
            this.toolStripMenuItemAddAmperageTransformerTool.Size = new Size(276, 22);
            this.toolStripMenuItemAddAmperageTransformerTool.Text = "Трансформатор тока";
            this.toolStripMenuItemAddAmperageTransformerTool.Click += this.toolStripMenuItemAddAmperageTransformerTool_Click;
            this.toolMenuItemLineAddLoadSwitch.Name = "toolMenuItemLineAddLoadSwitch";
            this.toolMenuItemLineAddLoadSwitch.Size = new Size(276, 22);
            this.toolMenuItemLineAddLoadSwitch.Text = "Выключатель нагрузки";
            this.toolMenuItemLineAddLoadSwitch.Click += this.toolMenuItemLineAddLoadSwitch_Click;
            this.toolMenuItemLineAddLoadSwitchWaxwork.Name = "toolMenuItemLineAddLoadSwitchWaxwork";
            this.toolMenuItemLineAddLoadSwitchWaxwork.Size = new Size(276, 22);
            this.toolMenuItemLineAddLoadSwitchWaxwork.Text = "Выключатель нагрузки";
            this.toolMenuItemLineAddLoadSwitchWaxwork.Click += this.toolMenuItemLineAddLoadSwitchWaxwork_Click;
            this.toolMenuItemLineAddRPS.Name = "toolMenuItemLineAddRPS";
            this.toolMenuItemLineAddRPS.Size = new Size(276, 22);
            this.toolMenuItemLineAddRPS.Text = "РПС";
            this.toolMenuItemLineAddRPS.Click += this.toolMenuItemLineAddRPS_Click;
            this.toolMenuItemLineAddLinearDisconnector.Name = "toolMenuItemLineAddLinearDisconnector";
            this.toolMenuItemLineAddLinearDisconnector.Size = new Size(276, 22);
            this.toolMenuItemLineAddLinearDisconnector.Text = "Линейный разъеденитель";
            this.toolMenuItemLineAddLinearDisconnector.Click += this.toolMenuItemLineAddLinearDisconnector_Click;
            this.toolMenuItemLineAddLinearDisconnectorWaxwork.Name = "toolMenuItemLineAddLinearDisconnectorWaxwork";
            this.toolMenuItemLineAddLinearDisconnectorWaxwork.Size = new Size(276, 22);
            this.toolMenuItemLineAddLinearDisconnectorWaxwork.Text = "Линейный разъеденитель";
            this.toolMenuItemLineAddLinearDisconnectorWaxwork.Visible = false;
            this.toolMenuItemLineAddLinearDisconnectorWaxwork.Click += this.toolMenuItemLineAddLinearDisconnectorWaxwork_Click;
            this.toolMenuItemLineAddLubricantDisconnector.Name = "toolMenuItemLineAddLubricantDisconnector";
            this.toolMenuItemLineAddLubricantDisconnector.Size = new Size(276, 22);
            this.toolMenuItemLineAddLubricantDisconnector.Text = "Маслянный выключатель";
            this.toolMenuItemLineAddLubricantDisconnector.Click += this.zdhttAlvjH;
            this.toolMenuItemLineAddFuseTool.Name = "toolMenuItemLineAddFuseTool";
            this.toolMenuItemLineAddFuseTool.Size = new Size(276, 22);
            this.toolMenuItemLineAddFuseTool.Text = "Предохранитель";
            this.toolMenuItemLineAddFuseTool.Click += this.toolMenuItemLineAddFuseTool_Click;
            this.toolMenuItemLineAddDischargerTool.Name = "toolMenuItemLineAddDischargerTool";
            this.toolMenuItemLineAddDischargerTool.Size = new Size(276, 22);
            this.toolMenuItemLineAddDischargerTool.Text = "Разрядник";
            this.toolMenuItemLineAddDischargerTool.Click += this.toolMenuItemLineAddDischargerTool_Click;
            this.toolMenuItemLineAddVoltageLimetedTool.Name = "toolMenuItemLineAddVoltageLimetedTool";
            this.toolMenuItemLineAddVoltageLimetedTool.Size = new Size(276, 22);
            this.toolMenuItemLineAddVoltageLimetedTool.Text = "Ограничитель перенапряжения";
            this.toolMenuItemLineAddVoltageLimetedTool.Click += this.toolMenuItemLineAddVoltageLimetedTool_Click;
            this.toolMenuItemLineAddEndTrim.Name = "toolMenuItemLineAddEndTrim";
            this.toolMenuItemLineAddEndTrim.Size = new Size(276, 22);
            this.toolMenuItemLineAddEndTrim.Text = "Концевая разделка";
            this.toolMenuItemLineAddEndTrim.Click += this.toolMenuItemLineAddEndTrim_Click;
            this.toolMenuItemLineAddCircuitBreakerTool.Name = "toolMenuItemLineAddCircuitBreakerTool";
            this.toolMenuItemLineAddCircuitBreakerTool.Size = new Size(276, 22);
            this.toolMenuItemLineAddCircuitBreakerTool.Text = "Автоматический выключатель";
            this.toolMenuItemLineAddCircuitBreakerTool.Click += this.toolMenuItemLineAddCircuitBreakerTool_Click;
            this.toolMenuItemLineAddGroundingTool.Name = "toolMenuItemLineAddGroundingTool";
            this.toolMenuItemLineAddGroundingTool.Size = new Size(276, 22);
            this.toolMenuItemLineAddGroundingTool.Text = "Заземление";
            this.toolMenuItemLineAddGroundingTool.Click += this.toolMenuItemLineAddGroundingTool_Click;
            this.toolMenuItemLineAddSeparatorTool.ImageAlign = ContentAlignment.MiddleRight;
            this.toolMenuItemLineAddSeparatorTool.Name = "toolMenuItemLineAddSeparatorTool";
            this.toolMenuItemLineAddSeparatorTool.Size = new Size(276, 22);
            this.toolMenuItemLineAddSeparatorTool.Text = "Отделитель";
            this.toolMenuItemLineAddSeparatorTool.Click += this.toolMenuItemLineAddSeparatorTool_Click;
            this.toolStripMenuItemAddMagneticStarterTool.Name = "toolStripMenuItemAddMagneticStarterTool";
            this.toolStripMenuItemAddMagneticStarterTool.Size = new Size(276, 22);
            this.toolStripMenuItemAddMagneticStarterTool.Text = "Магнитный пускатель";
            this.toolStripMenuItemAddMagneticStarterTool.Click += this.toolStripMenuItemAddMagneticStarterTool_Click;
            this.toolStripMenuItemAddElectricMeter.Name = "toolStripMenuItemAddElectricMeter";
            this.toolStripMenuItemAddElectricMeter.Size = new Size(276, 22);
            this.toolStripMenuItemAddElectricMeter.Text = "Счётчик";
            this.toolStripMenuItemAddElectricMeter.Click += this.toolStripMenuItemAddElectricMeter_Click;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(273, 6);
            this.toolMenuItemAddLineText.Name = "toolMenuItemAddLineText";
            this.toolMenuItemAddLineText.Size = new Size(276, 22);
            this.toolMenuItemAddLineText.Text = "Текст";
            this.toolMenuItemAddLineText.Click += this.toolMenuItemAddLineText_Click;
            this.toolMenuItemLineCopy.Name = "toolMenuItemLineCopy";
            this.toolMenuItemLineCopy.Size = new Size(271, 22);
            this.toolMenuItemLineCopy.Text = "Копировать";
            this.toolMenuItemLineCopy.Click += this.reArSpApSW_Click;
            this.uBbItwaYjM.Name = "toolMenuItemLinePaste";
            this.uBbItwaYjM.Size = new Size(271, 22);
            this.uBbItwaYjM.Text = "Вставить";
            this.uBbItwaYjM.Click += this.uBbItwaYjM_Click;
            this.toolStripMenuItemDevideLine.Name = "toolStripMenuItemDevideLine";
            this.toolStripMenuItemDevideLine.Size = new Size(271, 22);
            this.toolStripMenuItemDevideLine.Text = "Разделить линию";
            this.toolStripMenuItemDevideLine.Click += this.toolStripMenuItemDevideLine_Click;
            this.toolStripMenuItemDisconnectLine.Name = "toolStripMenuItemDisconnectLine";
            this.toolStripMenuItemDisconnectLine.Size = new Size(271, 22);
            this.toolStripMenuItemDisconnectLine.Text = "Разъеденить линии";
            this.toolStripMenuItemDisconnectLine.Click += this.toolStripMenuItemDisconnectLine_Click;
            this.toolMenuItemLineDel.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemLineDelObj,
                this.toolMenuItemLineDelPoint
            });
            this.toolMenuItemLineDel.Name = "toolMenuItemLineDel";
            this.toolMenuItemLineDel.Size = new Size(271, 22);
            this.toolMenuItemLineDel.Text = "Удалить";
            this.toolMenuItemLineDelObj.Name = "toolMenuItemLineDelObj";
            this.toolMenuItemLineDelObj.Size = new Size(117, 22);
            this.toolMenuItemLineDelObj.Text = "Объект ";
            this.toolMenuItemLineDelObj.Click += this.toolMenuItemTextBranchDel_Click;
            this.toolMenuItemLineDelPoint.Name = "toolMenuItemLineDelPoint";
            this.toolMenuItemLineDelPoint.Size = new Size(117, 22);
            this.toolMenuItemLineDelPoint.Text = "Узел";
            this.toolMenuItemLineDelPoint.Click += this.toolMenuItemLineDelPoint_Click;
            this.toolStripSeparatorEditLine.Name = "toolStripSeparatorEditLine";
            this.toolStripSeparatorEditLine.Size = new Size(268, 6);
            this.toolMenuItemLineSetStatus.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemLineSetStatusGrounding,
                this.toolMenuItemLineSetStatusBrakeDown,
                this.toolMenuItemLineSetStatusOff,
                this.toolMenuItemLineSetStatusNoPhased,
                this.toolMenuItemLineSetStatusArrow
            });
            this.toolMenuItemLineSetStatus.Name = "toolMenuItemLineSetStatus";
            this.toolMenuItemLineSetStatus.Size = new Size(271, 22);
            this.toolMenuItemLineSetStatus.Text = "Установить статус";
            this.toolMenuItemLineSetStatusGrounding.Name = "toolMenuItemLineSetStatusGrounding";
            this.toolMenuItemLineSetStatusGrounding.Size = new Size(174, 22);
            this.toolMenuItemLineSetStatusGrounding.Text = "Заземлено";
            this.toolMenuItemLineSetStatusGrounding.Click += this.toolMenuItemLineSetStatusGrounding_Click;
            this.toolMenuItemLineSetStatusBrakeDown.Name = "toolMenuItemLineSetStatusBrakeDown";
            this.toolMenuItemLineSetStatusBrakeDown.Size = new Size(174, 22);
            this.toolMenuItemLineSetStatusBrakeDown.Text = "Повреждено";
            this.toolMenuItemLineSetStatusBrakeDown.Click += this.toolMenuItemLineSetStatusBrakeDown_Click;
            this.toolMenuItemLineSetStatusOff.Name = "toolMenuItemLineSetStatusOff";
            this.toolMenuItemLineSetStatusOff.Size = new Size(174, 22);
            this.toolMenuItemLineSetStatusOff.Text = "Отсоединено";
            this.toolMenuItemLineSetStatusOff.Click += this.toolMenuItemLineSetStatusOff_Click;
            this.toolMenuItemLineSetStatusNoPhased.Name = "toolMenuItemLineSetStatusNoPhased";
            this.toolMenuItemLineSetStatusNoPhased.Size = new Size(174, 22);
            this.toolMenuItemLineSetStatusNoPhased.Text = "Несфазированно";
            this.toolMenuItemLineSetStatusNoPhased.Click += this.toolMenuItemLineSetStatusNoPhased_Click;
            this.toolMenuItemLineSetStatusArrow.Name = "toolMenuItemLineSetStatusArrow";
            this.toolMenuItemLineSetStatusArrow.Size = new Size(174, 22);
            this.toolMenuItemLineSetStatusArrow.Text = "Перенос нагрузки";
            this.toolMenuItemLineSetStatusArrow.Click += this.toolMenuItemLineSetStatusArrow_Click;
            this.toolStripSeparatorSetStatus.Name = "toolStripSeparatorSetStatus";
            this.toolStripSeparatorSetStatus.Size = new Size(268, 6);
            this.toolMenuItemLineTextHere.Name = "toolMenuItemLineTextHere";
            this.toolMenuItemLineTextHere.Size = new Size(271, 22);
            this.toolMenuItemLineTextHere.Text = "Разместить текст здесь";
            this.toolMenuItemLineTextHere.Click += this.toolMenuItemLineTextHere_Click;
            this.toolStripSeparatorLineTextHere.Name = "toolStripSeparatorLineTextHere";
            this.toolStripSeparatorLineTextHere.Size = new Size(268, 6);
            this.toolMenuItemLineFilter.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemLineFilterAdd,
                this.toolMenuItemLineFilterDel
            });
            this.toolMenuItemLineFilter.Name = "toolMenuItemLineFilter";
            this.toolMenuItemLineFilter.Size = new Size(271, 22);
            this.toolMenuItemLineFilter.Text = "Фильтр";
            this.toolMenuItemLineFilterAdd.Name = "toolMenuItemLineFilterAdd";
            this.toolMenuItemLineFilterAdd.Size = new Size(183, 22);
            this.toolMenuItemLineFilterAdd.Text = "Добавить в фильтр";
            this.toolMenuItemLineFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
            this.toolMenuItemLineFilterDel.Name = "toolMenuItemLineFilterDel";
            this.toolMenuItemLineFilterDel.Size = new Size(183, 22);
            this.toolMenuItemLineFilterDel.Text = "Удалить из фильтра";
            this.toolMenuItemLineFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
            this.toolMenuItemLinePowerSource.Name = "toolMenuItemLinePowerSource";
            this.toolMenuItemLinePowerSource.Size = new Size(268, 6);
            this.toolMenuItemLinePowerSource.Click += this.toolStripMenuItem8_Click;
            this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem6,
                this.toolStripMenuItem8
            });
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(271, 22);
            this.toolStripMenuItem1.Text = "Просчитать запитку";
            this.toolStripMenuItem1.Click += this.toolStripMenuItem8_Click;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new Size(186, 22);
            this.toolStripMenuItem6.Tag = "1";
            this.toolStripMenuItem6.Text = "Выделить";
            this.toolStripMenuItem6.Click += this.toolStripMenuItem8_Click;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new Size(186, 22);
            this.toolStripMenuItem8.Tag = "2";
            this.toolStripMenuItem8.Text = "Выделить миганием";
            this.toolStripMenuItem8.Click += this.toolStripMenuItem8_Click;
            this.toolMenuItemLineRecipientsPower.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem7,
                this.toolStripMenuItem9
            });
            this.toolMenuItemLineRecipientsPower.Name = "toolMenuItemLineRecipientsPower";
            this.toolMenuItemLineRecipientsPower.Size = new Size(271, 22);
            this.toolMenuItemLineRecipientsPower.Text = "Просчитать схему";
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new Size(186, 22);
            this.toolStripMenuItem7.Tag = "1";
            this.toolStripMenuItem7.Text = "Выделить";
            this.toolStripMenuItem7.Click += this.toolStripMenuItem9_Click;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new Size(186, 22);
            this.toolStripMenuItem9.Tag = "2";
            this.toolStripMenuItem9.Text = "Выделить миганием";
            this.toolStripMenuItem9.Click += this.toolStripMenuItem9_Click;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new Size(271, 22);
            this.toolStripMenuItem10.Text = "Все возможные источники питания";
            this.toolStripMenuItem10.Visible = false;
            this.toolStripMenuItem10.Click += this.toolStripMenuItem10_Click;
            this.toolStripMenuItem12.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem13,
                this.toolStripMenuItem14
            });
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new Size(271, 22);
            this.toolStripMenuItem12.Text = "Абоненты";
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new Size(191, 22);
            this.toolStripMenuItem13.Text = "Текущей подстанции";
            this.toolStripMenuItem13.Click += this.toolStripMenuItem14_Click;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new Size(191, 22);
            this.toolStripMenuItem14.Tag = "1";
            this.toolStripMenuItem14.Text = "По цепочке";
            this.toolStripMenuItem14.Click += this.toolStripMenuItem14_Click;
            this.QyjrxReCs8.Name = "toolStripMenuItemLineAddTelemertryLabel";
            this.QyjrxReCs8.Size = new Size(271, 22);
            this.QyjrxReCs8.Text = "Вывести данные телеметрии";
            this.QyjrxReCs8.Click += this.QyjrxReCs8_Click;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new Size(268, 6);
            this.toolMenuItemLinePropertyPoint.Name = "toolMenuItemLinePropertyPoint";
            this.toolMenuItemLinePropertyPoint.Size = new Size(271, 22);
            this.toolMenuItemLinePropertyPoint.Text = "Свойства узла";
            this.toolMenuItemLinePropertyPoint.Click += this.toolMenuItemLinePropertyPoint_Click;
            this.toolStripMenuItemLineAlignBranch.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemAlignBranchByTop,
                this.toolStripMenuItemAlignBranchByBottom,
                this.toolStripMenuItemAlignBranchByRigth,
                this.toolStripMenuItemAlignBranchByLeft
            });
            this.toolStripMenuItemLineAlignBranch.Name = "toolStripMenuItemLineAlignBranch";
            this.toolStripMenuItemLineAlignBranch.Size = new Size(271, 22);
            this.toolStripMenuItemLineAlignBranch.Text = "Выровнить ветку";
            this.toolStripMenuItemAlignBranchByTop.Name = "toolStripMenuItemAlignBranchByTop";
            this.toolStripMenuItemAlignBranchByTop.Size = new Size(171, 22);
            this.toolStripMenuItemAlignBranchByTop.Tag = "T";
            this.toolStripMenuItemAlignBranchByTop.Text = "По верхней точке";
            this.toolStripMenuItemAlignBranchByTop.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
            this.toolStripMenuItemAlignBranchByBottom.Name = "toolStripMenuItemAlignBranchByBottom";
            this.toolStripMenuItemAlignBranchByBottom.Size = new Size(171, 22);
            this.toolStripMenuItemAlignBranchByBottom.Tag = "B";
            this.toolStripMenuItemAlignBranchByBottom.Text = "По нижней точке";
            this.toolStripMenuItemAlignBranchByBottom.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
            this.toolStripMenuItemAlignBranchByRigth.Name = "toolStripMenuItemAlignBranchByRigth";
            this.toolStripMenuItemAlignBranchByRigth.Size = new Size(171, 22);
            this.toolStripMenuItemAlignBranchByRigth.Tag = "R";
            this.toolStripMenuItemAlignBranchByRigth.Text = "По правой точке";
            this.toolStripMenuItemAlignBranchByRigth.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
            this.toolStripMenuItemAlignBranchByLeft.Name = "toolStripMenuItemAlignBranchByLeft";
            this.toolStripMenuItemAlignBranchByLeft.Size = new Size(171, 22);
            this.toolStripMenuItemAlignBranchByLeft.Tag = "L";
            this.toolStripMenuItemAlignBranchByLeft.Text = "По левой точке";
            this.toolStripMenuItemAlignBranchByLeft.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
            this.toolMenuItemLinePropertyBranch.Name = "toolMenuItemLinePropertyBranch";
            this.toolMenuItemLinePropertyBranch.Size = new Size(271, 22);
            this.toolMenuItemLinePropertyBranch.Text = "Свойства ветки";
            this.toolMenuItemLinePropertyBranch.Click += this.toolMenuItemLinePropertyBranch_Click;
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new Size(268, 6);
            this.toolMenuItemLineRelayProtection.Name = "toolMenuItemLineRelayProtection";
            this.toolMenuItemLineRelayProtection.Size = new Size(271, 22);
            this.toolMenuItemLineRelayProtection.Text = "Уставки РЗА";
            this.toolMenuItemLineRelayProtection.Click += this.toolMenuItemLineRelayProtection_Click;
            this.toolMenuItemLineLogDispatcher.Name = "toolMenuItemLineLogDispatcher";
            this.toolMenuItemLineLogDispatcher.Size = new Size(271, 22);
            this.toolMenuItemLineLogDispatcher.Text = "Отчет диспетчера";
            this.toolMenuItemLineLogDispatcher.Click += this.toolMenuItemLineLogDispatcher_Click;
            this.toolMenuItemLinePassport.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemLinePassportOpen,
                this.toolMenuItemLineDeLinkPassport,
                this.toolMenuItemLineLinkPassport
            });
            this.toolMenuItemLinePassport.Name = "toolMenuItemLinePassport";
            this.toolMenuItemLinePassport.Size = new Size(271, 22);
            this.toolMenuItemLinePassport.Text = "Паспорт";
            this.toolMenuItemLinePassport.Click += this.toolMenuItemLinePassportOpen_Click;
            this.toolMenuItemLinePassportOpen.Name = "toolMenuItemLinePassportOpen";
            this.toolMenuItemLinePassportOpen.Size = new Size(194, 22);
            this.toolMenuItemLinePassportOpen.Text = "Открыть";
            this.toolMenuItemLinePassportOpen.Click += this.toolMenuItemLinePassportOpen_Click;
            this.toolMenuItemLineDeLinkPassport.Name = "toolMenuItemLineDeLinkPassport";
            this.toolMenuItemLineDeLinkPassport.Size = new Size(194, 22);
            this.toolMenuItemLineDeLinkPassport.Text = "Отвязать от паспорта";
            this.toolMenuItemLineDeLinkPassport.Click += this.toolMenuItemLineDeLinkPassport_Click;
            this.toolMenuItemLineLinkPassport.Name = "toolMenuItemLineLinkPassport";
            this.toolMenuItemLineLinkPassport.Size = new Size(194, 22);
            this.toolMenuItemLineLinkPassport.Text = "Привязать к паспорту";
            this.toolMenuItemLineLinkPassport.Click += this.toolMenuItemLineLinkPassport_Click;
            this.toolMenuItemLineFile.Name = "toolMenuItemLineFile";
            this.toolMenuItemLineFile.Size = new Size(271, 22);
            this.toolMenuItemLineFile.Text = "Файлы";
            this.toolMenuItemLineFile.Click += this.toolMenuItemLineFile_Click;
            this.toolMenuItemLineProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
            this.toolMenuItemLineProperty.Name = "toolMenuItemLineProperty";
            this.toolMenuItemLineProperty.Size = new Size(271, 22);
            this.toolMenuItemLineProperty.Text = "Свойства линии";
            this.toolMenuItemLineProperty.Click += this.WcgruJuvXg_Click;
            this.contextMenuCanvas.ImageScalingSize = new Size(20, 20);
            this.contextMenuCanvas.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemAddFreeLabel,
                this.toolStripMenuItemAddTelemetryLabel2Level,
                this.toolMenuItemAddNode,
                this.toolMenuCanvasPaste
            });
            this.contextMenuCanvas.Name = "contextMenuCanvas";
            this.contextMenuCanvas.Size = new Size(233, 92);
            this.contextMenuCanvas.Opening += this.contextMenuCanvas_Opening;
            this.toolStripMenuItemAddFreeLabel.Name = "toolStripMenuItemAddFreeLabel";
            this.toolStripMenuItemAddFreeLabel.Size = new Size(232, 22);
            this.toolStripMenuItemAddFreeLabel.Text = "Добавить текст";
            this.toolStripMenuItemAddFreeLabel.Click += this.toolStripMenuItemAddFreeLabel_Click;
            this.toolStripMenuItemAddTelemetryLabel2Level.Name = "toolStripMenuItemAddTelemetryLabel2Level";
            this.toolStripMenuItemAddTelemetryLabel2Level.Size = new Size(232, 22);
            this.toolStripMenuItemAddTelemetryLabel2Level.Text = "Вывести данные телеметрии";
            this.toolStripMenuItemAddTelemetryLabel2Level.Click += this.toolStripMenuItemAddTelemetryLabel2Level_Click;
            this.toolMenuItemAddNode.Name = "toolMenuItemAddNode";
            this.toolMenuItemAddNode.Size = new Size(232, 22);
            this.toolMenuItemAddNode.Text = "Добавить примечание";
            this.toolMenuItemAddNode.Click += this.toolMenuItemAddNode_Click;
            this.toolMenuCanvasPaste.Name = "toolMenuCanvasPaste";
            this.toolMenuCanvasPaste.Size = new Size(232, 22);
            this.toolMenuCanvasPaste.Text = "Вставить";
            this.toolMenuCanvasPaste.Click += this.toolMenuCanvasPaste_Click;
            this.imageList_0.ImageStream = (ImageListStreamer)resources.GetObject("imageListConnected.ImageStream");
            this.imageList_0.TransparentColor = Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "Connect.png");
            this.imageList_0.Images.SetKeyName(1, "NoConnect.png");
            this.contextMenuLabelTool.ImageScalingSize = new Size(20, 20);
            this.contextMenuLabelTool.Items.AddRange(new ToolStripItem[]
            {
                this.toolMenuItemLabelUpdate,
                this.toolMenuItemLabelDel,
                this.toolMenuItemLabelProperty
            });
            this.contextMenuLabelTool.Name = "contextMenuLabelTool";
            this.contextMenuLabelTool.Size = new Size(178, 70);
            this.contextMenuLabelTool.Opening += this.contextMenuLabelTool_Opening;
            this.toolMenuItemLabelUpdate.Name = "toolMenuItemLabelUpdate";
            this.toolMenuItemLabelUpdate.Size = new Size(177, 22);
            this.toolMenuItemLabelUpdate.Text = "Обновить данные";
            this.toolMenuItemLabelUpdate.Click += this.toolMenuItemLabelUpdate_Click;
            this.toolMenuItemLabelDel.Name = "toolMenuItemLabelDel";
            this.toolMenuItemLabelDel.Size = new Size(177, 22);
            this.toolMenuItemLabelDel.Text = "Удалить";
            this.toolMenuItemLabelDel.Click += this.toolMenuItemLabelDel_Click;
            this.toolMenuItemLabelProperty.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.toolMenuItemLabelProperty.Name = "toolMenuItemLabelProperty";
            this.toolMenuItemLabelProperty.Size = new Size(177, 22);
            this.toolMenuItemLabelProperty.Text = "Свойства объекта";
            this.toolMenuItemLabelProperty.Click += this.WcgruJuvXg_Click;
            this.contextMenuStripWhitePoint.ImageScalingSize = new Size(20, 20);
            this.contextMenuStripWhitePoint.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItemRemoveWhitePoint,
                this.toolStripMenuItem_0
            });
            this.contextMenuStripWhitePoint.Name = "contextMenuStripWhitePoint";
            this.contextMenuStripWhitePoint.Size = new Size(128, 48);
            this.contextMenuStripWhitePoint.Opening += this.contextMenuStripWhitePoint_Opening;
            this.toolStripMenuItemRemoveWhitePoint.Name = "toolStripMenuItemRemoveWhitePoint";
            this.toolStripMenuItemRemoveWhitePoint.Size = new Size(127, 22);
            this.toolStripMenuItemRemoveWhitePoint.Text = "Удалить";
            this.toolStripMenuItemRemoveWhitePoint.Click += this.toolStripMenuItemRemoveWhitePoint_Click;
            this.toolStripMenuItem_0.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.toolStripMenuItem_0.Name = "свойстваToolStripMenuItem";
            this.toolStripMenuItem_0.Size = new Size(127, 22);
            this.toolStripMenuItem_0.Text = "Свойства";
            this.toolStripMenuItem_0.Click += this.WcgruJuvXg_Click;
            this.contextMenuFrame.ImageScalingSize = new Size(20, 20);
            this.contextMenuFrame.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuFramePrint,
                this.toolStripMenuFrameCopyToImage,
                this.toolStripMenuFrameExportToImage,
                this.toolStripMenuFrameFitZoom
            });
            this.contextMenuFrame.Name = "contextMenuFrame";
            this.contextMenuFrame.Size = new Size(202, 92);
            this.toolStripMenuFramePrint.Name = "toolStripMenuFramePrint";
            this.toolStripMenuFramePrint.Size = new Size(201, 22);
            this.toolStripMenuFramePrint.Text = "Печать";
            this.toolStripMenuFramePrint.Click += this.toolStripMenuFramePrint_Click;
            this.toolStripMenuFrameCopyToImage.Name = "toolStripMenuFrameCopyToImage";
            this.toolStripMenuFrameCopyToImage.Size = new Size(201, 22);
            this.toolStripMenuFrameCopyToImage.Text = "Копировать в картинку";
            this.toolStripMenuFrameCopyToImage.Click += this.toolStripMenuFrameCopyToImage_Click;
            this.toolStripMenuFrameExportToImage.Name = "toolStripMenuFrameExportToImage";
            this.toolStripMenuFrameExportToImage.Size = new Size(201, 22);
            this.toolStripMenuFrameExportToImage.Text = "Экспорт в картинку";
            this.toolStripMenuFrameExportToImage.Click += this.toolStripMenuFrameExportToImage_Click;
            this.toolStripMenuFrameFitZoom.Name = "toolStripMenuFrameFitZoom";
            this.toolStripMenuFrameFitZoom.Size = new Size(201, 22);
            this.toolStripMenuFrameFitZoom.Text = "Подогнать под рамку";
            this.toolStripMenuFrameFitZoom.Click += this.toolStripMenuFrameFitZoom_Click;
            this.textBoxSearch.Location = new Point(0, 399);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new Size(100, 20);
            this.textBoxSearch.TabIndex = 9;
            this.button1.Location = new Point(112, 397);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.contextMenuTextBranchTool.ImageScalingSize = new Size(20, 20);
            this.contextMenuTextBranchTool.Items.AddRange(new ToolStripItem[]
            {
                this.reArSpApSW,
                this.toolStripMenuItemTBTDisplayGrLevel,
                this.toolMenuItemTextBranchDel,
                this.WcgruJuvXg
            });
            this.contextMenuTextBranchTool.Name = "contextMenuTextBranchTool";
            this.contextMenuTextBranchTool.Size = new Size(243, 92);
            this.contextMenuTextBranchTool.Opening += this.contextMenuTextBranchTool_Opening;
            this.reArSpApSW.Name = "копироватьToolStripMenuItem";
            this.reArSpApSW.Size = new Size(242, 22);
            this.reArSpApSW.Text = "Копировать";
            this.reArSpApSW.Click += this.reArSpApSW_Click;
            this.toolStripMenuItemTBTDisplayGrLevel.Name = "toolStripMenuItemTBTDisplayGrLevel";
            this.toolStripMenuItemTBTDisplayGrLevel.Size = new Size(242, 22);
            this.toolStripMenuItemTBTDisplayGrLevel.Text = "Копировать на первый уровне";
            this.toolStripMenuItemTBTDisplayGrLevel.Click += this.toolStripMenuItemTBTDisplayGrLevel_Click;
            this.toolMenuItemTextBranchDel.Name = "toolMenuItemTextBranchDel";
            this.toolMenuItemTextBranchDel.Size = new Size(242, 22);
            this.toolMenuItemTextBranchDel.Text = "Убрать текст";
            this.toolMenuItemTextBranchDel.Click += this.toolMenuItemTextBranchDel_Click;
            this.WcgruJuvXg.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.WcgruJuvXg.Name = "toolMenuItemTextBranchProperty";
            this.WcgruJuvXg.Size = new Size(242, 22);
            this.WcgruJuvXg.Text = "Свойства текста";
            this.WcgruJuvXg.Click += this.WcgruJuvXg_Click;
            this.AllowDrop = true;
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBoxSearch);
            base.Controls.Add(this.tbPopup);
            base.Controls.Add(this.buttonCheck);
            base.Controls.Add(this.bigBoldButton);
            base.Controls.Add(this.propertyGrid1);
            base.Controls.Add(this.statusStrip);
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            base.Name = "CanvasControl";
            base.Size = new Size(754, 494);
            base.Load += this.CanvasControl_Load;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((ISupportInitialize)this.dsScheme).EndInit();
            this.contextMenuSelectedObjects.ResumeLayout(false);
            this.contextMenuRectnagle.ResumeLayout(false);
            this.contextMenuShina.ResumeLayout(false);
            this.contextMenuSwitchTool.ResumeLayout(false);
            this.contextMenuLineTool.ResumeLayout(false);
            this.contextMenuCanvas.ResumeLayout(false);
            this.contextMenuLabelTool.ResumeLayout(false);
            this.contextMenuStripWhitePoint.ResumeLayout(false);
            this.contextMenuFrame.ResumeLayout(false);
            this.contextMenuTextBranchTool.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }


        #endregion

        private IContainer components = null;

        private StatusStrip statusStrip;

        private ToolStripStatusLabel labelMousePosition;

        public PrintDocument printDocument;

        public PrintPreviewDialog printPreviewDialog;

        internal DataSetScheme dsScheme;

        private PropertyGrid propertyGrid1;

        private Button bigBoldButton;

        private ToolStripStatusLabel GihsIhiuKn;

        private ToolStripStatusLabel labelProgressBar;

        private ToolStripProgressBar toolProgressBarSave;

        private Button buttonCheck;

        private ToolStripStatusLabel labelInfo;

        private System.Windows.Forms.Timer timer_1;

        private Label tbPopup;

        private ToolStripSplitButton toolBtnZoom;

        private ToolStripMenuItem toolBtnZoom800;

        private ToolStripMenuItem toolBtnZoom400;

        private ToolStripMenuItem toolBtnZoom200;

        private ToolStripMenuItem toolBtnZoom150;

        private ToolStripMenuItem toolBtnZoom125;

        private ToolStripMenuItem toolBtnZoom100;

        private ToolStripMenuItem toolBtnZoom75;

        private ToolStripMenuItem toolBtnZoom50;

        private ToolStripMenuItem toolBtnZoom25;

        private ContextMenuStrip contextMenuSelectedObjects;

        private ToolStripMenuItem toolMenuItemDeleteSelectedObjects;

        private ToolStripMenuItem toolMenuItemFilterSelectedObjects;

        private ToolStripMenuItem toolMenuItemCenterSElectedObjects;

        private ToolStripMenuItem toolMenuItemAddFilterSelectedObjects;

        private ToolStripMenuItem toolMenuItemDeleteFilterSelectedObjects;

        private ContextMenuStrip contextMenuRectnagle;

        private ToolStripMenuItem toolMenuItemRectProperty;

        private ToolStripMenuItem twFspjsly3;

        private ToolStripMenuItem toolMenuItemRectRecipientsPower;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripMenuItem toolMenuItemRectAlign;

        private ToolStripMenuItem toolMenuItemRectDel;

        private ToolStripSeparator toolStripSeparator2;

        private ContextMenuStrip contextMenuShina;

        private ToolStripMenuItem toolMenuItemShinaPowerSource;

        private ToolStripMenuItem toolMenuItemShinaRecipientsPower;

        private ToolStripSeparator toolStripSeparator3;

        private ToolStripMenuItem toolMenuItemShinaDel;

        private ToolStripSeparator toolStripSeparatorEditShina;

        private ToolStripMenuItem toolMenuItemShinaProperty;

        private ToolStripMenuItem toolMenuItemShinaAddChild;

        private ToolStripMenuItem toolMenuItemShinaAddCell;

        private ToolStripMenuItem toolMenuItemShinaBridge;

        private ToolStripMenuItem toolMenuItemShinaSplitter;

        private ContextMenuStrip contextMenuSwitchTool;

        private ToolStripMenuItem toolMenuItemSwitchDel;

        private ToolStripSeparator toolStripSeparator5;

        private ToolStripMenuItem MSMZJEXRVG;

        private ContextMenuStrip contextMenuLineTool;

        private ToolStripMenuItem toolMenuItemLineAddChild;

        private ToolStripMenuItem toolMenuItemLineAddBranch;

        private ToolStripMenuItem toolMenuItemLineAddPoint;

        private ToolStripSeparator toolStripSeparatorLineAddBranchPoint;

        private ToolStripMenuItem toolMenuItemLineDel;

        private ToolStripMenuItem toolMenuItemLineAddOutsideLineDisconnector;

        private ToolStripMenuItem toolMenuItemLineAddVacuumSwitch;

        private ToolStripMenuItem toolMenuItemLineAddTransformer;

        private ToolStripMenuItem toolMenuItemLineAddLoadSwitch;

        private ToolStripMenuItem toolMenuItemLineAddLinearDisconnector;

        private ToolStripMenuItem toolMenuItemLineAddLubricantDisconnector;

        private ToolStripSeparator toolStripSeparator6;

        private ToolStripMenuItem toolMenuItemAddLineText;

        private ToolStripSeparator toolStripSeparatorSetStatus;

        private ToolStripMenuItem toolMenuItemLineRecipientsPower;

        private ToolStripSeparator toolStripSeparator8;

        private ToolStripMenuItem toolMenuItemLinePropertyBranch;

        private ToolStripMenuItem toolMenuItemLineProperty;

        private ToolStripSeparator toolStripSeparatorEditLine;

        private ToolStripMenuItem toolMenuItemLineSetStatus;

        private ToolStripMenuItem toolMenuItemLineSetStatusGrounding;

        private ToolStripMenuItem toolMenuItemLineSetStatusBrakeDown;

        private ToolStripMenuItem toolMenuItemLineSetStatusOff;

        private ToolStripMenuItem toolMenuItemLineSetStatusNoPhased;

        private ToolStripMenuItem toolMenuItemLineDelObj;

        private ToolStripMenuItem toolMenuItemLineDelPoint;

        private ToolStripMenuItem toolMenuItemLineTextHere;

        private ToolStripSeparator toolStripSeparatorLineTextHere;

        private ToolStripSeparator toolStripSeparator10;

        private ToolStripMenuItem toolMenuItemRectFilter;

        private ToolStripMenuItem toolMenuItemRectFilterAdd;

        private ToolStripMenuItem toolMenuItemRectFilterDel;

        private ToolStripMenuItem toolMenuItemShinaFilter;

        private ToolStripMenuItem toolMenuItemShinaFilterAdd;

        private ToolStripMenuItem toolMenuItemShinaFilterDel;

        private ToolStripSeparator toolStripSeparator11;

        private ToolStripMenuItem toolMenuItemSwitchFilter;

        private ToolStripMenuItem toolMenuItemSwitchFilterAdd;

        private ToolStripMenuItem toolMenuItemSwitchFilterDel;

        private ToolStripSeparator toolStripSeparator12;

        private ToolStripMenuItem toolMenuItemLineFilter;

        private ToolStripMenuItem toolMenuItemLineFilterAdd;

        private ToolStripMenuItem toolMenuItemLineFilterDel;

        private ToolStripSeparator toolMenuItemLinePowerSource;

        private ToolStripMenuItem toolMenuItemLinePropertyPoint;

        private ToolStripMenuItem toolMenuItemStateDel;

        private ToolStripMenuItem toolStripMenuItem1;

        private ToolStripMenuItem toolStripMenuItem2;

        private ToolStripMenuItem toolStripMenuItem3;

        private ToolStripMenuItem toolStripMenuItem5;

        private ToolStripMenuItem toolStripMenuItem4;

        private ToolStripMenuItem toolStripMenuItem6;

        private ToolStripMenuItem toolStripMenuItem8;

        private ToolStripMenuItem toolStripMenuItem7;

        private ToolStripMenuItem toolStripMenuItem9;

        private ToolStripMenuItem toolMenuItemSwitchOn;

        private ToolStripTextBox toolTxtZoomChanged;

        private ToolStripMenuItem toolStripMenuItemBookmark;

        private ToolStripMenuItem toolStripMenuItemRemoveBookmark;

        private ToolStripMenuItem toolStripMenuItemAllPower;

        private ToolStripMenuItem toolStripMenuItem10;

        private ToolStripSeparator toolStripSeparator4;

        private ToolStripSeparator toolStripSeparator9;

        private ToolStripMenuItem toolMenuItemSelectedPowerBullshit;

        private ToolStripSeparator toolStripSeparator13;

        private ToolStripMenuItem toolMenuItemCopySelectedObjects;

        private ContextMenuStrip contextMenuCanvas;

        private ToolStripMenuItem toolMenuCanvasPaste;

        private ToolStripMenuItem toolMenuItemRectCopy;

        private ToolStripMenuItem toolMenuItemShinaCopy;

        private ToolStripMenuItem toolMenuItemSwitchCopy;

        private ToolStripMenuItem toolMenuItemLineCopy;

        private ToolStripMenuItem uBbItwaYjM;

        private ToolStripMenuItem toolMenuItemPasteSelectedObjects;

        private ToolStripMenuItem toolMenuItemRectPaste;

        private ToolStripMenuItem toolMenuItemShinaPaste;

        private ToolStripMenuItem toolStripMenuItem11;

        private ToolStripMenuItem toolMenuItemLineAddFuseTool;

        private ToolStripMenuItem toolMenuItemLineAddDischargerTool;

        private ToolStripMenuItem toolMenuItemLineAddVoltageLimetedTool;

        private ToolStripMenuItem toolMenuItemLineAddVoltageTransformer;

        private ToolStripMenuItem toolStripMenuItemAdjacentSubstation;

        private ToolStripStatusLabel toolStripStatusLabelConnected;

        private ImageList imageList_0;

        private ToolStripMenuItem toolMenuItemAddNode;

        private ContextMenuStrip contextMenuLabelTool;

        private ToolStripMenuItem toolMenuItemLabelDel;

        private ToolStripMenuItem toolMenuItemLabelProperty;

        private ToolStripMenuItem toolMenuItemLineSetStatusArrow;

        private ToolStripMenuItem toolStripMenuItemAdjacentSubstation2;

        private ToolStripMenuItem toolStripMenuItemLineAlignBranch;

        private ToolStripMenuItem toolStripMenuItemAlignBranchByTop;

        private ToolStripMenuItem toolStripMenuItemAlignBranchByBottom;

        private ToolStripMenuItem toolStripMenuItemAlignBranchByRigth;

        private ToolStripMenuItem toolStripMenuItemAlignBranchByLeft;

        private ToolStripSeparator toolStripSeparator14;

        private ToolStripMenuItem toolMenuItemSelectedAlign;

        private ToolStripMenuItem toolMenuItemSelectedAlignByTop;

        private ToolStripMenuItem toolMenuItemSelectedAlignByBottom;

        private ToolStripMenuItem toolMenuItemSelectedAlignByRigth;

        private ToolStripMenuItem toolMenuItemSelectedAlignByLeft;

        private ToolStripMenuItem toolMenuItemSelectedAlignByHorCenter;

        private ToolStripMenuItem toolMenuItemSelectedAlignByVertCenter;

        private ToolStripMenuItem toolStripMenuItemAddWhitePoint;

        private ContextMenuStrip contextMenuStripWhitePoint;

        private ToolStripMenuItem toolStripMenuItemRemoveWhitePoint;

        private ToolStripMenuItem toolStripMenuItemRectanglePosition;

        private ToolStripMenuItem toolStripMenuItemReflect;

        private ToolStripMenuItem toolStripMenuItemRotateRectangle;

        private ToolStripMenuItem toolStripMenuItemRotate90;

        private ToolStripMenuItem toolStripMenuItemRotate180;

        private ToolStripMenuItem toolStripMenuItemRotate170;

        private ToolStripMenuItem toolStripMenuItemVReflect;

        private ToolStripMenuItem toolStripMenuItemHReflect;

        private ToolStripMenuItem toolStripMenuItem_0;

        private ToolStripMenuItem toolStripMenuItemDisconnectLine;

        private ToolStripMenuItem toolMenuItemLineAddEndTrim;

        private ToolStripMenuItem toolMenuItemLineAddGroundingTool;

        private ToolStripMenuItem toolMenuItemLineAddCircuitBreakerTool;

        private ToolStripMenuItem toolMeniItemShinaAddPattern;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve;

        private ToolStripMenuItem oGyhJxxeRR;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn2;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn3;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn4;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn5;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn6;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn7;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn8;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn9;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbn10;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve1;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve2;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve3;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve4;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve5;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve6;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve7;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve8;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve9;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve10;

        private PageSetupDialog pageSetupDialog_0;

        public PrintDialog printDialog;

        private ToolStripMenuItem toolStripMenuItemOOLDisplayGrLevel;

        private ToolStripMenuItem toolStripMenuItemDevideLine;

        private ToolStripMenuItem toolStripMenuItemGroupProperty;

        private ToolStripSeparator toolStripSeparatorGroup;

        private ToolStripMenuItem toolStripMenuItemGroupSelectedObject;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto1;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto2;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto3;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto4;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto5;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto6;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto7;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto8;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto9;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto10;

        private ToolStripMenuItem toolMenuItemLineRelayProtection;

        private ToolStripMenuItem toolMenuItemLineAddRPS;

        private ToolStripMenuItem toolStripMenuItemAddAmperageTransformerTool;

        private ToolStripMenuItem toolMenuItemCopySelectedObjectsToImage;

        private ContextMenuStrip contextMenuFrame;

        private ToolStripMenuItem toolStripMenuFramePrint;

        private ToolStripMenuItem toolStripMenuFrameCopyToImage;

        private ToolStripMenuItem toolStripMenuFrameFitZoom;

        private ToolStripMenuItem toolMenuItemLineLogDispatcher;

        private ToolStripMenuItem toolMenuItemSwitchLogDispatcher;

        private ToolStripMenuItem toolMenuItemExportSelectedObjectsToDXF;

        private ToolStripMenuItem toolStripMenuFrameExportToImage;

        private ToolStripMenuItem toolMenuItemLineLinkPassport;

        private ToolStripMenuItem toolMenuItemLinePassport;

        private ToolStripMenuItem toolMenuItemSwitchPassport;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS1;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS2;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS3;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS4;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS5;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS6;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS7;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS8;

        private ToolStripMenuItem EhkrgnfgYC;

        private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS10;

        private ToolStripMenuItem toolMenuItemLineAddLinearDisconnectorWaxwork;

        private ToolStripMenuItem toolMenuItemLineAddSeparatorTool;

        private ToolStripMenuItem toolStripMenuItemCSNormalMode;

        private ToolStripSeparator toolStripSeparatorCS;

        private ToolStripMenuItem toolStripMenuItemCSRollingOut;

        private ToolStripMenuItem toolStripMenuItemCSRepairMode;

        private ToolStripMenuItem toolStripMenuItemCSTestMode;

        private TextBox textBoxSearch;

        private Button button1;

        private ToolStripMenuItem toolStripMenuItemShinaGetOldAbn;

        private ToolStripMenuItem toolStripMenuItemShinaOldAbnCurrentRect;

        private ToolStripMenuItem toolStripMenuItemShinaOldAbnNextRect;

        private ToolStripMenuItem toolStripMenuItem12;

        private ToolStripMenuItem toolStripMenuItem13;

        private ToolStripMenuItem toolStripMenuItem14;

        private ToolStripMenuItem toolMenuItemRectFile;

        private ToolStripMenuItem toolMenuItemShinaFile;

        private ToolStripMenuItem toolMenuItemSwitchFile;

        private ToolStripMenuItem toolMenuItemLineFile;

        private ToolStripMenuItem toolMenuItemLineDeLinkPassport;

        private ToolStripMenuItem toolStripMenuItemAddFreeLabel;

        private ToolStripMenuItem QyjrxReCs8;

        private ToolStripMenuItem toolMenuItemLabelUpdate;

        private ToolStripMenuItem toolStripMenuItemAddTelemetryLabel2Level;

        private ToolStripMenuItem toolStripMenuItemSwitchAddTelemetry;

        private ToolStripMenuItem toolMenuItemLineAddLoadSwitchWaxwork;

        private ToolStripMenuItem ToolStripMenuItemSwitchMeasurement;

        private ContextMenuStrip contextMenuTextBranchTool;

        private ToolStripMenuItem reArSpApSW;

        private ToolStripMenuItem toolMenuItemTextBranchDel;

        private ToolStripMenuItem WcgruJuvXg;

        private ToolStripMenuItem waWrHaQms2;

        private ToolStripMenuItem ldtrvofZuY;

        private ToolStripSeparator toolStripSeparator7;

        private ToolStripMenuItem toolStripMenuItemBusMeasurement;

        private ToolStripMenuItem toolStripMenuItemAddMagneticStarterTool;

        private ToolStripMenuItem toolStripMenuItemAddElectricMeter;

        private ToolStripMenuItem toolMenuItemSwitchErcloud;

        private ToolStripMenuItem toolMenuItemSwitchLinkErcloud;

        private ToolStripMenuItem toolMenuItemSwitchShowDataErcloud;

        private ToolStripMenuItem toolStripMenuChangeArrowDirection;

        private ToolStripMenuItem toolMenuItemLinePassportOpen;

        private ToolStripMenuItem toolStripMenuItemTBTDisplayGrLevel;
    }
}
