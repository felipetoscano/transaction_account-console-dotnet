# transaction-account
Projeto em C# que realiza algumas operações em uma conta bancária, utilizando o Design Pattern State

Neste exemplo, precisamos observar o estado da conta bancária para realizar as operações de depósito e saque. Por exemplo, caso o saldo esteja "Negative", o cliente não poderá realizar saques. 

Implementar essa regra dentro da conta acarretaria um grande número de "ifs" e alto grau de complexidade para controlar cada um dos estados.

Utilizando o padrão State, podemos passar essa responsabilidade para cada um destes estados, criando uma classe para cada um, onde concentrará a sua respectiva regra. Isso contribui para a resolução do problema acima.

