#include <stdio.h>

/* copy input to output; 1st version */
int main(void)
{
    int c;
    while(1)
    {
        c = getchar();          // Get one character from the input
        if (c==EOF) { break; }  // Exit the loop if we receive EOF ("end of file")
        putchar(c);
    }

    printf("Success!");

}