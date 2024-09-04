/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Catalogues Management                      Component : Use cases Layer                         *
*  Assembly : Empiria.Financial.Core.dll                 Pattern   : Use case interactor class               *
*  Type     : CataloguesUseCases                         License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Use cases used to retrieve financial core catalogues.                                          *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/

using Empiria.Services;

namespace Empiria.Financial.Core.UseCases {

  /// <summary>Use cases used to retrieve financial core catalogues.</summary>
  public class CataloguesUseCases : UseCase {

    #region Constructors and parsers

    protected CataloguesUseCases() {
      // no-op
    }

    static public CataloguesUseCases UseCaseInteractor() {
      return UseCase.CreateInstance<CataloguesUseCases>();
    }

    #endregion Constructors and parsers

    #region Use cases

    public FixedList<NamedEntityDto> GetCurrencies() {
      var currencies = Currency.GetList();

      return currencies.MapToNamedEntityList();
    }

    #endregion Use cases

  }  // class CataloguesUseCases

}  // namespace Empiria.Financial.Core.UseCases
