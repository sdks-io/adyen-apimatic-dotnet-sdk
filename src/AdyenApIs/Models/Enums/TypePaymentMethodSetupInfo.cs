using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypePaymentMethodSetupInfo>))]
public sealed record TypePaymentMethodSetupInfo : OpenStringEnum<TypePaymentMethodSetupInfo>
{
    private TypePaymentMethodSetupInfo(string value) : base(value)
    {
    }

    public static readonly TypePaymentMethodSetupInfo Abrapetite = new("abrapetite");

    public static readonly TypePaymentMethodSetupInfo AbrapetiteCredit = new("abrapetite_credit");

    public static readonly TypePaymentMethodSetupInfo AbrapetiteDebit = new("abrapetite_debit");

    public static readonly TypePaymentMethodSetupInfo AbrapetitePrepaid = new("abrapetite_prepaid");

    public static readonly TypePaymentMethodSetupInfo Accel = new("accel");

    public static readonly TypePaymentMethodSetupInfo Ach = new("ach");

    public static readonly TypePaymentMethodSetupInfo Affirm = new("affirm");

    public static readonly TypePaymentMethodSetupInfo Afterpaytouch = new("afterpaytouch");

    public static readonly TypePaymentMethodSetupInfo Alelo = new("alelo");

    public static readonly TypePaymentMethodSetupInfo Alipay = new("alipay");

    public static readonly TypePaymentMethodSetupInfo AlipayHk = new("alipay_hk");

    public static readonly TypePaymentMethodSetupInfo AlipayPlus = new("alipay_plus");

    public static readonly TypePaymentMethodSetupInfo AlipayWap = new("alipay_wap");

    public static readonly TypePaymentMethodSetupInfo Amex = new("amex");

    public static readonly TypePaymentMethodSetupInfo Applepay = new("applepay");

    public static readonly TypePaymentMethodSetupInfo Avancard = new("avancard");

    public static readonly TypePaymentMethodSetupInfo AvancardCredit = new("avancard_credit");

    public static readonly TypePaymentMethodSetupInfo AvancardDebit = new("avancard_debit");

    public static readonly TypePaymentMethodSetupInfo BaneseCard = new("banese_card");

    public static readonly TypePaymentMethodSetupInfo BaneseCardCredit = new("banese_card_credit");

    public static readonly TypePaymentMethodSetupInfo BaneseCardDebit = new("banese_card_debit");

    public static readonly TypePaymentMethodSetupInfo BaneseCardPrepaid = new("banese_card_prepaid");

    public static readonly TypePaymentMethodSetupInfo Bcmc = new("bcmc");

    public static readonly TypePaymentMethodSetupInfo Blik = new("blik");

    public static readonly TypePaymentMethodSetupInfo BlikPos = new("blik_pos");

    public static readonly TypePaymentMethodSetupInfo BrSchemes = new("br_schemes");

    public static readonly TypePaymentMethodSetupInfo Cartebancaire = new("cartebancaire");

    public static readonly TypePaymentMethodSetupInfo Clearpay = new("clearpay");

    public static readonly TypePaymentMethodSetupInfo Clicktopay = new("clicktopay");

    public static readonly TypePaymentMethodSetupInfo Cooper = new("cooper");

    public static readonly TypePaymentMethodSetupInfo CooperCredit = new("cooper_credit");

    public static readonly TypePaymentMethodSetupInfo CooperDebit = new("cooper_debit");

    public static readonly TypePaymentMethodSetupInfo CooperFoodDebit = new("cooper_food_debit");

    public static readonly TypePaymentMethodSetupInfo CooperMealDebit = new("cooper_meal_debit");

    public static readonly TypePaymentMethodSetupInfo CooperPrepaid = new("cooper_prepaid");

    public static readonly TypePaymentMethodSetupInfo CooperPrivateCredit = new("cooper_private_credit");

    public static readonly TypePaymentMethodSetupInfo CooperRetailCredit = new("cooper_retail_credit");

    public static readonly TypePaymentMethodSetupInfo Credtodos = new("credtodos");

    public static readonly TypePaymentMethodSetupInfo CredtodosPrivateCredit = new("credtodos_private_credit");

    public static readonly TypePaymentMethodSetupInfo CredtodosPrivateDebit = new("credtodos_private_debit");

    public static readonly TypePaymentMethodSetupInfo Cup = new("cup");

    public static readonly TypePaymentMethodSetupInfo Diners = new("diners");

    public static readonly TypePaymentMethodSetupInfo DirectdebitGb = new("directdebit_GB");

    public static readonly TypePaymentMethodSetupInfo Discover = new("discover");

    public static readonly TypePaymentMethodSetupInfo EbankingFi = new("ebanking_FI");

    public static readonly TypePaymentMethodSetupInfo EftDirectdebitCa = new("eft_directdebit_CA");

