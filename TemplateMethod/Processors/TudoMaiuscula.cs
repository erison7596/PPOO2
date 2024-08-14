namespace ProcessadorDeTexto.Processors
{
    public class TudoMaiuscula : TextoProcessor
    {
        protected override char[] ConverterCaracteres(char[] caracteres)
        {
            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = char.ToUpper(caracteres[i]);
            }
            return caracteres;
        }
    }
}
