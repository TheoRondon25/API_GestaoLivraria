# 📚 API Gestão de Livraria - Rocketseat Formation (C# .NET)

Este projeto é uma API REST simples para gestão de livros de uma livraria, desenvolvida como parte da formação em C# da Rocketseat.

---

## ✅ Funcionalidades da API

- 📖 Criar um livro  
- 📖 Listar todos os livros cadastrados  
- 📖 Buscar um livro por ID  
- 📖 Editar informações de um livro  
- 📖 Excluir um livro  

> ⚠️ **Observação importante:**  
Esta API **não possui banco de dados**, os dados são armazenados apenas **em memória (RAM)** e serão perdidos a cada vez que a aplicação for reiniciada.

---

## ✅ Estrutura de um Livro (Modelo `Livraria`)

| Campo | Tipo | Observação |
|---|---|---|
| `Id` | int | Gerado automaticamente pela API (autoincremento) |
| `Titulo` | string | Título do livro |
| `Autor` | string | Nome do autor |
| `Genero` | string | Exemplo: Ficção, Romance, Mistério |
| `Preco` | decimal | Preço do livro |
| `QuantidadeEstoque` | int | Quantidade disponível em estoque |

---

## ✅ Endpoints disponíveis

| Método | Rota | Descrição |
|---|---|---|
| `POST` | `/api/Livraria` | Criar um novo livro |
| `GET` | `/api/Livraria` | Listar todos os livros |
| `GET` | `/api/Livraria/{id}` | Obter detalhes de um livro pelo ID |
| `PUT` | `/api/Livraria/{id}` | Atualizar um livro existente |
| `DELETE` | `/api/Livraria/{id}` | Remover um livro |

---

## ✅ Como executar o projeto localmente

1. Clone o repositório:

```bash
git clone https://github.com/TheoRondon25/API_GestaoLivraria.git
```

2. Navegue até a pasta do projeto:

```bash
cd API_GestaoLivraria
```

3. Rode o projeto:

```bash
dotnet run
```

4. Acesse a documentação Swagger:

```
https://localhost:5001/swagger
```

---

## ✅ Tecnologias utilizadas

- .NET 8
- ASP.NET Core Web API
- Swagger (Swashbuckle)

---

## ✅ Melhorias futuras

- ✅ Implementar persistência com banco de dados (ex: SQL Server ou PostgreSQL)
- ✅ Criar DTOs para melhor separação entre models e requisições
- ✅ Adicionar validações de entrada
- ✅ Implementar testes unitários

---

## ✅ Autor

- **Theo Rondon**
- Projeto de estudo - Formação C# Rocketseat 🚀
