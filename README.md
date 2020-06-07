# BaseMVCNoEntity
Base Project for Web Application (Without Entity Framework)

Sebuah Base project untuk membuat Web Application tanpa harus membuat ulang di Visual Studio
Project ini sudah Termasuk contoh kode untuk membuat CRUD sederhana

Cara pemakaian :
1. Download Source Code dan Ekstrak data
2. Jalankan Script DB di folder DB, untuk membuat database dan Tablenya (Recommend : menggunakan SQL Server 2017)
3. Install Visual Studio (Recommend : VS 2019)
4. Buka Folder BaseMVCNoEntity Lalu jalankan BaseMVCNoEntity.sln
5. Jalankan Project

Requirement Project
1. .Net Framework 4.6.1
2. SQL Server 12++
3. Visual Studio 2017++

Kelengkapan Project sudah meliputi :
1. Bootstrap 3.1
2. JQuery 3.4.1
3. JQuery Validate

Hal yang tidak termasuk dalam project :
1. WebAPI (API controller bisa gunakan, namun WebApiConfig belum berubah)

Flow Data Project :
UI -> Controller/ApiController -> (Penghubungnya menggunakan Model) -> BussinessLayer (BLL) -> Data Access (DAL) -> DB
