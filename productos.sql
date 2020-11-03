/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     21/11/2019 9:49:14 p. m.                     */
/*==============================================================*/


drop table if exists CATEGORIA;

drop table if exists CLIENTE;

drop table if exists PRODUCTOS;

drop table if exists USUARIO;

drop table if exists VENTA;

drop table if exists VENTADETALLE;

/*==============================================================*/
/* Table: CATEGORIA                                             */
/*==============================================================*/
create table CATEGORIA
(
   COD_CAT              varchar(15) not null,
   CATEGORIA            varchar(50),
   primary key (COD_CAT)
);

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE
(
   COD_CLI              varchar(8) not null,
   NOMBRE               varchar(150),
   DIRECCION            varchar(200),
   NIT                  varchar(10),
   CREDITO              varchar(10),
   SALDO                decimal(8,2),
   primary key (COD_CLI)
);

/*==============================================================*/
/* Table: PRODUCTOS                                             */
/*==============================================================*/
create table PRODUCTOS
(
   CODIGO_P             int not null,
   COD_CAT              varchar(15),
   NOMBRE               varchar(150),
   DESCRIPCION          varchar(200),
   MARCA                varchar(150),
   PRECIOV              decimal(8,2),
   PRECIOC              decimal(8,2),
   GANACIA              decimal(8,2),
   IMAGEN               varchar(255),
   primary key (CODIGO_P)
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO
(
   COD_USU              int not null,
   NOMBRE               varchar(150),
   USUARIO              varchar(150),
   CONTRASENA           varchar(150),
   NIVEL                int,
   primary key (COD_USU)
);

/*==============================================================*/
/* Table: VENTA                                                 */
/*==============================================================*/
create table VENTA
(
   COMPROBANTE          int not null,
   COD_USU              int,
   COD_CLI              varchar(8),
   ESTADO               varchar(20),
   FECHA                datetime,
   TIPO                 varchar(20),
   primary key (COMPROBANTE)
);

/*==============================================================*/
/* Table: VENTADETALLE                                          */
/*==============================================================*/
create table VENTADETALLE
(
   COD_DETALLE          int not null,
   CODIGO_P             int,
   COMPROBANTE          int,
   PRECIO               decimal(8,2),
   CANTIDAD             int,
   primary key (COD_DETALLE)
);

alter table PRODUCTOS add constraint FK_REFERENCE_5 foreign key (COD_CAT)
      references CATEGORIA (COD_CAT) on delete restrict on update restrict;

alter table VENTA add constraint FK_REFERENCE_3 foreign key (COD_USU)
      references USUARIO (COD_USU) on delete restrict on update restrict;

alter table VENTA add constraint FK_REFERENCE_4 foreign key (COD_CLI)
      references CLIENTE (COD_CLI) on delete restrict on update restrict;

alter table VENTADETALLE add constraint FK_REFERENCE_1 foreign key (CODIGO_P)
      references PRODUCTOS (CODIGO_P) on delete restrict on update restrict;

alter table VENTADETALLE add constraint FK_REFERENCE_2 foreign key (COMPROBANTE)
      references VENTA (COMPROBANTE) on delete restrict on update restrict;

