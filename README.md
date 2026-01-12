# ⛽ Calculadora Flex: Etanol vs. Gasolina

## 📝 Descrição

O **Calculadora Flex** é um aplicativo desenvolvido em **.NET MAUI** para auxiliar motoristas de veículos flex a tomarem a melhor decisão financeira no momento de abastecer.

O app realiza o cálculo de eficiência com base nos preços informados e fornece uma recomendação clara, indicando se o **Etanol** ou a **Gasolina** é o combustível mais vantajoso.

## ✨ Funcionalidades Principais

* **Cálculo de Vantagem**: Determina qual combustível é o mais econômico para abastecer.
* **Entrada de Preços**: Campos intuitivos para inserir o preço por litro da Gasolina e do Etanol.
* **Marca do Veículo**: Campo de personalização (opcional) onde o usuário pode registrar a marca do seu carro.
* **Multiplataforma**: O aplicativo possui uma interface unificada e pode ser executado em **Android, iOS, Windows e macOS**.

## ⚙️ A Lógica do Cálculo (Regra dos 70%)

O aplicativo utiliza a regra mais comum e aceita no mercado para veículos flex no Brasil.

> O Etanol é considerado a melhor opção se o seu preço for **menor ou igual a 70%** do preço da Gasolina. Caso contrário, a Gasolina é mais vantajosa.

**Como Funciona:**

1.  O app calcula o percentual: $P = \frac{\text{Preço do Etanol}}{\text{Preço da Gasolina}}$.
2.  **Se** $P \le 0.70$: Recomenda **Etanol**.
3.  **Se** $P > 0.70$: Recomenda **Gasolina**.

## 🚀 Como Executar o Projeto

Siga estes passos para configurar e rodar o projeto em sua máquina de desenvolvimento:

### Pré-requisitos

* **Visual Studio 2022** (com a carga de trabalho de **.NET MAUI** instalada).
* **.NET 8**: Versão da *framework* utilizada no projeto.

### Passos para Execução

1.  **Clone o Repositório:**
    ```bash
    git clone [https://github.com/brendahidalgo/MauiAppMeuCombustivel.git](https://github.com/brendahidalgos/MauiAppMeuCombustivel.git)
    ```
2.  **Abra no Visual Studio:**
    * Abra o arquivo de solução (`.sln`) do projeto no Visual Studio 2022.
3.  **Execute o Aplicativo:**
    * Selecione o destino desejado (ex: `Android Emulator`, `Windows Machine` ou `iOS Simulator`).
    * Pressione **F5** (ou clique no botão de **Executar**).
---
## 👩‍💻 Desenvolvido em

* **Curso Técnico em Desenvolvimento de Sistemas**

## 📧 Contato

Se tiver alguma dúvida ou sugestão, pode me chamar!

* **GitHub**: [@brendahidalgos](https://github.com/brendahidalgos)

## ✍️ Autor

* **@brendahidalgos** - Aluna do curso técnico de Desenvolvimento de Sistemas.
