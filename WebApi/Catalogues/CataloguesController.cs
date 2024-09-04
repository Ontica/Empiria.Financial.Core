/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Financial Core                               Component : Web Api                               *
*  Assembly : Empiria.Payments.WebApi.dll                  Pattern   : Query web api controller              *
*  Type     : CataloguesController                         License   : Please read LICENSE.txt file          *
*                                                                                                            *
*  Summary  : Query web API used to retrive financial core catalogues.                                       *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System.Web.Http;

using Empiria.WebApi;

using Empiria.Financial.Core.UseCases;

namespace Empiria.Financial.Core.WebApi {

  /// <summary>Query web API used to retrive financial core catalogues.</summary>
  public class CataloguesController : WebApiController {

    #region Query web apis

    [HttpGet]
    [Route("v2/financial/catalogues/currencies")]
    public CollectionModel GetCurrencies() {

      using (var usecases = CataloguesUseCases.UseCaseInteractor()) {
        FixedList<NamedEntityDto> currencies = usecases.GetCurrencies();

        return new CollectionModel(Request, currencies);
      }
    }

    #endregion Query web apis

  }  // class CataloguesController

}  // namespace Empiria.Financial.Core.WebApi
