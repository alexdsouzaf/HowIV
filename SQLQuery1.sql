CREATE TABLE produto (
  ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
  NOME varchar(45) NOT NULL,
  OBS varchar(45) DEFAULT NULL,
  QUANTIDADE int NOT NULL,
  DATA_CADASTRO datetime NOT NULL,
  VAL_UN float NOT NULL DEFAULT '0',
  VINCULO_ESTOQUE int NOT NULL DEFAULT '1',
)

use db_teste
select * from produto