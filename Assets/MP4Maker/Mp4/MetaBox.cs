using System.Text;

namespace Mp4Maker
{
    /// <summary>
    /// type域为meta，包含描述或注释信息
    /// </summary>
    public class MetaBox : FullBox
    {
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            str.AppendLine("  ContentLength : " + (Size - (ulong)headerLength));
            return str.ToString();
        }
    }
}