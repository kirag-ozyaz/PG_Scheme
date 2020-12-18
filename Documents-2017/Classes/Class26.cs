using System;
using System.Collections;

internal class Class26
{
    private static ArrayList arrayList_0;
    private static ArrayList arrayList_1;
    private static ArrayList arrayList_10;
    private static ArrayList arrayList_11;
    private static ArrayList arrayList_12;
    private static ArrayList arrayList_13;
    private static ArrayList arrayList_14;
    private static ArrayList arrayList_2;
    private static ArrayList arrayList_3;
    private static ArrayList arrayList_4;
    private static ArrayList arrayList_5;
    private static ArrayList arrayList_6;
    private static ArrayList arrayList_7;
    private static ArrayList arrayList_8;
    private static ArrayList arrayList_9;
    private static Hashtable hashtable_0;

    static Class26()
    {
        smethod_8();
        smethod_9();
        smethod_11();
        smethod_10();
        smethod_12();
        smethod_13();
        smethod_14();
    }

    internal static bool smethod_0(string string_0)
    {
        return arrayList_3.Contains(string_0.ToLower());
    }

    internal static bool smethod_1(string string_0)
    {
        return arrayList_1.Contains(string_0);
    }

    private static void smethod_10()
    {
        arrayList_3 = new ArrayList();
        arrayList_3.Add("area");
        arrayList_3.Add("base");
        arrayList_3.Add("basefont");
        arrayList_3.Add("br");
        arrayList_3.Add("col");
        arrayList_3.Add("frame");
        arrayList_3.Add("hr");
        arrayList_3.Add("img");
        arrayList_3.Add("input");
        arrayList_3.Add("isindex");
        arrayList_3.Add("link");
        arrayList_3.Add("meta");
        arrayList_3.Add("param");
    }

    private static void smethod_11()
    {
        arrayList_2 = new ArrayList();
        arrayList_2.Add("applet");
        arrayList_2.Add("base");
        arrayList_2.Add("basefont");
        arrayList_2.Add("colgroup");
        arrayList_2.Add("fieldset");
        arrayList_2.Add("frameset");
        arrayList_2.Add("head");
        arrayList_2.Add("iframe");
        arrayList_2.Add("map");
        arrayList_2.Add("noframes");
        arrayList_2.Add("noscript");
        arrayList_2.Add("object");
        arrayList_2.Add("optgroup");
        arrayList_2.Add("option");
        arrayList_2.Add("script");
        arrayList_2.Add("select");
        arrayList_2.Add("style");
        arrayList_2.Add("title");
    }

    private static void smethod_12()
    {
        arrayList_4 = new ArrayList();
        arrayList_4.Add("body");
        arrayList_4.Add("colgroup");
        arrayList_4.Add("dd");
        arrayList_4.Add("dt");
        arrayList_4.Add("head");
        arrayList_4.Add("html");
        arrayList_4.Add("li");
        arrayList_4.Add("p");
        arrayList_4.Add("tbody");
        arrayList_4.Add("td");
        arrayList_4.Add("tfoot");
        arrayList_4.Add("thead");
        arrayList_4.Add("th");
        arrayList_4.Add("tr");
    }

    private static void smethod_13()
    {
        arrayList_5 = new ArrayList();
        arrayList_5.Add("colgroup");
        arrayList_5.Add("tr");
        arrayList_5.Add("thead");
        arrayList_5.Add("tfoot");
        arrayList_5.Add("tbody");
        arrayList_6 = new ArrayList();
        arrayList_6.Add("dd");
        arrayList_6.Add("dt");
        arrayList_7 = new ArrayList();
        arrayList_6.Add("dd");
        arrayList_6.Add("dt");
        arrayList_8 = new ArrayList();
        arrayList_8.Add("li");
        arrayList_9 = new ArrayList();
        arrayList_9.Add("tbody");
        arrayList_9.Add("thead");
        arrayList_9.Add("tfoot");
        arrayList_14 = new ArrayList();
        arrayList_14.Add("thead");
        arrayList_14.Add("tfoot");
        arrayList_14.Add("tbody");
        arrayList_14.Add("tr");
        arrayList_10 = new ArrayList();
        arrayList_10.Add("td");
        arrayList_10.Add("th");
        arrayList_10.Add("tr");
        arrayList_10.Add("tbody");
        arrayList_10.Add("tfoot");
        arrayList_10.Add("thead");
        arrayList_13 = new ArrayList();
        arrayList_13.Add("td");
        arrayList_13.Add("th");
        arrayList_13.Add("tr");
        arrayList_13.Add("tbody");
        arrayList_13.Add("tfoot");
        arrayList_13.Add("thead");
        arrayList_12 = new ArrayList();
        arrayList_12.Add("tbody");
        arrayList_12.Add("tfoot");
        arrayList_11 = new ArrayList();
        arrayList_11.Add("tbody");
        arrayList_11.Add("thead");
    }

