namespace ServiceLayer.Messages.WebApp
{
    public static class ValidationMessages
    {
        public static string NullEmptyMessage(string propname)
        {
            return $"¡{propname} tiene que tener un valor!";
        }
        public static string MaxinumCharachterAllowence(string propname, int restriccion)
        {
            return $"¡{propname} puede tener hasta {restriccion} carácteres!";
        }
        public static string GreaterThanMessage(string propname, int restriccion)
        {
            return $"{propname} tiene que ser mas grande que {restriccion} ";
        }
        public static string LessThanMessage(string propname, int restriccion)
        {
            return $"{propname} tiene que ser mas pequeño que {restriccion} ";
        }

    }
}
