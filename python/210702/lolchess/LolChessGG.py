#!/usr/bin/env python
# coding: utf-8

# In[171]:


import requests
from bs4 import BeautifulSoup
url = "https://lolchess.gg/statistics/items?hl=ko-KR"
htmlText = requests.get(url).text
bsoup = BeautifulSoup(htmlText, "html.parser")
btab = bsoup.find("tbody")
#btab = bsoup.find_all("td", {"class":"champion"})
btrs = btab.find_all("tr")
# garen = btrs[0].get_text().split("\n")
# testgaren = [v for v in garen if v]

list_cham_item=[]
for i in range(len(btrs)):
    list_cham_item.append((btrs[i].get_text().split("\n")))
    
itemUse = []
for i in range(len(list_cham_item)):    
    chamItem = [v for v in list_cham_item[i] if v]
#    print(chamItem)
#    print([v for v in list_cham_item[i][0] if v])
#     list_cham_item = [v for v in list_cham_item[i][0] if v]
    dic={}
    dic['champion'] = chamItem[0]
    dic['item1'] = chamItem[2]
    dic['item2'] = chamItem[6]
    dic['item3'] = chamItem[10]
    dic['item4'] = chamItem[14]
    dic['item5'] = chamItem[18]
    dic['use1'] = chamItem[1]
    dic['use2'] = chamItem[5]
    dic['use3'] = chamItem[9]
    dic['use4'] = chamItem[13]
    dic['use5'] = chamItem[17]
    itemUse.append(dic)
#print(itemUse[4])


from tkinter import Tk, ttk, Label, Button, Text, END
window = Tk()
window.title("롤토체스 아이템 통계 v1.0")
window.geometry("1500x600")
window.resizable(0,0)


title = "롤토체스 챔피언별 자주 사용하는 아이템"
title_feature = Label(window, text = title, font = ("Century Gothic", 20))
title_feature.pack(padx = 10, pady = 15)


treeTable = ttk.Treeview(window)
treeTable["columns"] = ("champion", "item1", "use1", "item2", "use2", "item3", "use3", "item4", "use4", "item5", "use5")
treeTable.column("#0", width = 50 , anchor = "center")
treeTable.column("champion", width = 160, anchor = "center")
treeTable.column("item1", width = 160, anchor = "center")
treeTable.column("use1", width = 50, anchor = "center")
treeTable.column("item2", width = 160, anchor = "center")
treeTable.column("use2", width = 50, anchor = "center")
treeTable.column("item3", width = 160, anchor = "center")
treeTable.column("use3", width = 50, anchor = "center")
treeTable.column("item4", width = 160, anchor = "center")
treeTable.column("use4", width = 50, anchor = "center")
treeTable.column("item5", width = 160, anchor = "center")
treeTable.column("use5", width = 50, anchor = "center")


treeTable.heading("#0", text = "NO.", anchor = "center")
treeTable.heading("champion", text = "챔피언", anchor = "center")
treeTable.heading("item1", text = "아이템 1위", anchor = "center")
treeTable.heading("use1", text = "사용 비율", anchor = "center")
treeTable.heading("item2", text = "아이템 2위", anchor = "center")
treeTable.heading("use2", text = "사용 비율", anchor = "center")
treeTable.heading("item3", text = "아이템 3위", anchor = "center")
treeTable.heading("use3", text = "사용 비율", anchor = "center")
treeTable.heading("item4", text = "아이템 4위", anchor = "center")
treeTable.heading("use4", text = "사용 비율", anchor = "center")
treeTable.heading("item5", text = "아이템 5위", anchor = "center")
treeTable.heading("use5", text = "사용 비율", anchor = "center")

def setTableItems():
    treeTable.delete(*treeTable.get_children())
    for idx, report in enumerate(itemUse):
        champion = report['champion']
        item1 = report['item1']
        use1 = report['use1']
        item2 = report['item2']
        use2 = report['use2']
        item3 = report['item3']
        use3 = report['use3']
        item4 = report['item4']
        use4 = report['use4']
        item5 = report['item5']
        use5 = report['use5']
        treeTable.insert("", 'end', iid = None, text = str(idx+1), values = [champion, item1, use1, item2, use2, item3, use3, item4, use4, item5, use5])


setTableItems()
treeTable.place(x = 50, y = 150, width = 1400, height = 300)

window.mainloop()


# In[ ]:




