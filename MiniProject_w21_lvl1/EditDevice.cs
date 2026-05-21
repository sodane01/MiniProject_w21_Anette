
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

class EditDevice
{
    private readonly ValidateDevices validate = new();

    public void Edit(List<Devices> devices)
    {
        Console.Write("Enter ID of device to edit: ");
        string input = Console.ReadLine()?.Trim() ?? "";

        int id = validate.ValidateExistingId(input, devices);

        //string input = Console.ReadLine()?.Trim() ?? "";

        //if (!int.TryParse(input, out int id))
        //{
        //    Console.WriteLine("Invalid ID.");
        //    return;
        //}

        var device = devices.FirstOrDefault(d => d.id == id);

        if (device == null)
        {
            Console.WriteLine("Device not found.");
            return;
        }

        //Console.Write("New brand: ");
        //device.brand = Console.ReadLine()?.Trim() ?? device.brand;
        //Console.Write("New brand: ");
        //string brandInput = Console.ReadLine()?.Trim() ?? "";
        //device.brand = validate.ValidateBrand(brandInput);
        Console.Write($"New brand ({device.brand}): ");

        input = Console.ReadLine()?.Trim() ?? "";

        if (!string.IsNullOrWhiteSpace(input))
        {
            device.brand =
                validate.ValidateBrand(input);
        }

        //Console.Write("New model: ");
        Console.Write($"New model ({device.model}): ");
        input = Console.ReadLine()?.Trim() ?? "";

        if (!string.IsNullOrWhiteSpace(input))
        {
            device.model = validate.ValidateModel(input);
        }
        //device.model = Console.ReadLine()?.Trim() ?? device.model;

        //Console.Write("New office location: ");
        //device.officeLocation = validate.ValidateOfficeLocation(Console.ReadLine()?.Trim() ?? device.officeLocation);
        //device.officeLocation = Console.ReadLine()?.Trim() ?? device.officeLocation;
        Console.Write($"New office location ({device.officeLocation}): ");

        input = Console.ReadLine()?.Trim() ?? "";

        if (!string.IsNullOrWhiteSpace(input))
        {
            device.officeLocation =
                validate.ValidateOfficeLocation(input);
        }

        //Console.Write("New purchase date (YYYY-MM-DD): ");
        //string purchaseDateInput = Console.ReadLine()?.Trim() ?? "";
        //device.purchaseDate = validate.ValidatePurchaseDate(purchaseDateInput);

        //Console.Write("New price in USD: ");
        //string priceInput = Console.ReadLine()?.Trim() ?? "";
        //device.priceUSD = validate.ValidatePrice(priceInput);
        Console.Write($"New price ({device.priceUSD}): ");

        input = Console.ReadLine()?.Trim() ?? "";

        if (!string.IsNullOrWhiteSpace(input))
        {
            device.priceUSD =
                validate.ValidatePrice(input);
        }

        Console.WriteLine("Device updated successfully.");
    }
    
}