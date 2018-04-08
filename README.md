# Test_Training
Project seqence
--
- 1.XmasChecker
    - for dependency can't control
    - production code can't change signature
- 2.AssertionSamples
    - compare object by properties
    - partial compare
    - verify Exceptions
- 3.RsaSecureToken
    - learn dependency by Interface
    - stub/mock framework (NSubstitute)
    - DI / IoC
- 4.IsolatedByInheritanceAndOverride
    - isolated by inheritance and virtual keyword
    - mock object to verify
- 5.BaseClassCoupling
    - isolated static dependency
    - inheritance override
    - property injection

tips: 傳入 stub 物件的多種方式，可參考：
--
http://www.dotblogs.com.tw/hatelove/archive/2012/11/27/learning-tdd-in-30-days-day6-several-ways-to-isolate-object-dependency-and-easy-for-testing.aspx

- 1. 透過 target 的 constructor 傳入 interface/abstract 的 instance (DI auto-wiring)
- 2. 透過 target 的 public property 傳入 (DI auto-wiring)
- 3. target 方法的參數 (常看到傳入的參數型別為 interface的那種情況)
- 4. target 將欲 stub 的方法擷取成 protected virtual 方法，使用 繼承 + override 的方式來測試原始target class
