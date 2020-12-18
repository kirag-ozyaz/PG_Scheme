using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class DataGridViewTextBoxTagColumn : DataGridViewColumn
{
    #region 4.Создайте класс с именем DataGridViewRolloverCellColumn, производный от типа DataGridViewColumn. В конструкторе назначьте новый объект DataGridViewRolloverCell его свойству CellTemplate.
        public DataGridViewTextBoxTagColumn()
        {
            this.CellTemplate = new DataGridViewTextBoxTagCell();

        }
    #endregion
}
public class DataGridViewTextBoxTagCell : DataGridViewTextBoxCell
{
    #region 2. Переопределите метод Paint в классе DataGridViewRolloverCell. При переопределении сначала вызовите реализацию базового класса, которая отвечает за функциональные возможности размещенного текстового поля. Затем с помощью метода PointToClient элемента управления преобразуйте положение курсора (в экранных координатах) в координаты клиентской области DataGridView. Если координаты курсора попадают в границы ячейки, то рисуется внутренняя рамка.
    protected override void Paint(    Graphics graphics,    Rectangle clipBounds,    Rectangle cellBounds,    int rowIndex,    DataGridViewElementStates cellState,    object value,    object formattedValue,    string errorText,    DataGridViewCellStyle cellStyle,    DataGridViewAdvancedBorderStyle advancedBorderStyle,    DataGridViewPaintParts paintParts)
    {
        // Call the base class method to paint the default cell appearance.
        base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
            value, formattedValue, errorText, cellStyle,
            advancedBorderStyle, paintParts);

        // Retrieve the client location of the mouse pointer.
        Point cursorPosition =
            this.DataGridView.PointToClient(Cursor.Position);

        // If the mouse pointer is over the current cell, draw a custom border.
        if (cellBounds.Contains(cursorPosition))
        {
            Rectangle newRect = new Rectangle(cellBounds.X + 1,
                cellBounds.Y + 1, cellBounds.Width - 4,
                cellBounds.Height - 4);
            graphics.DrawRectangle(Pens.Red, newRect);
        }
    }
    #endregion
    #region 3. Переопределите методы OnMouseEnter и OnMouseLeave класса DataGridViewRolloverCell, чтобы ячейки отрисовывались повторно, когда указатель мыши пересекает их границы.
    // Force the cell to repaint itself when the mouse pointer enters it.
    protected override void OnMouseEnter(int rowIndex)
    {
        this.DataGridView.InvalidateCell(this);
    }

    // Force the cell to repaint itself when the mouse pointer leaves it.
    protected override void OnMouseLeave(int rowIndex)
    {
        this.DataGridView.InvalidateCell(this);
    }
    #endregion
    public object Tag1 { get; set; }

}


#region Красная окантовка вокруг ячейки при наведении курсора
// https://docs.microsoft.com/ru-ru/dotnet/framework/winforms/controls/customize-cells-and-columns-in-the-datagrid-by-extending-behavior
public class DataGridViewRolloverCell : DataGridViewTextBoxCell
{
    protected override void Paint(
        Graphics graphics,
        Rectangle clipBounds,
        Rectangle cellBounds,
        int rowIndex,
        DataGridViewElementStates cellState,
        object value,
        object formattedValue,
        string errorText,
        DataGridViewCellStyle cellStyle,
        DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
    {
        // Call the base class method to paint the default cell appearance.
        base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
            value, formattedValue, errorText, cellStyle,
            advancedBorderStyle, paintParts);

        // Retrieve the client location of the mouse pointer.
        Point cursorPosition =
            this.DataGridView.PointToClient(Cursor.Position);

        // If the mouse pointer is over the current cell, draw a custom border.
        if (cellBounds.Contains(cursorPosition))
        {
            Rectangle newRect = new Rectangle(cellBounds.X + 1,
                cellBounds.Y + 1, cellBounds.Width - 4,
                cellBounds.Height - 4);
            graphics.DrawRectangle(Pens.Red, newRect);
        }
    }

    // Force the cell to repaint itself when the mouse pointer enters it.
    protected override void OnMouseEnter(int rowIndex)
    {
        this.DataGridView.InvalidateCell(this);
    }

