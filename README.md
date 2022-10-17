![logo](https://user-images.githubusercontent.com/644179/196199839-9227a625-3423-46bc-adcd-67464f51348c.png)

Simple helpers to count percentage and more.

`Install-Package PercentageNET -Version 1.0.0`

## Documentation

1. Count 20% from 1000:

`.Count(1000, 20)` = 200

2. Substract 20% from 1000%

`.Substract(1000, 20)` = 800

3.1 Add 20% to 1000 (simple mode)

`.Add(1000, 20)` = 1200

3.2 Add 20% to 1000 (upcharge mode)

`.Add(1000, 20, AddMode.Upcharge)` = 1250
