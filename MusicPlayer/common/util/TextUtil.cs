
namespace MusicPlayer.common.util
{
    class TextUtil
    {
        public static string GetTextWithLimitedLength(string text, int maxLength)
        {
            if (text.Length > maxLength)
            {
                text = text.Substring(0, maxLength - 3) + "...";
            }

            return text;
        }
    }
}
