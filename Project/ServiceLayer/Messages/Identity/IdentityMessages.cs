namespace ServiceLayer.Messages.Identity
{
    public static class IdentityMessages
    {
        public static string CheckEmailAdrress()
        {
            return " Debería tener un formato de email";
        }

        public static string ComparePassword()
        {
            return "Tiene que ser lo mismo que ingreso como contraseña";
        }
    }
}
