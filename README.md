#Solic Principle

Projeto criado para fins de aprendizado dos principios do S.O.L.I.D..

1- Single Responsability Principle -> tem apenas um único motivo para mudar, classes com responsabilidades unicas, classes com maior coesão.

2- Open Closed Principle -> onde classes, módulos, funções, etc devem estar abertar para ampliações e fechada para alterações, podemos alterar o comportamento através de herança, inteface ou composição, mas não podemos permitir abertura para pequenas alterações.

3- Liskov Substitution Principle -> subclasses devem ser substituidas pela classe base, classe base possa ser substituida por qualquer uma das subclasses, ter cuidado no uso da herança, que deve ser usada de acordo com o contexto. (Se S é um subtipo de T, então os objetos do tipo T podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa)

4- Interface Segregation Principle -> muitas interfaces específicas são melhores do que uma interface geral, trata-se de coesão na interface, construção de módulos enxutos e pouca responsabilidade. Interfaces com muitas responsabilidades são dificeis de manter.

5- Dependency Inversion Principle -> devemos depender de classes abstratas e não de classes concretas.