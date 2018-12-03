from bs4 import BeautifulSoup

import requests

url = input("Insira um site para extrair suas URL's:")

r = requests.get("http://"+url)

data = r.text

#soup = BeautifulSoup(data)

for link in soup.find_all('a'):
    print(link.get('href'))