    private static void smethod_14()
    {
        hashtable_0 = new Hashtable();
        hashtable_0["Aacute"] = '\x00c1';
        hashtable_0["aacute"] = '\x00e1';
        hashtable_0["Acirc"] = '\x00c2';
        hashtable_0["acirc"] = '\x00e2';
        hashtable_0["acute"] = '\x00b4';
        hashtable_0["AElig"] = '\x00c6';
        hashtable_0["aelig"] = '\x00e6';
        hashtable_0["Agrave"] = '\x00c0';
        hashtable_0["agrave"] = '\x00e0';
        hashtable_0["alefsym"] = 'ℵ';
        hashtable_0["Alpha"] = 'Α';
        hashtable_0["alpha"] = 'α';
        hashtable_0["amp"] = '&';
        hashtable_0["and"] = '∧';
        hashtable_0["ang"] = '∠';
        hashtable_0["Aring"] = '\x00c5';
        hashtable_0["aring"] = '\x00e5';
        hashtable_0["asymp"] = '≈';
        hashtable_0["Atilde"] = '\x00c3';
        hashtable_0["atilde"] = '\x00e3';
        hashtable_0["Auml"] = '\x00c4';
        hashtable_0["auml"] = '\x00e4';
        hashtable_0["bdquo"] = '„';
        hashtable_0["Beta"] = 'Β';
        hashtable_0["beta"] = 'β';
        hashtable_0["brvbar"] = '\x00a6';
        hashtable_0["bull"] = '•';
        hashtable_0["cap"] = '∩';
        hashtable_0["Ccedil"] = '\x00c7';
        hashtable_0["ccedil"] = '\x00e7';
        hashtable_0["cent"] = '\x00a2';
        hashtable_0["Chi"] = 'Χ';
        hashtable_0["chi"] = 'χ';
        hashtable_0["circ"] = 'ˆ';
        hashtable_0["clubs"] = '♣';
        hashtable_0["cong"] = '≅';
        hashtable_0["copy"] = '\x00a9';
        hashtable_0["crarr"] = '↵';
        hashtable_0["cup"] = '∪';
        hashtable_0["curren"] = '\x00a4';
        hashtable_0["dagger"] = '†';
        hashtable_0["Dagger"] = '‡';
        hashtable_0["darr"] = '↓';
        hashtable_0["dArr"] = '⇓';
        hashtable_0["deg"] = '\x00b0';
        hashtable_0["Delta"] = 'Δ';
        hashtable_0["delta"] = 'δ';
        hashtable_0["diams"] = '♦';
        hashtable_0["divide"] = '\x00f7';
        hashtable_0["Eacute"] = '\x00c9';
        hashtable_0["eacute"] = '\x00e9';
        hashtable_0["Ecirc"] = '\x00ca';
        hashtable_0["ecirc"] = '\x00ea';
        hashtable_0["Egrave"] = '\x00c8';
        hashtable_0["egrave"] = '\x00e8';
        hashtable_0["empty"] = '∅';
        hashtable_0["emsp"] = ' ';
        hashtable_0["ensp"] = ' ';
        hashtable_0["Epsilon"] = 'Ε';
        hashtable_0["epsilon"] = 'ε';
        hashtable_0["equiv"] = '≡';
        hashtable_0["Eta"] = 'Η';
        hashtable_0["eta"] = 'η';
        hashtable_0["ETH"] = '\x00d0';
        hashtable_0["eth"] = '\x00f0';
        hashtable_0["Euml"] = '\x00cb';
        hashtable_0["euml"] = '\x00eb';
        hashtable_0["euro"] = '€';
        hashtable_0["exist"] = '∃';
        hashtable_0["fnof"] = 'ƒ';
        hashtable_0["forall"] = '∀';
        hashtable_0["frac12"] = '\x00bd';
        hashtable_0["frac14"] = '\x00bc';
        hashtable_0["frac34"] = '\x00be';
        hashtable_0["frasl"] = '⁄';
        hashtable_0["Gamma"] = 'Γ';
        hashtable_0["gamma"] = 'γ';
        hashtable_0["ge"] = '≥';
        hashtable_0["gt"] = '>';
        hashtable_0["harr"] = '↔';
        hashtable_0["hArr"] = '⇔';
        hashtable_0["hearts"] = '♥';
        hashtable_0["hellip"] = '…';
        hashtable_0["Iacute"] = '\x00cd';
        hashtable_0["iacute"] = '\x00ed';
        hashtable_0["Icirc"] = '\x00ce';
        hashtable_0["icirc"] = '\x00ee';
        hashtable_0["iexcl"] = '\x00a1';
        hashtable_0["Igrave"] = '\x00cc';
        hashtable_0["igrave"] = '\x00ec';
        hashtable_0["image"] = 'ℑ';
        hashtable_0["infin"] = '∞';
        hashtable_0["int"] = '∫';
        hashtable_0["Iota"] = 'Ι';
        hashtable_0["iota"] = 'ι';
        hashtable_0["iquest"] = '\x00bf';
        hashtable_0["isin"] = '∈';
        hashtable_0["Iuml"] = '\x00cf';
        hashtable_0["iuml"] = '\x00ef';
        hashtable_0["Kappa"] = 'Κ';
        hashtable_0["kappa"] = 'κ';
        hashtable_0["Lambda"] = 'Λ';
        hashtable_0["lambda"] = 'λ';
        hashtable_0["lang"] = '〈';
        hashtable_0["laquo"] = '\x00ab';
        hashtable_0["larr"] = '←';
        hashtable_0["lArr"] = '⇐';
        hashtable_0["lceil"] = '⌈';
        hashtable_0["ldquo"] = '“';
        hashtable_0["le"] = '≤';
        hashtable_0["lfloor"] = '⌊';
        hashtable_0["lowast"] = '∗';
        hashtable_0["loz"] = '◊';
        hashtable_0["lrm"] = '‎';
        hashtable_0["lsaquo"] = '‹';
        hashtable_0["lsquo"] = '‘';
        hashtable_0["lt"] = '<';
        hashtable_0["macr"] = '\x00af';
        hashtable_0["mdash"] = '—';
        hashtable_0["micro"] = '\x00b5';
        hashtable_0["middot"] = '\x00b7';
        hashtable_0["minus"] = '−';
        hashtable_0["Mu"] = 'Μ';
        hashtable_0["mu"] = 'μ';
        hashtable_0["nabla"] = '∇';
        hashtable_0["nbsp"] = '\x00a0';
        hashtable_0["ndash"] = '–';
        hashtable_0["ne"] = '≠';
        hashtable_0["ni"] = '∋';
        hashtable_0["not"] = '\x00ac';
        hashtable_0["notin"] = '∉';
        hashtable_0["nsub"] = '⊄';
        hashtable_0["Ntilde"] = '\x00d1';
        hashtable_0["ntilde"] = '\x00f1';
        hashtable_0["Nu"] = 'Ν';
        hashtable_0["nu"] = 'ν';
        hashtable_0["Oacute"] = '\x00d3';
        hashtable_0["ocirc"] = '\x00f4';
        hashtable_0["OElig"] = 'Œ';
        hashtable_0["oelig"] = 'œ';
        hashtable_0["Ograve"] = '\x00d2';
        hashtable_0["ograve"] = '\x00f2';
        hashtable_0["oline"] = '‾';
        hashtable_0["Omega"] = 'Ω';
        hashtable_0["omega"] = 'ω';
        hashtable_0["Omicron"] = 'Ο';
        hashtable_0["omicron"] = 'ο';
        hashtable_0["oplus"] = '⊕';
        hashtable_0["or"] = '∨';
        hashtable_0["ordf"] = '\x00aa';
        hashtable_0["ordm"] = '\x00ba';
        hashtable_0["Oslash"] = '\x00d8';
        hashtable_0["oslash"] = '\x00f8';
        hashtable_0["Otilde"] = '\x00d5';
        hashtable_0["otilde"] = '\x00f5';
        hashtable_0["otimes"] = '⊗';
        hashtable_0["Ouml"] = '\x00d6';
        hashtable_0["ouml"] = '\x00f6';
        hashtable_0["para"] = '\x00b6';
        hashtable_0["part"] = '∂';
        hashtable_0["permil"] = '‰';
        hashtable_0["perp"] = '⊥';
        hashtable_0["Phi"] = 'Φ';
        hashtable_0["phi"] = 'φ';
        hashtable_0["pi"] = 'π';
        hashtable_0["piv"] = 'ϖ';
        hashtable_0["plusmn"] = '\x00b1';
        hashtable_0["pound"] = '\x00a3';
        hashtable_0["prime"] = '′';
        hashtable_0["Prime"] = '″';
        hashtable_0["prod"] = '∏';
        hashtable_0["prop"] = '∝';
        hashtable_0["Psi"] = 'Ψ';
        hashtable_0["psi"] = 'ψ';
        hashtable_0["quot"] = '"';
        hashtable_0["radic"] = '√';
        hashtable_0["rang"] = '〉';
        hashtable_0["raquo"] = '\x00bb';
        hashtable_0["rarr"] = '→';
        hashtable_0["rArr"] = '⇒';
        hashtable_0["rceil"] = '⌉';
        hashtable_0["rdquo"] = '”';
        hashtable_0["real"] = 'ℜ';
        hashtable_0["reg"] = '\x00ae';
        hashtable_0["rfloor"] = '⌋';
        hashtable_0["Rho"] = 'Ρ';
        hashtable_0["rho"] = 'ρ';
        hashtable_0["rlm"] = '‏';
        hashtable_0["rsaquo"] = '›';
        hashtable_0["rsquo"] = '’';
        hashtable_0["sbquo"] = '‚';
        hashtable_0["Scaron"] = 'Š';
        hashtable_0["scaron"] = 'š';
        hashtable_0["sdot"] = '⋅';
        hashtable_0["sect"] = '\x00a7';
        hashtable_0["shy"] = '\x00ad';
        hashtable_0["Sigma"] = 'Σ';
        hashtable_0["sigma"] = 'σ';
        hashtable_0["sigmaf"] = 'ς';
        hashtable_0["sim"] = '∼';
        hashtable_0["spades"] = '♠';
        hashtable_0["sub"] = '⊂';
        hashtable_0["sube"] = '⊆';
        hashtable_0["sum"] = '∑';
        hashtable_0["sup"] = '⊃';
        hashtable_0["sup1"] = '\x00b9';
        hashtable_0["sup2"] = '\x00b2';
        hashtable_0["sup3"] = '\x00b3';
        hashtable_0["supe"] = '⊇';
        hashtable_0["szlig"] = '\x00df';
        hashtable_0["Tau"] = 'Τ';
        hashtable_0["tau"] = 'τ';
        hashtable_0["there4"] = '∴';
        hashtable_0["Theta"] = 'Θ';
        hashtable_0["theta"] = 'θ';
        hashtable_0["thetasym"] = 'ϑ';
        hashtable_0["thinsp"] = ' ';
        hashtable_0["THORN"] = '\x00de';
        hashtable_0["thorn"] = '\x00fe';
        hashtable_0["tilde"] = '˜';
        hashtable_0["times"] = '\x00d7';
        hashtable_0["trade"] = '™';
        hashtable_0["Uacute"] = '\x00da';
        hashtable_0["uacute"] = '\x00fa';
        hashtable_0["uarr"] = '↑';
        hashtable_0["uArr"] = '⇑';
        hashtable_0["Ucirc"] = '\x00db';
        hashtable_0["ucirc"] = '\x00fb';
        hashtable_0["Ugrave"] = '\x00d9';
        hashtable_0["ugrave"] = '\x00f9';
        hashtable_0["uml"] = '\x00a8';
        hashtable_0["upsih"] = 'ϒ';
        hashtable_0["Upsilon"] = 'Υ';
        hashtable_0["upsilon"] = 'υ';
        hashtable_0["Uuml"] = '\x00dc';
        hashtable_0["uuml"] = '\x00fc';
        hashtable_0["weierp"] = '℘';
        hashtable_0["Xi"] = 'Ξ';
        hashtable_0["xi"] = 'ξ';
        hashtable_0["Yacute"] = '\x00dd';
        hashtable_0["yacute"] = '\x00fd';
        hashtable_0["yen"] = '\x00a5';
        hashtable_0["Yuml"] = 'Ÿ';
        hashtable_0["yuml"] = '\x00ff';
        hashtable_0["Zeta"] = 'Ζ';
        hashtable_0["zeta"] = 'ζ';
        hashtable_0["zwj"] = '‍';
        hashtable_0["zwnj"] = '‌';
    }

