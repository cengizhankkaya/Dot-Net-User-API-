# Flutter Project with .NET API and SQL Database

Bu proje, bir Flutter mobil uygulaması ile .NET Core Web API kullanarak bir SQL Server veritabanına bağlanmayı amaçlamaktadır.

## İçindekiler
## API CRUD İşlemleri

### Kullanıcı Tablosu CRUD İşlemleri

#### 1. Kullanıcıları Listeleme

- **Yöntem**: GET
- **Endpoint**: `/api/users`
- **Açıklama**: Tüm kullanıcıları listelemek için bu endpoint'i kullanabilirsiniz.
- **Örnek İstek**:

  ```http
  GET /api/users HTTP/1.1
  Host: localhost:5000

  2. Yeni Kullanıcı Oluşturma
Yöntem: POST
Endpoint: /api/users
Açıklama: Yeni bir kullanıcı eklemek için kullanılır.
Gereken Veri: JSON formatında kullanıcı bilgileri.
Örnek İstek:
POST /api/users HTTP/1.1
Host: localhost:5000
Content-Type: application/json

{
  "fullName": "Ali Veli",
  "email": "aliveli@example.com",
  "departmentId": 1,
  "genderId": 2,
  "isOfficeEmployee": true,
  "status": "Aktif"
}
3. Kullanıcı Bilgilerini Getirme
Yöntem: GET

Endpoint: /api/users/{id}

Açıklama: Belirtilen id değerine sahip kullanıcı bilgilerini getirir.

Örnek İstek:
GET /api/users/1 HTTP/1.1
Host: localhost:5000

4. Kullanıcı Bilgilerini Güncelleme
Yöntem: PUT

Endpoint: /api/users/{id}

Açıklama: Belirtilen id değerine sahip kullanıcının bilgilerini günceller.

Gereken Veri: JSON formatında güncellenmiş kullanıcı bilgileri.

Örnek İstek:
PUT /api/users/1 HTTP/1.1
Host: localhost:5000
Content-Type: application/json

{
  "fullName": "Ali Veli",
  "email": "aliveli@example.com",
  "departmentId": 1,
  "genderId": 2,
  "isOfficeEmployee": false,
  "status": "Pasif"
}
5. Kullanıcı Silme
Yöntem: DELETE

Endpoint: /api/users/{id}

Açıklama: Belirtilen id değerine sahip kullanıcıyı siler.

Örnek İstek:
DELETE /api/users/1 HTTP/1.1
Host: localhost:5000

Bu endpointler, kullanıcı tablosu üzerinde temel CRUD işlemlerini gerçekleştirmenizi sağlar. Her bir istek, doğru formatta ve gerekli verilerle yapılmalıdır. API'yi kullanmadan önce veritabanınızın yapılandırıldığından ve API'nizin çalıştığından emin olun.




- **Flutter Mobil Uygulama**: Kullanıcı dostu arayüz ve işlevsellik.
- **.NET Core Web API**: Güvenilir ve hızlı sunucu tarafı işlemleri.
- **SQL Server Veritabanı**: Veri depolama ve yönetimi.

## Gereksinimler

- [Flutter](https://flutter.dev/docs/get-started/install)
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)


