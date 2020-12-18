using MarkupConverter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

internal static class Class21
{
    private static readonly string[] string_0 = new string[] { 
        "aliceblue", "antiquewhite", "aqua", "aquamarine", "azure", "beige", "bisque", "black", "blanchedalmond", "blue", "blueviolet", "brown", "burlywood", "cadetblue", "chartreuse", "chocolate",
        "coral", "cornflowerblue", "cornsilk", "crimson", "cyan", "darkblue", "darkcyan", "darkgoldenrod", "darkgray", "darkgreen", "darkkhaki", "darkmagenta", "darkolivegreen", "darkorange", "darkorchid", "darkred",
        "darksalmon", "darkseagreen", "darkslateblue", "darkslategray", "darkturquoise", "darkviolet", "deeppink", "deepskyblue", "dimgray", "dodgerblue", "firebrick", "floralwhite", "forestgreen", "fuchsia", "gainsboro", "ghostwhite",
        "gold", "goldenrod", "gray", "green", "greenyellow", "honeydew", "hotpink", "indianred", "indigo", "ivory", "khaki", "lavender", "lavenderblush", "lawngreen", "lemonchiffon", "lightblue",
        "lightcoral", "lightcyan", "lightgoldenrodyellow", "lightgreen", "lightgrey", "lightpink", "lightsalmon", "lightseagreen", "lightskyblue", "lightslategray", "lightsteelblue", "lightyellow", "lime", "limegreen", "linen", "magenta",
        "maroon", "mediumaquamarine", "mediumblue", "mediumorchid", "mediumpurple", "mediumseagreen", "mediumslateblue", "mediumspringgreen", "mediumturquoise", "mediumvioletred", "midnightblue", "mintcream", "mistyrose", "moccasin", "navajowhite", "navy",
        "oldlace", "olive", "olivedrab", "orange", "orangered", "orchid", "palegoldenrod", "palegreen", "paleturquoise", "palevioletred", "papayawhip", "peachpuff", "peru", "pink", "plum", "powderblue",
        "purple", "red", "rosybrown", "royalblue", "saddlebrown", "salmon", "sandybrown", "seagreen", "seashell", "sienna", "silver", "skyblue", "slateblue", "slategray", "snow", "springgreen",
        "steelblue", "tan", "teal", "thistle", "tomato", "turquoise", "violet", "wheat", "white", "whitesmoke", "yellow", "yellowgreen"
    };
    private static readonly string[] string_1 = new string[] { 
        "activeborder", "activecaption", "appworkspace", "background", "buttonface", "buttonhighlight", "buttonshadow", "buttontext", "captiontext", "graytext", "highlight", "highlighttext", "inactiveborder", "inactivecaption", "inactivecaptiontext", "infobackground",
        "infotext", "menu", "menutext", "scrollbar", "threeddarkshadow", "threedface", "threedhighlight", "threedlightshadow", "threedshadow", "window", "windowframe", "windowtext"
    };
    private static readonly string[] string_10 = new string[] { "inside", "outside" };
    private static readonly string[] string_11 = new string[] { "none", "underline", "overline", "line-through", "blink" };
    private static readonly string[] string_12 = new string[] { "none", "capitalize", "uppercase", "lowercase" };
    private static readonly string[] string_13 = new string[] { "left", "right", "center", "justify" };
    private static readonly string[] string_14 = new string[] { "baseline", "sub", "super", "top", "text-top", "middle", "bottom", "text-bottom" };
    private static readonly string[] string_15 = new string[] { "left", "right", "none" };
    private static readonly string[] string_16 = new string[] { "none", "left", "right", "both" };
    private static readonly string[] string_17 = new string[] { "none", "dotted", "dashed", "solid", "double", "groove", "ridge", "inset", "outset" };
    private static string[] string_18 = new string[] { "block", "inline", "list-item", "none" };
    private static readonly string[] string_2 = new string[] { "serif", "sans-serif", "monospace", "cursive", "fantasy" };
    private static readonly string[] string_3 = new string[] { "normal", "italic", "oblique" };
    private static readonly string[] string_4 = new string[] { "normal", "small-caps" };
    private static readonly string[] string_5 = new string[] { "normal", "bold", "bolder", "lighter", "100", "200", "300", "400", "500", "600", "700", "800", "900" };
    private static readonly string[] string_6 = new string[] { "xx-small", "x-small", "small", "medium", "large", "x-large", "xx-large" };
    private static readonly string[] string_7 = new string[] { "larger", "smaller" };
    private static readonly string[] string_8 = new string[] { "px", "mm", "cm", "in", "pt", "pc", "em", "ex", "%" };
    private static readonly string[] string_9 = new string[] { "disc", "circle", "square", "decimal", "lower-roman", "upper-roman", "lower-alpha", "upper-alpha", "none" };

