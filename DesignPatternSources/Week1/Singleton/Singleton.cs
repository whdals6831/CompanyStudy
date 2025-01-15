namespace Singleton;

public class Singleton<T> where T : class
{
    // new()는 컴파일 타임에 결정 하지만
    // Activator.CreateInstance는 디자인 타임에 결정됨
    // 지정한 유형의 인스턴스를 동적으로 생성 가능
    // 리플렉션을 사용하여 상대적으로 느림
    // private 생성자도 접근가능함
    private static readonly Lazy<T> _lazy = 
        new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);

    public static T Instance => _lazy.Value;
    
    protected Singleton() { }
}