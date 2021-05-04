# APISul


### Projeto administração do prédio 99a da Tecnopuc
com 16 andares e cinco elevadores, denominados A, B, C, D e E, nos convidou a aperfeiçoar o sistema de controle dos elevadores. Depois de realizado um levantamento no qual cada usuário respondia:
a. O elevador que utiliza com mais frequência (A, B, C, D ou E);
b. O andar ao qual se dirigia (0 a 15);
c. O período que utilizava o elevador – M: Matutino; V: Vespertino; N: Noturno.

Necessidades
Considerando que este possa evoluir para um sistema dinâmico, escreva o código que nos ajude a extrair as seguintes informações:
a. Qual é o andar menos utilizado pelos usuários;
b. Qual é o elevador mais frequentado e o período que se encontra maior fluxo;
c. Qual é o elevador menos frequentado e o período que se encontra menor fluxo;
d. Qual o período de maior utilização do conjunto de elevadores;
e. Qual o percentual de uso de cada elevador com relação a todos os serviços prestados;

Deve ser programado em Java ou C#.
Para a realização do exercício você deve implementar a interface IElevadorService.
Faça a leitura do arquivo input.json para ter acesso às entradas.


Projeto foi estruturado em 5 camadas separadas

- **Domains**
Camada responsavel pelos objetos da classe.

- **Service**
Camada responsavel pelas Interface.

- **BusinessRule**
Camada responsavel pelas regras de negócio.

- **WebApi**
Camada do serviço Rest API.

- **Angular 10**
Front-End do projeto.

## tecnologias utilizadas
- .Net Core 3.1.114
- Angular 10

Tecnologias necessárias instaladas no computador
- dotnet = https://dotnet.microsoft.com/download
- nodejs = https://nodejs.org/en/
- angular cli = npm install -g @angular/cli

Como rodar projeto:
1) Em APISul.WebApi executar comando : **dotnet run**
2) Em APISul.Angular executar comando :  **ng serve -o**
3) Abrir navegador **http://localhost:4200/**

<img src="https://github.com/davidsretzlaff/APISul/blob/master/APISul/Capturar.PNG?raw=true" alt="My cool logo"/>

