import time
from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys

s = Service(ChromeDriverManager().install())
driver = webdriver.Chrome(service=s)
driver.get("https://moodle2223.vtc.edu.hk/login/index.php")
print(driver.title)
print(driver.current_url)
search_button = driver.find_element(By.XPATH, '/html/body/div[3]/div/div[2]/div[1]/div/div/div/div/div/div[2]/div/div/div/div/div[1]/div/a')
search_button.click()
search_bar = driver.find_element(by=By.NAME, value="UserName")
search_bar.clear()
search_bar.send_keys("200218864@stu.vtc.edu.hk")

time.sleep(60)
driver.close()
