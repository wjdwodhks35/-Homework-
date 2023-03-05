# fish-Homework

## 낚시해 본적 없는 사람이 만든 낚시하는 게임

- 제작자 : 정재완
- 제작기간  : 2/26~3/05
- 게임 설명 : 낚시로 물고기를 낚을 수 있으며 낚은 물고기에 따라 피로도가 쌓인다. 피로도가 100이 되면 더이상 낚시를 할수 없으며 100을 초과하면 강제로 집에 가진다.
낚시를 하며 돈을 벌고 번 돈으로 장비를 구매하거나 특정 장소에 이동할 수 있다.
상점에서 구매한 낚시대를 사용하면 물고기를 낚을 확률이 올라가며 약을 사용하면 부작용으로 다음날 (사용한 횟수)*10으로 피로도가 쌓인다.
날씨가 좋지 않으면 위험도가 상승하며 위험에 노출되면 모든 돈을 잃을 수 있다.
- 최종 목표 : 잡은 물고기들을 팔아서 10만원을 벌면 끝이 납니다.
### 배운점
- 배운 점 : 타이머를 만드는 법을 몰라 선생님의 도움을 받았고, 덕분에 토큰이라는 존재를 알게 되었다.
getch와 같은 역할인 ReadKey를 알았다. 평소에는 모듈화를 쓸 상황이 없어 안써왔었지만 static이 같은 class에서만 사용할 수 있다는 것을 알았다.
### 사용한 코드
- 화면을 전환 할때마다 화면에 글이 누적되어 Clear를 사용
- 할 수 있다면 왠만한 변수는 private를 씀
- 변수 안의 값이 변하면 안되는 것들에는  static을 사용하였다. 
-타이머는 token을 활용
- 글자에 ForegroundColor 을 사용해 색을 바꿈
- 보기 하게 하기 위해 #region을 사용하였다.
- 모듈화 한것들
![image](https://user-images.githubusercontent.com/110615719/222947803-bafdb8b4-5780-4784-9d7d-c39a007458cd.png)
- 시작
![image](https://user-images.githubusercontent.com/110615719/222946799-cb21bebf-3311-4972-88b5-ffdfe6dd80ad.png)
- 내부 기능
![image](https://user-images.githubusercontent.com/110615719/222946818-e0864c0f-9274-4c04-a087-f9258569d9f6.png)
- 총괄
![image](https://user-images.githubusercontent.com/110615719/222946831-a20a9717-b010-46e3-8df7-06d717ebd814.png)
- 얻은 것들 모음
![image](https://user-images.githubusercontent.com/110615719/222946775-0b8f0f4f-ae9f-4687-901d-77198d11f249.png)
크게 이렇게 나눌수 있다.
### 인게임 화면
-시작 
![image](https://user-images.githubusercontent.com/110615719/222948033-4171f60d-3351-40ee-90a3-3e5f1ebbd247.png)
- 처음 들어갔을때 화면
![image](https://user-images.githubusercontent.com/110615719/222948249-b2d9b5fc-19b7-4040-bdd2-affb4c9fb183.png)
- 상점
![image](https://user-images.githubusercontent.com/110615719/222948082-cf80c7b8-0812-41f8-bebf-427e452fce3c.png)
- 낚시터
![image](https://user-images.githubusercontent.com/110615719/222948092-15f5768d-d2cf-4e35-9fe6-d0d2506aef40.png)
### 플레이 화면


https://user-images.githubusercontent.com/110615719/222949294-646822fd-74c0-466b-857c-ad6ff0b1a371.mp4


