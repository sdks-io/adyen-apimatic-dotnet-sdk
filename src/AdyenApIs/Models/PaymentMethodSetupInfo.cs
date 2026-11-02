using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record PaymentMethodSetupInfo
{
    /// <summary>
    /// Details to provide if <c>type</c> is <b>accel</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accel")]
    public AccelInfoPaymentMethodSetupInfo? Accel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affirm")]
    public AffirmInfo? Affirm { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>afterpaytouch</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("afterpayTouch")]
    public AfterpayTouchInfoPaymentMethodSetupInfo? AfterpayTouch { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>alipay_plus</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alipayPlus")]
    public AlipayPlusInfoPaymentMethodSetupInfo? AlipayPlus { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>amex</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amex")]
    public AmexInfoPaymentMethodSetupInfo? Amex { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>applepay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applePay")]
    public ApplePayInfoPaymentMethodSetupInfo? ApplePay { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>bcmc</b> (Bancontact).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bcmc")]
    public BcmcInfoPaymentMethodSetupInfo? Bcmc { get; init; }

    /// <summary>
    /// The unique identifier of the business line. Required if you are a <see href="https://docs.adyen.com/platforms">platform model</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineId")]
    public string? BusinessLineId { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>cartebancaire</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cartesBancaires")]
    public CartesBancairesInfoPaymentMethodSetupInfo? CartesBancaires { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>clearpay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clearpay")]
    public ClearpayInfoPaymentMethodSetupInfo? Clearpay { get; init; }

    /// <summary>
    /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cup")]
    public GenericPmWithTdiInfo? Cup { get; init; }

    /// <summary>
    /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencies")]
    public IReadOnlyList<string>? Currencies { get; init; }

    /// <summary>
    /// The list of custom routing flags to route payment to the intended acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customRoutingFlags")]
    public IReadOnlyList<string>? CustomRoutingFlags { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>diners</b>.
    /// For merchants operating in Japan, Diners payments are processed through the JCB network. This means that you must include <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">JCB-specific fields</see>/paymentMethodSettings/(paymentMethodId)#request-jcb) in this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("diners")]
    public DinersInfoPaymentMethodSetupInfo? Diners { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public GenericPmWithTdiInfo? Discover { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_directdebit_CA")]
    public GenericPmWithTdiInfo? EftDirectdebitCa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eftpos_australia")]
    public GenericPmWithTdiInfo? EftposAustralia { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("girocard")]
    public GenericPmWithTdiInfo? Girocard { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>givex</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("givex")]
    public GivexInfoPaymentMethodSetupInfo? Givex { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>googlepay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("googlePay")]
    public GooglePayInfoPaymentMethodSetupInfo? GooglePay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ideal")]
    public GenericPmWithTdiInfo? Ideal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interac_card")]
    public GenericPmWithTdiInfo? InteracCard { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>jcb</b>.
    /// For merchants operating in Japan, <c>midNumber</c>, <c>reuseMidNumber</c>, and <c>serviceLevel</c> fields are required.
    /// For merchants operating outside of Japan, these fields are not required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jcb")]
    public JcbInfoPaymentMethodSetupInfo? Jcb { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>klarna</b> or its variant.
    /// <para>
    /// You can use the following payment method <c>type</c> values for Klarna:
    /// * <b>klarna</b>: Klarna Pay Later
    /// * <b>klarna_account</b>: Klarna Pay over time
    /// * <b>klarna_paynow</b>: Klarna Pay now
    /// * <b>klarna_b2b</b>: <see href="https://docs.adyen.com/payment-methods/klarna/billie">Billie via Klarna</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("klarna")]
    public KlarnaInfoPaymentMethodSetupInfo? Klarna { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro")]
    public GenericPmWithTdiInfo? Maestro { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro_usa")]
    public GenericPmWithTdiInfo? MaestroUsa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc")]
    public GenericPmWithTdiInfo? Mc { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>mealVoucher_FR</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mealVoucher_FR")]
    public MealVoucherFrInfoPaymentMethodSetupInfo? MealVoucherFr { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>nyce</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nyce")]
    public NyceInfoPaymentMethodSetupInfo? Nyce { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>paybybank_plaid</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paybybank_plaid")]
    public PayByBankPlaidInfoPaymentMethodSetupInfo? PaybybankPlaid { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>payme</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payme")]
    public PayMeInfoPaymentMethodSetupInfo? Payme { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>paypal</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paypal")]
    public PayPalInfoPaymentMethodSetupInfo? Paypal { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>payto</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payto")]
    public PayToInfoPaymentMethodSetupInfo? Payto { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>pulse</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pulse")]
    public PulseInfoPaymentMethodSetupInfo? Pulse { get; init; }

    /// <summary>
    /// Your reference for the payment method. Supported characters a-z, A-Z, 0-9.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>sepadirectdebit</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit")]
    public SepaDirectDebitInfoPaymentMethodSetupInfo? Sepadirectdebit { get; init; }

    /// <summary>
    /// The sales channel. Required if the merchant account does not have a sales channel. When you provide this field, it overrides the default sales channel set on the merchant account.
    /// <para>
    /// Possible values: <b>eCommerce</b>, <b>pos</b>, <b>contAuth</b>, and <b>moto</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteractionManagementApi? ShopperInteraction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sodexo")]
    public SodexoInfo? Sodexo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sofort")]
    public SofortInfo? Sofort { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>star</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("star")]
    public StarInfoPaymentMethodSetupInfo? Star { get; init; }

    /// <summary>
    /// The unique identifier of the store for which to configure the payment method, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>svs</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("svs")]
    public SvsInfoPaymentMethodSetupInfo? Svs { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>swish</b>.
    ///  - This field is required only if you have a contract with Swish. Swish handles settlement directly with you (not through Adyen).
    ///  - If not specified then it's assumed that you are using Adyen's contract with Swish.You don't have a direct relationship with Swish.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swish")]
    public SwishInfoPaymentMethodSetupInfo? Swish { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>ticket</b> (Edenred Brazil).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticket")]
    public TicketInfoPaymentMethodSetupInfo? Ticket { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>twint</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twint")]
    public TwintInfoPaymentMethodSetupInfo? Twint { get; init; }

    /// <summary>
    /// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
    /// </summary>
    [JsonPropertyName("type")]
    public required TypePaymentMethodSetupInfo Type { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>valuelink</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valuelink")]
    public ValuelinkInfoPaymentMethodSetupInfo? Valuelink { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>vipps</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vipps")]
    public VippsInfoPaymentMethodSetupInfo? Vipps { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public GenericPmWithTdiInfo? Visa { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>wechatpay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay")]
    public WeChatPayInfoPaymentMethodSetupInfo? Wechatpay { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>wechatpay_pos</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay_pos")]
    public WeChatPayPosInfoPaymentMethodSetupInfo? WechatpayPos { get; init; }
}
