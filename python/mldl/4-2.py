import pandas as pd
import numpy as np
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import SGDClassifier

import matplotlib.pyplot as plt

'''
Classifier => 분류할때
bream smelt roach ..... 분류하는게 목적이니까

Regressor => 가로 세로 높이 넓이 대각선 -> 무게 weight 예측
'''

fish = pd.read_csv('https://bit.ly/fish_csv_data')

fish_input = fish[['Weight','Length','Diagonal','Height','Width']].to_numpy()
fish_target = fish['Species'].to_numpy()

train_input,test_input,train_target,test_target = train_test_split(fish_input,fish_target,random_state=42)

ss=StandardScaler()
ss.fit(train_input)

train_scaled=ss.transform(train_input)
test_scaled=ss.transform(test_input)

# print(np.round(train_scaled[:5] , decimals=3))
# print(test_scaled[:5])

sgd=SGDClassifier(loss='log', max_iter=10, random_state=42)
sgd.fit(train_scaled, train_target)
print(sgd.score(train_scaled,train_target))
print(sgd.score(test_scaled,test_target))

sgd.partial_fit(train_scaled,train_target)
print(sgd.score(train_scaled,train_target))
print(sgd.score(test_scaled,test_target))

sc = SGDClassifier(loss='log', random_state=42)

train_score = []
test_score = []

classes = np.unique(train_target)

for _ in range(0,300):
    sc.partial_fit(train_scaled,train_target,classes=classes)

    trains = sc.score(train_scaled,train_target)
    train_score.append(trains)
    tests = sc.score(test_scaled,test_target)
    test_score.append(tests)

plt.plot(train_score)
plt.plot(test_score)
plt.xlabel('학습횟수')
plt.ylabel('정확도')
plt.show()