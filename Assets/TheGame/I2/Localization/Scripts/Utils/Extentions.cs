namespace I2.Loc
{
    public static class Extentions
    {
        public static string Localized(this string key)
        {
            return LocalizationManager.GetTranslation(key);
        }
    }
}