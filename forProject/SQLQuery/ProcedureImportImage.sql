CREATE PROCEDURE dbo.usp_ImportImage 
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
   update [Pictures] set [gameId] = @gameOwnerId where [pictureName] = @PicName 
   SET NOCOUNT OFF
END
GO
