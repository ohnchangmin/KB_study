import cv2
import matplotlib.pyplot as plt

mainimg=cv2.imread('main.jpg')
mainimg=cv2.resize(mainimg,(640,680))
print(mainimg.shape)

indoimg=cv2.imread('indo.jpg')
indoimg=cv2.resize(indoimg,(640,680))
print(indoimg.shape)
# cv2.imshow("indoimg",indoimg)
# cv2.waitKey(0)

result = cv2.add(mainimg, indoimg)
plt.imshow(cv2.cvtColor(result, cv2.COLOR_BGR2RGB))
plt.show()

result = mainimg + indoimg
plt.imshow(cv2.cvtColor(result, cv2.COLOR_BGR2RGB))
plt.show()