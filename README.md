# grpc-service
Usando gRPC, Google Remote Procedure Call, para comunicação eficiente entre aplicações cliente e servidor com C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como usar o framework gRPC, Google Remote Procedure Call, para comunicação eficiente entre aplicações cliente e servidor com C#.

O gRPC é uma estrutura de comunicação de código aberto desenvolvida pelo Google, que permite a comunicação eficiente e de alto desempenho entre serviços distribuídos, utilizando o protocolo HTTP/2 para a comunicação bidirecional e o Protocol Buffers (protobuf) para a serialização de dados.

**Protocol Buffers (protobuf):** O protobuf é uma linguagem de descrição de interface e um sistema de serialização de dados desenvolvido pelo Google. Ele é usado para definir a estrutura dos dados que serão transmitidos entre o cliente e o servidor em um formato compacto e eficiente.

**Serviços e Métodos:** No gRPC, você define serviços e métodos de serviço em arquivos protobuf. Um serviço é uma coleção de métodos RPC (Remote Procedure Call) que podem ser chamados remotamente pelo cliente. Cada método do serviço é definido com um nome, tipo de solicitação e tipo de resposta.

**Cliente e Servidor:** No gRPC, o cliente e o servidor são responsáveis por enviar e receber chamadas RPC. O servidor expõe um ou mais serviços que o cliente pode chamar, enquanto o cliente faz solicitações para invocar métodos em serviços remotos.

**Streaming:** O gRPC suporta streaming de dados bidirecional, onde tanto o cliente quanto o servidor podem enviar e receber fluxos de dados de forma assíncrona. Isso é útil para cenários em que você precisa transmitir grandes quantidades de dados de forma eficiente ou manter uma conexão persistente entre o cliente e o servidor.

**Código Gerado:** O gRPC gera automaticamente código cliente e servidor a partir dos arquivos protobuf, permitindo que você se concentre na lógica de negócios do seu aplicativo em vez de lidar com a comunicação de baixo nível.

<div align="center">
    <img src="https://github.com/jfs-dev/grpc-service/assets/54154628/a9f484b0-c088-4dfe-9a5d-fa221bfb3096"</img>
    <img src="https://github.com/jfs-dev/grpc-service/assets/54154628/bdc92a60-cd38-4c17-aafd-2b37dd40b52a"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/aspnet/core/grpc/basics?view=aspnetcore-9.0/

https://grpc.io/

## Licença
GPL-3.0 license
