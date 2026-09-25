# 📱 App de Usuários HBM

Um aplicativo mobile desenvolvido em **.NET MAUI** focado no consumo de APIs RESTful. O projeto foi estruturado utilizando o padrão **MVVM** (Model-View-ViewModel).

Desenvolvido por Henrique Knaul, Breno e Marlon (HBM).

## 🚀 Funcionalidades

* **Navegação Inicial:** Tela de entrada (Home) com roteamento direto construído sobre a arquitetura `AppShell`.
* **Consumo de API Externa:** Integração assíncrona com a REST API pública [JSONPlaceholder](https://jsonplaceholder.typicode.com/) utilizando `HttpClient`.
* **Listagem Dinâmica e Reativa:** Exibição da lista de usuários consumidos da internet através de uma `CollectionView`, com suporte a feedback visual de carregamento (`ActivityIndicator`).
* **Detalhes Dinâmicos:** Sistema de navegação com passagem de parâmetros em memória (`[QueryProperty]`) para exibir o card de informações de contato (Nome, E-mail e Telefone) do usuário selecionado.

## 🛠️ Tecnologias e Padrões

* **Framework:** .NET MAUI (Multi-platform App UI) para deploy em Android/iOS/Windows.
* **Linguagens:** C# (Lógica e Serviços) e XAML (Interface Gráfica).
* **Arquitetura:** Padrão MVVM implementado com o pacote oficial `CommunityToolkit.Mvvm` (utilizando `ObservableObject` e `RelayCommand`).
* **Tratamento de Dados:** Desserialização nativa de JSON (`System.Net.Http.Json`).

## ⚙️ Como Executar o Projeto

1. Clone este repositório para a sua máquina.
2. Abra a solução (`MauiAppUsuarios.sln`) no **Visual Studio** (certifique-se de ter a carga de trabalho do .NET MAUI instalada).
3. O Visual Studio irá restaurar automaticamente os pacotes NuGet necessários.
4. Na barra superior, selecione o seu emulador **Android** preferido.
5. Clique no botão de compilação (Play verde) para iniciar a depuração e rodar o app.

---
*Engenharia de Software — UDESC Alto Vale (CEAVI)*