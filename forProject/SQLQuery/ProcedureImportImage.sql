USE [gameMarket]
GO
/****** Object:  StoredProcedure [dbo].[usp_ImportImage]    Script Date: 25.09.2021 20:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_ImportImage] 
(
   @gameOwnerId int,
   @PicName NVARCHAR (100),
   @ImageFolderPath NVARCHAR (1000),
   @Filename NVARCHAR (1000)
)
AS
BEGIN
   DECLARE @Path2OutFile NVARCHAR (2000);
   DECLARE @tsql NVARCHAR (2000);
   SET NOCOUNT ON
   SET @Path2OutFile = CONCAT (
         @ImageFolderPath
         ,'\'
         , @Filename
         );
   SET @tsql = 'insert into Pictures  (pictureName, picFileName, PictureData)' +
               ' SELECT ' + '''' + @PicName + '''' + ',' + '''' + @Filename + '''' + ', * ' + 
               'FROM Openrowset( Bulk ' + '''' + @Path2OutFile + '''' + ', Single_Blob) as img'
   EXEC (@tsql)
   update [Pictures] set [gameId] = @gameOwnerId where [picFileName] = @Filename
   SET NOCOUNT OFF
END

