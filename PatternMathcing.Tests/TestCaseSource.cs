using System;
using System.Collections.Generic;
using CommercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;
using NUnit.Framework;

namespace PatternMathcing.Tests
{
    public sealed class TestCaseSource
    {
        public static IEnumerable<TestCaseData> TestCaseForCalculationWeekends
        {
            get
            {
                yield return new TestCaseData(new Car { Passangers = 0 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 2.50m);
                yield return new TestCaseData(new Car { Passangers = 1 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 2.00m);
                yield return new TestCaseData(new Car { Passangers = 2 }, true, new DateTime(2019, 3, 9, 8, 0, 0), 1.50m);
                yield return new TestCaseData(new Car { Passangers = 3 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 1.00m);
                yield return new TestCaseData(new Taxi { Fares = 0 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 4.50m);
                yield return new TestCaseData(new Taxi { Fares = 1 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 3.50m);
                yield return new TestCaseData(new Taxi { Fares = 2 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 3.00m);
                yield return new TestCaseData(new Taxi { Fares = 4 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 2.50m);
                yield return new TestCaseData(new Bus { Riders = 0, Capacity = 50 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 7.00m);
                yield return new TestCaseData(new Bus { Riders = 22, Capacity = 50 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 7.00m);
                yield return new TestCaseData(new Bus { Riders = 49, Capacity = 50 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 4.00m);
                yield return new TestCaseData(new DeliveryTruck { GrossWeightClass = 2000 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 8.00m);
                yield return new TestCaseData(new DeliveryTruck { GrossWeightClass = 4000 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 10.00m);
                yield return new TestCaseData(new DeliveryTruck { GrossWeightClass = 20000 }, true, new DateTime(2019, 3, 9, 5, 0, 0), 15.00m);
            }
        }

        public static IEnumerable<TestCaseData> TestCaseForCalculationWordDays
        {
            get
            {
                yield return new TestCaseData(new Car { Passangers = 0 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 5.00m);
                yield return new TestCaseData(new Car { Passangers = 1 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 4.00m);
                yield return new TestCaseData(new Car { Passangers = 2 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 3.00m);
                yield return new TestCaseData(new Car { Passangers = 3 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 2.00m);
                yield return new TestCaseData(new Taxi { Fares = 0 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 9.00m);
                yield return new TestCaseData(new Taxi { Fares = 1 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 7.00m);
                yield return new TestCaseData(new Taxi { Fares = 2 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 6.00m);
                yield return new TestCaseData(new Taxi { Fares = 4 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 5.00m);
                yield return new TestCaseData(new Bus { Riders = 0, Capacity = 50 }, true, new DateTime(2019, 3, 4, 9, 0, 0), 14.00m);
                yield return new TestCaseData(new Bus { Riders = 22, Capacity = 50 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 14.00m);
                yield return new TestCaseData(new Bus { Riders = 49, Capacity = 50 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 8.00m);
                yield return new TestCaseData(new DeliveryTruck { GrossWeightClass = 2000 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 16.00m);
                yield return new TestCaseData(new DeliveryTruck { GrossWeightClass = 4000 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 20.00m);
                yield return new TestCaseData(new DeliveryTruck { GrossWeightClass = 20000 }, true, new DateTime(2019, 3, 4, 8, 0, 0), 30.00m);
            }
        }
    }
}
