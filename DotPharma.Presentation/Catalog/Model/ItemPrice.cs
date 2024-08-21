using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Pricing.Contracts;
using NavigatR.Validations;

namespace DotPharma.Presentation.Catalog.Model;

public sealed partial class ItemPrice : ObservableValidator, IValidator<PriceRule>, IValidator<DiscountRule>
{
    [ObservableProperty]
    private bool _canChangePrice;

    [ObservableProperty]
    private bool _canChangeDiscount;

    [ObservableProperty]
    private PriceRule _priceRule;

    [ObservableProperty]
    [Validation<ItemPrice, PriceRule>]
    private decimal _grossPrice;

    [ObservableProperty]
    private decimal _maxGrossPrice;

    [ObservableProperty]
    private decimal _minGrossPrice;

    [ObservableProperty]
    [Validation<ItemPrice, PriceRule>]
    private decimal _price;

    [ObservableProperty]
    private decimal _maxPrice;

    [ObservableProperty]
    private decimal _minPrice;

    [ObservableProperty]
    [Validation<ItemPrice, DiscountRule>]
    private decimal _discount;

    [ObservableProperty]
    private decimal _maxDiscount;

    [ObservableProperty]
    private decimal _minDiscount;

    partial void OnPriceRuleChanged(PriceRule value)
    {
        MaxGrossPrice = value.MaxPrice.NetValue;
        MinGrossPrice = value.MinPrice.NetValue;

        MaxPrice = value.MaxPrice.NetValue;
        MinPrice = value.MinPrice.NetValue;

        MaxDiscount = value.DiscountRule.MaxDiscount.Value;
        MinDiscount = value.DiscountRule.MinDiscount.Value;
    }

    public void ResetPrice()
    {
        Price = PriceRule.OriginalPrice.NetValue;
    }

    public ValidationResult Validate(PriceRule? _, ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }

    public ValidationResult Validate(DiscountRule? _, ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }
}