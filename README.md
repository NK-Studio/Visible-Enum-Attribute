# Visible Enum Attribute
![image01.png](Image%2Fimage01.png)
유니티의 Enum 타입 변수를 인스펙터에서 선택 가능하게 만들어주는 Attribute입니다.

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

