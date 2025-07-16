-- CLIENTE
INSERT INTO cliente (CPF, nome, dataCadastro, telefone, email, sexo) VALUES
('111.222.333-44', 'Ana Silva', '2023-01-15 10:00:00', '(11)98765-4321', 'ana.silva@email.com', 'Feminino'),
('222.333.444-55', 'Bruno Costa', '2023-02-20 11:30:00', '(21)99876-5432', 'bruno.costa@email.com', 'Masculino'),
('333.444.555-66', 'Carla Dias', '2023-03-05 14:00:00', '(31)97654-3210', 'carla.dias@email.com', 'Feminino'),
('444.555.666-77', 'Daniel Souza', '2023-04-10 09:15:00', '(41)96543-2109', 'daniel.souza@email.com', 'Masculino'),
('555.666.777-88', 'Eduarda Lima', '2023-05-25 16:45:00', '(51)95432-1098', 'eduarda.lima@email.com', 'Feminino'),
('666.777.888-99', 'Fernando Alves', '2023-06-01 13:20:00', '(61)94321-0987', 'fernando.alves@email.com', 'Masculino'),
('777.888.999-00', 'Gabriela Rocha', '2023-07-12 10:50:00', '(71)93210-9876', 'gabriela.rocha@email.com', 'Feminino'),
('888.999.000-11', 'Hugo Pereira', '2023-08-18 15:00:00', '(81)92109-8765', 'hugo.pereira@email.com', 'Masculino'),
('999.000.111-22', 'Isabela Santos', '2023-09-03 08:00:00', '(91)91098-7654', 'isabela.santos@email.com', 'Feminino'),
('000.111.222-33', 'João Oliveira', '2023-10-07 12:10:00', '(11)90987-6543', 'joao.oliveira@email.com', 'Masculino'),
('123.456.789-01', 'Karen Martins', '2023-11-19 17:00:00', '(21)98765-1234', 'karen.martins@email.com', 'Feminino'),
('987.654.321-09', 'Lucas Ferreira', '2023-12-01 09:40:00', '(31)97654-4321', 'lucas.ferreira@email.com', 'Masculino'),
('101.202.303-40', 'Mariana Gomes', '2024-01-08 11:00:00', '(41)96543-3210', 'mariana.gomes@email.com', 'Feminino'),
('202.303.404-50', 'Nuno Rodrigues', '2024-02-14 14:30:00', '(51)95432-2109', 'nuno.rodrigues@email.com', 'Masculino'),
('303.404.505-60', 'Olívia Castro', '2024-03-29 10:10:00', '(61)94321-1098', 'olivia.castro@email.com', 'Feminino');

select*from cliente;

-- FUNCIONÁRIO
INSERT INTO funcionario (CPF, nome, dataContratacao, salario, telefone, email, sexo) VALUES
('123.123.123-12', 'Pedro Rocha', '2022-01-10 09:00:00', '2500.00', '(11)91234-5678', 'pedro.rocha@cafeteria.com', 'Masculino'),
('234.234.234-23', 'Laura Mendes', '2022-03-15 10:00:00', '2800.00', '(21)92345-6789', 'laura.mendes@cafeteria.com', 'Feminino'),
('345.345.345-34', 'Marcos Silva', '2022-05-20 11:00:00', '3000.00', '(31)93456-7890', 'marcos.silva@cafeteria.com', 'Masculino'),
('456.456.456-45', 'Sofia Costa', '2022-07-25 12:00:00', '2600.00', '(41)94567-8901', 'sofia.costa@cafeteria.com', 'Feminino'),
('567.567.567-56', 'Thiago Lima', '2022-09-30 13:00:00', '2700.00', '(51)95678-9012', 'thiago.lima@cafeteria.com', 'Masculino'),
('678.678.678-67', 'Vitória Dias', '2022-11-05 14:00:00', '2900.00', '(61)96789-0123', 'vitoria.dias@cafeteria.com', 'Feminino'),
('789.789.789-78', 'André Santos', '2023-01-01 15:00:00', '2550.00', '(71)97890-1234', 'andre.santos@cafeteria.com', 'Masculino'),
('890.890.890-89', 'Beatriz Alves', '2023-03-08 16:00:00', '2850.00', '(81)98901-2345', 'beatriz.alves@cafeteria.com', 'Feminino'),
('901.901.901-90', 'Carlos Pereira', '2023-05-12 17:00:00', '3100.00', '(91)99012-3456', 'carlos.pereira@cafeteria.com', 'Masculino'),
('012.012.012-01', 'Diana Gomes', '2023-07-18 08:30:00', '2650.00', '(11)90123-4567', 'diana.gomes@cafeteria.com', 'Feminino'),
('100.200.300-10', 'Felipe Castro', '2023-09-22 09:30:00', '2750.00', '(21)91002-0030', 'felipe.castro@cafeteria.com', 'Masculino'),
('200.300.400-20', 'Giovana Rodrigues', '2023-11-01 10:30:00', '2950.00', '(31)92003-0040', 'giovana.rodrigues@cafeteria.com', 'Feminino'),
('300.400.500-30', 'Henrique Oliveira', '2024-01-05 11:30:00', '2600.00', '(41)93004-0050', 'henrique.oliveira@cafeteria.com', 'Masculino'),
('400.500.600-40', 'Isadora Costa', '2024-03-10 12:30:00', '2800.00', '(51)94005-0060', 'isadora.costa@cafeteria.com', 'Feminino'),
('500.600.700-50', 'Juliana Fernandes', '2024-05-15 13:30:00', '3050.00', '(61)95006-0070', 'juliana.fernandes@cafeteria.com', 'Feminino');
select*from funcionario;