    public static readonly TypePaymentMethodSetupInfo EftposAustralia = new("eftpos_australia");

    public static readonly TypePaymentMethodSetupInfo Elo = new("elo");

    public static readonly TypePaymentMethodSetupInfo Elocredit = new("elocredit");

    public static readonly TypePaymentMethodSetupInfo Elodebit = new("elodebit");

    public static readonly TypePaymentMethodSetupInfo Girocard = new("girocard");

    public static readonly TypePaymentMethodSetupInfo Givex = new("givex");

    public static readonly TypePaymentMethodSetupInfo Googlepay = new("googlepay");

    public static readonly TypePaymentMethodSetupInfo GreenCard = new("green_card");

    public static readonly TypePaymentMethodSetupInfo GreenCardCredit = new("green_card_credit");

    public static readonly TypePaymentMethodSetupInfo GreenCardDebit = new("green_card_debit");

    public static readonly TypePaymentMethodSetupInfo GreenCardFoodPrepaid = new("green_card_food_prepaid");

    public static readonly TypePaymentMethodSetupInfo GreenCardMealPrepaid = new("green_card_meal_prepaid");

    public static readonly TypePaymentMethodSetupInfo GreenCardPrepaid = new("green_card_prepaid");

    public static readonly TypePaymentMethodSetupInfo Hiper = new("hiper");

    public static readonly TypePaymentMethodSetupInfo Hipercard = new("hipercard");

    public static readonly TypePaymentMethodSetupInfo Ideal = new("ideal");

    public static readonly TypePaymentMethodSetupInfo InteracCard = new("interac_card");

    public static readonly TypePaymentMethodSetupInfo Jcb = new("jcb");

    public static readonly TypePaymentMethodSetupInfo Klarna = new("klarna");

    public static readonly TypePaymentMethodSetupInfo KlarnaAccount = new("klarna_account");

    public static readonly TypePaymentMethodSetupInfo KlarnaB2B = new("klarna_b2b");

    public static readonly TypePaymentMethodSetupInfo KlarnaPaynow = new("klarna_paynow");

    public static readonly TypePaymentMethodSetupInfo LeCard = new("le_card");

    public static readonly TypePaymentMethodSetupInfo LeCardCredit = new("le_card_credit");

    public static readonly TypePaymentMethodSetupInfo LeCardDebit = new("le_card_debit");

    public static readonly TypePaymentMethodSetupInfo Maestro = new("maestro");

    public static readonly TypePaymentMethodSetupInfo MaestroUsa = new("maestro_usa");

    public static readonly TypePaymentMethodSetupInfo Maxifrota = new("maxifrota");

    public static readonly TypePaymentMethodSetupInfo MaxifrotaPrepaid = new("maxifrota_prepaid");

    public static readonly TypePaymentMethodSetupInfo Mbway = new("mbway");

    public static readonly TypePaymentMethodSetupInfo Mc = new("mc");

    public static readonly TypePaymentMethodSetupInfo Mcdebit = new("mcdebit");

    public static readonly TypePaymentMethodSetupInfo MealVoucherFr = new("mealVoucher_FR");

    public static readonly TypePaymentMethodSetupInfo Megaleve = new("megaleve");

    public static readonly TypePaymentMethodSetupInfo MegaleveCredit = new("megaleve_credit");

    public static readonly TypePaymentMethodSetupInfo MegaleveDebit = new("megaleve_debit");

    public static readonly TypePaymentMethodSetupInfo Mobilepay = new("mobilepay");

    public static readonly TypePaymentMethodSetupInfo Multibanco = new("multibanco");

    public static readonly TypePaymentMethodSetupInfo Nutricash = new("nutricash");

    public static readonly TypePaymentMethodSetupInfo NutricashPrepaid = new("nutricash_prepaid");

    public static readonly TypePaymentMethodSetupInfo Nyce = new("nyce");

    public static readonly TypePaymentMethodSetupInfo OnlineBankingPl = new("onlineBanking_PL");

    public static readonly TypePaymentMethodSetupInfo Paybybank = new("paybybank");

    public static readonly TypePaymentMethodSetupInfo PaybybankPlaid = new("paybybank_plaid");

    public static readonly TypePaymentMethodSetupInfo Payme = new("payme");

    public static readonly TypePaymentMethodSetupInfo PaymePos = new("payme_pos");

    public static readonly TypePaymentMethodSetupInfo Paynow = new("paynow");

    public static readonly TypePaymentMethodSetupInfo PaynowPos = new("paynow_pos");

    public static readonly TypePaymentMethodSetupInfo Paypal = new("paypal");

    public static readonly TypePaymentMethodSetupInfo Payto = new("payto");

    public static readonly TypePaymentMethodSetupInfo PersonalCard = new("personal_card");

    public static readonly TypePaymentMethodSetupInfo PersonalCardCredit = new("personal_card_credit");

