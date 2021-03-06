if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_tblBookTicket]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_tblBookTicket]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_tblBusInfo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_tblBusInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_tblCompanyInfo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_tblCompanyInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_tblEmployees]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_tblEmployees]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_tblFeedback]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_tblFeedback]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_tblMailaFriend]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_tblMailaFriend]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_tblUsers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sp_tblUsers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblAdmin]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblAdmin]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblBookTicket]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblBookTicket]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblBusInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblBusInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblCompanyInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblCompanyInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblEmployees]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblEmployees]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblFeedback]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblFeedback]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblMailaFriend]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblMailaFriend]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tblUsers]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tblUsers]
GO

CREATE TABLE [dbo].[tblAdmin] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Password] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblBookTicket] (
	[TicketID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[FullName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Phone] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Mobile] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Gender] [char] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Address] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IDCardType] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IDCardNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[IssuingAuthority] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PaymentMode] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Source] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Destination] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SeatNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[JourneyDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ServiceNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NoOfPassengers] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AvailableSeats] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StartTime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BusType] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TravelName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Fare] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BoardingPoint] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TotalAmount] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ServiceTax] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TransactionFee] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NetAmount] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BookedDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblBusInfo] (
	[ServiceID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[ServiceName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ServiceNumber] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[TravelName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BusType] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Source] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Destination] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StartTime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ReachTime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Fare] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NoOfSeatsAvailable] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DateOfJourney] [datetime] NULL ,
	[AllotedDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblCompanyInfo] (
	[CompanyID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[CompanyName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Description] [varchar] (350) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Address] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CompanyLogo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CreatedDate] [datetime] NULL ,
	[UpdatedDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblEmployees] (
	[EmployeeID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[EmployeeName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Designation] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Address] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Mobile] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AllotedToBranch] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CreatedDate] [datetime] NULL ,
	[UpdatedDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblFeedback] (
	[FeedbackID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[UserName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Mobile] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Phone] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Subject] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Comments] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RatingOfSite] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SendDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblMailaFriend] (
	[ID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[YourEmailID] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FriendsEmailID1] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EmailID2] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EmailID3] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EmailID4] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EmailID5] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StandardContent] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Comments] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SendDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblUsers] (
	[UserID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[UserName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Password] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Mobile] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Phone] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Country] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[City] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Address] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Status] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CreatedDate] [datetime] NULL ,
	[UpdatedDate] [datetime] NULL 
) ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE  PROCEDURE sp_tblBookTicket
(
@TicketID [bigint]=0 output,
@FullName [VarChar](50)=null,
@Mobile [VarChar](50)=null,
@Gender [char](1)=null,
@Email [VarChar](50)=null,
@Address [VarChar](50)=null,
@IDCardType varchar(50)=null,
@IDCardNumber [VarChar](50)=null,
@IssuingAuthority [VarChar](50)=null,
@PaymentMode [VarChar](50)=null,
@Source varchar(50)=null,
@Destination [VarChar](50)=null,
@SeatNumber [VarChar](50)=null,
@JourneyDate [VarChar](50)=null,
@ServiceNumber varchar(50)=null,
@NoOfPassengers [VarChar](50)=null,
@AvailableSeats [VarChar](50)=null,
@BusType [VarChar](50)=null,
@TravelName varchar(50)=null,
@BoardingPoint varchar(50)=null,
@TotalAmount [VarChar](50)=null,
@ServiceTax [VarChar](50)=null,
@TransactionFee [VarChar](50)=null,
@StartTime [VarChar](50)=null,
@Fare [VarChar](50)=null,
@Phone [VarChar](50)=null,
@NetAmount varchar(50)=null,
@BookedDate [DateTime]=null,
@strIds varchar(500)=null,
@Type char(1)
)
AS
begin

if(@Type='I')
begin
	
