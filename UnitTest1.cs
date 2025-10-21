using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Laba_C_.Tests
{
    [TestClass]
    public class HomeApplianceTests
    {
        [TestMethod]
        public void HomeAppliance_Creation_ValidData_Success()
        {
            // Arrange & Act
            var appliance = new HomeAppliance("TestModel", "TestManu", 100.0, 2020);

            // Assert
            Assert.AreEqual("TestModel", appliance.GetModel());
            Assert.AreEqual("TestManu", appliance.GetManufacturer());
            Assert.AreEqual(100.0, appliance.GetPrice());
            Assert.AreEqual(2020, appliance.GetYear());
        }

        [TestMethod]
        public void HomeAppliance_SetPrice_NegativeValue_ThrowsException()
        {
            // Arrange
            var appliance = new HomeAppliance();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => appliance.SetPrice(-50.0));
        }

        [TestMethod]
        public void HomeAppliance_SetYear_OutOfRange_ThrowsException()
        {
            // Arrange
            var appliance = new HomeAppliance();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => appliance.SetYear(1979));
            Assert.ThrowsException<ArgumentException>(() => appliance.SetYear(2024));
        }
    }

    [TestClass]
    public class WashingMachineTests
    {
        [TestMethod]
        public void WashingMachine_Creation_ValidData_Success()
        {
            // Arrange & Act
            var wm = new WashingMachine("WM100", "Brand", 500.0, 2023, 8.0, "Front Load", 1200);

            // Assert
            Assert.AreEqual(8.0, wm.GetCapacity());
            Assert.AreEqual("Front Load", wm.GetWashType());
            Assert.AreEqual(1200, wm.GetSpinSpeed());
        }

        [TestMethod]
        public void WashingMachine_Creation_InvalidCapacity_ThrowsException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
                new WashingMachine("WM100", "Brand", 500.0, 2023, -5.0, "Front Load", 1200));
        }

        [TestMethod]
        public void WashingMachine_SetSpinSpeed_Zero_ThrowsException()
        {
            // Arrange
            var wm = new WashingMachine();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => wm.SetSpinSpeed(0));
        }
    }

    [TestClass]
    public class MicrowaveTests
    {
        [TestMethod]
        public void Microwave_Creation_ValidData_Success()
        {
            // Arrange & Act
            var microwave = new Microwave("MW200", "Brand", 200.0, 2022, 800.0, "Convection", 25);

            // Assert
            Assert.AreEqual(800.0, microwave.GetPower());
            Assert.AreEqual("Convection", microwave.GetCookingType());
            Assert.AreEqual(25, microwave.GetTurntableSize());
        }

        [TestMethod]
        public void Microwave_SetPower_Negative_ThrowsException()
        {
            // Arrange
            var microwave = new Microwave();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => microwave.SetPower(-100.0));
        }
    }

    [TestClass]
    public class InputHelperTests
    {
        [TestMethod]
        public void InputPositiveDouble_PositiveValue_ReturnsValue()
        {
            // Arrange
            // Для тестирования InputHelper потребуется мокирование консольного ввода

            // Этот тест демонстрирует концепцию, реальная реализация требует мокирования
        }
    }
}
