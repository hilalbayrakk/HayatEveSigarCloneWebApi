

public class ResponseGeneratorHelper : ControllerBase
{
    public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
    {
        switch (incomingResponse.ResponseCode)
        {
            case ResponseCodeEnum.Success:
            case ResponseCodeEnum.CreateDistrictOperationSuccess:
            case ResponseCodeEnum.GetAllDistrictsOperationSuccess:
            case ResponseCodeEnum.DeleteDistrictOperationSuccess:
            case ResponseCodeEnum.CreateCityOperationSuccess:
            case ResponseCodeEnum.DeleteCityOperationSuccess:
            case ResponseCodeEnum.GetAllCityOperationSuccess:



                {
                    return Ok(incomingResponse);
                }




            case ResponseCodeEnum.GetAllDistrictsOperationFail:
            case ResponseCodeEnum.GetAllCityOperationFail:
            


                {
                    return NotFound(incomingResponse);
                }




            case ResponseCodeEnum.CreateCityOperationFail:
            case ResponseCodeEnum.CityEditOperationFail:
            case ResponseCodeEnum.DeleteCityOperationFail:
            case ResponseCodeEnum.CreateDistrictOperationFail:
            case ResponseCodeEnum.DeleteDistrictOperationFail:


                {
                    return NoContent();
                }
            default:
                {
                    return BadRequest(incomingResponse);
                }
        }
    }
}