    internal static void smethod_0(XmlElement xmlElement_0, string string_19, Class22 class22_0, Hashtable hashtable_0, List<XmlElement> list_0)
    {
        string str = class22_0.method_3(string_19, list_0);
        string attribute = HtmlToXamlConverter.GetAttribute(xmlElement_0, "style");
        string str3 = (str != null) ? str : null;
        if (attribute != null)
        {
            str3 = (str3 == null) ? attribute : (str3 + ";" + attribute);
        }
        if (str3 != null)
        {
            char[] separator = new char[] { ';' };
            string[] strArray = str3.Split(separator);
            for (int i = 0; i < strArray.Length; i++)
            {
                string str4;
                string str5;
                int num2;
                uint num3;
                char[] chArray2 = new char[] { ':' };
                string[] strArray2 = strArray[i].Split(chArray2);
                if (strArray2.Length == 2)
                {
                    str4 = strArray2[0].Trim().ToLower();
                    str5 = HtmlToXamlConverter.smethod_0(strArray2[1].Trim()).ToLower();
                    num2 = 0;
                    num3 = Class227.smethod_0(str4);
                    if (num3 <= 0x88814459)
                    {
                        if (num3 <= 0x3d7e6258)
                        {
                            if (num3 <= 0x274e1290)
                            {
                                if (num3 <= 0xf0cc3d8)
                                {
                                    switch (num3)
                                    {
                                        case 0x79bd282:
                                        {
                                            if (str4 == "text-align")
                                            {
                                                smethod_20(str5, ref num2, hashtable_0);
                                            }
                                            continue;
                                        }
                                        case 0xd0e23a8:
                                        {
                                            if (str4 == "font-variant")
                                            {
                                                smethod_11(str5, ref num2, hashtable_0);
                                            }
                                            continue;
                                        }
                                    }
                                    if ((num3 == 0xf0cc3d8) && (str4 == "font-style"))
                                    {
                                        smethod_10(str5, ref num2, hashtable_0);
                                    }
                                }
                                else
                                {
                                    switch (num3)
                                    {
                                        case 0x1f523237:
                                        {
                                            if (str4 == "border")
                                            {
                                                smethod_25(str5, ref num2, hashtable_0);
                                            }
                                            continue;
                                        }
                                        case 0x20c4ce3f:
                                        {
                                            if (str4 == "font-family")
                                            {
                                                smethod_13(str5, ref num2, hashtable_0);
                                            }
                                            continue;
                                        }
                                    }
                                    if ((num3 == 0x274e1290) && (str4 == "font"))
                                    {
                                        smethod_9(str5, hashtable_0);
                                    }
                                }
                            }
                            else if (num3 <= 0x30037084)
                            {
                                switch (num3)
                                {
                                    case 0x2c3a7b53:
                                    {
                                        if (str4 == "vertical-align")
                                        {
                                            smethod_21(str5, ref num2, hashtable_0);
                                        }
                                        continue;
                                    }
                                    case 0x2ef4c9d1:
                                    {
                                        if (str4 == "word-spacing")
                                        {
                                        }
                                        continue;
                                    }
                                }
                                if ((num3 == 0x30037084) && (str4 != "border-bottom-width"))
                                {
                                }
                            }
                            else if (num3 <= 0x34a74fa7)
                            {
                                if (num3 == 0x31139a45)
                                {
                                    if (str4 == "margin-top")
                                    {
                                        goto Label_0572;
                                    }
                                }
                                else if ((num3 == 0x34a74fa7) && (str4 == "text-indent"))
                                {
                                    smethod_6(str5, ref num2, hashtable_0, "text-indent", false);
                                }
                            }
                            else if (num3 != 0x386d0f95)
                            {
                                if ((num3 == 0x3d7e6258) && (str4 == "color"))
                                {
                                    smethod_8(str5, ref num2, hashtable_0, "color");
                                }
                            }
                            else if (str4 == "border-bottom")
                            {
                            }
                        }
                        else if (num3 <= 0x4f0febbb)
                        {
                            if (num3 <= 0x463684e0)
                            {
                                switch (num3)
                                {
                                    case 0x41c0820d:
                                    {
                                        if (str4 == "border-right-width")
                                        {
                                        }
                                        continue;
                                    }
                                    case 0x4569f715:
                                    {
                                        if (str4 == "display")
                                        {
                                        }
                                        continue;
                                    }
                                }
                                if ((num3 == 0x463684e0) && (str4 == "margin-right"))
                                {
                                    goto Label_0572;
                                }
                            }
                            else
                            {
                                switch (num3)
                                {
                                    case 0x4babd89d:
                                    {
                                        if (str4 == "background")
                                        {
                                            smethod_27(str5, ref num2, hashtable_0);
                                        }
                                        continue;
                                    }
                                    case 0x4de11fef:
                                    {
                                        if (str4 == "margin-left")
                                        {
                                            goto Label_0572;
                                        }
                                        continue;
                                    }
                                }
                                if ((num3 == 0x4f0febbb) && (str4 != "border-left"))
                                {
                                }
                            }
                        }
                        else if (num3 <= 0x5c6e1222)
                        {
                            switch (num3)
                            {
                                case 0x54cfb37d:
                                {
                                    if (str4 == "border-bottom-style")
                                    {
                                    }
                                    continue;
                                }
                                case 0x576bfd10:
                                {
                                    if (str4 == "padding-top")
                                    {
                                        goto Label_08B3;
                                    }
                                    continue;
                                }
                            }
                            if ((num3 == 0x5c6e1222) && (str4 == "clear"))
                            {
                                smethod_23(str5, ref num2, hashtable_0);
                            }
                        }
                        else if (num3 <= 0x79a90ea7)
                        {
                            if (num3 == 0x79974cea)
                            {
                                if (str4 == "border-right-color")
                                {
                                }
                            }
                            else if ((num3 == 0x79a90ea7) && (str4 == "text-decoration"))
                            {
                                smethod_18(str5, ref num2, hashtable_0);
                            }
                        }
                        else if (num3 != 0x809608b6)
                        {
                            if ((num3 == 0x88814459) && (str4 != "border-top"))
                            {
                            }
                        }
                        else if (str4 == "padding")
                        {
                            smethod_24(str5, ref num2, hashtable_0, str4);
                        }
                    }
                    else
                    {
                        if (num3 > 0xc662ae27)
                        {
                            goto Label_070D;
                        }
                        if (num3 > 0x9fb8c69e)
                        {
                            goto Label_05E6;
                        }
                        if (num3 > 0x95876e1f)
                        {
                            goto Label_0584;
                        }
                        switch (num3)
                        {
                            case 0x900e0a71:
                                goto Label_0561;

                            case 0x908cab31:
                            {
                                if (str4 == "letter-spacing")
                                {
                                }
                                continue;
                            }
                        }
                        if ((num3 == 0x95876e1f) && (str4 == "width"))
                        {
                            goto Label_07EE;
                        }
                    }
                }
                continue;
            Label_0561:
                if (str4 != "margin-bottom")
                {
                    continue;
                }
            Label_0572:
                smethod_6(str5, ref num2, hashtable_0, str4, true);
                continue;
            Label_0584:
                switch (num3)
                {
                    case 0x98a4e9ff:
                    {
                        if (str4 == "border-bottom-color")
                        {
                        }
                        continue;
                    }
                    case 0x9de554d1:
                    {
                        if (str4 == "border-color")
                        {
                            goto Label_0850;
                        }
                        continue;
                    }
                    default:
                    {
                        if ((num3 == 0x9fb8c69e) && (str4 != "border-left-width"))
                        {
                        }
                        continue;
                    }
                }
            Label_05E6:
                if (num3 <= 0xab783b8c)
                {
                    switch (num3)
                    {
                        case 0xa6497a0f:
                        {
                            if (str4 == "text-transform")
                            {
                                smethod_19(str5, ref num2, hashtable_0);
                            }
                            continue;
                        }
                        case 0xa6c45d85:
                        {
                            if (str4 == "float")
                            {
                                smethod_22(str5, ref num2, hashtable_0);
                            }
                            continue;
                        }
                    }
                    if ((num3 == 0xab783b8c) && (str4 == "padding-left"))
                    {
                        goto Label_08B3;
                    }
                }
                else if (num3 <= 0xc18cc803)
                {
                    if (num3 == 0xaea533b5)
                    {
                        if (str4 == "border-left-color")
                        {
                        }
                    }
                    else if ((num3 == 0xc18cc803) && (str4 == "font-weight"))
                    {
                        smethod_12(str5, ref num2, hashtable_0);
                    }
                }
                else if (num3 != 0xc542b16a)
                {
                    if ((num3 == 0xc662ae27) && (str4 == "background-color"))
                    {
                        smethod_8(str5, ref num2, hashtable_0, "background-color");
                    }
                }
                else if (str4 == "border-width")
                {
                    goto Label_0850;
                }
                continue;
            Label_070D:
                if (num3 > 0xda21f5a7)
                {
                    goto Label_0800;
                }
                if (num3 <= 0xd0e0e0a3)
                {
                    switch (num3)
                    {
                        case 0xca23d419:
                        {
                            if (str4 == "padding-right")
                            {
                                goto Label_08B3;
                            }
                            continue;
                        }
                        case 0xcf03278c:
                        {
                            if (str4 == "border-right-style")
                            {
                            }
                            continue;
                        }
                    }
                    if ((num3 == 0xd0e0e0a3) && (str4 != "border-top-color"))
                    {
                    }
                }
                else
                {
                    switch (num3)
                    {
                        case 0xd5bdbb42:
                            goto Label_07DD;

                        case 0xd7713c7b:
                        {
                            if (str4 == "margin")
                            {
                                smethod_24(str5, ref num2, hashtable_0, str4);
                            }
                            continue;
                        }
                    }
                    if ((num3 == 0xda21f5a7) && (str4 != "border-left-style"))
                    {
                    }
                }
                continue;
            Label_07DD:
                if (str4 != "height")
                {
                    continue;
                }
            Label_07EE:
                smethod_6(str5, ref num2, hashtable_0, str4, true);
                continue;
            Label_0800:
                if (num3 > 0xe61c3068)
                {
                    goto Label_0888;
                }
                switch (num3)
                {
                    case 0xe0ac0af5:
                    {
                        if (str4 == "line-height")
                        {
                            smethod_6(str5, ref num2, hashtable_0, "line-height", true);
                        }
                        continue;
                    }
                    case 0xe5eeabe3:
                        break;

                    default:
                    {
                        if ((num3 == 0xe61c3068) && (str4 != "border-top-width"))
                        {
                        }
                        continue;
                    }
                }
                if (str4 != "border-style")
                {
                    continue;
                }
            Label_0850:
                smethod_24(str5, ref num2, hashtable_0, str4);
                continue;
            Label_0888:
                if (num3 > 0xecf9338e)
                {
                    goto Label_08D2;
                }
                if (num3 == 0xea20ca31)
                {
                    goto Label_08C2;
                }
                if ((num3 != 0xecf9338e) || (str4 != "padding-bottom"))
                {
                    continue;
                }
            Label_08B3:
                smethod_6(str5, ref num2, hashtable_0, str4, true);
                continue;
            Label_08C2:
                if (str4 != "border-top-style")
                {
                }
                continue;
            Label_08D2:
                if (num3 != 0xee7dd284)
                {
                    if ((num3 == 0xff5ed19e) && (str4 == "font-size"))
                    {
                        smethod_6(str5, ref num2, hashtable_0, "font-size", true);
                    }
                }
                else if (str4 == "border-right")
                {
                }
            }
        }
    }

