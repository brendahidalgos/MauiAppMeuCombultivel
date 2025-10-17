namespace MauiAppMeuCombultivel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // quando o botão "Qual compensa mais?" é clicado
        private async void Button_Clicked(Object sender, EventArgs e)
        {
            try
            {
                // validação dos dados
                // obtém a marca e o modelo dos campos de entrada
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                // validação para garantir que marca e modelo foram preenchidos
                if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo))
                {
                    // exibe alerta de aviso e interrompe a execução
                    await DisplayAlert("Atenção", "Por favor, insira a Marca e o Modelo do veículo.", "OK");
                    return;
                }

                // calculos
                // converte os textos dos campos de preço para números 
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                // logica do calculo do combustivel
                // o etanol compensa se for até 70% (0.7) do preço da gasolina
                if (etanol <= (gasolina * 0.7))
                {
                    // se etanol compensa, forma a mensagem personalizada com o veículo 
                    msg = $"O etanol está compensando para o seu {marca} {modelo}.";
                }
                else
                {
                    // se gasolina compensa (preço do Etanol é > 70%), forma a mensagem personalizada
                    msg = $"A gasolina está compensando para o seu {marca} {modelo}.";
                }

                // exibindo resultado final
                await DisplayAlert("Resultado do Cálculo", msg, "OK");
            }
            catch (Exception)
            {
                // tratamento de exceção: captura erros de conversão (ex: usuário digitou texto nos campos de preço)
                await DisplayAlert("Atenção", "Por favor, insira valores numéricos válidos para os preços de combustível.", "OK");
            }
        }
    }
}
