# Agenda

A agenda é uma ferramenta utilizada para marcar tarefas e organizar compromissos durante o dia. Apesar de sua simplicidade, uma Agenda pode entregar um conjunto de outras funcionalidades que agregam maior valor a ferramenta.

Com esse propósito, foi desenvolvido uma API de agenda que permiti o usuário cadastrar um evento e, com as informações cadastradas, receber informações sobre o clima naquela região de maneira antecipada.

## Requisitos

- A aplicação deve buscar um evento
- A aplicação deve exibir a lista de eventos 
- A aplicação deve adicionar um evento 
- A aplicação deve alterar um evento 
- A aplicação deve remover um evento

## Requisitos não funcionais

- A aplicação deve fazer uma unica requisição para obter os dados de previsão do tempo.
- Os dados recebidos pela API Externa devem ser atualizados diariamente.
- Os eventos devem ser ordenados por data.

## OpenWeatherMap

[OpenWeatherMap](https://openweathermap.org/api) é a API utilizada para fornecer os dados meteorológicos globais, incluindo dados meteorológicos atuais e previsões, para a agenda.

## Stack utilizada

**Back-end:** C#, .Net

**Banco de Dados:** MongoDB


## Autores

- [@jpsouza-rod](https://github.com/jpsouza-rod)