    internal static bool smethod_2(string string_0)
    {
        return arrayList_0.Contains(string_0);
    }

    internal static bool smethod_3(string string_0)
    {
        return arrayList_2.Contains(string_0);
    }

    internal static bool smethod_4(string string_0)
    {
        return arrayList_4.Contains(string_0.ToLower());
    }

    internal static bool smethod_5(string string_0, string string_1)
    {
        uint num = Class227.smethod_0(string_0);
        if (num <= 0x47455003)
        {
            if (num > 0x3d454045)
            {
                switch (num)
                {
                    case 0x4031bd46:
                        if (string_0 != "li")
                        {
                            goto Label_01C3;
                        }
                        return arrayList_8.Contains(string_1);

                    case 0x41454691:
                        if (string_0 != "th")
                        {
                            goto Label_01C3;
                        }
                        return arrayList_13.Contains(string_1);
                }
                if ((num == 0x47455003) && (string_0 == "tr"))
                {
                    return arrayList_14.Contains(string_1);
                }
            }
            else if (num == 0x8f58208)
            {
                if (string_0 == "colgroup")
                {
                    return (arrayList_5.Contains(string_1) && smethod_1(string_1));
                }
            }
            else if ((num == 0x3d454045) && (string_0 == "td"))
            {
                return arrayList_10.Contains(string_1);
            }
        }
        else if (num <= 0x8b7cd36b)
        {
            switch (num)
            {
                case 0x4d1cb705:
                    if (string_0 != "dt")
                    {
                        goto Label_01C3;
                    }
                    return (arrayList_7.Contains(string_1) && smethod_1(string_1));

                case 0x5d1cd035:
                    if (string_0 != "dd")
                    {
                        goto Label_01C3;
                    }
                    return (arrayList_6.Contains(string_1) && smethod_1(string_1));
            }
            if ((num == 0x8b7cd36b) && (string_0 == "tbody"))
            {
                return arrayList_9.Contains(string_1);
            }
        }
        else
        {
            switch (num)
            {
                case 0xaa108e99:
                    if (string_0 == "thead")
                    {
                        return arrayList_12.Contains(string_1);
                    }
                    goto Label_01C3;

                case 0xbfb4741b:
                    if (string_0 != "tfoot")
                    {
                        goto Label_01C3;
                    }
                    return arrayList_11.Contains(string_1);
            }
            if ((num == 0xf50c43ef) && (string_0 == "p"))
            {
                return smethod_1(string_1);
            }
        }
    Label_01C3:
        return false;
    }

