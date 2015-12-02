using Microsoft.Xna.Framework;

namespace AnimationEditor
{
    public static class StaticMethods
    {
        public static Vector2 GetCenter(Vector2 box)
        {
            return new Vector2(box.X / 2, box.Y / 2);
        }

        public static Vector2 GetDrawPosition(Vector2 boxLimits, Vector2 center)
        {
            return new Vector2((boxLimits.X / 2) - center.X, (boxLimits.Y / 2) - center.Y);
        }
    }
}