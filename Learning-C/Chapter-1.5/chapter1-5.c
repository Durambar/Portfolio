#include <stdio.h>

/* copy input to output; 1st version */
main()
{
    int c;
    long nc;

    printf("%d\n",EOF);
    
    nc = 0;
    while(getchar()!=EOF)
        ++nc;
    printf("%1d\n",nc);
    

}