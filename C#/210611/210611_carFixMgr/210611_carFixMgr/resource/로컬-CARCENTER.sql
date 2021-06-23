-- 테이블 순서는 관계를 고려하여 한 번에 실행해도 에러가 발생하지 않게 정렬되었습니다.

-- car_t Table Create SQL
CREATE TABLE car_t
(
    car_id    INT             NOT NULL, 
    model     VARCHAR2(20)    NOT NULL, 
    num       VARCHAR2(20)    NOT NULL, 
    cc        VARCHAR2(20)    NOT NULL, 
    year      VARCHAR2(20)    NOT NULL, 
    CONSTRAINT PK_car_t PRIMARY KEY (car_id)
)
/

CREATE SEQUENCE car_t_SEQ
START WITH 1
INCREMENT BY 1;
/

/*
CREATE OR REPLACE TRIGGER car_t_AI_TRG
BEFORE INSERT ON car_t 
REFERENCING NEW AS NEW FOR EACH ROW 
BEGIN 
    SELECT car_t_SEQ.NEXTVAL
    INTO :NEW.car_id
    FROM DUAL;
END;
*/

/

--DROP TRIGGER car_t_AI_TRG;
/

--DROP SEQUENCE car_t_SEQ;
/

COMMENT ON TABLE car_t IS '차량정보'
/

COMMENT ON COLUMN car_t.car_id IS '차량id'
/

COMMENT ON COLUMN car_t.model IS '차량모델'
/

COMMENT ON COLUMN car_t.num IS '차량번호'
/

COMMENT ON COLUMN car_t.cc IS '배기량'
/

COMMENT ON COLUMN car_t.year IS '차량연식'
/


-- customer_t Table Create SQL
CREATE TABLE customer_t
(
    cust_id    INT             NOT NULL, 
    name       VARCHAR2(20)    NOT NULL, 
    tel        VARCHAR2(20)    NOT NULL, 
    birth      VARCHAR2(20)    NOT NULL, 
    car_id     INT             NULL, 
    CONSTRAINT PK_customer_t PRIMARY KEY (cust_id)
)
/

CREATE SEQUENCE customer_t_SEQ
START WITH 1
INCREMENT BY 1;
/

/*CREATE OR REPLACE TRIGGER customer_t_AI_TRG
BEFORE INSERT ON customer_t 
REFERENCING NEW AS NEW FOR EACH ROW 
BEGIN 
    SELECT customer_t_SEQ.NEXTVAL
    INTO :NEW.cust_id
    FROM DUAL;
END;
*/
/

--DROP TRIGGER customer_t_AI_TRG;
/

--DROP SEQUENCE customer_t_SEQ;
/

COMMENT ON TABLE customer_t IS '고객정보'
/

COMMENT ON COLUMN customer_t.cust_id IS '고객id'
/

COMMENT ON COLUMN customer_t.name IS '고객명'
/

COMMENT ON COLUMN customer_t.tel IS '고객전화'
/

COMMENT ON COLUMN customer_t.birth IS '생년월일'
/

COMMENT ON COLUMN customer_t.car_id IS '차량id'
/

ALTER TABLE customer_t
    ADD CONSTRAINT FK_customer_t_car_id_car_t_car FOREIGN KEY (car_id)
        REFERENCES car_t (car_id)
/


-- repair_Item_t Table Create SQL
CREATE TABLE repair_Item_t
(
    repair_item_id    INT             NOT NULL, 
    idx               INT             NOT NULL, 
    repair            VARCHAR2(20)    NOT NULL, 
    price             INT             NOT NULL, 
    car_id            INT             NOT NULL, 
    CONSTRAINT PK_repair_Item_t PRIMARY KEY (repair_item_id)
)
/

CREATE SEQUENCE repair_Item_t_SEQ
START WITH 1
INCREMENT BY 1;
/

/*
CREATE OR REPLACE TRIGGER repair_Item_t_AI_TRG
BEFORE INSERT ON repair_Item_t 
REFERENCING NEW AS NEW FOR EACH ROW 
BEGIN 
    SELECT repair_Item_t_SEQ.NEXTVAL
    INTO :NEW.repair_item_id
    FROM DUAL;
END;
*/
/

--DROP TRIGGER repair_Item_t_AI_TRG;
/

--DROP SEQUENCE repair_Item_t_SEQ;
/

COMMENT ON TABLE repair_Item_t IS '수리항목'
/

COMMENT ON COLUMN repair_Item_t.repair_item_id IS '수리항목id'
/

COMMENT ON COLUMN repair_Item_t.idx IS '항목번호'
/

