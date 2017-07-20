namespace DrawGame
{
    
    public static class ExtensionMethods
    {
        public static string ToWizcomString(this Microsoft.Xna.Framework.Color value)
        {
            return string.Format(@"{0},{1},{2},{3}", value.R, value.G, value.B, value.A);

        }
    }
}
