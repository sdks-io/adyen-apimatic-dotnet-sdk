using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypePaymentDetails>))]
public sealed record TypePaymentDetails : OpenStringEnum<TypePaymentDetails>
{
    private TypePaymentDetails(string value) : base(value)
    {
    }

    public static readonly TypePaymentDetails Alipay = new("alipay");

    public static readonly TypePaymentDetails Multibanco = new("multibanco");

    public static readonly TypePaymentDetails BankTransfer = new("bankTransfer");

    public static readonly TypePaymentDetails BankTransferIban = new("bankTransfer_IBAN");

    public static readonly TypePaymentDetails Paybright = new("paybright");

    public static readonly TypePaymentDetails Paynow = new("paynow");

    public static readonly TypePaymentDetails AffirmPos = new("affirm_pos");

    public static readonly TypePaymentDetails Iris = new("iris");

    public static readonly TypePaymentDetails Trustly = new("trustly");

    public static readonly TypePaymentDetails Trustlyvector = new("trustlyvector");

    public static readonly TypePaymentDetails Oney = new("oney");

    public static readonly TypePaymentDetails Facilypay = new("facilypay");

    public static readonly TypePaymentDetails Facilypay3X = new("facilypay_3x");

    public static readonly TypePaymentDetails Facilypay4X = new("facilypay_4x");

    public static readonly TypePaymentDetails Facilypay6X = new("facilypay_6x");

    public static readonly TypePaymentDetails Facilypay10X = new("facilypay_10x");

    public static readonly TypePaymentDetails Facilypay12X = new("facilypay_12x");

    public static readonly TypePaymentDetails Unionpay = new("unionpay");

    public static readonly TypePaymentDetails KcpBanktransfer = new("kcp_banktransfer");

    public static readonly TypePaymentDetails KcpPayco = new("kcp_payco");

    public static readonly TypePaymentDetails KcpCreditcard = new("kcp_creditcard");

    public static readonly TypePaymentDetails WechatpaySdk = new("wechatpaySDK");

    public static readonly TypePaymentDetails WechatpayQr = new("wechatpayQR");

    public static readonly TypePaymentDetails WechatpayWeb = new("wechatpayWeb");

    public static readonly TypePaymentDetails MolpayBoost = new("molpay_boost");

    public static readonly TypePaymentDetails WalletIn = new("wallet_IN");

    public static readonly TypePaymentDetails PayuInCashcard = new("payu_IN_cashcard");

    public static readonly TypePaymentDetails PayuInNb = new("payu_IN_nb");

    public static readonly TypePaymentDetails Paytm = new("paytm");

    public static readonly TypePaymentDetails MolpayEbankingVn = new("molpay_ebanking_VN");

    public static readonly TypePaymentDetails MolpayEbankingMy = new("molpay_ebanking_MY");

    public static readonly TypePaymentDetails MolpayEbankingDirectMy = new("molpay_ebanking_direct_MY");

    public static readonly TypePaymentDetails Swish = new("swish");

    public static readonly TypePaymentDetails Bizum = new("bizum");

    public static readonly TypePaymentDetails Walley = new("walley");

    public static readonly TypePaymentDetails WalleyB2B = new("walley_b2b");

    public static readonly TypePaymentDetails Alma = new("alma");

    public static readonly TypePaymentDetails Paypo = new("paypo");

    public static readonly TypePaymentDetails Scalapay = new("scalapay");

    public static readonly TypePaymentDetails Scalapay3X = new("scalapay_3x");

    public static readonly TypePaymentDetails Scalapay4X = new("scalapay_4x");

    public static readonly TypePaymentDetails MolpayFpx = new("molpay_fpx");

    public static readonly TypePaymentDetails Payme = new("payme");

    public static readonly TypePaymentDetails PaymePos = new("payme_pos");

    public static readonly TypePaymentDetails Konbini = new("konbini");

    public static readonly TypePaymentDetails DirectEbanking = new("directEbanking");

    public static readonly TypePaymentDetails Boletobancario = new("boletobancario");