INSERT INTO tblBookTicket(FullName, Mobile,Gender,Email,Address,IDCardType,IDCardNumber,IssuingAuthority,Phone,
PaymentMode, TravelName, BusType, Source,Destination,StartTime,Fare,SeatNumber,JourneyDate,ServiceNumber,
NoOfPassengers,AvailableSeats,BoardingPoint,TotalAmount,ServiceTax,NetAmount,TransactionFee,BookedDate)
VALUES(@FullName,@Mobile,@Gender,@Email,@Address,@IDCardType,
@IDCardNumber,@IssuingAuthority,@Phone,@PaymentMode,@TravelName,@BusType,@Source,@Destination,@StartTime,@Fare,
@SeatNumber,@JourneyDate,@ServiceNumber,@NoOfPassengers,
@AvailableSeats,@BoardingPoint,@TotalAmount,@ServiceTax,@NetAmount,@TransactionFee,
getdate())
select @TicketID=scope_identity()
			
		
	
end

if(@Type='S')
begin

select * from tblBookTicket
end

end




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE   PROCEDURE sp_tblBusInfo
(
@ServiceID [bigint]=0 output,
@ServiceName [VarChar](50)=null,
@ServiceNumber [VarChar](50)=null,
@TravelName [VarChar](50)=null,
@BusType [VarChar](50)=null,
@Source [VarChar](50)=null,
@Destination varchar(50)=null,
@StartTime [VarChar](50)=null,
@ReachTime [VarChar](50)=null,
@Fare [VarChar](50)=null,
@NoOfSeatsAvailable varchar(50)=null,
@DateOfJourney [DateTime]=null,
@AllotedDate [DateTime]=null,
@strIds varchar(500)=null,
@SearchString varchar(300)=null,
@Type char(1)
)
AS
begin
if(@Type='I')
begin
	
			INSERT INTO tblBusInfo(ServiceName, ServiceNumber, TravelName, BusType, Source,Destination,StartTime,ReachTime,Fare,
			NoOfSeatsAvailable,DateOfJourney,AllotedDate)VALUES(@ServiceName,@ServiceNumber,@TravelName,@BusType,@Source,
			@Destination,@StartTime,@ReachTime,@Fare,@NoOfSeatsAvailable,@DateOfJourney,getdate())
			
		
	
end
if(@Type='U')
begin
	UPDATE tblBusInfo SET ServiceName=@ServiceName,ServiceNumber =@ServiceNumber,
	TravelName=@TravelName,StartTime=@StartTime,ReachTime=@ReachTime,Fare=@Fare,DateOfJourney=@DateOfJourney,
	 BusType =@BusType, Source =@Source,Destination=@Destination,NoOfSeatsAvailable=@NoOfSeatsAvailable,
	AllotedDate=getdate() where ServiceID=@ServiceID
end

if(@Type='T')
begin
         select ServiceName,ServiceNumber,TravelName,BusType,Source,Destination,StartTime,ReachTime,Fare,NoOfSeatsAvailable,DateOfJourney,convert(varchar(20),AllotedDate,106) as AllotedDate
 from tblBusInfo where ServiceID=@ServiceID
end
if(@Type='S')
begin

select * from tblBusInfo
end
if(@Type='D')
begin
          Exec('Delete from tblBusInfo where ServiceID in('+@StrIds+')')
end
if(@Type='R')
begin

select Fare,TravelName,BusType,Source,Destination,StartTime,NoOfSeatsAvailable,convert(varchar(20),DateOfJourney,103) as DateOfJourney from tblBusInfo where ServiceNumber=@ServiceNumber
end
if(@Type='Z')
begin
exec('select *,convert(varchar(20),DateOfJourney,101) as DateOfJourneyFMT from tblBusInfo where '+@SearchString+'')

end

end




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE  PROCEDURE sp_tblCompanyInfo
(
@CompanyID [bigint]=0 output,
@CompanyName [VarChar](350)=null,
@Description [VarChar](100)=null,
@Address [VarChar](50)=null,
@CompanyLogo [VarChar](50)=null,
@CreatedDate [DateTime]=null,
@UpdatedDate [DateTime]=null,
@Type char(1)
)
AS
begin
if(@Type='I')
begin
	
			INSERT INTO tblCompanyInfo(CompanyName, Description, Address, CompanyLogo,
			CreatedDate)VALUES(@CompanyName,@Description,@Address,
			@CompanyLogo,getdate())
			
		
	end
