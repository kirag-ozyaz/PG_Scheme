using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace EIS
{
  public static class Compress
  {
        static void CompressFile(string sDir, string sRelativePath, GZipStream zipStream)
        {
            char[] chars = sRelativePath.ToCharArray();
            zipStream.Write(BitConverter.GetBytes(chars.Length), 0, sizeof(int));
            foreach (char c in chars)
                zipStream.Write(BitConverter.GetBytes(c), 0, sizeof(char));

            byte[] bytes = File.ReadAllBytes(Path.Combine(sDir, sRelativePath));
            zipStream.Write(BitConverter.GetBytes(bytes.Length), 0, sizeof(int));
            zipStream.Write(bytes, 0, bytes.Length);
        }

        private static bool DecompressFile(string sDir, GZipStream gZipStream)
        {
            byte[] buffer1 = new byte[4];
            if (gZipStream.Read(buffer1, 0, 4) < 4)
                return false;
            int int32_1 = BitConverter.ToInt32(buffer1, 0);
            byte[] buffer2 = new byte[2];
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < int32_1; ++index)
            {
                gZipStream.Read(buffer2, 0, 2);
                char ch = BitConverter.ToChar(buffer2, 0);
                stringBuilder.Append(ch);
            }
            string sFileName = stringBuilder.ToString();
            byte[] buffer3 = new byte[8];
            gZipStream.Read(buffer3, 0, 8);
            DateTime creationTime = DateTime.FromBinary(BitConverter.ToInt64(buffer3, 0));
            byte[] buffer4 = new byte[8];
            gZipStream.Read(buffer4, 0, 8);
            DateTime lastAccessTime = DateTime.FromBinary(BitConverter.ToInt64(buffer4, 0));
            byte[] buffer5 = new byte[8];
            gZipStream.Read(buffer5, 0, 8);
            DateTime lastWriteTime = DateTime.FromBinary(BitConverter.ToInt64(buffer5, 0));
            byte[] buffer6 = new byte[4];
            gZipStream.Read(buffer6, 0, 4);
               int int32_2 = BitConverter.ToInt32(buffer6, 0);
            byte[] buffer7 = new byte[int32_2];
            gZipStream.Read(buffer7, 0, buffer7.Length);
            string sFilePath = Path.Combine(sDir, sFileName);
            string directoryName = Path.GetDirectoryName(sFilePath);
            if (!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);
            using (FileStream fileStream = new FileStream(sFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                fileStream.Write(buffer7, 0, int32_2);
            File.SetCreationTime(sFilePath, creationTime);
            File.SetLastAccessTime(sFilePath, lastAccessTime);
            File.SetLastWriteTime(sFilePath, lastWriteTime);
            return true;
    }

    public static void DecompressToDirectory(string sCompressedFile, string sDir)
    {
      using (FileStream fileStream = new FileStream(sCompressedFile, FileMode.Open, FileAccess.Read, FileShare.None))
      {
        using (GZipStream gzipStream = new GZipStream((Stream) fileStream, CompressionMode.Decompress, true))
        {
                    while (Compress.DecompressFile(sDir, gzipStream)) ;
        }
      }
    }
        public static void CompressDirectory(string sInDir, string sOutFile)
        {
            string[] sFiles = Directory.GetFiles(sInDir, "*.*", SearchOption.AllDirectories);
            int iDirLen = sInDir[sInDir.Length - 1] == Path.DirectorySeparatorChar ? sInDir.Length : sInDir.Length + 1;

            using (FileStream outFile = new FileStream(sOutFile, FileMode.Create, FileAccess.Write, FileShare.None))
            using (GZipStream str = new GZipStream(outFile, CompressionMode.Compress))
                foreach (string sFilePath in sFiles)
                {
                    string sRelativePath = sFilePath.Substring(iDirLen);
                    CompressFile(sInDir, sRelativePath, str);
                }
        }
    }
}
