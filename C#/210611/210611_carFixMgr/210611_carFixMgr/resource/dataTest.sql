insert into staff_t values (staff_t_SEQ.nextval, '김점검', '010-2222-2222', '대구 동구 신천1동', '19800912', '과장', '정규직', '300만원');
insert into staff_t values (staff_t_SEQ.nextval, '박수리', '010-2222-2222', '대구 동구 신천1동', '19800912', '대리', '정규직', '230만원');
insert into staff_t values (staff_t_SEQ.nextval, '오고침', '010-2222-2222', '대구 동구 신천1동', '19800912', '부장', '정규직', '400만원');
insert into staff_t values (staff_t_SEQ.nextval, '최교체', '010-2222-2222', '대구 동구 신천1동', '19800912', '과장', '정규직', '200만원');
commit

insert all into car_t values(car_t_SEQ.NEXTVAl,'그랜저','12가1234','2500cc이하','2020년식')
into customer_t values(CUSTOMER_T_SEQ.NEXTVAL,'홍길동','010-1234-7890','19820520',Car_t_seq.currval)
select * from dual;
    
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,4,'엔진오일 교환',50000,car_t_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,5,'부동액 교환',50000,car_t_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,6,'와이퍼 교환',20000,car_t_SEQ.currval);

insert into receipt_t values (receipt_t_SEQ.NEXTVAL, customer_t_seq.currval, '2021년6월23일', car_t_seq.currval, (select staff_t.staff_id from staff_t where staff_t.name='김우치'), 150000);
