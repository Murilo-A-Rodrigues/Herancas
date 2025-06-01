# Problemas de Programação Orientada a Objetos (Associações e Herança)

Este é um projeto desenvolvido na matéria de Programação Orientada a Objetos. Ele utiliza a linguagem de programação C# para resolver vários problemas utilizando de Associações e Herança.

## Projetos e Funcionalidades

## Projetos e Funcionalidades

### 1. **Biblioteca**
- Cadastro de livros, leitores e empréstimos.
- Associação entre leitor e livro via empréstimo.
- Controle de empréstimo e devolução de livros.

### 2. **Cadastro Escolar**
- Cadastro de alunos, professores e funcionários.
- Herança: Pessoa como superclasse, subclasses com atributos e métodos próprios.
- Polimorfismo para exibição de dados.

### 3. **Cursos**
- Cadastro de cursos, alunos e matrículas.
- Associação muitos-para-muitos entre alunos e cursos via matrícula.
- Controle de matrículas e histórico de cursos/alunos.

### 4. **Pet Shop**
- Cadastro de animais (Cachorro, Gato, Pássaro) e donos.
- Herança: Animal como superclasse, subclasses com atributos específicos.
- Serviços específicos para cada espécie.
- Exibição polimórfica dos serviços disponíveis.

### 5. **Vendas**
- Cadastro de produtos, pedidos e itens de pedido.
- Composição: Pedido contém itens, item referencia produto.
- Cálculo automático do total do pedido.
- Menu interativo para registrar vendas e cadastrar produtos.

### 6. **Veículos**
- Cadastro de veículos e manutenções.
- Associação um-para-muitos entre veículo e manutenção.
- Validação para impedir manutenções duplicadas na mesma data.

### 7. **Recrutamento**
- Cadastro de vagas, candidatos e candidaturas.
- Associação muitos-para-muitos via classe intermediária (Candidatura).
- Consulta de vagas por candidato e candidatos por vaga.

### 8. **Streaming**
- Cadastro de mídias: filmes, séries (com episódios) e documentários.
- Herança: Midia como superclasse, subclasses com atributos específicos.
- Composição: Série contém episódios.
- Exibição polimórfica de resumos.
  
### 9. **Controle de Treinos**
- Cadastro de alunos, treinos e exercícios.
- Composição: Treino contém exercícios.
- Edição dos detalhes dos exercícios (séries, repetições, peso).
- Cálculo da carga total do treino.

### 9. **Streaming**
- Cadastro de mídias: filmes, séries (com episódios) e documentários.
- Herança: Midia como superclasse, subclasses com atributos específicos.
- Composição: Série contém episódios.
- Exibição polimórfica de resumos.

### 10. **Eventos Culturais**
- Cadastro de eventos (Oficina, Palestra, Show) e participantes.
- Herança: Evento como superclasse, subclasses com atributos específicos.
- Polimorfismo para exibição de informações.
- Associação muitos-para-muitos entre eventos e participantes.

## Como Executar

1. Certifique-se de ter o .NET SDK instalado.
2. Abra o terminal do Program do projeto desejado.
3. Execute:
```bash
   dotnet run
```

## Estrutura dos Projetos

- **Model**: Contém as classes de domínio (entidades, regras de negócio).
- **Console**: Ponto de entrada do programa, menus e interação com o usuário.

## Estratégias e Conceitos Utilizados

- **Herança e Polimorfismo**: Superclasses abstratas e métodos sobrescritos para comportamentos específicos.
- **Composição**: Objetos que só existem dentro de outros (ex: exercícios em treinos, itens em pedidos).
- **Associação Muitos-para-Muitos**: Classes intermediárias para relacionar entidades (ex: candidaturas, inscrições em eventos).
- **Encapsulamento**: Propriedades privadas e métodos públicos para manipulação segura dos dados.
- **Validação de Regras de Negócio**: Restrições implementadas nas classes de domínio (ex: limite de capacidade, datas únicas).

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).


## Créditos

Este projeto foi desenvolvido por Murilo Andre Rodrigues como parte da disciplina de Programação Orientada a Objetos.

## Contato

- **Email**: murilorodrigues@alunos.utfpr.edu.br
- **GitHub**: Murilo-A-Rodrigues(https://github.com/Murilo-A-Rodrigues)
