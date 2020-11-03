/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     03/12/2019 9:46:56 p. m.                     */
/*==============================================================*/


drop table if exists BITACORA;

drop table if exists CATEGORIA;

drop table if exists CLIENTE;

drop table if exists CREDITO;

drop table if exists PAGO;

drop table if exists PRODUCTO;

drop table if exists USUARIO;

drop table if exists VENTA;

drop table if exists VENTADETALLE;

/*==============================================================*/
/* Table: BITACORA                                              */
/*==============================================================*/
create table BITACORA
(
   ID                   int not null,
   FECHA                date,
   HORA                 time,
   ACCION               varchar(512) binary,
   primary key (ID)
);

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
   CREDITO              decimal(10,2),
   SALDO                decimal(8,2),
   primary key (COD_CLI)
);

/*==============================================================*/
/* Table: CREDITO                                               */
/*==============================================================*/
create table CREDITO
(
   COD_CREDI            int not null,
   COMPROBANTE          int,
   COD_CLI              varchar(8),
   COD_USU              int,
   ANTICIPO             decimal(10,2),
   primary key (COD_CREDI)
);

/*==============================================================*/
/* Table: PAGO                                                  */
/*==============================================================*/
create table PAGO
(
   ID_PAGO              int not null,
   COD_CREDI            int,
   COD_USU              int,
   MONTO                decimal(10,2),
   FECHA                date,
   HORA                 time,
   primary key (ID_PAGO)
);

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO
(
   CODIGO_P             int not null,
   COD_CAT              varchar(15),
   NOMBRE               varchar(150),
   DESCRIPCION          varchar(200),
   MARCA                varchar(150),
   CANTIDAD             int,
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
   FECHA                date,
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

alter table CREDITO add constraint FK_REFERENCE_6 foreign key (COMPROBANTE)
      references VENTA (COMPROBANTE) on delete restrict on update restrict;

alter table CREDITO add constraint FK_REFERENCE_7 foreign key (COD_CLI)
      references CLIENTE (COD_CLI) on delete restrict on update restrict;

alter table CREDITO add constraint FK_REFERENCE_8 foreign key (COD_USU)
      references USUARIO (COD_USU) on delete restrict on update restrict;

alter table PAGO add constraint FK_REFERENCE_10 foreign key (COD_USU)
      references USUARIO (COD_USU) on delete restrict on update restrict;

alter table PAGO add constraint FK_REFERENCE_9 foreign key (COD_CREDI)
      references CREDITO (COD_CREDI) on delete restrict on update restrict;

alter table PRODUCTO add constraint FK_REFERENCE_5 foreign key (COD_CAT)
      references CATEGORIA (COD_CAT) on delete restrict on update restrict;

alter table VENTA add constraint FK_REFERENCE_3 foreign key (COD_USU)
      references USUARIO (COD_USU) on delete restrict on update restrict;

alter table VENTA add constraint FK_REFERENCE_4 foreign key (COD_CLI)
      references CLIENTE (COD_CLI) on delete restrict on update restrict;

alter table VENTADETALLE add constraint FK_REFERENCE_1 foreign key (CODIGO_P)
      references PRODUCTO (CODIGO_P) on delete restrict on update restrict;

alter table VENTADETALLE add constraint FK_REFERENCE_2 foreign key (COMPROBANTE)
      references VENTA (COMPROBANTE) on delete restrict on update restrict;

