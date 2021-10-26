Create Database StudentsOnCloud

Create Table Kullanici_Bilgisi(

id int primary key identity(1,1)not null,
kullanici_adi nvarchar(50),
sifre nvarchar(50),
)


insert into Kullanici_Bilgisi values ('serhadozel07','426936qwe')

select *from Kullanici_Bilgisi