
            Console.WriteLine("==================================================================");
            Console.WriteLine("EJERCICIO 3: Simulación de carga de una batería a 12.6 V");
            Console.WriteLine("==================================================================\n");

            Console.Write("Ingrese el voltaje inicial de la batería (V): ");
            double voltajeActual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el incremento de voltaje por ciclo (V): ");
            double incremento = Convert.ToDouble(Console.ReadLine());

            if (incremento <= 0)
            {
                Console.WriteLine("\n[ERROR]: El incremento debe ser un valor mayor que cero. Simulación cancelada.");
            }
            else
            {
                int ciclo = 0;
                Console.WriteLine("\n--- Iniciando Carga ---");

                
                while (voltajeActual < 12.6)
                {
                    ciclo++;
                    voltajeActual += incremento;
                    Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {voltajeActual:F2} V");
                }

                Console.WriteLine($"\nSimulación finalizada. Batería cargada completamente en {ciclo} ciclos.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        