![logo2](https://user-images.githubusercontent.com/644179/196201277-cad519b5-db00-4e5f-be3f-c478b3082200.png)

Simple helpers to count percentage and more.

````bash
> Install-Package PercentageNET -Version 1.0.0
````

## Documentation

Count 20% from 1000:

````csharp 
var result = PercentageHelper.Count(1000, 20);
// result = 200
````

Substract 20% from 1000

````csharp
var result = PercentageHelper.Substract(1000, 20);
// result = 800
````

Add 20% to 1000 (simple mode)

````csharp
var result = PercentageHelper.Add(1000, 20);
// result = 1200
````

Add 20% to 1000 (upcharge mode[^1])

````csharp
var result = PercentageHelper.Add(1000, 20, AddMode.Upcharge);
// result  = 1250
````

## Todo
- [ ] Tests
- [ ] More helpers

[^1]: For example you need to upcharge your items for sale. Use this mode to get "real" percentage for following discount on this amount.