    public static readonly TypePaymentDetails Cashticket = new("cashticket");

    public static readonly TypePaymentDetails Ikano = new("ikano");

    public static readonly TypePaymentDetails Karenmillen = new("karenmillen");

    public static readonly TypePaymentDetails Oasis = new("oasis");

    public static readonly TypePaymentDetails Warehouse = new("warehouse");

    public static readonly TypePaymentDetails PrimeiropayBoleto = new("primeiropay_boleto");

    public static readonly TypePaymentDetails Mada = new("mada");

    public static readonly TypePaymentDetails Benefit = new("benefit");

    public static readonly TypePaymentDetails Knet = new("knet");

    public static readonly TypePaymentDetails Omannet = new("omannet");

    public static readonly TypePaymentDetails GopayWallet = new("gopay_wallet");

    public static readonly TypePaymentDetails KcpNaverpay = new("kcp_naverpay");

    public static readonly TypePaymentDetails Fawry = new("fawry");

    public static readonly TypePaymentDetails Atome = new("atome");

    public static readonly TypePaymentDetails Naps = new("naps");

    public static readonly TypePaymentDetails Nordea = new("nordea");

    public static readonly TypePaymentDetails BoletobancarioBradesco = new("boletobancario_bradesco");

    public static readonly TypePaymentDetails BoletobancarioItau = new("boletobancario_itau");

    public static readonly TypePaymentDetails BoletobancarioSantander = new("boletobancario_santander");

    public static readonly TypePaymentDetails BoletobancarioBancodobrasil = new("boletobancario_bancodobrasil");

    public static readonly TypePaymentDetails BoletobancarioHsbc = new("boletobancario_hsbc");

    public static readonly TypePaymentDetails MolpayMaybank2U = new("molpay_maybank2u");

    public static readonly TypePaymentDetails MolpayCimb = new("molpay_cimb");

    public static readonly TypePaymentDetails MolpayRhb = new("molpay_rhb");

    public static readonly TypePaymentDetails MolpayAmb = new("molpay_amb");

    public static readonly TypePaymentDetails MolpayHlb = new("molpay_hlb");

    public static readonly TypePaymentDetails MolpayAffinEpg = new("molpay_affin_epg");

    public static readonly TypePaymentDetails MolpayBankislam = new("molpay_bankislam");

    public static readonly TypePaymentDetails MolpayPublicbank = new("molpay_publicbank");

    public static readonly TypePaymentDetails FpxAgrobank = new("fpx_agrobank");

    public static readonly TypePaymentDetails Touchngo = new("touchngo");

    public static readonly TypePaymentDetails Maybank2UMae = new("maybank2u_mae");

    public static readonly TypePaymentDetails Duitnow = new("duitnow");

    public static readonly TypePaymentDetails Promptpay = new("promptpay");

    public static readonly TypePaymentDetails TwintPos = new("twint_pos");

    public static readonly TypePaymentDetails AlipayHk = new("alipay_hk");

    public static readonly TypePaymentDetails AlipayHkWeb = new("alipay_hk_web");

    public static readonly TypePaymentDetails AlipayHkWap = new("alipay_hk_wap");

    public static readonly TypePaymentDetails AlipayWap = new("alipay_wap");

    public static readonly TypePaymentDetails Balanceplatform = new("balanceplatform");

