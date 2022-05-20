using Refit;

namespace SmartPixl.Sdk;

public interface ISmartPixlApiClient
{
    [Get("/GetSmartPiXLApi")]
    Task<SmartPiXLAPIModel[]> GetSmartPixl([AliasAs("CompanyId")] int companyId,
                                                      [AliasAs("PiXLId")] int pixlId,
                                                      [AliasAs("Startdate")] string startDate,
                                                      [AliasAs("Enddate")] string endDate,
                                                      CancellationToken cancellationToken = default);
}

public class SmartPixlQueryParameters
{
    [AliasAs("ApiCompanyID")]
    public int ApiCompanyId { get; set; }
}