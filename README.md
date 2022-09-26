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

## Evento

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `Id` | `string` | Identificador único de evento |
| `Titulo` | `string` |Titulo do evento |
| `Local` | `string` | Local do evento |
| `dtHoraInicio` | `DateTime` | Data e hora - Inicio do evento |
| `dtHoraFim` | `DateTime` | Data e hora  - Fim do evento |



## PrevisaoTempo

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `Temp_min` | `Double` |Temperatura máxima esperada para o dia |
| `Temp_max` | `Double` | Temperatura mínima esperada para o dia |
| `Descrição` | `string` | Descrição do clima  |
| `Precipitacao` | `int` | Probabilidade de chuva esperada para o dia |


## ResponseEvento

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `Evento` | `Evento` |Fornece dados sobre o evento agendado |
| `PrevisaoTempo` | `PrevisaoTempo` | Fornece previsões meterológicas esperadas para o dia e o local do evento  |



## OpenWeatherMap

[OpenWeatherMap](https://openweathermap.org/api) é a API utilizada para fornecer os dados meteorológicos globais, incluindo dados meteorológicos atuais e previsões, para a agenda. Os dados fornecidos pela API retorna as informações meteorológicos previstas para o intervalo de 5 dias, contando com o dia da requisição.

[Observação]
As chances de acerto para o intervalo de um ou dois dias é de 90%. De 3 a 8 dias, declina para 60%.

## Stack utilizada

**Back-end:** C#, .Net

**Banco de Dados:** MongoDB


## Autores

- [@jpsouza-rod](https://github.com/jpsouza-rod)

