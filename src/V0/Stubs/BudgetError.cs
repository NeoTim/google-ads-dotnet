// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/budget_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/budget_error.proto</summary>
  public static partial class BudgetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/budget_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BudgetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvYnVkZ2V0X2Vycm9y",
            "LnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnMi4gQKD0J1",
            "ZGdldEVycm9yRW51bSLOBAoLQnVkZ2V0RXJyb3ISDwoLVU5TUEVDSUZJRUQQ",
            "ABILCgdVTktOT1dOEAESEgoOQlVER0VUX1JFTU9WRUQQAhIRCg1CVURHRVRf",
            "SU5fVVNFEAMSHwobQlVER0VUX1BFUklPRF9OT1RfQVZBSUxBQkxFEAQSMwov",
            "Q0FOTk9UX01PRElGWV9GSUVMRF9PRl9JTVBMSUNJVExZX1NIQVJFRF9CVURH",
            "RVQQBhItCilDQU5OT1RfVVBEQVRFX0JVREdFVF9UT19JTVBMSUNJVExZX1NI",
            "QVJFRBAHEjoKNkNBTk5PVF9VUERBVEVfQlVER0VUX1RPX0VYUExJQ0lUTFlf",
            "U0hBUkVEX1dJVEhPVVRfTkFNRRAIEi0KKUNBTk5PVF9VUERBVEVfQlVER0VU",
            "X1RPX0VYUExJQ0lUTFlfU0hBUkVEEAkSPwo7Q0FOTk9UX1VTRV9JTVBMSUNJ",
            "VExZX1NIQVJFRF9CVURHRVRfV0lUSF9NVUxUSVBMRV9DQU1QQUlHTlMQChIS",
            "Cg5EVVBMSUNBVEVfTkFNRRALEiIKHk1PTkVZX0FNT1VOVF9JTl9XUk9OR19D",
            "VVJSRU5DWRAMEi8KK01PTkVZX0FNT1VOVF9MRVNTX1RIQU5fQ1VSUkVOQ1lf",
            "TUlOSU1VTV9DUEMQDRIaChZNT05FWV9BTU9VTlRfVE9PX0xBUkdFEA4SGQoV",
            "TkVHQVRJVkVfTU9ORVlfQU1PVU5UEA8SKQolTk9OX01VTFRJUExFX09GX01J",
            "TklNVU1fQ1VSUkVOQ1lfVU5JVBAQQsYBCiJjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjAuZXJyb3JzQhBCdWRnZXRFcnJvclByb3RvUAFaRGdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MC9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjAuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcRXJyb3JzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.BudgetErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.BudgetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.BudgetErrorEnum.Types.BudgetError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible budget errors.
  /// </summary>
  public sealed partial class BudgetErrorEnum : pb::IMessage<BudgetErrorEnum> {
    private static readonly pb::MessageParser<BudgetErrorEnum> _parser = new pb::MessageParser<BudgetErrorEnum>(() => new BudgetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BudgetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.BudgetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetErrorEnum(BudgetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetErrorEnum Clone() {
      return new BudgetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BudgetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BudgetErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BudgetErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BudgetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible budget errors.
      /// </summary>
      public enum BudgetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The requested budget no longer exists.
        /// </summary>
        [pbr::OriginalName("BUDGET_REMOVED")] BudgetRemoved = 2,
        /// <summary>
        /// The budget is associated with at least one campaign, and so the budget
        /// cannot be removed.
        /// </summary>
        [pbr::OriginalName("BUDGET_IN_USE")] BudgetInUse = 3,
        /// <summary>
        /// Customer is not whitelisted for this budget period.
        /// </summary>
        [pbr::OriginalName("BUDGET_PERIOD_NOT_AVAILABLE")] BudgetPeriodNotAvailable = 4,
        /// <summary>
        /// This field is not mutable on implicitly shared budgets
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FIELD_OF_IMPLICITLY_SHARED_BUDGET")] CannotModifyFieldOfImplicitlySharedBudget = 6,
        /// <summary>
        /// Cannot change explicitly shared budgets back to implicitly shared ones.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_BUDGET_TO_IMPLICITLY_SHARED")] CannotUpdateBudgetToImplicitlyShared = 7,
        /// <summary>
        /// An implicit budget without a name cannot be changed to explicitly shared
        /// budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_BUDGET_TO_EXPLICITLY_SHARED_WITHOUT_NAME")] CannotUpdateBudgetToExplicitlySharedWithoutName = 8,
        /// <summary>
        /// Cannot change an implicitly shared budget to an explicitly shared one.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_BUDGET_TO_EXPLICITLY_SHARED")] CannotUpdateBudgetToExplicitlyShared = 9,
        /// <summary>
        /// Only explicitly shared budgets can be used with multiple campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_IMPLICITLY_SHARED_BUDGET_WITH_MULTIPLE_CAMPAIGNS")] CannotUseImplicitlySharedBudgetWithMultipleCampaigns = 10,
        /// <summary>
        /// A budget with this name already exists.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 11,
        /// <summary>
        /// A money amount was not in the expected currency.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_IN_WRONG_CURRENCY")] MoneyAmountInWrongCurrency = 12,
        /// <summary>
        /// A money amount was less than the minimum CPC for currency.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC")] MoneyAmountLessThanCurrencyMinimumCpc = 13,
        /// <summary>
        /// A money amount was greater than the maximum allowed.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_TOO_LARGE")] MoneyAmountTooLarge = 14,
        /// <summary>
        /// A money amount was negative.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_MONEY_AMOUNT")] NegativeMoneyAmount = 15,
        /// <summary>
        /// A money amount was not a multiple of a minimum unit.
        /// </summary>
        [pbr::OriginalName("NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT")] NonMultipleOfMinimumCurrencyUnit = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code