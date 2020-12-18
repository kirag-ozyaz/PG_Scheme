using System;
using System.Collections.Generic;

namespace Passport.Classes
{
	public static class Transliteration
	{
		public static string Front(string text)
		{
			return Transliteration.Front(text, TransliterationType.ISO_9_1995);
		}

		public static string Front(string text, TransliterationType type)
		{
			string text2 = text;
			foreach (KeyValuePair<string, string> keyValuePair in Transliteration.smethod_0(type))
			{
				text2 = text2.Replace(keyValuePair.Key, keyValuePair.Value);
			}
			return text2;
		}

		public static string Back(string text)
		{
			return Transliteration.Back(text, TransliterationType.ISO_9_1995);
		}

		public static string Back(string text, TransliterationType type)
		{
			string text2 = text;
			foreach (KeyValuePair<string, string> keyValuePair in Transliteration.smethod_0(type))
			{
				text2 = text2.Replace(keyValuePair.Value, keyValuePair.Key);
			}
			return text2;
		}

		private static Dictionary<string, string> smethod_0(TransliterationType transliterationType_0)
		{
			Dictionary<string, string> result = Transliteration.dictionary_2;
			if (transliterationType_0 != TransliterationType.GOST_16786_71)
			{
				if (transliterationType_0 == TransliterationType.GOST_7_79_2000)
				{
					result = Transliteration.dictionary_1;
				}
			}
			else
			{
				result = Transliteration.dictionary_0;
			}
			return result;
		}

