insert into staff_t values (staff_t_SEQ.nextval, '������', '010-2222-2222', '�뱸 ���� ��õ1��', '19800912', '����', '������', '300����');
insert into staff_t values (staff_t_SEQ.nextval, '�ڼ���', '010-2222-2222', '�뱸 ���� ��õ1��', '19800912', '�븮', '������', '230����');
insert into staff_t values (staff_t_SEQ.nextval, '����ħ', '010-2222-2222', '�뱸 ���� ��õ1��', '19800912', '����', '������', '400����');
insert into staff_t values (staff_t_SEQ.nextval, '�ֱ�ü', '010-2222-2222', '�뱸 ���� ��õ1��', '19800912', '����', '������', '200����');
commit

insert all into car_t values(car_t_SEQ.NEXTVAl,'�׷���','12��1234','2500cc����','2020���')
into customer_t values(CUSTOMER_T_SEQ.NEXTVAL,'ȫ�浿','010-1234-7890','19820520',Car_t_seq.currval)
select * from dual;
    
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,4,'�������� ��ȯ',50000,car_t_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,5,'�ε��� ��ȯ',50000,car_t_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,6,'������ ��ȯ',20000,car_t_SEQ.currval);

insert into receipt_t values (receipt_t_SEQ.NEXTVAL, customer_t_seq.currval, '2021��6��23��', car_t_seq.currval, (select staff_t.staff_id from staff_t where staff_t.name='���ġ'), 150000);