    // Force the cell to repaint itself when the mouse pointer leaves it.
    protected override void OnMouseLeave(int rowIndex)
    {
        this.DataGridView.InvalidateCell(this);
    }

}

public class DataGridViewRolloverCellColumn : DataGridViewColumn
{
    public DataGridViewRolloverCellColumn()
    {
        this.CellTemplate = new DataGridViewRolloverCell();
    }
}
#endregion

//На просторах большого SO был найден похожий на ваш вопрос и довольно не плохой ответ (https://stackoverflow.com/questions/19914880/using-a-custom-control-in-a-datagridview/19924829#19924829).Звучит вопрос так: «Using a custom control in a DataGridView» (Использование настраиваемого элемента управления в DataGridView). Собственно говоря, ссылка на источник: Using a custom control in a DataGridView и перевод ответа на русский язык:

//Для начала необходимо вычислить общее количество ячеек отображения, и вам необходим список List<YourControl> чтобы хранить все необходимые элементы управления. Эти элементы управления должны иметь свой DataGridView как и их Parent.Количество этих элементов должно быть равно количеству отображаемых ячеек.Затем в обработчике события CellPainting вы должны обновить расположение всех элементов управления в списке. В обработчика события CellPainting добавим код обновления, потому что всякий раз, когда значение ячейки и границы обновляются, то CellPainting выполнится и обновит средства управления Location. Этот процесс немного сложнее, но это работает.Вы можете связать каждый элемент управления с каждой ячейкой с помощью свойства reference , у такого элемента как Tag свойство.