-- FORNECEDOR
INSERT INTO fornecedor (CNPJ, nomeFornecedor, telefone, email) VALUES
('00.111.222/0001-00', 'Cafés Especiais Ltda.', '(11)3000-1111', 'contato@cafesespe.com'),
('01.222.333/0001-11', 'Laticínios Frescos S.A.', '(21)3111-2222', 'vendas@laticiniosfrescos.com'),
('02.333.444/0001-22', 'Padaria Gourmet Atacado', '(31)3222-3333', 'comercial@padariagourmet.com'),
('03.444.555/0001-33', 'Embalagens Sustentáveis', '(41)3333-4444', 'orcamento@embalagenssustentaveis.com'),
('04.555.666/0001-44', 'Doces Finos Brasil', '(51)3444-5555', 'pedidos@docesfinos.com'),
('05.666.777/0001-55', 'Águas Puras Distribuidora', '(61)3555-6666', 'distribuidora@aguaspuras.com'),
('06.777.888/0001-66', 'Frutas Frescas do Campo', '(71)3666-7777', 'contato@frutasfrescas.com'),
('07.888.999/0001-77', 'Limpeza Profissional', '(81)3777-8888', 'vendas@limpezaprofissional.com'),
('08.999.000/0001-88', 'Grãos Selecionados', '(91)3888-9999', 'comercial@graosselecionados.com'),
('09.000.111/0001-99', 'Refrigerantes Refrescantes', '(11)3999-0000', 'vendas@refrisrefrescantes.com'),
('10.111.222/0001-01', 'Temperos do Mundo', '(21)3001-1112', 'contato@temperosdomundo.com'),
('11.222.333/0001-02', 'Carnes Nobres Atacado', '(31)3112-2223', 'pedidos@carnesnobres.com'),
('12.333.444/0001-03', 'Vegetais Orgânicos', '(41)3223-3334', 'vendas@vegetaisorganicos.com'),
('13.444.555/0001-04', 'Utensílios de Cozinha', '(51)3334-4445', 'comercial@utensilioscozinha.com'),
('14.555.666/0001-05', 'Equipamentos para Cafeteria', '(61)3445-5556', 'vendas@equipamentoscafe.com');

select*from fornecedor;

-- CATEGORIA
INSERT INTO categoria (nomeCategoria, descricao) VALUES
('Cafés Quentes', 'Bebidas à base de café, servidas quentes.'),
('Cafés Gelados', 'Bebidas à base de café, servidas geladas.'),
('Doces', 'Bolos, tortas, cookies e outras sobremesas.'),
('Salgados', 'Sanduíches, pães de queijo, tortas salgadas.'),
('Bebidas Não Café', 'Sucos, chás, refrigerantes, água.'),
('Grãos de Café', 'Café em grãos para consumo doméstico.'),
('Acompanhamentos', 'Itens para acompanhar as bebidas e comidas.'),
('Utensílios', 'Utensílios de cozinha e serviço.'),
('Matéria-Prima', 'Ingredientes básicos para preparo.'),
('Limpeza', 'Produtos de limpeza e higiene.'),
('Laticínios', 'Leites, cremes e derivados.'),
('Frutas', 'Frutas frescas e processadas.'),
('Embalagens', 'Copos, tampas, sacolas, etc.'),
('Chás', 'Variedades de chás quentes e gelados.'),
('Bolos e Tortas', 'Categorização específica de doces maiores.');

select*from categoria;


