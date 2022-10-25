using DistEquipment.Shared;
using System.Collections.Generic;

namespace DistEquipment.Client.Services
{
    public class Calculator : ICalculator
    {
        private readonly IDataProduct _dataProduct;

        public Calculator(IDataProduct dataProduct)
        {
            _dataProduct = dataProduct;
        }
        public async Task<int> Calculate(int volume, decimal price, int hour)
        {
            //затраты на утилизацию
            decimal disposalSolvent = 15;
            //затраты на электроэнергию
            decimal disposalElectro = 50;
            
           List<Product> products = await _dataProduct.GetAllDistillars();
           
           Product? product = products?.FirstOrDefault(p => p.Volume == volume);            

            //затраты на 1 литр нового сольвента
            decimal expension = Decimal.Add(price,disposalSolvent);

            //стоимость дистиллятора
            decimal? priceDistillar = product?.ProductModels[0].Price;

            decimal DistillarVolume = Convert.ToDecimal(volume);
            Console.WriteLine($"DistillarVolume{DistillarVolume}");

            //затраты на 1 литр переработанного растворителя
            decimal recicleExpension = (Decimal.Add((Decimal.Multiply(price, 0.05m)), disposalElectro));
            Console.Write($"затраты на 1 литр переработанного растворителя {recicleExpension}");
            //затраты в день без дистиллятора
            decimal DistillarHours = Convert.ToDecimal(hour);
            Console.WriteLine($"DistillarHours{DistillarHours}");

            decimal expensionPerDay = Decimal.Multiply((Decimal.Multiply(expension, DistillarVolume)), DistillarHours);
            Console.WriteLine($"expensionPerDay{expensionPerDay}");
            //затраты в день с дистиллятором
            decimal expensionDistillarPerDay = Decimal.Multiply(Decimal.Multiply(recicleExpension, DistillarVolume), (Convert.ToDecimal(hour))));
            Console.WriteLine(expensionDistillarPerDay);
            //экономия в день
            decimal saveMonerPerDay = Decimal.Subtract(expensionPerDay, expensionDistillarPerDay);
            Console.WriteLine(saveMonerPerDay);
            //окупаемость установки
            decimal finalPrice = priceDistillar ?? 0;
            if (finalPrice != 0)
                return Convert.ToInt32(Decimal.Divide(finalPrice, saveMonerPerDay));
            else return 0;

        }

      
    }
}