    public static readonly TypePaymentMethodSetupInfo PersonalCardDebit = new("personal_card_debit");

    public static readonly TypePaymentMethodSetupInfo Pulse = new("pulse");

    public static readonly TypePaymentMethodSetupInfo Romcard = new("romcard");

    public static readonly TypePaymentMethodSetupInfo RomcardCredit = new("romcard_credit");

    public static readonly TypePaymentMethodSetupInfo RomcardDebit = new("romcard_debit");

    public static readonly TypePaymentMethodSetupInfo Senff = new("senff");

    public static readonly TypePaymentMethodSetupInfo SenffCredit = new("senff_credit");

    public static readonly TypePaymentMethodSetupInfo Sepadirectdebit = new("sepadirectdebit");

    public static readonly TypePaymentMethodSetupInfo Sodexo = new("sodexo");

    public static readonly TypePaymentMethodSetupInfo Star = new("star");

    public static readonly TypePaymentMethodSetupInfo Svs = new("svs");

    public static readonly TypePaymentMethodSetupInfo Swish = new("swish");

    public static readonly TypePaymentMethodSetupInfo Ticket = new("ticket");

    public static readonly TypePaymentMethodSetupInfo TodoGiftcard = new("todo_giftcard");

    public static readonly TypePaymentMethodSetupInfo Trustly = new("trustly");

    public static readonly TypePaymentMethodSetupInfo Twint = new("twint");

    public static readonly TypePaymentMethodSetupInfo TwintPos = new("twint_pos");

    public static readonly TypePaymentMethodSetupInfo UpBrazil = new("up_brazil");

    public static readonly TypePaymentMethodSetupInfo UpBrazilCredit = new("up_brazil_credit");

    public static readonly TypePaymentMethodSetupInfo UpBrazilDebit = new("up_brazil_debit");

    public static readonly TypePaymentMethodSetupInfo UpBrazilPrepaid = new("up_brazil_prepaid");

    public static readonly TypePaymentMethodSetupInfo ValeRefeicao = new("vale_refeicao");

    public static readonly TypePaymentMethodSetupInfo ValeRefeicaoPrepaid = new("vale_refeicao_prepaid");

    public static readonly TypePaymentMethodSetupInfo Valuelink = new("valuelink");

    public static readonly TypePaymentMethodSetupInfo VegasCard = new("vegas_card");

    public static readonly TypePaymentMethodSetupInfo VegasCardCredit = new("vegas_card_credit");

    public static readonly TypePaymentMethodSetupInfo VegasCardDebit = new("vegas_card_debit");

    public static readonly TypePaymentMethodSetupInfo VeroCard = new("vero_card");

    public static readonly TypePaymentMethodSetupInfo VeroCardCredit = new("vero_card_credit");

    public static readonly TypePaymentMethodSetupInfo VeroCardDebit = new("vero_card_debit");

    public static readonly TypePaymentMethodSetupInfo VeroCardPrepaid = new("vero_card_prepaid");

    public static readonly TypePaymentMethodSetupInfo Vipps = new("vipps");

    public static readonly TypePaymentMethodSetupInfo Visa = new("visa");

    public static readonly TypePaymentMethodSetupInfo Visadebit = new("visadebit");

    public static readonly TypePaymentMethodSetupInfo Vpay = new("vpay");

    public static readonly TypePaymentMethodSetupInfo Wechatpay = new("wechatpay");

    public static readonly TypePaymentMethodSetupInfo WechatpayPos = new("wechatpay_pos");

