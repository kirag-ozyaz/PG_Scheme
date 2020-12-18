﻿using System;

namespace OfficeLB.Word
{
	public enum WdWordDialog
	{
		wdDialogConnect = 420,
		wdDialogMailMergeCreateHeaderSource = 643,
		wdDialogConsistencyChecker = 1121,
		wdDialogMailMergeFieldMapping = 1304,
		wdDialogControlRun = 235,
		wdDialogMailMergeFindRecipient = 1326,
		wdDialogConvertObject = 392,
		wdDialogMailMergeFindRecord = 569,
		wdDialogCopyFile = 300,
		wdDialogMailMergeHelper = 680,
		wdDialogCreateAutoText = 872,
		wdDialogMailMergeInsertAddressBlock = 1305,
		wdDialogCSSLinks = 1261,
		wdDialogMailMergeInsertAsk = 4047,
		wdDialogDocumentStatistics = 78,
		wdDialogMailMergeInsertFields = 1307,
		wdDialogDrawAlign = 634,
		wdDialogMailMergeInsertFillIn = 4048,
		wdDialogDrawingGrid = 1168,
		wdDialogMailMergeInsertGreetingLine = 1306,
		wdDialogDrawSnapToGrid = 633,
		wdDialogMailMergeInsertIf = 4049,
		wdDialogEditAutoText = 985,
		wdDialogMailMergeInsertNextIf = 4053,
		wdDialogEditCreatePublisher = 732,
		wdDialogMailMergeInsertSet = 4054,
		wdDialogEditFind = 112,
		wdDialogMailMergeInsertSkipIf = 4055,
		wdDialogEditFrame = 458,
		wdDialogMailMergeOpenDataSource = 81,
		wdDialogEditGoTo = 896,
		wdDialogMailMergeOpenHeaderSource = 82,
		wdDialogEditGoToOld = 811,
		wdDialogMailMergeQueryOptions = 681,
		wdDialogEditLinks = 124,
		wdDialogMailMergeRecipients = 1308,
		wdDialogEditObject = 125,
		wdDialogMailMergeSetDocumentType = 1339,
		wdDialogEditPasteSpecial = 111,
		wdDialogMailMergeUseAddressBook = 779,
		wdDialogEditPublishOptions = 735,
		wdDialogMarkCitation = 463,
		wdDialogEditReplace = 117,
		wdDialogMarkIndexEntry = 169,
		wdDialogEditStyle = 120,
		wdDialogMarkTableOfContentsEntry = 442,
		wdDialogEditSubscribeOptions = 736,
		wdDialogMyPermission = 1437,
		wdDialogEditSubscribeTo = 733,
		wdDialogNewToolbar = 586,
		wdDialogEditTOACategory = 625,
		wdDialogNoteOptions = 373,
		wdDialogEmailOptions = 863,
		wdDialogOrganizer = 222,
		wdDialogFileDocumentLayout = 178,
		wdDialogPermission = 1469,
		wdDialogFileFind = 99,
		wdDialogPhoneticGuide = 986,
		wdDialogFileMacCustomPageSetupGX = 737,
		wdDialogReviewAfmtRevisions = 570,
		wdDialogFileMacPageSetup = 685,
		wdDialogSchemaLibrary = 1417,
		wdDialogFileMacPageSetupGX = 444,
		wdDialogSearch = 1363,
		wdDialogFileNew = 79,
		wdDialogShowRepairs = 1381,
		wdDialogFileOpen = 80,
		wdDialogTableAutoFormat = 563,
		wdDialogFilePageSetup = 178,
		wdDialogTableCellOptions = 1081,
		wdDialogFilePrint = 88,
		wdDialogTableColumnWidth = 143,
		wdDialogFilePrintOneCopy = 445,
		wdDialogTableDeleteCells = 133,
		wdDialogFilePrintSetup = 97,
		wdDialogTableFormatCell = 612,
		wdDialogFileRoutingSlip = 624,
		wdDialogTableFormula = 348,
		wdDialogFileSaveAs = 84,
		wdDialogTableInsertCells = 130,
		wdDialogFileSaveVersion = 1007,
		wdDialogTableInsertRow = 131,
		wdDialogFileSummaryInfo = 86,
		wdDialogTableInsertTable = 129,
		wdDialogFileVersions = 945,
		wdDialogTableOfCaptionsOptions = 551,
		wdDialogFitText = 983,
		wdDialogTableOfContentsOptions = 470,
		wdDialogFontSubstitution = 581,
		wdDialogTableProperties = 861,
		wdDialogFormatAddrFonts = 103,
		wdDialogTableRowHeight = 142,
		wdDialogFormatBordersAndShading = 189,
		wdDialogTableSort = 199,
		wdDialogFormatBulletsAndNumbering = 824,
		wdDialogTableSplitCells = 137,
		wdDialogFormatCallout = 610,
		wdDialogTableTableOptions = 1080,
		wdDialogFormatChangeCase = 322,
		wdDialogTableToText = 128,
		wdDialogFormatColumns = 177,
		wdDialogTableWrapping = 854,
		wdDialogFormatDefineStyleBorders = 185,
		wdDialogTCSCTranslator = 1156,
		wdDialogFormatDefineStyleFont = 181,
		wdDialogTextToTable = 127,
		wdDialogFormatDefineStyleFrame = 184,
		wdDialogToolsAcceptRejectChanges = 506,
		wdDialogFormatDefineStyleLang = 186,
		wdDialogToolsAdvancedSettings = 206,
		wdDialogFormatDefineStylePara = 182,
		wdDialogToolsAutoCorrect = 378,
		wdDialogFormatDefineStyleTabs = 183,
		wdDialogToolsAutoCorrectExceptions = 762,
		wdDialogFormatDrawingObject = 960,
		wdDialogToolsAutoManager = 915,
		wdDialogFormatDropCap = 488,
		wdDialogToolsAutoSummarize = 874,
		wdDialogFormatEncloseCharacters = 1162,
		wdDialogToolsBulletsNumbers = 196,
		wdDialogFormatFont = 174,
		wdDialogToolsCompareDocuments = 198,
		wdDialogFormatFrame = 190,
		wdDialogToolsCreateDirectory = 833,
		wdDialogFormatPageNumber = 298,
		wdDialogToolsCreateEnvelope = 173,
		wdDialogFormatParagraph = 175,
		wdDialogToolsCreateLabels = 489,
		wdDialogFormatPicture = 187,
		wdDialogToolsCustomize = 152,
		wdDialogFormatRetAddrFonts = 221,
		wdDialogToolsCustomizeKeyboard = 432,
		wdDialogFormatSectionLayout = 176,
		wdDialogToolsCustomizeMenuBar = 615,
		wdDialogFormatStyle = 180,
		wdDialogToolsCustomizeMenus = 433,
		wdDialogFormatStyleGallery = 505,
		wdDialogToolsDictionary = 989,
		wdDialogFormatStylesCustom = 1248,
		wdDialogToolsEnvelopesAndLabels = 607,
		wdDialogFormatTabs = 179,
		wdDialogToolsGrammarSettings = 885,
		wdDialogFormatTheme = 855,
		wdDialogToolsHangulHanjaConversion = 784,
		wdDialogFormattingRestrictions = 1427,
		wdDialogToolsHighlightChanges = 197,
		wdDialogFormFieldHelp = 361,
		wdDialogToolsHyphenation = 195,
		wdDialogFormFieldOptions = 353,
		wdDialogToolsLanguage = 188,
		wdDialogFrameSetProperties = 1074,
		wdDialogToolsMacro = 215,
		wdDialogHelpAbout = 9,
		wdDialogToolsMacroRecord = 214,
		wdDialogHelpWordPerfectHelp = 10,
		wdDialogToolsManageFields = 631,
		wdDialogHelpWordPerfectHelpOptions = 511,
		wdDialogToolsMergeDocuments = 435,
		wdDialogHorizontalInVertical = 1160,
		wdDialogToolsOptions = 974,
		wdDialogIMESetDefault = 1094,
		wdDialogToolsOptionsAutoFormat = 959,
		wdDialogInsertAddCaption = 402,
		wdDialogToolsOptionsAutoFormatAsYouType = 778,
		wdDialogInsertAutoCaption = 359,
		wdDialogToolsOptionsBidi = 1029,
		wdDialogInsertBookmark = 168,
		wdDialogToolsOptionsCompatibility = 525,
		wdDialogInsertBreak = 159,
		wdDialogToolsOptionsEdit = 224,
		wdDialogInsertCaption = 357,
		wdDialogToolsOptionsEditCopyPaste = 1356,
		wdDialogInsertCaptionNumbering = 358,
		wdDialogToolsOptionsFileLocations = 225,
		wdDialogInsertCrossReference = 367,
		wdDialogToolsOptionsFuzzy = 790,
		wdDialogInsertDatabase = 341,
		wdDialogToolsOptionsGeneral = 203,
		wdDialogInsertDateTime = 165,
		wdDialogToolsOptionsPrint = 208,
		wdDialogInsertField = 166,
		wdDialogToolsOptionsSave = 209,
		wdDialogInsertFile = 164,
		wdDialogToolsOptionsSecurity = 1361,
		wdDialogInsertFootnote = 370,
		wdDialogToolsOptionsSmartTag = 1395,
		wdDialogInsertFormField = 483,
		wdDialogToolsOptionsSpellingAndGrammar = 211,
		wdDialogInsertHyperlink = 925,
		wdDialogToolsOptionsTrackChanges = 386,
		wdDialogInsertIndex = 170,
		wdDialogToolsOptionsTypography = 739,
		wdDialogInsertIndexAndTables = 473,
		wdDialogToolsOptionsUserInfo = 213,
		wdDialogInsertMergeField = 167,
		wdDialogToolsOptionsView = 204,
		wdDialogInsertNumber = 812,
		wdDialogToolsProtectDocument = 503,
		wdDialogInsertObject = 172,
		wdDialogToolsProtectSection = 578,
		wdDialogInsertPageNumbers = 294,
		wdDialogToolsRevisions = 197,
		wdDialogInsertPicture = 163,
		wdDialogToolsSpellingAndGrammar = 828,
		wdDialogInsertSubdocument = 583,
		wdDialogToolsTemplates = 87,
		wdDialogInsertSymbol = 162,
		wdDialogToolsThesaurus = 194,
		wdDialogInsertTableOfAuthorities = 471,
		wdDialogToolsUnprotectDocument = 521,
		wdDialogInsertTableOfContents = 171,
		wdDialogToolsWordCount = 228,
		wdDialogInsertTableOfFigures = 472,
		wdDialogTwoLinesInOne = 1161,
		wdDialogInsertWebComponent = 1324,
		wdDialogUpdateTOC = 331,
		wdDialogLetterWizard = 821,
		wdDialogViewZoom = 577,
		wdDialogListCommands = 723,
		wdDialogWebOptions = 898,
		wdDialogMailMerge = 676,
		wdDialogWindowActivate = 220,
		wdDialogMailMergeCheck = 677,
		wdDialogXMLElementAttributes = 1460,
		wdDialogMailMergeCreateDataSource = 642,
		wdDialogXMLOptions = 1425
	}
}
