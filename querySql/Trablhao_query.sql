DROP SCHEMA IF EXISTS centro_loca_mais;
CREATE SCHEMA IF NOT EXISTS  centro_loca_mais;
USE centro_loca_mais;

CREATE TABLE IF NOT EXISTS cliente(
	id BIGINT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
	cpf VARCHAR(11) UNIQUE NOT NULL,
    nome VARCHAR(50) NOT NULL,
    sobrenome VARCHAR(75) NOT NULL,
    email VARCHAR(100) UNIQUE NULL, 
    telefone_residencial VARCHAR(15),
    celular VARCHAR(15) NOT NULL
);

CREATE TABLE IF NOT EXISTS endereco(
	id BIGINT UNIQUE NOT NULL PRIMARY KEY AUTO_INCREMENT,
    cliente_id BIGINT UNIQUE NOT NULL,
    rua varchar(50) NOT  NULL,
    numero INT NOT NULL,
    complemento VARCHAR(50),
    bairro varchar(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    
    FOREIGN KEY(cliente_id) REFERENCES cliente(id)
);

 CREATE TABLE IF NOT EXISTS carro_fabricante(
	id BIGINT NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,
    nome_fabricante VARCHAR(100) NOT NULL UNIQUE
 );
 CREATE TABLE IF NOT EXISTS carro_categoria(
	id BIGINT NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,
    categoria_nome VARCHAR(50) NOT NULL
 );

CREATE TABLE IF NOT EXISTS carro(
	id BIGINT UNIQUE NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    placa CHAR(7) UNIQUE NOT NULL,
    kilometragem INT NOT NULL,
    ano_fabricacao DATE NOT NULL,
    id_carro_fabricante BIGINT NOT NULL,
    id_carro_categoria BIGINT NOT NULL,
    valor_locacao DECIMAL(10,2),
    
    FOREIGN KEY(id_carro_fabricante) REFERENCES carro_fabricante(id),
    FOREIGN KEY(id_carro_categoria) REFERENCES carro_categoria(id)
);

CREATE TABLE IF NOT EXISTS registro_locacao(
    cliente_id BIGINT UNIQUE NOT NULL,
    carro_id BIGINT UNIQUE NOT NULL,
    
    FOREIGN KEY(cliente_id) REFERENCES cliente(id),
    FOREIGN KEY(carro_id) REFERENCES carro(id)
);

CREATE TABLE IF NOT EXISTS historiso_locacao(
	id BIGINT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    cliente_id BIGINT UNIQUE NOT NULL,
    carro_id BIGINT UNIQUE NOT NULL,
    
    FOREIGN KEY(cliente_id) REFERENCES cliente(id),
    FOREIGN KEY(carro_id) REFERENCES carro(id)
);