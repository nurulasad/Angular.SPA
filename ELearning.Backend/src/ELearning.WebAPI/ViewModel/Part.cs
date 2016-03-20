using PCS.DataModel;
using System;
namespace PCS.WebAPI.ViewModel
{
    public class Part
    {
        public int PartID { get; set; }
        public int SupplierID { get; set; }
        public string PartNo { get; set; }
        public int? PartGroupID { get; set; }
        public string NewGoodsItem { get; set; }
        public short? UnitsPerPart { get; set; }
        public float? PCSNoInStock { get; set; }
        public float? SandsNoInStock { get; set; }
        public float? StandardNoInStock { get; set; }
        public int? PartMakeID { get; set; }
        public int? PartModelID { get; set; }
        public string PartBin { get; set; }
        public string PartDescription { get; set; }
        public string SupplierName { get; set; }
        public short? PartMinimum { get; set; }
        public short? PartMaximum { get; set; }
        public decimal? PartBasicCostValue { get; set; }
        public float? PartDiscountPercent { get; set; }
        public short? PartMarkUpPercent { get; set; }
        public string PartAlternativeNumber { get; set; }
        public decimal? PartCustomCharges { get; set; }
        public DateTime? PartLastBought { get; set; }
        public DateTime? PartLastSold { get; set; }
        public bool? CanBeConsumable { get; set; }
        public bool? CanBePlant { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public string CreatedBy { get; set; }
        public bool? PartCommonlyUsed { get; set; }
        public bool? NotCounted { get; set; }
        public float? OtherCurrencyPrice { get; set; }
        public decimal? PackPriceInclGST { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public static explicit operator Part(tblPart part)
        {
            return new Part
            {
                PartID = part.PartID,
                SupplierID = part.SupplierID,
                PartNo = part.PartNo,
                PartGroupID = part.PartGroupID,
                NewGoodsItem = part.NewGoodsItem,
                UnitsPerPart = part.UnitsPerPart,
                PCSNoInStock = part.PCSNoInStock,
                SandsNoInStock = part.SandsNoInStock,
                StandardNoInStock = part.StandardNoInStock,
                PartMakeID = part.PartMakeID,
                PartModelID = part.PartModelID,
                PartBin = part.PartBin,
                PartDescription = part.PartDescription,
                SupplierName = part.SupplierName,
                PartMinimum = part.PartMinimum,
                PartMaximum = part.PartMaximum,
                PartBasicCostValue = part.PartBasicCostValue,
                PartDiscountPercent = part.PartDiscount_,
                PartMarkUpPercent = part.PartMarkUp_,
                PartAlternativeNumber = part.PartAlternativeNumber,
                PartCustomCharges = part.PartCustomCharges,
                PartLastBought = part.PartLastBought,
                PartLastSold = part.PartLastSold,
                CanBeConsumable = part.CanBeConsumable,
                CanBePlant = part.CanBePlant,
                DateOfCreation = part.DateOfCreation,
                CreatedBy = part.CreatedBy,
                PartCommonlyUsed = part.PartCommonlyUsed,
                NotCounted = part.NotCounted,
                OtherCurrencyPrice = part.OtherCurrencyPrice,
                PackPriceInclGST = part.PackPriceInclGST,
                SSMA_TimeStamp = part.SSMA_TimeStamp
            };
        }
        public static explicit operator tblPart(Part part)
        {
            return new tblPart
            {
                PartID = part.PartID,
                SupplierID = part.SupplierID,
                PartNo = part.PartNo,
                PartGroupID = part.PartGroupID,
                NewGoodsItem = part.NewGoodsItem,
                UnitsPerPart = part.UnitsPerPart,
                PCSNoInStock = part.PCSNoInStock,
                SandsNoInStock = part.SandsNoInStock,
                StandardNoInStock = part.StandardNoInStock,
                PartMakeID = part.PartMakeID,
                PartModelID = part.PartModelID,
                PartBin = part.PartBin,
                PartDescription = part.PartDescription,
                SupplierName = part.SupplierName,
                PartMinimum = part.PartMinimum,
                PartMaximum = part.PartMaximum,
                PartBasicCostValue = part.PartBasicCostValue,
                PartDiscount_ = part.PartDiscountPercent,
                PartMarkUp_ = part.PartMarkUpPercent,
                PartAlternativeNumber = part.PartAlternativeNumber,
                PartCustomCharges = part.PartCustomCharges,
                PartLastBought = part.PartLastBought,
                PartLastSold = part.PartLastSold,
                CanBeConsumable = part.CanBeConsumable,
                CanBePlant = part.CanBePlant,
                DateOfCreation = part.DateOfCreation,
                CreatedBy = part.CreatedBy,
                PartCommonlyUsed = part.PartCommonlyUsed,
                NotCounted = part.NotCounted,
                OtherCurrencyPrice = part.OtherCurrencyPrice,
                PackPriceInclGST = part.PackPriceInclGST,
                SSMA_TimeStamp = part.SSMA_TimeStamp
            };
        }
        public static Part toModel(tblPart part)
        {
            return (Part)part;
        }
    }
}
