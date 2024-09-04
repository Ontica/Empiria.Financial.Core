/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Financial Core                             Component : Test cases                              *
*  Assembly : Empiria.Financial.Core.Tests.dll           Pattern   : Use cases tests                         *
*  Type     : CataloguesUseCasesTests                    License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Test cases for financial core catalogues use cases.                                            *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using Xunit;

using Empiria.Financial.Core.UseCases;

namespace Empiria.Tests.Financial.Core {

  /// <summary>Test cases for financial core catalogues use cases.</summary>
  public class CataloguesUseCasesTests {

    #region Use cases initialization

    private readonly CataloguesUseCases _usecases;

    public CataloguesUseCasesTests() {
      TestsCommonMethods.Authenticate();

      _usecases = CataloguesUseCases.UseCaseInteractor();
    }

    ~CataloguesUseCasesTests() {
      _usecases.Dispose();
    }

    #endregion Use cases initialization

    #region Facts

    [Fact]
    public void Should_GetCurrencies() {
      var sut = _usecases.GetCurrencies();

      Assert.NotNull(sut);
    }

    #endregion Facts

  }  // class CataloguesUseCasesTests

}  // namespace Empiria.Tests.Financial.Core
