setwd("C:/Users/KB/Documents/GitHub/KB_study/R")

install.packages('cowsay')
library(cowsay)
say('Hello world!', by = 'cat')

dim(available.packages())
available.packages()
sessionInfo()
installed.packages()
remove.packages('cowsay')
hist(Nile)
hist(Nile, freq = F)
lines(density(Nile))
par(mfrow = c(1,1))
pdf("C:/Users/KB/Documents/GitHub/KB_study/R/210426/test.pdf")
hist(rnorm(20))
dev.off()

a <- 10
b <- 20
c <- a+b
print(a)
print(b)
print(c)
num <- c(2,5)
.a <- 10
.a
ls(all.names = TRUE)

#스칼라 변수 사용 예
int <- 20
int

string <- "홍길동"
string

boolean <- TRUE
boolean

sum(10,10,20)
sum(10,20,20.NA) #NA결측치 자료형

sum(10,20,20,NA,na.rm = TRUE) #결측치 제거후 합계 여산

is() #현재 사용중인 변수(객체) 보기

#자료형 확인
is.character(string)

x <- is.numeric(int)
x

is.logical(boolean)
is.logical(x)
is.na(x)

#벡터 변수 사용 예
age <- 35
names <- c("홍길동", "이순신", "유관순")
age
names

#자료형 변환
age.1 <-  20
age.2 <- 25
print(age.1 + age.2)
name.1 <- "john"
print(name.1)
grade.1 <- '3'
is.numeric(grade.1)
print(age.1 + as.numeric(grade.1))
as.character(int)

#문자 원소를 숫자 원소로 형 변환하기
x <- c(1,2,"3")
x
#result <- x*3
result <- as.numeric(x)*3
result


gender <- c("man","woman","woman","man","man")
#plot(gender)
Ngender <- as.factor(gender)
table(Ngender)

plot(Ngender)
mode(Ngender)
class(Ngender)
is.factor(Ngender)
Ngender

args(factor)
Ogender <- factor(gender,levels=c("woman","man"),ordered = T)
Ogender

as.Date("20/02/28", "%y/%m/%d")
class(as.Date("20/02/28", "%y/%m/%d"))
dates <- c("02/28/20", "02/30/20", "03/01/20")
as.Date(dates, "%m/%d/%y")


Sys.getlocale(category = "LC_ALL")
Sys.getlocale(category = "LC_COLLATE")
Sys.time()
Sys.Date()

#csv불러오기
setwd("C:/Users/KB/Documents/GitHub/KB_study/R/210426")
data <- read.csv("students.csv", header = T)
data
data[1]
data[1,1]
data[1,2]
data[1,3]
data[1,4]

ave.1 <- (data[1,2]+data[1,3]+data[1,4]) /3
ave.2 <- (data[2,2]+data[2,3]+data[2,4]) /3
ave.3 <- (data[3,2]+data[3,3]+data[3,4]) /3
ave.4 <- (data[4,2]+data[4,3]+data[4,4]) /3
ave.5 <- (data[5,2]+data[5,3]+data[5,4]) /3
options(digits = 4)
data$average <- c(ave.1, ave.2, ave.3, ave.4, ave.5)
data



#vector
c(1:20)
1:20
c(1,2,3,4,5)

seq(1,10,2)
seq(1,10)

rep(1:3,3)
rep(1:3,each =3)

#백터 객체의 값에 칼럼명 지정
age <- c(30,35,40)
names(age) <- c("홍길동","이순신","강감찬")
age

d <- c(1,4,3,7,8)
d[c(1,3,5)]
d[1:3]
d[seq(1,5,2)]
d[-2]
d[c(3:5)]
d[-c(3:5)]





