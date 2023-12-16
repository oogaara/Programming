using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Aluno1", sobrenome: "01");
Pessoa p2 = new Pessoa(nome: "Aluno2", sobrenome:"02");
Pessoa p3 = new Pessoa(nome: "Aluno3", sobrenome: "03");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();
