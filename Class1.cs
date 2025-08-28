namespace bibliotecaFazCoisas
{
    public static class CalculadoraIMC
    {
        public static double Calcular(double peso, double altura)
        {
            if (altura <= 0)
                throw new ArgumentException("Altura deve ser maior que zero.");

            return Math.Round(peso / (altura * altura), 2);
        }
        public static string Classificar(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso";
            else if (imc < 25)
                return "Peso normal";
            else if (imc < 30)
                return "Sobrepeso";
            else if (imc < 35)
                return "Obesidade grau I";
            else if (imc < 40)
                return "Obesidade grau II";
            else
                return "Obesidade grau III";
        }
    }
}

