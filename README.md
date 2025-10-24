# ⛽ Calculadora Flex: Etanol vs. Gasolina

## 📝 Descrição:
O Calculadora Flex é um aplicativo desenvolvido em .NET MAUI para ajudar motoristas de veículos flex a decidir qual combustível é mais vantajoso financeiramente: Etanol ou Gasolina.

O app realiza o cálculo de eficiência e mostra a recomendação com base nos preços informados. Além disso, permite que o usuário registre a marca do seu veículo.

## ✨ Funcionalidades Principais
Cálculo de Vantagem: Determina se o Etanol ou a Gasolina é o mais econômico para abastecer.

Entrada de Preços: Campos para inserir o preço por litro da Gasolina e do Etanol.

Marca do Veículo: Campo para personalização (opcional) onde o usuário pode registrar a marca do seu carro.

Multiplataforma: O app tem uma interface unificada para Android, iOS, Windows e macOS.

## ⚙️ A Lógica do Cálculo (Regra dos 70%)
O aplicativo utiliza a regra mais comum para veículos flex no Brasil:

O Etanol é considerado a melhor opção se o seu preço for menor ou igual a 70% do preço da Gasolina. Caso contrário, a Gasolina é mais vantajosa.

Como Funciona:
O app calcula o percentual: (Preço do Etanol / Preço da Gasolina).

Se o resultado for 0.70 (70%) ou menor: Recomenda Etanol.

Se o resultado for maior que 0.70 (70%): Recomenda Gasolina.

## 🚀 Como Executar o Projeto
Siga estes passos para rodar o projeto em sua máquina:

Pré-requisitos
Visual Studio 2022 (com a carga de trabalho de .NET MAUI instalada).

.NET 8 - Versão utilizada.

Passos para Execução
Clone o Repositório:

Abra no Visual Studio: Abra o arquivo de solução (.sln).

Execute o Aplicativo: Selecione a plataforma (ex: Android Emulator) e pressione F5 (Executar).

## ✍️ Autor
@brendahidalgos - Aluna do curso de Análise e Desenvolvimento de Sistemas.
