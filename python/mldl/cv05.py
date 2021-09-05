import cv2
import matplotlib.pyplot as plt

image = cv2.imread('main.jpg', cv2.IMREAD_GRAYSCALE)

images = []
ret, thres1 = cv2.threshold(image, 127, 255, cv2.THRESH_BINARY)
ret, thres2 = cv2.threshold(image, 127, 255, cv2.THRESH_BINARY_INV)
ret, thres3 = cv2.threshold(image, 127, 255, cv2.THRESH_TRUNC)
ret, thres4 = cv2.threshold(image, 127, 255, cv2.THRESH_TOZERO)
ret, thres5 = cv2.threshold(image, 127, 255, cv2.THRESH_TOZERO_INV)
images.append(thres1)
images.append(thres2)
images.append(thres3)
images.append(thres4)
images.append(thres5)

# for i in images:
#   plt.imshow(cv2.cvtColor(i, cv2.COLOR_GRAY2RGB))
#   plt.show()

grayimg=cv2.imread('indo.jpg', cv2.IMREAD_GRAYSCALE)
grayimg=cv2.resize(grayimg,(640,680))
meanimg=cv2.adaptiveThreshold(grayimg,255,cv2.ADAPTIVE_THRESH_MEAN_C,cv2.THRESH_BINARY,21,3)
gaussianimg=cv2.adaptiveThreshold(grayimg,255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,cv2.THRESH_BINARY,21,3)

cv2.imshow("meanimg",meanimg)
cv2.waitKey(0)

cv2.imshow("gaussianimg",gaussianimg)
cv2.waitKey(0)