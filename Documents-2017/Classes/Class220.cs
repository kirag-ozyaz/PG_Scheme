using Documents.Classes;
using Documents.DataSets;
using Domino;
using FormLbr.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Class220 : IDisposable
{
    private NotesDatabase notesDatabase_0;
    private NotesDatabase notesDatabase_1;
    private NotesDatabase notesDatabase_2;
    private NotesDatabase notesDatabase_3;
    private NotesDocument notesDocument_0;
    private NotesDocument notesDocument_1;
    private NotesDocument notesDocument_2;
    private NotesDocument notesDocument_3;
    private NotesDocument notesDocument_4;
    private NotesDocument notesDocument_5;
    private NotesItem notesItem_0;
    private NotesItem notesItem_1;
    private NotesItem notesItem_2;
    private NotesItem notesItem_3;
    private NotesSession notesSession_0;
    private NotesView notesView_0;
    private NotesView notesView_1;
    private NotesView notesView_2;
    private NotesView notesView_3;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    [CompilerGenerated]
    private string string_5;
    [CompilerGenerated]
    private string string_6;
    [CompilerGenerated]
    private string string_7;
    [CompilerGenerated]
    private string string_8;
    private DataSetGES.vJ_BossUserDataTable vJ_BossUserDataTable_0;

    internal Class220()
    {
        this.string_4 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\LotusTemp\";
        this.vJ_BossUserDataTable_0 = new DataSetGES.vJ_BossUserDataTable();
        this.method_7();
        if (Directory.Exists(this.string_4))
        {
            Directory.CreateDirectory(this.string_4);
        }
    }

    internal Class220(string string_9)
    {
        this.string_4 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\LotusTemp\";
        this.vJ_BossUserDataTable_0 = new DataSetGES.vJ_BossUserDataTable();
        this.Password = string_9;
        this.method_7();
    }

    [CompilerGenerated]
    internal string method_0()
    {
        return this.string_5;
    }

    [CompilerGenerated]
    internal void method_1(string string_9)
    {
        this.string_5 = string_9;
    }

    internal bool method_10(string string_9, string string_10, string string_11, string string_12, Status status_0, string[] string_13, string string_14, string[] string_15, List<string> list_0)
    {
        this.method_3(string_9);
        smethod_0(string_10, string_13, string_14);
        if (this.notesSession_0 == null)
        {
            this.method_7();
        }
        this.notesDatabase_0 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\offmemo.nsf", false);
        NotesDocument documentByUNID = this.notesDatabase_0.GetDocumentByUNID(string_9);
        if ((documentByUNID.GetFirstItem("Status").get_Text() != "X") && (documentByUNID.GetFirstItem("Status").get_Text() != "Send"))
        {
            NotesItem item;
            NotesItem item2;
            NotesItem item3;
            NotesItem item4;
            NotesItem item5;
            NotesItem item6;
            this.notesDatabase_3 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\itstaff.nsf", false);
            this.notesDatabase_2 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", "names.nsf", false);
            this.notesView_1 = this.notesDatabase_2.GetView("_people");
            this.notesView_2 = this.notesDatabase_3.GetView("Структура");
            this.notesView_3 = this.notesDatabase_3.GetView(@"Сотрудники\вся информация");
            this.method_30(ref this.notesItem_0, ref this.notesDocument_1);
            this.method_29(ref this.notesItem_2, ref this.notesDocument_2);
            this.method_24(ref this.string_2, ref this.notesDocument_3);
            this.method_28(string_14, ref this.string_0, ref this.notesItem_3, ref this.notesDocument_4);
            this.method_25(ref this.string_1, ref this.notesItem_0, ref this.notesDocument_5);
            documentByUNID.ReplaceItemValue("Form", "OfficeMemo");
            documentByUNID.ReplaceItemValue("NewBody", "0");
            documentByUNID.ReplaceItemValue("Status", status_0.ToString());
            if (documentByUNID.HasItem("Body_e"))
            {
                ((NotesRichTextItem) documentByUNID.GetFirstItem("Body_e")).Remove();
            }
            NotesRichTextItem item1 = documentByUNID.CreateRichTextItem("Body_e");
            item1.AddNewLine(1, false);
            item1.AppendText(string_12);
            item1.AddNewLine(2, false);
            documentByUNID.ReplaceItemValue("Subject", string_11);
            documentByUNID.ReplaceItemValue("Category", "Служебная записка (ТП)");
            documentByUNID.ReplaceItemValue("Stamp", "1");
            documentByUNID.ReplaceItemValue("IO_InExec", this.method_4());
            documentByUNID.ReplaceItemValue("IO_InP", this.string_1);
            documentByUNID.ReplaceItemValue("IO_InP_Notes", this.string_0);
            documentByUNID.ReplaceItemValue("IO_InP_Notes_Proxy", this.string_0);
            documentByUNID.ReplaceItemValue("IO_InExec_Notes", this.notesItem_0);
            documentByUNID.ReplaceItemValue("Access_IO_InP", this.string_0);
            documentByUNID.ReplaceItemValue("IO_InExec_Dept", (this.notesItem_2 != null) ? this.notesItem_2.get_Text() : "");
            documentByUNID.ReplaceItemValue("IO_InDep", (this.notesItem_2 != null) ? this.notesItem_2.get_Text() : "");
            documentByUNID.ReplaceItemValue("IO_InExec_DeptID", this.string_2);
            documentByUNID.ReplaceItemValue("IO_InDepID", this.string_2);
            documentByUNID.ReplaceItemValue("Access_Flags", "InheritReaders");
            documentByUNID.ReplaceItemValue("AuthorSite", "CN=Domino/O=ULGES/C=RU");
            documentByUNID.ReplaceItemValue("Access_Servers", "CN=Domino/O=ULGES/C=RU");
            documentByUNID.ReplaceItemValue("Access_FlagsMod", "InheritReaders");
            documentByUNID.ReplaceItemValue("Access_Created", DateTime.Now);
            documentByUNID.ReplaceItemValue("Access_CName", this.method_4());
            documentByUNID.ReplaceItemValue("Access_CreatedBy", this.notesItem_0.get_Text());
            documentByUNID.ReplaceItemValue("IO_InExec_D", ((this.notesItem_2 != null) ? this.notesItem_2.get_Text() : "") + @"\" + this.method_4());
            documentByUNID.ReplaceItemValue("IO_In_D", ((this.notesItem_3 != null) ? this.notesItem_3.get_Text() : "") + @"\" + this.string_1);
            documentByUNID.ReplaceItemValue("Access_MName", this.method_4());
            documentByUNID.ReplaceItemValue("Access_ModifiedBy", this.notesItem_0.get_Text());
            documentByUNID.ReplaceItemValue("Access_ExtremeReaders", "[Extreme]");
            this.method_23(string_13, documentByUNID, out item, out item2, out item3, out item4);
            this.method_27(string_15, documentByUNID, item3, out item5, out item6);
            documentByUNID.ReplaceItemValue("IO_IntCorr", this.notesItem_2.get_Text());
            documentByUNID.ReplaceItemValue("IO_IntCorrID", item);
            documentByUNID.ReplaceItemValue("IO_IntCorrPers", item2);
            documentByUNID.ReplaceItemValue("IO_Org_D", item4);
            documentByUNID.ReplaceItemValue("ReviewersID", item5);
            documentByUNID.ReplaceItemValue("Reviewers", item6);
            documentByUNID.ReplaceItemValue("WriteAccess", item3);
            if (list_0 != null)
            {
                foreach (string str in list_0)
                {
                    if (str != "")
                    {
                        NotesRichTextItem firstItem;
                        FileInfo info = new FileInfo(str);
                        info.Name.Replace(info.Extension, "");
                        if (documentByUNID.HasItem("Body"))
                        {
                            firstItem = documentByUNID.GetFirstItem("Body");
                            if (firstItem.get_EmbeddedObjects() != null)
                            {
                                object[] objArray = (object[]) firstItem.get_EmbeddedObjects();
                                for (int i = 0; i < objArray.Length; i++)
                                {
                                    ((NotesEmbeddedObject) objArray[i]).Remove();
                                }
                            }
                        }
                        else
                        {
                            firstItem = documentByUNID.CreateRichTextItem("Body");
                        }
                        firstItem.EmbedObject(0x5ae, "", str, null);
                    }
                }
            }
            return documentByUNID.Save(true, true, false);
        }
        MessageBox.Show("Вы не можете править этот документ!", "Предупреждение.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
    }

    internal List<string> method_11(NotesDocument notesDocument_6, bool bool_0 = false, string string_9 = "")
    {
        List<string> list = new List<string>();
        NotesRichTextItem firstItem = notesDocument_6.GetFirstItem("Body");
        if (notesDocument_6.get_HasEmbedded() && (firstItem != null))
        {
            foreach (NotesEmbeddedObject obj2 in (object[]) firstItem.get_EmbeddedObjects())
            {
                if (obj2.get_type() == 0x5ae)
                {
                    string str = obj2.get_Name();
                    if (bool_0)
                    {
                        obj2.ExtractFile(string_9 + str);
                    }
                    list.Add(str.Replace("\r\n", ""));
                }
            }
        }
        return list;
    }

    internal List<NotesDocument> method_12()
    {
        List<NotesDocument> list = null;
        try
        {
            if (this.notesSession_0 == null)
            {
                this.method_7();
            }
            this.notesDatabase_1 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\ittask.nsf", false);
            this.notesView_0 = this.notesDatabase_1.GetView("UICommissionsAll");
            this.notesDocument_0 = this.notesView_0.GetFirstDocument();
            while (this.notesDocument_0 != null)
            {
                list.Add(this.notesDocument_0);
                this.notesDocument_0 = this.notesView_0.GetNextDocument(this.notesDocument_0);
            }
        }
        catch (Exception exception1)
        {
            throw new Exception(exception1.Message);
        }
        return list;
    }

    internal List<Class221> method_13(string string_9 = "", bool bool_0 = false)
    {
        List<Class221> list = null;
        try
        {
            if (this.notesSession_0 == null)
            {
                this.notesSession_0 = new NotesSessionClass();
                this.notesSession_0.Initialize(this.Password);
            }
            this.notesDatabase_1 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\ittask.nsf", false);
            this.notesView_0 = this.notesDatabase_1.GetView("UICommissionsAll");
            this.notesDocument_0 = this.notesView_0.GetFirstDocument();
            while (this.notesDocument_0 != null)
            {
                if ((string_9 == "") || (string_9 == this.method_21(this.notesDocument_0.GetFirstItem("ctb_InheritedID"))))
                {
                    list = this.method_14(list);
                    this.notesDocument_0 = this.notesView_0.GetNextDocument(this.notesDocument_0);
                }
            }
        }
        catch (Exception exception1)
        {
            throw new Exception(exception1.Message);
        }
        return list;
    }

    private List<Class221> method_14(List<Class221> list_0)
    {
        if (this.notesDocument_0.GetFirstItem("ctb_InheritedID") != null)
        {
            Class221 class2 = new Class221 {
                UniversalID = this.notesDocument_0.get_UniversalID(),
                Body = this.method_21(this.notesDocument_0.GetFirstItem("Body")),
                ctbStatus = this.method_21(this.notesDocument_0.GetFirstItem("ctbStatus")),
                ctb_InheritedID = this.method_21(this.notesDocument_0.GetFirstItem("ctb_InheritedID")),
                ctbBoss = this.method_21(this.notesDocument_0.GetFirstItem("ctbBoss")),
                ctbSubject = this.method_21(this.notesDocument_0.GetFirstItem("ctbSubject")),
                ctbExecutor = this.method_21(this.notesDocument_0.GetFirstItem("ctbExecutor")),
                ctbSign = this.method_21(this.notesDocument_0.GetFirstItem("ctbSign")),
                ctbBoss = this.method_21(this.notesDocument_0.GetFirstItem("ctbBoss")),
                ctbComment = this.method_21(this.notesDocument_0.GetFirstItem("ctbComment")),
                ctbDateCreate = this.method_21(this.notesDocument_0.GetFirstItem("ctbDateCreate")),
                ctbDateFact = this.method_21(this.notesDocument_0.GetFirstItem("ctbDateFact")),
                ctbDocNum = this.method_21(this.notesDocument_0.GetFirstItem("ctbDocNum")),
                Header_Title = this.method_21(this.notesDocument_0.GetFirstItem("Header_Title"))
            };
            if (this.notesDocument_0.HasItem("Body"))
            {
                List<Class224> list = new List<Class224>();
                NotesRichTextItem firstItem = this.notesDocument_0.GetFirstItem("Body");
                if ((firstItem.get_EmbeddedObjects() != null) && (((object[]) firstItem.get_EmbeddedObjects()).Count<object>() > 0))
                {
                    string[] separator = new string[] { " - " };
                    string[] source = firstItem.get_Text().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < source.Count<string>(); i++)
                    {
                        NotesEmbeddedObject obj2 = (NotesEmbeddedObject) ((object[]) firstItem.get_EmbeddedObjects())[i];
                        obj2.ExtractFile(this.string_4 + obj2.ToString());
                        FileBinary binary = new FileBinary(this.string_4 + obj2.ToString());
                        Class224 item = new Class224();
                        item.method_7(binary.get_ByteArray());
                        item.method_1(binary.get_Extension());
                        item.method_3(binary.get_KbSize());
                        item.method_5(item.method_4());
                        item.Name = source[i];
                        list.Add(item);
                        File.Delete(this.string_4 + obj2.ToString());
                    }
                }
                class2.Files = list;
            }
            if (list_0 == null)
            {
                list_0 = new List<Class221>();
            }
            list_0.Add(class2);
        }
        return list_0;
    }

    internal List<Class222> method_15(string string_9 = "", bool bool_0 = false)
    {
        List<Class222> list2;
        List<Class222> list = new List<Class222>();
        try
        {
            if (this.notesSession_0 == null)
            {
                this.notesSession_0 = new NotesSessionClass();
                this.notesSession_0.Initialize(this.Password);
            }
            NotesDatabase database = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\offmemo.nsf", false);
            if (string_9 != "")
            {
                this.method_16(list, database.GetDocumentByUNID(string_9));
            }
            NotesView view = database.GetView("UIOfficeMemoAll");
            NotesDocument firstDocument = view.GetFirstDocument();
            while (firstDocument != null)
            {
                if ((firstDocument.GetItemValue("Category") != null) || (firstDocument.GetItemValue("Category").ToString() == "Служебная записка (ТП)"))
                {
                    this.method_16(list, firstDocument);
                    firstDocument = view.GetNextDocument(firstDocument);
                }
            }
            this.notesSession_0 = null;
            list2 = list;
        }
        catch (Exception exception1)
        {
            MessageBox.Show(exception1.ToString());
            list2 = list;
        }
        finally
        {
            this.notesSession_0 = null;
        }
        return list2;
    }

    private void method_16(List<Class222> list_0, NotesDocument notesDocument_6)
    {
        Class222 class2 = new Class222 {
            UniversalID = notesDocument_6.get_UniversalID(),
            Body_C = this.method_21(notesDocument_6.GetFirstItem("Body_C")),
            Category = this.method_21(notesDocument_6.GetFirstItem("Category")),
            CorrName = this.method_21(notesDocument_6.GetFirstItem("CorrName")),
            ctb_InheritedID = this.method_21(notesDocument_6.GetFirstItem("ctb_InheritedID")),
            ctbDateCreate = this.method_21(notesDocument_6.GetFirstItem("ctbDateCreate")),
            IO_InExec = this.method_21(notesDocument_6.GetFirstItem("IO_InExec")),
            IO_InP = this.method_21(notesDocument_6.GetFirstItem("IO_InP")),
            RespDate = this.method_21(notesDocument_6.GetFirstItem("RespDate")),
            RespNum = this.method_21(notesDocument_6.GetFirstItem("RespNum")),
            Reviewers = this.method_21(notesDocument_6.GetFirstItem("Reviewers")),
            RgNum = this.method_21(notesDocument_6.GetFirstItem("RgNum")),
            SignDate = this.method_21(notesDocument_6.GetFirstItem("SignDate")),
            Status = this.method_21(notesDocument_6.GetFirstItem("Status")),
            Subject = this.method_21(notesDocument_6.GetFirstItem("Subject"))
        };
        if (notesDocument_6.HasItem("Body"))
        {
            List<Class224> list = new List<Class224>();
            NotesRichTextItem firstItem = notesDocument_6.GetFirstItem("Body");
            if ((firstItem.get_EmbeddedObjects() != null) && (((object[]) firstItem.get_EmbeddedObjects()).Count<object>() > 0))
            {
                string[] separator = new string[] { " - " };
                string[] source = firstItem.get_Text().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < source.Count<string>(); i++)
                {
                    NotesEmbeddedObject obj2 = (NotesEmbeddedObject) ((object[]) firstItem.get_EmbeddedObjects())[i];
                    obj2.ExtractFile(this.string_4 + obj2.ToString());
                    FileBinary binary = new FileBinary(this.string_4 + obj2.ToString());
                    Class224 item = new Class224();
                    item.method_7(binary.get_ByteArray());
                    item.method_1(binary.get_Extension());
                    item.method_3(binary.get_KbSize());
                    item.method_5(item.method_4());
                    item.Name = source[i];
                    list.Add(item);
                    File.Delete(this.string_4 + obj2.ToString());
                }
            }
            class2.Files = list;
        }
        list_0.Add(class2);
    }

    internal DataTable method_17()
    {
        DataTable table2;
        DataTable table = new DataTable();
        try
        {
            if (this.notesSession_0 == null)
            {
                this.notesSession_0 = new NotesSessionClass();
                this.notesSession_0.Initialize(this.Password);
            }
            NotesView view = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\offmemo.nsf", false).GetView("UIOfficeMemoAll");
            table.Columns.Add("UniversalID");
            NotesDocument firstDocument = view.GetFirstDocument();
            foreach (NotesItem item in (object[]) firstDocument.get_Items())
            {
                table.Columns.Add(item.get_Name(), typeof(object));
            }
        Label_00A9:
            if (firstDocument != null)
            {
                DataRow row = table.NewRow();
                row["UniversalID"] = firstDocument.get_UniversalID();
                object[] objArray = (object[]) firstDocument.get_Items();
                int index = 0;
                while (true)
                {
                    if (index < objArray.Length)
                    {
                        NotesItem item2 = (NotesItem) objArray[index];
                        try
                        {
                            if (!table.Columns.Contains(item2.get_Name()))
                            {
                                table.Columns.Add(item2.get_Name());
                            }
                            row[item2.get_Name()] = ((item2 == null) || (item2.get_Text() == null)) ? "" : item2.get_Text();
                        }
                        catch (Exception exception1)
                        {
                            MessageBox.Show(exception1.ToString());
                        }
                    }
                    else
                    {
                        table.Rows.Add(row);
                        firstDocument = view.GetNextDocument(firstDocument);
                        goto Label_00A9;
                    }
                    index++;
                }
            }
            this.notesSession_0 = null;
            table2 = table;
        }
        catch (Exception exception2)
        {
            MessageBox.Show(exception2.ToString());
            table2 = table;
        }
        finally
        {
            this.notesSession_0 = null;
        }
        return table2;
    }

    internal DataTable method_18(string[] string_9)
    {
        DataTable table = new DataTable();
        try
        {
            if (this.notesSession_0 == null)
            {
                this.notesSession_0 = new NotesSessionClass();
                this.notesSession_0.Initialize(this.Password);
            }
            NotesView view = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\offmemo.nsf", false).GetView("UIOfficeMemoAll");
            foreach (string str in string_9)
            {
                table.Columns.Add(str);
            }
            NotesDocument firstDocument = view.GetFirstDocument();
        Label_007A:
            if (firstDocument != null)
            {
                DataRow row = table.NewRow();
                row["UniversalID"] = firstDocument.get_UniversalID();
                object[] objArray = (object[]) firstDocument.get_Items();
                int index = 0;
                while (true)
                {
                    if (index < objArray.Length)
                    {
                        NotesItem item = (NotesItem) objArray[index];
                        try
                        {
                            if (string_9.Contains<string>(item.get_Name()))
                            {
                                row[item.get_Name()] = ((item == null) || (item.get_Text() == null)) ? "" : item.get_Text();
                            }
                        }
                        catch (Exception exception1)
                        {
                            MessageBox.Show(exception1.ToString());
                        }
                    }
                    else
                    {
                        table.Rows.Add(row);
                        firstDocument = view.GetNextDocument(firstDocument);
                        goto Label_007A;
                    }
                    index++;
                }
            }
            this.notesSession_0 = null;
        }
        catch (Exception exception2)
        {
            MessageBox.Show(exception2.ToString());
        }
        finally
        {
            this.notesSession_0 = null;
        }
        return table;
    }

    internal List<Class223> method_19()
    {
        return this.method_20("");
    }

    [CompilerGenerated]
    internal string method_2()
    {
        return this.string_6;
    }

    internal List<Class223> method_20(string string_9)
    {
        List<Class223> list = new List<Class223>();
        try
        {
            if (this.notesSession_0 == null)
            {
                this.notesSession_0 = new NotesSessionClass();
                this.notesSession_0.Initialize(this.Password);
            }
            NotesDatabase database = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\itstaff.nsf", false);
            if (!database.get_IsOpen())
            {
                database.Open();
            }
            NotesView view = database.GetView(@"Сотрудники\вся информация");
            for (NotesDocument document = view.GetFirstDocument(); document != null; document = view.GetNextDocument(document))
            {
                NotesItem firstItem = document.GetFirstItem("User_NotesName");
                if ((document.GetFirstItem("Form").get_Text() == "Person") && ((string_9 == "") || ((firstItem != null) && (string_9 == firstItem.get_Text()))))
                {
                    Class223 item = new Class223 {
                        Form = (document.GetFirstItem("Form") != null) ? document.GetFirstItem("Form").get_Text() : "",
                        FirstName = (document.GetFirstItem("FirstName") != null) ? document.GetFirstItem("FirstName").get_Text() : "",
                        LastName = (document.GetFirstItem("LastName") != null) ? document.GetFirstItem("LastName").get_Text() : "",
                        MiddleInitial = (document.GetFirstItem("MiddleInitial") != null) ? document.GetFirstItem("MiddleInitial").get_Text() : ""
                    };
                    string[] textArray1 = new string[] { item.LastName, " ", item.FirstName, " ", item.MiddleInitial };
                    item.FIO = string.Concat(textArray1);
                    item.FullName = (document.GetFirstItem("FullName") != null) ? document.GetFirstItem("FullName").get_Text() : "";
                    item.Owner = (document.GetFirstItem("Owner") != null) ? document.GetFirstItem("Owner").get_Text() : "";
                    item.PersonName = (document.GetFirstItem("Person_Name") != null) ? document.GetFirstItem("Person_Name").get_Text() : "";
                    item.UniversalID = document.get_UniversalID();
                    item.UserNotesName = (document.GetFirstItem("User_NotesName") != null) ? document.GetFirstItem("User_NotesName").get_Text() : "";
                    list.Add(item);
                    if (string_9 != "")
                    {
                        return list;
                    }
                }
            }
            return list;
        }
        catch (Exception exception1)
        {
            MessageBox.Show(exception1.ToString());
        }
        finally
        {
            this.notesSession_0 = null;
        }
        return list;
    }

    private string method_21(NotesItem notesItem_4)
    {
        if (notesItem_4 != null)
        {
            if (!string.IsNullOrEmpty(notesItem_4.get_Text()))
            {
                return notesItem_4.get_Text();
            }
            if ((notesItem_4.get_Values() != null) && (notesItem_4.get_Values() is string))
            {
                return notesItem_4.get_Values().ToString();
            }
        }
        return "";
    }

    private void method_22(string[] string_9, NotesDocument notesDocument_6, out NotesItem notesItem_4, out NotesItem notesItem_5, out NotesItem notesItem_6, out NotesItem notesItem_7)
    {
        notesItem_4 = notesDocument_6.AppendItemValue("IO_IntCorrID", "");
        NotesItem item = notesDocument_6.AppendItemValue("IO_IntCorr", "");
        notesItem_5 = notesDocument_6.AppendItemValue("IO_IntCorrPers", "");
        notesItem_6 = notesDocument_6.AppendItemValue("WriteAccess", "");
        notesItem_7 = notesDocument_6.AppendItemValue("IO_Org_D", "");
        this.string_3 = "";
        foreach (string str in string_9)
        {
            this.notesDocument_3 = this.notesView_3.GetFirstDocument();
            while (this.notesDocument_3 != null)
            {
                if (((this.notesDocument_3.GetFirstItem("form") != null) && (this.notesDocument_3.GetFirstItem("form").get_Text() == "Person")) && ((this.notesDocument_3.GetFirstItem("Person_Name") != null) && (this.notesDocument_3.GetFirstItem("Person_Name").get_Text() == str)))
                {
                    goto Label_0110;
                }
                this.notesDocument_3 = this.notesView_3.GetNextDocument(this.notesDocument_3);
            }
            goto Label_01E1;
        Label_0110:
            this.string_2 = this.notesDocument_3.get_UniversalID();
            this.string_3 = this.notesDocument_3.get_ParentDocumentUNID();
            this.notesDocument_2 = this.notesView_2.GetFirstDocument();
            while (this.notesDocument_2 != null)
            {
                if (((this.notesDocument_2.GetFirstItem("form") != null) && (this.notesDocument_2.GetFirstItem("form").get_Text() == "Person")) && ((this.notesDocument_2.GetFirstItem("Person_Name") != null) && (this.notesDocument_2.GetFirstItem("Person_Name").get_Text() == str)))
                {
                    goto Label_01CB;
                }
                this.notesDocument_2 = this.notesView_2.GetNextDocument(this.notesDocument_2);
            }
            goto Label_01E1;
        Label_01CB:
            this.notesItem_2 = this.notesDocument_2.GetFirstItem("DBody_Struct_Dept");
        Label_01E1:
            notesItem_7.AppendToTextList(this.notesItem_2.get_Text() + @"\" + str);
            notesItem_4.AppendToTextList(this.string_3);
            item.AppendToTextList(this.notesItem_2.get_Text() ?? "");
            notesItem_5.AppendToTextList(str + "|" + this.string_2);
            notesItem_6.AppendToTextList(this.notesDocument_3.GetFirstItem("User_NotesName").get_Text());
        }
    }

    private void method_23(string[] string_9, NotesDocument notesDocument_6, out NotesItem notesItem_4, out NotesItem notesItem_5, out NotesItem notesItem_6, out NotesItem notesItem_7)
    {
        notesItem_4 = notesDocument_6.ReplaceItemValue("IO_IntCorrID", "");
        NotesItem item = notesDocument_6.ReplaceItemValue("IO_IntCorr", "");
        notesItem_5 = notesDocument_6.ReplaceItemValue("IO_IntCorrPers", "");
        notesItem_6 = notesDocument_6.ReplaceItemValue("WriteAccess", "");
        notesItem_7 = notesDocument_6.ReplaceItemValue("IO_Org_D", "");
        this.string_3 = "";
        foreach (string str in string_9)
        {
            this.notesDocument_3 = this.notesView_3.GetFirstDocument();
            while (this.notesDocument_3 != null)
            {
                if (((this.notesDocument_3.GetFirstItem("form") != null) && (this.notesDocument_3.GetFirstItem("form").get_Text() == "Person")) && ((this.notesDocument_3.GetFirstItem("Person_Name") != null) && (this.notesDocument_3.GetFirstItem("Person_Name").get_Text() == str)))
                {
                    goto Label_0110;
                }
                this.notesDocument_3 = this.notesView_3.GetNextDocument(this.notesDocument_3);
            }
            goto Label_01E1;
        Label_0110:
            this.string_2 = this.notesDocument_3.get_UniversalID();
            this.string_3 = this.notesDocument_3.get_ParentDocumentUNID();
            this.notesDocument_2 = this.notesView_2.GetFirstDocument();
            while (this.notesDocument_2 != null)
            {
                if (((this.notesDocument_2.GetFirstItem("form") != null) && (this.notesDocument_2.GetFirstItem("form").get_Text() == "Person")) && ((this.notesDocument_2.GetFirstItem("Person_Name") != null) && (this.notesDocument_2.GetFirstItem("Person_Name").get_Text() == str)))
                {
                    goto Label_01CB;
                }
                this.notesDocument_2 = this.notesView_2.GetNextDocument(this.notesDocument_2);
            }
            goto Label_01E1;
        Label_01CB:
            this.notesItem_2 = this.notesDocument_2.GetFirstItem("DBody_Struct_Dept");
        Label_01E1:
            notesItem_7.AppendToTextList(this.notesItem_2.get_Text() + @"\" + str);
            notesItem_4.AppendToTextList(this.string_3);
            item.AppendToTextList(this.notesItem_2.get_Text() ?? "");
            notesItem_5.AppendToTextList(str + "|" + this.string_2);
            notesItem_6.AppendToTextList(this.notesDocument_3.GetFirstItem("User_NotesName").get_Text());
        }
    }

    private void method_24(ref string string_9, ref NotesDocument notesDocument_6)
    {
        notesDocument_6 = this.notesView_3.GetFirstDocument();
        while (notesDocument_6 != null)
        {
            if (((notesDocument_6.GetFirstItem("form") != null) && (notesDocument_6.GetFirstItem("form").get_Text() == "Person")) && ((notesDocument_6.GetFirstItem("Person_Name") != null) && (notesDocument_6.GetFirstItem("Person_Name").get_Text() == this.method_4())))
            {
                string_9 = notesDocument_6.get_ParentDocumentUNID();
                return;
            }
            notesDocument_6 = this.notesView_3.GetNextDocument(notesDocument_6);
        }
    }

    private void method_25(ref string string_9, ref NotesItem notesItem_4, ref NotesDocument notesDocument_6)
    {
        notesDocument_6 = this.notesView_3.GetFirstDocument();
        string_9 = "";
        notesDocument_6 = this.notesView_1.GetFirstDocument();
        while (notesDocument_6 != null)
        {
            if ((notesDocument_6.GetFirstItem("Owner") != null) && (notesDocument_6.GetFirstItem("Owner").get_Text() == this.string_0))
            {
                this.notesItem_1 = notesDocument_6.GetFirstItem("Owner");
                break;
            }
            notesDocument_6 = this.notesView_1.GetNextDocument(notesDocument_6);
        }
        if (this.notesItem_1 == null)
        {
            throw new Exception("Не заполнен \"Подписант\".");
        }
        string[] textArray1 = new string[] { notesDocument_6.GetFirstItem("LastName").get_Text(), " ", notesDocument_6.GetFirstItem("FirstName").get_Text(), " ", notesDocument_6.GetFirstItem("MiddleInitial").get_Text() };
        string_9 = string.Concat(textArray1);
    }

    private void method_26(string[] string_9, NotesDocument notesDocument_6, NotesItem notesItem_4, out NotesItem notesItem_5, out NotesItem notesItem_6)
    {
        NotesItem firstItem = null;
        notesItem_5 = notesDocument_6.AppendItemValue("ReviewersID", "");
        notesItem_6 = notesDocument_6.AppendItemValue("Reviewers", "");
        notesDocument_6.AppendItemValue("Access_ANames", this.method_4());
        notesDocument_6.AppendItemValue("Access_Authors", this.notesItem_0);
        foreach (string str in string_9)
        {
            this.notesDocument_3 = this.notesView_3.GetFirstDocument();
            while (this.notesDocument_3 != null)
            {
                if (((this.notesDocument_3.GetFirstItem("form") != null) && (this.notesDocument_3.GetFirstItem("form").get_Text() == "Person")) && ((this.notesDocument_3.GetFirstItem("Person_Name") != null) && (this.notesDocument_3.GetFirstItem("Person_Name").get_Text() == str)))
                {
                    goto Label_00F2;
                }
                this.notesDocument_3 = this.notesView_3.GetNextDocument(this.notesDocument_3);
            }
            continue;
        Label_00F2:
            this.string_2 = this.notesDocument_3.get_UniversalID();
            firstItem = this.notesDocument_3.GetFirstItem("Person_Name");
            notesItem_5.AppendToTextList(this.string_2);
            notesItem_6.AppendToTextList(firstItem.get_Text());
            notesItem_4.AppendToTextList(this.notesDocument_3.GetFirstItem("User_NotesName").get_Text());
        }
    }

    private void method_27(string[] string_9, NotesDocument notesDocument_6, NotesItem notesItem_4, out NotesItem notesItem_5, out NotesItem notesItem_6)
    {
        NotesItem firstItem = null;
        notesItem_5 = notesDocument_6.ReplaceItemValue("ReviewersID", "");
        notesItem_6 = notesDocument_6.ReplaceItemValue("Reviewers", "");
        notesDocument_6.ReplaceItemValue("Access_ANames", this.method_4());
        notesDocument_6.ReplaceItemValue("Access_Authors", this.notesItem_0);
        foreach (string str in string_9)
        {
            this.notesDocument_3 = this.notesView_3.GetFirstDocument();
            while (this.notesDocument_3 != null)
            {
                if (((this.notesDocument_3.GetFirstItem("form") != null) && (this.notesDocument_3.GetFirstItem("form").get_Text() == "Person")) && ((this.notesDocument_3.GetFirstItem("Person_Name") != null) && (this.notesDocument_3.GetFirstItem("Person_Name").get_Text() == str)))
                {
                    goto Label_00F2;
                }
                this.notesDocument_3 = this.notesView_3.GetNextDocument(this.notesDocument_3);
            }
            continue;
        Label_00F2:
            this.string_2 = this.notesDocument_3.get_UniversalID();
            firstItem = this.notesDocument_3.GetFirstItem("Person_Name");
            notesItem_5.AppendToTextList(this.string_2);
            notesItem_6.AppendToTextList(firstItem.get_Text());
            notesItem_4.AppendToTextList(this.notesDocument_3.GetFirstItem("User_NotesName").get_Text());
        }
    }

    private void method_28(string string_9, ref string string_10, ref NotesItem notesItem_4, ref NotesDocument notesDocument_6)
    {
        notesDocument_6 = this.notesView_3.GetFirstDocument();
        notesItem_4 = null;
        string_10 = "";
        while (notesDocument_6 != null)
        {
            if (((notesDocument_6.GetFirstItem("form") != null) && (notesDocument_6.GetFirstItem("form").get_Text() == "Person")) && (notesDocument_6.GetFirstItem("Person_Name").get_Text() == string_9))
            {
                string_10 = notesDocument_6.GetFirstItem("User_NotesName").get_Text();
                notesItem_4 = this.notesItem_2;
                return;
            }
            notesDocument_6 = this.notesView_3.GetNextDocument(notesDocument_6);
        }
    }

    private void method_29(ref NotesItem notesItem_4, ref NotesDocument notesDocument_6)
    {
        notesDocument_6 = this.notesView_2.GetFirstDocument();
        this.notesItem_2 = null;
        while (notesDocument_6 != null)
        {
            if (((notesDocument_6.GetFirstItem("form") != null) && (notesDocument_6.GetFirstItem("form").get_Text() == "Person")) && ((notesDocument_6.GetFirstItem("Person_Name") != null) && (notesDocument_6.GetFirstItem("Person_Name").get_Text() == this.method_4())))
            {
                this.notesItem_2 = notesDocument_6.GetFirstItem("DBody_Struct_Dept");
                return;
            }
            notesDocument_6 = this.notesView_2.GetNextDocument(notesDocument_6);
        }
    }

    [CompilerGenerated]
    internal void method_3(string string_9)
    {
        this.string_6 = string_9;
    }

    private void method_30(ref NotesItem notesItem_4, ref NotesDocument notesDocument_6)
    {
        notesDocument_6 = this.notesView_1.GetFirstDocument();
        while (notesDocument_6 != null)
        {
            if (notesDocument_6.GetFirstItem("Owner").get_Text() == this.notesSession_0.get_UserName())
            {
                notesItem_4 = notesDocument_6.GetFirstItem("Owner");
                break;
            }
            notesDocument_6 = this.notesView_1.GetNextDocument(notesDocument_6);
        }
        this.method_5(((notesDocument_6.GetFirstItem("LastName").get_Text() != null) ? (notesDocument_6.GetFirstItem("LastName").get_Text().Trim() + " ") : "") + ((notesDocument_6.GetFirstItem("FirstName").get_Text() != null) ? (notesDocument_6.GetFirstItem("FirstName").get_Text().Trim() + " ") : "") + ((notesDocument_6.GetFirstItem("MiddleInitial").get_Text() != null) ? notesDocument_6.GetFirstItem("MiddleInitial").get_Text().Trim() : ""));
    }

    internal void method_31()
    {
        this.notesItem_3 = null;
        this.notesItem_2 = null;
        this.notesItem_0 = null;
        this.notesDocument_5 = null;
        this.notesDocument_4 = null;
        this.notesDocument_3 = null;
        this.notesDocument_2 = null;
        this.notesDocument_1 = null;
        this.notesView_3 = null;
        this.notesView_2 = null;
        this.notesView_1 = null;
        this.notesDatabase_3 = null;
        this.notesDatabase_2 = null;
        this.notesDatabase_0 = null;
        this.notesSession_0 = null;
    }

    [CompilerGenerated]
    internal string method_4()
    {
        return this.string_8;
    }

    [CompilerGenerated]
    private void method_5(string string_9)
    {
        this.string_8 = string_9;
    }

    internal Class223 method_6()
    {
        if (this.notesSession_0 == null)
        {
            this.notesSession_0 = new NotesSessionClass();
            this.notesSession_0.Initialize(this.Password);
        }
        List<Class223> source = this.method_20(this.notesSession_0.get_UserName());
        if (source.Count <= 0)
        {
            return new Class223("", "", "", "");
        }
        return source.First<Class223>();
    }

    internal void method_7()
    {
        if (string.IsNullOrEmpty(this.Password))
        {
            throw new Exception("Не указан пароль пользователя");
        }
        this.notesSession_0 = new NotesSessionClass();
        this.notesSession_0.Initialize(this.Password);
    }

    internal bool method_8(string string_9)
    {
        NotesDocument documentByUNID = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\offmemo.nsf", false).GetDocumentByUNID(string_9);
        if ((documentByUNID.GetFirstItem("Status").get_Text() != "X") && (documentByUNID.GetFirstItem("Status").get_Text() != "Send"))
        {
            return true;
        }
        MessageBox.Show("Вы не можете править этот документ!", "Предупреждение.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
    }

    internal bool method_9(string string_9, string string_10, string string_11, Status status_0, string[] string_12, string string_13, string[] string_14, List<string> list_0)
    {
        NotesItem item;
        NotesItem item2;
        NotesItem item3;
        NotesItem item4;
        NotesItem item5;
        NotesItem item6;
        smethod_0(string_9, string_12, string_13);
        if (this.notesSession_0 == null)
        {
            this.method_7();
        }
        this.notesDatabase_0 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\offmemo.nsf", false);
        this.notesDatabase_3 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", @"Referent\itstaff.nsf", false);
        this.notesDatabase_2 = this.notesSession_0.GetDatabase("Domino/ULGES/RU", "names.nsf", false);
        this.notesView_1 = this.notesDatabase_2.GetView("_people");
        this.notesView_2 = this.notesDatabase_3.GetView("Структура");
        this.notesView_3 = this.notesDatabase_3.GetView(@"Сотрудники\вся информация");
        this.method_30(ref this.notesItem_0, ref this.notesDocument_1);
        this.method_29(ref this.notesItem_2, ref this.notesDocument_2);
        this.method_24(ref this.string_2, ref this.notesDocument_3);
        this.method_28(string_13, ref this.string_0, ref this.notesItem_3, ref this.notesDocument_4);
        this.method_25(ref this.string_1, ref this.notesItem_0, ref this.notesDocument_5);
        NotesDocument document = this.notesDatabase_0.CreateDocument();
        document.AppendItemValue("Form", "OfficeMemo");
        document.AppendItemValue("NewBody", "0");
        document.AppendItemValue("Status", status_0.ToString());
        NotesRichTextItem item1 = document.CreateRichTextItem("Body_e");
        item1.AddNewLine(1, false);
        item1.AppendText(string_11);
        item1.AddNewLine(2, false);
        document.AppendItemValue("Subject", string_10);
        document.AppendItemValue("Category", "Служебная записка (ТП)");
        document.AppendItemValue("Stamp", "1");
        document.AppendItemValue("IO_InExec", this.method_4());
        document.AppendItemValue("IO_InP", this.string_1);
        document.AppendItemValue("IO_InP_Notes", this.string_0);
        document.AppendItemValue("IO_InP_Notes_Proxy", this.string_0);
        document.AppendItemValue("IO_InExec_Notes", this.notesItem_0);
        document.AppendItemValue("Access_IO_InP", this.string_0);
        document.AppendItemValue("IO_InExec_Dept", (this.notesItem_2 != null) ? this.notesItem_2.get_Text() : "");
        document.AppendItemValue("IO_InDep", (this.notesItem_2 != null) ? this.notesItem_2.get_Text() : "");
        document.AppendItemValue("IO_InExec_DeptID", this.string_2);
        document.AppendItemValue("IO_InDepID", this.string_2);
        document.AppendItemValue("Access_Flags", "InheritReaders");
        document.AppendItemValue("AuthorSite", "CN=Domino/O=ULGES/C=RU");
        document.AppendItemValue("Access_Servers", "CN=Domino/O=ULGES/C=RU");
        document.AppendItemValue("Access_FlagsMod", "InheritReaders");
        document.AppendItemValue("Access_Created", DateTime.Now);
        document.AppendItemValue("Access_CName", this.method_4());
        document.AppendItemValue("Access_CreatedBy", this.notesItem_0.get_Text());
        document.AppendItemValue("IO_InExec_D", ((this.notesItem_2 != null) ? this.notesItem_2.get_Text() : "") + @"\" + this.method_4());
        document.AppendItemValue("IO_In_D", ((this.notesItem_3 != null) ? this.notesItem_3.get_Text() : "") + @"\" + this.string_1);
        document.AppendItemValue("Access_MName", this.method_4());
        document.AppendItemValue("Access_ModifiedBy", this.notesItem_0.get_Text());
        document.AppendItemValue("Access_ExtremeReaders", "[Extreme]");
        this.method_22(string_12, document, out item, out item2, out item3, out item4);
        this.method_26(string_14, document, item3, out item5, out item6);
        document.AppendItemValue("IO_IntCorr", this.notesItem_2.get_Text());
        document.AppendItemValue("IO_IntCorrID", item);
        document.AppendItemValue("IO_IntCorrPers", item2);
        document.AppendItemValue("IO_Org_D", item4);
        document.AppendItemValue("ReviewersID", item5);
        document.AppendItemValue("Reviewers", item6);
        document.AppendItemValue("WriteAccess", item3);
        if (list_0 != null)
        {
            foreach (string str in list_0)
            {
                if (str != "")
                {
                    NotesRichTextItem firstItem;
                    FileInfo info = new FileInfo(str);
                    info.Name.Replace(info.Extension, "");
                    if (document.HasItem("Body"))
                    {
                        firstItem = document.GetFirstItem("Body");
                    }
                    else
                    {
                        firstItem = document.CreateRichTextItem("Body");
                    }
                    firstItem.EmbedObject(0x5ae, "", str, null);
                }
            }
        }
        this.method_3(document.get_UniversalID());
        return document.Save(true, true, false);
    }

    private static void smethod_0(string string_9, string[] string_10, string string_11)
    {
        if (string.IsNullOrEmpty(string_9))
        {
            throw new Exception("Не заполнена \"Категория\"");
        }
        string_10.Where<string>((<>c.<>9__62_0 ?? (<>c.<>9__62_0 = new Func<string, bool>(<>c.<>9.method_0)))).Count<string>();
        if (string_10.Where<string>((<>c.<>9__62_1 ?? (<>c.<>9__62_1 = new Func<string, bool>(<>c.<>9.method_1)))).Count<string>() == 0)
        {
            throw new Exception("Не заполнен \"Адресат\"");
        }
        if (string.IsNullOrEmpty(string_11))
        {
            throw new Exception("Не заполнен \"Подписант\"");
        }
    }

    void IDisposable.Dispose()
    {
        this.notesItem_3 = null;
        this.notesItem_2 = null;
        this.notesItem_0 = null;
        this.notesDocument_5 = null;
        this.notesDocument_4 = null;
        this.notesDocument_3 = null;
        this.notesDocument_2 = null;
        this.notesDocument_1 = null;
        this.notesView_3 = null;
        this.notesView_2 = null;
        this.notesView_1 = null;
        this.notesDatabase_3 = null;
        this.notesDatabase_2 = null;
        this.notesDatabase_0 = null;
        this.notesSession_0 = null;
    }

    internal string Password
    {
        [CompilerGenerated]
        get
        {
            return this.string_7;
        }
        [CompilerGenerated]
        set
        {
            this.string_7 = value;
        }
    }

    [Serializable, CompilerGenerated]
    private sealed class <>c
    {
        public static readonly Class220.<>c <>9 = new Class220.<>c();
        public static Func<string, bool> <>9__62_0;
        public static Func<string, bool> <>9__62_1;

        internal bool method_0(string string_0)
        {
            return !string.IsNullOrEmpty(string_0);
        }

        internal bool method_1(string string_0)
        {
            return !string.IsNullOrEmpty(string_0);
        }
    }
}

