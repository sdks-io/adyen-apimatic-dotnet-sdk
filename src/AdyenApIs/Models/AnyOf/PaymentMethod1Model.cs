using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Extensions;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models.AnyOf;

/// <summary>
/// The type and required details of a payment method to use.
/// </summary>
[JsonConverter(typeof(PaymentMethod1ModelConverter))]
public record PaymentMethod1Model
{
    private readonly Optional<AchDirectDebit> _achDirectDebitValue;

    private readonly Optional<Affirm> _affirmValue;

    private readonly Optional<Afterpay> _afterpayValue;

    private readonly Optional<AmazonPay> _amazonPayValue;

    private readonly Optional<Ancv> _ancvValue;

    private readonly Optional<AndroidPay> _androidPayValue;

    private readonly Optional<ApplePay> _applePayValue;

    private readonly Optional<BacsDirectDebit> _bacsDirectDebitValue;

    private readonly Optional<BillDesk> _billDeskValue;

    private readonly Optional<Blik> _blikValue;

    private readonly Optional<Card> _cardValue;

    private readonly Optional<StoredPaymentMethod> _storedPaymentMethodValue;

    private readonly Optional<Cellulant> _cellulantValue;

    private readonly Optional<Doku> _dokuValue;

    private readonly Optional<Dragonpay> _dragonpayValue;

    private readonly Optional<EBankingFinland> _eBankingFinlandValue;

    private readonly Optional<Voucher> _voucherValue;

    private readonly Optional<EftDirectDebit> _eftDirectDebitValue;

    private readonly Optional<DetailsOfTokensThatAreNotStoredWithAdyen> _detailsOfTokensThatAreNotStoredWithAdyenValue;

    private readonly Optional<Fastlane> _fastlaneValue;

    private readonly Optional<object> _anonymousObjectValue;

    private readonly Optional<Klarna> _klarnaValue;

    private readonly Optional<Masterpass> _masterpassValue;

    private readonly Optional<MbWay> _mbWayValue;

    private readonly Optional<MobilePay> _mobilePayValue;

    private readonly Optional<MolPay> _molPayValue;

    private readonly Optional<OpenInvoice> _openInvoiceValue;

    private readonly Optional<PayByBankAisDirectDebit> _payByBankAisDirectDebitValue;

    private readonly Optional<PayByBank> _payByBankValue;

    private readonly Optional<PayPal> _payPalValue;

    private readonly Optional<PayPay> _payPayValue;

    private readonly Optional<PayTo> _payToValue;

    private readonly Optional<PayU> _payUValue;

    private readonly Optional<PaymentDetails> _paymentDetailsValue;

    private readonly Optional<PseLatam> _pseLatamValue;

    private readonly Optional<RakutenPay> _rakutenPayValue;

    private readonly Optional<Ratepay> _ratepayValue;

    private readonly Optional<Riverty> _rivertyValue;

    private readonly Optional<SamsungPay> _samsungPayValue;

    private readonly Optional<SepaDirectDebit> _sepaDirectDebitValue;

    private readonly Optional<Twint> _twintValue;

    private readonly Optional<UpiCollect> _upiCollectValue;

    private readonly Optional<UpiIntent> _upiIntentValue;

    private readonly Optional<UpiQr> _upiQrValue;

    private readonly Optional<Vipps> _vippsValue;

    private readonly Optional<VisaCheckout> _visaCheckoutValue;

    private readonly Optional<WeChatPay> _weChatPayValue;

    private readonly Optional<WeChatPayMiniProgram> _weChatPayMiniProgramValue;

    private readonly Optional<Zip> _zipValue;

