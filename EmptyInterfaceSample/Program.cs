// See https://aka.ms/new-console-template for more information

// maker interface calls

using EmptyInterfaceSample.MakerInterfaceSample;
using EmptyInterfaceSample.SuperTypeInterfaceSample.BlankInterfaceImplementation;
using Shipment = EmptyInterfaceSample.SuperTypeInterfaceSample.BlankInterfaceImplementation.Shipment;

var orderRepo = new OrderRepository();
var order = orderRepo.GetById(1);

// Empty Super Type Usage
var shipment = new Shipment { ShippingMethod = new ExpressShipping { EstimatedDeliveryDays = 2 } };

shipment.PrintShippingDetails();


// Evolved Super type usage
var standardShipping = new EmptyInterfaceSample.SuperTypeInterfaceSample.EvolvedInterfaceImplementation.StandardShipping();

standardShipping.AdvanceShippingMethod();

Console.WriteLine($"Updated Estimated Delivery Days: {standardShipping.EstimatedDeliveryDays}");

var expressShipping = new EmptyInterfaceSample.SuperTypeInterfaceSample.EvolvedInterfaceImplementation.ExpressShipping();

expressShipping.AdvanceShippingMethod();

Console.WriteLine($"Updated Estimated Delivery Days: {expressShipping.EstimatedDeliveryDays}");