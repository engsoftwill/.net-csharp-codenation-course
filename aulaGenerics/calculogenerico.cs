namespace aulaGenerics
{
    public class calculogenerico<T> where T :icalculovalor //limita a tipagem que pode ser utilizada pela classe
    {
        private decimal _imposto    =   0.05m;
        private decimal _lucro      =   0.10m;
        public  void calcularvalorunitario(T obj)
        {
            obj.ValorFinal  += obj.ValorBruto;
            obj.ValorFinal  += obj.ValorBruto   *   _imposto;
            obj.ValorFinal  += obj.ValorBruto   *   _lucro;
        }
    }
}