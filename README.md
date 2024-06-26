# CYJ_CrossyRoad
- **구현 사항:**
    1. ~~**키보드 입력 처리**~~ (난이도: ★☆☆☆☆) `Input System` **`입문 6강`**
        - 방향키를 이용하여 플레이어가 좌우 위치를 바꾸거나 앞으로 이동할 수 있도록 하는 기능입니다.   

    2. ~~**오브젝트 생성 기능**~~ (난이도: ★☆☆☆☆) `Prefab` **`입문 9강`**
        - 자동차, 나무, 도로 등의 오브젝트를 미리 만들어 Prefab화 해놓고, 플레이어 진행 시 자동으로 생성/삭제가 되는 기능을 구현하세요.   
       
        **자동차만 오브젝트풀로 생성은 되는 상태**   
          
          
    3. ~~**충돌 기능**~~ (난이도: ★☆☆☆☆) `Collider` **`입문 7강`**
        - 충돌 시 게임오버가 되는 기능을 구현 하세요.
        - 동전 아이템을 구현했다면, 동전 아이템 충돌 시 가지고 있는 돈이 올라가는 기능을 구현해주세요.   
      
          **동전과 충돌시 동전은 사라지고 동전 UI가 올라감(1점)**   
          
    4. ~~**애니메이션 기능**~~ (난이도: ★☆☆☆☆) `Animation` `Animator` **`입문 13강`**
        - 플레이어 캐릭터가 가만히 있을 때, 이동, 피격할 때의 애니메이션을 구현해주세요.   
          
    5. ~~**점수 UI 시스템**~~ (난이도: ★★☆☆☆) `UGUI` **`숙련 4강`**  `Coroutine` **`숙련 5강`**
        - 일정 시간마다 점수가 올라가는 기능을 구현하세요.
        - 점수와 소유한 돈의 변화가 있을 때마다 해당 상태가 UI에 반영되는 기능을 구현하세요.
      
          **현재 5초마다 10점씩 올라감**

    6. ~~**사운드 효과**~~ (난이도: ★★☆☆☆) `사운드 시스템` **`심화 2강`**
        - 이동, 아이템 획득, 피격 시의 효과음을 추가하세요.   
          
          **이동, 점프, 코인획득 시 소리 남**   
          
    7. ~~**파티클 효과**~~ (난이도: ★★☆☆☆) `파티클 시스템` **`심화 1강`**
        - 캐릭터가 폭죽이 있는 라인을 지날 때, 폭죽이 터지면서 다양한 파티클이 생기는 기능을 구현하세요.   
       
          **골패드 밟으면 불꽃놀이 파티클 활성화**
          
    8. ~~**자동차 데이터 관리**~~ (난이도: ★★★☆☆) `ScriptableObject` **`입문 10강`**
        - 여러 자동차의 속도, 색깔, 크기 등의 데이터를 ScriptableObject로 통합 관리 하세요.
        - 모든 자동차를 하나의 Prefab으로부터 생성하면서, 자동차의 데이터를 받고 있는 ScriptableObject를 입력으로 받아 초기화하는 기능을 생성하세요.   
          
    9. ~~**오브젝트 생성~~/삭제 최적화** (난이도: ★★★☆☆) `Object Pool` **`입문 12강`**
        - Object Pool을 이용하여 오브젝트의 생성/삭제가 반복적으로 이루어지는 상황에서 가비지를 최소화해주세요.
        - 추천: 생성 및 파괴되는 자동차를 Object Pool로 관리해주세요.   

          **8,9번이 어려워서 제대로 못하였음**   

          