    private PaymentMethod1Model(Optional<AchDirectDebit> achDirectDebitValue,
        Optional<Affirm> affirmValue,
        Optional<Afterpay> afterpayValue,
        Optional<AmazonPay> amazonPayValue,
        Optional<Ancv> ancvValue,
        Optional<AndroidPay> androidPayValue,
        Optional<ApplePay> applePayValue,
        Optional<BacsDirectDebit> bacsDirectDebitValue,
        Optional<BillDesk> billDeskValue,
        Optional<Blik> blikValue,
        Optional<Card> cardValue,
        Optional<StoredPaymentMethod> storedPaymentMethodValue,
        Optional<Cellulant> cellulantValue,
        Optional<Doku> dokuValue,
        Optional<Dragonpay> dragonpayValue,
        Optional<EBankingFinland> eBankingFinlandValue,
        Optional<Voucher> voucherValue,
        Optional<EftDirectDebit> eftDirectDebitValue,
        Optional<DetailsOfTokensThatAreNotStoredWithAdyen> detailsOfTokensThatAreNotStoredWithAdyenValue,
        Optional<Fastlane> fastlaneValue,
        Optional<object> anonymousObjectValue,
        Optional<Klarna> klarnaValue,
        Optional<Masterpass> masterpassValue,
        Optional<MbWay> mbWayValue,
        Optional<MobilePay> mobilePayValue,
        Optional<MolPay> molPayValue,
        Optional<OpenInvoice> openInvoiceValue,
        Optional<PayByBankAisDirectDebit> payByBankAisDirectDebitValue,
        Optional<PayByBank> payByBankValue,
        Optional<PayPal> payPalValue,
        Optional<PayPay> payPayValue,
        Optional<PayTo> payToValue,
        Optional<PayU> payUValue,
        Optional<PaymentDetails> paymentDetailsValue,
        Optional<PseLatam> pseLatamValue,
        Optional<RakutenPay> rakutenPayValue,
        Optional<Ratepay> ratepayValue,
        Optional<Riverty> rivertyValue,
        Optional<SamsungPay> samsungPayValue,
        Optional<SepaDirectDebit> sepaDirectDebitValue,
        Optional<Twint> twintValue,
        Optional<UpiCollect> upiCollectValue,
        Optional<UpiIntent> upiIntentValue,
        Optional<UpiQr> upiQrValue,
        Optional<Vipps> vippsValue,
        Optional<VisaCheckout> visaCheckoutValue,
        Optional<WeChatPay> weChatPayValue,
        Optional<WeChatPayMiniProgram> weChatPayMiniProgramValue,
        Optional<Zip> zipValue)
    {
        _achDirectDebitValue = achDirectDebitValue;
        _affirmValue = affirmValue;
        _afterpayValue = afterpayValue;
        _amazonPayValue = amazonPayValue;
        _ancvValue = ancvValue;
        _androidPayValue = androidPayValue;
        _applePayValue = applePayValue;
        _bacsDirectDebitValue = bacsDirectDebitValue;
        _billDeskValue = billDeskValue;
        _blikValue = blikValue;
        _cardValue = cardValue;
        _storedPaymentMethodValue = storedPaymentMethodValue;
        _cellulantValue = cellulantValue;
        _dokuValue = dokuValue;
        _dragonpayValue = dragonpayValue;
        _eBankingFinlandValue = eBankingFinlandValue;
        _voucherValue = voucherValue;
        _eftDirectDebitValue = eftDirectDebitValue;
        _detailsOfTokensThatAreNotStoredWithAdyenValue = detailsOfTokensThatAreNotStoredWithAdyenValue;
        _fastlaneValue = fastlaneValue;
        _anonymousObjectValue = anonymousObjectValue;
        _klarnaValue = klarnaValue;
        _masterpassValue = masterpassValue;
        _mbWayValue = mbWayValue;
        _mobilePayValue = mobilePayValue;
        _molPayValue = molPayValue;
        _openInvoiceValue = openInvoiceValue;
        _payByBankAisDirectDebitValue = payByBankAisDirectDebitValue;
        _payByBankValue = payByBankValue;
        _payPalValue = payPalValue;
        _payPayValue = payPayValue;
        _payToValue = payToValue;
        _payUValue = payUValue;
        _paymentDetailsValue = paymentDetailsValue;
        _pseLatamValue = pseLatamValue;
        _rakutenPayValue = rakutenPayValue;
        _ratepayValue = ratepayValue;
        _rivertyValue = rivertyValue;
        _samsungPayValue = samsungPayValue;
        _sepaDirectDebitValue = sepaDirectDebitValue;
        _twintValue = twintValue;
        _upiCollectValue = upiCollectValue;
        _upiIntentValue = upiIntentValue;
        _upiQrValue = upiQrValue;
        _vippsValue = vippsValue;
        _visaCheckoutValue = visaCheckoutValue;
        _weChatPayValue = weChatPayValue;
        _weChatPayMiniProgramValue = weChatPayMiniProgramValue;
        _zipValue = zipValue;
    }