		static Transliteration()
		{
			Transliteration.dictionary_0.Add("Є", "EH");
			Transliteration.dictionary_0.Add("І", "I");
			Transliteration.dictionary_0.Add("і", "i");
			Transliteration.dictionary_0.Add("№", "#");
			Transliteration.dictionary_0.Add("є", "eh");
			Transliteration.dictionary_0.Add("А", "A");
			Transliteration.dictionary_0.Add("Б", "B");
			Transliteration.dictionary_0.Add("В", "V");
			Transliteration.dictionary_0.Add("Г", "G");
			Transliteration.dictionary_0.Add("Д", "D");
			Transliteration.dictionary_0.Add("Е", "E");
			Transliteration.dictionary_0.Add("Ё", "JO");
			Transliteration.dictionary_0.Add("Ж", "ZH");
			Transliteration.dictionary_0.Add("З", "Z");
			Transliteration.dictionary_0.Add("И", "I");
			Transliteration.dictionary_0.Add("Й", "JJ");
			Transliteration.dictionary_0.Add("К", "K");
			Transliteration.dictionary_0.Add("Л", "L");
			Transliteration.dictionary_0.Add("М", "M");
			Transliteration.dictionary_0.Add("Н", "N");
			Transliteration.dictionary_0.Add("О", "O");
			Transliteration.dictionary_0.Add("П", "P");
			Transliteration.dictionary_0.Add("Р", "R");
			Transliteration.dictionary_0.Add("С", "S");
			Transliteration.dictionary_0.Add("Т", "T");
			Transliteration.dictionary_0.Add("У", "U");
			Transliteration.dictionary_0.Add("Ф", "F");
			Transliteration.dictionary_0.Add("Х", "KH");
			Transliteration.dictionary_0.Add("Ц", "C");
			Transliteration.dictionary_0.Add("Ч", "CH");
			Transliteration.dictionary_0.Add("Ш", "SH");
			Transliteration.dictionary_0.Add("Щ", "SHH");
			Transliteration.dictionary_0.Add("Ъ", "'");
			Transliteration.dictionary_0.Add("Ы", "Y");
			Transliteration.dictionary_0.Add("Ь", "");
			Transliteration.dictionary_0.Add("Э", "EH");
			Transliteration.dictionary_0.Add("Ю", "YU");
			Transliteration.dictionary_0.Add("Я", "YA");
			Transliteration.dictionary_0.Add("а", "a");
			Transliteration.dictionary_0.Add("б", "b");
			Transliteration.dictionary_0.Add("в", "v");
			Transliteration.dictionary_0.Add("г", "g");
			Transliteration.dictionary_0.Add("д", "d");
			Transliteration.dictionary_0.Add("е", "e");
			Transliteration.dictionary_0.Add("ё", "jo");
			Transliteration.dictionary_0.Add("ж", "zh");
			Transliteration.dictionary_0.Add("з", "z");
			Transliteration.dictionary_0.Add("и", "i");
			Transliteration.dictionary_0.Add("й", "jj");
			Transliteration.dictionary_0.Add("к", "k");
			Transliteration.dictionary_0.Add("л", "l");
			Transliteration.dictionary_0.Add("м", "m");
			Transliteration.dictionary_0.Add("н", "n");
			Transliteration.dictionary_0.Add("о", "o");
			Transliteration.dictionary_0.Add("п", "p");
			Transliteration.dictionary_0.Add("р", "r");
			Transliteration.dictionary_0.Add("с", "s");
			Transliteration.dictionary_0.Add("т", "t");
			Transliteration.dictionary_0.Add("у", "u");
			Transliteration.dictionary_0.Add("ф", "f");
			Transliteration.dictionary_0.Add("х", "kh");
			Transliteration.dictionary_0.Add("ц", "c");
			Transliteration.dictionary_0.Add("ч", "ch");
			Transliteration.dictionary_0.Add("ш", "sh");
			Transliteration.dictionary_0.Add("щ", "shh");
			Transliteration.dictionary_0.Add("ъ", "");
			Transliteration.dictionary_0.Add("ы", "y");
			Transliteration.dictionary_0.Add("ь", "");
			Transliteration.dictionary_0.Add("э", "eh");
			Transliteration.dictionary_0.Add("ю", "yu");
			Transliteration.dictionary_0.Add("я", "ya");
			Transliteration.dictionary_0.Add("«", "");
			Transliteration.dictionary_0.Add("»", "");
			Transliteration.dictionary_0.Add("—", "-");
			Transliteration.dictionary_1.Add("а", "a");
			Transliteration.dictionary_1.Add("б", "b");
			Transliteration.dictionary_1.Add("в", "v");
			Transliteration.dictionary_1.Add("г", "g");
			Transliteration.dictionary_1.Add("д", "d");
			Transliteration.dictionary_1.Add("е", "e");
			Transliteration.dictionary_1.Add("ё", "yo");
			Transliteration.dictionary_1.Add("ж", "zh");
			Transliteration.dictionary_1.Add("з", "z");
			Transliteration.dictionary_1.Add("и", "i");
			Transliteration.dictionary_1.Add("й", "j");
			Transliteration.dictionary_1.Add("к", "k");
			Transliteration.dictionary_1.Add("л", "l");
			Transliteration.dictionary_1.Add("м", "m");
			Transliteration.dictionary_1.Add("н", "n");
			Transliteration.dictionary_1.Add("о", "o");
			Transliteration.dictionary_1.Add("п", "p");
			Transliteration.dictionary_1.Add("р", "r");
			Transliteration.dictionary_1.Add("с", "s");
			Transliteration.dictionary_1.Add("т", "t");
			Transliteration.dictionary_1.Add("у", "u");
			Transliteration.dictionary_1.Add("ф", "f");
			Transliteration.dictionary_1.Add("х", "x");
			Transliteration.dictionary_1.Add("ц", "c");
			Transliteration.dictionary_1.Add("ч", "ch");
			Transliteration.dictionary_1.Add("ш", "sh");
			Transliteration.dictionary_1.Add("щ", "shh");
			Transliteration.dictionary_1.Add("ъ", "``");
			Transliteration.dictionary_1.Add("ы", "y'");
			Transliteration.dictionary_1.Add("ь", "`");
			Transliteration.dictionary_1.Add("э", "e`");
			Transliteration.dictionary_1.Add("ю", "yu");
			Transliteration.dictionary_1.Add("я", "ya");
			Transliteration.dictionary_1.Add("А", "A");
			Transliteration.dictionary_1.Add("Б", "B");
			Transliteration.dictionary_1.Add("В", "V");
			Transliteration.dictionary_1.Add("Г", "G");
			Transliteration.dictionary_1.Add("Д", "D");
			Transliteration.dictionary_1.Add("Е", "E");
			Transliteration.dictionary_1.Add("Ё", "Yo");
			Transliteration.dictionary_1.Add("Ж", "Zh");
			Transliteration.dictionary_1.Add("З", "Z");
			Transliteration.dictionary_1.Add("И", "I");
			Transliteration.dictionary_1.Add("Й", "J");
			Transliteration.dictionary_1.Add("К", "K");
			Transliteration.dictionary_1.Add("Л", "L");
			Transliteration.dictionary_1.Add("М", "M");
			Transliteration.dictionary_1.Add("Н", "N");
			Transliteration.dictionary_1.Add("О", "O");
			Transliteration.dictionary_1.Add("П", "P");
			Transliteration.dictionary_1.Add("Р", "R");
			Transliteration.dictionary_1.Add("С", "S");
			Transliteration.dictionary_1.Add("Т", "T");
			Transliteration.dictionary_1.Add("У", "U");
			Transliteration.dictionary_1.Add("Ф", "F");
			Transliteration.dictionary_1.Add("Х", "X");
			Transliteration.dictionary_1.Add("Ц", "C");
			Transliteration.dictionary_1.Add("Ч", "Ch");
			Transliteration.dictionary_1.Add("Ш", "Sh");
			Transliteration.dictionary_1.Add("Щ", "Shh");
			Transliteration.dictionary_1.Add("Ъ", "``");
			Transliteration.dictionary_1.Add("Ы", "y'");
			Transliteration.dictionary_1.Add("Ь", "`");
			Transliteration.dictionary_1.Add("Э", "e`");
			Transliteration.dictionary_1.Add("Ю", "Yu");
			Transliteration.dictionary_1.Add("Я", "Ya");
			Transliteration.dictionary_1.Add("'", "'");
			Transliteration.dictionary_2.Add("Є", "YE");
			Transliteration.dictionary_2.Add("І", "I");
			Transliteration.dictionary_2.Add("Ѓ", "G");
			Transliteration.dictionary_2.Add("і", "i");
			Transliteration.dictionary_2.Add("№", "#");
			Transliteration.dictionary_2.Add("є", "ye");
			Transliteration.dictionary_2.Add("ѓ", "g");
			Transliteration.dictionary_2.Add("А", "A");
			Transliteration.dictionary_2.Add("Б", "B");
			Transliteration.dictionary_2.Add("В", "V");
			Transliteration.dictionary_2.Add("Г", "G");
			Transliteration.dictionary_2.Add("Д", "D");
			Transliteration.dictionary_2.Add("Е", "E");
			Transliteration.dictionary_2.Add("Ё", "YO");
			Transliteration.dictionary_2.Add("Ж", "ZH");
			Transliteration.dictionary_2.Add("З", "Z");
			Transliteration.dictionary_2.Add("И", "I");
			Transliteration.dictionary_2.Add("Й", "J");
			Transliteration.dictionary_2.Add("К", "K");
			Transliteration.dictionary_2.Add("Л", "L");
			Transliteration.dictionary_2.Add("М", "M");
			Transliteration.dictionary_2.Add("Н", "N");
			Transliteration.dictionary_2.Add("О", "O");
			Transliteration.dictionary_2.Add("П", "P");
			Transliteration.dictionary_2.Add("Р", "R");
			Transliteration.dictionary_2.Add("С", "S");
			Transliteration.dictionary_2.Add("Т", "T");
			Transliteration.dictionary_2.Add("У", "U");
			Transliteration.dictionary_2.Add("Ф", "F");
			Transliteration.dictionary_2.Add("Х", "X");
			Transliteration.dictionary_2.Add("Ц", "C");
			Transliteration.dictionary_2.Add("Ч", "CH");
			Transliteration.dictionary_2.Add("Ш", "SH");
			Transliteration.dictionary_2.Add("Щ", "SHH");
			Transliteration.dictionary_2.Add("Ъ", "'");
			Transliteration.dictionary_2.Add("Ы", "Y");
			Transliteration.dictionary_2.Add("Ь", "");
			Transliteration.dictionary_2.Add("Э", "E");
			Transliteration.dictionary_2.Add("Ю", "YU");
			Transliteration.dictionary_2.Add("Я", "YA");
			Transliteration.dictionary_2.Add("а", "a");
			Transliteration.dictionary_2.Add("б", "b");
			Transliteration.dictionary_2.Add("в", "v");
			Transliteration.dictionary_2.Add("г", "g");
			Transliteration.dictionary_2.Add("д", "d");
			Transliteration.dictionary_2.Add("е", "e");
			Transliteration.dictionary_2.Add("ё", "yo");
			Transliteration.dictionary_2.Add("ж", "zh");
			Transliteration.dictionary_2.Add("з", "z");
			Transliteration.dictionary_2.Add("и", "i");
			Transliteration.dictionary_2.Add("й", "j");
			Transliteration.dictionary_2.Add("к", "k");
			Transliteration.dictionary_2.Add("л", "l");
			Transliteration.dictionary_2.Add("м", "m");
			Transliteration.dictionary_2.Add("н", "n");
			Transliteration.dictionary_2.Add("о", "o");
			Transliteration.dictionary_2.Add("п", "p");
			Transliteration.dictionary_2.Add("р", "r");
			Transliteration.dictionary_2.Add("с", "s");
			Transliteration.dictionary_2.Add("т", "t");
			Transliteration.dictionary_2.Add("у", "u");
			Transliteration.dictionary_2.Add("ф", "f");
			Transliteration.dictionary_2.Add("х", "x");
			Transliteration.dictionary_2.Add("ц", "c");
			Transliteration.dictionary_2.Add("ч", "ch");
			Transliteration.dictionary_2.Add("ш", "sh");
			Transliteration.dictionary_2.Add("щ", "shh");
			Transliteration.dictionary_2.Add("ъ", "");
			Transliteration.dictionary_2.Add("ы", "y");
			Transliteration.dictionary_2.Add("ь", "");
			Transliteration.dictionary_2.Add("э", "e");
			Transliteration.dictionary_2.Add("ю", "yu");
			Transliteration.dictionary_2.Add("я", "ya");
			Transliteration.dictionary_2.Add("«", "");
			Transliteration.dictionary_2.Add("»", "");
			Transliteration.dictionary_2.Add("—", "-");
		}

		private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

		private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

		private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();
	}
}