    public TResult Match<TResult>(Func<TResult> onAlipay,
        Func<TResult> onMultibanco,
        Func<TResult> onBankTransfer,
        Func<TResult> onBankTransferIban,
        Func<TResult> onPaybright,
        Func<TResult> onPaynow,
        Func<TResult> onAffirmPos,
        Func<TResult> onIris,
        Func<TResult> onTrustly,
        Func<TResult> onTrustlyvector,
        Func<TResult> onOney,
        Func<TResult> onFacilypay,
        Func<TResult> onFacilypay3X,
        Func<TResult> onFacilypay4X,
        Func<TResult> onFacilypay6X,
        Func<TResult> onFacilypay10X,
        Func<TResult> onFacilypay12X,
        Func<TResult> onUnionpay,
        Func<TResult> onKcpBanktransfer,
        Func<TResult> onKcpPayco,
        Func<TResult> onKcpCreditcard,
        Func<TResult> onWechatpaySdk,
        Func<TResult> onWechatpayQr,
        Func<TResult> onWechatpayWeb,
        Func<TResult> onMolpayBoost,
        Func<TResult> onWalletIn,
        Func<TResult> onPayuInCashcard,
        Func<TResult> onPayuInNb,
        Func<TResult> onPaytm,
        Func<TResult> onMolpayEbankingVn,
        Func<TResult> onMolpayEbankingMy,
        Func<TResult> onMolpayEbankingDirectMy,
        Func<TResult> onSwish,
        Func<TResult> onBizum,
        Func<TResult> onWalley,
        Func<TResult> onWalleyB2B,
        Func<TResult> onAlma,
        Func<TResult> onPaypo,
        Func<TResult> onScalapay,
        Func<TResult> onScalapay3X,
        Func<TResult> onScalapay4X,
        Func<TResult> onMolpayFpx,
        Func<TResult> onPayme,
        Func<TResult> onPaymePos,
        Func<TResult> onKonbini,
        Func<TResult> onDirectEbanking,
        Func<TResult> onBoletobancario,
        Func<TResult> onCashticket,
        Func<TResult> onIkano,
        Func<TResult> onKarenmillen,
        Func<TResult> onOasis,
        Func<TResult> onWarehouse,
        Func<TResult> onPrimeiropayBoleto,
        Func<TResult> onMada,
        Func<TResult> onBenefit,
        Func<TResult> onKnet,
        Func<TResult> onOmannet,
        Func<TResult> onGopayWallet,
        Func<TResult> onKcpNaverpay,
        Func<TResult> onFawry,
        Func<TResult> onAtome,
        Func<TResult> onNaps,
        Func<TResult> onNordea,
        Func<TResult> onBoletobancarioBradesco,
        Func<TResult> onBoletobancarioItau,
        Func<TResult> onBoletobancarioSantander,
        Func<TResult> onBoletobancarioBancodobrasil,
        Func<TResult> onBoletobancarioHsbc,
        Func<TResult> onMolpayMaybank2U,
        Func<TResult> onMolpayCimb,
        Func<TResult> onMolpayRhb,
        Func<TResult> onMolpayAmb,
        Func<TResult> onMolpayHlb,
        Func<TResult> onMolpayAffinEpg,
        Func<TResult> onMolpayBankislam,
        Func<TResult> onMolpayPublicbank,
        Func<TResult> onFpxAgrobank,
        Func<TResult> onTouchngo,
        Func<TResult> onMaybank2UMae,
        Func<TResult> onDuitnow,
        Func<TResult> onPromptpay,
        Func<TResult> onTwintPos,
        Func<TResult> onAlipayHk,
        Func<TResult> onAlipayHkWeb,
        Func<TResult> onAlipayHkWap,
        Func<TResult> onAlipayWap,
        Func<TResult> onBalanceplatform,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Alipay => onAlipay(),
            _ when this == Multibanco => onMultibanco(),
            _ when this == BankTransfer => onBankTransfer(),
            _ when this == BankTransferIban => onBankTransferIban(),
            _ when this == Paybright => onPaybright(),
            _ when this == Paynow => onPaynow(),
            _ when this == AffirmPos => onAffirmPos(),
            _ when this == Iris => onIris(),
            _ when this == Trustly => onTrustly(),
            _ when this == Trustlyvector => onTrustlyvector(),
            _ when this == Oney => onOney(),
            _ when this == Facilypay => onFacilypay(),
            _ when this == Facilypay3X => onFacilypay3X(),
            _ when this == Facilypay4X => onFacilypay4X(),
            _ when this == Facilypay6X => onFacilypay6X(),
            _ when this == Facilypay10X => onFacilypay10X(),
            _ when this == Facilypay12X => onFacilypay12X(),
            _ when this == Unionpay => onUnionpay(),
            _ when this == KcpBanktransfer => onKcpBanktransfer(),
            _ when this == KcpPayco => onKcpPayco(),
            _ when this == KcpCreditcard => onKcpCreditcard(),
            _ when this == WechatpaySdk => onWechatpaySdk(),
            _ when this == WechatpayQr => onWechatpayQr(),
            _ when this == WechatpayWeb => onWechatpayWeb(),
            _ when this == MolpayBoost => onMolpayBoost(),
            _ when this == WalletIn => onWalletIn(),
            _ when this == PayuInCashcard => onPayuInCashcard(),
            _ when this == PayuInNb => onPayuInNb(),
            _ when this == Paytm => onPaytm(),
            _ when this == MolpayEbankingVn => onMolpayEbankingVn(),
            _ when this == MolpayEbankingMy => onMolpayEbankingMy(),
            _ when this == MolpayEbankingDirectMy => onMolpayEbankingDirectMy(),
            _ when this == Swish => onSwish(),
            _ when this == Bizum => onBizum(),
            _ when this == Walley => onWalley(),
            _ when this == WalleyB2B => onWalleyB2B(),
            _ when this == Alma => onAlma(),
            _ when this == Paypo => onPaypo(),
            _ when this == Scalapay => onScalapay(),
            _ when this == Scalapay3X => onScalapay3X(),
            _ when this == Scalapay4X => onScalapay4X(),
            _ when this == MolpayFpx => onMolpayFpx(),
            _ when this == Payme => onPayme(),
            _ when this == PaymePos => onPaymePos(),
            _ when this == Konbini => onKonbini(),
            _ when this == DirectEbanking => onDirectEbanking(),
            _ when this == Boletobancario => onBoletobancario(),
            _ when this == Cashticket => onCashticket(),
            _ when this == Ikano => onIkano(),
            _ when this == Karenmillen => onKarenmillen(),
            _ when this == Oasis => onOasis(),
            _ when this == Warehouse => onWarehouse(),
            _ when this == PrimeiropayBoleto => onPrimeiropayBoleto(),
            _ when this == Mada => onMada(),
            _ when this == Benefit => onBenefit(),
            _ when this == Knet => onKnet(),
            _ when this == Omannet => onOmannet(),
            _ when this == GopayWallet => onGopayWallet(),
            _ when this == KcpNaverpay => onKcpNaverpay(),
            _ when this == Fawry => onFawry(),
            _ when this == Atome => onAtome(),
            _ when this == Naps => onNaps(),
            _ when this == Nordea => onNordea(),
            _ when this == BoletobancarioBradesco => onBoletobancarioBradesco(),
            _ when this == BoletobancarioItau => onBoletobancarioItau(),
            _ when this == BoletobancarioSantander => onBoletobancarioSantander(),
            _ when this == BoletobancarioBancodobrasil => onBoletobancarioBancodobrasil(),
            _ when this == BoletobancarioHsbc => onBoletobancarioHsbc(),
            _ when this == MolpayMaybank2U => onMolpayMaybank2U(),
            _ when this == MolpayCimb => onMolpayCimb(),
            _ when this == MolpayRhb => onMolpayRhb(),
            _ when this == MolpayAmb => onMolpayAmb(),
            _ when this == MolpayHlb => onMolpayHlb(),
            _ when this == MolpayAffinEpg => onMolpayAffinEpg(),
            _ when this == MolpayBankislam => onMolpayBankislam(),
            _ when this == MolpayPublicbank => onMolpayPublicbank(),
            _ when this == FpxAgrobank => onFpxAgrobank(),
            _ when this == Touchngo => onTouchngo(),
            _ when this == Maybank2UMae => onMaybank2UMae(),
            _ when this == Duitnow => onDuitnow(),
            _ when this == Promptpay => onPromptpay(),
            _ when this == TwintPos => onTwintPos(),
            _ when this == AlipayHk => onAlipayHk(),
            _ when this == AlipayHkWeb => onAlipayHkWeb(),
            _ when this == AlipayHkWap => onAlipayHkWap(),
            _ when this == AlipayWap => onAlipayWap(),
            _ when this == Balanceplatform => onBalanceplatform(),
            _ => otherwise(Value)
        };