COMMENT ON COLUMN repair_Item_t.repair IS '수리항목id'
/

COMMENT ON COLUMN repair_Item_t.price IS '수리가격'
/

COMMENT ON COLUMN repair_Item_t.car_id IS '차량id'
/

ALTER TABLE repair_Item_t
    ADD CONSTRAINT FK_repair_Item_t_car_id_car_t_ FOREIGN KEY (car_id)
        REFERENCES car_t (car_id)
/


-- staff_t Table Create SQL
CREATE TABLE staff_t
(
    staff_id    INT             NOT NULL, 
    name        VARCHAR2(20)    NOT NULL, 
    tel         VARCHAR2(30)    NOT NULL, 
    address     VARCHAR2(40)    NOT NULL, 
    birth       VARCHAR2(20)    NOT NULL, 
    rank        VARCHAR2(20)    NOT NULL, 
    worktype    VARCHAR2(20)    NOT NULL, 
    salary      VARCHAR2(20)    NOT NULL, 
    CONSTRAINT PK_staff_t PRIMARY KEY (staff_id)
)
/

CREATE SEQUENCE staff_t_SEQ
START WITH 1
INCREMENT BY 1;
/

/*
CREATE OR REPLACE TRIGGER staff_t_AI_TRG
BEFORE INSERT ON staff_t 
REFERENCING NEW AS NEW FOR EACH ROW 
BEGIN 
    SELECT staff_t_SEQ.NEXTVAL
    INTO :NEW.staff_id
    FROM DUAL;
END;
*/

/

--DROP TRIGGER staff_t_AI_TRG;
/

--DROP SEQUENCE staff_t_SEQ;
/

COMMENT ON TABLE staff_t IS '직원'
/

COMMENT ON COLUMN staff_t.staff_id IS '직원id'
/

COMMENT ON COLUMN staff_t.name IS '직원이름'
/

COMMENT ON COLUMN staff_t.tel IS '직원연락처'
/

COMMENT ON COLUMN staff_t.address IS '직원주소'
/

COMMENT ON COLUMN staff_t.birth IS '생년월일'
/

COMMENT ON COLUMN staff_t.rank IS '직원직급'
/

COMMENT ON COLUMN staff_t.worktype IS '고용형태'
/

COMMENT ON COLUMN staff_t.salary IS '급여'
/


-- receipt_t Table Create SQL
CREATE TABLE receipt_t
(
    receipt_id        INT             NOT NULL, 
    cust_id           INT             NOT NULL, 
    indate            VARCHAR2(20)    NOT NULL, 
    staff_id          INT             NOT NULL, 
    repair_item_id    INT             NOT NULL, 
    total_price       INT             NOT NULL, 
    CONSTRAINT PK_receipt_t PRIMARY KEY (receipt_id)
)
/

CREATE SEQUENCE receipt_t_SEQ
START WITH 1
INCREMENT BY 1;
/

/*
CREATE OR REPLACE TRIGGER receipt_t_AI_TRG
BEFORE INSERT ON receipt_t 
REFERENCING NEW AS NEW FOR EACH ROW 
BEGIN 
    SELECT receipt_t_SEQ.NEXTVAL
    INTO :NEW.receipt_id
    FROM DUAL;
END;
*/

/

--DROP TRIGGER receipt_t_AI_TRG;
/

--DROP SEQUENCE receipt_t_SEQ;
/

COMMENT ON TABLE receipt_t IS '접수정보'
/

COMMENT ON COLUMN receipt_t.receipt_id IS '접수id'
/

COMMENT ON COLUMN receipt_t.cust_id IS '고객id'
/

COMMENT ON COLUMN receipt_t.indate IS '접수날짜'
/

COMMENT ON COLUMN receipt_t.staff_id IS '담당자id'
/

COMMENT ON COLUMN receipt_t.repair_item_id IS '수리항목id'
/

COMMENT ON COLUMN receipt_t.total_price IS '총결제금액'
/

ALTER TABLE receipt_t
    ADD CONSTRAINT FK_receipt_t_cust_id_customer_ FOREIGN KEY (cust_id)
        REFERENCES customer_t (cust_id)
/

ALTER TABLE receipt_t
    ADD CONSTRAINT FK_receipt_t_staff_id_staff_t_ FOREIGN KEY (staff_id)
        REFERENCES staff_t (staff_id)
/

ALTER TABLE receipt_t
    ADD CONSTRAINT FK_receipt_t_repair_item_id_re FOREIGN KEY (repair_item_id)
        REFERENCES repair_Item_t (repair_item_id)
/


