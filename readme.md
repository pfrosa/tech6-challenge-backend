# Instruções
Para subir esse backend é necessario antes ter um banco para persistir os dados, durante o desenvolvimento foi usado um banco local postgresql.
A string de conexão pode ser encontrada e alterada em `appsettings.json` de modo com que seja posivel conectar ao banco.
Apos isso é necessario rodar as migrações do banco atraves do comando `dotnet ef database update`, e por fim basta executar `dotnet run` na raiz do projeto