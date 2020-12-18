// криптозащита
// RCA
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace EIS.Forms
{
    // gyTR2TVVrbCHvCVDmc = Class8
    internal class clRSACrypto
    {
        static clRSACrypto()
        {
            try
            {
                RSACryptoServiceProvider.UseMachineKeyStore = true;
            }
            catch
            {
            }
                    //private static Assembly Field3 = Type.GetTypeFromHandle(Class12.Method6(33554461)).Assembly;
                    // private static Assembly Field3 = typeof(clRSACrypto).Assembly;
        Field3 = System.Reflection.Assembly.GetExecutingAssembly();
    }
        private void Method52()
        {
        }
        internal static byte[] Method51(byte[] array)
        {
            uint[] array2 = new uint[16];
            int num = 448 - array.Length * 8 % 512;
            uint num2 = (uint)((num + 512) % 512);
            if (num2 == 0u)
            {
                num2 = 512u;
            }
            uint num3 = (uint)((long)array.Length + (long)((ulong)(num2 / 8u)) + 8L);
            ulong num4 = (ulong)((long)array.Length * 8L);
            byte[] array3 = new byte[num3];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i];
            }
            byte[] expr_77_cp_0 = array3;
            int expr_77_cp_1 = array.Length;
            expr_77_cp_0[expr_77_cp_1] |= 128;
            for (int j = 8; j > 0; j--)
            {
                array3[(int)(checked((IntPtr)(unchecked((ulong)num3 - (ulong)((long)j)))))] = (byte)(num4 >> (8 - j) * 8 & 255uL);
            }
            uint num5 = (uint)(array3.Length * 8 / 32);
            uint num6 = 1732584193u;
            uint num7 = 4023233417u;
            uint num8 = 2562383102u;
            uint num9 = 271733878u;
            for (uint num10 = 0u; num10 < num5 / 16u; num10 += 1u)
            {
                uint num11 = num10 << 6;
                for (uint num12 = 0u; num12 < 61u; num12 += 4u)
                {
                    array2[(int)((UIntPtr)(num12 >> 2))] = (uint)((int)array3[(int)((UIntPtr)(num11 + (num12 + 3u)))] << 24 | (int)array3[(int)((UIntPtr)(num11 + (num12 + 2u)))] << 16 | (int)array3[(int)((UIntPtr)(num11 + (num12 + 1u)))] << 8 | (int)array3[(int)((UIntPtr)(num11 + num12))]);
                }
                uint num13 = num6;
                uint num14 = num7;
                uint num15 = num8;
                uint num16 = num9;
                clRSACrypto.Method50(ref num6, num7, num8, num9, 0u, 7, 1u, array2);
                clRSACrypto.Method50(ref num9, num6, num7, num8, 1u, 12, 2u, array2);
                clRSACrypto.Method50(ref num8, num9, num6, num7, 2u, 17, 3u, array2);
                clRSACrypto.Method50(ref num7, num8, num9, num6, 3u, 22, 4u, array2);
                clRSACrypto.Method50(ref num6, num7, num8, num9, 4u, 7, 5u, array2);
                clRSACrypto.Method50(ref num9, num6, num7, num8, 5u, 12, 6u, array2);
                clRSACrypto.Method50(ref num8, num9, num6, num7, 6u, 17, 7u, array2);
                clRSACrypto.Method50(ref num7, num8, num9, num6, 7u, 22, 8u, array2);
                clRSACrypto.Method50(ref num6, num7, num8, num9, 8u, 7, 9u, array2);
                clRSACrypto.Method50(ref num9, num6, num7, num8, 9u, 12, 10u, array2);
                clRSACrypto.Method50(ref num8, num9, num6, num7, 10u, 17, 11u, array2);
                clRSACrypto.Method50(ref num7, num8, num9, num6, 11u, 22, 12u, array2);
                clRSACrypto.Method50(ref num6, num7, num8, num9, 12u, 7, 13u, array2);
                clRSACrypto.Method50(ref num9, num6, num7, num8, 13u, 12, 14u, array2);
                clRSACrypto.Method50(ref num8, num9, num6, num7, 14u, 17, 15u, array2);
                clRSACrypto.Method50(ref num7, num8, num9, num6, 15u, 22, 16u, array2);
                clRSACrypto.Method49(ref num6, num7, num8, num9, 1u, 5, 17u, array2);
                clRSACrypto.Method49(ref num9, num6, num7, num8, 6u, 9, 18u, array2);
                clRSACrypto.Method49(ref num8, num9, num6, num7, 11u, 14, 19u, array2);
                clRSACrypto.Method49(ref num7, num8, num9, num6, 0u, 20, 20u, array2);
                clRSACrypto.Method49(ref num6, num7, num8, num9, 5u, 5, 21u, array2);
                clRSACrypto.Method49(ref num9, num6, num7, num8, 10u, 9, 22u, array2);
                clRSACrypto.Method49(ref num8, num9, num6, num7, 15u, 14, 23u, array2);
                clRSACrypto.Method49(ref num7, num8, num9, num6, 4u, 20, 24u, array2);
                clRSACrypto.Method49(ref num6, num7, num8, num9, 9u, 5, 25u, array2);
                clRSACrypto.Method49(ref num9, num6, num7, num8, 14u, 9, 26u, array2);
                clRSACrypto.Method49(ref num8, num9, num6, num7, 3u, 14, 27u, array2);
                clRSACrypto.Method49(ref num7, num8, num9, num6, 8u, 20, 28u, array2);
                clRSACrypto.Method49(ref num6, num7, num8, num9, 13u, 5, 29u, array2);
                clRSACrypto.Method49(ref num9, num6, num7, num8, 2u, 9, 30u, array2);
                clRSACrypto.Method49(ref num8, num9, num6, num7, 7u, 14, 31u, array2);
                clRSACrypto.Method49(ref num7, num8, num9, num6, 12u, 20, 32u, array2);
                clRSACrypto.Method48(ref num6, num7, num8, num9, 5u, 4, 33u, array2);
                clRSACrypto.Method48(ref num9, num6, num7, num8, 8u, 11, 34u, array2);
                clRSACrypto.Method48(ref num8, num9, num6, num7, 11u, 16, 35u, array2);
                clRSACrypto.Method48(ref num7, num8, num9, num6, 14u, 23, 36u, array2);
                clRSACrypto.Method48(ref num6, num7, num8, num9, 1u, 4, 37u, array2);
                clRSACrypto.Method48(ref num9, num6, num7, num8, 4u, 11, 38u, array2);
                clRSACrypto.Method48(ref num8, num9, num6, num7, 7u, 16, 39u, array2);
                clRSACrypto.Method48(ref num7, num8, num9, num6, 10u, 23, 40u, array2);
                clRSACrypto.Method48(ref num6, num7, num8, num9, 13u, 4, 41u, array2);
                clRSACrypto.Method48(ref num9, num6, num7, num8, 0u, 11, 42u, array2);
                clRSACrypto.Method48(ref num8, num9, num6, num7, 3u, 16, 43u, array2);
                clRSACrypto.Method48(ref num7, num8, num9, num6, 6u, 23, 44u, array2);
                clRSACrypto.Method48(ref num6, num7, num8, num9, 9u, 4, 45u, array2);
                clRSACrypto.Method48(ref num9, num6, num7, num8, 12u, 11, 46u, array2);
                clRSACrypto.Method48(ref num8, num9, num6, num7, 15u, 16, 47u, array2);
                clRSACrypto.Method48(ref num7, num8, num9, num6, 2u, 23, 48u, array2);
                clRSACrypto.Method47(ref num6, num7, num8, num9, 0u, 6, 49u, array2);
                clRSACrypto.Method47(ref num9, num6, num7, num8, 7u, 10, 50u, array2);
                clRSACrypto.Method47(ref num8, num9, num6, num7, 14u, 15, 51u, array2);
                clRSACrypto.Method47(ref num7, num8, num9, num6, 5u, 21, 52u, array2);
                clRSACrypto.Method47(ref num6, num7, num8, num9, 12u, 6, 53u, array2);
                clRSACrypto.Method47(ref num9, num6, num7, num8, 3u, 10, 54u, array2);
                clRSACrypto.Method47(ref num8, num9, num6, num7, 10u, 15, 55u, array2);
                clRSACrypto.Method47(ref num7, num8, num9, num6, 1u, 21, 56u, array2);
                clRSACrypto.Method47(ref num6, num7, num8, num9, 8u, 6, 57u, array2);
                clRSACrypto.Method47(ref num9, num6, num7, num8, 15u, 10, 58u, array2);
                clRSACrypto.Method47(ref num8, num9, num6, num7, 6u, 15, 59u, array2);
                clRSACrypto.Method47(ref num7, num8, num9, num6, 13u, 21, 60u, array2);
                clRSACrypto.Method47(ref num6, num7, num8, num9, 4u, 6, 61u, array2);
                clRSACrypto.Method47(ref num9, num6, num7, num8, 11u, 10, 62u, array2);
                clRSACrypto.Method47(ref num8, num9, num6, num7, 2u, 15, 63u, array2);
                clRSACrypto.Method47(ref num7, num8, num9, num6, 9u, 21, 64u, array2);
                num6 += num13;
                num7 += num14;
                num8 += num15;
                num9 += num16;
            }
            byte[] array4 = new byte[16];
            Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
            Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
            Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
            Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
            return array4;
        }
        private static void Method50(ref uint ptr, uint num, uint num2, uint num3, uint num4, ushort num5, uint num6, uint[] array)
        {
            ptr = num + clRSACrypto.Method46(ptr + ((num & num2) | (~num & num3)) + array[(int)((UIntPtr)num4)] + clRSACrypto.Field27[(int)((UIntPtr)(num6 - 1u))], num5);
        }
        private static void Method49(ref uint ptr, uint num, uint num2, uint num3, uint num4, ushort num5, uint num6, uint[] array)
        {
            ptr = num + clRSACrypto.Method46(ptr + ((num & num3) | (num2 & ~num3)) + array[(int)((UIntPtr)num4)] + clRSACrypto.Field27[(int)((UIntPtr)(num6 - 1u))], num5);
        }
        private static void Method48(ref uint ptr, uint num, uint num2, uint num3, uint num4, ushort num5, uint num6, uint[] array)
        {
            ptr = num + clRSACrypto.Method46(ptr + (num ^ num2 ^ num3) + array[(int)((UIntPtr)num4)] + clRSACrypto.Field27[(int)((UIntPtr)(num6 - 1u))], num5);
        }
        private static void Method47(ref uint ptr, uint num, uint num2, uint num3, uint num4, ushort num5, uint num6, uint[] array)
        {
            ptr = num + clRSACrypto.Method46(ptr + (num2 ^ (num | ~num3)) + array[(int)((UIntPtr)num4)] + clRSACrypto.Field27[(int)((UIntPtr)(num6 - 1u))], num5);
        }
        private static uint Method46(uint num, ushort num2)
        {
            return num >> (int)(32 - num2) | num << (int)num2;
        }

        internal static bool Method45()
        {
            if (!clRSACrypto.Field26)
            {
                clRSACrypto.Method43();
                clRSACrypto.Field26 = true;
            }
            return clRSACrypto.Field15;
        }
        internal static SymmetricAlgorithm Method44()
        {
            SymmetricAlgorithm result = null;
            if (clRSACrypto.Method45())
            {
                try
                {
                    result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
                    return result;
                }
                catch
                {
                    result = new RijndaelManaged();
                    return result;
                }
            }
            try
            {
                result = new RijndaelManaged();
            }
            catch
            {
                result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
            }
            return result;
        }
        internal static void Method43()
        {
            try
            {
                // зачем-то в примере был создан
                // new RijndaelManaged();
                clRSACrypto.Field15 = false;
            }
            catch
            {
                clRSACrypto.Field15 = true;
            }
        }
        internal static byte[] Method42(byte[] array)
        {
            if (!clRSACrypto.Method45())
            {
                return new MD5CryptoServiceProvider().ComputeHash(array);
            }
            return clRSACrypto.Method51(array);
        }

        //[Class8.Attribute1(typeof(gyTR2TVVrbCHvCVDmc.P57xxoT27DExysv3UO.rHWQFXNUguF8ytuACu<object>[]))]
        [Attribute1(typeof(Attribute1.Class9<object>[]))]
        internal static bool Method41(int num)
        {
            if (clRSACrypto.Field25.Length == 0)
            {
                BinaryReader binaryReader = new BinaryReader(clRSACrypto.Field3.GetManifestResourceStream("{11111-22222-20001-00000}"));
                binaryReader.BaseStream.Position = 0L;
                RSACryptoServiceProvider.UseMachineKeyStore = true;
                byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
                byte[] rgbKey = new clRSACrypto().Method28();
                byte[] array2 = new clRSACrypto().Method29();
                byte[] publicKeyToken = clRSACrypto.Field3.GetName().GetPublicKeyToken();
                if (publicKeyToken != null && publicKeyToken.Length > 0)
                {
                    array2[1] = publicKeyToken[0];
                    array2[3] = publicKeyToken[1];
                    array2[5] = publicKeyToken[2];
                    array2[7] = publicKeyToken[3];
                    array2[9] = publicKeyToken[4];
                    array2[11] = publicKeyToken[5];
                    array2[13] = publicKeyToken[6];
                    array2[15] = publicKeyToken[7];
                }
                SymmetricAlgorithm symmetricAlgorithm = clRSACrypto.Method44();
                symmetricAlgorithm.Mode = CipherMode.CBC;
                ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array2);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.FlushFinalBlock();
                clRSACrypto.Field25 = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                binaryReader.Close();
            }
            if (clRSACrypto.Field10.Length == 0)
            {
                clRSACrypto.Field10 = clRSACrypto.Method33(clRSACrypto.Method34(clRSACrypto.Field3).ToString());
            }
            int num2 = 0;
            try
            {
                num2 = BitConverter.ToInt32(new byte[]
                {
            clRSACrypto.Field25[num],
            clRSACrypto.Field25[num + 1],
            clRSACrypto.Field25[num + 2],
            clRSACrypto.Field25[num + 3]
                }, 0);
            }
            catch
            {
            }
            try
            {
                if (clRSACrypto.Field10[num2] == 128)
                {
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }
        private byte[] Method28()
        {
            string text = "{11111-22222-20001-00002}";
            if (text.Length > 0)
            {
                return new byte[] {1,2};
            }
            return new byte[] {1,2};
        }
        private byte[] Method29()
        {
            string text = "{11111-22222-20001-00001}";
            if (text.Length > 0)
            {
                return new byte[] {1,2};
            }
            return new byte[] {1,2};
        }
        //[Class8.Attribute1(typeof(gyTR2TVVrbCHvCVDmc.P57xxoT27DExysv3UO.rHWQFXNUguF8ytuACu<object>[]))]
        [clRSACrypto.Attribute1(typeof(clRSACrypto.Attribute1.Class9<object>[]))]
        private static byte[] Method33(string path)
        {
            byte[] array;
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int num = 0;
                long length = fileStream.Length;
                int i = (int)length;
                array = new byte[i];
                while (i > 0)
                {
                    int num2 = fileStream.Read(array, num, i);
                    num += num2;
                    i -= num2;
                }
            }
            return array;
        }
        internal static object Method34(object obj)
        {
            try
            {
                if (File.Exists(((Assembly)obj).Location))
                {
                    object result = ((Assembly)obj).Location;
                    return result;
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists(((Assembly)obj).GetName().CodeBase.ToString().Replace("file:///", "")))
                {
                    object result = ((Assembly)obj).GetName().CodeBase.ToString().Replace("file:///", "");
                    return result;
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists(obj.GetType().GetProperty("Location").GetValue(obj, new object[0]).ToString()))
                {
                    object result = obj.GetType().GetProperty("Location").GetValue(obj, new object[0]).ToString();
                    return result;
                }
            }
            catch
            {
            }
            return "";
        }

        /// <summary>
        /// Ссылка из дизайнерана наименования текста (возврат строкового значения)
        /// </summary>
        //[Class8.Attribute1(typeof(gyTR2TVVrbCHvCVDmc.P57xxoT27DExysv3UO.rHWQFXNUguF8ytuACu<object>[]))]
        [clRSACrypto.Attribute1(typeof(clRSACrypto.Attribute1.Class9<object>[]))]
        internal static string Method39(int num)
        {
            //if (Class8.Field24.Length == 0)
            //{
            //BinaryReader binaryReader = new BinaryReader(Class8.Field3.GetManifestResourceStream("RutIMOqmpIH8UM5lEy.e39GUc7UjBG7fnPwUf"));
            //    binaryReader.BaseStream.Position = 0L;
            //    byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
            //    binaryReader.Close();
            //    byte[] array2 = new byte[32];
            //    array2[0] = 141 - 47;
            //    array2[0] = 163;
            //    array2[0] = 41 + 109;
            //    array2[0] = 223 - 74;
            //    array2[0] = 75 + 95;
            //    array2[0] = 144;
            //    array2[1] = 2 + 54;
            //    array2[1] = 42 + 87;
            //    array2[1] = 141;
            //    array2[1] = 160;
            //    array2[1] = 151 - 50;
            //    array2[1] = 133 - 74;
            //    array2[2] = 90;
            //    array2[2] = 112 + 121;
            //    array2[2] = 28 + 2;
            //    array2[2] = 146;
            //    array2[2] = 81 + 51;
            //    array2[3] = 124;
            //    array2[3] = 56 + 35;
            //    array2[3] = 143;
            //    array2[3] = 199 - 102;
            //    array2[4] = 34 + 57;
            //    array2[4] = 16;
            //    array2[4] = 139 - 46;
            //    array2[4] = 158;
            //    array2[4] = 99 - 41;
            //    array2[5] = 178;
            //    array2[5] = 131;
            //    array2[5] = 179 - 59;
            //    array2[5] = 191;
            //    array2[6] = 38;
            //    array2[6] = 157 - 52;
            //    array2[6] = 82 + 45;
            //    array2[6] = 14;
            //    array2[6] = 7 + 121;
            //    array2[6] = 96;
            //    array2[7] = 15 + 108;
            //    array2[7] = 236 - 78;
            //    array2[7] = 219;
            //    array2[8] = 82;
            //    array2[8] = 193 - 64;
            //    array2[8] = 113 + 115;
            //    array2[8] = 160;
            //    array2[8] = 209;
            //    array2[8] = 80;
            //    array2[9] = 105;
            //    array2[9] = 91;
            //    array2[9] = 110 + 52;
            //    array2[10] = 125;
            //    array2[10] = 137;
            //    array2[10] = 84;
            //    array2[10] = 127;
            //    array2[10] = 169 - 56;
            //    array2[10] = 140 - 17;
            //    array2[11] = 105;
            //    array2[11] = 221 - 73;
            //    array2[11] = 153;
            //    array2[11] = 215 - 71;
            //    array2[11] = 164 + 37;
            //    array2[12] = 141;
            //    array2[12] = 104;
            //    array2[12] = 187;
            //    array2[13] = 124;
            //    array2[13] = 201;
            //    array2[13] = 88;
            //    array2[13] = 200;
            //    array2[14] = 143 - 47;
            //    array2[14] = 55 + 55;
            //    array2[14] = 215 - 71;
            //    array2[14] = 110;
            //    array2[14] = 104;
            //    array2[14] = 212;
            //    array2[15] = 183 - 61;
            //    array2[15] = 109;
            //    array2[15] = 90;
            //    array2[15] = 192 - 64;
            //    array2[15] = 109 + 31;
            //    array2[16] = 159;
            //    array2[16] = 223 - 74;
            //    array2[16] = 28 + 94;
            //    array2[16] = 116;
            //    array2[16] = 248 + 1;
            //    array2[17] = 125 - 41;
            //    array2[17] = 84 + 87;
            //    array2[17] = 96;
            //    array2[17] = 93;
            //    array2[17] = 134 + 102;
            //    array2[18] = 189 - 63;
            //    array2[18] = 152;
            //    array2[18] = 55;
            //    array2[18] = 182;
            //    array2[18] = 88;
            //    array2[19] = 124 + 91;
            //    array2[19] = 207 - 69;
            //    array2[19] = 151 - 85;
            //    array2[20] = 104;
            //    array2[20] = 137;
            //    array2[20] = 1 + 46;
            //    array2[20] = 119 + 18;
            //    array2[21] = 220 - 73;
            //    array2[21] = 146;
            //    array2[21] = 50 + 31;
            //    array2[21] = 235;
            //    array2[22] = 29 + 92;
            //    array2[22] = 110;
            //    array2[22] = 107 + 93;
            //    array2[22] = 83;
            //    array2[22] = 3 + 117;
            //    array2[22] = 161;
            //    array2[23] = 128 - 42;
            //    array2[23] = 164 - 54;
            //    array2[23] = 86 + 4;
            //    array2[23] = 206 - 68;
            //    array2[23] = 123 - 20;
            //    array2[24] = 167 - 55;
            //    array2[24] = 92;
            //    array2[24] = 163 - 54;
            //    array2[24] = 134;
            //    array2[24] = 78;
            //    array2[24] = 211 + 15;
            //    array2[25] = 89 + 68;
            //    array2[25] = 85;
            //    array2[25] = 144;
            //    array2[25] = 173 - 57;
            //    array2[25] = 83;
            //    array2[26] = 240 - 80;
            //    array2[26] = 172;
            //    array2[26] = 106 + 124;
            //    array2[27] = 138;
            //    array2[27] = 149;
            //    array2[27] = 48 + 28;
            //    array2[27] = 168;
            //    array2[27] = 37;
            //    array2[28] = 198 - 66;
            //    array2[28] = 133 - 44;
            //    array2[28] = 249 - 83;
            //    array2[28] = 4 + 61;
            //    array2[28] = 86;
            //    array2[29] = 45 + 0;
            //    array2[29] = 237 - 79;
            //    array2[29] = 241 - 80;
            //    array2[29] = 145;
            //    array2[29] = 36 + 15;
            //    array2[29] = 52;
            //    array2[30] = 85;
            //    array2[30] = 68;
            //    array2[30] = 150 + 0;
            //    array2[31] = 142;
            //    array2[31] = 11 + 41;
            //    array2[31] = 211 - 70;
            //    array2[31] = 119 + 82;
            //    array2[31] = 246;
            //    byte[] array3 = array2;
            //    byte[] array4 = new byte[16];
            //    array4[0] = 94;
            //    array4[0] = 170 - 56;
            //    array4[0] = 146;
            //    array4[0] = 35;
            //    array4[1] = 83 + 75;
            //    array4[1] = 112;
            //    array4[1] = 28 + 2;
            //    array4[1] = 72 + 42;
            //    array4[1] = 56 + 44;
            //    array4[1] = 113;
            //    array4[2] = 106 + 25;
            //    array4[2] = 165;
            //    array4[2] = 152 - 50;
            //    array4[2] = 242 - 80;
            //    array4[2] = 111 + 121;
            //    array4[3] = 30;
            //    array4[3] = 146;
            //    array4[3] = 152;
            //    array4[3] = 159;
            //    array4[4] = 86 + 93;
            //    array4[4] = 205;
            //    array4[4] = 57 + 41;
            //    array4[4] = 106 - 16;
            //    array4[5] = 108;
            //    array4[5] = 107 + 41;
            //    array4[5] = 70;
            //    array4[6] = 78 + 68;
            //    array4[6] = 52 + 116;
            //    array4[6] = 53 - 8;
            //    array4[7] = 151 - 50;
            //    array4[7] = 221 - 73;
            //    array4[7] = 168;
            //    array4[7] = 72;
            //    array4[7] = 23;
            //    array4[8] = 89;
            //    array4[8] = 94;
            //    array4[8] = 94;
            //    array4[8] = 126;
            //    array4[8] = 212;
            //    array4[8] = 145;
            //    array4[9] = 114 + 65;
            //    array4[9] = 113 + 115;
            //    array4[9] = 170;
            //    array4[9] = 226;
            //    array4[10] = 221 - 73;
            //    array4[10] = 192 - 64;
            //    array4[10] = 90 + 15;
            //    array4[10] = 89 - 51;
            //    array4[11] = 52 + 72;
            //    array4[11] = 102;
            //    array4[11] = 160 + 76;
            //    array4[12] = 84;
            //    array4[12] = 184;
            //    array4[12] = 138;
            //    array4[12] = 77 + 118;
            //    array4[12] = 93;
            //    array4[12] = 187 - 100;
            //    array4[13] = 87 + 37;
            //    array4[13] = 211 - 70;
            //    array4[13] = 86 + 60;
            //    array4[14] = 158;
            //    array4[14] = 56 + 92;
            //    array4[14] = 117;
            //    array4[14] = 134;
            //    array4[14] = 194 + 7;
            //    array4[15] = 129 - 43;
            //    array4[15] = 143 - 47;
            //    array4[15] = 148 + 50;
            //    byte[] array5 = array4;
            //    Array.Reverse(array5);
            //    byte[] publicKeyToken = Class8.Field3.GetName().GetPublicKeyToken();
            //    if (publicKeyToken != null && publicKeyToken.Length > 0)
            //    {
            //        array5[1] = publicKeyToken[0];
            //        array5[3] = publicKeyToken[1];
            //        array5[5] = publicKeyToken[2];
            //        array5[7] = publicKeyToken[3];
            //        array5[9] = publicKeyToken[4];
            //        array5[11] = publicKeyToken[5];
            //        array5[13] = publicKeyToken[6];
            //        array5[15] = publicKeyToken[7];
            //    }
            //    for (int i = 0; i < array5.Length; i++)
            //    {
            //        array3[i] ^= array5[i];
            //    }
            //    if (num == -1)
            //    {
            //        SymmetricAlgorithm symmetricAlgorithm = Class8.Method44();
            //        symmetricAlgorithm.Mode = CipherMode.CBC;
            //        ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
            //        MemoryStream memoryStream = new MemoryStream();
            //        CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
            //        cryptoStream.Write(array, 0, array.Length);
            //        cryptoStream.FlushFinalBlock();
            //        Class8.Field24 = memoryStream.ToArray();
            //        memoryStream.Close();
            //        cryptoStream.Close();
            //        array = Class8.Field24;
            //    }
            //    int num2 = array.Length % 4;
            //    int num3 = array.Length / 4;
            //    byte[] array6 = new byte[array.Length];
            //    int num4 = array3.Length / 4;
            //    uint num5 = 0u;
            //    if (num2 > 0)
            //    {
            //        num3++;
            //    }
            //    for (int j = 0; j < num3; j++)
            //    {
            //        int num6 = j % num4;
            //        int num7 = j * 4;
            //        uint num8 = (uint)(num6 * 4);
            //        uint num9 = (uint)((int)array3[(int)((UIntPtr)(num8 + 3u))] << 24 | (int)array3[(int)((UIntPtr)(num8 + 2u))] << 16 | (int)array3[(int)((UIntPtr)(num8 + 1u))] << 8 | (int)array3[(int)((UIntPtr)num8)]);
            //        uint num10 = 255u;
            //        int num11 = 0;
            //        uint num12;
            //        if (j == num3 - 1 && num2 > 0)
            //        {
            //            num12 = 0u;
            //            num5 += num9;
            //            for (int k = 0; k < num2; k++)
            //            {
            //                if (k > 0)
            //                {
            //                    num12 <<= 8;
            //                }
            //                num12 |= (uint)array[array.Length - (1 + k)];
            //            }
            //        }
            //        else
            //        {
            //            num5 += num9;
            //            num8 = (uint)num7;
            //            num12 = (uint)((int)array[(int)((UIntPtr)(num8 + 3u))] << 24 | (int)array[(int)((UIntPtr)(num8 + 2u))] << 16 | (int)array[(int)((UIntPtr)(num8 + 1u))] << 8 | (int)array[(int)((UIntPtr)num8)]);
            //        }
            //        uint num13 = num5;
            //        uint arg_1142_0 = num13;
            //        uint num14 = num13;
            //        uint num15 = 1135765180u;
            //        uint num16 = 33000u * (1820768095u & 65535u) - (1820768095u >> 16);
            //        uint num17 = 40110u * (1086486090u & 65535u) + (1086486090u >> 16);
            //        uint num18 = 63038u * 400813983u + 1356330994u;
            //        uint num19 = 1560332032u >> 8 | 7012363u << 8;
            //        num19 = 8402u * (1801259975u & 65535u) - (1801259975u >> 16);
            //        num17 = 30452u * (1214627598u & 65535u) + (1214627598u >> 16);
            //        num17 = 30435u * 1489425853u - 25304545u;
            //        num19 = 169517u * (25304545u & 16383u) - (25304545u >> 14);
            //        num17 = 243450u * (1565689526u & 16383u) + (1565689526u >> 14);
            //        num17 = 49924u * 418342662u - 1296633989u;
            //        if (1135765180 == 0.0)
            //        {
            //            num15 -= 1u;
            //        }
            //        uint num20 = (uint)(43101.0 / num15 + num15);
            //        if (num17 == 0u)
            //        {
            //            num17 -= 1u;
            //        }
            //        num15 = (uint)((uint)(1375020721.0 / num17) - num20 + 1375020721.0);
            //        num14 ^= num14 << 9;
            //        num14 += num18;
            //        num14 ^= num14 << 1;
            //        num14 += num16;
            //        num14 ^= num14 >> 5;
            //        num14 += num15;
            //        num14 = ((num16 << 4) + num19 ^ num18) - num14;
            //        num13 = arg_1142_0 + (uint)num14;
            //        num5 = num13;
            //        if (j == num3 - 1 && num2 > 0)
            //        {
            //            uint num21 = num5 ^ num12;
            //            for (int l = 0; l < num2; l++)
            //            {
            //                if (l > 0)
            //                {
            //                    num10 <<= 8;
            //                    num11 += 8;
            //                }
            //                array6[num7 + l] = (byte)((num21 & num10) >> num11);
            //            }
            //        }
            //        else
            //        {
            //            uint num22 = num5 ^ num12;
            //            array6[num7] = (byte)(num22 & 255u);
            //            array6[num7 + 1] = (byte)((num22 & 65280u) >> 8);
            //            array6[num7 + 2] = (byte)((num22 & 16711680u) >> 16);
            //            array6[num7 + 3] = (byte)((num22 & 4278190080u) >> 24);
            //        }
            //    }
            //    Class8.Field24 = array6;
            //}
            //int count = BitConverter.ToInt32(Class8.Field24, num);
            //try
            //{
            //    return System.Text.Encoding.Unicode.GetString(Class8.Field24, num + 4, count);
            //}
            //catch
            //{
            //}
            if (clRSACrypto.Field24.Length == 0)
            {
                //BinaryReader binaryReader = new BinaryReader(clRSACrypto.Field3.GetManifestResourceStream("RutIMOqmpIH8UM5lEy.e39GUc7UjBG7fnPwUf"));
                BinaryReader binaryReader = new BinaryReader(Field3.GetManifestResourceStream("EIS.e39GUc7UjBG7fnPwUf"));
                binaryReader.BaseStream.Position = 0L;
                byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
                binaryReader.Close();
                byte[] array2 = new byte[32];
                array2[0] = 141 - 47;
                array2[0] = 163;
                array2[0] = 41 + 109;
                array2[0] = 223 - 74;
                array2[0] = 75 + 95;
                array2[0] = 144;
                array2[1] = 2 + 54;
                array2[1] = 42 + 87;
                array2[1] = 141;
                array2[1] = 160;
                array2[1] = 151 - 50;
                array2[1] = 133 - 74;
                array2[2] = 90;
                array2[2] = 112 + 121;
                array2[2] = 28 + 2;
                array2[2] = 146;
                array2[2] = 81 + 51;
                array2[3] = 124;
                array2[3] = 56 + 35;
                array2[3] = 143;
                array2[3] = 199 - 102;
                array2[4] = 34 + 57;
                array2[4] = 16;
                array2[4] = 139 - 46;
                array2[4] = 158;
                array2[4] = 99 - 41;
                array2[5] = 178;
                array2[5] = 131;
                array2[5] = 179 - 59;
                array2[5] = 191;
                array2[6] = 38;
                array2[6] = 157 - 52;
                array2[6] = 82 + 45;
                array2[6] = 14;
                array2[6] = 7 + 121;
                array2[6] = 96;
                array2[7] = 15 + 108;
                array2[7] = 236 - 78;
                array2[7] = 219;
                array2[8] = 82;
                array2[8] = 193 - 64;
                array2[8] = 113 + 115;
                array2[8] = 160;
                array2[8] = 209;
                array2[8] = 80;
                array2[9] = 105;
                array2[9] = 91;
                array2[9] = 110 + 52;
                array2[10] = 125;
                array2[10] = 137;
                array2[10] = 84;
                array2[10] = 127;
                array2[10] = 169 - 56;
                array2[10] = 140 - 17;
                array2[11] = 105;
                array2[11] = 221 - 73;
                array2[11] = 153;
                array2[11] = 215 - 71;
                array2[11] = 164 + 37;
                array2[12] = 141;
                array2[12] = 104;
                array2[12] = 187;
                array2[13] = 124;
                array2[13] = 201;
                array2[13] = 88;
                array2[13] = 200;
                array2[14] = 143 - 47;
                array2[14] = 55 + 55;
                array2[14] = 215 - 71;
                array2[14] = 110;
                array2[14] = 104;
                array2[14] = 212;
                array2[15] = 183 - 61;
                array2[15] = 109;
                array2[15] = 90;
                array2[15] = 192 - 64;
                array2[15] = 109 + 31;
                array2[16] = 159;
                array2[16] = 223 - 74;
                array2[16] = 28 + 94;
                array2[16] = 116;
                array2[16] = 248 + 1;
                array2[17] = 125 - 41;
                array2[17] = 84 + 87;
                array2[17] = 96;
                array2[17] = 93;
                array2[17] = 134 + 102;
                array2[18] = 189 - 63;
                array2[18] = 152;
                array2[18] = 55;
                array2[18] = 182;
                array2[18] = 88;
                array2[19] = 124 + 91;
                array2[19] = 207 - 69;
                array2[19] = 151 - 85;
                array2[20] = 104;
                array2[20] = 137;
                array2[20] = 1 + 46;
                array2[20] = 119 + 18;
                array2[21] = 220 - 73;
                array2[21] = 146;
                array2[21] = 50 + 31;
                array2[21] = 235;
                array2[22] = 29 + 92;
                array2[22] = 110;
                array2[22] = 107 + 93;
                array2[22] = 83;
                array2[22] = 3 + 117;
                array2[22] = 161;
                array2[23] = 128 - 42;
                array2[23] = 164 - 54;
                array2[23] = 86 + 4;
                array2[23] = 206 - 68;
                array2[23] = 123 - 20;
                array2[24] = 167 - 55;
                array2[24] = 92;
                array2[24] = 163 - 54;
                array2[24] = 134;
                array2[24] = 78;
                array2[24] = 211 + 15;
                array2[25] = 89 + 68;
                array2[25] = 85;
                array2[25] = 144;
                array2[25] = 173 - 57;
                array2[25] = 83;
                array2[26] = 240 - 80;
                array2[26] = 172;
                array2[26] = 106 + 124;
                array2[27] = 138;
                array2[27] = 149;
                array2[27] = 48 + 28;
                array2[27] = 168;
                array2[27] = 37;
                array2[28] = 198 - 66;
                array2[28] = 133 - 44;
                array2[28] = 249 - 83;
                array2[28] = 4 + 61;
                array2[28] = 86;
                array2[29] = 45 + 0;
                array2[29] = 237 - 79;
                array2[29] = 241 - 80;
                array2[29] = 145;
                array2[29] = 36 + 15;
                array2[29] = 52;
                array2[30] = 85;
                array2[30] = 68;
                array2[30] = 150 + 0;
                array2[31] = 142;
                array2[31] = 11 + 41;
                array2[31] = 211 - 70;
                array2[31] = 119 + 82;
                array2[31] = 246;
                byte[] array3 = array2;
                byte[] array4 = new byte[16];
                array4[0] = 94;
                array4[0] = 170 - 56;
                array4[0] = 146;
                array4[0] = 35;
                array4[1] = 83 + 75;
                array4[1] = 112;
                array4[1] = 28 + 2;
                array4[1] = 72 + 42;
                array4[1] = 56 + 44;
                array4[1] = 113;
                array4[2] = 106 + 25;
                array4[2] = 165;
                array4[2] = 152 - 50;
                array4[2] = 242 - 80;
                array4[2] = 111 + 121;
                array4[3] = 30;
                array4[3] = 146;
                array4[3] = 152;
                array4[3] = 159;
                array4[4] = 86 + 93;
                array4[4] = 205;
                array4[4] = 57 + 41;
                array4[4] = 106 - 16;
                array4[5] = 108;
                array4[5] = 107 + 41;
                array4[5] = 70;
                array4[6] = 78 + 68;
                array4[6] = 52 + 116;
                array4[6] = 53 - 8;
                array4[7] = 151 - 50;
                array4[7] = 221 - 73;
                array4[7] = 168;
                array4[7] = 72;
                array4[7] = 23;
                array4[8] = 89;
                array4[8] = 94;
                array4[8] = 94;
                array4[8] = 126;
                array4[8] = 212;
                array4[8] = 145;
                array4[9] = 114 + 65;
                array4[9] = 113 + 115;
                array4[9] = 170;
                array4[9] = 226;
                array4[10] = 221 - 73;
                array4[10] = 192 - 64;
                array4[10] = 90 + 15;
                array4[10] = 89 - 51;
                array4[11] = 52 + 72;
                array4[11] = 102;
                array4[11] = 160 + 76;
                array4[12] = 84;
                array4[12] = 184;
                array4[12] = 138;
                array4[12] = 77 + 118;
                array4[12] = 93;
                array4[12] = 187 - 100;
                array4[13] = 87 + 37;
                array4[13] = 211 - 70;
                array4[13] = 86 + 60;
                array4[14] = 158;
                array4[14] = 56 + 92;
                array4[14] = 117;
                array4[14] = 134;
                array4[14] = 194 + 7;
                array4[15] = 129 - 43;
                array4[15] = 143 - 47;
                array4[15] = 148 + 50;
                byte[] array5 = array4;
                Array.Reverse(array5);
                byte[] publicKeyToken = clRSACrypto.Field3.GetName().GetPublicKeyToken();
                if (publicKeyToken != null && publicKeyToken.Length > 0)
                {
                    array5[1] = publicKeyToken[0];
                    array5[3] = publicKeyToken[1];
                    array5[5] = publicKeyToken[2];
                    array5[7] = publicKeyToken[3];
                    array5[9] = publicKeyToken[4];
                    array5[11] = publicKeyToken[5];
                    array5[13] = publicKeyToken[6];
                    array5[15] = publicKeyToken[7];
                }
                for (int i = 0; i < array5.Length; i++)
                {
                    array3[i] ^= array5[i];
                }
                if (num == -1)
                {
                    SymmetricAlgorithm symmetricAlgorithm = clRSACrypto.Method44();
                    symmetricAlgorithm.Mode = CipherMode.CBC;
                    ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
                    MemoryStream memoryStream = new MemoryStream();
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                    cryptoStream.Write(array, 0, array.Length);
                    cryptoStream.FlushFinalBlock();
                    clRSACrypto.Field24 = memoryStream.ToArray();
                    memoryStream.Close();
                    cryptoStream.Close();
                    array = clRSACrypto.Field24;
                }
                int num2 = array.Length % 4;
                int num3 = array.Length / 4;
                byte[] array6 = new byte[array.Length];
                int num4 = array3.Length / 4;
                uint num5 = 0u;
                if (num2 > 0)
                {
                    num3++;
                }
                for (int j = 0; j < num3; j++)
                {
                    int num6 = j % num4;
                    int num7 = j * 4;
                    uint num8 = (uint)(num6 * 4);
                    uint num9 = (uint)((int)array3[(int)((UIntPtr)(num8 + 3u))] << 24 | (int)array3[(int)((UIntPtr)(num8 + 2u))] << 16 | (int)array3[(int)((UIntPtr)(num8 + 1u))] << 8 | (int)array3[(int)((UIntPtr)num8)]);
                    uint num10 = 255u;
                    int num11 = 0;
                    uint num12;
                    if (j == num3 - 1 && num2 > 0)
                    {
                        num12 = 0u;
                        num5 += num9;
                        for (int k = 0; k < num2; k++)
                        {
                            if (k > 0)
                            {
                                num12 <<= 8;
                            }
                            num12 |= (uint)array[array.Length - (1 + k)];
                        }
                    }
                    else
                    {
                        num5 += num9;
                        num8 = (uint)num7;
                        num12 = (uint)((int)array[(int)((UIntPtr)(num8 + 3u))] << 24 | (int)array[(int)((UIntPtr)(num8 + 2u))] << 16 | (int)array[(int)((UIntPtr)(num8 + 1u))] << 8 | (int)array[(int)((UIntPtr)num8)]);
                    }
                    uint num13 = num5;
                    uint arg_1142_0 = num13;
                    uint num14 = num13;
                    uint num15 = 1135765180u;
                    uint num16 = 33000u * (1820768095u & 65535u) - (1820768095u >> 16);
                    uint num17 = 40110u * (1086486090u & 65535u) + (1086486090u >> 16);
                    uint num18_1 = 400813983u;
                    uint num18 = 63038u * num18_1 + 1356330994u;
                    uint num19 = 1560332032u >> 8 | 7012363u << 8;
                    num19 = 8402u * (1801259975u & 65535u) - (1801259975u >> 16);
                    num17 = 30452u * (1214627598u & 65535u) + (1214627598u >> 16);

                    //uint num17 = 1489425853u;
                    num17 = 30435u * num17 - 25304545u;

                    num19 = 169517u * (25304545u & 16383u) - (25304545u >> 14);
                    num17 = 243450u * (1565689526u & 16383u) + (1565689526u >> 14);

                    //num17 = 418342662u;
                    num17 = 49924u * num17 - 1296633989u;

                    if (1135765180 == 0.0)
                    {
                        num15 -= 1u;
                    }
                    uint num20 = (uint)(43101.0 / num15 + num15);
                    if (num17 == 0u)
                    {
                        num17 -= 1u;
                    }
                    num15 = (uint)((uint)(1375020721.0 / num17) - num20 + 1375020721.0);
                    num14 ^= num14 << 9;
                    num14 += num18;
                    num14 ^= num14 << 1;
                    num14 += num16;
                    num14 ^= num14 >> 5;
                    num14 += num15;
                    num14 = ((num16 << 4) + num19 ^ num18) - num14;
                    num13 = arg_1142_0 + (uint)num14;
                    num5 = num13;
                    if (j == num3 - 1 && num2 > 0)
                    {
                        uint num21 = num5 ^ num12;
                        for (int l = 0; l < num2; l++)
                        {
                            if (l > 0)
                            {
                                num10 <<= 8;
                                num11 += 8;
                            }
                            array6[num7 + l] = (byte)((num21 & num10) >> num11);
                        }
                    }
                    else
                    {
                        uint num22 = num5 ^ num12;
                        array6[num7] = (byte)(num22 & 255u);
                        array6[num7 + 1] = (byte)((num22 & 65280u) >> 8);
                        array6[num7 + 2] = (byte)((num22 & 16711680u) >> 16);
                        array6[num7 + 3] = (byte)((num22 & 4278190080u) >> 24);
                    }
                }
                clRSACrypto.Field24 = array6;
            }
            int count = BitConverter.ToInt32(clRSACrypto.Field24, num);
            try
            {
                return System.Text.Encoding.Unicode.GetString(clRSACrypto.Field24, num + 4, count);
            }
            catch
            {
            }

            return "";
        }

        //tljAwuFosO = Field27
        private static uint[] Field27 = new uint[]
                {
            3614090360u,
            3905402710u,
            606105819u,
            3250441966u,
            4118548399u,
            1200080426u,
            2821735955u,
            4249261313u,
            1770035416u,
            2336552879u,
            4294925233u,
            2304563134u,
            1804603682u,
            4254626195u,
            2792965006u,
            1236535329u,
            4129170786u,
            3225465664u,
            643717713u,
            3921069994u,
            3593408605u,
            38016083u,
            3634488961u,
            3889429448u,
            568446438u,
            3275163606u,
            4107603335u,
            1163531501u,
            2850285829u,
            4243563512u,
            1735328473u,
            2368359562u,
            4294588738u,
            2272392833u,
            1839030562u,
            4259657740u,
            2763975236u,
            1272893353u,
            4139469664u,
            3200236656u,
            681279174u,
            3936430074u,
            3572445317u,
            76029189u,
            3654602809u,
            3873151461u,
            530742520u,
            3299628645u,
            4096336452u,
            1126891415u,
            2878612391u,
            4237533241u,
            1700485571u,
            2399980690u,
            4293915773u,
            2240044497u,
            1873313359u,
            4264355552u,
            2734768916u,
            1309151649u,
            4149444226u,
            3174756917u,
            718787259u,
            3951481745u
                };
        private static bool Field26 = false;
        private static bool Field15 = false;
        private static byte[] Field25 = new byte[0];
        private static byte[] Field24 = new byte[0];
        private static object Field23 = new string[0];
        private static SortedList Field22 = new SortedList();
        //private static int Field21 = 0;
        //private static long Field20 = 0L;
        //private static long Field19 = 0L;
        private static IntPtr Field18 = IntPtr.Zero;
        private static byte[] Field17 = new byte[0];
        private static int[] Field16 = new int[0];
        internal static Hashtable Field14 = new Hashtable();
        //private static int Field13 = 0;
        //private static int Field12 = 1;
        //private static bool Field11 = false;
        private static byte[] Field10 = new byte[0];
        private static IntPtr Field9 = IntPtr.Zero;
        //private static bool Field8 = false;
        internal static MulticastDelegate4 Field7 = null;
        internal static MulticastDelegate4 Field6 = null;
        private static IntPtr Field5 = IntPtr.Zero;
        //private static int Field4 = 0;
        //private static Assembly Field3 = Type.GetTypeFromHandle(Class12.Method6(33554461)).Assembly;
        // private static Assembly Field3 = typeof(clRSACrypto).Assembly;
        private static Assembly Field3;// = System.Reflection.Assembly.GetExecutingAssembly();

        //RduuN7nyMB4Xqx
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        internal delegate uint MulticastDelegate4(IntPtr classthis, IntPtr comp, IntPtr info, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);
        //f6IUeXJtvDrCc
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate IntPtr MulticastDelegate5();

        //internal struct Struct1
        //{
        //    internal bool Field2;
        //    internal byte[] Field1;
        //}
        [Flags]
        private enum Enum2
        {
        }

        //P57xxoT27DExysv3UO. = Attribute1
        internal class Attribute1 : Attribute
        {
            // [Class8.Attribute1(typeof(gyTR2TVVrbCHvCVDmc.P57xxoT27DExysv3UO.rHWQFXNUguF8ytuACu<object>[]))]
            [clRSACrypto.Attribute1(typeof(clRSACrypto.Attribute1.Class9<object>[]))]
            // насчет входящего параметра не уверен нужен ли он
            // public Attribute1(object ) <-- было так 
            public Attribute1(object obj)
            {
                clRSACrypto.Attribute1.Method1();
            }
            internal static void Method1()
            {
                Class11.Method1();
            }
            // rHWQFXNUguF8ytuACu = Class9
            internal class Class9<vW7SRRmRyXy3tM3Dtb>
            {
                public Class9()
                {
                    Class11.Method1();
                }
                internal static bool Method2()
                {
                    return true;
                }
                internal static bool Method1()
                {
                    return false;
                }
            }
        }
    }
    /// <summary>
    /// Класс нужен для Class5.Attribute
    /// </summary>
    internal class Class11
    {
        internal static void Method1()
        {
        }
        public Class11()
        {
        }
        //private static bool Field1;
    }
}