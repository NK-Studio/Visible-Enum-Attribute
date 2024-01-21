# Visible Enum Attribute
## 소개

![image01.png](Image%2Fimage01.png)
유니티의 Enum 타입 변수를 인스펙터에서 선택 가능하게 만들어주는 Attribute입니다.

## 설치
### Git UPM
Visible Enum 패키지를 설치하려면 다음 단계가 필요합니다.
1. Git이 설치되어 있는지 확인하십시오.
2. Package Manager를 오픈합니다.
3. +버튼을 클릭하고, Add package from git URL을 클릭합니다.
4. `https://github.com/NK-Studio/Visible-Enum-Attribute.git#UPM` 를 입력하고 추가 버튼을 클릭하세요.
   
### Unity Package
[Releases](https://github.com/NK-Studio/Visible-Enum-Attribute/releases)에서 최신 버전의 패키지를 다운로드 받아 설치합니다.
## 사용법
```cs
public enum EFruit
{
    Apple,
    Banana,
    Orange,
    Pear,
}

public class TestCode : MonoBehaviour
{
    [VisibleEnum(typeof(EFruit))]
    public void OnChangeFruit(int fruit)
    {
        EFruit fruitEnum = (EFruit)fruit;
        Debug.Log($"Fruit : {fruitEnum}");
    }
}
```

