using System.Drawing;

namespace MusicPlayer.View.ulti
{
    class PictureBoxUtil
    {

        public static void ChangeOpacity(Bitmap bitmap, float opacity)
        {
            for (int w = 0; w < bitmap.Width; w++)
                for (int h = 0; h < bitmap.Height; h++)
                {
                    Color pixel = bitmap.GetPixel(w, h);
                    if (pixel != Color.Transparent)
                    {
                        Color newColor = Color.FromArgb((int)(pixel.A * opacity), pixel.R, pixel.G, pixel.B);
                        bitmap.SetPixel(w, h, newColor);
                    }
                }
        }

    }
}
