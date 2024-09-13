/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Contracts Management                       Component : Domain Layer                            *
*  Assembly : Empiria.Payments.Core.dll                  Pattern   : Information Holder                      *
*  Type     : Contract                                   License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Represents a contract or a service order.                                                      *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/

namespace Empiria.Financial.Core {

  public class Currency: GeneralObject {

    #region Constructors and parsers

    static public Currency Parse(string uid) {
      return BaseObject.ParseKey<Currency>(uid);
    }


    static public Currency Parse(int id) => BaseObject.ParseId<Currency>(id);


    static public Currency Empty => BaseObject.ParseEmpty<Currency>();


    #endregion Constructors and parsers

    #region Properties

    public string Code {
      get {
        return base.ExtendedDataField.Get("code", "ND");
      }
    }

    #endregion Properties


    #region Methods

    static public FixedList<Currency> GetList() {
      return BaseObject.GetList<Currency>()
                       .ToFixedList();
    }

    #endregion Methods

  }  // class Currency

} // namespace Empiria.Financial.Core