//Подход.Вам просто нужно создать пользовательский DataGridViewCell используемый в качестве CellTemplate для обычного DataGridViewColumn.Далее довольно много кода:
/// <summary>
/// Колонка для указания рейтинга ()
/// </summary>
public class DataGridViewRatingColumn : DataGridViewColumn
{
    public DataGridViewRatingColumn() : base(new DataGridViewRatingCell())
    {
        base.ReadOnly = true;
        RatedStarColor = Color.Green;
        GrayStarColor = Color.LightGray;
        StarScale = 1;
    }
    bool readOnly;
    public new bool ReadOnly
    {
        get
        {
            return readOnly;
        }
        set
        {
            readOnly = value;
        }
    }
    Color ratedStarColor;
    Color grayStarColor;
    float starScale;
    public Color RatedStarColor
    {
        get { return ratedStarColor; }
        set
        {
            if (ratedStarColor != value)
            {
                ratedStarColor = value;
                if (DataGridView != null) DataGridView.InvalidateColumn(Index);
            }
        }
    }
    public Color GrayStarColor
    {
        get { return grayStarColor; }
        set
        {
            if (grayStarColor != value)
            {
                grayStarColor = value;
                if (DataGridView != null) DataGridView.InvalidateColumn(Index);
            }
        }
    }
    public float StarScale
    {
        get { return starScale; }
        set
        {
            if (starScale != value)
            {
                starScale = value;
                DataGridViewRatingCell.UpdateBrushes(value);
                if (DataGridView != null) DataGridView.InvalidateColumn(Index);
            }
        }
    }
}
public class DataGridViewRatingCell : DataGridViewTextBoxCell
{
    static DataGridViewRatingCell()
    {
        //Init star            
        List<PointF> points = new List<PointF>();
        bool largeArc = true;
        R = 10;
        r = 4;
        center = new Point(R, R);
        for (float alpha = 90; alpha <= 414; alpha += 36)
        {
            int d = largeArc ? R : r;
            double radAlpha = alpha * Math.PI / 180;
            float x = (float)(d * Math.Cos(radAlpha));
            float y = (float)(d * Math.Sin(radAlpha));
            points.Add(new PointF(center.X + x, center.Y + y));
            largeArc = !largeArc;
        }
        star.AddPolygon(points.ToArray());
        star.Transform(new Matrix(1, 0, 0, -1, 0, center.Y * 2));
        //Init stars
        UpdateBrushes(1);
    }
    public DataGridViewRatingCell()
    {
        ValueType = typeof(int);
        ratedStarColor = Color.Green;
        grayStarColor = Color.LightGray;
        starScale = 1;
        UseColumnStarColor = true;
        UseColumnStarScale = true;
    }
    public override object DefaultNewRowValue
    {
        get
        {
            return 0;
        }
    }
    internal static void UpdateBrushes(float scale)
    {
        int space = 2 * R;
        for (int i = 0; i < 5; i++)
        {
            if (stars[i] != null) stars[i].Dispose();
            stars[i] = (GraphicsPath)star.Clone();
            stars[i].Transform(new Matrix(scale, 0, 0, scale, space * i * scale, 0));
            brushes[i] = CreateBrush(new RectangleF(center.X - R + space * i * scale, center.Y - R, R * 2 * scale, R * 2 * scale));
        }
    }
    private static LinearGradientBrush CreateBrush(RectangleF bounds)
    {
        var brush = new LinearGradientBrush(bounds, Color.White, Color.Yellow, LinearGradientMode.ForwardDiagonal);
        ColorBlend cb = new ColorBlend();
        Color c = Color.Green;
        Color lightColor = Color.White;
        cb.Colors = new Color[] { c, c, lightColor, c, c };
        cb.Positions = new float[] { 0, 0.4f, 0.5f, 0.6f, 1 };
        brush.InterpolationColors = cb;
        return brush;
    }
    private void AdjustBrushColors(LinearGradientBrush brush, Color baseColor, Color lightColor)
    {
        //Note how we adjust the colors, using brush.InterpolationColors directly won't work.
        ColorBlend cb = brush.InterpolationColors;
        cb.Colors = new Color[] { baseColor, baseColor, lightColor, baseColor, baseColor };
        brush.InterpolationColors = cb;
    }
    static GraphicsPath star = new GraphicsPath();
    static GraphicsPath[] stars = new GraphicsPath[5];
    static LinearGradientBrush[] brushes = new LinearGradientBrush[5];
    static Point center;
    static int R, r;
    int currentValue = -1;
    bool mouseOver;
    protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds,
        int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue,
        string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
    {
        base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue,
            errorText, cellStyle, advancedBorderStyle, paintParts & ~DataGridViewPaintParts.SelectionBackground & ~DataGridViewPaintParts.ContentForeground);
        if (rowIndex == RowIndex && (paintParts & DataGridViewPaintParts.ContentForeground) != 0)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (Value != null) Value = Math.Min(Math.Max(0, (int)Value), 5);
            if (!mouseOver) currentValue = (int)(Value ?? 0);
            PaintStars(graphics, cellBounds, 0, currentValue, true);
            PaintStars(graphics, cellBounds, currentValue, 5 - currentValue, false);
            graphics.SmoothingMode = SmoothingMode.Default;
        }
    }
    protected override void OnMouseMove(DataGridViewCellMouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (!mouseOver) mouseOver = true;
        if (IsReadOnly()) return;
        var lastStar = stars.Select((x, i) => new { x, i })
                            .LastOrDefault(x => x.x.IsVisible(e.Location));
        if (lastStar != null)
        {
            currentValue = lastStar.i + 1;
            DataGridView.Cursor = Cursors.Hand;
        }
        else if (RowIndex > -1)
        {
            currentValue = (int)(Value ?? 0);
            DataGridView.Cursor = Cursors.Default;
        }
        DataGridView.InvalidateCell(this);
    }
    protected override void OnClick(DataGridViewCellEventArgs e)
    {
        base.OnClick(e);
        if (IsReadOnly()) return;
        Value = currentValue == 1 && (int?)Value == 1 ? 0 : currentValue;
    }
    protected override void OnMouseLeave(int rowIndex)
    {
        base.OnMouseLeave(rowIndex);
        mouseOver = false;
        if (IsReadOnly()) return;
        if (rowIndex == RowIndex)
        {
            currentValue = (int)(Value ?? 0);
            DataGridView.InvalidateCell(this);
        }
    }
    private bool IsReadOnly()
    {
        var col = OwningColumn as DataGridViewRatingColumn;
        return col != null ? col.ReadOnly : false;
    }
    private void PaintStars(Graphics g, Rectangle bounds, int startIndex, int count, bool rated)
    {
        GraphicsState gs = g.Save();
        g.TranslateTransform(bounds.Left, bounds.Top);
        var col = OwningColumn as DataGridViewRatingColumn;
        Color ratedColor = col == null ? Color.Yellow :
            UseColumnStarColor ? col.RatedStarColor : RatedStarColor;
        Color grayColor = col == null ? Color.LightGray :
            UseColumnStarColor ? col.GrayStarColor : GrayStarColor;
        float starScale = col == null ? 1 :
            UseColumnStarScale ? col.StarScale : StarScale;
        UpdateBrushes(starScale);
        for (int i = startIndex; i < startIndex + count; i++)
        {
            AdjustBrushColors(brushes[i], rated ? ratedColor : grayColor, rated ? Color.White : grayColor);
            g.FillPath(brushes[i], stars[i]);
            //g.DrawPath(Pens.Green, stars[i]);
        }
        g.Restore(gs);
    }
    Color ratedStarColor;
    Color grayStarColor;
    float starScale;
    public Color RatedStarColor
    {
        get { return ratedStarColor; }
        set
        {
            if (ratedStarColor != value)
            {
                ratedStarColor = value;
                var col = OwningColumn as DataGridViewRatingColumn;
                if (col != null && col.RatedStarColor != value)
                {
                    UseColumnStarColor = false;
                    DataGridView.InvalidateCell(this);
                }
            }
        }
    }
    public Color GrayStarColor
    {
        get { return grayStarColor; }
        set
        {
            if (grayStarColor != value)
            {
                grayStarColor = value;
                var col = OwningColumn as DataGridViewRatingColumn;
                if (col != null && col.GrayStarColor != value)
                {
                    UseColumnStarColor = false;
                    DataGridView.InvalidateCell(this);
                }
            }
        }
    }
    //Change the star size via scaling factor (default by 1)
    public float StarScale
    {
        get { return starScale; }
        set
        {
            if (starScale != value)
            {
                starScale = value;
                var col = OwningColumn as DataGridViewRatingColumn;
                if (col != null && col.StarScale != value)
                {
                    UseColumnStarScale = false;
                    DataGridView.InvalidateCell(this);
                }
            }
        }
    }
    public bool UseColumnStarColor { get; set; }
    public bool UseColumnStarScale { get; set; }
}

