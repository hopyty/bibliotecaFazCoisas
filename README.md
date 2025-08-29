namespace bibliotecaFazCoisas
{
    /// <summary>
    /// Fornece métodos para calcular e classificar o Índice de Massa Corporal (IMC).
    /// </summary>
    public static class CalculadoraIMC
    {
        /// <summary>
        /// Calcula o Índice de Massa Corporal (IMC) com base no peso e altura informados.
        /// </summary>
        /// <param name="peso">Peso da pessoa em quilogramas (kg).</param>
        /// <param name="altura">Altura da pessoa em metros (m).</param>
        /// <returns>O valor do IMC arredondado para duas casas decimais.</returns>
        /// <exception cref="ArgumentException">Lançada quando a altura for menor ou igual a zero.</exception>
        public static double Calcular(double peso, double altura)
        {
            if (altura <= 0)
                throw new ArgumentException("Altura deve ser maior que zero.");

            return Math.Round(peso / (altura * altura), 2);
        }

        /// <summary>
        /// Classifica o valor do IMC de acordo com os padrões da Organização Mundial da Saúde (OMS).
        /// </summary>
        /// <param name="imc">Valor do IMC já calculado.</param>
        /// <returns>
        /// Uma string representando a categoria do IMC:
        /// <list type="bullet">
        /// <item><description>Abaixo de 18,5 → Abaixo do peso</description></item>
        /// <item><description>18,5 a 24,9 → Peso normal</description></item>
        /// <item><description>25 a 29,9 → Sobrepeso</description></item>
        /// <item><description>30 a 34,9 → Obesidade grau I</description></item>
        /// <item><description>35 a 39,9 → Obesidade grau II</description></item>
        /// <item><description>40 ou mais → Obesidade grau III</description></item>
        /// </list>
        /// </returns>
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