    internal static bool smethod_6(string string_0)
    {
        return hashtable_0.Contains(string_0);
    }

    internal static char smethod_7(string string_0)
    {
        if (hashtable_0.Contains(string_0))
        {
            return (char) hashtable_0[string_0];
        }
        return '\0';
    }

    private static void smethod_8()
    {
        arrayList_0 = new ArrayList();
        arrayList_0.Add("a");
        arrayList_0.Add("abbr");
        arrayList_0.Add("acronym");
        arrayList_0.Add("address");
        arrayList_0.Add("b");
        arrayList_0.Add("bdo");
        arrayList_0.Add("big");
        arrayList_0.Add("button");
        arrayList_0.Add("code");
        arrayList_0.Add("del");
        arrayList_0.Add("dfn");
        arrayList_0.Add("em");
        arrayList_0.Add("font");
        arrayList_0.Add("i");
        arrayList_0.Add("ins");
        arrayList_0.Add("kbd");
        arrayList_0.Add("label");
        arrayList_0.Add("legend");
        arrayList_0.Add("q");
        arrayList_0.Add("s");
        arrayList_0.Add("samp");
        arrayList_0.Add("small");
        arrayList_0.Add("span");
        arrayList_0.Add("strike");
        arrayList_0.Add("strong");
        arrayList_0.Add("sub");
        arrayList_0.Add("sup");
        arrayList_0.Add("u");
        arrayList_0.Add("var");
    }

