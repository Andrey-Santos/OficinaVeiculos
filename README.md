# OficinaVeiculos

Projeto simples de gestão de ordens de serviço para uma oficina de veículos, desenvolvido em C#.

## Funcionalidades
- Cadastro de ordens de serviço com descrição e valor
- Controle de status da ordem (Aberta, Em Andamento, Concluída, Cancelada)
- Registro da data de criação da ordem
- Aplicação de desconto percentual ao valor da ordem
- Alteração do status da ordem

## Estrutura do Projeto
- `OficinaVeiculos/OrdemServico.cs`: Classe principal com as regras de negócio
- `OficinaVeiculos.Tests/OrdemServicoTests.cs`: Testes unitários utilizando xUnit

## Como Executar
1. **Requisitos:**
   - .NET 9.0 SDK ou superior
2. **Restaurar dependências:**
   ```sh
   dotnet restore
   ```
3. **Executar os testes:**
   ```sh
   dotnet test
   ```

## Exemplos de Uso
```csharp
var ordem = new OrdemServico("Troca de óleo", 100);
ordem.AplicarDesconto(10); // Valor passa a ser 90
ordem.AlterarStatus(StatusOrdemServico.Concluida);
```

## Testes
Os testes cobrem:
- Criação da ordem
- Status inicial e alteração de status
- Data de criação
- Aplicação de desconto e validação de valores inválidos

---

Desenvolvido para fins didáticos.
