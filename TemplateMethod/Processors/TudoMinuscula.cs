namespace ProcessadorDeTexto.Processors
{
    public class TudoMinuscula : TextoProcessor
    {
        protected override char[] ConverterCaracteres(char[] caracteres)
        {
            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = char.ToLower(caracteres[i]);
            }
            return caracteres;
        }
    }
}
