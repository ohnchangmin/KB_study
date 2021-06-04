--헬스 스키마 생성

-- USER SQL
CREATE USER HEALTH IDENTIFIED BY "1234"  
DEFAULT TABLESPACE "SYSTEM"
TEMPORARY TABLESPACE "TEMP";

-- QUOTAS
ALTER USER HEALTH QUOTA 10M ON USERS;

-- ROLES
GRANT "CONNECT" TO HEALTH ;
GRANT "RESOURCE" TO HEALTH ;

-- SYSTEM PRIVILEGES



--고객 테이블 생성

CREATE TABLE CUSTOMER 
(
  NAME NVARCHAR2(5) NOT NULL 
, TEL NVARCHAR2(11) NOT NULL 
, GENDER NVARCHAR2(1) NOT NULL 
, ADDRESS NVARCHAR2(20) NOT NULL 
, ROCKER NUMBER(3) NOT NULL 
, REGI_DATE DATE NOT NULL 
, EXPIRE_DATE DATE NOT NULL
, DURING NVARCHAR2(3) NOT NULL
, CONSTRAINT CUSTOMER_PK PRIMARY KEY 
  (
    TEL 
  )
  ENABLE 
);


--인바디 테이블 생성
CREATE TABLE INBODY 
(
  IDNUM NUMBER(5) NOT NULL 
, NAME NVARCHAR2(5) NOT NULL 
, TEL NVARCHAR2(11) NOT NULL 
, GENDER NCHAR(1) NOT NULL 
, HEIGHT NUMBER(4,1) NOT NULL 
, WEIGHT NUMBER(4,1) NOT NULL 
, MUSCLE NUMBER(4,1) NOT NULL 
, FAT NUMBER(4,1) NOT NULL 
, PER_FAT NUMBER(3,1) 
, BMI NUMBER(3,1) 
, CONSTRAINT INBODY_PK PRIMARY KEY 
  (
    IDNUM 
  )
  ENABLE 
);

ALTER TABLE INBODY
ADD CONSTRAINT INBODY_FK1 FOREIGN KEY
(
  TEL 
)
REFERENCES CUSTOMER
(
  TEL 
)
ENABLE;

--시퀀스 생성
CREATE SEQUENCE SEQ_INBODY INCREMENT BY 1 START WITH 1 MAXVALUE 10000 MINVALUE 1 NOCYCLE;

--시퀀스 자동 생성 트리거
CREATE OR REPLACE TRIGGER AUTOSEQ 
BEFORE INSERT ON INBODY
FOR EACH ROW
BEGIN
  IF INSERTING AND :NEW.IDNUM IS NULL THEN
  SELECT SEQ_INBODY.NEXTVAL INTO :NEW.IDNUM FROM DUAL;
  END IF;
END;

--체지방률, BMI 자동입력 트리거
CREATE OR REPLACE TRIGGER TRG_PERFAT_BMI
BEFORE INSERT
ON INBODY
FOR EACH ROW
BEGIN 
 IF INSERTING AND :NEW.PER_FAT IS NULL THEN
 SELECT (:NEW.FAT/:NEW.WEIGHT)*100 INTO :NEW.PER_FAT FROM DUAL;
 END IF; 
 IF INSERTING AND :NEW.BMI IS NULL THEN
 SELECT (:NEW.WEIGHT / ((:NEW.HEIGHT*0.01) * (:NEW.HEIGHT*0.01))) INTO :NEW.BMI FROM DUAL;
 END IF;
END;

--만료일 자동입력 트리거
CREATE OR REPLACE TRIGGER TRG_EXPIRE
BEFORE INSERT OR UPDATE
ON CUSTOMER
FOR EACH ROW
BEGIN
IF INSERTING AND :NEW.DURING = '1개월' AND :NEW.EXPIRE_DATE IS NULL THEN
SELECT ADD_MONTHS(:NEW.REGI_DATE, 1) INTO :NEW.EXPIRE_DATE FROM DUAL;
ELSIF INSERTING AND :NEW.DURING = '2개월' AND :NEW.EXPIRE_DATE IS NULL THEN
SELECT ADD_MONTHS(:NEW.REGI_DATE, 2) INTO :NEW.EXPIRE_DATE FROM DUAL;
ELSIF INSERTING AND :NEW.DURING = '3개월' AND :NEW.EXPIRE_DATE IS NULL THEN 
SELECT ADD_MONTHS(:NEW.REGI_DATE, 3) INTO :NEW.EXPIRE_DATE FROM DUAL;
END IF;
END;



--고객테이블에 데이터삽입
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, ROCKER, REGI_DATE) VALUES ('이지은', '01045217855', '여', '대구광역시 동구 동부로 121', TO_DATE('1993-05-07 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '7', TO_DATE('2021-06-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, REGI_DATE) VALUES ('박효신', '01015568455', '남', '대구광역시 동구 동부로 94', TO_DATE('1987-08-18 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE('2021-05-05 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, ROCKER, REGI_DATE) VALUES ('이병헌', '01088884446', '남', '대구광역시 동구 동부로 51', TO_DATE('1975-06-15 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '1', TO_DATE('2021-03-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, ROCKER, REGI_DATE) VALUES ('박보검', '01048714489', '남', '대구광역시 송라로6길 5', TO_DATE('1993-09-09 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '3', TO_DATE('2021-04-30 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, ROCKER, REGI_DATE) VALUES ('장기하', '01042517854', '남', '대구광역시 아양로 78', TO_DATE('1988-12-11 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '2', TO_DATE('2021-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, REGI_DATE) VALUES ('강지현', '01037854467', '여', '대구광역시 송라로6길 15', TO_DATE('1991-08-14 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE('2021-03-03 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, ROCKER, REGI_DATE) VALUES ('김종국', '01063215584', '남', '대구광역시 동구 동부로 122', TO_DATE('1974-11-11 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10', TO_DATE('2021-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));
INSERT INTO "HEALTH"."USERTBL" (NAME, TEL, GENDER, ADDRESS, BIRTHDAY, REGI_DATE) VALUES ('조혜련', '01005235456', '여', '대구광역시 아양로 55', TO_DATE('1970-05-05 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE('2021-06-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'));



INSERT INTO CUSTOMER VALUES('이지은', '01041280047', '여', '대구 동구 동부로 39', 130, TO_DATE(SYSDATE), NULL, 2);
select idnum from customer;
INSERT INTO INBODY VALEUS(seq_INBODY.NEXTVAL, '이지은', '01041280047', '여', 160.5, 49.1, 23.4, 12.2, NULL, NULL); 
