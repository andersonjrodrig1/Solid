#Solic Principle

Projeto criado para fins de aprendizado dos principios do S.O.L.I.D..

1- Single Responsability Principle -> tem apenas um �nico motivo para mudar, classes com responsabilidades unicas, classes com maior coes�o.

2- Open Closed Principle -> onde classes, m�dulos, fun��es, etc devem estar abertar para amplia��es e fechada para altera��es, podemos alterar o comportamento atrav�s de heran�a, inteface ou composi��o, mas n�o podemos permitir abertura para pequenas altera��es.

3- Liskov Substitution Principle -> subclasses devem ser substituidas pela classe base, classe base possa ser substituida por qualquer uma das subclasses, ter cuidado no uso da heran�a, que deve ser usada de acordo com o contexto. (Se S � um subtipo de T, ent�o os objetos do tipo T podem ser substitu�dos pelos objetos de tipo S sem que seja necess�rio alterar as propriedades deste programa)

4- Interface Segregation Principle -> muitas interfaces espec�ficas s�o melhores do que uma interface geral, trata-se de coes�o na interface, constru��o de m�dulos enxutos e pouca responsabilidade. Interfaces com muitas responsabilidades s�o dificeis de manter.

5- Dependency Inversion Principle -> devemos depender de classes abstratas e n�o de classes concretas.