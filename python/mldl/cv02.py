import cv2
import time

image = cv2.imread('main.jpg', cv2.IMREAD_COLOR)
roi = image[100:200,100:200]
print(roi.shape)

image[0:100,0:100] = roi


# bgr = image[100,100]
#
# print('3개 = ',bgr)
# print('파란색값 = ', bgr[0])
# print('초록색값 = ', bgr[1])
# print('빨간색값 = ', bgr[2])
#
# starttime = time.time()
#
# for x in range(0,100):
#     for y in range(0,100):
#         image[x,y] = [255,255,255]
# print('걸린시간 = ',time.time()-starttime)
#
# starttime = time.time()
# image[200:300,300:] = [255,0,0]
# print('걸린시간 = bbb',time.time()-starttime)

cv2.imshow('image',image)
cv2.waitKey(0)
