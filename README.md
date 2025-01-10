# Teste Técnico - Projeto de Programação

Este repositório contém soluções para um conjunto de problemas de programação. O objetivo é desenvolver programas que atendem a diferentes requisitos, com foco em manipulação de dados e lógica de programação.

## Exercícios

### 1. **Soma dos Números de 1 até INDICE**
Neste exercício, o código calcula a soma dos números de 1 até um valor específico, armazenado na variável `INDICE`. A lógica percorre um intervalo de números, somando-os até alcançar o valor de `INDICE`, e ao final imprime o valor total da soma.

**Resultado Esperado:** O valor final da soma será 91 para `INDICE = 13`.

---

### 2. **Sequência de Fibonacci e Verificação de Pertinência**
Neste exercício, o programa calcula a sequência de Fibonacci e verifica se um número informado pelo usuário pertence à sequência. A sequência começa com 0 e 1, e cada número subsequente é a soma dos dois anteriores.

O programa recebe um número e calcula a sequência até que o número informado seja atingido ou ultrapassado, informando se ele pertence ou não à sequência.

---

### 3. **Cálculo de Faturamento Mensal**
Este exercício analisa o faturamento diário de uma distribuidora a partir de um arquivo JSON. O programa realiza os seguintes cálculos:
- O menor e maior valor de faturamento ocorrido em um dia.
- O número de dias no mês em que o faturamento foi superior à média mensal, desconsiderando dias sem faturamento (ex.: finais de semana e feriados).

A entrada de dados é fornecida por meio de um arquivo JSON com os valores de faturamento diário.

---

### 4. **Percentual de Representação por Estado**
O programa calcula o percentual de representação de cada estado no faturamento mensal total de uma distribuidora. Os estados considerados são SP, RJ, MG, ES e Outros, com valores pré-definidos. O código calcula a porcentagem que cada estado representa no valor total mensal.

---

### 5. **Inverter os Caracteres de uma String**
Este exercício solicita que o programa inverta os caracteres de uma string fornecida pelo usuário. A inversão é feita manualmente, sem utilizar funções prontas como `reverse`, para atender ao requisito de manipulação de dados de forma mais explícita.

---

## Tecnologias Utilizadas

- C#
- .NET (para manipulação de arquivos e JSON)
- JSON (para dados do faturamento)
