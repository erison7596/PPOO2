namespace ProcessadorDeTexto.Processors
{
    public abstract class TextoProcessor
    {
        public string ProcessarTexto(string entrada)
        {
            char[] caracteres = ExtrairCaracteres(entrada);
            char[] caracteresConvertidos = ConverterCaracteres(caracteres);
            string resultado = JuntarCaracteresConvertidos(caracteresConvertidos);
            return resultado;
        }

        protected abstract char[] ConverterCaracteres(char[] caracteres);

        private char[] ExtrairCaracteres(string texto)
        {
            return texto.ToCharArray();
        }

        private string JuntarCaracteresConvertidos(char[] caracteres)
        {
            return new string(caracteres);
        }
    }
}
