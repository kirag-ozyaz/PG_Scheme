    /// <summary>
    /// Режим редактирования документа
    /// eActionRequest
    /// </summary>
    internal enum eActionRequest
    {
        Add = 0, Edit = 1, Read = 2
    }

    private enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    
    /// <summary>
    /// Тип полей контактных данных
    /// </summary>
    internal enum eSelectTypeFieldContact
    {
        Tag = 0,//тэг
        Division = 1,//подразделение
        Contact = 2// прочее
    }
 
/// режим поиска 
    private enum eFind
    {
        First = 0,
        Next = 1,
        Prev = 2
    }