    public static PaymentMethod1Model AchDirectDebit(AchDirectDebit value) =>
        new(
            Optional<AchDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Affirm(Affirm value) =>
        new(
            default,
            Optional<Affirm>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Afterpay(Afterpay value) =>
        new(
            default,
            default,
            Optional<Afterpay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model AmazonPay(AmazonPay value) =>
        new(
            default,
            default,
            default,
            Optional<AmazonPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Ancv(Ancv value) =>
        new(
            default,
            default,
            default,
            default,
            Optional<Ancv>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model AndroidPay(AndroidPay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            Optional<AndroidPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model ApplePay(ApplePay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<ApplePay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model BacsDirectDebit(BacsDirectDebit value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<BacsDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model BillDesk(BillDesk value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<BillDesk>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Blik(Blik value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Blik>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Card(Card value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Card>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model StoredPaymentMethod(StoredPaymentMethod value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<StoredPaymentMethod>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Cellulant(Cellulant value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Cellulant>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Doku(Doku value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Doku>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Dragonpay(Dragonpay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Dragonpay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model EBankingFinland(EBankingFinland value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<EBankingFinland>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Voucher(Voucher value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Voucher>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model EftDirectDebit(EftDirectDebit value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<EftDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model DetailsOfTokensThatAreNotStoredWithAdyen(DetailsOfTokensThatAreNotStoredWithAdyen value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<DetailsOfTokensThatAreNotStoredWithAdyen>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Fastlane(Fastlane value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Fastlane>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model AnonymousObject(object value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<object>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Klarna(Klarna value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Klarna>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Masterpass(Masterpass value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Masterpass>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model MbWay(MbWay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<MbWay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model MobilePay(MobilePay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<MobilePay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model MolPay(MolPay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<MolPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model OpenInvoice(OpenInvoice value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<OpenInvoice>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PayByBankAisDirectDebit(PayByBankAisDirectDebit value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayByBankAisDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PayByBank(PayByBank value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayByBank>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PayPal(PayPal value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayPal>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PayPay(PayPay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PayTo(PayTo value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayTo>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PayU(PayU value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayU>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PaymentDetails(PaymentDetails value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PaymentDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model PseLatam(PseLatam value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PseLatam>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model RakutenPay(RakutenPay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<RakutenPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Ratepay(Ratepay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Ratepay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Riverty(Riverty value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Riverty>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model SamsungPay(SamsungPay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SamsungPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model SepaDirectDebit(SepaDirectDebit value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SepaDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Twint(Twint value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Twint>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model UpiCollect(UpiCollect value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UpiCollect>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model UpiIntent(UpiIntent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UpiIntent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model UpiQr(UpiQr value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UpiQr>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model Vipps(Vipps value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Vipps>.Some(value),
            default,
            default,
            default,
            default);

    public static PaymentMethod1Model VisaCheckout(VisaCheckout value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<VisaCheckout>.Some(value),
            default,
            default,
            default);

    public static PaymentMethod1Model WeChatPay(WeChatPay value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<WeChatPay>.Some(value),
            default,
            default);

    public static PaymentMethod1Model WeChatPayMiniProgram(WeChatPayMiniProgram value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<WeChatPayMiniProgram>.Some(value),
            default);

    public static PaymentMethod1Model Zip(Zip value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Zip>.Some(value));

    public bool TryGetAchDirectDebit(out AchDirectDebit value) => _achDirectDebitValue.TryGetValue(out value);

    public bool TryGetAffirm(out Affirm value) => _affirmValue.TryGetValue(out value);

    public bool TryGetAfterpay(out Afterpay value) => _afterpayValue.TryGetValue(out value);

    public bool TryGetAmazonPay(out AmazonPay value) => _amazonPayValue.TryGetValue(out value);

    public bool TryGetAncv(out Ancv value) => _ancvValue.TryGetValue(out value);

    public bool TryGetAndroidPay(out AndroidPay value) => _androidPayValue.TryGetValue(out value);

    public bool TryGetApplePay(out ApplePay value) => _applePayValue.TryGetValue(out value);

    public bool TryGetBacsDirectDebit(out BacsDirectDebit value) => _bacsDirectDebitValue.TryGetValue(out value);

    public bool TryGetBillDesk(out BillDesk value) => _billDeskValue.TryGetValue(out value);

    public bool TryGetBlik(out Blik value) => _blikValue.TryGetValue(out value);

    public bool TryGetCard(out Card value) => _cardValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod(out StoredPaymentMethod value) =>
        _storedPaymentMethodValue.TryGetValue(out value);

    public bool TryGetCellulant(out Cellulant value) => _cellulantValue.TryGetValue(out value);

    public bool TryGetDoku(out Doku value) => _dokuValue.TryGetValue(out value);

    public bool TryGetDragonpay(out Dragonpay value) => _dragonpayValue.TryGetValue(out value);

    public bool TryGetEBankingFinland(out EBankingFinland value) => _eBankingFinlandValue.TryGetValue(out value);

    public bool TryGetVoucher(out Voucher value) => _voucherValue.TryGetValue(out value);

    public bool TryGetEftDirectDebit(out EftDirectDebit value) => _eftDirectDebitValue.TryGetValue(out value);

    public bool TryGetDetailsOfTokensThatAreNotStoredWithAdyen(out DetailsOfTokensThatAreNotStoredWithAdyen value) =>
        _detailsOfTokensThatAreNotStoredWithAdyenValue.TryGetValue(out value);

    public bool TryGetFastlane(out Fastlane value) => _fastlaneValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    public bool TryGetKlarna(out Klarna value) => _klarnaValue.TryGetValue(out value);

    public bool TryGetMasterpass(out Masterpass value) => _masterpassValue.TryGetValue(out value);

    public bool TryGetMbWay(out MbWay value) => _mbWayValue.TryGetValue(out value);

    public bool TryGetMobilePay(out MobilePay value) => _mobilePayValue.TryGetValue(out value);

    public bool TryGetMolPay(out MolPay value) => _molPayValue.TryGetValue(out value);

    public bool TryGetOpenInvoice(out OpenInvoice value) => _openInvoiceValue.TryGetValue(out value);

    public bool TryGetPayByBankAisDirectDebit(out PayByBankAisDirectDebit value) =>
        _payByBankAisDirectDebitValue.TryGetValue(out value);

    public bool TryGetPayByBank(out PayByBank value) => _payByBankValue.TryGetValue(out value);

    public bool TryGetPayPal(out PayPal value) => _payPalValue.TryGetValue(out value);

    public bool TryGetPayPay(out PayPay value) => _payPayValue.TryGetValue(out value);

    public bool TryGetPayTo(out PayTo value) => _payToValue.TryGetValue(out value);

    public bool TryGetPayU(out PayU value) => _payUValue.TryGetValue(out value);

    public bool TryGetPaymentDetails(out PaymentDetails value) => _paymentDetailsValue.TryGetValue(out value);

    public bool TryGetPseLatam(out PseLatam value) => _pseLatamValue.TryGetValue(out value);

    public bool TryGetRakutenPay(out RakutenPay value) => _rakutenPayValue.TryGetValue(out value);

    public bool TryGetRatepay(out Ratepay value) => _ratepayValue.TryGetValue(out value);

    public bool TryGetRiverty(out Riverty value) => _rivertyValue.TryGetValue(out value);

    public bool TryGetSamsungPay(out SamsungPay value) => _samsungPayValue.TryGetValue(out value);

    public bool TryGetSepaDirectDebit(out SepaDirectDebit value) => _sepaDirectDebitValue.TryGetValue(out value);

    public bool TryGetTwint(out Twint value) => _twintValue.TryGetValue(out value);

    public bool TryGetUpiCollect(out UpiCollect value) => _upiCollectValue.TryGetValue(out value);

    public bool TryGetUpiIntent(out UpiIntent value) => _upiIntentValue.TryGetValue(out value);

    public bool TryGetUpiQr(out UpiQr value) => _upiQrValue.TryGetValue(out value);

    public bool TryGetVipps(out Vipps value) => _vippsValue.TryGetValue(out value);

    public bool TryGetVisaCheckout(out VisaCheckout value) => _visaCheckoutValue.TryGetValue(out value);

    public bool TryGetWeChatPay(out WeChatPay value) => _weChatPayValue.TryGetValue(out value);

    public bool TryGetWeChatPayMiniProgram(out WeChatPayMiniProgram value) =>
        _weChatPayMiniProgramValue.TryGetValue(out value);

    public bool TryGetZip(out Zip value) => _zipValue.TryGetValue(out value);

    public static implicit operator PaymentMethod1Model(AchDirectDebit value) => AchDirectDebit(value);

    public static implicit operator PaymentMethod1Model(Affirm value) => Affirm(value);

    public static implicit operator PaymentMethod1Model(Afterpay value) => Afterpay(value);

    public static implicit operator PaymentMethod1Model(AmazonPay value) => AmazonPay(value);

    public static implicit operator PaymentMethod1Model(Ancv value) => Ancv(value);

    public static implicit operator PaymentMethod1Model(AndroidPay value) => AndroidPay(value);

    public static implicit operator PaymentMethod1Model(ApplePay value) => ApplePay(value);

    public static implicit operator PaymentMethod1Model(BacsDirectDebit value) => BacsDirectDebit(value);

    public static implicit operator PaymentMethod1Model(BillDesk value) => BillDesk(value);

    public static implicit operator PaymentMethod1Model(Blik value) => Blik(value);

    public static implicit operator PaymentMethod1Model(Card value) => Card(value);

    public static implicit operator PaymentMethod1Model(StoredPaymentMethod value) => StoredPaymentMethod(value);

    public static implicit operator PaymentMethod1Model(Cellulant value) => Cellulant(value);

    public static implicit operator PaymentMethod1Model(Doku value) => Doku(value);

    public static implicit operator PaymentMethod1Model(Dragonpay value) => Dragonpay(value);

    public static implicit operator PaymentMethod1Model(EBankingFinland value) => EBankingFinland(value);

    public static implicit operator PaymentMethod1Model(Voucher value) => Voucher(value);

    public static implicit operator PaymentMethod1Model(EftDirectDebit value) => EftDirectDebit(value);

    public static implicit operator PaymentMethod1Model(DetailsOfTokensThatAreNotStoredWithAdyen value) =>
        DetailsOfTokensThatAreNotStoredWithAdyen(value);

    public static implicit operator PaymentMethod1Model(Fastlane value) => Fastlane(value);

    public static implicit operator PaymentMethod1Model(Klarna value) => Klarna(value);

    public static implicit operator PaymentMethod1Model(Masterpass value) => Masterpass(value);

    public static implicit operator PaymentMethod1Model(MbWay value) => MbWay(value);

    public static implicit operator PaymentMethod1Model(MobilePay value) => MobilePay(value);

    public static implicit operator PaymentMethod1Model(MolPay value) => MolPay(value);

    public static implicit operator PaymentMethod1Model(OpenInvoice value) => OpenInvoice(value);

    public static implicit operator PaymentMethod1Model(PayByBankAisDirectDebit value) =>
        PayByBankAisDirectDebit(value);

    public static implicit operator PaymentMethod1Model(PayByBank value) => PayByBank(value);

    public static implicit operator PaymentMethod1Model(PayPal value) => PayPal(value);

    public static implicit operator PaymentMethod1Model(PayPay value) => PayPay(value);

    public static implicit operator PaymentMethod1Model(PayTo value) => PayTo(value);

    public static implicit operator PaymentMethod1Model(PayU value) => PayU(value);

    public static implicit operator PaymentMethod1Model(PaymentDetails value) => PaymentDetails(value);

    public static implicit operator PaymentMethod1Model(PseLatam value) => PseLatam(value);

    public static implicit operator PaymentMethod1Model(RakutenPay value) => RakutenPay(value);

    public static implicit operator PaymentMethod1Model(Ratepay value) => Ratepay(value);

    public static implicit operator PaymentMethod1Model(Riverty value) => Riverty(value);

    public static implicit operator PaymentMethod1Model(SamsungPay value) => SamsungPay(value);

    public static implicit operator PaymentMethod1Model(SepaDirectDebit value) => SepaDirectDebit(value);

    public static implicit operator PaymentMethod1Model(Twint value) => Twint(value);

    public static implicit operator PaymentMethod1Model(UpiCollect value) => UpiCollect(value);

    public static implicit operator PaymentMethod1Model(UpiIntent value) => UpiIntent(value);

    public static implicit operator PaymentMethod1Model(UpiQr value) => UpiQr(value);

    public static implicit operator PaymentMethod1Model(Vipps value) => Vipps(value);

    public static implicit operator PaymentMethod1Model(VisaCheckout value) => VisaCheckout(value);

    public static implicit operator PaymentMethod1Model(WeChatPay value) => WeChatPay(value);

    public static implicit operator PaymentMethod1Model(WeChatPayMiniProgram value) => WeChatPayMiniProgram(value);

    public static implicit operator PaymentMethod1Model(Zip value) => Zip(value);
}

file sealed class PaymentMethod1ModelConverter : JsonConverter<PaymentMethod1Model>
{
    public override PaymentMethod1Model Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AchDirectDebit>(root, options, out var achDirectDebitValue))
        {
            return PaymentMethod1Model.AchDirectDebit(achDirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<Affirm>(root, options, out var affirmValue))
        {
            return PaymentMethod1Model.Affirm(affirmValue);
        }
        if (JsonSerializer.TryDeserialize<Afterpay>(root, options, out var afterpayValue))
        {
            return PaymentMethod1Model.Afterpay(afterpayValue);
        }
        if (JsonSerializer.TryDeserialize<AmazonPay>(root, options, out var amazonPayValue))
        {
            return PaymentMethod1Model.AmazonPay(amazonPayValue);
        }
        if (JsonSerializer.TryDeserialize<Ancv>(root, options, out var ancvValue))
        {
            return PaymentMethod1Model.Ancv(ancvValue);
        }
        if (JsonSerializer.TryDeserialize<AndroidPay>(root, options, out var androidPayValue))
        {
            return PaymentMethod1Model.AndroidPay(androidPayValue);
        }
        if (JsonSerializer.TryDeserialize<ApplePay>(root, options, out var applePayValue))
        {
            return PaymentMethod1Model.ApplePay(applePayValue);
        }
        if (JsonSerializer.TryDeserialize<BacsDirectDebit>(root, options, out var bacsDirectDebitValue))
        {
            return PaymentMethod1Model.BacsDirectDebit(bacsDirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<BillDesk>(root, options, out var billDeskValue))
        {
            return PaymentMethod1Model.BillDesk(billDeskValue);
        }
        if (JsonSerializer.TryDeserialize<Blik>(root, options, out var blikValue))
        {
            return PaymentMethod1Model.Blik(blikValue);
        }
        if (JsonSerializer.TryDeserialize<Card>(root, options, out var cardValue))
        {
            return PaymentMethod1Model.Card(cardValue);
        }
        if (JsonSerializer.TryDeserialize<StoredPaymentMethod>(root, options, out var storedPaymentMethodValue))
        {
            return PaymentMethod1Model.StoredPaymentMethod(storedPaymentMethodValue);
        }
        if (JsonSerializer.TryDeserialize<Cellulant>(root, options, out var cellulantValue))
        {
            return PaymentMethod1Model.Cellulant(cellulantValue);
        }
        if (JsonSerializer.TryDeserialize<Doku>(root, options, out var dokuValue))
        {
            return PaymentMethod1Model.Doku(dokuValue);
        }
        if (JsonSerializer.TryDeserialize<Dragonpay>(root, options, out var dragonpayValue))
        {
            return PaymentMethod1Model.Dragonpay(dragonpayValue);
        }
        if (JsonSerializer.TryDeserialize<EBankingFinland>(root, options, out var eBankingFinlandValue))
        {
            return PaymentMethod1Model.EBankingFinland(eBankingFinlandValue);
        }
        if (JsonSerializer.TryDeserialize<Voucher>(root, options, out var voucherValue))
        {
            return PaymentMethod1Model.Voucher(voucherValue);
        }
        if (JsonSerializer.TryDeserialize<EftDirectDebit>(root, options, out var eftDirectDebitValue))
        {
            return PaymentMethod1Model.EftDirectDebit(eftDirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<DetailsOfTokensThatAreNotStoredWithAdyen>(
            root,
            options,
            out var detailsOfTokensThatAreNotStoredWithAdyenValue))
        {
            return PaymentMethod1Model.DetailsOfTokensThatAreNotStoredWithAdyen(
                detailsOfTokensThatAreNotStoredWithAdyenValue);
        }
        if (JsonSerializer.TryDeserialize<Fastlane>(root, options, out var fastlaneValue))
        {
            return PaymentMethod1Model.Fastlane(fastlaneValue);
        }
        if (JsonSerializer.TryDeserialize<object>(root, options, out var anonymousObjectValue))
        {
            return PaymentMethod1Model.AnonymousObject(anonymousObjectValue);
        }
        if (JsonSerializer.TryDeserialize<Klarna>(root, options, out var klarnaValue))
        {
            return PaymentMethod1Model.Klarna(klarnaValue);
        }
        if (JsonSerializer.TryDeserialize<Masterpass>(root, options, out var masterpassValue))
        {
            return PaymentMethod1Model.Masterpass(masterpassValue);
        }
        if (JsonSerializer.TryDeserialize<MbWay>(root, options, out var mbWayValue))
        {
            return PaymentMethod1Model.MbWay(mbWayValue);
        }
        if (JsonSerializer.TryDeserialize<MobilePay>(root, options, out var mobilePayValue))
        {
            return PaymentMethod1Model.MobilePay(mobilePayValue);
        }
        if (JsonSerializer.TryDeserialize<MolPay>(root, options, out var molPayValue))
        {
            return PaymentMethod1Model.MolPay(molPayValue);
        }
        if (JsonSerializer.TryDeserialize<OpenInvoice>(root, options, out var openInvoiceValue))
        {
            return PaymentMethod1Model.OpenInvoice(openInvoiceValue);
        }
        if (JsonSerializer.TryDeserialize<PayByBankAisDirectDebit>(root, options, out var payByBankAisDirectDebitValue))
        {
            return PaymentMethod1Model.PayByBankAisDirectDebit(payByBankAisDirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<PayByBank>(root, options, out var payByBankValue))
        {
            return PaymentMethod1Model.PayByBank(payByBankValue);
        }
        if (JsonSerializer.TryDeserialize<PayPal>(root, options, out var payPalValue))
        {
            return PaymentMethod1Model.PayPal(payPalValue);
        }
        if (JsonSerializer.TryDeserialize<PayPay>(root, options, out var payPayValue))
        {
            return PaymentMethod1Model.PayPay(payPayValue);
        }
        if (JsonSerializer.TryDeserialize<PayTo>(root, options, out var payToValue))
        {
            return PaymentMethod1Model.PayTo(payToValue);
        }
        if (JsonSerializer.TryDeserialize<PayU>(root, options, out var payUValue))
        {
            return PaymentMethod1Model.PayU(payUValue);
        }
        if (JsonSerializer.TryDeserialize<PaymentDetails>(root, options, out var paymentDetailsValue))
        {
            return PaymentMethod1Model.PaymentDetails(paymentDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<PseLatam>(root, options, out var pseLatamValue))
        {
            return PaymentMethod1Model.PseLatam(pseLatamValue);
        }
        if (JsonSerializer.TryDeserialize<RakutenPay>(root, options, out var rakutenPayValue))
        {
            return PaymentMethod1Model.RakutenPay(rakutenPayValue);
        }
        if (JsonSerializer.TryDeserialize<Ratepay>(root, options, out var ratepayValue))
        {
            return PaymentMethod1Model.Ratepay(ratepayValue);
        }
        if (JsonSerializer.TryDeserialize<Riverty>(root, options, out var rivertyValue))
        {
            return PaymentMethod1Model.Riverty(rivertyValue);
        }
        if (JsonSerializer.TryDeserialize<SamsungPay>(root, options, out var samsungPayValue))
        {
            return PaymentMethod1Model.SamsungPay(samsungPayValue);
        }
        if (JsonSerializer.TryDeserialize<SepaDirectDebit>(root, options, out var sepaDirectDebitValue))
        {
            return PaymentMethod1Model.SepaDirectDebit(sepaDirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<Twint>(root, options, out var twintValue))
        {
            return PaymentMethod1Model.Twint(twintValue);
        }
        if (JsonSerializer.TryDeserialize<UpiCollect>(root, options, out var upiCollectValue))
        {
            return PaymentMethod1Model.UpiCollect(upiCollectValue);
        }
        if (JsonSerializer.TryDeserialize<UpiIntent>(root, options, out var upiIntentValue))
        {
            return PaymentMethod1Model.UpiIntent(upiIntentValue);
        }
        if (JsonSerializer.TryDeserialize<UpiQr>(root, options, out var upiQrValue))
        {
            return PaymentMethod1Model.UpiQr(upiQrValue);
        }
        if (JsonSerializer.TryDeserialize<Vipps>(root, options, out var vippsValue))
        {
            return PaymentMethod1Model.Vipps(vippsValue);
        }
        if (JsonSerializer.TryDeserialize<VisaCheckout>(root, options, out var visaCheckoutValue))
        {
            return PaymentMethod1Model.VisaCheckout(visaCheckoutValue);
        }
        if (JsonSerializer.TryDeserialize<WeChatPay>(root, options, out var weChatPayValue))
        {
            return PaymentMethod1Model.WeChatPay(weChatPayValue);
        }
        if (JsonSerializer.TryDeserialize<WeChatPayMiniProgram>(root, options, out var weChatPayMiniProgramValue))
        {
            return PaymentMethod1Model.WeChatPayMiniProgram(weChatPayMiniProgramValue);
        }
        if (JsonSerializer.TryDeserialize<Zip>(root, options, out var zipValue))
        {
            return PaymentMethod1Model.Zip(zipValue);
        }
        throw new JsonException(
            $"JSON does not match AchDirectDebit or Affirm or Afterpay or AmazonPay or Ancv or AndroidPay or ApplePay or BacsDirectDebit or BillDesk or Blik or Card or StoredPaymentMethod or Cellulant or Doku or Dragonpay or EBankingFinland or Voucher or EftDirectDebit or DetailsOfTokensThatAreNotStoredWithAdyen or Fastlane or object or Klarna or Masterpass or MbWay or MobilePay or MolPay or OpenInvoice or PayByBankAisDirectDebit or PayByBank or PayPal or PayPay or PayTo or PayU or PaymentDetails or PseLatam or RakutenPay or Ratepay or Riverty or SamsungPay or SepaDirectDebit or Twint or UpiCollect or UpiIntent or UpiQr or Vipps or VisaCheckout or WeChatPay or WeChatPayMiniProgram or Zip schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PaymentMethod1Model value, JsonSerializerOptions options)
    {
        if (value.TryGetAchDirectDebit(out var achDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, achDirectDebitValue, options);
        }
        else if (value.TryGetAffirm(out var affirmValue))
        {
            JsonSerializer.Serialize(writer, affirmValue, options);
        }
        else if (value.TryGetAfterpay(out var afterpayValue))
        {
            JsonSerializer.Serialize(writer, afterpayValue, options);
        }
        else if (value.TryGetAmazonPay(out var amazonPayValue))
        {
            JsonSerializer.Serialize(writer, amazonPayValue, options);
        }
        else if (value.TryGetAncv(out var ancvValue))
        {
            JsonSerializer.Serialize(writer, ancvValue, options);
        }
        else if (value.TryGetAndroidPay(out var androidPayValue))
        {
            JsonSerializer.Serialize(writer, androidPayValue, options);
        }
        else if (value.TryGetApplePay(out var applePayValue))
        {
            JsonSerializer.Serialize(writer, applePayValue, options);
        }
        else if (value.TryGetBacsDirectDebit(out var bacsDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, bacsDirectDebitValue, options);
        }
        else if (value.TryGetBillDesk(out var billDeskValue))
        {
            JsonSerializer.Serialize(writer, billDeskValue, options);
        }
        else if (value.TryGetBlik(out var blikValue))
        {
            JsonSerializer.Serialize(writer, blikValue, options);
        }
        else if (value.TryGetCard(out var cardValue))
        {
            JsonSerializer.Serialize(writer, cardValue, options);
        }
        else if (value.TryGetStoredPaymentMethod(out var storedPaymentMethodValue))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethodValue, options);
        }
        else if (value.TryGetCellulant(out var cellulantValue))
        {
            JsonSerializer.Serialize(writer, cellulantValue, options);
        }
        else if (value.TryGetDoku(out var dokuValue))
        {
            JsonSerializer.Serialize(writer, dokuValue, options);
        }
        else if (value.TryGetDragonpay(out var dragonpayValue))
        {
            JsonSerializer.Serialize(writer, dragonpayValue, options);
        }
        else if (value.TryGetEBankingFinland(out var eBankingFinlandValue))
        {
            JsonSerializer.Serialize(writer, eBankingFinlandValue, options);
        }
        else if (value.TryGetVoucher(out var voucherValue))
        {
            JsonSerializer.Serialize(writer, voucherValue, options);
        }
        else if (value.TryGetEftDirectDebit(out var eftDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, eftDirectDebitValue, options);
        }
        else if (value.TryGetDetailsOfTokensThatAreNotStoredWithAdyen(
            out var detailsOfTokensThatAreNotStoredWithAdyenValue))
        {
            JsonSerializer.Serialize(writer, detailsOfTokensThatAreNotStoredWithAdyenValue, options);
        }
        else if (value.TryGetFastlane(out var fastlaneValue))
        {
            JsonSerializer.Serialize(writer, fastlaneValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else if (value.TryGetKlarna(out var klarnaValue))
        {
            JsonSerializer.Serialize(writer, klarnaValue, options);
        }
        else if (value.TryGetMasterpass(out var masterpassValue))
        {
            JsonSerializer.Serialize(writer, masterpassValue, options);
        }
        else if (value.TryGetMbWay(out var mbWayValue))
        {
            JsonSerializer.Serialize(writer, mbWayValue, options);
        }
        else if (value.TryGetMobilePay(out var mobilePayValue))
        {
            JsonSerializer.Serialize(writer, mobilePayValue, options);
        }
        else if (value.TryGetMolPay(out var molPayValue))
        {
            JsonSerializer.Serialize(writer, molPayValue, options);
        }
        else if (value.TryGetOpenInvoice(out var openInvoiceValue))
        {
            JsonSerializer.Serialize(writer, openInvoiceValue, options);
        }
        else if (value.TryGetPayByBankAisDirectDebit(out var payByBankAisDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, payByBankAisDirectDebitValue, options);
        }
        else if (value.TryGetPayByBank(out var payByBankValue))
        {
            JsonSerializer.Serialize(writer, payByBankValue, options);
        }
        else if (value.TryGetPayPal(out var payPalValue))
        {
            JsonSerializer.Serialize(writer, payPalValue, options);
        }
        else if (value.TryGetPayPay(out var payPayValue))
        {
            JsonSerializer.Serialize(writer, payPayValue, options);
        }
        else if (value.TryGetPayTo(out var payToValue))
        {
            JsonSerializer.Serialize(writer, payToValue, options);
        }
        else if (value.TryGetPayU(out var payUValue))
        {
            JsonSerializer.Serialize(writer, payUValue, options);
        }
        else if (value.TryGetPaymentDetails(out var paymentDetailsValue))
        {
            JsonSerializer.Serialize(writer, paymentDetailsValue, options);
        }
        else if (value.TryGetPseLatam(out var pseLatamValue))
        {
            JsonSerializer.Serialize(writer, pseLatamValue, options);
        }
        else if (value.TryGetRakutenPay(out var rakutenPayValue))
        {
            JsonSerializer.Serialize(writer, rakutenPayValue, options);
        }
        else if (value.TryGetRatepay(out var ratepayValue))
        {
            JsonSerializer.Serialize(writer, ratepayValue, options);
        }
        else if (value.TryGetRiverty(out var rivertyValue))
        {
            JsonSerializer.Serialize(writer, rivertyValue, options);
        }
        else if (value.TryGetSamsungPay(out var samsungPayValue))
        {
            JsonSerializer.Serialize(writer, samsungPayValue, options);
        }
        else if (value.TryGetSepaDirectDebit(out var sepaDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, sepaDirectDebitValue, options);
        }
        else if (value.TryGetTwint(out var twintValue))
        {
            JsonSerializer.Serialize(writer, twintValue, options);
        }
        else if (value.TryGetUpiCollect(out var upiCollectValue))
        {
            JsonSerializer.Serialize(writer, upiCollectValue, options);
        }
        else if (value.TryGetUpiIntent(out var upiIntentValue))
        {
            JsonSerializer.Serialize(writer, upiIntentValue, options);
        }
        else if (value.TryGetUpiQr(out var upiQrValue))
        {
            JsonSerializer.Serialize(writer, upiQrValue, options);
        }
        else if (value.TryGetVipps(out var vippsValue))
        {
            JsonSerializer.Serialize(writer, vippsValue, options);
        }
        else if (value.TryGetVisaCheckout(out var visaCheckoutValue))
        {
            JsonSerializer.Serialize(writer, visaCheckoutValue, options);
        }
        else if (value.TryGetWeChatPay(out var weChatPayValue))
        {
            JsonSerializer.Serialize(writer, weChatPayValue, options);
        }
        else if (value.TryGetWeChatPayMiniProgram(out var weChatPayMiniProgramValue))
        {
            JsonSerializer.Serialize(writer, weChatPayMiniProgramValue, options);
        }
        else if (value.TryGetZip(out var zipValue))
        {
            JsonSerializer.Serialize(writer, zipValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentMethod1Model)} contains no valid value to serialize.");
        }
    }
}
