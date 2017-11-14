CREATE PROCEDURE [dbo].[USP_Get_Students]
(
    @uid INT = 0
)
    /*******************************************************************************************************************

    *
    * ******************************************************************************************************************
    * Procedure :
    * Function  :
    * Table     :
    * Author    :
    * Date      :
    * Version   :
    * ********************************************************************************************************************
    * EXEC [USP_Get_Students]
    * *******************************************************************************************************************/

    AS
    BEGIN

        SET NOCOUNT ON
        
    DECLARE
        @retval         INT=0,
        @processname    VARCHAR(100),
        @error_message  VARCHAR(500),
        @error_number   INT=0

    SET @processname = OBJECT_NAME(@@PRROCID)

    BEGIN TRY

        Select Id, 
            Name 
        from dbo.UST_Students

        RETURN 0
    END TRY
    
    BEGIN CATCH
            IF @@TRANCOUNT >0
                ROLLBACK TRANSACTION
            Select @error_number = ERROR_NUMBER(),
                    @error_message = @processname + '   ' + CAST (ERROR_LINE() AS VARCHAR(4)) + '  : ' +  ERROR_MESSAGE()
            EXEC @retval = dbo.USP_insert_error__log @error_number, 0, @processname, @error_message,@uid

            RAISE ERROR ('Error caused while getting students details',16,2)
            RETURN -1
    END CATCH

END