    private static void smethod_1(string string_19, ref int int_0)
    {
        while (int_0 < string_19.Length)
        {
            if (!char.IsWhiteSpace(string_19[int_0]))
            {
                break;
            }
            int_0++;
        }
    }

    private static void smethod_10(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_3, string_19, ref int_0, hashtable_0, "font-style");
    }

    private static void smethod_11(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_4, string_19, ref int_0, hashtable_0, "font-variant");
    }

    private static void smethod_12(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_5, string_19, ref int_0, hashtable_0, "font-weight");
    }

    private static void smethod_13(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        string str = null;
        while (int_0 < string_19.Length)
        {
            string str2 = smethod_3(string_2, string_19, ref int_0);
            if (str2 == null)
            {
                if ((int_0 < string_19.Length) && ((string_19[int_0] == '"') || (string_19[int_0] == '\'')))
                {
                    char ch = string_19[int_0];
                    int_0++;
                    int startIndex = int_0;
                    while (int_0 < string_19.Length)
                    {
                        if (string_19[int_0] == ch)
                        {
                            break;
                        }
                        int_0++;
                    }
                    str2 = "\"" + string_19.Substring(startIndex, int_0 - startIndex) + "\"";
                }
                if (str2 == null)
                {
                    int num2 = int_0;
                    while (int_0 < string_19.Length)
                    {
                        if ((string_19[int_0] == ',') || (string_19[int_0] == ';'))
                        {
                            break;
                        }
                        int_0++;
                    }
                    if (int_0 > num2)
                    {
                        str2 = string_19.Substring(num2, int_0 - num2).Trim();
                        if (str2.Length == 0)
                        {
                            str2 = null;
                        }
                    }
                }
            }
            smethod_1(string_19, ref int_0);
            if ((int_0 < string_19.Length) && (string_19[int_0] == ','))
            {
                int_0++;
            }
            if (str2 == null)
            {
                break;
            }
            if ((str == null) && (str2.Length > 0))
            {
                if ((str2[0] == '"') || (str2[0] == '\''))
                {
                    str2 = str2.Substring(1, str2.Length - 2);
                }
                str = str2;
            }
        }
        if (str != null)
        {
            hashtable_0["font-family"] = str;
        }
    }

    private static void smethod_14(string string_19, Hashtable hashtable_0)
    {
        int num = 0;
        while (num < string_19.Length)
        {
            string str = smethod_15(string_19, ref num);
            if (str != null)
            {
                hashtable_0["list-style-type"] = str;
            }
            else
            {
                string str2 = smethod_16(string_19, ref num);
                if (str2 != null)
                {
                    hashtable_0["list-style-position"] = str2;
                    continue;
                }
                string str3 = smethod_17(string_19, ref num);
                if (str3 == null)
                {
                    break;
                }
                hashtable_0["list-style-image"] = str3;
            }
        }
    }

    private static string smethod_15(string string_19, ref int int_0)
    {
        return smethod_3(string_9, string_19, ref int_0);
    }

    private static string smethod_16(string string_19, ref int int_0)
    {
        return smethod_3(string_10, string_19, ref int_0);
    }

    private static string smethod_17(string string_19, ref int int_0)
    {
        return null;
    }

    private static void smethod_18(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        for (int i = 1; i < string_11.Length; i++)
        {
            hashtable_0["text-decoration-" + string_11[i]] = "false";
        }
        while (int_0 < string_19.Length)
        {
            string str = smethod_3(string_11, string_19, ref int_0);
            if ((str == null) || (str == "none"))
            {
                break;
            }
            hashtable_0["text-decoration-" + str] = "true";
        }
    }

    private static void smethod_19(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_12, string_19, ref int_0, hashtable_0, "text-transform");
    }

    private static bool smethod_2(string string_19, string string_20, ref int int_0)
    {
        smethod_1(string_20, ref int_0);
        for (int i = 0; i < string_19.Length; i++)
        {
            if (((int_0 + i) >= string_20.Length) || (string_19[i] != string_20[int_0 + i]))
            {
                return false;
            }
        }
        if (((int_0 + string_19.Length) < string_20.Length) && char.IsLetterOrDigit(string_20[int_0 + string_19.Length]))
        {
            return false;
        }
        int_0 += string_19.Length;
        return true;
    }

    private static void smethod_20(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_13, string_19, ref int_0, hashtable_0, "text-align");
    }

    private static void smethod_21(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_14, string_19, ref int_0, hashtable_0, "vertical-align");
    }

    private static void smethod_22(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_15, string_19, ref int_0, hashtable_0, "float");
    }

    private static void smethod_23(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        smethod_4(string_16, string_19, ref int_0, hashtable_0, "clear");
    }

    private static bool smethod_24(string string_19, ref int int_0, Hashtable hashtable_0, string string_20)
    {
        string str = (string_20 == "border-color") ? smethod_7(string_19, ref int_0) : ((string_20 == "border-style") ? smethod_26(string_19, ref int_0) : smethod_5(string_19, ref int_0, true));
        if (str == null)
        {
            return false;
        }
        hashtable_0[string_20 + "-top"] = str;
        hashtable_0[string_20 + "-bottom"] = str;
        hashtable_0[string_20 + "-right"] = str;
        hashtable_0[string_20 + "-left"] = str;
        str = (string_20 == "border-color") ? smethod_7(string_19, ref int_0) : ((string_20 == "border-style") ? smethod_26(string_19, ref int_0) : smethod_5(string_19, ref int_0, true));
        if (str != null)
        {
            hashtable_0[string_20 + "-right"] = str;
            hashtable_0[string_20 + "-left"] = str;
            str = (string_20 == "border-color") ? smethod_7(string_19, ref int_0) : ((string_20 == "border-style") ? smethod_26(string_19, ref int_0) : smethod_5(string_19, ref int_0, true));
            if (str != null)
            {
                hashtable_0[string_20 + "-bottom"] = str;
                str = (string_20 == "border-color") ? smethod_7(string_19, ref int_0) : ((string_20 == "border-style") ? smethod_26(string_19, ref int_0) : smethod_5(string_19, ref int_0, true));
                if (str != null)
                {
                    hashtable_0[string_20 + "-left"] = str;
                }
            }
        }
        return true;
    }

    private static void smethod_25(string string_19, ref int int_0, Hashtable hashtable_0)
    {
        while ((smethod_24(string_19, ref int_0, hashtable_0, "border-width") || smethod_24(string_19, ref int_0, hashtable_0, "border-style")) || smethod_24(string_19, ref int_0, hashtable_0, "border-color"))
        {
        }
    }

    private static string smethod_26(string string_19, ref int int_0)
    {
        return smethod_3(string_17, string_19, ref int_0);
    }

    private static void smethod_27(string string_19, ref int int_0, Hashtable hashtable_0)
    {
    }

    private static string smethod_3(string[] string_19, string string_20, ref int int_0)
    {
        for (int i = 0; i < string_19.Length; i++)
        {
            if (smethod_2(string_19[i], string_20, ref int_0))
            {
                return string_19[i];
            }
        }
        return null;
    }

    private static void smethod_4(string[] string_19, string string_20, ref int int_0, Hashtable hashtable_0, string string_21)
    {
        string str = smethod_3(string_19, string_20, ref int_0);
        if (str != null)
        {
            hashtable_0[string_21] = str;
        }
    }

    private static string smethod_5(string string_19, ref int int_0, bool bool_0)
    {
        smethod_1(string_19, ref int_0);
        int startIndex = int_0;
        if ((int_0 < string_19.Length) && (string_19[int_0] == '-'))
        {
            int_0++;
        }
        if ((int_0 >= string_19.Length) || !char.IsDigit(string_19[int_0]))
        {
            return null;
        }
        while (int_0 < string_19.Length)
        {
            if (!char.IsDigit(string_19[int_0]) && (string_19[int_0] != '.'))
            {
                break;
            }
            int_0++;
        }
        string str = string_19.Substring(startIndex, int_0 - startIndex);
        string str2 = smethod_3(string_8, string_19, ref int_0);
        if (str2 == null)
        {
            str2 = "px";
        }
        if (bool_0 && (string_19[startIndex] == '-'))
        {
            return "0";
        }
        return (str + str2);
    }

    private static void smethod_6(string string_19, ref int int_0, Hashtable hashtable_0, string string_20, bool bool_0)
    {
        string str = smethod_5(string_19, ref int_0, bool_0);
        if (str != null)
        {
            hashtable_0[string_20] = str;
        }
    }

    private static string smethod_7(string string_19, ref int int_0)
    {
        smethod_1(string_19, ref int_0);
        string str = null;
        if (int_0 < string_19.Length)
        {
            int startIndex = int_0;
            char c = string_19[int_0];
            if (c != '#')
            {
                if (string_19.Substring(int_0, 3).ToLower() != "rbg")
                {
                    if (char.IsLetter(c))
                    {
                        str = smethod_3(string_0, string_19, ref int_0);
                        if (str == null)
                        {
                            str = smethod_3(string_1, string_19, ref int_0);
                            if (str != null)
                            {
                                str = "black";
                            }
                        }
                    }
                    return str;
                }
                while (int_0 < string_19.Length)
                {
                    if (string_19[int_0] == ')')
                    {
                        break;
                    }
                    int_0++;
                }
                if (int_0 < string_19.Length)
                {
                    int_0++;
                }
                return "gray";
            }
            int_0++;
            while (int_0 < string_19.Length)
            {
                c = char.ToUpper(string_19[int_0]);
                if ((('0' > c) || (c > '9')) && (('A' > c) || (c > 'F')))
                {
                    break;
                }
                int_0++;
            }
            if (int_0 > (startIndex + 1))
            {
                str = string_19.Substring(startIndex, int_0 - startIndex);
            }
        }
        return str;
    }

    private static void smethod_8(string string_19, ref int int_0, Hashtable hashtable_0, string string_20)
    {
        string str = smethod_7(string_19, ref int_0);
        if (str != null)
        {
            hashtable_0[string_20] = str;
        }
    }

    private static void smethod_9(string string_19, Hashtable hashtable_0)
    {
        int num = 0;
        smethod_10(string_19, ref num, hashtable_0);
        smethod_11(string_19, ref num, hashtable_0);
        smethod_12(string_19, ref num, hashtable_0);
        smethod_6(string_19, ref num, hashtable_0, "font-size", true);
        smethod_1(string_19, ref num);
        if ((num < string_19.Length) && (string_19[num] == '/'))
        {
            num++;
            smethod_6(string_19, ref num, hashtable_0, "line-height", true);
        }
        smethod_13(string_19, ref num, hashtable_0);
    }
}

