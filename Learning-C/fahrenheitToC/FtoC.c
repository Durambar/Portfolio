#include <stdio.h>

#define LOWER 0     /* lower limit of table */
#define UPPER 300   /* upper limit of table */
#define STEP 20     /* step size */

/*  print Fahrenheit - Celsius table
    for fahr = 0, 20, ..., 300 */

main()
{
    float fahr, celsius;
    int far;

    printf("Fahrenheit - Celsius\n");
    fahr=LOWER;
    while(fahr<=UPPER)
    {
        celsius = (5.0/9.0)*(fahr-32.0);
        printf("%9.0f %9.1f\n", fahr, celsius);
        fahr += STEP;
    }

    printf("\n\nCelsius - Fahrenheit\n");
    celsius = LOWER;
    while(celsius<=UPPER)
    {
        fahr = (celsius * (5.0/9.0)) + 32.0;
        printf("%7.0f %12.1f\n", celsius, fahr);
        celsius += STEP;
    }

    printf("\n\n For loop, reversed\n");
    printf("\nFahrenheit - Celsius\n");

    for(far=UPPER; far>=LOWER; far-=STEP)
        printf("%9d %9.1f\n",far,(5.0/9.0)*(far-32));
    
        
    
}