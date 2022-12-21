create table TB_LABRARY1
(
BookUid int primary key
,BookName varchar(50)
,AuthorName varchar(50)
,YearOfPrinting date
)


create proc SP_TB_LABRARY1

as
begin
select * from TB_LABRARY1
end
exec SP_TB_LABRARY1
insert into TB_LABRARY1 values(
 @BookUid 
,@BookName 
,@AuthorName 
,@YearOfPrinting )
@BookUid int 
,@BookName varchar(50)
,@AuthorName varchar(50)
,@YearOfPrinting date



create table TB_LIBRARY2
(
BookUid int
,BookName varchar(50)
,AuthorName varchar(50)
,YearOfPrinting date
,BranchCategory varchar(50)
,Room int
)


create proc SP_TB_LIBRARY2
(
@BookUid int
,@BookName varchar(50)
,@AuthorName varchar(50)
,@YearOfPrinting date
,@BranchCategory varchar(50)
,@Room int
)
as 
begin
insert into TB_LIBRARY2 values(
@BookUid= 
,@BookName 
,@AuthorName 
,@YearOfPrinting 
,@BranchCategory 
,@Room )
end


create  proc SP_LibraryStudent
(
@StudentId int
,@StudentName varchar(50)
,@Year int
,@Branch varchar(50)
,@StudentPassword varchar(50)
)
as begin
insert into LibraryStudent values
(
@StudentId 
,@StudentName 
,@Year 
,@Branch
,@StudentPassword 
)
end
 create table LibraryStudent
 (
  StudentId int
,StudentName varchar(50)
,Year int
,Branch varchar(50)
,StudentPassword varchar(50)
  )



select  * from LibraryStudent
select *  from  TB_LABRARY1
select * from TB_LIBRARY2

insert into LibraryStudent values(1,'pavan',2,'cse','pavan')
insert into LibraryStudent values(2,'kumar',4,'cse1','pavan')
insert into LibraryStudent values(3,'puppala',3,'civil','pavan')
insert into LibraryStudent values(4,'naveen',1,'mech','pavan')

insert into TB_LABRARY1 values(1,'c','berg','01-01-2000',)
insert into TB_LABRARY1 values(2,'c++','berg2','01-02-2000')
insert into TB_LABRARY1 values(3,'math','aryabatta','01-02-2000')
insert into TB_LABRARY1 values(4,'eletrical','elev','01-02-2000')

insert into  TB_LABRARY1 values (5,'python','nag','10-10-2000')
insert into  TB_LABRARY1 values (6,'java','rajesh','01-10-2000')
insert into  TB_LABRARY1 values (7,'c#','happy','02-10-2000')
insert into  TB_LABRARY1 values (8,'perl','null','03-10-2000')



insert into TB_LIBRARY2 values(1,'c','berg','01-01-2000','prog',1)
insert into TB_LIBRARY2 values(2,'c++','berg2','01-02-2000','match',2)
insert into TB_LIBRARY2 values(3,'math','aryabatta','01-02-2000','logic',3)
insert into TB_LIBRARY2 values(4,'eletrical','elev','01-02-2000','lang',4)

insert into  TB_LIBRARY2 values (5,'python','nag','10-10-2000','law',5)
insert into  TB_LIBRARY2 values (6,'java','rajesh','01-10-2000','branch',6)
insert into  TB_LIBRARY2 values (7,'c#','happy','02-10-2000','prog',7)
insert into  TB_LIBRARY2 values (8,'perl','null','03-10-2000','lang',8)



create table TB_LIBRARYTASK
(
BookUid int
,BookName varchar(50)
,AuthorName varchar(50)
,YearOfPrinting date
,LibraryCode varchar(50)
,LPassword varchar(50)
)
create proc SP_TB_LIBRARYTASK
(
@BookUid int
,@BookName varchar(50)
,@AuthorName varchar(50)
,@YearOfPrinting date
,@LibraryCode varchar(50)
,@LPassword varchar(50)
)
as 
begin
insert into  TB_LIBRARYTASK values
(
@BookUid 
,@BookName 
,@AuthorName 
,@YearOfPrinting 
,@LibraryCode 
,@LPassword 
)
end

select * from TB_LIBRARYTASK

select 
BookUid 
,BookName 
,AuthorName 
,YearOfPrinting 
,LibraryCode 
,LPassword
 ,StudentId 
,StudentName 
,Year 
,Branch 
,StudentPassword 
 from TB_LIBRARYTASK inner join LibraryStudent on TB_LIBRARYTASK.BookUid=LibraryStudent.StudentId;

 create proc sp_tb_LibraryStudent
 as 
 begin
 select * from LibraryStudent
 end

 select * from tb_Student

 ----------------------------------------------------------------------
 --------------------------------------------------------------------
 ------------------------------------------------------------------------

 create  table TB_STUDENTDATA
 (
 StudentId int primary key
,StudentName varchar(50)
,Year int
,Branch varchar(50)
,StudentPassword varchar(50)
,CollegeId int 
  )


  create table TB_LIBRARYBOOKINSERTDATA
  (
  BookUid int
,BookName varchar(50)
,AuthorName varchar(50)
,YearOfPrinting date
,BranchCategory varchar(50)
,Room int
,CollegeId int
  )
  create table TB_LIBRARYPASSTASK
  (
 BookUid int
,BookName varchar(50)
,AuthorName varchar(50)
,YearOfPrinting date
,LibraryCode varchar(50)
,LPassword varchar(50)
,CollegeId varchar(50)

  )

  create table TB_REGISTRATIONFORM
  (
  StudentId int primary key
  ,StudentName varchar(50)
  ,StudentPassword varchar(50)
  )
  

  create proc SP_TB_STUDENTDATA
  as begin
  select * from TB_STUDENTDATA
  end

  
  create proc SP_TB_LIBRARYPASSTASK
  as begin
  select * from TB_LIBRARYPASSTASK
  end

   
  create proc SP_TB_LIBRARYBOOKINSERTDATA
  as begin
  select * from TB_LIBRARYBOOKINSERTDATA
  END

    select StudentId,StudentPassword,LibraryCode,LPassword from TB_STUDENTDATA inner join TB_LIBRARYPASSTASK on 
	TB_STUDENTDATA.CollegeId=TB_LIBRARYPASSTASK.CollegeId

  SELECT * FROM TB_STUDENTDATA
  SELECT * FROM TB_LIBRARYBOOKINSERTDATA
  SELECT * FROM TB_LIBRARYPASSTASK
  SELECT * FROM TB_REGISTRATIONFORM
