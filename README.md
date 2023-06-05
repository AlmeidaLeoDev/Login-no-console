# Login no console

Aqui está uma explicação passo a passo do funcionamento do programa:

1. As diretivas using importam os namespaces necessários para o funcionamento do código, fornecendo acesso a classes e métodos relacionados.
2. O código está encapsulado dentro do namespace Cadastro_de_Usuarios, o que ajuda a organizar e evitar conflitos de nomes.
3. A classe principal é Program, declarada como internal, o que significa que ela só pode ser acessada de dentro do mesmo assembly (neste caso, o próprio projeto).
4. O método ReadPassword() é responsável por ler a senha do usuário sem exibi-la no console. Ele retorna a senha digitada pelo usuário como uma string.
5. Dentro do método ReadPassword(), temos um loop do-while que continua a executar até que o usuário pressione a tecla Enter. O loop é usado para ler os caracteres da senha.
6. key = Console.ReadKey(true); lê a próxima tecla pressionada pelo usuário, sem exibi-la no console. O parâmetro true passado para Console.ReadKey() indica que a tecla deve ser lida sem ecoar no console.
7. O bloco if verifica se a tecla pressionada pelo usuário não é a tecla Backspace nem a tecla Enter. Se não for, significa que o usuário digitou um caractere válido da senha.
8. senhaOculta += key.KeyChar; adiciona o caractere digitado à variável senhaOculta, que armazena a senha oculta. O key.KeyChar contém o caractere digitado pelo usuário.
9. Console.Write("*"); exibe um asterisco no console para fornecer um feedback visual de que um caractere foi digitado. Como o caractere digitado não é exibido, o asterisco é usado para indicar que algo foi digitado.
10. O bloco else é executado quando o usuário pressiona a tecla Backspace. Ele verifica se a tecla é Backspace e se a senha oculta já possui caracteres digitados. Se essas condições forem verdadeiras, significa que o usuário deseja apagar o último caractere digitado.
11. senhaOculta = senhaOculta.Remove(senhaOculta.Length - 1); remove o último caractere da senha oculta usando o método Remove da classe string. O senhaOculta.Length - 1 especifica o índice do último caractere na senha oculta.
12. Console.Write("\b\b"); exibe uma sequência de caracteres de retrocesso (\b\b) no console, simulando a exclusão do último caractere digitado, movendo o cursor de volta e substituindo o caractere apagado por um espaço em branco.
13. Após o loop, quando o usuário pressiona a tecla Enter, a execução do método ReadPassword() é concluída.
14. O método Main() é o ponto de entrada do programa. Ele é chamado quando o programa é iniciado.
15. Dentro do método Main(), temos um loop do-while que permite que o usuário faça o cadastro ou saia do programa. O loop continua até que o usuário escolha a opção "s" para sair.
16. opcao = Console.ReadKey(true).Key.ToString().ToLower(); lê a próxima tecla pressionada pelo usuário, sem exibi-la no console. O método Console.ReadKey(true) retorna uma instância de ConsoleKeyInfo, e Key contém a tecla pressionada pelo usuário. O método ToString().ToLower() converte a tecla para uma string em minúsculas.
17. O bloco if verifica se o usuário escolheu a opção "c" para cadastrar um novo usuário.
18. Se o usuário escolher "c", o programa solicita o nome de usuário e a senha usando Console.ReadLine(). O método ReadPassword() é chamado para ler a senha ocultamente.
19. Após o cadastro bem-sucedido, uma mensagem é exibida no console, e Console.Clear() é usado para limpar o console.
20. Se o usuário escolher "s", uma mensagem é exibida informando que o programa está sendo encerrado.
21. Se o usuário escolher uma opção diferente de "c" ou "s", uma mensagem de "Opção desconhecida" é exibida.
22. Após o loop, quando o usuário escolhe a opção "s" para sair, uma mensagem é exibida e o programa aguarda que o usuário pressione qualquer tecla para encerrar.
