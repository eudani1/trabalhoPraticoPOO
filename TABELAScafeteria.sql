CREATE DATABASE cafeteria;
USE cafeteria;

CREATE TABLE cliente (
	idCliente INT PRIMARY KEY AUTO_INCREMENT,
    CPF VARCHAR(30) NOT NULL UNIQUE,
    nome VARCHAR(100) NOT NULL,
    dataCadastro DATETIME NOT NULL,
    telefone VARCHAR(50) NOT NULL,
    email VARCHAR(60) NOT NULL,
    sexo VARCHAR(50) NOT NULL
);

CREATE TABLE funcionario (
	idFuncionario INT PRIMARY KEY AUTO_INCREMENT,
    CPF VARCHAR(30) NOT NULL UNIQUE,
    nome VARCHAR(100) NOT NULL,
    dataContratacao DATETIME NOT NULL,
    salario VARCHAR(100) NOT NULL,
    telefone VARCHAR(50) NOT NULL,
    email VARCHAR(60) NOT NULL,
    sexo VARCHAR(50) NOT NULL
);

CREATE TABLE fornecedor (
	idFornecedor INT PRIMARY KEY AUTO_INCREMENT,
    CNPJ VARCHAR(40) NOT NULL UNIQUE,
    nomeFornecedor VARCHAR(150) NOT NULL,
    telefone VARCHAR(50) NOT NULL,
    email VARCHAR(60) NOT NULL
);

CREATE TABLE categoria (
	idCategoria INT PRIMARY KEY AUTO_INCREMENT,
    nomeCategoria VARCHAR(100) NOT NULL,
    descricao VARCHAR(150)
);

CREATE TABLE produto (
	idProduto INT PRIMARY KEY AUTO_INCREMENT,
    nomeProduto VARCHAR(100) NOT NULL,
    descricao VARCHAR(150),
    preco VARCHAR(100) NOT NULL,
    fk_idCategoria INT NOT NULL,
    FOREIGN KEY (fk_idCategoria) REFERENCES categoria(idCategoria) 
);

CREATE TABLE insumo (
	idInsumo INT PRIMARY KEY AUTO_INCREMENT,
    nomeInsumo VARCHAR(100) NOT NULL,
    descricao VARCHAR(150),
    unidadeMedida VARCHAR(100) NOT NULL
);

CREATE TABLE itemComprado (
	idItemComprado INT PRIMARY KEY AUTO_INCREMENT,
    dataCompra DATETIME NOT NULL,
    preco VARCHAR(100) NOT NULL,
    quantidadeComprada VARCHAR(100) NOT NULL,
    fk_idInsumo INT NOT NULL,
    fk_idFornecedor INT NOT NULL,
    FOREIGN KEY (fk_idInsumo) REFERENCES insumo (idInsumo),
    FOREIGN KEY (fk_idFornecedor) REFERENCES fornecedor (idFornecedor)
);

CREATE TABLE compoe (
		idCompoe INT PRIMARY KEY AUTO_INCREMENT,
        quantidade VARCHAR(100) NOT NULL,
        fk_idInsumo INT NOT NULL,
        fk_idProduto INT NOT NULL,
        FOREIGN KEY (fk_idInsumo) REFERENCES insumo (idInsumo),
        FOREIGN KEY (fk_idProduto) REFERENCES produto (idProduto)
);

CREATE TABLE pedido (
	idPedido INT PRIMARY KEY AUTO_INCREMENT,
    dataHora DATETIME NOT NULL,
	status VARCHAR(50) NOT NULL,
    observacao VARCHAR(200) NOT NULL,
    valorTotal VARCHAR(150) NOT NULL,
    fk_idFuncionario INT NOT NULL,
    fk_idCliente INT NOT NULL,
    FOREIGN KEY (fk_idFuncionario) REFERENCES funcionario (idFuncionario),
    FOREIGN KEY (fk_idCliente) REFERENCES cliente (idCliente)
);

CREATE TABLE itemPedido (
	idItemPedido INT PRIMARY KEY AUTO_INCREMENT,
    precoUnitario VARCHAR(100) NOT NULL,
    quantidade VARCHAR(100) NOT NULL,
    fk_idPedido INT NOT NULL,
    fk_idProduto INT NOT NULL,
    FOREIGN KEY (fk_idPedido) REFERENCES pedido (idPedido),
    FOREIGN KEY (fk_idProduto) REFERENCES produto (idProduto)
);

CREATE TABLE pagamento (
	idPagamento INT PRIMARY KEY AUTO_INCREMENT,
    valor VARCHAR(100) NOT NULL,
    status VARCHAR(50) NOT NULL,
    formaPagamento VARCHAR(100) NOT NULL,
    observacao VARCHAR(150),
    fk_idPedido INT NOT NULL,
    FOREIGN KEY (fk_idPedido) REFERENCES pedido (idPedido)
);