    public TResult Match<TResult>(Func<TResult> onAbrapetite,
        Func<TResult> onAbrapetiteCredit,
        Func<TResult> onAbrapetiteDebit,
        Func<TResult> onAbrapetitePrepaid,
        Func<TResult> onAccel,
        Func<TResult> onAch,
        Func<TResult> onAffirm,
        Func<TResult> onAfterpaytouch,
        Func<TResult> onAlelo,
        Func<TResult> onAlipay,
        Func<TResult> onAlipayHk,
        Func<TResult> onAlipayPlus,
        Func<TResult> onAlipayWap,
        Func<TResult> onAmex,
        Func<TResult> onApplepay,
        Func<TResult> onAvancard,
        Func<TResult> onAvancardCredit,
        Func<TResult> onAvancardDebit,
        Func<TResult> onBaneseCard,
        Func<TResult> onBaneseCardCredit,
        Func<TResult> onBaneseCardDebit,
        Func<TResult> onBaneseCardPrepaid,
        Func<TResult> onBcmc,
        Func<TResult> onBlik,
        Func<TResult> onBlikPos,
        Func<TResult> onBrSchemes,
        Func<TResult> onCartebancaire,
        Func<TResult> onClearpay,
        Func<TResult> onClicktopay,
        Func<TResult> onCooper,
        Func<TResult> onCooperCredit,
        Func<TResult> onCooperDebit,
        Func<TResult> onCooperFoodDebit,
        Func<TResult> onCooperMealDebit,
        Func<TResult> onCooperPrepaid,
        Func<TResult> onCooperPrivateCredit,
        Func<TResult> onCooperRetailCredit,
        Func<TResult> onCredtodos,
        Func<TResult> onCredtodosPrivateCredit,
        Func<TResult> onCredtodosPrivateDebit,
        Func<TResult> onCup,
        Func<TResult> onDiners,
        Func<TResult> onDirectdebitGb,
        Func<TResult> onDiscover,
        Func<TResult> onEbankingFi,
        Func<TResult> onEftDirectdebitCa,
        Func<TResult> onEftposAustralia,
        Func<TResult> onElo,
        Func<TResult> onElocredit,
        Func<TResult> onElodebit,
        Func<TResult> onGirocard,
        Func<TResult> onGivex,
        Func<TResult> onGooglepay,
        Func<TResult> onGreenCard,
        Func<TResult> onGreenCardCredit,
        Func<TResult> onGreenCardDebit,
        Func<TResult> onGreenCardFoodPrepaid,
        Func<TResult> onGreenCardMealPrepaid,
        Func<TResult> onGreenCardPrepaid,
        Func<TResult> onHiper,
        Func<TResult> onHipercard,
        Func<TResult> onIdeal,
        Func<TResult> onInteracCard,
        Func<TResult> onJcb,
        Func<TResult> onKlarna,
        Func<TResult> onKlarnaAccount,
        Func<TResult> onKlarnaB2B,
        Func<TResult> onKlarnaPaynow,
        Func<TResult> onLeCard,
        Func<TResult> onLeCardCredit,
        Func<TResult> onLeCardDebit,
        Func<TResult> onMaestro,
        Func<TResult> onMaestroUsa,
        Func<TResult> onMaxifrota,
        Func<TResult> onMaxifrotaPrepaid,
        Func<TResult> onMbway,
        Func<TResult> onMc,
        Func<TResult> onMcdebit,
        Func<TResult> onMealVoucherFr,
        Func<TResult> onMegaleve,
        Func<TResult> onMegaleveCredit,
        Func<TResult> onMegaleveDebit,
        Func<TResult> onMobilepay,
        Func<TResult> onMultibanco,
        Func<TResult> onNutricash,
        Func<TResult> onNutricashPrepaid,
        Func<TResult> onNyce,
        Func<TResult> onOnlineBankingPl,
        Func<TResult> onPaybybank,
        Func<TResult> onPaybybankPlaid,
        Func<TResult> onPayme,
        Func<TResult> onPaymePos,
        Func<TResult> onPaynow,
        Func<TResult> onPaynowPos,
        Func<TResult> onPaypal,
        Func<TResult> onPayto,
        Func<TResult> onPersonalCard,
        Func<TResult> onPersonalCardCredit,
        Func<TResult> onPersonalCardDebit,
        Func<TResult> onPulse,
        Func<TResult> onRomcard,
        Func<TResult> onRomcardCredit,
        Func<TResult> onRomcardDebit,
        Func<TResult> onSenff,
        Func<TResult> onSenffCredit,
        Func<TResult> onSepadirectdebit,
        Func<TResult> onSodexo,
        Func<TResult> onStar,
        Func<TResult> onSvs,
        Func<TResult> onSwish,
        Func<TResult> onTicket,
        Func<TResult> onTodoGiftcard,
        Func<TResult> onTrustly,
        Func<TResult> onTwint,
        Func<TResult> onTwintPos,
        Func<TResult> onUpBrazil,
        Func<TResult> onUpBrazilCredit,
        Func<TResult> onUpBrazilDebit,
        Func<TResult> onUpBrazilPrepaid,
        Func<TResult> onValeRefeicao,
        Func<TResult> onValeRefeicaoPrepaid,
        Func<TResult> onValuelink,
        Func<TResult> onVegasCard,
        Func<TResult> onVegasCardCredit,
        Func<TResult> onVegasCardDebit,
        Func<TResult> onVeroCard,
        Func<TResult> onVeroCardCredit,
        Func<TResult> onVeroCardDebit,
        Func<TResult> onVeroCardPrepaid,
        Func<TResult> onVipps,
        Func<TResult> onVisa,
        Func<TResult> onVisadebit,
        Func<TResult> onVpay,
        Func<TResult> onWechatpay,
        Func<TResult> onWechatpayPos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Abrapetite => onAbrapetite(),
            _ when this == AbrapetiteCredit => onAbrapetiteCredit(),
            _ when this == AbrapetiteDebit => onAbrapetiteDebit(),
            _ when this == AbrapetitePrepaid => onAbrapetitePrepaid(),
            _ when this == Accel => onAccel(),
            _ when this == Ach => onAch(),
            _ when this == Affirm => onAffirm(),
            _ when this == Afterpaytouch => onAfterpaytouch(),
            _ when this == Alelo => onAlelo(),
            _ when this == Alipay => onAlipay(),
            _ when this == AlipayHk => onAlipayHk(),
            _ when this == AlipayPlus => onAlipayPlus(),
            _ when this == AlipayWap => onAlipayWap(),
            _ when this == Amex => onAmex(),
            _ when this == Applepay => onApplepay(),
            _ when this == Avancard => onAvancard(),
            _ when this == AvancardCredit => onAvancardCredit(),
            _ when this == AvancardDebit => onAvancardDebit(),
            _ when this == BaneseCard => onBaneseCard(),
            _ when this == BaneseCardCredit => onBaneseCardCredit(),
            _ when this == BaneseCardDebit => onBaneseCardDebit(),
            _ when this == BaneseCardPrepaid => onBaneseCardPrepaid(),
            _ when this == Bcmc => onBcmc(),
            _ when this == Blik => onBlik(),
            _ when this == BlikPos => onBlikPos(),
            _ when this == BrSchemes => onBrSchemes(),
            _ when this == Cartebancaire => onCartebancaire(),
            _ when this == Clearpay => onClearpay(),
            _ when this == Clicktopay => onClicktopay(),
            _ when this == Cooper => onCooper(),
            _ when this == CooperCredit => onCooperCredit(),
            _ when this == CooperDebit => onCooperDebit(),
            _ when this == CooperFoodDebit => onCooperFoodDebit(),
            _ when this == CooperMealDebit => onCooperMealDebit(),
            _ when this == CooperPrepaid => onCooperPrepaid(),
            _ when this == CooperPrivateCredit => onCooperPrivateCredit(),
            _ when this == CooperRetailCredit => onCooperRetailCredit(),
            _ when this == Credtodos => onCredtodos(),
            _ when this == CredtodosPrivateCredit => onCredtodosPrivateCredit(),
            _ when this == CredtodosPrivateDebit => onCredtodosPrivateDebit(),
            _ when this == Cup => onCup(),
            _ when this == Diners => onDiners(),
            _ when this == DirectdebitGb => onDirectdebitGb(),
            _ when this == Discover => onDiscover(),
            _ when this == EbankingFi => onEbankingFi(),
            _ when this == EftDirectdebitCa => onEftDirectdebitCa(),
            _ when this == EftposAustralia => onEftposAustralia(),
            _ when this == Elo => onElo(),
            _ when this == Elocredit => onElocredit(),
            _ when this == Elodebit => onElodebit(),
            _ when this == Girocard => onGirocard(),
            _ when this == Givex => onGivex(),
            _ when this == Googlepay => onGooglepay(),
            _ when this == GreenCard => onGreenCard(),
            _ when this == GreenCardCredit => onGreenCardCredit(),
            _ when this == GreenCardDebit => onGreenCardDebit(),
            _ when this == GreenCardFoodPrepaid => onGreenCardFoodPrepaid(),
            _ when this == GreenCardMealPrepaid => onGreenCardMealPrepaid(),
            _ when this == GreenCardPrepaid => onGreenCardPrepaid(),
            _ when this == Hiper => onHiper(),
            _ when this == Hipercard => onHipercard(),
            _ when this == Ideal => onIdeal(),
            _ when this == InteracCard => onInteracCard(),
            _ when this == Jcb => onJcb(),
            _ when this == Klarna => onKlarna(),
            _ when this == KlarnaAccount => onKlarnaAccount(),
            _ when this == KlarnaB2B => onKlarnaB2B(),
            _ when this == KlarnaPaynow => onKlarnaPaynow(),
            _ when this == LeCard => onLeCard(),
            _ when this == LeCardCredit => onLeCardCredit(),
            _ when this == LeCardDebit => onLeCardDebit(),
            _ when this == Maestro => onMaestro(),
            _ when this == MaestroUsa => onMaestroUsa(),
            _ when this == Maxifrota => onMaxifrota(),
            _ when this == MaxifrotaPrepaid => onMaxifrotaPrepaid(),
            _ when this == Mbway => onMbway(),
            _ when this == Mc => onMc(),
            _ when this == Mcdebit => onMcdebit(),
            _ when this == MealVoucherFr => onMealVoucherFr(),
            _ when this == Megaleve => onMegaleve(),
            _ when this == MegaleveCredit => onMegaleveCredit(),
            _ when this == MegaleveDebit => onMegaleveDebit(),
            _ when this == Mobilepay => onMobilepay(),
            _ when this == Multibanco => onMultibanco(),
            _ when this == Nutricash => onNutricash(),
            _ when this == NutricashPrepaid => onNutricashPrepaid(),
            _ when this == Nyce => onNyce(),
            _ when this == OnlineBankingPl => onOnlineBankingPl(),
            _ when this == Paybybank => onPaybybank(),
            _ when this == PaybybankPlaid => onPaybybankPlaid(),
            _ when this == Payme => onPayme(),
            _ when this == PaymePos => onPaymePos(),
            _ when this == Paynow => onPaynow(),
            _ when this == PaynowPos => onPaynowPos(),
            _ when this == Paypal => onPaypal(),
            _ when this == Payto => onPayto(),
            _ when this == PersonalCard => onPersonalCard(),
            _ when this == PersonalCardCredit => onPersonalCardCredit(),
            _ when this == PersonalCardDebit => onPersonalCardDebit(),
            _ when this == Pulse => onPulse(),
            _ when this == Romcard => onRomcard(),
            _ when this == RomcardCredit => onRomcardCredit(),
            _ when this == RomcardDebit => onRomcardDebit(),
            _ when this == Senff => onSenff(),
            _ when this == SenffCredit => onSenffCredit(),
            _ when this == Sepadirectdebit => onSepadirectdebit(),
            _ when this == Sodexo => onSodexo(),
            _ when this == Star => onStar(),
            _ when this == Svs => onSvs(),
            _ when this == Swish => onSwish(),
            _ when this == Ticket => onTicket(),
            _ when this == TodoGiftcard => onTodoGiftcard(),
            _ when this == Trustly => onTrustly(),
            _ when this == Twint => onTwint(),
            _ when this == TwintPos => onTwintPos(),
            _ when this == UpBrazil => onUpBrazil(),
            _ when this == UpBrazilCredit => onUpBrazilCredit(),
            _ when this == UpBrazilDebit => onUpBrazilDebit(),
            _ when this == UpBrazilPrepaid => onUpBrazilPrepaid(),
            _ when this == ValeRefeicao => onValeRefeicao(),
            _ when this == ValeRefeicaoPrepaid => onValeRefeicaoPrepaid(),
            _ when this == Valuelink => onValuelink(),
            _ when this == VegasCard => onVegasCard(),
            _ when this == VegasCardCredit => onVegasCardCredit(),
            _ when this == VegasCardDebit => onVegasCardDebit(),
            _ when this == VeroCard => onVeroCard(),
            _ when this == VeroCardCredit => onVeroCardCredit(),
            _ when this == VeroCardDebit => onVeroCardDebit(),
            _ when this == VeroCardPrepaid => onVeroCardPrepaid(),
            _ when this == Vipps => onVipps(),
            _ when this == Visa => onVisa(),
            _ when this == Visadebit => onVisadebit(),
            _ when this == Vpay => onVpay(),
            _ when this == Wechatpay => onWechatpay(),
            _ when this == WechatpayPos => onWechatpayPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onAbrapetite,
        Action onAbrapetiteCredit,
        Action onAbrapetiteDebit,
        Action onAbrapetitePrepaid,
        Action onAccel,
        Action onAch,
        Action onAffirm,
        Action onAfterpaytouch,
        Action onAlelo,
        Action onAlipay,
        Action onAlipayHk,
        Action onAlipayPlus,
        Action onAlipayWap,
        Action onAmex,
        Action onApplepay,
        Action onAvancard,
        Action onAvancardCredit,
        Action onAvancardDebit,
        Action onBaneseCard,
        Action onBaneseCardCredit,
        Action onBaneseCardDebit,
        Action onBaneseCardPrepaid,
        Action onBcmc,
        Action onBlik,
        Action onBlikPos,
        Action onBrSchemes,
        Action onCartebancaire,
        Action onClearpay,
        Action onClicktopay,
        Action onCooper,
        Action onCooperCredit,
        Action onCooperDebit,
        Action onCooperFoodDebit,
        Action onCooperMealDebit,
        Action onCooperPrepaid,
        Action onCooperPrivateCredit,
        Action onCooperRetailCredit,
        Action onCredtodos,
        Action onCredtodosPrivateCredit,
        Action onCredtodosPrivateDebit,
        Action onCup,
        Action onDiners,
        Action onDirectdebitGb,
        Action onDiscover,
        Action onEbankingFi,
        Action onEftDirectdebitCa,
        Action onEftposAustralia,
        Action onElo,
        Action onElocredit,
        Action onElodebit,
        Action onGirocard,
        Action onGivex,
        Action onGooglepay,
        Action onGreenCard,
        Action onGreenCardCredit,
        Action onGreenCardDebit,
        Action onGreenCardFoodPrepaid,
        Action onGreenCardMealPrepaid,
        Action onGreenCardPrepaid,
        Action onHiper,
        Action onHipercard,
        Action onIdeal,
        Action onInteracCard,
        Action onJcb,
        Action onKlarna,
        Action onKlarnaAccount,
        Action onKlarnaB2B,
        Action onKlarnaPaynow,
        Action onLeCard,
        Action onLeCardCredit,
        Action onLeCardDebit,
        Action onMaestro,
        Action onMaestroUsa,
        Action onMaxifrota,
        Action onMaxifrotaPrepaid,
        Action onMbway,
        Action onMc,
        Action onMcdebit,
        Action onMealVoucherFr,
        Action onMegaleve,
        Action onMegaleveCredit,
        Action onMegaleveDebit,
        Action onMobilepay,
        Action onMultibanco,
        Action onNutricash,
        Action onNutricashPrepaid,
        Action onNyce,
        Action onOnlineBankingPl,
        Action onPaybybank,
        Action onPaybybankPlaid,
        Action onPayme,
        Action onPaymePos,
        Action onPaynow,
        Action onPaynowPos,
        Action onPaypal,
        Action onPayto,
        Action onPersonalCard,
        Action onPersonalCardCredit,
        Action onPersonalCardDebit,
        Action onPulse,
        Action onRomcard,
        Action onRomcardCredit,
        Action onRomcardDebit,
        Action onSenff,
        Action onSenffCredit,
        Action onSepadirectdebit,
        Action onSodexo,
        Action onStar,
        Action onSvs,
        Action onSwish,
        Action onTicket,
        Action onTodoGiftcard,
        Action onTrustly,
        Action onTwint,
        Action onTwintPos,
        Action onUpBrazil,
        Action onUpBrazilCredit,
        Action onUpBrazilDebit,
        Action onUpBrazilPrepaid,
        Action onValeRefeicao,
        Action onValeRefeicaoPrepaid,
        Action onValuelink,
        Action onVegasCard,
        Action onVegasCardCredit,
        Action onVegasCardDebit,
        Action onVeroCard,
        Action onVeroCardCredit,
        Action onVeroCardDebit,
        Action onVeroCardPrepaid,
        Action onVipps,
        Action onVisa,
        Action onVisadebit,
        Action onVpay,
        Action onWechatpay,
        Action onWechatpayPos,
        Action<string> otherwise)
    {
        if (this == Abrapetite) onAbrapetite();
        else if (this == AbrapetiteCredit) onAbrapetiteCredit();
        else if (this == AbrapetiteDebit) onAbrapetiteDebit();
        else if (this == AbrapetitePrepaid) onAbrapetitePrepaid();
        else if (this == Accel) onAccel();
        else if (this == Ach) onAch();
        else if (this == Affirm) onAffirm();
        else if (this == Afterpaytouch) onAfterpaytouch();
        else if (this == Alelo) onAlelo();
        else if (this == Alipay) onAlipay();
        else if (this == AlipayHk) onAlipayHk();
        else if (this == AlipayPlus) onAlipayPlus();
        else if (this == AlipayWap) onAlipayWap();
        else if (this == Amex) onAmex();
        else if (this == Applepay) onApplepay();
        else if (this == Avancard) onAvancard();
        else if (this == AvancardCredit) onAvancardCredit();
        else if (this == AvancardDebit) onAvancardDebit();
        else if (this == BaneseCard) onBaneseCard();
        else if (this == BaneseCardCredit) onBaneseCardCredit();
        else if (this == BaneseCardDebit) onBaneseCardDebit();
        else if (this == BaneseCardPrepaid) onBaneseCardPrepaid();
        else if (this == Bcmc) onBcmc();
        else if (this == Blik) onBlik();
        else if (this == BlikPos) onBlikPos();
        else if (this == BrSchemes) onBrSchemes();
        else if (this == Cartebancaire) onCartebancaire();
        else if (this == Clearpay) onClearpay();
        else if (this == Clicktopay) onClicktopay();
        else if (this == Cooper) onCooper();
        else if (this == CooperCredit) onCooperCredit();
        else if (this == CooperDebit) onCooperDebit();
        else if (this == CooperFoodDebit) onCooperFoodDebit();
        else if (this == CooperMealDebit) onCooperMealDebit();
        else if (this == CooperPrepaid) onCooperPrepaid();
        else if (this == CooperPrivateCredit) onCooperPrivateCredit();
        else if (this == CooperRetailCredit) onCooperRetailCredit();
        else if (this == Credtodos) onCredtodos();
        else if (this == CredtodosPrivateCredit) onCredtodosPrivateCredit();
        else if (this == CredtodosPrivateDebit) onCredtodosPrivateDebit();
        else if (this == Cup) onCup();
        else if (this == Diners) onDiners();
        else if (this == DirectdebitGb) onDirectdebitGb();
        else if (this == Discover) onDiscover();
        else if (this == EbankingFi) onEbankingFi();
        else if (this == EftDirectdebitCa) onEftDirectdebitCa();
        else if (this == EftposAustralia) onEftposAustralia();
        else if (this == Elo) onElo();
        else if (this == Elocredit) onElocredit();
        else if (this == Elodebit) onElodebit();
        else if (this == Girocard) onGirocard();
        else if (this == Givex) onGivex();
        else if (this == Googlepay) onGooglepay();
        else if (this == GreenCard) onGreenCard();
        else if (this == GreenCardCredit) onGreenCardCredit();
        else if (this == GreenCardDebit) onGreenCardDebit();
        else if (this == GreenCardFoodPrepaid) onGreenCardFoodPrepaid();
        else if (this == GreenCardMealPrepaid) onGreenCardMealPrepaid();
        else if (this == GreenCardPrepaid) onGreenCardPrepaid();
        else if (this == Hiper) onHiper();
        else if (this == Hipercard) onHipercard();
        else if (this == Ideal) onIdeal();
        else if (this == InteracCard) onInteracCard();
        else if (this == Jcb) onJcb();
        else if (this == Klarna) onKlarna();
        else if (this == KlarnaAccount) onKlarnaAccount();
        else if (this == KlarnaB2B) onKlarnaB2B();
        else if (this == KlarnaPaynow) onKlarnaPaynow();
        else if (this == LeCard) onLeCard();
        else if (this == LeCardCredit) onLeCardCredit();
        else if (this == LeCardDebit) onLeCardDebit();
        else if (this == Maestro) onMaestro();
        else if (this == MaestroUsa) onMaestroUsa();
        else if (this == Maxifrota) onMaxifrota();
        else if (this == MaxifrotaPrepaid) onMaxifrotaPrepaid();
        else if (this == Mbway) onMbway();
        else if (this == Mc) onMc();
        else if (this == Mcdebit) onMcdebit();
        else if (this == MealVoucherFr) onMealVoucherFr();
        else if (this == Megaleve) onMegaleve();
        else if (this == MegaleveCredit) onMegaleveCredit();
        else if (this == MegaleveDebit) onMegaleveDebit();
        else if (this == Mobilepay) onMobilepay();
        else if (this == Multibanco) onMultibanco();
        else if (this == Nutricash) onNutricash();
        else if (this == NutricashPrepaid) onNutricashPrepaid();
        else if (this == Nyce) onNyce();
        else if (this == OnlineBankingPl) onOnlineBankingPl();
        else if (this == Paybybank) onPaybybank();
        else if (this == PaybybankPlaid) onPaybybankPlaid();
        else if (this == Payme) onPayme();
        else if (this == PaymePos) onPaymePos();
        else if (this == Paynow) onPaynow();
        else if (this == PaynowPos) onPaynowPos();
        else if (this == Paypal) onPaypal();
        else if (this == Payto) onPayto();
        else if (this == PersonalCard) onPersonalCard();
        else if (this == PersonalCardCredit) onPersonalCardCredit();
        else if (this == PersonalCardDebit) onPersonalCardDebit();
        else if (this == Pulse) onPulse();
        else if (this == Romcard) onRomcard();
        else if (this == RomcardCredit) onRomcardCredit();
        else if (this == RomcardDebit) onRomcardDebit();
        else if (this == Senff) onSenff();
        else if (this == SenffCredit) onSenffCredit();
        else if (this == Sepadirectdebit) onSepadirectdebit();
        else if (this == Sodexo) onSodexo();
        else if (this == Star) onStar();
        else if (this == Svs) onSvs();
        else if (this == Swish) onSwish();
        else if (this == Ticket) onTicket();
        else if (this == TodoGiftcard) onTodoGiftcard();
        else if (this == Trustly) onTrustly();
        else if (this == Twint) onTwint();
        else if (this == TwintPos) onTwintPos();
        else if (this == UpBrazil) onUpBrazil();
        else if (this == UpBrazilCredit) onUpBrazilCredit();
        else if (this == UpBrazilDebit) onUpBrazilDebit();
        else if (this == UpBrazilPrepaid) onUpBrazilPrepaid();
        else if (this == ValeRefeicao) onValeRefeicao();
        else if (this == ValeRefeicaoPrepaid) onValeRefeicaoPrepaid();
        else if (this == Valuelink) onValuelink();
        else if (this == VegasCard) onVegasCard();
        else if (this == VegasCardCredit) onVegasCardCredit();
        else if (this == VegasCardDebit) onVegasCardDebit();
        else if (this == VeroCard) onVeroCard();
        else if (this == VeroCardCredit) onVeroCardCredit();
        else if (this == VeroCardDebit) onVeroCardDebit();
        else if (this == VeroCardPrepaid) onVeroCardPrepaid();
        else if (this == Vipps) onVipps();
        else if (this == Visa) onVisa();
        else if (this == Visadebit) onVisadebit();
        else if (this == Vpay) onVpay();
        else if (this == Wechatpay) onWechatpay();
        else if (this == WechatpayPos) onWechatpayPos();
        else otherwise(Value);
    }
}
