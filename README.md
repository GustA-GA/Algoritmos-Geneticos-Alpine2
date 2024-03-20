# Desenv-Analise-RNA-Adaline 

Projeto desenvolvido durante o curso de bacharelado em engenharia de computação, apelidado de NeuroGM, onde foi proposto conceber uma rede neural artificial Adaline personalizada com o propósito de efetuar a classificação entre comprimentos de cabelo com o tamanho de sapato para homens e mulheres, dentre os parâmetros de entrada que servem como referência para o aprendizado. 

O código resultante foi desenvolvido em C#, utilizando a plataforma WindowsForm e o ambiente de desenvolvimento Microsoft Visual Studio. A implementação buscou incorporar o mecanismo de adaptação por meio do algoritmo Widrow-Hoff, tal como descrito na apostila de Redes Neurais Artificiais "Introdução e Principais Conceitos" de Carlos Roberto Minussi e Anna Diva Plasencia Lotufo (Ilha Solteira – SP, maio-2008). Essa implementação foi, então, comparada ao desempenho da rede neural Adaline previamente apresentada no documento intitulado "NeuroFURG: uma ferramenta de apoio ao ensino de Redes Neurais Artificiais", de Carlos Alberto B. C. W. Madsen e Diana F. Adamatti (Rio Grande do Sul - RS - Brasil)


| Tela do projeto desenvolvido | Parâmetros de entrada analisados |
|-----------------------|-----------------------|
| ![Tela do projeto](https://github.com/GustA-GA/Algoritmos-Geneticos-Alpine2/assets/164023591/2134670b-8532-4ffc-b877-63e5c9e61618) | ![Casos Iniciais](https://github.com/GustA-GA/Algoritmos-Geneticos-Alpine2/assets/164023591/181cf599-4a80-4e88-8368-71fa5f67ff1f) |


Esse código personalizado permite a configuração e análise de diversos parâmetros essenciais, como pesos, bias, taxa de aprendizagem, número de gerações, quantidade de treinamentos da RNA, pesos finais e parâmetros relativos à função de ativação. A comparação entre o código original e a implementação desenvolvida se baseia no critério da convergência, considerando a variação de todos os mencionados parâmetros para uma avaliação abrangente do desempenho.

Foi concluído que a principal diferença entre os algoritmos Adaline e Widrow-Hoff é sua capacidade de lidar com padrões não lineares. Enquanto o Adaline se limita a aprender relações lineares, o Widrow-Hoff pode capturar relações não lineares usando funções de ativação adequadas. Além disso, o Adaline é mais útil em problemas de regressão linear, onde a saída desejada é uma combinação linear das entradas, enquanto o Widrow-Hoff é preferível para problemas de classificação e regressão não lineares, onde as relações entre as variáveis de entrada e saída são complexas e não lineares. Por fim, o algoritmo Widrow-Hoff pode demorar mais para convergir devido à sua natureza não linear, enquanto o Adaline tende a convergir mais rapidamente em problemas lineares.

O projeto foi entregue e desenvolvido em conjunto com a colega de turma Manoela Alvares de Abreu Oliveira
