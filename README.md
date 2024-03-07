# `Stock Management API` created by *Tohirjon.*

## Loyiha ustunliklari
* Seeddata -> ya'ni dasturda default qiymat mavjud.
* Hashing password -> databazaga password hashlanib tushadi.
* Configuration -> har bir table uchun alohida sozlamalari mavjud.
* Table'lar bir-biriga relation bo'lgan.
* Login qismida tasdiqlash uchun email'ga xabar jo'natadi.
* Password va Email uchun regex ishlatilgan
* Loyihada user-secret texnalogiyasi orqali turlixildagi appsettings.json ichidagi tarqalishi mumkin bo'lmagan ma'lumotlar yashirilgan uni sozlash uchun yoriqnomaga amal qiling
> Exam.StockManagement.APi'ga terminal orqali kirilib. Ushbi buyrug'lar kiritiladi.
```
dotnet user-secrets init
dotnet user-secrets set "JWT:ValidIssuer" "127.0.0.1"
dotnet user-secrets set "JWT:ValidAudience" "StockManagement"
dotnet user-secrets set "JWT:Secret" "Your Secret Kod 32dan oshishi kerak"
dotnet user-secrets set "JWT:ExpireDate" "1000"
dotnet user-secrets set "EmailSettings:SenderName" "Najot Ta'lim"
dotnet user-secrets set "EmailSettings:Sender" "app yaratilgan email kiritilishi kerak"
dotnet user-secrets set "EmailSettings:Password" "appdagi kalit kiritilishi kerak"
dotnet user-secrets set "EmailSettings:MailServer" "smtp.gmail.com"
dotnet user-secrets set "EmailSettings:MailPort" "587"
dotnet user-secrets set "ConnectionStrings:StockManagementConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=DatabasePassword;Database=TesDBProduct;"
dotnet user-secrets set "AllowedHosts" "*"
```
## Autorizatsiya qismi
> Ushbu controller user'larni ro'yhatga olish va user yokida adminligiga qarab ruhsatlarni berish uchun hizmat qiladi

![image](https://github.com/Tohirjon-Odilov/Exam.StockManagement/assets/82634626/4e423b3d-1641-4b78-b110-4ff168b3cd56)

## Category qismi
> Bu yerga product'larni turlari kiritiladi

![image](https://github.com/Tohirjon-Odilov/Exam.StockManagement/assets/82634626/23518f3d-4ba4-4c01-aa0f-ac3ee11df3f6)

## Product qismi 

![image](https://github.com/Tohirjon-Odilov/Exam.StockManagement/assets/82634626/2cdfdd6b-7ed8-4b9f-8d5d-1e0c94e6d741)

## Statistika qismi

![image](https://github.com/Tohirjon-Odilov/Exam.StockManagement/assets/82634626/f432e135-3c4a-41db-8f1f-808cf5885ab9)

## User qismi

![image](https://github.com/Tohirjon-Odilov/Exam.StockManagement/assets/82634626/7f2aa9ad-01ce-411f-b83b-a1f96bf8cf81)

> Email uchun validation

![image](https://github.com/Tohirjon-Odilov/Exam.StockManagement/assets/82634626/9bfa8c29-f71f-4f5b-abb3-e9ae0029a819)

> Password uchun validation

![image](https://github.com/Tohirjon-Odilov/Exam.StockManagement/assets/82634626/5f7eedaa-231f-499f-b6cf-7b5c06fb48bc)


