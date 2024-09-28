# API de Pagamentos Bancários com Suporte a PIX

Este é um projeto de API RESTful de pagamentos bancários, implementado com .NET 6 e Entity Framework Core. Ele suporta operações de pagamento via PIX, incluindo a criação de transações, gerenciamento de chaves PIX, controle de clientes, e histórico de pagamentos.

## Tecnologias Utilizadas

- **.NET 6**
- **Entity Framework Core**
- **SQL Server** (ou outro banco de dados relacional suportado pelo EF Core)
- **Serilog** para logging
- **Swagger** para documentação da API
- **Docker** (opcional) para desenvolvimento e execução em containers

## Funcionalidades

A API oferece os seguintes recursos principais:

1. **Gestão de Clientes**
    - Criar, listar e gerenciar clientes.
    
2. **Gestão de Pagamentos**
    - Processar pagamentos e visualizar histórico.
    - Realizar pagamentos via PIX.

3. **Gestão de Chaves PIX**
    - Cadastrar, listar e gerenciar chaves PIX associadas a um cliente.

4. **Transações PIX**
    - Realizar transações financeiras utilizando uma chave PIX.

## Estrutura do Projeto

O projeto segue uma arquitetura limpa e modular:

- **Domain**: Entidades de domínio que representam os modelos de dados.
- **Infrastructure**: Mapas de entidades para o Entity Framework e lógica de acesso a dados.
  - **Map**: Classes de mapeamento para as entidades utilizando `ModelBuilder`.
- **Application**: Contém os serviços da aplicação, bem como as requisições e respostas da API.
- **Presentation**: Contém os controllers e as configurações de endpoints.
  
## Modelos Principais

### Cliente

- **IdCliente**: Identificador único do cliente.
- **Nome**: Nome completo do cliente.
- **Email**: Endereço de e-mail.
- **Celular**: Número de telefone celular.
- **DataCadastro**: Data de criação do cliente.

### Pagamento

- **IdPagamento**: Identificador único do pagamento.
- **Valor**: Valor da transação.
- **Status**: Status do pagamento.
- **DataPagamento**: Data em que o pagamento foi realizado.
- **ClienteId**: Identificador do cliente associado ao pagamento.

### ChavePix

- **IdChavePix**: Identificador da chave PIX.
- **Chave**: Valor da chave PIX (e-mail, CPF, telefone, etc.).
- **TipoChave**: Tipo da chave (e.g., CPF, e-mail, telefone).
- **ClienteId**: Identificador do cliente associado à chave.

### TransacaoPix

- **IdTransacaoPix**: Identificador da transação PIX.
- **PagamentoId**: Identificador do pagamento associado.
- **ChavePixId**: Identificador da chave PIX utilizada.
- **DataTransacao**: Data da transação.
- **Status**: Status da transação.