//Примечания: два класса DataGridViewRatingColumn и DataGridViewRatingCell должны быть размещены в одном и том же файле, потому что внутри объявлен статический метод UpdateBrushes в DataGridViewRatingCell используемый в классе DataGridViewRatingColumn.Можно изменить модификатор доступа, если нужно разместить их в отдельных файлах.Посмотрите на предоставленные классы, свойства и методы - их названия говорят сами за себя. Их можно использовать, чтобы настроить внешний вид контрола (звезд). Пример кода, показывающий использование:

//dataGridView1.Columns.Add(new DataGridViewRatingColumn()
//{
//    // свойства DataGridViewRatingColumn можно инициализировать здесь...
//});

//// Чтобы изменить ReadOnly, которое позволяет пользователю писать или нет, вам нужно
//// сначала преобразовать столбец в DataGridViewRatingColumn, это поведение вызвано 
//// ненормальным поведением переопределения ReadOnly (поэтому пришлось использовать новый).
//((DataGridViewRatingColumn) dataGridView1.Columns[0]).ReadOnly = true; (default by false)

//// также вы должны включить DoubleBuffered в DataGridView для устранения мерцания
//typeof(Control).GetProperty("DoubleBuffered",
//    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
//  .SetValue(dataGridView1, true, null);
#region столбец календаря
// https://docs.microsoft.com/ru-ru/dotnet/framework/winforms/controls/how-to-host-controls-in-windows-forms-datagridview-cells
public class CalendarColumn : DataGridViewColumn
{
    public CalendarColumn() : base(new CalendarCell())
    {
    }

    public override DataGridViewCell CellTemplate
    {
        get
        {
            return base.CellTemplate;
        }
        set
        {
            // Ensure that the cell used for the template is a CalendarCell.
            if (value != null &&
                !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
            {
                throw new InvalidCastException("Must be a CalendarCell");
            }
            base.CellTemplate = value;
        }
    }
}

public class CalendarCell : DataGridViewTextBoxCell
{

