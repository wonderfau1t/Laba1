using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    public class Order
    {
        private string deviceType;
        private string deviceBrand;
        private DateTime date;
        private int priority;
        private double sum;
        private bool status;

        public Order(string deviceType, string deviceBrand, DateTime date, string priority) 
        {
            this.deviceType = deviceType;
            this.deviceBrand = deviceBrand;
            this.date = date;
            this.priority = priority == "Срочный" ? 1 : 0;
            this.status = false;
            this.sum = CalculateSum(deviceType, deviceBrand, this.priority);
        }

        private double CalculateSum(string deviceType, string deviceBrand, int priority)
        {
            const double baseSum = 1000;
            double baseMultiplier = 1.0;

            switch (deviceType)
            {
                case "Смартфон":
                    baseMultiplier += 0.75;
                    break;
                case "Планшет":
                    baseMultiplier += 1.0;
                    break;
                case "Телевизор":
                    baseMultiplier += 3.0;
                    break;
                case "Монитор":
                    baseMultiplier += 2.0;
                    break;
                default:
                    break;
            }

            switch (deviceBrand)
            {
                case "Apple":
                    baseMultiplier += 5.0;
                    break;
                case "Samsung":
                    baseMultiplier += 4.0;
                    break;
                case "Google":
                    baseMultiplier += 4.5;
                    break;
                case "Huawei":
                case "Xiaomi":
                case "Haier":
                    baseMultiplier += 3.5;
                    break;
                default:
                    break;
            }

            double calculatedSum = baseSum * baseMultiplier; 

            return priority == 0 ? calculatedSum : calculatedSum * 1.5;
        }

        public string DeviceType
        { get { return deviceType; } }

        public string DeviceBrand
        { get { return deviceBrand; } }

        public string Date
        { get { return date.ToShortDateString(); } }

        public string Sum
        { get { return $"{sum:C2}"; } }

        public string Priority
        { get { return (priority == 1) ? "Cрочный" : "Обычный" ; } }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Info()
        {
            string info = $"Устройство: {deviceType}\nМарка: {deviceBrand}\nДата приема в ремонт: {date.ToShortDateString()}\nСостояние готовности: {(status ? "Выполнен" : "Не выполнен")}\nСтоимость работ: {sum:C2}";
            return info;
        }

    }
}
