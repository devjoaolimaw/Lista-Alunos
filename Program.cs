using System.Threading.Channels;
using Propriedadesaula.Models;

Pessoa p1 = new Pessoa(nome: "Joao", sobrenome: "Brito", idade: 25);
Pessoa p2 = new Pessoa(nome: "Alan", sobrenome: "Neves", idade: 23);


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Espanhol";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





















// Pessoa p1 = new Pessoa();
// p1.Nome = "Joao";
// p1.Sobrenome = "Paulo";
// p1.Idade = 18;  
// p1.Apresentar();