-- PRODUTO
INSERT INTO produto (nomeProduto, descricao, preco, fk_idCategoria) VALUES
('Espresso', 'Café puro, encorpado.', '7.50', 1),
('Cappuccino', 'Espresso, leite vaporizado e espuma.', '12.00', 1),
('Latte Macchiato', 'Leite vaporizado com um toque de espresso.', '13.50', 1),
('Mocaccino', 'Cappuccino com chocolate.', '14.00', 1),
('Café Gelado', 'Café coado gelado.', '10.00', 2),
('Frappuccino Caramelo', 'Café gelado batido com caramelo e chantilly.', '18.00', 2),
('Bolo de Cenoura', 'Fatia de bolo de cenoura com cobertura de chocolate.', '15.00', 3),
('Cookie de Chocolate', 'Cookie crocante com gotas de chocolate.', '8.00', 3),
('Pão de Queijo', 'Tradicional pão de queijo.', '6.00', 4),
('Misto Quente', 'Sanduíche de queijo e presunto na chapa.', '16.00', 4),
('Suco de Laranja Natural', 'Suco fresco de laranja.', '11.00', 5),
('Água Mineral', 'Garrafa de água mineral sem gás.', '5.00', 5),
('Café em Grãos Blend da Casa 250g', 'Blend especial de grãos selecionados.', '35.00', 6),
('Chá de Hortelã', 'Chá quente de hortelã.', '9.00', 14), 
('Torta de Limão', 'Fatia de torta de limão com merengue.', '16.50', 15); 

select*from produto;

-- INSUMO
INSERT INTO insumo (nomeInsumo, descricao, unidadeMedida) VALUES
('Grão de Café Arábica', 'Café em grãos 100% Arábica.', 'Kg'),
('Leite Integral', 'Leite de vaca integral.', 'Litro'),
('Açúcar Refinado', 'Açúcar branco granulado.', 'Kg'),
('Xarope de Caramelo', 'Xarope concentrado sabor caramelo.', 'Litro'),
('Chocolate em Pó 50%', 'Chocolate em pó para bebidas.', 'Kg'),
('Farinha de Trigo', 'Farinha de trigo tipo 1.', 'Kg'),
('Ovo', 'Ovos de galinha grandes.', 'Unidade'),
('Manteiga', 'Manteiga sem sal.', 'Kg'),
('Queijo Minas Padrão', 'Queijo minas padrão para pão de queijo.', 'Kg'),
('Presunto Cozido', 'Presunto fatiado.', 'Kg'),
('Laranja', 'Laranjas frescas para suco.', 'Kg'),
('Água Filtrada', 'Água tratada para máquinas de café.', 'Litro'),
('Copo Descartável 200ml', 'Copo plástico para bebidas quentes.', 'Unidade'),
('Guardanapo de Papel', 'Guardanapos de papel brancos.', 'Pacote'),
('Limão', 'Limões frescos para torta e sucos.', 'Kg');

select*from insumo;

-- ITEM COMPRADO
INSERT INTO itemComprado (dataCompra, preco, quantidadeComprada, fk_idInsumo, fk_idFornecedor) VALUES
('2024-06-01 10:00:00', '50.00', '10', 1, 1),   
('2024-06-01 10:00:00', '4.50', '20', 2, 2),   
('2024-06-02 11:00:00', '3.00', '50', 3, 1),   
('2024-06-02 11:00:00', '25.00', '5', 4, 5),   
('2024-06-03 12:00:00', '18.00', '10', 5, 1),  
('2024-06-03 12:00:00', '5.00', '20', 6, 3),   
('2024-06-04 13:00:00', '0.80', '100', 7, 3),  
('2024-06-04 13:00:00', '22.00', '5', 8, 2),   
('2024-06-05 14:00:00', '30.00', '10', 9, 2),  
('2024-06-05 14:00:00', '28.00', '8', 10, 3),  
('2024-06-06 15:00:00', '6.00', '15', 11, 7),  
('2024-06-06 15:00:00', '0.50', '100', 12, 6), 
('2024-06-07 16:00:00', '0.20', '500', 13, 4), 
('2024-06-07 16:00:00', '10.00', '10', 14, 4), 
('2024-06-08 17:00:00', '7.00', '10', 15, 7);  

select*from itemComprado;

-- COMPÕE
INSERT INTO compoe (quantidade, fk_idInsumo, fk_idProduto) VALUES
('0.05', 1, 1), 
('0.2', 2, 2),  
('0.03', 1, 2), 
('0.25', 2, 3), 
('0.03', 1, 3), 
('0.2', 2, 4),  
('0.03', 1, 4), 
('0.02', 5, 4), 
('0.05', 1, 5), 
('0.2', 2, 6),  
('0.03', 1, 6), 
('0.05', 4, 6), 
('0.2', 6, 7),  
('2', 7, 7),    
('0.1', 8, 7);  

select*from compoe;

