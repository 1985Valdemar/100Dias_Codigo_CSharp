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
  <img src="https://github.com/user-attachments/assets/1ad1acf4-a8ac-470f-9249-79041060c203" height="500" width="800">

## Dia 7
- Otimizado codigo com Menu e Reestruturado codigo deixando mais robusto
- segue imagem codigo
 <br>
  <img src="https://github.com/user-attachments/assets/76b98291-e80a-4e52-8ea8-81d718c0fb05" height="500" width="800">

## Dia 8
- Otimizado codigo com Pasta Common para Reutilizar codigo
- Reestruturado codigo deixando mais robusto colocando cores e para otimizar
- segue imagem codigo
<br>
  <img src="https://github.com/user-attachments/assets/c7459eae-564f-41f7-ba64-56de796e19d5" height="500" width="800">

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
  <img src="https://github.com/user-attachments/assets/49a5823d-10d0-4960-8155-5db649e4edfc" height="500" width="800">

## Dia 11
- Implementado Base Model para Id
- Utilizando como Herança em Cliente para Id
- Após varias tentativas e ajustes em Cliente e Repository Funcionou
- segue imagem codigo aqui Banco dados
<br>
  <img src="https://github.com/user-attachments/assets/54bebfd2-72dc-4564-b871-63e0f4453948" height="500" width="800">
  
  <br>
- segue imagem codigo 
<br>
  <img src="https://github.com/user-attachments/assets/07d3a08d-5f44-49c0-876d-1e9a107207eb" height="500" width="800">

## Dia 12
- Criado Formulario com Form
- Testado funcionado porém tem afazer link com view
 <br>
  <img src="https://github.com/user-attachments/assets/9d481688-3dd5-4ffc-8d70-2ef0fe9bb553" height="500" width="800">

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
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta empresa?",
                                   "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
<br>
<img src="https://github.com/user-attachments/assets/ec24dcf3-aba5-40e2-96f3-b0aac6a149c6" height="500" width="800">

<br>
<img src="https://github.com/user-attachments/assets/51721841-ca7f-4740-a3f7-ef3aaf837383" height="500" width="800">

## Dia 15
- Inserindo Update
- Atualizado com Try-Catch para tratar possiveis erros
  <br>
  <img src="https://github.com/user-attachments/assets/0be5abcc-6d37-41d0-b605-a9baedfc0f90" height="500" width="800">

## Dia 16
- Melhorado Performace codigo crud
- Organizado para melhorar manutenção
- Segurança uso parametros sql minimiza invasão

## Dia 17
- Criado Projeto MVC Model View Controller
- Falta otimizar pagina para comunicar projeto

## Dia 18
- Atualizado projeto tentado reutilizar projeto já criado mas deu vários conflitos
- Tendo que iniciar do Zero mas funcionou vamos atualizando aos poucos nem todo dia Vencemos
<br>
<img src="https://github.com/user-attachments/assets/066506ce-b377-4ce5-98e6-e6adb2aa9be7" height="500" width="800">

## Dia 19
- Configurado CRUD mas nao funcionou ainda mas vai
- tive varios desafios como conlfito de atualizar mas agora estou guase la em fazer os parametro
 <br>
<img src="https://github.com/user-attachments/assets/421597b2-a776-44e8-a988-8e2c216c4503" height="500" width="800">

## Dia 20
- Tentado salvar dados mas sem sucesso
- Bora tentar novamente
  
## Dia 21
- Deu tudo errado tem rever projeto nao esta salvando dados
  
## Dia 22
- Criando Projeto novo do zero para achar erro
 <br>
<img src="https://github.com/user-attachments/assets/b6e4ab69-cd8f-4fe1-b50c-966acc6f19f2" height="500" width="800">

## Dia 22
- Criando Projeto MVC mas ainda com erro

## Dia 24
- Criando Projeto novo do zero para achar erro
- Usando por fora em postgres

## Dia 25
- Configurado Projeto novo
- Usando por fora em postgres
- Funcionou Huruuuuuuu
- Agora verificar erro que esta dando docker
 <br>
<img src="https://github.com/user-attachments/assets/e738781e-51e9-434c-9795-d22ca31fc95e" height="500" width="800">
 <br>
<img src="https://github.com/user-attachments/assets/476d9f5c-f36e-40cd-8349-4f42dd235c77" height="500" width="800">

## Dia 26
- Configurado Projeto com Editar e Deletar
- Otimizado deletar para ter interação de confirmação de exclusão 
- Realizado testes de Adicionar, editar e Deletar do Banco
 <br>
<img src="https://github.com/user-attachments/assets/6d5da473-dc6e-43a0-a01b-44a7f292c28a" height="500" width="800">
 <br>
<img src="https://github.com/user-attachments/assets/c21cf294-011b-447a-8d15-4393ce81ad46" height="500" width="800">

## Dia 27
- Configurado MVC para não habilitar o Contêiner no docker
- Testado e configurado
- Realizado testes de Adicionar, editar e Deletar do Banco do docker
 <br>
  Não Habilitando Contêiner Modo simples
<img src="https://github.com/user-attachments/assets/d5e77d71-1f39-4d8f-961a-77cdf9b9b40d" height="500" width="800">

 <br>
 Modo Habilitado Conteiner mais complexo
<img src="https://github.com/user-attachments/assets/7052413a-a323-4c28-a3ad-358e029ff352" height="500" width="800">

## Dia 28
- Praticado Docker dentro Docker
- Iniciado pratica CRM como fazer

## Dia 29
- Estilizar página CRM: Isso é importante para a experiência do usuário. Use frameworks como Bootstrap ou Tailwind CSS para agilizar o processo.
- Faltou interação e regras de negócios: Este é o ponto chave! A estilização é superficial sem a lógica por trás.
- Faltou requisitos para prosseguir: Sem requisitos claros, você estará "atirando no escuro".
 <br>
<img src="https://github.com/user-attachments/assets/41b8b5f4-3c24-4696-bd63-ffeaf684cf77" height="500" width="800">


## 🔗 Links Úteis

- [Meu LinkedIn](https://www.linkedin.com/in/valdemar-teider-5336b394/)
- [Meu GitHub](https://github.com/1985Valdemar)

## Este registro diário demonstra um compromisso contínuo com a aprendizagem e a aplicação prática dos conceitos em C#. O desafio não apenas melhora as habilidades técnicas, mas também promove uma disciplina valiosa na programação.

