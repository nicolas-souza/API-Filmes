# API-Filmes
Esta API foi construída após assistir ao curso da Alura, e é um projeto que faz parte da trilha ASP.NET, o objetivo de refazer o projeto foi consolidar os conhecimentos adquiridos. Neste README continuarei perseguindo o objetivo de aprender e portanto estarei explicando o que foi utilizado e o motivo de ter sido utilizado, então vamos lá! 

# Introdução

As três estruturas fundamentais de uma API construída com ASP.NET estão nas pastas Model, Controller e Data. 

Nosso controller é o cérebro da nossa API, é ele quem recebe as requisições e através dos verbos HTTPS, realiza a devida operação. Para realizar os retornos utilizamos o IActionResult, que fornece uma série de métodos que padronizam os códigos HTTP. Exemplo: Ok(), retorna um http code = 200, indicando sucesso.

Um *model* nada mais é do que uma representação de uma entidade, ou seja, um objeto que representa o que estamos armazenando no banco de dados.  Neste projeto nosso model Filme, possui os campos Id, Titulo, Duracao, Diretor, Genero. Foi utilizado estruturas de DataAnnotations para validar os campos vindos do cliente.

Nosso banco de dados é a parte nova nesse processo de criação de API com ASP, obviamente que pra mim. No primeiro projeto, as consultas ao banco foram realizadas "manualmente", informando explicitamente qual instrução sql eu gostaria de executar. Neste projeto no entanto foi utilizado o Entity Framework e tudo ficou muito mais simples.

Utilizando o Entity Framework (EF), eu não precisei acessar o Microsoft SQL Server Management Studio para nada, tudo foi realizado diretamente pelo Visual Studio, de uma maneira programática. 

<aside>
📢 O código deste repositório está excessivamente comentado, totalmente fora do Clean Code, mas o objetivo aqui era de estudo então achei importante comentar tudo o que eu havia entendido como fonte de pequisa no futuro.

</aside>