    public CalendarCell()
        : base()
    {
        // Use the short date format.
        this.Style.Format = "d";
    }

    public override void InitializeEditingControl(int rowIndex, object
        initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
    {
        // Set the value of the editing control to the current cell value.
        base.InitializeEditingControl(rowIndex, initialFormattedValue,
            dataGridViewCellStyle);
        CalendarEditingControl ctl =
            DataGridView.EditingControl as CalendarEditingControl;
        // Use the default row value when Value property is null.
        if (this.Value == null)
        {
            ctl.Value = (DateTime)this.DefaultNewRowValue;
        }
        else
        {
            ctl.Value = (DateTime)this.Value;
        }
    }

    public override Type EditType
    {
        get
        {
            // Return the type of the editing control that CalendarCell uses.
            return typeof(CalendarEditingControl);
        }
    }

    public override Type ValueType
    {
        get
        {
            // Return the type of the value that CalendarCell contains.

            return typeof(DateTime);
        }
    }

    public override object DefaultNewRowValue
    {
        get
        {
            // Use the current date and time as the default value.
            return DateTime.Now;
        }
    }
}

class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
{
    DataGridView dataGridView;
    private bool valueChanged = false;
    int rowIndex;

    public CalendarEditingControl()
    {
        this.Format = DateTimePickerFormat.Short;
    }

    // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
    // property.
    public object EditingControlFormattedValue
    {
        get
        {
            return this.Value.ToShortDateString();
        }
        set
        {
            if (value is String)
            {
                try
                {
                    // This will throw an exception of the string is 
                    // null, empty, or not in the format of a date.
                    this.Value = DateTime.Parse((String)value);
                }
                catch
                {
                    // In the case of an exception, just use the 
                    // default value so we're not left with a null
                    // value.
                    this.Value = DateTime.Now;
                }
            }
        }
    }

    // Implements the 
    // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
    public object GetEditingControlFormattedValue(
        DataGridViewDataErrorContexts context)
    {
        return EditingControlFormattedValue;
    }

    // Implements the 
    // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
    public void ApplyCellStyleToEditingControl(
        DataGridViewCellStyle dataGridViewCellStyle)
    {
        this.Font = dataGridViewCellStyle.Font;
        this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
        this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
    }

    // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
    // property.
    public int EditingControlRowIndex
    {
        get
        {
            return rowIndex;
        }
        set
        {
            rowIndex = value;
        }
    }

    // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
    // method.
    public bool EditingControlWantsInputKey(
        Keys key, bool dataGridViewWantsInputKey)
    {
        // Let the DateTimePicker handle the keys listed.
        switch (key & Keys.KeyCode)
        {
            case Keys.Left:
            case Keys.Up:
            case Keys.Down:
            case Keys.Right:
            case Keys.Home:
            case Keys.End:
            case Keys.PageDown:
            case Keys.PageUp:
                return true;
            default:
                return !dataGridViewWantsInputKey;
        }
    }

    // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
    // method.
    public void PrepareEditingControlForEdit(bool selectAll)
    {
        // No preparation needs to be done.
    }

    // Implements the IDataGridViewEditingControl
    // .RepositionEditingControlOnValueChange property.
    public bool RepositionEditingControlOnValueChange
    {
        get
        {
            return false;
        }
    }

    // Implements the IDataGridViewEditingControl
    // .EditingControlDataGridView property.
    public DataGridView EditingControlDataGridView
    {
        get
        {
            return dataGridView;
        }
        set
        {
            dataGridView = value;
        }
    }

    // Implements the IDataGridViewEditingControl
    // .EditingControlValueChanged property.
    public bool EditingControlValueChanged
    {
        get
        {
            return valueChanged;
        }
        set
        {
            valueChanged = value;
        }
    }

    // Implements the IDataGridViewEditingControl
    // .EditingPanelCursor property.
    public Cursor EditingPanelCursor
    {
        get
        {
            return base.Cursor;
        }
    }

    protected override void OnValueChanged(EventArgs eventargs)
    {
        // Notify the DataGridView that the contents of the cell
        // have changed.
        valueChanged = true;
        this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
        base.OnValueChanged(eventargs);
    }
}
#endregion