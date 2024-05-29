# Lista-Alunos

**Documentação do Código:**

**Classes:**

1. **Curso**
   - Descrição: Representa um curso com um nome e uma lista de alunos matriculados.
   - Métodos:
     - `AdicionarAluno(Pessoa aluno)`: Adiciona um aluno à lista de alunos matriculados no curso.
     - `ObterQuantidadeDeAlunosMatriculados()`: Retorna a quantidade de alunos matriculados no curso.
     - `RemoverAlunos(Pessoa aluno)`: Remove um aluno da lista de alunos matriculados no curso.
     - `ListarAlunos()`: Lista os nomes completos de todos os alunos matriculados no curso.

2. **Pessoa**
   - Descrição: Representa uma pessoa com um nome, sobrenome e idade.
   - Métodos:
     - `Apresentar()`: Apresenta o nome completo e a idade da pessoa.

**Usos:**

1. **Instanciação de Pessoas:**
   ```csharp
   Pessoa p1 = new Pessoa(nome: "Joao", sobrenome: "Brito", idade: 25);
   Pessoa p2 = new Pessoa(nome: "Alan", sobrenome: "Neves", idade: 23);
   ```
   - Duas instâncias de Pessoa são criadas com nomes, sobrenomes e idades específicos.

2. **Instanciação de Curso:**
   ```csharp
   Curso cursoDeIngles = new Curso();
   cursoDeIngles.Nome = "Espanhol";
   cursoDeIngles.Alunos = new List<Pessoa>();
   ```
   - Uma instância de Curso é criada e inicializada com um nome "Espanhol" e uma lista vazia de alunos.

3. **Adição de Alunos ao Curso:**
   ```csharp
   cursoDeIngles.AdicionarAluno(p1);
   cursoDeIngles.AdicionarAluno(p2);
   ```
   - Os objetos `p1` e `p2` são adicionados à lista de alunos do curso `cursoDeIngles`.

4. **Listagem de Alunos Matriculados:**
   ```csharp
   cursoDeIngles.ListarAlunos();
   ```
   - Lista os nomes completos de todos os alunos matriculados no curso `cursoDeIngles`.

5. **Apresentação de uma Pessoa:**
   ```csharp
   p1.Apresentar();
   ```
   - Apresenta o nome completo e a idade da pessoa representada por `p1`.

**Considerações Adicionais:**

- Os métodos `AdicionarAluno` e `ListarAlunos` da classe `Curso` são utilizados para gerenciar os alunos matriculados no curso.
- A classe `Pessoa` encapsula informações sobre uma pessoa individual, fornecendo métodos para sua apresentação.
- São feitas validações simples nos setters das propriedades `Nome` e `Idade` da classe `Pessoa` para garantir que valores inválidos não sejam atribuídos.
