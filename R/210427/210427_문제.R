#1 tips의 자료구조
class(tips)#데이터프레임

#2 처음6개의 관측값과 끝 6개의 관측값
head(tips, 6)
tail(tips, 6)

#3 데이터 구조 출력
str(tips)

#4 tips의 데이터셋에서 요일별 팁을 받는 빈도
table(tips$day)

#5 tips의 데이터셋에서 팁의 빈도 차이
table(tips$time)

#6 시간대별 결제금액,팁,일행수에 대한 평균
din <- subset(tips, time=='Dinner')
lun <- subset(tips, time=='Lunch')
summary(din)
summary(lun)

#7 평균적으로 몇퍼센트의 팁을 주었는지
tip_late <- tips$total_bill / tips$tip
mean(tip_late)
