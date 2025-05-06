# positivo-kelvin-breno
Atividades 

Integrantes: Kelvin Matheus Lopes Cardoso / Breno Andrade da Silva

<!-- Atividade 1 -->
 valida se a senha é forte, verificando se possui pelo menos 8 caracteres, uma letra maiúscula, um número e um caractere especial. Usando Regex, ele testa cada critério e, ao final, informa se a senha é forte ou aponta o que está faltando.

 <!-- Atividade 2 -->
O código pede um número ao usuário, converte para inteiro e usa um laço for para multiplicá-lo de 1 a 10 e repetir a multiplicação usando um contador (i) e exibir cada linha da tabuada com Console.WriteLine. O código define o contador até 10.

<!-- Atividade 3 -->
O código pede ao usuário um número inteiro e calcula seu fatorial. Primeiro, usa um if para verificar se o número é negativo se for, exibe uma mensagem e encerra. Em seguida, utiliza um while que repete a multiplicação do número por seus antecessores até 1, armazenando o resultado em fatorial.

<!-- Atividade 4  -->
O código é um conversor de temperaturas que usa um laço while para manter o menu funcionando até o usuário escolher a opção de sair. A lógica do switch define o que fazer com base na escolha do usuário: converter Celsius para Fahrenheit, Fahrenheit para Celsius ou encerrar o programa. Se a opção for inválida, exibe uma mensagem de erro.

<!-- Atividade 5 -->
O código lê uma frase, converte tudo para minúsculo com ToLower() e remove os espaços com Replace(). Em seguida, a string é convertida em um array de caracteres usando char[] textoArray = texto.ToCharArray();, que permite manipular cada letra individualmente. Esse array é invertido com Array.Reverse() e transformado de volta em string. No final, o programa compara o texto original com o invertido para verificar se são iguais. Se forem, é um palíndromo senão, não é.

<!-- Atividade 6 -->
O código cria a classe Produto com nome, preço e quantidade, além de um método que calcula o valor total (preço × quantidade). No Main, um vetor armazena 3 produtos. Um for coleta os dados do usuário e outro exibe as informações e o valor total de cada item. A lógica usa entrada de dados, laço for e multiplicação para calcular o valor em estoque.

<!-- Atividade 7 -->
O código pede 10 números ao usuário, armazena em um array e soma apenas os pares. A lógica usa um for para ler os valores e, dentro do laço, verifica se o número é par com num % 2 == 0. Se for, ele é somado à variável somaPares, e no final o resultado é exibido na tela.

<!-- Atividade 8 -->
O código em C# pede o peso e a altura do usuário, calcula o IMC com a fórmula peso / (altura * altura) e exibe o valor com duas casas decimais. Em seguida, usa if-else para classificar o IMC como "Abaixo do peso", "Peso normal", "Sobrepeso" ou "Obesidade", de acordo com o valor calculado. O valor da altura deve ser digitado com uma casa decimal.

<!-- Atividade 9 -->
O programa gera um número aleatório entre 1 e 100 usando Random.Next(1, 101). Depois, entra em um laço do-while onde o usuário tenta adivinhar. A cada tentativa, ele informa se o número secreto é maior ou menor do que o digitado, até acertar. O número de tentativas é contado com a variável tentativas.

<!-- Atividade 10 -->
O código implementa uma lista de tarefas simples, organizada dentro da classe Program, que contém o método Main. O método Main é do tipo static void, ou seja, não retorna valor e pode ser executado sem instanciar a classe. Nele, são criadas duas listas: List<string> para armazenar as tarefas e List<bool>, utilizando a biblioteca System.Collections.Generic para marcar se cada tarefa foi concluída, mantendo a correspondência pelos índices. Um laço while exibe um menu com quatro opções: adicionar tarefa, marcar como concluída, listar tarefas ou sair. O usuário interage digitando a opção desejada, e o programa usa estruturas if para tomar decisões com base na escolha. O uso de OOP com a classe Program facilita a organização e futuras expansões, como transformar tarefas em objetos com propriedades (por exemplo, Tarefa.Nome, Tarefa.Concluida). O while foi escolhido no lugar do switch por permitir repetição contínua do menu até o usuário optar por sair, garantindo um ciclo interativo. O sistema, embora simples, é funcional para praticar conceitos de listas, controle de fluxo e entrada de dados no console.