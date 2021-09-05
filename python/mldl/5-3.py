import numpy as np
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.model_selection import cross_validate
from sklearn.ensemble import RandomForestClassifier

# import sys

# reload(sys)
# sys.enco("UTF-8")

wine = pd.read_csv('https://bit.ly/wine_csv_data')

data = wine[['alcohol', 'sugar', 'pH']].to_numpy()
target = wine['class'].to_numpy()

train_input, test_input, train_target, test_target \
    = train_test_split(data, target, test_size=0.2, random_state=42)

train_input = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
train_target = [0, 0, 1]

rf = RandomForestClassifier(random_state=42)
scores = cross_validate(rf, train_input, train_target, return_train_score=True,cv=2)

print(np.mean(scores['train_score']), np.mean(scores['test_score']))

rf.fit(train_input, train_target)
print(rf.feature_importances_)

# 창민 컴퓨터가 cpu 코어 갯수가 작아서 폴드를 5개로 나눌수가 없다고 .. 에러가..
# n_jobs=-1 주면 모든 코어 갯수 사용 하는데 그렇게 하지 말라고.. 자꾸
# cv = 2 준거는 훈련데이터갯수를 또 여러개로 나누면 자동으로
# cpu 코어 갯수를 3으로 지정해가지고.. 뭐.. 컴퓨터 시스템 환경 문제라..
# 소스가 아직 구글사에서 덜 만든거 같기도.. 하ㄱ고..