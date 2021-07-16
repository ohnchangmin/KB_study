import requests
from bs4 import BeautifulSoup as bs
import pandas as pd

req = requests.get('https://www.rankingdak.com/content/content.php?cont=weekly')
html = req.text
soup = bs(html, 'html.parser', from_encoding='utf-8')
title = soup.select('p.prd_name')
print(soup)
#print(title)