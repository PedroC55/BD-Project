insert PF.EMPRESA values('Ctesi', 'Rua Ctesi', 'Multibanco')
insert PF.EMPRESA values('Initial', 'Rua Initial', 'Multibanco')
insert PF.EMPRESA values('Diversey', 'Rua Diversey', 'Cobrança')

select * from PF.EMPRESA

GO

insert PF.FORNECEDOR values('António Silva',902455912,'Rua XPTO',265456964,'Ferro')
insert PF.FORNECEDOR values('José Rodrigues',902123762,'Rua César',265790914,'Cobre')
insert PF.FORNECEDOR values('Vítor Farias',904456967,'Rua MITO',261423187,'Granito')
insert PF.FORNECEDOR values('Eugénio Mafra',921361856,'Rua de CIMA',278345193,'Madeira')
insert PF.FORNECEDOR values('Anselmo Nunes',993578012,'Rua VELAS',259032671,'Gesso')

select * from PF.FORNECEDOR

Go

insert PF.MATERIA_PRIMA values('Ferro', 'Mineral')
insert PF.MATERIA_PRIMA values('Cobre', 'Mineral')
insert PF.MATERIA_PRIMA values('Granito', 'Rocha')
insert PF.MATERIA_PRIMA values('Madeira', 'Vegetal')
insert PF.MATERIA_PRIMA values('Gesso', 'Rocha')

select * from PF.MATERIA_PRIMA

GO

insert PF.CATEGORIA values('Mobiliário')
insert PF.CATEGORIA values('Torneiras')
insert PF.CATEGORIA values('Louças Sanitárias')
insert PF.CATEGORIA values('Toalheiros')
insert PF.CATEGORIA values('Cabines de Duche')
insert PF.CATEGORIA values('Autoclismos')

select * from PF.CATEGORIA

GO

insert PF.PRODUTO values('CT8000050', 'Móvel Glam', 565.80, 23.0, 432, 'Ctesi','Mobiliário')
insert PF.PRODUTO values('CT5008252', 'Espelho Stretched', 258.30, 23.0, 502,'Ctesi','Mobiliário')
insert PF.PRODUTO values('CT2008900', 'Lavatório mono', 111.56, 23.0, 632,'Ctesi','Torneiras')
insert PF.PRODUTO values('IN2403500', 'Coluna de duche', 265.80, 23.0, 382,'Initial','Torneiras')
insert PF.PRODUTO values('IN7501345', 'Sanita suspensa', 289.05, 23.0, 516,'Initial','Louças Sanitárias')
insert PF.PRODUTO values('IN1300000', 'Toalheiro Straw', 72.94, 23.0, 612,'Initial','Toalheiros')
insert PF.PRODUTO values('DV7501345', 'Cabide Pipeline', 28.91, 23.0, 854,'Diversey','Toalheiros')
insert PF.PRODUTO values('DV1000220', 'Banheira acrílica', 242.31, 23.0, 543,'Diversey','Cabines de Duche')
insert PF.PRODUTO values('DV0010500', 'Ondabloc', 85.73, 23.0, 729,'Diversey','Autoclismos')

select * from PF.PRODUTO

GO

insert PF.CLIENTE values('Manuel Alves', 'Rua de BAIXO', 15992356, 'M', 'manuel.alves@gmail.com', 'Ctesi')
insert PF.CLIENTE values('Pedro Viegas', 'Rua da GUIA', 14992186, 'M', 'pedro.viegas@gmail.com', 'Ctesi')
insert PF.CLIENTE values('Ruben Coimbra', 'Rua do DIA', 14344567, 'M', 'ruben.coimbra@gmail.com', 'Ctesi')
insert PF.CLIENTE values('Maria Neres', 'Rua da LUA', 16721467, 'F', 'maria.neres@gmail.com', 'Ctesi')
insert PF.CLIENTE values('Sandra Esposende', 'Rua de CRISTO', 16023456, 'F', 'sandra.esposende@gmail.com', 'Initial')
insert PF.CLIENTE values('Ricardo Sá', 'Rua TRINDADE', 15786524, 'M', 'ricardo.sa@gmail.com', 'Initial')
insert PF.CLIENTE values('Ana Jesus', 'Rua de BAIXO', 15961803, 'F', 'ana.jesus@gmail.com', 'Diversey')
insert PF.CLIENTE values('Carina Esteves', 'Rua de MIRA', 16782330, 'F', 'carina.esteves@gmail.com', 'Diversey')

select * from PF.CLIENTE

GO

insert PF.TRANSPORTADORA values('Fastway', 'Veículo de Carga', 12)
insert PF.TRANSPORTADORA values('CargoClear', 'Caminhão 3/4', 14)
insert PF.TRANSPORTADORA values('FEDEX', 'Veículo Urbano de Carga', 10)
insert PF.TRANSPORTADORA values('DawnWing', 'Caminhão Semipesado', 17)
insert PF.TRANSPORTADORA values('UPS', 'Caminhão pesado', 23)

GO

insert PF.ENVIO values('22:02:05', 'Rua S', 1, 'Fastway')

GO

insert PF.ENCOMENDA values(1, '2022-06-21', 'Rua S', '22:02:05', 'Ctesi', 'Pedro Coelho')

select * from PF.CLIENTE
