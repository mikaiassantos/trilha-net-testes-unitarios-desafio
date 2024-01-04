namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista)
        {
            List<int> resultado = new List<int>();

            foreach (var numero in lista)
            {
                resultado.Add(numero * 2);
            }

            return resultado;
        }


        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }
    }
}