-- PEDIDO
INSERT INTO pedido (dataHora, status, observacao, valorTotal, fk_idFuncionario, fk_idCliente) VALUES
('2024-07-10 10:00:00', 'Concluído', 'Sem açúcar no café', '27.50', 1, 1),
('2024-07-10 10:15:00', 'Concluído', 'Extra quente', '12.00', 2, 2),
('2024-07-10 10:30:00', 'Pendente', 'Para viagem', '30.00', 3, 3),
('2024-07-10 10:45:00', 'Concluído', 'Com adoçante', '13.50', 4, 4),
('2024-07-10 11:00:00', 'Em Preparação', 'Leite de aveia', '14.00', 5, 5),
('2024-07-10 11:15:00', 'Concluído', 'Com gelo extra', '10.00', 6, 6),
('2024-07-10 11:30:00', 'Concluído', 'Aquecer o pão', '21.00', 7, 7),
('2024-07-10 11:45:00', 'Pendente', 'Sem presunto', '16.00', 8, 8),
('2024-07-10 12:00:00', 'Concluído', 'Com canudo', '11.00', 9, 9),
('2024-07-10 12:15:00', 'Concluído', 'Gelada', '5.00', 10, 10),
('2024-07-10 12:30:00', 'Concluído', 'Moer na hora', '35.00', 11, 11),
('2024-07-10 12:45:00', 'Em Preparação', 'Com mel', '9.00', 12, 12),
('2024-07-10 13:00:00', 'Concluído', 'Fatia grande', '16.50', 13, 13),
('2024-07-10 13:15:00', 'Concluído', 'Sem lactose', '13.50', 14, 14),
('2024-07-10 13:30:00', 'Pendente', 'Com chantilly', '14.00', 15, 15);

select*from pedido;

-- ITEM PEDIDO
INSERT INTO itemPedido (precoUnitario, quantidade, fk_idPedido, fk_idProduto) VALUES
('7.50', '1', 1, 1),  -- Pedido 1: Espresso
('15.00', '1', 1, 7), -- Pedido 1: Bolo de Cenoura
('12.00', '1', 2, 2),  -- Pedido 2: Cappuccino
('15.00', '2', 3, 7),  -- Pedido 3: 2x Bolo de Cenoura
('13.50', '1', 4, 3),  -- Pedido 4: Latte Macchiato
('14.00', '1', 5, 4),  -- Pedido 5: Mocaccino
('10.00', '1', 6, 5),  -- Pedido 6: Café Gelado
('6.00', '1', 7, 9),   -- Pedido 7: Pão de Queijo
('15.00', '1', 7, 7),  -- Pedido 7: Bolo de Cenoura
('16.00', '1', 8, 10), -- Pedido 8: Misto Quente
('11.00', '1', 9, 11), -- Pedido 9: Suco de Laranja Natural
('5.00', '1', 10, 12), -- Pedido 10: Água Mineral
('35.00', '1', 11, 13),-- Pedido 11: Café em Grãos Blend da Casa
('9.00', '1', 12, 14), -- Pedido 12: Chá de Hortelã
('16.50', '1', 13, 15);-- Pedido 13: Torta de Limão

select*from itemPedido;

-- PAGAMENTO
INSERT INTO pagamento (valor, status, formaPagamento, observacao, fk_idPedido) VALUES
('27.50', 'Aprovado', 'Cartão de Crédito', 'Pagamento integral', 1),
('12.00', 'Aprovado', 'Dinheiro', 'Troco de R$8.00', 2),
('15.00', 'Pendente', 'Cartão de Débito', 'Primeira parte do pagamento', 3), -- pagamento parcial/pendente
('15.00', 'Aprovado', 'Pix', 'Segunda parte do pagamento', 3), -- Continuação do pagamento do pedido 3
('13.50', 'Aprovado', 'Cartão de Crédito', 'Pagamento integral', 4),
('14.00', 'Aprovado', 'Dinheiro', NULL, 5),
('10.00', 'Aprovado', 'Cartão de Débito', NULL, 6),
('21.00', 'Aprovado', 'Pix', NULL, 7),
('16.00', 'Pendente', 'Cartão de Crédito', 'Aguardando aprovação', 8),
('11.00', 'Aprovado', 'Dinheiro', NULL, 9),
('5.00', 'Aprovado', 'Cartão de Débito', NULL, 10),
('35.00', 'Aprovado', 'Pix', NULL, 11),
('9.00', 'Aprovado', 'Dinheiro', NULL, 12),
('16.50', 'Aprovado', 'Cartão de Crédito', NULL, 13),
('13.50', 'Aprovado', 'Pix', NULL, 14);

select*from pagamento;
