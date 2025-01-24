# 100 Dias de Código em C# 🚀
## 100 Days of Code in C# 🚀
## 🌟🌟🌟 Bora Focar Para Aprender e Ter Realizações 🚀🚀🚀

### 🗓️ Calendário do Desafio: 
- **Início:** 09 de janeiro de 2025 🎯✨🚀💻 
- **Término:** 18 de abril de 2025 🎯✨🚀💻 

## 🌟 Progresso

![100 Days of Code](https://img.shields.io/badge/100DaysOfCode-blueviolet)

- ...

## 🗓️ Log de Atividades - 100 Dias de Código em C#

## Dia 1
- Estudei os fundamentos de C#.
- Pratiquei conceitos de OOP.
- Criei Pasta Common para Otimizar codigo e poder reutilizar codigo.

## Dia 2
- Criei Base model para armazenar Id.
- Criei Cliente e suas propriedades e com herança da base model para utilizar Id.

## Dia 3
- Criei métodos CRUD (Create, Read, Update,) para salvar e resgatar dados.
- Implementei uma View para interagir com os métodos CRUD e manipular os dados.
- Usei um arquivo de texto (.txt) para praticar a persistência e recuperação de dados. 

## Dia 4
- Implementado Menu e Realizado testes para chamar program
- Realizado testes e funcionou 

## Dia 5
- Corrigido codigo pois tostring estava base.ToString Trazendo todas infomação,
  - Ficou this.Id dentro do Tosting trazendo somente o Id

## Dia 6
- Criado novo ConsoleApp2 para praticar comunicação com banco dados postgres.
- Após varias tentativas falhas consegui deu certo.
- Estava tentando implementar em uma estrutura mais robusta mas deu varios B.O.
- Por este motivo Criei uma estrutura simples e funcionou agora proximo Desafio ajustar
  uma estrutura mais robusta.
- Unica coisa manual foi criar banco pelo DBeaver o resto tudo pelo C# e ajuda IA.
- Abaixo Imagem test estou usando DBeaver para fazer Gerenciamento do Banco Dados
  <br>
  
 ![Captura de tela 2025-01-14 155648](https://github.com/user-attachments/assets/1ad1acf4-a8ac-470f-9249-79041060c203)

## Dia 7
- Otimizado codigo com Menu e Reestruturado codigo deixando mais robusto
- segue imagem codigo
  <br>
  
 ![Captura de tela 2025-01-15 171503](https://github.com/user-attachments/assets/76b98291-e80a-4e52-8ea8-81d718c0fb05)

## Dia 8
- Otimizado codigo com Pasta Common para Reutilizar codigo
- Reestruturado codigo deixando mais robusto colocando cores e para otimizar
- segue imagem codigo
  <br>

![Captura de tela 2025-01-16 191703](https://github.com/user-attachments/assets/c7459eae-564f-41f7-ba64-56de796e19d5)

## Dia 9
- Revisto Codigo View e Repository para otimizar codigo
- Após modificação testado Codigo ficou Top
- Mais Limpo e Claro nas declarações

## Dia 10
- Implementado Metodo Deletar
- Testado delete simples mas por segurança obtei em aprimorar e deixar mais seguro codigo
- Antes deletar Vai Solicitar confirmaçao do CPF para usuario confirmar e assim deletar
- segue imagem codigo
  <br>

![Captura de tela 2025-01-18 201403](https://github.com/user-attachments/assets/49a5823d-10d0-4960-8155-5db649e4edfc)

## Dia 11
- Implementado Base Model para Id
- Utilizando como Herança em Cliente para Id
- Após varias tentativas e ajustes em Cliente e Repository Funcionou
- segue imagem codigo aqui Banco dados
  <br>
![Captura de tela 2025-01-19 195312](https://github.com/user-attachments/assets/54bebfd2-72dc-4564-b871-63e0f4453948)
  <br>
- segue imagem codigo 
![Captura de tela 2025-01-19 194919](https://github.com/user-attachments/assets/07d3a08d-5f44-49c0-876d-1e9a107207eb)

## Dia 12
- Criado Formulario com Form
- Testado funcionado porém tem afazer link com view
  <br>
- ![Captura de tela 2025-01-20 195156](https://github.com/user-attachments/assets/9d481688-3dd5-4ffc-8d70-2ef0fe9bb553)

## Dia 13
- Inserido Web AspNet Core
- Testado funcionando

## Dia 14
- Ajustado formulario
- Utilizado Try-Catch para possiveis erros para quando for exluir mostrar msg
- Confirmando com usuario o cancelamento
- Abaixo Codigo e imagem codigo
```csharp
private void btnExcluir_Click(object sender, EventArgs e)
{
    try
    {
        int indice = lista.SelectedIndex;

        // Verificar se algum item está selecionado
        if (indice >= 0)
        {
            // Exibir mensagem de confirmação
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta empresa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar resposta do usuário
            if (resultado == DialogResult.Yes)
            {
                listaEmpresa.RemoveAt(indice);
                Listar();
            }
        }
        else
        {
            MessageBox.Show("Selecione uma empresa para excluir.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Ocorreu um erro: {ex.Message}");
    }
}
```
 
![Captura de tela 2025-01-22 153316](https://github.com/user-attachments/assets/ec24dcf3-aba5-40e2-96f3-b0aac6a149c6)

![Captura de tela 2025-01-22 153817](https://github.com/user-attachments/assets/51721841-ca7f-4740-a3f7-ef3aaf837383)

## Dia 15
- Inserindo Update
- Atualizado com Try-Catch para tratar possiveis erros
  <br>
  ![Captura de tela 2025-01-23 134806](https://github.com/user-attachments/assets/0be5abcc-6d37-41d0-b605-a9baedfc0f90)

## Dia 16
- Melhorado Performace codigo crud
- Organizado para melhorar manutenção
- Segurança uso parametros sql minimiza invasão


  
## 🔗 Links Úteis

- [Meu LinkedIn](https://www.linkedin.com/in/valdemar-teider-5336b394/)
- [Meu GitHub](https://github.com/1985Valdemar)

## Este registro diário demonstra um compromisso contínuo com a aprendizagem e a aplicação prática dos conceitos em C#. O desafio não apenas melhora as habilidades técnicas, mas também promove uma disciplina valiosa na programação.

