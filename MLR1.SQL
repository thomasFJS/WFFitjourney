-- -----------------------------------------------------------------------------
--             Génération d'une base de données pour
--                      Oracle Version 10g
--                        (25/4/2023 15:37:21)
-- -----------------------------------------------------------------------------
--      Nom de la base : MLR1
--      Projet : Espace de travail
--      Auteur : Fujise
--      Date de dernière modification : 7/3/2023 17:48:35
-- -----------------------------------------------------------------------------

DROP TABLE FIT_SESSION CASCADE CONSTRAINTS;

DROP TABLE FIT_ROLE CASCADE CONSTRAINTS;

DROP TABLE FIT_WORKOUT CASCADE CONSTRAINTS;

DROP TABLE FIT_USER CASCADE CONSTRAINTS;

DROP TABLE FIT_WORKOUT_TYPE CASCADE CONSTRAINTS;

DROP TABLE FIT_COACHING_REVIEW CASCADE CONSTRAINTS;

DROP TABLE FIT_PROGRAM CASCADE CONSTRAINTS;

DROP TABLE FIT_WORKOUT_REVIEW CASCADE CONSTRAINTS;

-- -----------------------------------------------------------------------------
--       CREATION DE LA BASE 
-- -----------------------------------------------------------------------------

CREATE DATABASE MLR1;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_SESSION
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_SESSION
   (
    SES_DURATION DB_TEXT, 0  NULL,
    SES_TIME DB_TEXT, 0  NULL,
    SES_DATE DB_TEXT, 0  NULL,
    SES_NO DB_TEXT, 0  NOT NULL
,   CONSTRAINT PK_FIT_SESSION PRIMARY KEY (SES_NO)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_ROLE
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_ROLE
   (
    ROL_NAME DB_TEXT, 0  NOT NULL,
    USR_EMAIL DB_TEXT, 0  NOT NULL
,   CONSTRAINT PK_FIT_ROLE PRIMARY KEY (ROL_NAME)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE FIT_ROLE
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_FIT_ROLE_FIT_USER
     ON FIT_ROLE (USR_EMAIL ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_WORKOUT
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_WORKOUT
   (
    WRE_NO DB_TEXT, 0  NOT NULL,
    WOR_DATE DB_TEXT, 0  NULL,
    WOR_DURATION DB_TEXT, 0  NULL,
    WOR_CALORIES DB_TEXT, 0  NULL,
    WOR_NO DB_TEXT, 0  NOT NULL
,   CONSTRAINT PK_FIT_WORKOUT PRIMARY KEY (WOR_NO)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE FIT_WORKOUT
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_FIT_WORKOUT_FIT_WORKOUT_R
     ON FIT_WORKOUT (WRE_NO ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_USER
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_USER
   (
    CRE_NO DB_TEXT, 0  NOT NULL,
    PRO_NO DB_TEXT, 0  NOT NULL,
    PRO_NO_HAVE DB_TEXT, 0  NOT NULL,
    SES_NO DB_TEXT, 0  NOT NULL,
    WRE_NO DB_TEXT, 0  NOT NULL,
    SES_NO_GIVE DB_TEXT, 0  NOT NULL,
    WOR_NO DB_TEXT, 0  NOT NULL,
    USR_EMAIL_COACHEDBY DB_TEXT, 0  NOT NULL,
    CRE_NO_IS_REVIEWED DB_TEXT, 0  NOT NULL,
    USR_NAME DB_TEXT, 0  NULL,
    USR_SURNAME DB_TEXT, 0  NULL,
    USR_EMAIL DB_TEXT, 0  NOT NULL,
    USR_PASSWORD DB_TEXT, 0  NULL,
    USR_BIRTHDATE DB_TEXT, 0  NULL,
    USR_PROFILE_PIC DB_TEXT, 0  NULL,
    USR_ADDRESS DB_TEXT, 0  NULL,
    USR_NPA DB_TEXT, 0  NULL,
    USR_COUNTRY DB_TEXT, 0  NULL,
    USR_CITY DB_TEXT, 0  NULL,
    USR_IS_ACTIVE DB_TEXT, 0  NULL,
    USR_CREATED_AT DB_TEXT, 0  NULL
,   CONSTRAINT PK_FIT_USER PRIMARY KEY (USR_EMAIL)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE FIT_USER
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_FIT_USER_FIT_COACHING_REV
     ON FIT_USER (CRE_NO ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_PROGRAM
     ON FIT_USER (PRO_NO ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_PROGRAM1
     ON FIT_USER (PRO_NO_HAVE ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_SESSION
     ON FIT_USER (SES_NO ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_WORKOUT_REVI
     ON FIT_USER (WRE_NO ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_SESSION1
     ON FIT_USER (SES_NO_GIVE ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_WORKOUT
     ON FIT_USER (WOR_NO ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_USER
     ON FIT_USER (USR_EMAIL_COACHEDBY ASC)
    ;

CREATE  INDEX I_FK_FIT_USER_FIT_COACHING_RE1
     ON FIT_USER (CRE_NO_IS_REVIEWED ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_WORKOUT_TYPE
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_WORKOUT_TYPE
   (
    WTY_TITLE DB_TEXT, 0  NOT NULL,
    SES_NO DB_TEXT, 0  NOT NULL,
    WOR_NO DB_TEXT, 0  NOT NULL,
    WTY_DESCRIPTION DB_TEXT, 0  NULL,
    WTY_LOGO DB_TEXT, 0  NULL
,   CONSTRAINT PK_FIT_WORKOUT_TYPE PRIMARY KEY (WTY_TITLE)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE FIT_WORKOUT_TYPE
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_FIT_WORKOUT_TYPE_FIT_SESS
     ON FIT_WORKOUT_TYPE (SES_NO ASC)
    ;

CREATE  INDEX I_FK_FIT_WORKOUT_TYPE_FIT_WORK
     ON FIT_WORKOUT_TYPE (WOR_NO ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_COACHING_REVIEW
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_COACHING_REVIEW
   (
    CRE_SATISFACTION DB_TEXT, 0  NULL,
    CRE_SUPPORT DB_TEXT, 0  NULL,
    CRE_DISPONIBILITY DB_TEXT, 0  NULL,
    CRE_ADVICE DB_TEXT, 0  NULL,
    CRE_COMMENT DB_TEXT, 0  NULL,
    CRE_DATE DB_TEXT, 0  NULL,
    CRE_NO DB_TEXT, 0  NOT NULL
,   CONSTRAINT PK_FIT_COACHING_REVIEW PRIMARY KEY (CRE_NO)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_PROGRAM
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_PROGRAM
   (
    PRO_TYPE DB_TEXT, 0  NULL,
    PRO_PDF DB_TEXT, 0  NULL,
    PRO_NO DB_TEXT, 0  NOT NULL
,   CONSTRAINT PK_FIT_PROGRAM PRIMARY KEY (PRO_NO)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : FIT_WORKOUT_REVIEW
-- -----------------------------------------------------------------------------

CREATE TABLE FIT_WORKOUT_REVIEW
   (
    WRE_DIFFICULTY DB_TEXT, 0  NULL,
    WRE_FEEL DB_TEXT, 0  NULL,
    WRE_FATIGUE DB_TEXT, 0  NULL,
    WRE_ENERGY DB_TEXT, 0  NULL,
    WRE_COMMENT DB_TEXT, 0  NULL,
    WRE_DATE DB_TEXT, 0  NULL,
    WRE_NO DB_TEXT, 0  NOT NULL
,   CONSTRAINT PK_FIT_WORKOUT_REVIEW PRIMARY KEY (WRE_NO)  
   ) ;


-- -----------------------------------------------------------------------------
--       CREATION DES REFERENCES DE TABLE
-- -----------------------------------------------------------------------------


ALTER TABLE FIT_ROLE ADD (
     CONSTRAINT FK_FIT_ROLE_FIT_USER
          FOREIGN KEY (USR_EMAIL)
               REFERENCES FIT_USER (USR_EMAIL))   ;

ALTER TABLE FIT_WORKOUT ADD (
     CONSTRAINT FK_FIT_WORKOUT_FIT_WORKOUT_REV
          FOREIGN KEY (WRE_NO)
               REFERENCES FIT_WORKOUT_REVIEW (WRE_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_COACHING_REVIE
          FOREIGN KEY (CRE_NO)
               REFERENCES FIT_COACHING_REVIEW (CRE_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_PROGRAM
          FOREIGN KEY (PRO_NO)
               REFERENCES FIT_PROGRAM (PRO_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_PROGRAM1
          FOREIGN KEY (PRO_NO_HAVE)
               REFERENCES FIT_PROGRAM (PRO_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_SESSION
          FOREIGN KEY (SES_NO)
               REFERENCES FIT_SESSION (SES_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_WORKOUT_REVIEW
          FOREIGN KEY (WRE_NO)
               REFERENCES FIT_WORKOUT_REVIEW (WRE_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_SESSION1
          FOREIGN KEY (SES_NO_GIVE)
               REFERENCES FIT_SESSION (SES_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_WORKOUT
          FOREIGN KEY (WOR_NO)
               REFERENCES FIT_WORKOUT (WOR_NO))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_USER
          FOREIGN KEY (USR_EMAIL_COACHEDBY)
               REFERENCES FIT_USER (USR_EMAIL))   ;

ALTER TABLE FIT_USER ADD (
     CONSTRAINT FK_FIT_USER_FIT_COACHING_REVI1
          FOREIGN KEY (CRE_NO_IS_REVIEWED)
               REFERENCES FIT_COACHING_REVIEW (CRE_NO))   ;

ALTER TABLE FIT_WORKOUT_TYPE ADD (
     CONSTRAINT FK_FIT_WORKOUT_TYPE_FIT_SESSIO
          FOREIGN KEY (SES_NO)
               REFERENCES FIT_SESSION (SES_NO))   ;

ALTER TABLE FIT_WORKOUT_TYPE ADD (
     CONSTRAINT FK_FIT_WORKOUT_TYPE_FIT_WORKOU
          FOREIGN KEY (WOR_NO)
               REFERENCES FIT_WORKOUT (WOR_NO))   ;


-- -----------------------------------------------------------------------------
--                FIN DE GENERATION
-- -----------------------------------------------------------------------------