if(@Type='U')
begin
	UPDATE tblCompanyInfo SET CompanyName=@CompanyName,Description =@Description, 
	Address=@Address,
	 CompanyLogo =@CompanyLogo,
	UpdatedDate=getdate() where CompanyID=@CompanyID
end
if(@Type='S')
begin
          select * from tblCompanyInfo
end
if(@Type='T')
begin
         select CompanyName,Description,Address,convert(varchar(20),CreatedDate,106) as CreatedDate
 from tblCompanyInfo where CompanyID=@CompanyID
end
end
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE  PROCEDURE sp_tblEmployees
(
@EmployeeID [bigint]=0 output,
@EmployeeName [VarChar](50)=null,
@Designation [VarChar](50)=null,
@Email [VarChar](50)=null,
@Address [VarChar](50)=null,
@Mobile [VarChar](50)=null,
@AllotedToBranch varchar(50)=null,
@CreatedDate [DateTime]=null,
@UpdatedDate [DateTime]=null,
@StrEmployeeIds varchar(1000)=null,
@strLetter varchar(50)=null,
@strEmpIds varchar(500)=null,
@strIds varchar(500)=null,
@Type char(1)
)
AS
begin
if(@Type='I')
begin
	if not exists(select * from tblEmployees where EmployeeName=@EmployeeName)
	begin
			INSERT INTO tblEmployees(EmployeeName, Designation, Email, Address, Mobile,AllotedToBranch,
			CreatedDate)VALUES(@EmployeeName,@Designation,@Email,@Address,@Mobile,
			@AllotedToBranch,getdate())
			select @EmployeeID=scope_identity()
		
		
	end
	
end
if(@Type='U')
begin
	UPDATE tblEmployees SET AllotedToBranch=@AllotedToBranch,Address =@Address, 
	Designation=@Designation,EmployeeName=@EmployeeName,
	 Mobile =@Mobile, Email =@Email,
	UpdatedDate=getdate() where EmployeeID=@EmployeeID
end

if(@Type='T')
begin
         select EmployeeName,Designation,Email,Mobile,Address,AllotedToBranch,convert(varchar(20),CreatedDate,106) as CreatedDate
 from tblEmployees where EmployeeID=@EmployeeID
end
if(@Type='S')
begin
  select * from tblEmployees

end
if(@Type='D')
begin
          Exec('Delete from tblEmployees where EmployeeID in('+@StrIds+')')
end
end



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE  PROCEDURE sp_tblFeedback
(
@FeedbackID [bigint]=0 output,
@UserName [VarChar](50)=null,
@Email [VarChar](50)=null,
@Mobile [VarChar](50)=null,
@Phone [VarChar](50)=null,
@Subject [VarChar](50)=null,
@Comments [VarChar](250)=null,
@RatingOfSite varchar(50)=null,
@SendDate datetime=null,
@strIds varchar(500)=null,
@Type char(1)
)
AS
begin

if(@Type='I')
begin
		INSERT INTO tblFeedback(UserName, Email,Mobile,Phone,Subject,Comments,RatingOfSite,SendDate)
		VALUES(@UserName,@Email,@Mobile,@Phone,@Subject,@Comments,@RatingOfSite,getdate())
		
end
if(@Type='S')
begin
	select * from tblFeedback
end
if(@Type='D')
begin
          Exec('Delete from tblFeedback where FeedbackID in('+@StrIds+')')
end
if(@Type='T')
begin
         select UserName,Email,Mobile,Phone,Subject,Comments,RatingOfSite,convert(varchar(20),SendDate,106) as SendDate
 from tblFeedback where FeedbackID=@FeedbackID
end

