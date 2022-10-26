using DistEquipment.Client.Models;
using DistEquipment.Shared;


namespace DistEquipment.Client.Services
{
    public class Calculator : ICalculator
    {
        private readonly IDataProduct _dataProduct;

        public Calculator(IDataProduct dataProduct)
        {
            _dataProduct = dataProduct;
        }
        public async Task<int> Calculate(ModelFormCalculator modelFormCalculator)
        {
            //затраты на утилизацию
            decimal disposalSolvent = 15;
            //затраты на электроэнергию
            decimal disposalElectro = 50;
           

            // получаем данные для расчета
            int volume = modelFormCalculator.Volume;
            decimal price = modelFormCalculator.PriceSolvent;
            int hour = modelFormCalculator.Hours;

            //данные по выбранному дистиллятору
           List<Product> products = await _dataProduct.GetAllDistillars(); 
           Product? product = products?.FirstOrDefault(p => p.Volume == volume);            

            //затраты на 1 литр нового сольвента
            decimal expension = Decimal.Add(price,disposalSolvent);

            //стоимость дистиллятора
            decimal? priceDistillar = product?.ProductModels[0].Price;

            //затраты на 1 литр переработанного растворителя
            decimal DistillarVolume = Convert.ToDecimal(volume);
            decimal recicleExpension = (Decimal.Add((Decimal.Multiply(price, 0.05m)), disposalElectro));

           
            //затраты в день без дистиллятора
            decimal DistillarHours = Convert.ToDecimal(hour);
            //затраты на целы бак чистого растворителя
            decimal allReciclExpension = Decimal.Multiply(expension, DistillarVolume);
            decimal expensionPerDay = Decimal.Multiply(allReciclExpension, DistillarHours);
            
            //затраты в день с дистиллятором
            decimal allDutyReciclExpension = Decimal.Multiply(recicleExpension, DistillarVolume);
            decimal expensionDistillarPerDay = Decimal.Multiply(allDutyReciclExpension, DistillarHours);
           
            //экономия в день
            decimal saveMonerPerDay = Decimal.Subtract(expensionPerDay, expensionDistillarPerDay);
         
            //окупаемость установки
            decimal finalPrice = priceDistillar ?? 0;
            decimal daysPerCosts = Decimal.Divide(finalPrice, saveMonerPerDay);
            int days =  Convert.ToInt32(daysPerCosts);
            return days;

        }

      
    }
}