    private static void smethod_9()
    {
        arrayList_1 = new ArrayList();
        arrayList_1.Add("blockquote");
        arrayList_1.Add("body");
        arrayList_1.Add("caption");
        arrayList_1.Add("center");
        arrayList_1.Add("cite");
        arrayList_1.Add("dd");
        arrayList_1.Add("dir");
        arrayList_1.Add("div");
        arrayList_1.Add("dl");
        arrayList_1.Add("dt");
        arrayList_1.Add("form");
        arrayList_1.Add("h1");
        arrayList_1.Add("h2");
        arrayList_1.Add("h3");
        arrayList_1.Add("h4");
        arrayList_1.Add("h5");
        arrayList_1.Add("h6");
        arrayList_1.Add("html");
        arrayList_1.Add("li");
        arrayList_1.Add("menu");
        arrayList_1.Add("ol");
        arrayList_1.Add("p");
        arrayList_1.Add("pre");
        arrayList_1.Add("table");
        arrayList_1.Add("tbody");
        arrayList_1.Add("td");
        arrayList_1.Add("textarea");
        arrayList_1.Add("tfoot");
        arrayList_1.Add("th");
        arrayList_1.Add("thead");
        arrayList_1.Add("tr");
        arrayList_1.Add("tt");
        arrayList_1.Add("ul");
    }
}

