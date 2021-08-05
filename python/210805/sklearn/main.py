import matplotlib.pyplot as plt
from flask import Flask, render_template, request
from sklearn.neighbors import KNeighborsClassifier

app = Flask(__name__)

'''
matplotlib 그래프
sklearn 머신러닝
flask 웹 라이브러리
'''

bream_length = [25.4, 26.3, 26.5, 29.0, 29.0, 29.7, 29.7,
                30.0, 30.0, 30.7, 31.0, 31.0, 31.5, 32.0,
                32.0, 32.0, 33.0, 33.0, 33.5, 33.5, 34.0,
                34.0, 34.5, 35.0, 35.0, 35.0, 35.0, 36.0,
                36.0, 37.0, 38.5, 38.5, 39.5, 41.0, 41.0]
bream_weight = [242.0, 290.0, 340.0, 363.0, 430.0, 450.0,
                500.0, 390.0, 450.0, 500.0, 475.0, 500.0,
                500.0, 340.0, 600.0, 600.0, 700.0, 700.0,
                610.0, 650.0, 575.0, 685.0, 620.0, 680.0,
                700.0, 725.0, 720.0, 714.0, 850.0, 1000.0,
                920.0, 955.0, 925.0, 975.0, 950.0]

smelt_length = [9.8, 10.5, 10.6, 11.0, 11.2, 11.3, 11.8, 11.8, 12.0, 12.2, 12.4, 13.0, 14.3, 15.0]
smelt_weight = [6.7, 7.5, 7.0, 9.7, 9.8, 8.7, 10.0, 9.9, 9.8, 12.2, 13.4, 12.2, 19.7, 19.9]


# shift + d 한줄 삭제
# 실행 단축키
# shift + f10 or ctrl + shift + f10
# python flask(jsp) django(spring)

plt.scatter(bream_length, bream_weight, marker='*', c='r')
plt.scatter(smelt_length, smelt_weight, marker='D', c='b')
plt.scatter([30, 10], [80, 150], marker='^')
plt.xlabel('length')
plt.ylabel('weight')
plt.savefig('static/bream.png')
# plt.show()


length = bream_length+smelt_length
weight = bream_weight+smelt_weight

fish_data = [[l, w] for l, w in zip(length, weight)]
fish_target = [1]*35 + [0]*14

print(fish_data)
print(fish_target)

knc = KNeighborsClassifier()

# 학습을 진행해라
knc.fit(fish_data, fish_target)
predict_value = knc.predict([[30, 640], [10, 19]])
print('예측한값: ', predict_value)


@app.route("/")
def home():
    in_length = request.args.get('length', default='0')
    in_weight = request.args.get('weight', default='0')
    print('in_length: ', in_length)
    print('in_weight: ', in_weight)
    pre_value = knc.predict([[int(in_length), int(in_weight)]])
    print('pre_value: ', pre_value)
    str = 'bream'
    if pre_value == 1:
        str='bream'
    else:
        str='smelt'
    return render_template("index.html", pre_value=str)

@app.route("/aa")
def aa():
    return render_template("aa.html")

app.run(host="0.0.0.0", port="9999")