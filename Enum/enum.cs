    /// <summary>
    /// ����� �������������� ���������
    /// eActionRequest
    /// </summary>
    internal enum eActionRequest
    {
        Add = 0, Edit = 1, Read = 2
    }

    private enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    
    /// <summary>
    /// ��� ����� ���������� ������
    /// </summary>
    internal enum eSelectTypeFieldContact
    {
        Tag = 0,//���
        Division = 1,//�������������
        Contact = 2// ������
    }
 
/// ����� ������ 
    private enum eFind
    {
        First = 0,
        Next = 1,
        Prev = 2
    }