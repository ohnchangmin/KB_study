import pandas as pd

# dict_data = {'a':1, 'b':2, 'c':3}
# sr=pd.Series(dict_data)
# print(sr.index)
# print(sr.values)
# print(sr['b'])
# print(sr[0])

#data = ('창민', '2021-07-15', '남', True)
#sr1=pd.Series(data, index=['이름', '생년월일', '성별', '학생여부'])
#print(sr1)
#print(sr1[['생년월일','이름']])

# dict_data = {'c0':[1,2,3], 'c1':[4,5,6], 'c2':[7,8,9], 'c3':[10,11,12], 'c4':[13,14,15]}
# df=pd.DataFrame(dict_data)
# print(type(df))
# print('\n')
# print(df)

#print(df['c2'])

# df1 = pd.DataFrame([[15, '남', '덕영중'], [17,'여','수리중']], index=['준서','예은'], columns=['나이', '성별', '학교'])
# # print(df1,'\n')
# # print(df1.index, '\n')
# # print(df1.columns)
# df1.rename(columns={'나이':'연령', '성별':'남녀', '학교':'소속'}, inplace=True)
# df1.rename(index={'준서':'학생1', '예은':'학생2'},inplace=True)
#
# print(df1)

exam_data = {'수학': [90, 80, 70], '영어': [98, 89, 95], '음악': [85, 95, 100], '체육': [100, 90, 90]}
ex = pd.DataFrame(exam_data, index=['서준', '우현', '인아'])
print(ex, '\n')

ex1 = ex[:].copy()
ex1.drop('우현', inplace=True)
print(ex1, '\n')

ex2 = ex[:].copy()
ex2.drop(['우현', '인아'], axis=0, inplace=True)
print(ex2, '\n')

ex3 = ex[:].copy()
ex3.drop(['수학'], axis=1, inplace=True)
print(ex3, '\n')

ex4 = ex[:].copy()
ex4.drop(['수학', '체육'], axis=1, inplace=True)
ex4.drop(['인아'], axis=0, inplace=True)
print(ex4)
