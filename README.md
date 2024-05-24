<H1>Uso del programa:</H1>

Realicé el programa como una consola usando .NET 8.0.

El programa pide al usuario ingresar la longitud de cada fila del tablero, lo muestra pintado e indica la cantidad de cuadros pintados de rojo en cada fila.

También muestra la cantidad total de cuadros rojos y azules y consulta al usuario si desea realizar otra prueba o no. Si el usuario ingresa n o N termina la ejecución, caso contrario vuelve a pedir la nueva longitud de fila.

El código funciona para cualquier tamaño de tablero cuadrado y verifica que lo que ingrese el usuario sea un número.

<H1>Razonamiento del código y cómo llegué al resultado</H1>
Para colorear el tablero con la misma cantidad de cuadros rojos y azules sin que se repita la cantidad de cuadros pintados de rojo en cada fila primero pensé en dividir el cuadro por su bisectriz y pintar la parte inferior de la diagonal, de este modo no habría filas ni columnas que repitan la cantidad de cuadros rojos entre sí. Sin embargo, detecté que no era posible mantener el balance entre la cantidad de cuadros sin que se repitan la cantidad de colores en alguna fila o columna.

Durante las pruebas me di cuenta que introduciendo una línea de cuadros azules lograba los objetivos planteados.
