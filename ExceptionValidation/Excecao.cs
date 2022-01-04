namespace ExceptionValidation
{
    public class Excecao
    {
        public static string Erro = string.Empty;
        public static void ListaExcecoes(Exception ex)
        {
            Erro = string.Empty;

            do
            {
                Erro += @"    ------$$$$$$------" + Environment.NewLine;
                Erro += ex.Message + Environment.NewLine;
                Erro += @"    ------$$$$$$------" + Environment.NewLine;

                Erro += @"    ------######------" + Environment.NewLine;
                Erro += ex.StackTrace + Environment.NewLine;
                Erro += @"    ------######------" + Environment.NewLine;

                ex = ex.InnerException;
            }
            while (ex is not null);            
        }
    }
}
