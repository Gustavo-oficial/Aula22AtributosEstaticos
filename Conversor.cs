namespace Aula22AtributosEstaticos
{
    public static class Conversor
    {
        public static float CotacaoDolar;

        public static float CotacaoEuro;


        public static float CoverterRealparaDolar(float valor){
            return valor / CotacaoDolar;
        }

        public static float CoverterDolarparaReal(float valor){
            return valor * CotacaoDolar;
        }

        public static float CoverterEuroparaReal(float valor){
            return valor * CotacaoEuro;
        }
        
           public static float CoverterRealparaEuro(float valor){
            return valor / CotacaoEuro;
        }
    }
}