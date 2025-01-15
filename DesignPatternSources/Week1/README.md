# Singleton 패턴

- 단 하나의 유일한 객체를 만들기 위한 디자인 패턴
- 전역 단일 접근 지점 제공
- 인스턴스 생성에 따른 불필요한 리소스 낭비를 방지할 수 있음
- 동기화 관리 용이


### 간단한 싱글톤
- Thread-Safe 하지 않음
```csharp
public sealed class Singleton 
{
    private static Singleton _instance = null;
  
    private Singleton()
    {
      
    }
  
    public static Singleton Instance
    {
        get 
        {
            if (_instance == null) 
            {
                return _instance = new Singleton();
            }
            else
            {
                return _instance;
            }
        }
    }
}
```


### Double-Checked Locking Pattern 싱글톤
- Thread-Safe
- 첫 번째 null 체크를 통해 이미 초기화된 경우에는 `lock`을 사용하지 않아 성능 손실을 줄임
- `Lazy<T>`를 사용하는 방법도 있음
```csharp
public class Singleton<T> where T : class, new()
{
    // 싱글톤 인스턴스를 저장할 정적 필드
    private static T _instance = null;
    private static readonly object _lock = new object();

    // 외부에서 접근할 수 있는 프로퍼티
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                }
            }

            return _instance;
        }
    }

    // 생성자를 private으로 선언하여 외부에서 인스턴스 생성 불가
    private Singleton() { }
}
```

### 정적 초기화 싱글톤
- CLR(Common Language Runtime)에 의해 자동으로 초기화 되는 방식
- 멀티 스레드 환경에서도 안전하게 객체 생성 가능 (.NET 4 이후)
- 즉시 초기화 방식으로 인스턴스 생성 비용에 따라 지연 초기화 방식인 `Lazy<T>`와 적절하게 섞어서 사용
```csharp
public sealed class Singleton
{
    // 정적 필드로 싱글톤 인스턴스 생성
    private static readonly Singleton _instance = new Singleton();

    // 외부에서 접근할 수 있는 프로퍼티
    public static Singleton Instance => _instance;

    // 생성자를 private으로 선언하여 외부에서 인스턴스 생성 방지
    private Singleton()
    {
        
    }
}
```

### 문제점
- 클래스 사이의 의존성이 높아진다.
  - 즉, 한개를 수정하면 다른 것들을 수정할 가능성이 높아짐
  - 개방-폐쇄 원칙 위배
- 테스트하기가 어렵다.
  - 독립적으로 실행되어야 하는 테스트가 공유된 자원으로 정상적인 수행이 못될 가능성이 있다. 

### 개선 방법
- Dependency Injection을 사용하자.