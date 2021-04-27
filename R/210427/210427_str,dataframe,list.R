#vector를 이용한 행렬 객체 생성
m <- matrix(c(1:5))
m

#열 우선으로 행렬 객체 생성하기
m <- matrix(c(1:10), nrow=2)
m

#행과 열의 수가 일치하지 않는 경우
m <- matrix(c(1:11), nrow=2)
m

#행 우선으로 행렬 객체 생성하기
m <- matrix(c(1:10), nrow=2, byrow = T)
m

#행 묶음으로 행렬 객체 생성하기
x1 <- c(5,40,50:52)
x2 <- c(30,5,6:8)
mr <- rbind(x1,x2)
mr

#열 묶음으로 행렬 객체 생성하기
mc <- cbind(x1,x2)
mc

#3행 3열의 행렬 객체 생성하기
x <- matrix(c(1:9), nrow=3, ncol=3)
x

#자료의 개수 보기
length(x)
ncol(x)

#사용자 정의 함수 적용하기
f <- function(x){
  x*c(1,2,3)
}
result <- apply(x,1,f)
result

#열 우선 순서로 사용자 정의 함수 적용하기
result <- apply(x,2,f)
result


#행과 열에 이름 붙이기
score <- matrix(c(90,85,69,78,85,96,49,95,90,80,70,60),nrow=4)
score
rownames(score) <- c('John','Tom','Mark','Jane')
colnames(score) <- c('English','Math','Science')
score

#예제
nutrition <- matrix(c(514,917,11,533,853,13,566,888,10),nrow=3,byrow=T)
nutrition
rownames(nutrition) <- c('M','L','B')
colnames(nutrition) <- c('열랑(kcal)', '나트륨(na)','포화지방(fat)')
nutrition
nutrition['B',]

#배열 객체 생성하기
vec <- c(1:12)
arr <- array(vec,c(3,2,2))
arr

#배열 객체의 자료 조회하기
arr[,,1]
arr[,,2]

#배열의 자료형과 자료구조 보기
mode(arr); class(arr)

#데이터프레임 만들기
city <- c("seoul","Tokyo","Washington")
rank <- c(1,3,2)
city.info <- data.frame(city,rank)
city.info

brand <- c("M","L","B")
kcal <- c(514,533,566)
na <- c(917,853,888)
fat <- c(11,13,10)
menu <- c("새우","불고기","치킨")

hamburger <- data.frame(브랜드=brand, 열량=kcal, 나트륨=na, 포화지방=fat, 메뉴=menu)
hamburger

#matrix를 이용한 데이터프레임 객체 생성하기
m <- matrix(
  c(1,"hong",150,
    2,"lee",250,
    3,"kim",300),3,by=T)
memp <- data.frame(m)
memp

#텍스트 파일을 이용한 데이터 프레임 객체 생성하기
setwd("C:/Users/KB/Documents/GitHub/KB_study/R/210427")
getwd()
txtemp <- read.table('read_c.txt', header=1, sep=",")
txtemp
txtemp1 <- read.table('read_tab.txt', header=1, sep="\t")
txtemp1

#데이터프레임 만들기
df <- data.frame(x=c(1:5), y=seq(2, 10, 2), z=c('a','b','c','d','e'))
df

#데이터프레임의 칼럼명 참조하기
df$x
df$y

#데이터프레임의 자료구조,열,행,칼럼명 보기
str(df)
ncol(df)
nrow(df)
names(df)
df[c(2:3),1]

#요약통계량 보기
summary(df)

install.packages('reshape2')
library(reshape2)
tips

list <- list("Yi", "이순신", 95)
list
list[[2]]

#key와 value 형식으로 리스트 객체 생성하기
member <- list(name = c("홍길동","유관순"),age = c(35,25), 
               address=c("한양","충남"), gender=c("남자","여자"),
               htype=c("아파트","오피스텔"))
member
member$name
member$address

member$age[1] <- 45
member$id <- "hong"
member$pwd <- "1234"
member

a <- list(c(1:5))
b <- list(c(6:10))
lapply(c(a,b), max)

multi_list <- list(c1=list(1,2,3),
                   c2=list(10,20,30),
                   c3=list(100,200,300))
multi_list$c1

str_extract("홍길동35이순신45유관순25","[1-9]{2}")
str_extract_all("홍길동35이순신45유관순25","[1-9]{2}")

string <- "hongkd105leess1002you25강삼찬2005"
str_extract_all(string,"[a-z]{3}")