end


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE  PROCEDURE sp_tblMailaFriend
(
@ID [bigint]=0 output,
@YourEmailID [VarChar](50)=null,
@FriendsEmailID1 [VarChar](50)=null,
@EmailID2 [VarChar](50)=null,
@EmailID3 [VarChar](50)=null,
@EmailID4 [VarChar](50)=null,
@EmailID5 [VarChar](50)=null,
@StandardContent [VarChar](50)=null,
@Comments [VarChar](50)=null,
@SendDate [DateTime]=null,
@Type char(1)
)
AS
begin
if(@Type='I')
begin
	
			INSERT INTO tblMailaFriend(YourEmailID, FriendsEmailID1, EmailID2, EmailID3,EmailID4,EmailID5,StandardContent,Comments,SendDate)
                        VALUES(@YourEmailID,@FriendsEmailID1,@EmailID2,@EmailID3,@EmailID4,@EmailID4,@StandardContent,@Comments,getdate())
			
		
	end
If(@Type='S')
begin
	SELECT YourEmailID FROM tblMailaFriend WHERE ID=@ID
end


end



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE  PROCEDURE sp_tblUsers
(
@UserID [bigint]=0 output,
@UserName [VarChar](50)=null,
@Password [VarChar](50)=null,
@Status [VarChar](1)=null,
@Email [VarChar](50)=null,
@CreatedDate [DateTime]=null,
@UpdatedDate [DateTime]=null,
@Mobile varchar(50)=null,
@Phone varchar(50)=null,
@Country varchar(50)=null,
@City varchar(50)=null,
@Address varchar(250)=null,
@strIds varchar(500)=null,
@Type char(1),
@check char(1)=null
)
AS
begin

If(@Type='I')
begin
	if not exists(select * from tblUsers where UserName=@UserName)
	begin

              if not exists(select * from tblUsers where Email=@Email)
		begin
		INSERT INTO tblUsers([UserName],[Password],[Email],[Mobile],[Phone],[Country],[City],[Address],[Status],[CreatedDate])
		VALUES(@UserName,@Password,@Email,@Mobile,@Phone,@Country,@City,@Address,'I',getdate())
		select @UserID=scope_identity()
	end
	else
	begin
		select @UserID=0
	end
end

end
if(@Type='U')
begin
	UPDATE tblUsers SET Address =@Address, 
	 City =@City,Country =@Country,  Phone =@Phone,
	 Mobile =@Mobile, Email =@Email,
	UpdatedDate=getdate() where UserID=@UserID
end
If(@Type='F')
begin
	UPDATE tblUsers set Status=@Status WHERE UserID=@UserID
end
If(@Type='D')
begin
	 Exec('Delete from tblUsers where UserID in('+@StrIds+')')
end
If(@Type='A')
begin
	UPDATE tblUsers set Status=@Status,UpdatedDate=getdate() WHERE [UserId] = @UserId
end

If(@Type='R')
begin
	SELECT * FROM tblUsers  where UserID=@UserID
end
If(@Type='L')
begin
	select * from tblUsers where  UserName=@UserName
end

If(@Type='S')
begin
	SELECT UserName,Email,Mobile,Phone,Country,City,Address,convert(varchar(20),CreatedDate,106) as CreatedDate FROM tblUsers WHERE UserID=@UserID
end




If(@Type='B')
begin
	SELECT * FROM tblUsers 
	
end
if(@Type='C')
begin
	update tblUsers set Password=@Password WHERE UserId=@UserId
end
if(@Type='X')
begin
select * from tblUsers where  Email=@Email

end
if(@Type='Z')
begin
if(@check='A')
begin
select * from tblAdmin where BINARY_CHECKSUM(UserName)=BINARY_CHECKSUM(@Username) and 
BINARY_CHECKSUM(Password)=BINARY_CHECKSUM(@Password)

end


if(@check='U')
begin
select * from tblUsers where BINARY_CHECKSUM(UserName)=BINARY_CHECKSUM(@UserName) and 
BINARY_CHECKSUM(Password)=BINARY_CHECKSUM(@Password) 

end


end


end





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

