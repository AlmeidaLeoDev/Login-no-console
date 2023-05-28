# Login no console

Aqui está uma explicação passo a passo do funcionamento do programa:

* O programa está dentro do namespace ProjetoLoginConsole.
* A classe principal é Program, que é definida como internal (acessível apenas dentro do assembly atual).
* O método principal Main é onde a execução do programa começa.
* O programa está em um loop while (true) para que continue a solicitar as informações de login até que um usuário seja autenticado com sucesso ou o programa seja encerrado manualmente.
*Dentro do loop, é solicitado ao usuário que digite o nome do usuário usando Console.WriteLine("Digite o nome do seu usuário:") e, em seguida, lê a entrada do usuário usando Console.ReadLine(), armazenando-a na variável usuario.
*Em seguida, é solicitado ao usuário que digite a senha usando Console.WriteLine("Digite a sua senha:").
*Um segundo loop while (true) é iniciado para ler cada tecla digitada pelo usuário sem exibi-las no console.
*Dentro desse loop, Console.ReadKey(true) é usado para ler uma tecla pressionada pelo usuário, passando true para ocultar o caractere digitado.
*Se a tecla pressionada for a tecla Enter (representada por ConsoleKey.Enter), o loop interno é interrompido usando o comando break.
*Caso contrário, o caractere digitado é concatenado à variável senha.
*Após a saída do loop interno, o programa verifica se o usuario é igual a "Leonardo" e a senha é igual a "1234".
*Se a condição for verdadeira, exibe "Usuário logado com sucesso" e sai do loop principal usando break.
*Caso contrário, exibe "Usuário ou senha incorreto", aguarda uma tecla ser pressionada usando Console.ReadKey(), limpa o console com Console.Clear() e continua para a próxima iteração do loop principal.
*Após o loop principal ser interrompido, exibe "Pressione qualquer tecla para sair" e aguarda uma tecla ser pressionada antes de finalizar a execução do programa.
