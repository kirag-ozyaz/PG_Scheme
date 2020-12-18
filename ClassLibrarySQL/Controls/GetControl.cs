using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    /// <summary>
    /// работа  с элементами формы
    /// </summary>
    public static class Controls
    {
        /// <summary>
        /// вернуть имя контрола на форме
        /// </summary>
        public static Control GetName(Control control, string name)
        {
            var fetchedControl = control.Controls[name];
            if (fetchedControl == null)
                foreach (Control c in control.Controls)
                {
                    fetchedControl = GetName(c, name);
                    if (fetchedControl != null)
                        break;
                }
            return fetchedControl;
        }
        ///  <summary>
        /// Изменим ширину выпадающего списка
        /// </summary>
        public static void GetDropDownWidth(Control control, ComboBox cmb)
        {
            int width = cmb.DropDownWidth;
            Graphics g = control.CreateGraphics();
            Font font = cmb.Font;
            int vertScrollBarWidth =
                (cmb.Items.Count > cmb.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;
            int newWidth;

            foreach (string s in cmb.Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            cmb.DropDownWidth = width;
            cmb.Size = new Size(width, cmb.Size.Height);
        }
        ///  <summary>
        /// Изменим ширину выпадающего списка
        /// </summary>
        public static void GetDropDownWidth(Control control, ToolStripComboBox cmb)
        {
            int width = cmb.DropDownWidth;
            Graphics g = control.CreateGraphics();
            Font font = cmb.Font;
            int vertScrollBarWidth =
                (cmb.Items.Count > cmb.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;
            int newWidth;

            foreach (string s in cmb.Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            cmb.DropDownWidth = width;
            cmb.Size = new Size(width, cmb.Size.Height);
        }
        /// <summary>
        /// уберем выделени текста в комбобоксах
        /// </summary>
        public static void ControlSelectionLengthComboBox(Control.ControlCollection controlCollection)
        {
            foreach (Control cb in controlCollection)
            {
                if (cb is ComboBox)
                {
                    cb.Resize += delegate (object sender, EventArgs e)
                    {
                        if (cb is ComboBox && !cb.Focused)
                        {
                            ((ComboBox)cb).SelectionStart = 0;
                            ((ComboBox)cb).SelectionLength = 0;
                        }
                    };
                }
                if (cb is ToolStrip)
                {
                    foreach (ToolStripItem tsi in ((ToolStrip)cb).Items)
                    {
                        if (tsi is ToolStripItem && tsi.GetType() == typeof(ToolStripControlHost))
                        {
                            Control ctrl = ((ToolStripControlHost)tsi).Control;
                            if (ctrl is ComboBox)
                            {
                                ctrl.Resize += delegate (object sender, EventArgs e)
                                {
                                    if (!ctrl.IsHandleCreated)
                                        return;

                                    // if (ctrl is ComboBox && !(ctrl.Focused))
                                    {
                                        ctrl.BeginInvoke(new Action(() =>
                                        {
                                            var parent = ctrl.FindForm();
                                            if (parent == null)
                                                return;

                                            if (parent.ActiveControl == null)
                                                return;

                                            if (parent.ActiveControl == ctrl)
                                                return;
                                            ((ComboBox)ctrl).SelectionStart = 0;
                                            ((ComboBox)ctrl).SelectionLength = 0;
                                        }));
                                    }
                                };
                            }
                        }
                    }
                }
                ControlSelectionLengthComboBox(cb.Controls);
            }
        }
        /// <summary>
        /// Приведение значения перечисления в удобочитаемый формат.
        /// </summary>
        /// <remarks>
        /// Для корректной работы необходимо использовать атрибут [Description("Name")] для каждого элемента перечисления.
        /// </remarks>
        /// <param name="enumElement">Элемент перечисления</param>
        ///// <returns>Название элемента</returns>
        public static string GetDescription(this Enum enumElement)
        {
            Type type = enumElement.GetType();

            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return enumElement.ToString();
        }

        //public static string ToDescription<TEnum>(this TEnum EnumValue) where TEnum : struct
        //{
        //    return Controls.GetEnumDescription((Enum)(object)((TEnum)EnumValue));
        //}

        //public static string GetEnumDescription(this Enum value)
        //{
        //    FieldInfo field = value.GetType().GetField(value.ToString());

        //    DescriptionAttribute attribute
        //            = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
        //                as DescriptionAttribute;

        //    return attribute == null ? value.ToString() : attribute.Description;
        //}
    }

}