    public void Match(Action onAlipay,
        Action onMultibanco,
        Action onBankTransfer,
        Action onBankTransferIban,
        Action onPaybright,
        Action onPaynow,
        Action onAffirmPos,
        Action onIris,
        Action onTrustly,
        Action onTrustlyvector,
        Action onOney,
        Action onFacilypay,
        Action onFacilypay3X,
        Action onFacilypay4X,
        Action onFacilypay6X,
        Action onFacilypay10X,
        Action onFacilypay12X,
        Action onUnionpay,
        Action onKcpBanktransfer,
        Action onKcpPayco,
        Action onKcpCreditcard,
        Action onWechatpaySdk,
        Action onWechatpayQr,
        Action onWechatpayWeb,
        Action onMolpayBoost,
        Action onWalletIn,
        Action onPayuInCashcard,
        Action onPayuInNb,
        Action onPaytm,
        Action onMolpayEbankingVn,
        Action onMolpayEbankingMy,
        Action onMolpayEbankingDirectMy,
        Action onSwish,
        Action onBizum,
        Action onWalley,
        Action onWalleyB2B,
        Action onAlma,
        Action onPaypo,
        Action onScalapay,
        Action onScalapay3X,
        Action onScalapay4X,
        Action onMolpayFpx,
        Action onPayme,
        Action onPaymePos,
        Action onKonbini,
        Action onDirectEbanking,
        Action onBoletobancario,
        Action onCashticket,
        Action onIkano,
        Action onKarenmillen,
        Action onOasis,
        Action onWarehouse,
        Action onPrimeiropayBoleto,
        Action onMada,
        Action onBenefit,
        Action onKnet,
        Action onOmannet,
        Action onGopayWallet,
        Action onKcpNaverpay,
        Action onFawry,
        Action onAtome,
        Action onNaps,
        Action onNordea,
        Action onBoletobancarioBradesco,
        Action onBoletobancarioItau,
        Action onBoletobancarioSantander,
        Action onBoletobancarioBancodobrasil,
        Action onBoletobancarioHsbc,
        Action onMolpayMaybank2U,
        Action onMolpayCimb,
        Action onMolpayRhb,
        Action onMolpayAmb,
        Action onMolpayHlb,
        Action onMolpayAffinEpg,
        Action onMolpayBankislam,
        Action onMolpayPublicbank,
        Action onFpxAgrobank,
        Action onTouchngo,
        Action onMaybank2UMae,
        Action onDuitnow,
        Action onPromptpay,
        Action onTwintPos,
        Action onAlipayHk,
        Action onAlipayHkWeb,
        Action onAlipayHkWap,
        Action onAlipayWap,
        Action onBalanceplatform,
        Action<string> otherwise)
    {
        if (this == Alipay) onAlipay();
        else if (this == Multibanco) onMultibanco();
        else if (this == BankTransfer) onBankTransfer();
        else if (this == BankTransferIban) onBankTransferIban();
        else if (this == Paybright) onPaybright();
        else if (this == Paynow) onPaynow();
        else if (this == AffirmPos) onAffirmPos();
        else if (this == Iris) onIris();
        else if (this == Trustly) onTrustly();
        else if (this == Trustlyvector) onTrustlyvector();
        else if (this == Oney) onOney();
        else if (this == Facilypay) onFacilypay();
        else if (this == Facilypay3X) onFacilypay3X();
        else if (this == Facilypay4X) onFacilypay4X();
        else if (this == Facilypay6X) onFacilypay6X();
        else if (this == Facilypay10X) onFacilypay10X();
        else if (this == Facilypay12X) onFacilypay12X();
        else if (this == Unionpay) onUnionpay();
        else if (this == KcpBanktransfer) onKcpBanktransfer();
        else if (this == KcpPayco) onKcpPayco();
        else if (this == KcpCreditcard) onKcpCreditcard();
        else if (this == WechatpaySdk) onWechatpaySdk();
        else if (this == WechatpayQr) onWechatpayQr();
        else if (this == WechatpayWeb) onWechatpayWeb();
        else if (this == MolpayBoost) onMolpayBoost();
        else if (this == WalletIn) onWalletIn();
        else if (this == PayuInCashcard) onPayuInCashcard();
        else if (this == PayuInNb) onPayuInNb();
        else if (this == Paytm) onPaytm();
        else if (this == MolpayEbankingVn) onMolpayEbankingVn();
        else if (this == MolpayEbankingMy) onMolpayEbankingMy();
        else if (this == MolpayEbankingDirectMy) onMolpayEbankingDirectMy();
        else if (this == Swish) onSwish();
        else if (this == Bizum) onBizum();
        else if (this == Walley) onWalley();
        else if (this == WalleyB2B) onWalleyB2B();
        else if (this == Alma) onAlma();
        else if (this == Paypo) onPaypo();
        else if (this == Scalapay) onScalapay();
        else if (this == Scalapay3X) onScalapay3X();
        else if (this == Scalapay4X) onScalapay4X();
        else if (this == MolpayFpx) onMolpayFpx();
        else if (this == Payme) onPayme();
        else if (this == PaymePos) onPaymePos();
        else if (this == Konbini) onKonbini();
        else if (this == DirectEbanking) onDirectEbanking();
        else if (this == Boletobancario) onBoletobancario();
        else if (this == Cashticket) onCashticket();
        else if (this == Ikano) onIkano();
        else if (this == Karenmillen) onKarenmillen();
        else if (this == Oasis) onOasis();
        else if (this == Warehouse) onWarehouse();
        else if (this == PrimeiropayBoleto) onPrimeiropayBoleto();
        else if (this == Mada) onMada();
        else if (this == Benefit) onBenefit();
        else if (this == Knet) onKnet();
        else if (this == Omannet) onOmannet();
        else if (this == GopayWallet) onGopayWallet();
        else if (this == KcpNaverpay) onKcpNaverpay();
        else if (this == Fawry) onFawry();
        else if (this == Atome) onAtome();
        else if (this == Naps) onNaps();
        else if (this == Nordea) onNordea();
        else if (this == BoletobancarioBradesco) onBoletobancarioBradesco();
        else if (this == BoletobancarioItau) onBoletobancarioItau();
        else if (this == BoletobancarioSantander) onBoletobancarioSantander();
        else if (this == BoletobancarioBancodobrasil) onBoletobancarioBancodobrasil();
        else if (this == BoletobancarioHsbc) onBoletobancarioHsbc();
        else if (this == MolpayMaybank2U) onMolpayMaybank2U();
        else if (this == MolpayCimb) onMolpayCimb();
        else if (this == MolpayRhb) onMolpayRhb();
        else if (this == MolpayAmb) onMolpayAmb();
        else if (this == MolpayHlb) onMolpayHlb();
        else if (this == MolpayAffinEpg) onMolpayAffinEpg();
        else if (this == MolpayBankislam) onMolpayBankislam();
        else if (this == MolpayPublicbank) onMolpayPublicbank();
        else if (this == FpxAgrobank) onFpxAgrobank();
        else if (this == Touchngo) onTouchngo();
        else if (this == Maybank2UMae) onMaybank2UMae();
        else if (this == Duitnow) onDuitnow();
        else if (this == Promptpay) onPromptpay();
        else if (this == TwintPos) onTwintPos();
        else if (this == AlipayHk) onAlipayHk();
        else if (this == AlipayHkWeb) onAlipayHkWeb();
        else if (this == AlipayHkWap) onAlipayHkWap();
        else if (this == AlipayWap) onAlipayWap();
        else if (this == Balanceplatform) onBalanceplatform();
        else otherwise(Value);
    }
}
