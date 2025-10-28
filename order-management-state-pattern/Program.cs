using OrderManagement.Models;

Console.Title = "Order Management System with State Pattern";

// --- Cenário 1: Fluxo de Sucesso (Happy Path) ---
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("--- SCENARIO 1: Successful Order Workflow ---");
Console.ResetColor();

var order1 = new Order(101);
Console.WriteLine($"Current State: {order1.CurrentState.GetType().Name}\n");

order1.Pay();
Console.WriteLine($"Current State: {order1.CurrentState.GetType().Name}\n");

order1.Ship();
Console.WriteLine($"Current State: {order1.CurrentState.GetType().Name}\n");

// Tentativa de ação inválida: não pode cancelar um pedido já enviado
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-> Attempting an invalid action (Cancel a shipped order)...");
order1.Cancel();
Console.ResetColor();
Console.WriteLine($"Current State: {order1.CurrentState.GetType().Name}\n");


order1.Deliver();
Console.WriteLine($"Current State: {order1.CurrentState.GetType().Name}\n");

// --- Cenário 2: Fluxo de Cancelamento ---
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n--- SCENARIO 2: Order Cancellation Workflow ---");
Console.ResetColor();

var order2 = new Order(202);
Console.WriteLine($"Current State: {order2.CurrentState.GetType().Name}\n");

order2.Cancel();
Console.WriteLine($"Current State: {order2.CurrentState.GetType().Name}\n");

// Tentativa de ação inválida: não pode pagar um pedido cancelado
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-> Attempting an invalid action (Pay for a canceled order)...");
order2.Pay();
Console.ResetColor();
Console.WriteLine($"Current State: {order2.CurrentState.GetType().Name}\n");

Console.WriteLine("Demonstration finished.");