# Repository Pattern, Dependency Injection, Fake Repository

#### Repository Pattern é um padrão de projeto muito interessante, que visa centralizar em repositories todo o acesso a dados da aplicação(SPOF), facilitando assim novas implementações e/ou manutenções.

#### Dependency Injection é um padrão de projeto que implementa IOC(inversão de controle), e visa diminuir o nível de acoplamento entre diferentes módulos no sistema. Na prática a injeção de dependência cuida das dependências entre objetos injetando-as por parâmetro via construtor da classe.

#### Fake Repository são implementações falsas dos nossos repositórios, visando facilitar a testabilidade do código, principalmente nos testes de unidade.

#### Estes padrões de projeto podem ser implementados em diversos tipos de linguagens de programação.

Neste exemplo te mostro uma forma de implementar o padrão de projeto Repository em C#, e também como você pode utilizar a injeção de dependências para injetar teus repositórios através do gerenciador de dependências do ASP.NET Core e de quebra também te mostro como você pode criar repositórios falsos para os teus testes de unidade.

Link do vídeo no YouTube: https://youtu.be/qktnwPRiM8A 🍿
