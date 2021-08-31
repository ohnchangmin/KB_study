import cv2
import matplotlib.pyplot as plt

'''
이미지 보여주는 방식은
opencv
cv2.imshow()

matplotlib.pyplot
plt.show() 이미지 출력 rgb라이브러리
'''

img = cv2.imread('main.jpg', cv2.IMREAD_COLOR)
# cv2.imshow('main',img)
# cv2.waitKey(0)

# img_resize = cv2.resize(img, None, fx=2.0, fy=2.0, interpolation=cv2.INTER_CUBIC)
# cv2.imshow('main',img_resize)
# cv2.waitKey(0)
#
# img_resize = cv2.resize(img, None, fx=0.3, fy=0.3, interpolation=cv2.INTER_AREA)
# cv2.imshow('main',img_resize)
# cv2.waitKey(0)

print(img.shape)
M= cv2.getRotationMatrix2D((img.shape[0]/2, img.shape[1]/2),30,0.5)

ming = cv2.warpAffine(img,M,(img.shape[0],img.shape[1]))
cv2.imshow('ming',ming)
cv2.waitKey(0)
